using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VncSharp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);

        private int SYSMENU_ABOUT_ID = 0x1;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About…");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                MessageBoxEx.Show(this, "Custom About Dialog", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                _rd.Connect("localhost", 0, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _rd.Disconnect();
            }
            catch
            {
            }
        }

        private void _rd_ConnectComplete(object sender, ConnectEventArgs e)
        {
            ClientSize = new Size(e.DesktopWidth, e.DesktopHeight);
            Text = e.DesktopName;

            _rd.Focus();
        }
    }
}
