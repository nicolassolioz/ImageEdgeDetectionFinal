using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection.Business
{
    public interface ILogicController
    {
        Bitmap prewittEdge(Bitmap importedImg);
        Bitmap gaussianEdge(Bitmap importedImg);
        Bitmap zenFilter(Bitmap bmp);
        Bitmap rainbowFilter(Bitmap bmp);
        Bitmap swapFilter(Bitmap bmp);

    }
}
