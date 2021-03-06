﻿using ImageEdgeDetection.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection.IOFiles
{
    public interface IReadWriteController
    {
        void write(ISFD sfd, Bitmap importedImg);
        Bitmap read(IOFD ofd);
    }
}
