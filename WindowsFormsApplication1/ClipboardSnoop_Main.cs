using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;

namespace WindowsFormsApplication1
{
    
    public partial class ClipboardSnoop_Main : Form
    {
        private const int WM_CLIPBOARDUPDATE = 0x031D;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                RefreshData();
            }
        }
        
        public ClipboardSnoop_Main()
        {
            InitializeComponent();

            NativeMethods.AddClipboardFormatListener(Handle);

            RefreshData();
        }

        //System.Windows.Forms.Clipboard.GetText();
        public static event EventHandler ClipboardUpdate;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            NativeMethods.RemoveClipboardFormatListener(this.Handle);     // Remove our window from the clipboard's format listener list.
        }

        private static void OnClipboardUpdate(EventArgs e)
        {
            var handler = ClipboardUpdate;
            if( handler != null )
            {
                handler(null, e);

                
            }
            MessageBox.Show(e.ToString());
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }   

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            clipboardText.Text = Clipboard.GetText();
            clipboardImage.Image = Clipboard.GetImage();

            IDataObject iData = Clipboard.GetDataObject();
            clipboardData.Text = string.Join("\n", iData.GetFormats());

            // Try to view the HTML
            try
            {
                if (iData != null)
                {
                    rtfHTML.Text = (iData.GetData(DataFormats.Html)).ToString();
                    browseHTML.DocumentText = (string)iData.GetData(DataFormats.Html);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                rtfHTML.Text = ex.Message;
                browseHTML.DocumentText = "";
            }

            string format = "", formatDescription = "FileMaker", result = "";
            if (Clipboard.ContainsData("Mac-XMTB"))
            {
                format = "Mac-XMTB";
                formatDescription = "Table";
            }
            else if (Clipboard.ContainsData("Mac-XMFD"))
            {
                format = "Mac-XMFD";
                formatDescription = "Field";
            }
            else if (Clipboard.ContainsData("Mac-XMSC"))
            {
                format = "Mac-XMSC";
                formatDescription = "Script";
            }
            else if (Clipboard.ContainsData("Mac-XMFN"))
            {
                format = "Mac-XMFN";
                formatDescription = "Custom Function";
            }
            else if (Clipboard.ContainsData("Mac-XMSS"))
            {
                format = "Mac-XMSS";
                formatDescription = "Script Snippet";
            }
            else if (Clipboard.ContainsData("Mac-XML2"))
            {
                format = "Mac-XML2";
                formatDescription = "Layout Object .fmp12";
            }
            else if (Clipboard.ContainsData("Mac-XMLO"))
            {
                format = "Mac-XMLO";
                formatDescription = "Layout Object .fp7";
            }
            else if (Clipboard.ContainsData("Mac-"))
            {
                format = "Mac-";
                formatDescription = "Theme";
            } else
            {
                format = "";
                formatDescription = "Non FileMaker Data";
            }

            // Get the stream off the clipboard.
            System.IO.MemoryStream csdata = null;
            if ( format != "" )
            {
                csdata = (System.IO.MemoryStream)Clipboard.GetData(format);
            
                if (csdata != null )
                {
                    // The first 4 bytes on the clipboard is the size of data on the clipboard.
                    //  https://msdn.microsoft.com/en-us/library/system.windows.forms.clipboard.getdata
                    long offset = 4;
                    csdata.Position = offset;
                    long length = csdata.Length - offset;

                    // Read out the stream to the buffer.
                    // https://msdn.microsoft.com/en-us/library/system.io.stream.read(v=vs.110).aspx
                    byte [] buffer = new byte[length];
                    long readLen = csdata.Read(buffer, 0, (int)length);
                    result = Encoding.UTF8.GetString(buffer);
                    csdata.Dispose();

                    // Set the TextBox to the String encoded in UTF8, or "" if it was not a FileMaker text.
                    fmTextBox.Text = result;
                    XmlDocument fmXML = new XmlDocument();
                    try
                    {
                        fmXML.LoadXml(result);



                    }catch( XmlException e )
                    {
                        MessageBox.Show(e.Message);
                    }
                } 
            }

            fmTextboxTab.Text = "Filemaker: " + formatDescription;
        }

    }

    internal static class NativeMethods
    {
        // See http://msdn.microsoft.com/en-us/library/ms649021%28v=vs.85%29.aspx
        public const int WM_CLIPBOARDUPDATE = 0x031D;
        public static IntPtr HWND_MESSAGE = new IntPtr(-3);

        // See http://msdn.microsoft.com/en-us/library/ms632599%28VS.85%29.aspx#message_only
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        // See http://msdn.microsoft.com/en-us/library/ms633541%28v=vs.85%29.aspx
        // See http://msdn.microsoft.com/en-us/library/ms649033%28VS.85%29.aspx
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        /// <summary>
        /// Removes the given window from the system-maintained clipboard format listener list.
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
    }
}
