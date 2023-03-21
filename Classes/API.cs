//#region Help:  Introduction to the script task
///* The Script Task allows you to perform virtually any operation that can be accomplished in
// * a .Net application within the context of an Integration Services control flow. 
// * 
// * Expand the other regions which have "Help" prefixes for examples of specific ways to use
// * Integration Services features within this script task. */
//#endregion


//#region Namespaces
//using System;
//using System.Data;
////using Microsoft.SqlServer.Dts.Runtime;
////using System.Windows.Forms;
//using System.Net;
//using System.Net.Http;
//using System.Security.Cryptography;
//using System.Text;
//using System.IO;
//using System.Net.Security;
//using System.Security.Cryptography.X509Certificates;
//#endregion

//namespace ST_8f0b4b6e35e647fe81c2985d608d303c
//{
//    /// <summary>
//    /// ScriptMain is the entry point class of the script.  Do not change the name, attributes,
//    /// or parent of this class.
//    /// </summary>
//	//[Microsoft.SqlServer.Dts.Tasks.ScriptTask.SSISScriptTaskEntryPointAttribute]
//    public partial class ScriptMain
//    {
//        #region Help:  Using Integration Services variables and parameters in a script
//        /* To use a variable in this script, first ensure that the variable has been added to 
//         * either the list contained in the ReadOnlyVariables property or the list contained in 
//         * the ReadWriteVariables property of this script task, according to whether or not your
//         * code needs to write to the variable.  To add the variable, save this script, close this instance of
//         * Visual Studio, and update the ReadOnlyVariables and 
//         * ReadWriteVariables properties in the Script Transformation Editor window.
//         * To use a parameter in this script, follow the same steps. Parameters are always read-only.
//         * 
//         * Example of reading from a variable:
//         *  DateTime startTime = (DateTime) Dts.Variables["System::StartTime"].Value;
//         * 
//         * Example of writing to a variable:
//         *  Dts.Variables["User::myStringVariable"].Value = "new value";
//         * 
//         * Example of reading from a package parameter:
//         *  int batchId = (int) Dts.Variables["$Package::batchId"].Value;
//         *  
//         * Example of reading from a project parameter:
//         *  int batchId = (int) Dts.Variables["$Project::batchId"].Value;
//         * 
//         * Example of reading from a sensitive project parameter:
//         *  int batchId = (int) Dts.Variables["$Project::batchId"].GetSensitiveValue();
//         * */

//        #endregion

//        #region Help:  Firing Integration Services events from a script
//        /* This script task can fire events for logging purposes.
//         * 
//         * Example of firing an error event:
//         *  Dts.Events.FireError(18, "Process Values", "Bad value", "", 0);
//         * 
//         * Example of firing an information event:
//         *  Dts.Events.FireInformation(3, "Process Values", "Processing has started", "", 0, ref fireAgain)
//         * 
//         * Example of firing a warning event:
//         *  Dts.Events.FireWarning(14, "Process Values", "No values received for input", "", 0);
//         * */
//        #endregion

//        #region Help:  Using Integration Services connection managers in a script
//        /* Some types of connection managers can be used in this script task.  See the topic 
//         * "Working with Connection Managers Programatically" for details.
//         * 
//         * Example of using an ADO.Net connection manager:
//         *  object rawConnection = Dts.Connections["Sales DB"].AcquireConnection(Dts.Transaction);
//         *  SqlConnection myADONETConnection = (SqlConnection)rawConnection;
//         *  //Use the connection in some code here, then release the connection
//         *  Dts.Connections["Sales DB"].ReleaseConnection(rawConnection);
//         *
//         * Example of using a File connection manager
//         *  object rawConnection = Dts.Connections["Prices.zip"].AcquireConnection(Dts.Transaction);
//         *  string filePath = (string)rawConnection;
//         *  //Use the connection in some code here, then release the connection
//         *  Dts.Connections["Prices.zip"].ReleaseConnection(rawConnection);
//         * */
//        #endregion


