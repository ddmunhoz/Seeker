using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.DirectoryServices;
using System.IO;

namespace dLibProcessMng
{
    class dLibProcess
    {
        public DataTable findProcess(string iMachine, string iUser, string iPassword)
        {
            string[] columnNames = { "Caption", "Owner", "Description", "Name", "Priority", "ProcessID", "SessionId" };
            DataTable dt = new DataTable();
            Hashtable hs = new Hashtable();

            ManagementScope myScope;
            ConnectionOptions connOptions;
            ManagementObjectSearcher objSearcher;
            ManagementOperationObserver opsObserver;

            for (int i = 0; i < columnNames.Length; i++)
            {
                //dc[i] = new DataColumn(columnNames[i], typeof(string));
                dt.Columns.Add(columnNames[i], typeof(string));
            }


            connOptions = new ConnectionOptions();
            connOptions.Impersonation = ImpersonationLevel.Impersonate;
            connOptions.EnablePrivileges = true;

            if (iMachine.ToUpper() == Environment.MachineName.ToUpper())
            {
                myScope = new ManagementScope(@"\ROOT\CIMV2", connOptions);
            }
            else
            {
                connOptions.Username = iUser;
                connOptions.Password = iPassword;
                myScope = new ManagementScope(@"\\" + iMachine + @"\ROOT\CIMV2", connOptions);
            }

            try
            {

                myScope.Connect();
                objSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
                opsObserver = new ManagementOperationObserver();
                objSearcher.Scope = myScope;
                string[] sep = { "\n", "\t" };
                dt.Rows.Clear();
                foreach (ManagementObject obj in objSearcher.Get())
                {
                    string[] processInfo = { "", "", "", "", "", "", "" };
                    string caption = obj.GetText(TextFormat.Mof);
                    string[] methodArgs = { "", "" };
                    obj.InvokeMethod("GetOwner", methodArgs);
                    string[] split = caption.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    // Iterate through the splitter
                    for (int i = 0; i < split.Length; i++)
                    {
                        if (split[i].Split('=').Length > 1)
                        {
                            string[] procDetails = split[i].Split('=');
                            procDetails[1] = procDetails[1].Replace(@"""", "");
                            procDetails[1] = procDetails[1].Replace(';', ' ');
                            switch (procDetails[0].Trim().ToLower())
                            {
                                case "caption":

                                    processInfo[0] = procDetails[1];
                                    break;
                                case "CSName":
                                    // dr[dc[1]] = procDetails[1];
                                    break;
                                case "description":
                                    processInfo[2] = procDetails[1];
                                    break;
                                case "name":
                                    processInfo[3] = procDetails[1];
                                    break;
                                case "priority":
                                    processInfo[4] = procDetails[1];
                                    break;
                                case "processid":
                                    processInfo[5] = procDetails[1];
                                    break;
                                case "sessionid":
                                    processInfo[6] = procDetails[1];
                                    break;
                            }
                        }
                    }
                    if (methodArgs[0] != null)
                    {
                        processInfo[1] = methodArgs[0];
                    }
                    dt.Rows.Add(processInfo[0], processInfo[1], processInfo[2], processInfo[3], processInfo[4], processInfo[5], processInfo[6]);
                }
            }
            catch
            {

            }

            return dt;
        }
    }
}
