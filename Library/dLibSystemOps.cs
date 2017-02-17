using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Management;
using System.IO;
using System.Globalization;
using System.Windows;
using System.Diagnostics;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;

using dLibAdJobs;

namespace sysOps
{
    class dLibSystemOps
    {
        public dLibSystemOps()
        {
            // this.Processor = new stationHardwareCpu.CpuData();
            // this.Memory = new stationHardwareMemory.Memory();
        }

        // Data Enumerator Method
        public static ManagementObjectSearcher wmiQuery(string iFieldName, string iClass)
        {
            ManagementObjectSearcher wmiQueryDataObj;
            wmiQueryDataObj = new ManagementObjectSearcher("select " + iFieldName + " from " + iClass);
            return wmiQueryDataObj;
        }

        #region Common Functions
        // Reg Write/Read OPS --------------------
        //Take a Keyname, ValueName and Content and Write/Read to Registry Based on ACT operation   
        // Operation (act): 0 Write, 1 Read                                                         
        public static String registryOps(string keyName, string valueName, string content, int act)
        {
            Microsoft.Win32.RegistryKey key;
            String res = "";
            switch (act)
            {
                case 0:
                    try
                    {
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(keyName);
                        key.SetValue(valueName, content);
                        key.Close();
                        break;
                    }
                    catch { return "error"; }
                case 1:
                    try
                    {
                        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyName);
                        res = (string)key.GetValue(valueName);
                        key.Close();
                        break;
                    }
                    catch { return "error"; }
            }
            return res;
        }
        // End Reg Write/Read OPS --------------------

