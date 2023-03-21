//using System;
//using System.Data;
//using System.IO;
//using System.Data.SqlClient;
//using System.Data.OleDb;

//namespace SamplePrj_CSharp
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            string sqlConnectionString = "Data Source = HRPDEVCN02;Initial Catalog=ProdSupport;Provider=SQLNCLI11.1;Integrated Security=SSPI;Auto Translate=False;";
//            //var dateTable = Dts.Variables["User::ExecDates"].Value;

//            var conn = new OleDbConnectionStringBuilder(sqlConnectionString);
//            var DataSource = conn.DataSource;

//            OleDbDataAdapter oleDBDataAdapter = new OleDbDataAdapter();
//            DataTable dt = new DataTable();
//            //oleDBDataAdapter.Fill(dt, Dts.Variables["User::ExecDates"].Value);
//            dt.Columns.Add("ServerName"); 
//            dt.Columns.Add("LastRunDate");

//            DataRow dr1 = dt.NewRow();
//            dr1["ServerName"] = "HRPDEVCN02";
//            dr1["LastRunDate"] = "2022-02-16 09:57:22.3933333";
//            dt.Rows.Add(dr1);

//            DataRow dr2 = dt.NewRow();
//            dr2["ServerName"] = "HRPTSTCN02";
//            dr2["LastRunDate"] = "2020-02-18 09:57:22.3933333";
//            dt.Rows.Add(dr2);

//            DataRow[] dr3 = dt.Select("ServerName = 'HRPDEVCN02'");
//            var result = dt.AsEnumerable().Where(r => r.Field<string>("ServerName") == DataSource);

//            //var r = result.Select();
//            //var i1 = r[0].ItemArray[0].ToString();
//            //var i2 = r[0].ItemArray[0].ToString();

//            //Console.WriteLine(i1 + " - ", i2);
//            //var LastRunDate = result.Select("ServerName");

//            //Console.WriteLine("{0} - {1}", dr3[0], dr3[1]);
//            //Dts.Variables["User::LastRunDate"].Value = dr[1];

//            //foreach (DataRow row in dt.Rows)
//            //{
//            //    string ServerName;
//            //    string LastExecDate;
//            //    object[] array = row.ItemArray;
//            //    ServerName = array[0].ToString();
//            //    LastExecDate = array[1].ToString();
//            //    if (ServerName == DataSource)
//            //    {
//            //        string LastRunDate = LastExecDate;
//            //        Console.WriteLine("{0} - {1}", ServerName, LastRunDate);
//            //        //Dts.Variables["User::LastRunDate"].Value = DataSource;
//            //    }
//            //}

//            //Dts.TaskResult = (int)ScriptResults.Success;

//            public void Main()
//            {
//                //Declare variables
//                string sqlConnectionString = Dts.Variables["User::ConnectionString"].Value.ToString();
//                var dateTable = Dts.Variables["User::ExecDates"].Value;

//                var DataSource = new OleDbConnectionStringBuilder(sqlConnectionString).DataSource;
//                Dts.Variables["User::DataSource"].Value = DataSource;


//                //Populate LastExecutionDates
//                OleDbDataAdapter oleDBDataAdapter = new OleDbDataAdapter();
//                DataTable dt = new DataTable();
//                oleDBDataAdapter.Fill(dt, dateTable);

//                var result = dt.AsEnumerable().Where(r => r.Field<string>("ServerName") == DataSource).CopyToDataTable().Select();

//                var ServerName = result[0].ItemArray[0].ToString();
//                var LastRunDate = result[0].ItemArray[1].ToString();

//                //Write variables
//                Dts.Variables["User::ServerName"].Value = ServerName;
//                Dts.Variables["User::LastRunDate"].Value = LastRunDate;

//                //foreach (DataRow row in dt.Rows)
//                //{
//                //    string ServerName;
//                //    string LastExecDate;
//                //    object[] array = row.ItemArray;
//                //    ServerName = array[0].ToString();
//                //    LastExecDate = array[1].ToString();
//                //    if (ServerName == DataSource)
//                //    {
//                //        Dts.Variables["User::LastRunDate"].Value = DataSource;
//                //    }
//                //}                

//                Dts.TaskResult = (int)ScriptResults.Success;
//            }
//        }
//    }
//}