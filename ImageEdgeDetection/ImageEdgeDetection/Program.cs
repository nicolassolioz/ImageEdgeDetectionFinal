using ImageEdgeDetection.Business;
using ImageEdgeDetection.IOFiles;
using ImageEdgeDetection.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IReadWriteController readWrite = new ReadWriteController();
            ILogicController logicController = new LogicController(readWrite);
            Application.Run(new MainForm(logicController));
        }
    }
}
