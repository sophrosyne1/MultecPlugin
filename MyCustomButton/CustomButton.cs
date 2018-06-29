using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomButton
{
    public partial class MyCustomButton: PictureBox
    {
        public MyCustomButton()
        {
            InitializeComponent();
            
        }

        private Image NormalImage;
        private Image ClickedImage;

        public Image ImangeNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
        public Image ImageClicked
        {
            get { return ClickedImage; }
            set { ClickedImage = value; }
        }
      
        private void MyCustomButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (HitTest(this, e.X, e.Y))
                this.Image = ClickedImage;

        }

        private void MyCustomButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Enabled)
                this.Image = NormalImage;
            
        }


        public bool HitTest(PictureBox control, int x, int y)
        {
            var result = false;
            if (control.Image == null)
                return result;
            var method = typeof(PictureBox).GetMethod("ImageRectangleFromSizeMode",
              System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var r = (Rectangle)method.Invoke(control, new object[] { control.SizeMode});
            using (var bm = new Bitmap(r.Width, r.Height))
            {
                using (var g = Graphics.FromImage(bm))
                    g.DrawImage(control.Image, 0, 0, r.Width, r.Height);
                if (r.Contains(x, y) && bm.GetPixel(x - r.X, y - r.Y).A != 0)
                    result = true;
            }
            return result;
        }

        private void MyCustomButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void MyCustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