//        /// <summary>
//        /// This method is called when this script task executes in the control flow.
//        /// Before returning from this method, set the value of Dts.TaskResult to indicate success or failure.
//        /// To open Help, press F1.
//        /// </summary>
//        public static void Main()
//        {
//            try
//            {
//                //string URL_PackageVariable = Dts.Variables["User::URL"].Value.ToString();
//                //string Username_PackageVariable = Dts.Variables["User::UserName"].Value.ToString();
//                //string Key_PackageVariable = Dts.Variables["User::Key"].Value.ToString();
//                //string Filepath_PackageVariable = Dts.Variables["User::FileOutputLocMediConnect"].Value.ToString();
//                //string URL_notify_PackageVariable = Dts.Variables["User::SoapAction"].Value.ToString();
//                //string Extract_Type_PackageVariable = Dts.Variables["User::ExtractType_lower"].Value.ToString();

//                string Username_PackageVariable = "mrd.image";
//                string Key_PackageVariable = "iUxT8s8PP5+o9GDoXgOYM4QX94uvRCMMQwEUOrWAf2nxTgykdiJH99I0GUJAT8J9kdcemS1pNK+xKL0JPvOSbAYXO5xM3XCZnSlLP+I1VOE=";
//                string Filepath_PackageVariable = "\\\\w1p01-dfsstr.mediconnect.net\\shares\\RAPID\\ChartNav\\Aetna\\QA\\";
//                string URL_notify_PackageVariable = "https://qa-rqiapi.mediconnect.net/v1/MedicalRecordDelivery/Notify";
//                string Extract_Type_PackageVariable = "standard";

//                bool IsCorrection = true;

//                var request = new RapidRequest()
//                {
//                    FilePath = Filepath_PackageVariable,
//                    Url = URL_notify_PackageVariable,
//                    UserName = Username_PackageVariable,
//                    PrivateKey = Key_PackageVariable,
//                    IsCorrection = IsCorrection
//                };
//                var response = PostRequest(request);

//                String StatusCode = response.StatusCode;
//                //Dts.Variables["User::StatusCode"].Value = StatusCode;

//                String StatusMessage = response.StatusMessage;
//                //Dts.Variables["User::StatusMessage"].Value = StatusMessage;


//                Console.WriteLine(StatusCode);
//                Console.WriteLine(StatusMessage);

//                //Dts.TaskResult = (int)ScriptResults.Success;

//            }

//            catch (Exception ex)
//            {
//                //An error occurred.
//                Console.WriteLine(ex.Message);
//                //Dts.Events.FireError(0, "Script Task Example", ex.Message + "\r" + ex.StackTrace, String.Empty, 0);
//                //Dts.TaskResult = (int)ScriptResults.Failure;
//            }

//        }

//        public static RapidResponse PostRequest(RapidRequest request)
//        {
//            var response = new RapidResponse("200", "Ok");

//            //var httpClient = new HttpClient();

//            var payload = string.Format("{{\"FilePath\":\"{0}\", \"IsCorrection\":\"{1}\"}}", EscapeJsonPathString(request.FilePath), request.IsCorrection);
//            Console.WriteLine(payload);

//            // full-path URI concatenating the API authority and the API end-point
//            var fullUri = new Uri(request.Url);

//            // create the request
//            HttpRequestMessage req = new HttpRequestMessage
//            {
//                Method = HttpMethod.Post,
//                RequestUri = fullUri
//            };

//            // set Auth header
//            var auth = GenerateAuthTokenEncodedUserSignature(fullUri, request.UserName, request.PrivateKey, payload);
//            req.Headers.TryAddWithoutValidation("Authorization", auth);

//            // set Content of message
//            req.Content = new StringContent(payload, Encoding.UTF8, "application/json");

//            // set Accept header
//            req.Headers.Accept.ParseAdd("application/json");

//            try
//            {
//                using (var httpClientHandler = new HttpClientHandler())
//                {
//                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
//                    {
//                        return true;
//                    };

//                    var httpClient = new HttpClient(httpClientHandler);

