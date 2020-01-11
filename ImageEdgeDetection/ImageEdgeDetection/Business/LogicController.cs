using ImageEdgeDetection.Dialogs;
using ImageEdgeDetection.IOFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection.Business
{
    public class LogicController : ILogicController
    {
        private readonly IReadWriteController readWrite;

        public LogicController(IReadWriteController readWrite)
        {
            this.readWrite = readWrite;
        }     

        public Bitmap zenFilter(Bitmap importedImg, int alpha, int red, int blue, int green)
        {
            ImageFilter imageFilter = new ImageFilter();
            return imageFilter.zenFilter(importedImg, alpha, red, blue, green);
        }

        public Bitmap rainbowFilter(Bitmap importedImg)
        {
            ImageFilter imageFilter = new ImageFilter();
            return imageFilter.rainbowFilter(importedImg);
        }

        public Bitmap swapFilter(Bitmap importedImg)
        {
            ImageFilter imageFilter = new ImageFilter();
            return imageFilter.swapFilter(importedImg);
        }

        public Bitmap prewittEdge(Bitmap importedImg)
        {
            EdgeFilter edgeFilter = new EdgeFilter();
            return edgeFilter.prewittEdge(importedImg);
        }

        public Bitmap gaussianEdge(Bitmap importedImg)
        {
            EdgeFilter edgeFilter = new EdgeFilter();
            return edgeFilter.gaussianEdge(importedImg);
        }

        public Bitmap readImage(IOFD ofd)
        {            
            return readWrite.read(ofd);
        }

        public void writeImage(ISFD sfd, Bitmap bitmap)
        {
            readWrite.write(sfd, bitmap);
        }        
    }
}
