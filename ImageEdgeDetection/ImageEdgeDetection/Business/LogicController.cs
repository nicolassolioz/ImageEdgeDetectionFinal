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

        public Bitmap prewittEdge(Bitmap importedImg)
        {
            EdgeFilter edgeFilter = new EdgeFilter();
            return importedImg;
            
        }

        public Bitmap gaussianEdge(Bitmap importedImg)
        {
            EdgeFilter edgeFilter = new EdgeFilter();
            return importedImg;
        }


    }
}
