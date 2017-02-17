using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seeker;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace dLibSeekerSessions
{
    public class seekerSessions
    {
        public string SessionID { get; set; }
        public DateTime SessionDate { get; set; }
        public string Description { get; set; }
        public List<seekerObjects> Objects { get; set; }
        public seekerSessions()
        {
            Random rndSession = new Random();

            this.SessionDate = DateTime.Now;
            this.SessionID = frmMain.domainAccountData[1] + "-" + SessionDate.ToString("yyyyMMddmmss") + "-" + rndSession.Next(0, 1000);
            this.Objects = new List<seekerObjects>();
        }



        public static void sessionsLauncher(seekerSessions sessionsToLaunch)
        {
            foreach (seekerObjects sessionObj in sessionsToLaunch.Objects)
            {
                switch (sessionObj.Type)
                {
                    case seekerObjectType.AD_Computer:
                        frmSeekComputer computerToSeek = new frmSeekComputer();
                        computerToSeek.machineToQuery = sessionObj.QueryData;
                        computerToSeek.WindowState = FormWindowState.Normal;
                        computerToSeek.StartPosition = FormStartPosition.Manual;
                        computerToSeek.Location = sessionObj.ScreenPos;
                        computerToSeek.Show();
                        break;

                    case seekerObjectType.AD_User:
                        frmSeek userToSeek = new frmSeek();
                        userToSeek.userToQuery = sessionObj.QueryData;
                        userToSeek.WindowState = FormWindowState.Normal;
                        userToSeek.StartPosition = FormStartPosition.Manual;
                        userToSeek.Location = sessionObj.ScreenPos;
                        userToSeek.Show();
                        break;

                    case seekerObjectType.AD_Group:
                        frmSeekGroup frmSeekGroup = new frmSeekGroup();
                        frmSeekGroup.groupToQuery = sessionObj.QueryData;
                        frmSeekGroup.WindowState = FormWindowState.Normal;
                        frmSeekGroup.StartPosition = FormStartPosition.Manual;
                        frmSeekGroup.Location = sessionObj.ScreenPos;
                        frmSeekGroup.Show();
                        break;

                    case seekerObjectType.AD_OrganizationalUnit:
                        frmSeekOu frmSeekOu = new frmSeekOu();
                        frmSeekOu.ouToQuery = sessionObj.QueryData;
                        frmSeekOu.WindowState = FormWindowState.Normal;
                        frmSeekOu.StartPosition = FormStartPosition.Manual;
                        frmSeekOu.Location = sessionObj.ScreenPos;
                        frmSeekOu.Show();
                        break;

                }
            }
        }

        public static void sessionsUpdate(seekerSessions sessionToBeUpdated, seekerObjects objectToBeUpdated)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\";
            if (Directory.Exists(filepath))
            {                
                DirectoryInfo d = new DirectoryInfo(filepath);
                foreach (var file in d.GetFiles("*.xml"))
                {
                    if (file.Name.Substring((file.Name.LastIndexOf('-') + 1), (file.Name.LastIndexOf('.') + 1) - (file.Name.LastIndexOf('-') + 2)).Contains(sessionToBeUpdated.SessionID.Substring((sessionToBeUpdated.SessionID.LastIndexOf('-') + 1), (sessionToBeUpdated.SessionID.Length - (sessionToBeUpdated.SessionID.LastIndexOf('-') + 1)))))
                    {
                        seekerSessions sesstionToBeUpdated = dLibObjSerializer.dLibObjSerializer.XmlDeSerializeObjectFromDisk<seekerSessions>(file.FullName);
                        sesstionToBeUpdated.Objects.Add(objectToBeUpdated);                        
                        dLibObjSerializer.dLibObjSerializer.XmlSerializeObjectToDisk<seekerSessions>(sesstionToBeUpdated, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\" + sesstionToBeUpdated.SessionID + ".xml");                        
                    }
                }
            }
        }


    }
    public class seekerObjects
    {
        public seekerObjectType Type { get; set; }
        public string QueryData { get; set; }
        public System.Drawing.Point ScreenPos { get; set; }
    }



    /// <summary>
    /// Specifies the type Seeker Object
    /// http://msdn.microsoft.com/en-us/library/windows/desktop/aa378184.aspx
    /// </summary>
    /// 
    public enum seekerObjectType
    {
        /// <summary>
        /// This type is intended to be used for Active Directory Computers        
        /// </summary>
        AD_Computer = 1,

        /// <summary>
        /// This type is intended to be used for Active Directory Users        
        /// </summary>
        AD_User = 2,

        /// <summary>
        /// This type is intended to be used for Active Directory Groups        
        /// </summary>
        AD_Group = 3,

        /// <summary>
        /// This type is intended to be used for Active Directory Organizational Units
        /// </summary>
        AD_OrganizationalUnit = 4,

        /// <summary>
        /// This type is intended to be used for FURNAS NET user objects
        /// </summary>
        FurnasNet = 5,

        /// <summary>
        /// This type is intended to be used for Photo objects
        /// </summary>
        //PhotoObject = 6,
    }
}
