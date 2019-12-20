using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection.IOFiles
{
    public class ReadWriteController : IReadWriteController
    {
        public Bitmap read()
        {
            GetImage getImage = new GetImage();
            return getImage.read();
        }

        public void write(Bitmap importedImg)
        {
            SaveImage saveImage = new SaveImage();
            saveImage.write(importedImg);
        }
    }
}
