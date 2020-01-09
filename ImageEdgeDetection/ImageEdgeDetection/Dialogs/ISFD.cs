﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection.Dialogs
{
    public interface ISFD
    {
        DialogResult ShowDialog();
        string Title { get; set; }
        string Filter { get; set; }
        string FileName { get; set; }

    }
}
