using Atmorithm.Helper;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class PictureViewer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private bool _moveAble;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public PictureViewer(bool moveAble, bool showBorders, bool showInTaskbar)
        {
            InitializeComponent();
            _moveAble = moveAble;
            this.ShowInTaskbar = showInTaskbar;
            if (showBorders)
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;

        }

        public void ChangePicture(string nextPicture)
        {
            this.pictureBox.Image = FileHelper.GetPictureAsImage(nextPicture);
        }

        public void ChangeScreenAndMaximize(Screen destinationScreen)
        {
            ChangeScreen(destinationScreen);
            MaximizeForm();
        }

        public void ChangeScreenAndReset(Screen destinationScreen, Point newLocation)
        {
            ChangeScreen(destinationScreen);
            ChangePosition(newLocation);
            ResetForm();
        }

        private void ChangePosition(Point newLocation)
        {
            this.Location = newLocation;
        }

        public void ChangeScreen(Screen destinationScreen)
        {
            this.Top = destinationScreen.WorkingArea.Top;
            this.Left = destinationScreen.WorkingArea.Left;
        }

        public void MaximizeForm()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void ResetForm()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void PictureViewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _moveAble)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
