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

        private Bitmap previewBitmap = null;
        private Bitmap originalBitmap = null;

        public MainForm(ILogicController logicController)
        {
            this.logicController = logicController;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (previewBitmap != null)
                enableCheckboxes();
        }

        public void ApplyFilter()
        {                               
            previewBitmap = originalBitmap; 
            
            if (previewBitmap != null)
                enableCheckboxes();

            //apply filter to image     
            if (checkBoxZenFilter.Checked)
                previewBitmap = logicController.zenFilter(previewBitmap);

            if (checkBoxRainbowFilter.Checked)
                previewBitmap = logicController.rainbowFilter(previewBitmap);

            if (checkBoxSwapFilter.Checked)
                previewBitmap = logicController.swapFilter(previewBitmap);

            //apply edge detection
            if(radioGaussianEdge.Checked)
                previewBitmap = logicController.gaussianEdge(previewBitmap);
            else if(radioPrewittEdge.Checked)
                previewBitmap = logicController.prewittEdge(previewBitmap);


            //activate "next" button only if one or two checkboxes are activated
            if (checkBoxZenFilter.Checked || checkBoxRainbowFilter.Checked || checkBoxSwapFilter.Checked)        
                enableRadiobutton();
            else disableRadiobutton();



            if (radioNone.Checked || radioGaussianEdge.Checked || radioPrewittEdge.Checked)
                enableSavebutton();
            else disableSavebutton();

            picPreview.Image = previewBitmap;
        }

       

        // button action IO
        private void buttonSave_Click(object sender, EventArgs e)
        {
            logicController.writeImage(previewBitmap);
            ApplyFilter();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            originalBitmap = logicController.readImage();
            ApplyFilter();
        }

        // filters action event
        private void checkBoxSwapFilter_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void checkBoxRainbowFilter_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void checkBoxZenFilter_CheckedChanged(object sender, EventArgs e)
        {            
            ApplyFilter();
        }


        //radio action event
        private void radioGaussianEdge_CheckedChanged(object sender, EventArgs e)
        {            
            ApplyFilter();
        }

        private void radioPrewittEdge_CheckedChanged(object sender, EventArgs e)
        {            
            ApplyFilter();
        }


        // enable/disable group elements
        public void enableCheckboxes()
        {
            checkBoxRainbowFilter.Enabled = true;
            checkBoxSwapFilter.Enabled = true;
            checkBoxZenFilter.Enabled = true;
        }

        private void enableRadiobutton()
        {
            radioGaussianEdge.Enabled = true;
            radioPrewittEdge.Enabled = true;
            radioNone.Enabled = true;
        } 
        private void disableRadiobutton()
        {
            radioGaussianEdge.Enabled = false;
            radioGaussianEdge.Checked = false;
            radioPrewittEdge.Enabled = false;
            radioPrewittEdge.Checked = false;
            radioNone.Enabled = false;
            radioNone.Checked = false;

        }

        private void enableSavebutton()
        {
            buttonSave.Enabled = true;
        }
        private void disableSavebutton()
        {
            buttonSave.Enabled = false;
        }

      



    }
}
