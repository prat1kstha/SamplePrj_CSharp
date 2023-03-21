#region Help:  Introduction to the script task
/* The Script Task allows you to perform virtually any operation that can be accomplished in
 * a .Net application within the context of an Integration Services control flow. 
 * 
 * Expand the other regions which have "Help" prefixes for examples of specific ways to use
 * Integration Services features within this script task. */
#endregion


#region Namespaces
using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.IO;
#endregion

namespace ST_8f0b4b6e35e647fe81c2985d608d303c
{
    /// <summary>
    /// ScriptMain is the entry point class of the script.  Do not change the name, attributes,
    /// or parent of this class.
    /// </summary>
    public partial class ScriptMain
    {
        public void Main()
        {
            try
            {
                //    string Filepath_PackageVariable = Dts.Variables["User::MediconnectOutboundFolder"].Value.ToString();
                //    string Username_PackageVariable = Dts.Variables["User::MediconnectAPIUserID"].Value.ToString();
                //    string Key_PackageVariable = Dts.Variables["User::MediconnectAPIKey"].Value.ToString();
                //    string FileName_PackageVariable = Dts.Variables["User::FileName"].Value.ToString();
                //    string URL_notify_PackageVariable = Dts.Variables["User::MediconnectAPINotifyEndPoint"].Value.ToString();
                //    string Extract_Type_PackageVariable = Dts.Variables["User::RunType"].Value.ToString();

                string Username_PackageVariable = "mrd.image";
                //string Key_PackageVariable = "iUxT8s8PP5+o9GDoXgOYM4QX94uvRCMMQwEUOrWAf2nxTgykdiJH99I0GUJAT8J9kdcemS1pNK+xKL0JPvOSbAYXO5xM3XCZnSlLP+I1VOE=";
                string Key_PackageVariable = "lRQEedSmmn7bQoe9pB6o4kt4D0ye8cAdoXwvYQA8s/iJs1ciNkh2VDMJw195VObT";
                string Filepath_PackageVariable = "\\\\w1p01-dfsstr.mediconnect.net\\shares\\RAPID\\ChartNav\\Aetna\\UAT";
                string URL_notify_PackageVariable = "https://uatrqiapi.mediconnect.net/v1/MedicalRecordDelivery/Notify";
                string Extract_Type_PackageVariable = "standard";
                string FileName_PackageVariable = "CO_CodingDetail_2023002_0_20230213.txt";

                string FileType = Extract_Type_PackageVariable == "standard" ? "CDF" : "FileOnly";


                var request = new RapidRequest()
                {
                    FilePath = Filepath_PackageVariable,
                    Url = URL_notify_PackageVariable,
                    UserName = Username_PackageVariable,
                    PrivateKey = Key_PackageVariable,
                    FileType = FileType,
                    FileName = FileName_PackageVariable
                };
                var response = PostRequest(request);

                String StatusCode = response.StatusCode;
                //Dts.Variables["User::StatusCode"].Value = StatusCode;

                String StatusMessage = response.StatusMessage;
                //Dts.Variables["User::StatusMessage"].Value = StatusMessage;

                Console.WriteLine(StatusCode);
                Console.WriteLine(StatusMessage);
                //Dts.TaskResult = (int)ScriptResults.Success;

            }

            catch (Exception ex)
            {
                //An error occurred.
                Console.WriteLine(ex.Message);
                //Dts.Events.FireError(0, "Script Task Example", ex.Message + "\r" + ex.StackTrace, String.Empty, 0);
                //Dts.TaskResult = (int)ScriptResults.Failure;
            }

        }

