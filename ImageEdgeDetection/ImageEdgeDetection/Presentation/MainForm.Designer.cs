using System.Windows.Forms;
using System.Drawing;

namespace ImageEdgeDetection.Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxSwapFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxRainbowFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxZenFilter = new System.Windows.Forms.CheckBox();
            this.radioGaussianEdge = new System.Windows.Forms.RadioButton();
            this.radioPrewittEdge = new System.Windows.Forms.RadioButton();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelEdge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.AccessibleName = "picPreview";
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(628, 596);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 614);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(193, 70);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(557, 614);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(193, 70);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxSwapFilter
            // 
            this.checkBoxSwapFilter.AutoSize = true;
            this.checkBoxSwapFilter.Location = new System.Drawing.Point(649, 96);
            this.checkBoxSwapFilter.Name = "checkBoxSwapFilter";
            this.checkBoxSwapFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSwapFilter.TabIndex = 16;
            this.checkBoxSwapFilter.Text = "checkBoxSwapFilter";
            this.checkBoxSwapFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxRainbowFilter
            // 
            this.checkBoxRainbowFilter.AutoSize = true;
            this.checkBoxRainbowFilter.Location = new System.Drawing.Point(649, 130);
            this.checkBoxRainbowFilter.Name = "checkBoxRainbowFilter";
            this.checkBoxRainbowFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRainbowFilter.TabIndex = 17;
            this.checkBoxRainbowFilter.Text = "checkBoxRainbowFilter";
            this.checkBoxRainbowFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxZenFilter
            // 
            this.checkBoxZenFilter.AutoSize = true;
            this.checkBoxZenFilter.Location = new System.Drawing.Point(649, 168);
            this.checkBoxZenFilter.Name = "checkBoxZenFilter";
            this.checkBoxZenFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBoxZenFilter.TabIndex = 18;
            this.checkBoxZenFilter.Text = "checkBoxZenFilter";
            this.checkBoxZenFilter.UseVisualStyleBackColor = true;
            // 
            // radioGaussianEdge
            // 
            this.radioGaussianEdge.AutoSize = true;
            this.radioGaussianEdge.Location = new System.Drawing.Point(649, 328);
            this.radioGaussianEdge.Name = "radioGaussianEdge";
            this.radioGaussianEdge.Size = new System.Drawing.Size(85, 17);
            this.radioGaussianEdge.TabIndex = 19;
            this.radioGaussianEdge.TabStop = true;
            this.radioGaussianEdge.Text = "radioGaussianEdge";
            this.radioGaussianEdge.UseVisualStyleBackColor = true;
            // 
            // radioPrewittEdge
            // 
            this.radioPrewittEdge.AutoSize = true;
            this.radioPrewittEdge.Location = new System.Drawing.Point(649, 375);
            this.radioPrewittEdge.Name = "radioPrewittEdge";
            this.radioPrewittEdge.Size = new System.Drawing.Size(85, 17);
            this.radioPrewittEdge.TabIndex = 20;
            this.radioPrewittEdge.TabStop = true;
            this.radioPrewittEdge.Text = "radioPrewittEdge";
            this.radioPrewittEdge.UseVisualStyleBackColor = true;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(649, 424);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(85, 17);
            this.radioNone.TabIndex = 21;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "radioNone";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(646, 50);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(35, 13);
            this.labelFilter.TabIndex = 22;
            this.labelFilter.Text = "labelFilter";
            // 
            // labelEdge
            // 
            this.labelEdge.AutoSize = true;
            this.labelEdge.Location = new System.Drawing.Point(646, 287);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(35, 13);
            this.labelEdge.TabIndex = 23;
            this.labelEdge.Text = "labelEdge";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 696);
            this.Controls.Add(this.labelEdge);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.radioNone);
            this.Controls.Add(this.radioPrewittEdge);
            this.Controls.Add(this.radioGaussianEdge);
            this.Controls.Add(this.checkBoxZenFilter);
            this.Controls.Add(this.checkBoxRainbowFilter);
            this.Controls.Add(this.checkBoxSwapFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.picPreview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected PictureBox picPreview;
        private Button buttonLoad;
        private Button buttonSave;
        private CheckBox checkBoxSwapFilter;
        private CheckBox checkBoxRainbowFilter;
        private CheckBox checkBoxZenFilter;
        private RadioButton radioGaussianEdge;
        private RadioButton radioPrewittEdge;
        private RadioButton radioNone;
        private Label labelFilter;
        private Label labelEdge;
    }
}