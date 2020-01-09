using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection.Dialogs
{

    //SFD = SaveFileDialog
    //This class represents a dialog box we use to save an image
    //We manually create this class in order to test it more efficently
    public class SFD : ISFD
    {
        public SaveFileDialog m_dialog;

        public SFD()
        {
            SaveFileDialog ofd = new SaveFileDialog();
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
