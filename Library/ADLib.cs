using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using ActiveDs;
using Seeker;
using Seeker.Library;
using System.Data;

namespace Simple_AD_Browser_Helpers
{
    public class ADLib
    {
        /// <summary>
        /// Used for spliting AD Multiline values
        /// </summary>
        private string m_Delimiter = ", ";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctr_tree"></param>
        /// <param name="LoginCreditsFromUser"></param>
        public void ConnectAndDisplayRoot(ref BufferedTreeView ctr_tree, Credits LoginCreditsFromUser)
        {
            //Pass Connet info to DirextoryEntry object:
            DirectoryEntry LDAPRoot = new DirectoryEntry("LDAP://" + LoginCreditsFromUser.Domain, LoginCreditsFromUser.Username, LoginCreditsFromUser.Pwd);

            //Read the root:
            if (LDAPRoot == null) { return; }
            ctr_tree.Nodes.Clear();
            ctr_tree.BeginUpdate();


            //Custom Icons
            TreeNode childNode = new TreeNode();
            childNode.Text = LDAPRoot.Name.Substring(3, LDAPRoot.Name.Length - 3);

            string objCatChildNode = LDAPRoot.Properties["objectCategory"][0].ToString().ToLower().Split(',')[0];
            if (objCatChildNode.ToLower().Contains("group"))
            {
                childNode.ImageIndex = 10;
                childNode.SelectedImageIndex = 11;
            }

            if (objCatChildNode.ToLower().Contains("person"))
            {
                childNode.ImageIndex = 1;
                childNode.SelectedImageIndex = 2;
            }

            if (objCatChildNode.ToLower().Contains("organizational"))
            {
                childNode.ImageIndex = 14;
                childNode.SelectedImageIndex = 15;
            }
            if (objCatChildNode.ToLower().Contains("computer"))
            {
                childNode.ImageIndex = 3;
                childNode.SelectedImageIndex = 5;
            }
            //childNode = ctr_tree.Nodes.Add(LDAPRoot.Name);
            ctr_tree.Nodes.Add(childNode);
            childNode.Tag = LDAPRoot;

            try
            {
                foreach (DirectoryEntry Item in LDAPRoot.Children)
                {
                    //Add the root container to the treeview
                    TreeNode RootNode = new TreeNode();
                    RootNode.Text = Item.Name.Substring(3, Item.Name.Length - 3);
                    string objCat = Item.Properties["objectCategory"][0].ToString().ToLower().Split(',')[0];
                    if (objCat.ToLower().Contains("group"))
                    {
                        RootNode.ImageIndex = 10;
                        RootNode.SelectedImageIndex = 11;
                    }

                    if (objCat.ToLower().Contains("person"))
                    {
                        RootNode.ImageIndex = 1;
                        RootNode.SelectedImageIndex = 2;
                    }

                    if (objCat.ToLower().Contains("organizational"))
                    {
                        RootNode.ImageIndex = 14;
                        RootNode.SelectedImageIndex = 15;
                    }
                    if (objCat.ToLower().Contains("computer"))
                    {
                        RootNode.ImageIndex = 3;
                        RootNode.SelectedImageIndex = 5;
                    }
                    //RootNode = childNode.Nodes.Add(Item.Name);    
                    childNode.Nodes.Add(RootNode);

                    //Now tag the node with the current DirectoryEntry object. 
                    //Later we will use it for going down the tree after the user has clicked the node
                    RootNode.Tag = Item;
                }
            }
            finally
            {
                childNode.Expand();
                ctr_tree.EndUpdate();
            }

            frmSeekItAll.NodeSorterByType sortTypes = new frmSeekItAll.NodeSorterByType();
            ctr_tree.TreeViewNodeSorter = sortTypes;
            ctr_tree.Sort();
        }

