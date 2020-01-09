using ImageEdgeDetection.Dialogs;
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
        public Bitmap read(IOFD ofd)
        {
            GetImage getImage = new GetImage();
            return getImage.read(ofd);
        }

        public void write(ISFD sfd, Bitmap importedImg)
        {
            SaveImage saveImage = new SaveImage();
            saveImage.write(sfd, importedImg);
        }
    }
}
