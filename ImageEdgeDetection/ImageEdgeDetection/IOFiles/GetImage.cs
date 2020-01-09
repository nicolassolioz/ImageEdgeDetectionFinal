using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection.IOFiles
{
    public class GetImage
    {
        public Bitmap read()
        {
            Bitmap originalBitmap = null;

            //open dialog in order to load image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|" +
                            "Jpeg Images(*.jpg)|*.jpg|" +
                            "Jpeg Images(*.jpeg)|*.jpeg|" +
                            "Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);           
                streamReader.Close();
            }

            return originalBitmap;
        }
    }
}
