using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Windows;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Reflection;
using dLibCypherJobs;
using ActiveDs;
using Seeker;




namespace dLibAdJobs
{
    public enum adObjectType
    {
        /// <summary>
        /// Set ACtive Directory Object type to User
        /// </summary>
        User = 1,
        /// <summary>
        /// Set ACtive Directory Object type to Group
        /// </summary>
        Group = 2,
        /// <summary>
        /// Set ACtive Directory Object type to Computer
        /// </summary>
        Computer = 3
    }
    public class dLibAd
    {
        //Class Definitions-----------------------

        public class adGroups
        {
            public string DN { get; set; }
            public string Name { get; set; }
            public string SammAccountName { get; set; }
            public string Description { get; set; }
            public string Notes { get; set; }
            public string CreationDate { get; set; }
            public string ChangedDate { get; set; }
            public string Type { get; set; }
            public string Scope { get; set; }
            public List<adUsers> Members { get; set; }
        }

        public class adOu
        {
            public string DN { get; set; }
            public string Name { get; set; }
            public string CreationDate { get; set; }
            public string ChangedDate { get; set; }
            public string Description { get; set; }
        }
           
        public class adComputers
        {
            public string Name { get; set; }
            public string DN { get; set; }
            public string OS { get; set; }
            public string CreationDate { get; set; }
            public string ChangedDate { get; set; }
            public string LapPAS { get; set; }
            public string LapPASExpirationDate { get; set; }
            public string SerialNumber { get; set; }
            public List<adGroups> Groups { get; set; }
            public string Description { get; set; }
            public void updateComputer()
            {
                DirectoryEntry ent = new DirectoryEntry(@"LDAP://" + frmMain.domainAccountData[0] + @"/" + DN, frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
                ent.Username = frmMain.domainAccountData[1];
                ent.Password = frmMain.domainAccountData[2];
                ent.Properties["ms-Mcs-AdmPwdExpirationTime"].Value = Convert.ToDateTime(this.LapPASExpirationDate).ToFileTime().ToString("D");
                ent.Properties["serialNumber"].AddRange(new object[] { this.SerialNumber });
                ent.CommitChanges();
            }
        }

        public class adUsers
        {
            public string DN { get; set; }
            public Image Photo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DisplayName { get; set; }
            public string Description { get; set; }
            public string Notes { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Location { get; set; }
            public string Manager { get; set; }
            public string Division { get; set; }
            public string Account { get; set; }
            public string StructClass { get; set; }
            public string SerialNumber { get; set; }
            public string CreationDate { get; set; }
            public string ChangedDate { get; set; }
            public string Company { get; set; }
            public DateTime LastBadPasswordAttempt { get; set; }
            public DateTime LastPasswordChange { get; set; }
            public string Status { get; set; }
            public List<adGroups> Groups { get; set; }
        }

        //-----------End Class Defs---------------

        //Functions Definitions-------------------



        private static bool IsUserAccountActive(DirectoryEntry de)
        {
            if (de.NativeGuid == null) return false;

            int flags = (int)de.Properties["userAccountControl"].Value;

            return !Convert.ToBoolean(flags & 0x0002);
        }

        public PrincipalSearchResult<Principal> GetADUser(PrincipalContext ctx,string userName)
        {            
            PrincipalSearchResult<Principal> results;
            UserPrincipal user = new UserPrincipal(ctx);
            PrincipalSearcher searcher = new PrincipalSearcher();

            userName = dLibAd.EscapeLdapSearchFilter(userName);
            user.DisplayName = String.Format("*{0}*", userName.Trim());
            //user.AdvancedSearchFilter.LastLogonTime(DateTime.Now.AddDays(-60), MatchType.GreaterThan);            
            //user.AdvancedSearchFilter.LastBadPasswordAttempt(DateTime.Now.AddDays(-1), MatchType.GreaterThan);
            //user.AdvancedSearchFilter.LastBadPasswordAttempt(DateTime.Now.AddDays(-1), MatchType.GreaterThan);
            searcher.QueryFilter = user;
            results = searcher.FindAll();

            try
            {
                if (!(results.Count() != 0))
                {
                    user = new UserPrincipal(ctx);
                    user.SamAccountName = "*" + userName.Trim() + "*";
                    searcher.QueryFilter = user;
                    results = searcher.FindAll();
                }
            }
            catch { }
            return results;
        }