        // File Copy Ops -----------------------------
        public static Boolean fileCopy(string fSource, string fDestiny, string fileTypes, int act)
        {
            try
            {
                if (!Directory.Exists(fDestiny))
                {
                    System.IO.Directory.CreateDirectory(fDestiny);
                }

                foreach (var file in Directory.GetFiles(fSource))
                {
                    //Console.WriteLine(Path.GetExtension(file).ToString());
                    if (fileTypes.Contains(Path.GetExtension(file).ToString()))
                    {
                        //Console.WriteLine("Copying... " + file);
                        System.IO.File.Copy(file, Path.Combine(fDestiny, Path.GetFileName(file)), true);
                        //FMove(file, Path.Combine(fDestiny, Path.GetFileName(file)));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "dLibSystemOps - fileCopy";
                appLog.Log = ex.Message;
                appLog.WriteEntry("fileCopy \n\n" +
                    "General Failure copying Lotus Notes DATA " +
                    "Data: " + fSource + " " + fDestiny + " " + fileTypes +
                    "\n\nMessage: " + ex.Message +
                    "\n\nSource: " + ex.Source +
                    "\n\nStack: " + ex.StackTrace +
                    "\n\nTarget: " + ex.TargetSite, EventLogEntryType.FailureAudit, 3012, 02);


                MessageBox.Show("dLibSystemOps - fileCopy \n\n" +
                    "General Failure copying Lotus Notes DATA " +
                    "\n\nMessage: " + ex.Message +
                    "\n\nSource: " + ex.Source +
                    "\n\nStack: " + ex.StackTrace +
                    "\n\nTarget: " + ex.TargetSite, "Information: Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
            }
            return true;
        }

        public static Boolean fileCopyFiltered(string fSource, string fDestiny, string[] files)
        {
            if (!Directory.Exists(fDestiny))
            {
                System.IO.Directory.CreateDirectory(fDestiny);
            }

            foreach (var file in Directory.GetFiles(fSource))
            {
                //Console.WriteLine(Path.GetExtension(file).ToString());
                if (files.Contains(Path.GetFileName(file)))
                {
                    //Console.WriteLine("Copying... " + file);
                    System.IO.File.Copy(file, Path.Combine(fDestiny, Path.GetFileName(file)), true);
                    //FMove(file, Path.Combine(fDestiny, Path.GetFileName(file)));
                }
            }
            return true;
        }

        public static void FMove(string source, string destination)
        {
            int array_length = (int)Math.Pow(2, 19);
            byte[] dataArray = new byte[array_length];
            using (FileStream fsread = new FileStream
            (source, FileMode.Open, FileAccess.Read, FileShare.None, array_length))
            {
                using (BinaryReader bwread = new BinaryReader(fsread))
                {
                    using (FileStream fswrite = new FileStream
                    (destination, FileMode.Create, FileAccess.Write, FileShare.None, array_length))
                    {
                        using (BinaryWriter bwwrite = new BinaryWriter(fswrite))
                        {
                            for (; ; )
                            {
                                int read = bwread.Read(dataArray, 0, array_length);
                                if (0 == read)
                                    break;
                                bwwrite.Write(dataArray, 0, read);
                            }
                        }
                    }
                }
            }
            ////File.Delete(source);
            //const int CopyBufferSize = 64 * 1024;

            //using (var outputFile = File.OpenWrite(destination))
            //{
            //    using (var inputFile = File.OpenRead(source))
            //    {
            //        var buffer = new byte[CopyBufferSize];
            //        int bytesRead;
            //        while ((bytesRead = inputFile.Read(buffer, 0, CopyBufferSize)) != 0)
            //        {
            //            outputFile.Write(buffer, 0, bytesRead);
            //        }
            //    }

            //}
        }
        // End File Copy Ops -------------------------

        // File Sync Ops -----------------------------
        public static int syncFiles(string fSource, string fDestiny, string[] files, int act)
        {
            int result = 0;
            string direction = "";
            try
            {
                switch (act)
                {
                    case 0:
                        foreach (string file in files)
                        {
                            System.IO.FileInfo currentSourceFile = new System.IO.FileInfo(Path.Combine(fSource, file));
                            System.IO.FileInfo currentDestinyFile = new System.IO.FileInfo(Path.Combine(fDestiny, file));
                            if (currentSourceFile.LastWriteTime > currentDestinyFile.LastWriteTime)
                            {
                                //Console.WriteLine("Source > Destiny " + currentSourceFile + " " + currentDestinyFile);
                                //System.IO.File.Delete(currentDestinyFile.FullName);                          
                                System.IO.File.Copy(currentSourceFile.FullName, currentDestinyFile.FullName, true);
                                //FMove(currentSourceFile.FullName, currentDestinyFile.FullName);
                                direction = "Source: " + currentSourceFile + " > Destiny: " + currentDestinyFile;
                                result = 1;
                            }
                            else
                            {
                                if (currentSourceFile.LastWriteTime < currentDestinyFile.LastWriteTime)
                                {
                                    //Console.WriteLine("Destiny > Source" + currentDestinyFile + " " + currentSourceFile);
                                    //System.IO.File.Delete(currentSourceFile.FullName);                               
                                    System.IO.File.Copy(currentDestinyFile.FullName, currentSourceFile.FullName, true);
                                    //FMove(currentDestinyFile.FullName, currentSourceFile.FullName);
                                    result = 2;
                                    direction = "Destiny: " + currentSourceFile + " > Source: " + currentDestinyFile;
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "dLibSystemOps - syncFiles";
                appLog.Log = ex.Message;
                appLog.WriteEntry("syncFiles \n\n" +
                    "General Failure syncing Lotus Notes DATA " +
                    "Direction: " + direction +
                    "\n\nMessage: " + ex.Message +
                    "\n\nSource: " + ex.Source +
                    "\n\nStack: " + ex.StackTrace +
                    "\n\nTarget: " + ex.TargetSite, EventLogEntryType.FailureAudit, 3012, 02);


                MessageBox.Show("dLibSystemOps - syncFiles \n\n" +
                    "General Failure syncing Lotus Notes DATA " +
                    "\n\nMessage: " + ex.Message +
                    "\n\nSource: " + ex.Source +
                    "\n\nStack: " + ex.StackTrace +
                    "\n\nTarget: " + ex.TargetSite, "Information: Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
            }
            return result;
        }
        // End File Sync Ops -------------------------



        #endregion

        // User Related OPS---------------------------
        public class loggedUser
        {
            // Data objects Definitions---------------
            public class loggedUserData
            {
                public int LogonId { get; set; }
                public int LogonType { get; set; }
                public DateTime LogonTime { get; set; }
                public string Status { get; set; }
                public string LogonServer { get; set; }
                public string Province { get; set; }
                public TimeSpan SessionTimeSpam { get; set; }
                public loggedUserData()
                {
                    this.LogonTime = LoggedUSerOps.getLogonTime();
                    this.SessionTimeSpam = LoggedUSerOps.getSessionTimeSpan(DateTime.Now);
                    //this.SessionTimeSpam = TimeSpan.FromSeconds(30);
                    this.LogonServer = LoggedUSerOps.getLogonServer();
                    this.Province = LoggedUSerOps.getProvince();
                }
            }
            // ---------------------------------------

            // Data methods Definitions---------------
            public static class LoggedUSerOps
            {
                public static DateTime getLogonTime()
                {
                    ManagementScope ms = new ManagementScope("\\root\\cimv2");
                    ObjectQuery oq = new ObjectQuery("Select * from Win32_LogonSession");
                    ManagementObjectSearcher query = new ManagementObjectSearcher(ms, oq);
                    ManagementObjectCollection queryCollection = query.Get();
                    DateTime dt = new DateTime();

                    foreach (ManagementObject mo in queryCollection)
                    {
                        //Debug.WriteLine(mo["LogonType"].ToString());
                        //Debug.WriteLine(mo["LogonId"].ToString());
                        if ((mo["LogonType"].ToString().Equals("2") | mo["LogonType"].ToString().Equals("10")))          //  2 - for logged on User - 10 - rdp user
                        {
                            ObjectQuery LQuery = new ObjectQuery("Associators of {Win32_LogonSession.LogonId=" + mo["LogonId"] + "} Where AssocClass=Win32_LoggedOnUser Role=Dependent");
                            ManagementObjectSearcher LSearcher = new ManagementObjectSearcher(ms, LQuery);
                            foreach (ManagementObject LWmiObject in LSearcher.Get())
                            {
                                if (LWmiObject["Name"].ToString().ToUpper().Contains(System.Environment.UserName.ToUpper()))
                                {
                                    //Debug.WriteLine(LWmiObject["Name"]);
                                    dt = ManagementDateTimeConverter.ToDateTime(mo["StartTime"].ToString());
                                }
                            }
                            break;
                        }
                    }
                    return dt;
                }


                public static TimeSpan getSessionTimeSpan(DateTime fDateTime)
                {
                    TimeSpan sessionTimeSpan = fDateTime.Subtract(getLogonTime());
                    return sessionTimeSpan;
                }

                public static string getLogonServer()
                {
                    string logonServer = System.Environment.GetEnvironmentVariable("logonserver").ToString();
                    return System.Environment.GetEnvironmentVariable("logonserver").ToString().Substring(2, logonServer.Length - 2);
                }
                public static string getProvince()
                {
                    string province = System.Environment.GetEnvironmentVariable("logonserver").ToString().ToLower();
                    string provinceFormated = province.Substring(2, (province.Length - 2) - 4);
                    switch (provinceFormated)
                    {
                        case "corp":
                            province = "Botafogo";
                            break;

                        default:
                            province = provinceFormated;
                            break;
                    }

                    return province;
                }
            }

            // ---------------------------------------
        }
        //End  User Related OPS-----------------------

        //Static Checks
        private static bool DomainExist(string domain)
        {
            HashSet<string> domains = new HashSet<string>();
            Boolean isDomainFound = false;
            try
            {
                foreach (Domain d in Forest.GetCurrentForest().Domains)
                {
                    domains.Add(d.Name.ToLower());
                }
                isDomainFound = domains.Contains(domain.ToLower());
            }
            catch
            {
              
            }
            return isDomainFound;
        }
    }
}
