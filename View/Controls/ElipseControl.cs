using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace View.Components
{
    class ElipseControl : Control
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
           );

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);


        private void RecreateRegion()
        {
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, _CornerRadius, _CornerRadius);
            Region = Region.FromHrgn(handle);
            DeleteObject(handle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        private int _CornerRadius = 30;

        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                this.RecreateRegion();
            }
        }
    }
}