        public PrincipalSearchResult<Principal> GetADGroup(PrincipalContext ctx,string groupName, bool exactSearch)
        {            
            PrincipalSearchResult<Principal> results = null;
            GroupPrincipal group = new GroupPrincipal(ctx);
            PrincipalSearcher searcher = new PrincipalSearcher();

            groupName = dLibAd.EscapeLdapSearchFilter(groupName);
            if (exactSearch)
            {
                group.SamAccountName = String.Format("{0}", groupName.Trim());
                searcher.QueryFilter = group;
                results = searcher.FindAll();
            }
            else
            {
                group.DisplayName = String.Format("*{0}*", groupName.Trim());
                searcher.QueryFilter = group;
                results = searcher.FindAll();
                if (results.Count() <= 0)
                {
                    group = new GroupPrincipal(ctx);
                    group.SamAccountName = "*" + groupName.Trim() + "*";
                    searcher.QueryFilter = group;
                    results = searcher.FindAll();
                }
            }


            return results;
        }

        public PrincipalSearchResult<Principal> GetADComputer(PrincipalContext ctx,string pcName)
        {            
            PrincipalSearchResult<Principal> results;
            ComputerPrincipal computer = new ComputerPrincipal(ctx);
            PrincipalSearcher searcher = new PrincipalSearcher();

            pcName = dLibAd.EscapeLdapSearchFilter(pcName);

            computer.SamAccountName = String.Format("{0}$", pcName);
            searcher.QueryFilter = computer;
            results = searcher.FindAll();

            if (results.Count() <= 0)
            {
                computer = new ComputerPrincipal(ctx);
                computer.SamAccountName = "*" + pcName.Trim() + "*";
                searcher.QueryFilter = computer;
                results = searcher.FindAll();
            }
            return results;
        }
                
        public SearchResultCollection GetADOu(DirectoryEntry deBase, string ou1)
        {
            DirectorySearcher search = new DirectorySearcher(deBase)
            {
                SearchScope = SearchScope.Subtree,
                Filter = "(&" +
                    "(objectClass=organizationalUnit)" +
                    "(name=*" + ou1 + "*)" +
                    //"(samaccountname=*100)" +
                ")"
            };

            search.PropertiesToLoad.Add("name");
            search.PropertiesToLoad.Add("distinguishedname");
            SearchResultCollection result = search.FindAll();
            //PrincipalSearchResult<Principal> teste = search.FindAll();
            return result;
        }

        public static adOu GetADOuInfo(DirectoryEntry deBase, string ou1)
        {
            adOu queryOu = new adOu();
            DirectorySearcher search = new DirectorySearcher(deBase)
            {
                //Change SearchScope to search further down the three
                SearchScope = SearchScope.Base,
            };

            search.PropertiesToLoad.Add("name");
            search.PropertiesToLoad.Add("description");
            search.PropertiesToLoad.Add("whenCreated");
            search.PropertiesToLoad.Add("whenChanged");
            search.PropertiesToLoad.Add("distinguishedname");

            SearchResult result = search.FindOne();

            queryOu.Name = result.GetDirectoryEntry().Properties["name"].Value.ToString();
            queryOu.DN = result.GetDirectoryEntry().Properties["distinguishedname"].Value.ToString();
            queryOu.CreationDate = result.GetDirectoryEntry().Properties["whenCreated"].Value.ToString();
            queryOu.ChangedDate = result.GetDirectoryEntry().Properties["whenChanged"].Value.ToString();

            if (result.GetDirectoryEntry().Properties["description"].Value != null)
            {
                queryOu.Description = result.GetDirectoryEntry().Properties["description"].Value.ToString();
            }
            else { queryOu.Description = "No description Available"; }

            return queryOu;
        }

        public static List<adGroups> adObjectGroups(PrincipalContext context, string adObject, adObjectType objType, Boolean getNested)
        {
            List<adGroups> lstADGroups = new List<adGroups>();
            PrincipalSearchResult<Principal> groups = null;

            switch (objType)
            {
                case adObjectType.User:
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, adObject);
                    if (user != null)
                    {
                        if (getNested)
                        {
                            groups = user.GetAuthorizationGroups();
                        }
                        else
                        {
                            groups = user.GetGroups();
                        }
                    }
                    break;
                case adObjectType.Group:
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, adObject);
                    if (group != null)
                    {
                        groups = group.GetGroups();
                    }
                    break;
            }

            foreach (Principal p in groups)
            {
                adGroups adGroup = new adGroups();
                if (p is GroupPrincipal)
                {
                    adGroup.SammAccountName = p.SamAccountName;
                    adGroup.Name = p.Name;
                    adGroup.DN = p.DistinguishedName;
                    lstADGroups.Add(adGroup);
                    //result.Add((GroupPrincipal)p);
                }
            }
            return lstADGroups;
        }

