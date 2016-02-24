namespace FontVis
{
    partial class MainFrm
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
            this.fontsList = new System.Windows.Forms.ListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.contSample = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTry = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckItalic = new System.Windows.Forms.CheckBox();
            this.ckBold = new System.Windows.Forms.CheckBox();
            this.numFontSz = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSz)).BeginInit();
            this.SuspendLayout();
            // 
            // fontsList
            // 
            this.fontsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontsList.FormattingEnabled = true;
            this.fontsList.IntegralHeight = false;
            this.fontsList.Location = new System.Drawing.Point(0, 23);
            this.fontsList.Name = "fontsList";
            this.fontsList.ScrollAlwaysVisible = true;
            this.fontsList.Size = new System.Drawing.Size(138, 431);
            this.fontsList.Sorted = true;
            this.fontsList.TabIndex = 0;
            this.fontsList.SelectedIndexChanged += new System.EventHandler(this.fontsList_SelectedIndexChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFolder.Location = new System.Drawing.Point(0, 0);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(138, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "Select Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fontsList);
            this.splitContainer1.Panel1.Controls.Add(this.btnFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(623, 454);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.contSample);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtTry);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(481, 454);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // contSample
            // 
            this.contSample.AllowDrop = true;
            this.contSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contSample.Location = new System.Drawing.Point(0, 0);
            this.contSample.Name = "contSample";
            this.contSample.Size = new System.Drawing.Size(481, 300);
            this.contSample.TabIndex = 0;
            this.contSample.DragDrop += new System.Windows.Forms.DragEventHandler(this.contSample_DragDrop);
            this.contSample.DragEnter += new System.Windows.Forms.DragEventHandler(this.contSample_DragEnter);
            // 
            // txtTry
            // 
            this.txtTry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTry.Location = new System.Drawing.Point(0, 0);
            this.txtTry.Multiline = true;
            this.txtTry.Name = "txtTry";
            this.txtTry.Size = new System.Drawing.Size(418, 150);
            this.txtTry.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckItalic);
            this.panel1.Controls.Add(this.ckBold);
            this.panel1.Controls.Add(this.numFontSz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 150);
            this.panel1.TabIndex = 3;
            // 
            // ckItalic
            // 
            this.ckItalic.AutoSize = true;
            this.ckItalic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckItalic.Location = new System.Drawing.Point(6, 50);
            this.ckItalic.Name = "ckItalic";
            this.ckItalic.Size = new System.Drawing.Size(49, 17);
            this.ckItalic.TabIndex = 1;
            this.ckItalic.Text = "Italic";
            this.ckItalic.UseVisualStyleBackColor = true;
            this.ckItalic.CheckedChanged += new System.EventHandler(this.ckItalic_CheckedChanged);
            // 
            // ckBold
            // 
            this.ckBold.AutoSize = true;
            this.ckBold.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBold.Location = new System.Drawing.Point(6, 27);
            this.ckBold.Name = "ckBold";
            this.ckBold.Size = new System.Drawing.Size(50, 17);
            this.ckBold.TabIndex = 1;
            this.ckBold.Text = "Bold";
            this.ckBold.UseVisualStyleBackColor = true;
            this.ckBold.CheckedChanged += new System.EventHandler(this.ckBold_CheckedChanged);
            // 
            // numFontSz
            // 
            this.numFontSz.Location = new System.Drawing.Point(6, 0);
            this.numFontSz.Name = "numFontSz";
            this.numFontSz.Size = new System.Drawing.Size(50, 21);
            this.numFontSz.TabIndex = 0;
            this.numFontSz.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numFontSz.ValueChanged += new System.EventHandler(this.numFontSz_ValueChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 454);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainFrm";
            this.Text = "FontVis";
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fontsList;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel contSample;
        private System.Windows.Forms.TextBox txtTry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckItalic;
        private System.Windows.Forms.CheckBox ckBold;
        private System.Windows.Forms.NumericUpDown numFontSz;
    }
}

