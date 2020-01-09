using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection.IOFiles
{

    //OFD = OpenFileDialog
    //Cette classe représente la boîte de dialogue que l'utilisateur utilise pour charger une image
    
    public class OFD : IOFD
    {
        public OpenFileDialog m_dialog;

        public OFD()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            this.m_dialog = ofd;
        }
        public DialogResult ShowDialog()
        {
            return m_dialog.ShowDialog();
        }

        public string Title
        {
            get { return m_dialog.Title; }
            set { m_dialog.Title = value; }
        }

        public string FileName
        {
            get { return m_dialog.FileName; }
            set { m_dialog.FileName = value; }
        }

        public string Filter
        {
            get { return m_dialog.Filter; }
            set { m_dialog.Filter = value; }
        }

        

    }
}
