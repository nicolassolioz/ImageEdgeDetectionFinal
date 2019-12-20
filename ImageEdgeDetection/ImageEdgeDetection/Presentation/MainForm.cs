using ImageEdgeDetection.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetection.Presentation
{
    public partial class MainForm : Form
    {
        private readonly ILogicController logicController;

        public MainForm(ILogicController logicController)
        {
            this.logicController = logicController;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