        /// <summary>
        /// Populates the list from the container which was clicked on the treeview
        /// </summary>
        /// <param name="aDContainer"></param>
        public void FillListViewFromADContainer(ref ListView ctr_list, DirectoryEntry aDContainer)
        {
            //Fill the ListView Element
            try
            {
                if (aDContainer == null) { return; }
                ctr_list.Items.Clear();

                foreach (object ADProperties in aDContainer.Properties.PropertyNames)
                {
                    if (!(ADProperties.ToString().Contains("ms-Mcs-AdmPwdExpirationTime") | (ADProperties.ToString().Contains("ms-Mcs-AdmPwd"))))
                    {
                        IADsPropertyList oPropList = (aDContainer.NativeObject as IADsPropertyList);
                        IADsPropertyEntry oPropEntry = (oPropList.GetPropertyItem(ADProperties.ToString(), (int)ADSTYPEENUM.ADSTYPE_UNKNOWN) as IADsPropertyEntry);
                        int iADsType = oPropEntry.ADsType;

                        ListViewItem ListItem = new ListViewItem(ADProperties.ToString(), 0);
                        ListItem.SubItems.Add(PropertyToString(aDContainer, oPropEntry, iADsType));
                        ctr_list.Items.AddRange(new ListViewItem[] { ListItem });
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while populating the list", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// return Datatable from container
        /// </summary>
        /// <param name="aDContainer"></param>
        public DataTable FillDataTableFromADContainer(DirectoryEntry aDContainer)
        {            
            try
            {
                if (aDContainer == null) { return null; }
                DataTable containerData = new DataTable();
                containerData.Columns.Add("Property", typeof(string));
                containerData.Columns.Add("Value", typeof(string));
                foreach (object ADProperties in aDContainer.Properties.PropertyNames)
                {
                    if (!(ADProperties.ToString().Contains("ms-Mcs-AdmPwdExpirationTime") | (ADProperties.ToString().Contains("ms-Mcs-AdmPwd"))))
                    {
                        IADsPropertyList oPropList = (aDContainer.NativeObject as IADsPropertyList);
                        IADsPropertyEntry oPropEntry = (oPropList.GetPropertyItem(ADProperties.ToString(), (int)ADSTYPEENUM.ADSTYPE_UNKNOWN) as IADsPropertyEntry);
                        int iADsType = oPropEntry.ADsType;
                        string teste = PropertyToString(aDContainer, oPropEntry, iADsType);
                        containerData.Rows.Add(ADProperties.ToString(),teste);

                       // ListViewItem ListItem = new ListViewItem(ADProperties.ToString(), 0);
                        //ListItem.SubItems.Add(PropertyToString(aDContainer, oPropEntry, iADsType));
                        
                    }
                }
                return containerData;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while populating the Datatable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// <summary>
        /// Checks if the Node has child objects
        /// </summary>
        /// <param name="treeNode"></param>
        public void FillCheckTreeNodeForChildObjects(TreeNode treeNode)
        {
            //Fill the TreeView dynamic after Click
            if (treeNode.Nodes.Count == 0)
            {
                //Get the DirectoryEntry out of the tag property which was filled in ConnectAndDisplayRoot
                DirectoryEntry parent = (DirectoryEntry)treeNode.Tag;

                if (parent != null || parent.Children != null)
                {
                    foreach (DirectoryEntry ChildItem in parent.Children)
                    {
                        TreeNode childNode = new TreeNode();
                        childNode.Text = ChildItem.Name.Substring(3, ChildItem.Name.Length - 3);
                        string objCat = ChildItem.Properties["objectCategory"][0].ToString().ToLower().Split(',')[0];
                        if (objCat.ToLower().Contains("group"))
                        {
                            childNode.ImageIndex = 10;
                            childNode.SelectedImageIndex = 11;
                        }

                        if (objCat.ToLower().Contains("person"))
                        {
                            childNode.ImageIndex = 1;
                            childNode.SelectedImageIndex = 2;
                        }

                        if (objCat.ToLower().Contains("organizational"))
                        {
                            childNode.ImageIndex = 14;
                            childNode.SelectedImageIndex = 15;
                        }
                        if (objCat.ToLower().Contains("computer"))
                        {
                            childNode.ImageIndex = 3;
                            childNode.SelectedImageIndex = 5;
                        }
                        //childNode = treeNode.Nodes.Add(ChildItem.Name);
                        treeNode.Nodes.Add(childNode);
                        //Now tag the node with the current DirectoryEntry object. 
                        //Later we will use it for going down the tree after the user has clicked the node
                        childNode.Tag = ChildItem;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aObjectSid"></param>
        /// <returns></returns>
        private string ObjectSidToString(byte[] aObjectSid)
        {
            System.Security.Principal.SecurityIdentifier sid = new System.Security.Principal.SecurityIdentifier(aObjectSid, 0);
            return sid.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aObjectGUID"></param>
        /// <returns></returns>
        private string ObjectGUIDToStringGUID(string aObjectGUID)
        {
            StringBuilder oStrGUID = new StringBuilder("{");

            oStrGUID.Append(aObjectGUID.Substring(6, 2));
            oStrGUID.Append(aObjectGUID.Substring(4, 2));
            oStrGUID.Append(aObjectGUID.Substring(2, 2));
            oStrGUID.Append(aObjectGUID.Substring(0, 2));
            oStrGUID.Append("-");
            oStrGUID.Append(aObjectGUID.Substring(10, 2));
            oStrGUID.Append(aObjectGUID.Substring(8, 2));
            oStrGUID.Append("-");
            oStrGUID.Append(aObjectGUID.Substring(14, 2));
            oStrGUID.Append(aObjectGUID.Substring(12, 2));
            oStrGUID.Append("-");
            oStrGUID.Append(aObjectGUID.Substring(16, 4));
            oStrGUID.Append("-");
            oStrGUID.Append(aObjectGUID.Substring(20));
            oStrGUID.Append("}");

            return oStrGUID.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aEntry"></param>
        /// <param name="aDomainEntry"></param>
        /// <returns></returns>
        private string GetPrimaryGroup(DirectoryEntry aEntry, DirectoryEntry aDomainEntry)
        {
            int primaryGroupID = (int)aEntry.Properties["primaryGroupID"].Value;
            byte[] objectSid = (byte[])aEntry.Properties["objectSid"].Value;

            StringBuilder escapedGroupSid = new StringBuilder();

            // Copy over everything but the last four bytes(sub-authority)
            // Doing so gives us the RID of the domain
            for (uint i = 0; i < objectSid.Length - 4; i++)
            {
                escapedGroupSid.AppendFormat("\\{0:x2}", objectSid[i]);
            }

            //Add the primaryGroupID to the escape string to build the SID of the primaryGroup
            for (uint i = 0; i < 4; i++)
            {
                escapedGroupSid.AppendFormat("\\{0:x2}", (primaryGroupID & 0xFF));
                primaryGroupID >>= 8;
            }

            //Search the directory for a group with this SID
            DirectorySearcher searcher = new DirectorySearcher();
            if (aDomainEntry != null)
            {
                searcher.SearchRoot = aDomainEntry;
            }

            searcher.Filter = "(&(objectCategory=Group)(objectSID=" + escapedGroupSid.ToString() + "))";
            searcher.PropertiesToLoad.Add("distinguishedName");
            return searcher.FindOne().Properties["distinguishedName"][0].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aLargeInt"></param>
        /// <returns></returns>
        private string ConvertLargeIntToDate(Int64 aLargeInt)
        {
            if (aLargeInt == 0)
            {
                return "(no value set)";
            }

            if ((aLargeInt & 0xFFFFFFFF) == 0xFFFFFFFF)
            {
                return "(never expires)";
            }

            DateTime aDate = DateTime.FromFileTime(aLargeInt);
            return aDate.ToShortDateString() + " " + aDate.ToLongTimeString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aEntry"></param>
        /// <param name="aPropEntry"></param>
        /// <param name="aADsType"></param>
        /// <returns></returns>
        public string PropertyToString(DirectoryEntry aEntry, IADsPropertyEntry aPropEntry, int aADsType)
        {
            List<string> alsValues = new List<string>();
            ADSTYPEENUM oEnum = (ADSTYPEENUM)aADsType;

            try
            {
                foreach (IADsPropertyValue oPropValue in (object[])aPropEntry.Values)
                {
                    switch (oEnum)
                    {
                        case ADSTYPEENUM.ADSTYPE_DN_STRING:
                            alsValues.Add(oPropValue.DNString);
                            break;

                        case ADSTYPEENUM.ADSTYPE_CASE_EXACT_STRING:
                            alsValues.Add(oPropValue.CaseExactString);
                            break;

                        case ADSTYPEENUM.ADSTYPE_CASE_IGNORE_STRING:
                            alsValues.Add(oPropValue.CaseIgnoreString);
                            break;

                        case ADSTYPEENUM.ADSTYPE_PRINTABLE_STRING:
                            alsValues.Add(oPropValue.PrintableString);
                            break;

                        case ADSTYPEENUM.ADSTYPE_NUMERIC_STRING:
                            alsValues.Add(oPropValue.NumericString);
                            break;

                        case ADSTYPEENUM.ADSTYPE_BOOLEAN:
                            alsValues.Add(oPropValue.Boolean.ToString());
                            break;

                        case ADSTYPEENUM.ADSTYPE_INTEGER:
                            if (aPropEntry.Name == "primaryGroupID")
                            {
                                alsValues.Add(oPropValue.Integer.ToString() + m_Delimiter + "(" + GetPrimaryGroup(aEntry, null) + ")");

                            }
                            else
                            {
                                int iValue = oPropValue.Integer;
                                alsValues.Add(iValue.ToString() + m_Delimiter + "(Hex: 0x" + iValue.ToString("X") + ")");
                            }
                            break;

                        case ADSTYPEENUM.ADSTYPE_UTC_TIME:
                            alsValues.Add(oPropValue.UTCTime.ToString());
                            break;

                        case ADSTYPEENUM.ADSTYPE_OCTET_STRING:
                            // handle the objectSID
                            if (aPropEntry.Name == "objectSid")
                            {
                                // alsValues.Add(oPropValue.OctetString.ToString());
                                StringBuilder sbSID = new StringBuilder();
                                byte[] usrSID = (byte[])oPropValue.OctetString;

                                foreach (byte b in usrSID)
                                {
                                    sbSID.AppendFormat("{0:x2}", b);
                                }

                                alsValues.Add(sbSID.ToString() + m_Delimiter + "(" + ObjectSidToString(usrSID) + ")");
                            }
                            else if (aPropEntry.Name == "objectGUID")
                            {
                                StringBuilder sbGUID = new StringBuilder();
                                byte[] usrGUID = (byte[])oPropValue.OctetString;

                                foreach (byte b in usrGUID)
                                {
                                    sbGUID.AppendFormat("{0:x2}", b);
                                }

                                alsValues.Add(sbGUID.ToString() + m_Delimiter + "(CLSID-style: " + ObjectGUIDToStringGUID(sbGUID.ToString()) + ")");
                            }
                            else
                            {
                                alsValues.Add("(OCTET_STRING not yet supported)");
                            }
                            break;

                        case ADSTYPEENUM.ADSTYPE_LARGE_INTEGER:
                            try
                            {
                                Int64 iLargeInt = 0;
                                IADsLargeInteger int64Val = (IADsLargeInteger)oPropValue.LargeInteger;
                                iLargeInt = int64Val.HighPart * 4294967296 + int64Val.LowPart;

                                // check for special cases
                                string sPropName = aPropEntry.Name.ToLower();
                                if (sPropName == "accountexpires" || sPropName == "badpasswordtime" || sPropName == "creationtime" ||
                                    sPropName == "lastlogoff" || sPropName == "lastlogon" || sPropName == "pwdlastset")
                                {
                                    string sTimeString = ConvertLargeIntToDate(iLargeInt);
                                    alsValues.Add(sTimeString + m_Delimiter + iLargeInt.ToString());
                                }
                                else
                                {
                                    alsValues.Add(iLargeInt.ToString() + m_Delimiter + "(Hex: 0x" + iLargeInt.ToString("X") + ")");
                                }
                            }
                            catch (Exception)
                            {
                                //
                            }

                            break;

                        case ADSTYPEENUM.ADSTYPE_CASEIGNORE_LIST:
                            alsValues.Add("(CASEIGNORE_LIST not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_PATH:
                            alsValues.Add("(PATH not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_INVALID:
                            alsValues.Add("(invalid ADs type: " + aADsType.ToString() + ")");
                            break;

                        case ADSTYPEENUM.ADSTYPE_PROV_SPECIFIC:
                            alsValues.Add("(PROV_SPECIFIC not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_OBJECT_CLASS:
                            alsValues.Add("(OBJECT_CLASS not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_OCTET_LIST:
                            alsValues.Add("(OCTET_LIST not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_POSTALADDRESS:
                            alsValues.Add("(POSTALADDRESS not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_TIMESTAMP:
                            alsValues.Add("(TIMESTAMP not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_BACKLINK:
                            alsValues.Add("(BACKLINK not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_TYPEDNAME:
                            alsValues.Add("(TYPEDNAME not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_HOLD:
                            alsValues.Add("(HOLD not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_NETADDRESS:
                            alsValues.Add("(NETADDRESS not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_REPLICAPOINTER:
                            alsValues.Add("(REPLICAPOINTER not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_FAXNUMBER:
                            alsValues.Add("(FAXNUMBER not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_EMAIL:
                            alsValues.Add("(EMAIL not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_NT_SECURITY_DESCRIPTOR:
                            alsValues.Add(aADsType.ToString());
                            break;

                        case ADSTYPEENUM.ADSTYPE_UNKNOWN:
                            alsValues.Add("(unknown AD type: " + aADsType.ToString() + ")");
                            break;

                        case ADSTYPEENUM.ADSTYPE_DN_WITH_BINARY:
                            alsValues.Add("(DN_WITH_BINARY not yet supported)");
                            break;

                        case ADSTYPEENUM.ADSTYPE_DN_WITH_STRING:
                            alsValues.Add("(DN_WITH_STRING not yet supported)");
                            break;

                        default:
                            alsValues.Add("(unknown AD type: " + aADsType.ToString() + ")");
                            break;
                    }
                }
            }
            catch { }

            if (alsValues.Count > 0)
            {
                StringBuilder oSB = new StringBuilder(alsValues[0].ToString());
                for (int ix = 1; ix < alsValues.Count; ix++)
                {
                    oSB.Append(m_Delimiter + alsValues[ix]);
                }

                return oSB.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

    }

    public struct Credits
    {
        public string Domain;
        public string Username;
        public string Pwd;
    }
}
