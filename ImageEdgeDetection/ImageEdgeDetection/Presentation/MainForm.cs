using ImageEdgeDetection.Business;
using ImageEdgeDetection.Dialogs;
using ImageEdgeDetection.IOFiles;
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
                previewBitmap = logicController.zenFilter(previewBitmap,1,10,1,1);

            if (checkBoxRainbowFilter.Checked)
                previewBitmap = logicController.rainbowFilter(previewBitmap);

            if (checkBoxSwapFilter.Checked)
                previewBitmap = logicController.swapFilter(previewBitmap);

            //apply edge detection
            if(radioGaussianEdge.Checked)
                previewBitmap = logicController.gaussianEdge(previewBitmap);
            else if(radioPrewittEdge.Checked)
                previewBitmap = logicController.prewittEdge(previewBitmap);

            //activate radio buttons only if one or more checkboxes are checked
            if (checkBoxZenFilter.Checked || checkBoxRainbowFilter.Checked || checkBoxSwapFilter.Checked)        
                enableRadiobutton();
            else disableRadiobutton();

            //activate "Save" button only if one radio button is activated
            if (radioNone.Checked || radioGaussianEdge.Checked || radioPrewittEdge.Checked)
                enableSavebutton();
            else disableSavebutton();

            picPreview.Image = previewBitmap;
        }       

        // button action IO
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ISFD sfd = new SFD();


            logicController.writeImage(sfd, previewBitmap);
            ApplyFilter();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            IOFD ofd = new OFD();
            
            originalBitmap = logicController.readImage(ofd);
            disableCheckboxes();
            disableRadiobutton();            
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

        private void radioNone_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        // enable filter checkbox when image is load
        public void enableCheckboxes()
        {
            checkBoxRainbowFilter.Enabled = true;
            checkBoxSwapFilter.Enabled = true;
            checkBoxZenFilter.Enabled = true;
        }      

        // when a filter is select, enable all radio button
        private void enableRadiobutton()
        {
            radioGaussianEdge.Enabled = true;
            radioPrewittEdge.Enabled = true;
            radioNone.Enabled = true;
        } 

        // when all filter are unchecked, reset and disable radio button
        private void disableRadiobutton()
        {
            radioGaussianEdge.Enabled = false;
            radioGaussianEdge.Checked = false;
            radioPrewittEdge.Enabled = false;
            radioPrewittEdge.Checked = false;
            radioNone.Enabled = false;
            radioNone.Checked = false;
        }

        // If load a new picture, reset all filters
        public void disableCheckboxes()
        {
            checkBoxRainbowFilter.Enabled = false;
            checkBoxRainbowFilter.Checked = false;
            checkBoxSwapFilter.Enabled = false;
            checkBoxSwapFilter.Checked = false;
            checkBoxZenFilter.Enabled = false;
            checkBoxZenFilter.Checked = false;
        }

        // enable save button if one or more filter are cheked and if a radio button is checked, disable it otherwise
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
