using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace genEx
{
    public static class generalExtensions
    {
        // String Sanitize ---------------------------
        public static string RemoveDiacritics(this string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        public static Boolean checkDiacritics(this string s)
        {
            Boolean result = false;
            var regexItem = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z])\S{8,45}$");
            if (regexItem.IsMatch(s))
            {
                result = true;
            }
            return result;
        }

        // End String Snitize ------------------------


        //Count Special Chars occurences

        public static int countSoccur(string stringToSearch, string stringToBeSearched)
        {
            return stringToSearch.Length - stringToSearch.Replace(stringToBeSearched, "").Length;            
        }



        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }


       



        //Custom Tab Control

        class syncCustomTabControl : TabControl
        {
            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyData == (Keys.Tab | Keys.Control) ||
                    e.KeyData == (Keys.PageDown | Keys.Control))
                {
                    // Don't allow tabbing beyond last page
                    if (this.SelectedIndex == this.TabCount - 1) return;
                }
                base.OnKeyDown(e);
            }
        }
        public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
        {
            // If the invoke is not required, then invoke here and get out.
            if (!sync.InvokeRequired)
            {
                // Execute action.
                action();

                // Get out.
                return;
            }

            // Marshal to the required context.
            sync.Invoke(action, new object[] { });
        }
        //

        // RichTextBox Add Colorized Text Extension----
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
        // RichTextBox Add Colorized Text Extension---

        //Get Age
        public static Int32 GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        // -------------------------------------------


        
        //ListView Collapse Overhide
        [StructLayout(LayoutKind.Sequential)]
        public struct LVGROUP
        {
            public int cbSize;
            public int mask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszHeader;
            public int cchHeader;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszFooter;
            public int cchFooter;
            public int iGroupId;
            public int stateMask;
            public int state;
            public int uAlign;
        }

        public enum GroupState
        {
            COLLAPSIBLE = 8,
            COLLAPSED = 1,
            EXPANDED = 0
        }

        [DllImport("user32.dll")]
        static extern int SendMessage
            (IntPtr window, int message, int wParam, IntPtr lParam);


        public class ExtListView : ListView
        {
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case 0x202: // WM_LBUTTONUP
                        base.DefWndProc(ref m);
                        base.WndProc(ref m);
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }
        }

        public static void SetGroupCollapse(GroupState state, ListView listview)
        {
            for (int i = 0; i <= listview.Groups.Count; i++)
            {
                LVGROUP group = new LVGROUP();
                group.cbSize = Marshal.SizeOf(group);
                group.state = (int)state; // LVGS_COLLAPSIBLE 
                group.mask = 4; // LVGF_STATE 
                group.iGroupId = i;
                IntPtr ip = IntPtr.Zero;
                try
                {
                    ip = Marshal.AllocHGlobal(group.cbSize);
                    //Marshal.StructureToPtr(group, ip, true);
                    Marshal.StructureToPtr(group, ip, false);
                    SendMessage(listview.Handle, 0x1000 + 147, i, ip); // #define  LVM_SETGROUPINFO (LVM_FIRST + 147) 
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine
                    (ex.Message + Environment.NewLine + ex.StackTrace);
                }
                finally
                {
                    if (null != ip) Marshal.FreeHGlobal(ip);
                }
            }
        }
        //
    }
}