        public static void AddMemberToGroup(string group, PrincipalContext groupContext, string adObject, PrincipalContext objContext, adObjectType objType)
        {
            GroupPrincipal grp = GroupPrincipal.FindByIdentity(groupContext, IdentityType.Name, group);
            try
            {
                switch (objType)
                {
                    case adObjectType.User:
                        UserPrincipal objUser = UserPrincipal.FindByIdentity(objContext, adObject);
                        grp.Members.Add(objUser);
                        break;
                    case adObjectType.Group:
                        GroupPrincipal objGroup = GroupPrincipal.FindByIdentity(objContext, adObject);
                        grp.Members.Add(objGroup);
                        break;
                    default:
                        break;
                }
                grp.Save();
                grp.Dispose();
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("denied"))
                {
                    MessageBox.Show("Acesso Negado!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            finally
            {
            }
        }

        public static void RemoveMemberFromGroup(PrincipalContext context, string group, string member)
        {
            try
            {
                GroupPrincipal grp = GroupPrincipal.FindByIdentity(context, IdentityType.Name, group);
                if (grp != null)
                {
                    grp.Members.Remove(context, IdentityType.SamAccountName, member);
                    grp.Save();
                    grp.Dispose();
                    context.Dispose();
                }
            }
            catch (Exception ex)
            {

                if (ex.Message.ToLower().Contains("denied"))
                {
                    MessageBox.Show("Acesso Negado!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            finally
            {
            }
        }

        public static adGroups adGrpDetailsFinder(PrincipalContext context, string adGroup)
        {
            adGroups ladGrp = new adGroups();
            GroupPrincipal grp = GroupPrincipal.FindByIdentity(context, adGroup);
            if (grp != null)
            {
                System.DirectoryServices.DirectoryEntry underlayingFields = grp.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                ladGrp.Name = grp.Name;
                ladGrp.DN = grp.DistinguishedName;
                ladGrp.Description = grp.Description;
                ladGrp.Scope = grp.GroupScope.Value.ToString();

                if (grp.IsSecurityGroup == true)
                {
                    ladGrp.Type = "Security";
                }
                else
                {
                    ladGrp.Type = "Distribution";
                }

                if (underlayingFields.Properties.Contains("info"))
                {
                    ladGrp.Notes = underlayingFields.Properties["info"].Value.ToString();
                }

                if (underlayingFields.Properties.Contains("whenCreated"))
                {
                    ladGrp.CreationDate = underlayingFields.Properties["whenCreated"].Value.ToString();
                }

                if (underlayingFields.Properties.Contains("whenChanged"))
                {
                    ladGrp.ChangedDate = underlayingFields.Properties["whenChanged"].Value.ToString();
                }
            }
            return ladGrp;
        }

        public static adComputers adComputerDetailsFinder(PrincipalContext context, string computer)
        {
            adComputers adComputer = new adComputers();
            try
            {
                ComputerPrincipal comp = ComputerPrincipal.FindByIdentity(context, computer);
                if (comp != null)
                {
                    DirectoryEntry deepDetails = comp.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;

                    adComputer.Name = comp.Name;
                    adComputer.DN = comp.DistinguishedName;
                    adComputer.Description = comp.Description;

                    if (deepDetails.Properties.Contains("operatingSystem"))
                    {
                        adComputer.OS = deepDetails.Properties["operatingSystem"].Value.ToString();
                    }
                    if (deepDetails.Properties.Contains("whenCreated"))
                    {

                        adComputer.CreationDate = deepDetails.Properties["whenCreated"].Value.ToString();
                    }
                    if (deepDetails.Properties.Contains("whenChanged"))
                    {
                        adComputer.ChangedDate = deepDetails.Properties["whenChanged"].Value.ToString();
                    }
                    if (deepDetails.Properties.Contains("ms-Mcs-AdmPwd"))
                    {
                        adComputer.LapPAS = deepDetails.Properties["ms-Mcs-AdmPwd"].Value.ToString();
                    }
                    if (deepDetails.Properties.Contains("ms-Mcs-AdmPwdExpirationTime"))
                    {
                        Int64 lastLogonThisServer = new Int64();
                        try
                        {
                            IADsLargeInteger lgInt = (IADsLargeInteger)deepDetails.Properties["ms-Mcs-AdmPwdExpirationTime"].Value;
                            lastLogonThisServer = ((long)lgInt.HighPart << 32) + lgInt.LowPart;
                            adComputer.LapPASExpirationDate = (DateTime.FromFileTime(lastLogonThisServer)).ToString();
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }
            catch { Exception e; }
            return adComputer;
        }

        public static List<adGroups> adComputerGroups(PrincipalContext ctx,string adComputer)
        {            
            List<adGroups> lstADGroups = new List<adGroups>();
            ComputerPrincipal comp = ComputerPrincipal.FindByIdentity(ctx, adComputer);
            if (comp != null)
            {
                PrincipalSearchResult<Principal> groups = comp.GetGroups();
                foreach (Principal p in groups)
                {
                    adGroups adGroup = new adGroups();
                    if (p is GroupPrincipal)
                    {
                        adGroup.Name = p.Name;
                        adGroup.DN = p.DistinguishedName;
                        lstADGroups.Add(adGroup);                       
                    }
                }
            }
            return lstADGroups;
        }


        public static string EscapeLdapSearchFilter(string searchFilter)
        {
            String returnStr = "";
            returnStr = searchFilter.Replace("/", "");
            returnStr = searchFilter.Replace(@"\", "");
            returnStr = searchFilter.Replace("*/", "");
            returnStr = searchFilter.Replace(@"*\", "");
            returnStr = searchFilter.Replace("/*", "");
            returnStr = searchFilter.Replace(@"\*", "");
            returnStr = searchFilter.Replace("(", "");
            returnStr = searchFilter.Replace(@")", "");
            returnStr = searchFilter.Replace(@"*)", "");
            returnStr = searchFilter.Replace(@")*", "");
            returnStr = searchFilter.Replace(@"*(", "");
            returnStr = searchFilter.Replace(@"(*", "");

            int astCharCount = genEx.generalExtensions.countSoccur(searchFilter, "*");
            int querySize = searchFilter.Length;

            if (astCharCount == querySize)
            {
                returnStr = searchFilter.Replace("*", "Seeker");
            }
            return returnStr;
        }


        //User Principal Extensions to Get Private Properties
        [DirectoryRdnPrefix("CN")]
        [DirectoryObjectClass("user")]
        public class UserPrincipalExtended : UserPrincipal
        {
            public UserPrincipalExtended(PrincipalContext context) : base(context) { }

            public UserPrincipalExtended(PrincipalContext
                context,
                string samAccountName,
                string password,
                bool enabled)
                : base(context, samAccountName, password, enabled)
            { }

            public static new UserPrincipalExtended FindByIdentity(PrincipalContext context,
                                                           string identityValue)
            {
                return (UserPrincipalExtended)FindByIdentityWithType(context,
                                                             typeof(UserPrincipalExtended),
                                                             identityValue);
            }

            public static new UserPrincipalExtended FindByIdentity(PrincipalContext context,
                                                           IdentityType identityType,
                                                           string identityValue)
            {
                return (UserPrincipalExtended)FindByIdentityWithType(context,
                                                             typeof(UserPrincipalExtended),
                                                             identityType,
                                                             identityValue);
            }

            #region custom attributes
            [DirectoryProperty("RealLastLogon")]
            public DateTime? RealLastLogon
            {
                get
                {
                    if (ExtensionGet("LastLogon").Length > 0)
                    {
                        var lastLogonDate = ExtensionGet("LastLogon")[0];
                        var lastLogonDateType = lastLogonDate.GetType();

                        var highPart = (Int32)lastLogonDateType.InvokeMember("HighPart",
                            BindingFlags.GetProperty, null, lastLogonDate, null);
                        var lowPart = (Int32)lastLogonDateType.InvokeMember("LowPart",
                            BindingFlags.GetProperty | BindingFlags.Public, null, lastLogonDate, null);

                        var longDate = ((Int64)highPart << 32 | (UInt32)lowPart);

                        return longDate > 0 ? (DateTime?)DateTime.FromFileTime(longDate) : null;
                    }

                    return null;
                }
            }
            #endregion
        }
        //----------------------------------------------------

        //Done on The Run, Must Be Validated!      
    
        public static adUsers locateUsr(PrincipalContext context, string adUser)
        {
            adUsers ladUser = new adUsers();
            try
            {
                if (context.ContextType.ToString().ToLower().Contains("domain"))
                {
                    UserPrincipal usr = UserPrincipal.FindByIdentity(context, adUser);
                    if (usr != null)
                    {
                        System.DirectoryServices.DirectoryEntry underField = usr.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                        ladUser.DN = usr.DistinguishedName;
                        ladUser.FirstName = usr.GivenName;
                        ladUser.LastName = usr.Surname;
                        ladUser.DisplayName = usr.DisplayName;
                        ladUser.Description = usr.Description;
                        ladUser.LastBadPasswordAttempt = Convert.ToDateTime(usr.LastBadPasswordAttempt);
                        ladUser.LastPasswordChange = Convert.ToDateTime(usr.LastPasswordSet);
                        ladUser.Email = usr.EmailAddress;
                        ladUser.Account = usr.SamAccountName;

                        if (adUser.Substring(0, 2).ToLower().Contains("fe") | adUser.Substring(0, 2).ToLower().Contains("fr") | adUser.Substring(0, 2).ToLower().Contains("fc"))
                        {
                            // ladUser.Photo = dLibLke.usrPhoto(dLibLke.findDv(usr.SamAccountName));
                        }
                        else
                        {
                            ladUser.Photo = Seeker.Properties.Resources.usrPhoto;
                        }

                        if (underField.Properties.Contains("company"))
                        {
                            ladUser.Company = underField.Properties["company"].Value.ToString();
                        }

                        if (underField.Properties.Contains("telephoneNumber"))
                        {
                            ladUser.Phone = underField.Properties["telephoneNumber"].Value.ToString();
                        }
                        if (underField.Properties.Contains("otherTelephone"))
                        {
                            for (int i = 0; i < underField.Properties["otherTelephone"].Count; i++)
                            {
                                ladUser.Phone = ladUser.Phone + " - " + underField.Properties["otherTelephone"][i].ToString();
                            }
                        }

                        if (underField.Properties.Contains("info"))
                        {
                            ladUser.Notes = underField.Properties["info"].Value.ToString();
                        }

                        if (underField.Properties.Contains("whenCreated"))
                        {
                            ladUser.CreationDate = underField.Properties["whenCreated"].Value.ToString();
                        }
                        if (underField.Properties.Contains("whenChanged"))
                        {

                            ladUser.ChangedDate = underField.Properties["whenChanged"].Value.ToString();
                        }

                        if (IsUserAccountActive(underField))
                        {
                            ladUser.Status = "Active";
                        }
                        else
                        {
                            ladUser.Status = "Disabled";
                        }


                        if (usr.AccountLockoutTime != null)
                        {
                            ladUser.Status = ladUser.Status + ",Locked on: " + usr.AccountLockoutTime.ToString();

                        }
                        else
                        {
                            ladUser.Status = ladUser.Status + ", Unlocked";
                        }

                        if (underField.Properties.Contains("serialNumber"))
                        {
                            StringBuilder userSerials = new StringBuilder();
                            if (underField.Properties["serialNumber"].Count > 1)
                            {
                                foreach (string s in underField.Properties["serialNumber"])
                                {
                                    userSerials.Append(s + ",");
                                }
                                ladUser.SerialNumber = userSerials.ToString();
                            }
                            else
                            {
                                if (underField.Properties["serialNumber"].Count == 1)
                                {
                                    DateTime date;
                                    string[] formats = { "dd/MM/yyyy hh:mm:ss", "dd/MM/yyyy" };
                                    if (DateTime.TryParseExact(underField.Properties["serialNumber"].Value.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                                    {
                                        ladUser.SerialNumber = date.ToString();
                                    }
                                    else
                                    {
                                        ladUser.SerialNumber = null;
                                    }
                                }
                                else
                                {
                                    ladUser.SerialNumber = null;
                                }
                            }
                        }
                        else
                        {
                            ladUser.SerialNumber = null;
                        }
                        if (underField.Properties.Contains("department"))
                        {
                            ladUser.Division = underField.Properties["department"].Value.ToString();
                        }
                        else
                        {
                            ladUser.Division = "Unknown";
                        }


                        if (underField.Properties.Contains("l"))
                        {
                            ladUser.Location = underField.Properties["l"].Value.ToString();
                        }


                        if (underField.Properties.Contains("physicalDeliveryOfficeName"))
                        {
                            ladUser.Location = ladUser.Location + " - " + underField.Properties["physicalDeliveryOfficeName"].Value.ToString();
                        }





                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    UserPrincipal usr = UserPrincipal.FindByIdentity(context, adUser);
                    if (usr != null)
                    {
                        ladUser.DN = usr.SamAccountName;
                        ladUser.FirstName = usr.GivenName;
                        ladUser.LastName = usr.Surname;
                        ladUser.DisplayName = usr.DisplayName;
                        ladUser.Description = usr.Description;
                        ladUser.Email = usr.EmailAddress;
                        ladUser.Account = usr.SamAccountName;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("adUsrDetailsFinder \n\n" +
                    "\n\nObject: " + adUser +
                    "\n\nMessage: " + ex.Message +
                    "\n\nSource: " + ex.Source +
                    "\n\nStack: " + ex.StackTrace +
                    "\n\nTarget: " + ex.TargetSite, "Information: Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
            }
            return ladUser;


        }
        // --------------------------------------------------------------------------------


    }
}
