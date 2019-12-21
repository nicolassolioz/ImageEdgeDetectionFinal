using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using ImageEdgeDetection.Business.Calculations;

namespace ImageEdgeDetection.Business
{
    class EdgeFilter
    {
        public Bitmap prewittEdge(Bitmap importedImg)
        {
            Bitmap modifiedImg = ExtBitmap.PrewittFilter(importedImg, false);
            return modifiedImg;
        }

        public Bitmap gaussianEdge(Bitmap importedImg)
        {
            Bitmap modifiedImg = ExtBitmap.LaplacianOfGaussianFilter(importedImg);
            return modifiedImg;
        }
    }
}
