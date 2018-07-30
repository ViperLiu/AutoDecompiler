using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASToolBox
{
    class ScreenCapture
    {
        public static void Capture(TextBox myControl, string filename)
        {
            Graphics g = myControl.CreateGraphics();
            //new bitmap object to save the image        
            Bitmap bmp = new Bitmap(myControl.Width, myControl.Height);
            //Drawing control to the bitmap        
            myControl.DrawToBitmap(bmp, new Rectangle(0, 0, myControl.Width, myControl.Height));
            bmp.Save(filename, ImageFormat.Jpeg);
            bmp.Dispose();
        }

        public static void Capture(RichTextBox rtb, string filename)
        {
            rtb.Update();  // Ensure RTB fully painted
            Bitmap bmp = new Bitmap(rtb.Width, rtb.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(rtb.PointToScreen(Point.Empty), Point.Empty, rtb.Size);
            }
            bmp.Save(filename, ImageFormat.Jpeg);
            bmp.Dispose();
        }
    }
}