//                    var httpResponse = httpClient.SendAsync(req).Result;
//                    if (!httpResponse.IsSuccessStatusCode)
//                    {
//                        var statusMessage = httpResponse.Content.ReadAsStringAsync().Result;
//                        response = new RapidResponse(httpResponse.StatusCode.ToString(), statusMessage);
//                    }
//                }

//                //var httpResponse = httpClient.SendAsync(req).Result;
//                //if (!httpResponse.IsSuccessStatusCode)
//                //{
//                //    var statusMessage = httpResponse.Content.ReadAsStringAsync().Result;
//                //    response = new RapidResponse(httpResponse.StatusCode.ToString(), statusMessage);
//                //}
//            }
//            catch (Exception ex)
//            {
//                response = GetResponseFromException(ex);
//            }

//            return response;
//        }

//        public static string GenerateAuthTokenEncodedUserSignature(Uri uri, string username, string privateKey, string data)
//        {
//            var decodedPathAndQuery = WebUtility.UrlDecode(uri.PathAndQuery);

//            //build the string that will be used to create the signature
//            var signatureContent = new StringBuilder(decodedPathAndQuery);
//            signatureContent.Append((decodedPathAndQuery.Contains("?")) ? "&" : "?");
//            signatureContent.Append(data);

//            // generate signature
//            var signatureContentString = RemoveWhiteSpace(signatureContent.ToString());
//            var signature = GetHmacSha1Signature(signatureContentString, privateKey);

//            // build auth token using username and signature
//            var contentToEncode = string.Format("user {0}:{1}", username, signature);
//            string base64EncodedAuthHeaderValue =
//                Convert.ToBase64String(Encoding.ASCII.GetBytes(contentToEncode));

//            return base64EncodedAuthHeaderValue;
//        }

//        public static string EscapeJsonPathString(string s)
//        {
//            return s.Replace("\\", "\\\\");
//        }

//        public static string RemoveWhiteSpace(string input)
//        {
//            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
//            var sb = new StringBuilder(input.Length);
//            foreach (var c in input)
//            {
//                if (!char.IsWhiteSpace(c))
//                {
//                    sb.Append(c);
//                }
//            }
//            return sb.ToString();
//        }

//        public static string GetHmacSha1Signature(string contentToHash, string privateKey)
//        {
//            var encoding = new ASCIIEncoding();

//            byte[] contentBytes = encoding.GetBytes(contentToHash);
//            byte[] privateKeyBytes = encoding.GetBytes(privateKey);

//            var hashAlgorithm = new HMACSHA1(privateKeyBytes);
//            byte[] computedHashBytes = hashAlgorithm.ComputeHash(contentBytes);

//            string signature = Convert.ToBase64String(computedHashBytes);

//            return signature;
//        }

//        public static RapidResponse GetResponseFromException(Exception ex)
//        {
//            if (ex is AggregateException)
//            {
//                if (ex.InnerException != null)
//                {
//                    var webEx = ex.InnerException.InnerException as WebException;

//                    if (webEx != null)
//                    {
//                        return new RapidResponse(HttpStatusCode.ServiceUnavailable.ToString(), webEx.Message);
//                    }
//                }
//            }
//            else
//            {
//                return new RapidResponse(HttpStatusCode.ServiceUnavailable.ToString(), ex.Message);
//            }

//            return new RapidResponse("Unknown", "Unknown");
//        }

//        public class RapidRequest
//        {
//            public string Url { get; set; }
//            public string UserName { get; set; }
//            public string PrivateKey { get; set; }
//            public string FilePath { get; set; }
//            public bool IsCorrection { get; set; }
//        }

//        public class RapidResponse
//        {
//            public RapidResponse(string code, string message)
//            {
//                StatusCode = code;
//                StatusMessage = message;
//            }

//            public string StatusCode { get; set; }
//            public string StatusMessage { get; set; }
//        }


//        #region ScriptResults declaration
//        /// <summary>
//        /// This enum provides a convenient shorthand within the scope of this class for setting the
//        /// result of the script.
//        /// 
//        /// This code was generated automatically.
//        /// </summary>
//        //enum ScriptResults
//        //{
//        //    Success = Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Success,
//        //    Failure = Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Failure
//        //};
//        #endregion

//    }
//}
