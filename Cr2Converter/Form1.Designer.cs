namespace Cr2Converter
{
    partial class Form1
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
            this.btnExtractJPG = new System.Windows.Forms.Button();
            this.buttonCr2Folder = new System.Windows.Forms.Button();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstCr2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKeepAspect = new System.Windows.Forms.CheckBox();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtractJPG
            // 
            this.btnExtractJPG.Location = new System.Drawing.Point(447, 92);
            this.btnExtractJPG.Name = "btnExtractJPG";
            this.btnExtractJPG.Size = new System.Drawing.Size(120, 39);
            this.btnExtractJPG.TabIndex = 5;
            this.btnExtractJPG.Text = "Extract jpg from CR2";
            this.btnExtractJPG.UseVisualStyleBackColor = true;
            this.btnExtractJPG.Click += new System.EventHandler(this.buttonExtractJPG_Click);
            // 
            // buttonCr2Folder
            // 
            this.buttonCr2Folder.Location = new System.Drawing.Point(447, 12);
            this.buttonCr2Folder.Name = "buttonCr2Folder";
            this.buttonCr2Folder.Size = new System.Drawing.Size(120, 23);
            this.buttonCr2Folder.TabIndex = 11;
            this.buttonCr2Folder.Text = "Select CR2 folder";
            this.buttonCr2Folder.UseVisualStyleBackColor = true;
            this.buttonCr2Folder.Click += new System.EventHandler(this.buttonCr2Folder_Click);
            // 
            // txtInputDir
            // 
            this.txtInputDir.Location = new System.Drawing.Point(12, 12);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(406, 20);
            this.txtInputDir.TabIndex = 12;
            this.txtInputDir.TextChanged += new System.EventHandler(this.txtInputDir_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // lstCr2
            // 
            this.lstCr2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstCr2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCr2.Location = new System.Drawing.Point(0, 170);
            this.lstCr2.Name = "lstCr2";
            this.lstCr2.Size = new System.Drawing.Size(644, 272);
            this.lstCr2.TabIndex = 14;
            this.lstCr2.UseCompatibleStateImageBehavior = false;
            this.lstCr2.View = System.Windows.Forms.View.Details;
            this.lstCr2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstCr2_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 369;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 225;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDelete);
            this.groupBox2.Controls.Add(this.chkRotate);
            this.groupBox2.Controls.Add(this.chkOverwrite);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 114);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(17, 76);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(169, 17);
            this.chkDelete.TabIndex = 13;
            this.chkDelete.Text = "Delete original file (recycle bin)";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(17, 53);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(117, 17);
            this.chkRotate.TabIndex = 12;
            this.chkRotate.Text = "Rotate if necessary";
            this.chkRotate.UseVisualStyleBackColor = true;
            this.chkRotate.CheckedChanged += new System.EventHandler(this.chkRotate_CheckedChanged);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(17, 30);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(103, 17);
            this.chkOverwrite.TabIndex = 11;
            this.chkOverwrite.Text = "Overwrite if exist";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            this.chkOverwrite.CheckedChanged += new System.EventHandler(this.chkOverwrite_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKeepAspect);
            this.groupBox1.Controls.Add(this.chkResize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numHeight);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Location = new System.Drawing.Point(218, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resize to";
            // 
            // chkKeepAspect
            // 
            this.chkKeepAspect.AutoSize = true;
            this.chkKeepAspect.Enabled = false;
            this.chkKeepAspect.Location = new System.Drawing.Point(9, 86);
            this.chkKeepAspect.Name = "chkKeepAspect";
            this.chkKeepAspect.Size = new System.Drawing.Size(86, 17);
            this.chkKeepAspect.TabIndex = 15;
            this.chkKeepAspect.Text = "Keep aspect";
            this.chkKeepAspect.UseVisualStyleBackColor = true;
            this.chkKeepAspect.CheckedChanged += new System.EventHandler(this.chkKeepAspect_CheckedChanged);
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Location = new System.Drawing.Point(9, 19);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(70, 17);
            this.chkResize.TabIndex = 14;
            this.chkResize.Text = "Resize to";
            this.chkResize.UseVisualStyleBackColor = true;
            this.chkResize.CheckedChanged += new System.EventHandler(this.chkResize_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // numHeight
            // 
            this.numHeight.Enabled = false;
            this.numHeight.Location = new System.Drawing.Point(92, 60);
            this.numHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(60, 20);
            this.numHeight.TabIndex = 1;
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.Enabled = false;
            this.numWidth.Location = new System.Drawing.Point(5, 60);
            this.numWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(60, 20);
            this.numWidth.TabIndex = 0;
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstCr2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtInputDir);
            this.Controls.Add(this.buttonCr2Folder);
            this.Controls.Add(this.btnExtractJPG);
            this.Name = "Form1";
            this.Text = "Convert CR2 to JPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExtractJPG;
        private System.Windows.Forms.Button buttonCr2Folder;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ListView lstCr2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.CheckBox chkKeepAspect;
    }
}