        public static RapidResponse PostRequest(RapidRequest request)
        {
            var response = new RapidResponse("200", "Ok");

            var httpClient = new HttpClient();

            //var payload = string.Format("{{\"FilePath\":\"{0}\", \"IsCorrection\":\"{1}\"}}", EscapeJsonPathString(request.FilePath), request.IsCorrection);
            var payload = string.Format("{{" +
                "\"FilePath\":\"{0}\"," +
                "\"FileName\":\"{1}\"," +
                "\"FileType\":\"{2}\"," +
                "\"CustomerName\":\"CodeLogix\"" +
                "}}", EscapeJsonPathString(request.FilePath), request.FileName, request.FileType);

            Console.WriteLine(payload);

            // full-path URI concatenating the API authority and the API end-point
            var fullUri = new Uri(request.Url);

            // create the request
            HttpRequestMessage req = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = fullUri
            };

            // set Auth header
            var auth = GenerateAuthTokenEncodedUserSignature(fullUri, request.UserName, request.PrivateKey, payload);
            req.Headers.TryAddWithoutValidation("Authorization", auth);

            // set Content of message
            req.Content = new StringContent(payload, Encoding.UTF8, "application/json");

            // set Accept header
            req.Headers.Accept.ParseAdd("application/json");

            try
            {
                var httpResponse = httpClient.SendAsync(req).Result;
                if (!httpResponse.IsSuccessStatusCode)
                {
                    var statusMessage = httpResponse.Content.ReadAsStringAsync().Result;
                    response = new RapidResponse(httpResponse.StatusCode.ToString(), statusMessage);
                }
            }
            catch (Exception ex)
            {
                response = GetResponseFromException(ex);
            }

            return response;
        }

        public static string GenerateAuthTokenEncodedUserSignature(Uri uri, string username, string privateKey, string data)
        {
            var decodedPathAndQuery = WebUtility.UrlDecode(uri.PathAndQuery);

            //build the string that will be used to create the signature
            var signatureContent = new StringBuilder(decodedPathAndQuery);
            signatureContent.Append((decodedPathAndQuery.Contains("?")) ? "&" : "?");
            signatureContent.Append(data);

            // generate signature
            var signatureContentString = RemoveWhiteSpace(signatureContent.ToString());
            var signature = GetHmacSha1Signature(signatureContentString, privateKey);

            // build auth token using username and signature
            var contentToEncode = string.Format("user {0}:{1}", username, signature);
            string base64EncodedAuthHeaderValue =
                Convert.ToBase64String(Encoding.ASCII.GetBytes(contentToEncode));

            return base64EncodedAuthHeaderValue;
        }

        public static string EscapeJsonPathString(string s)
        {
            return s.Replace("\\", "\\\\");
        }

        public static string RemoveWhiteSpace(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            var sb = new StringBuilder(input.Length);
            foreach (var c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string GetHmacSha1Signature(string contentToHash, string privateKey)
        {
            var encoding = new ASCIIEncoding();

            byte[] contentBytes = encoding.GetBytes(contentToHash);
            byte[] privateKeyBytes = encoding.GetBytes(privateKey);

            var hashAlgorithm = new HMACSHA1(privateKeyBytes);
            byte[] computedHashBytes = hashAlgorithm.ComputeHash(contentBytes);

            string signature = Convert.ToBase64String(computedHashBytes);

            return signature;
        }

        public static RapidResponse GetResponseFromException(Exception ex)
        {
            if (ex is AggregateException)
            {
                if (ex.InnerException != null)
                {
                    var webEx = ex.InnerException.InnerException as WebException;

                    if (webEx != null)
                    {
                        return new RapidResponse(HttpStatusCode.ServiceUnavailable.ToString(), webEx.Message);
                    }
                }
            }
            else
            {
                return new RapidResponse(HttpStatusCode.ServiceUnavailable.ToString(), ex.Message);
            }

            return new RapidResponse("Unknown", "Unknown");
        }

        public class RapidRequest
        {
            public string Url { get; set; }
            public string UserName { get; set; }
            public string PrivateKey { get; set; }
            public string FilePath { get; set; }
            public string FileName { get; set; }
            public string FileType { get; set; }
        }

        public class RapidResponse
        {
            public RapidResponse(string code, string message)
            {
                StatusCode = code;
                StatusMessage = message;
            }

            public string StatusCode { get; set; }
            public string StatusMessage { get; set; }
        }
    }
}