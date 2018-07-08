using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;

namespace Cr2Converter
{
    public partial class Form1 : Form
    {
        string m_ext = ".jpg";

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            lblMessage.Text = "";
            progressBar.Visible = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().Init("TGMT cr2 to jpg");
            chkOverwrite.Checked = TGMTregistry.GetInstance().ReadRegValueBool("chkOverwrite");
            chkRotate.Checked = TGMTregistry.GetInstance().ReadRegValueBool("chkRotate");
            chkDelete.Checked = TGMTregistry.GetInstance().ReadRegValueBool("chkDelete");
            chkResize.Checked = TGMTregistry.GetInstance().ReadRegValueBool("chkResize");
            chkKeepAspect.Checked = TGMTregistry.GetInstance().ReadRegValueBool("chkKeepAspect");

            numWidth.Value = TGMTregistry.GetInstance().ReadRegValueInt("numWidth");
            numHeight.Value = TGMTregistry.GetInstance().ReadRegValueInt("numHeight");

            this.KeyPreview = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonCr2Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.RootFolder = Environment.SpecialFolder.Desktop;
            d.ShowNewFolderButton = false;
            d.Description = "Choose a folder containing raw (.CR2) files:";

            if (DialogResult.OK == d.ShowDialog())
            {
                txtInputDir.Text = d.SelectedPath;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonExtractJPG_Click(object sender, EventArgs e)
        {
            if(lstCr2.Items.Count == 0)
            {
                return;
            }
            progressBar.Visible = true;
            progressBar.Value = 0;
            lblMessage.Text = "Processing...";
            int nbExtracted = 0;


            foreach (ListViewItem item in lstCr2.Items)
            {
                string filePath = item.Text;
                if (File.Exists(filePath))
                {                    
                    string baseName = Path.GetFileNameWithoutExtension(filePath);
                    string outDir = Path.GetDirectoryName(filePath) + "\\";
                    baseName = outDir + baseName;
                    string jpgName = baseName + m_ext;

                    if (!chkOverwrite.Checked && File.Exists(jpgName))
                    {
                        int version = 1;

                        do
                        {
                            jpgName = String.Format("{0}_{1}" + m_ext, baseName, version);
                            ++version;
                        }
                        while (File.Exists(jpgName));
                    }

                    Size size = new Size();
                    if(chkResize.Checked )
                    {
                        if(chkKeepAspect.Checked && numWidth.Value > 0 )
                            size = new Size((int)numWidth.Value, 0);
                        else if(numWidth.Value > 0 && numHeight.Value > 0)
                            size = new Size((int)numWidth.Value, (int)numHeight.Value);
                    }
                    
                    if(TGMTimage.ConvertCr2(filePath, jpgName, chkRotate.Checked, size))
                    {
                        progressBar.Value = ++nbExtracted;
                        if (item.SubItems.Count == 1)
                        {
                            item.SubItems.Add("done");
                        }
                        else
                        {
                            item.SubItems[1].Text = "done";
                        }
                        item.ForeColor = Color.Green;
                        if (chkDelete.Checked)
                        {
                            FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        }
                    }                    
                }
                else //file does not exist
                {
                    if (item.SubItems.Count == 1)
                    {
                        item.SubItems.Add("File not exist");
                    }
                    else
                    {
                        item.SubItems[1].Text = "File not exist";
                    }
                    item.ForeColor = Color.Red;
                }
            }

            lblMessage.Text = "Complete";
            progressBar.Visible = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txtInputDir_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] cr2Files = Directory.GetFiles(txtInputDir.Text, "*.CR2");
                if (cr2Files.Length > 0)
                {
                    for (int i = 0; i != cr2Files.Length; ++i)
                    {
                        lstCr2.Items.Add(cr2Files[i]);
                    }

                    progressBar.Maximum = cr2Files.Length;
                }
                else
                {
                    lblMessage.Text = "No raw (.CR2) files in folder.";
                }
            }
            catch (DirectoryNotFoundException)
            {
                lblMessage.Text = "Invalid folder name.";
            }


            progressBar.Value = 0;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < files.Length; i++)
            {
                string f = files[i];
                string ext = Path.GetExtension(f);
                if (ext.ToLower() == ".cr2")
                {
                    lstCr2.Items.Add(f);
                }
            }

            btnExtractJPG.Enabled = lstCr2.Items.Count > 0;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveRegValue("chkDelete", chkDelete.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chkOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveRegValue("chkOverwrite", chkOverwrite.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chkRotate_CheckedChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveRegValue("chkRotate", chkRotate.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        void ShortcutKey(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in lstCr2.Items)
                {
                    item.Selected = true;
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in lstCr2.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ShortcutKey(e);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lstCr2_KeyUp(object sender, KeyEventArgs e)
        {
            ShortcutKey(e);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chkResize_CheckedChanged(object sender, EventArgs e)
        {
            numWidth.Enabled = chkResize.Checked;
            numHeight.Enabled = chkResize.Checked;
            chkKeepAspect.Enabled = chkResize.Checked;
            TGMTregistry.GetInstance().SaveRegValue("chkResize", chkResize.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chkKeepAspect_CheckedChanged(object sender, EventArgs e)
        {
            numHeight.Enabled = !chkKeepAspect.Checked;
            numHeight.Value = 0;
            TGMTregistry.GetInstance().SaveRegValue("chkKeepAspect", chkKeepAspect.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveRegValue("numWidth", numWidth.Value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveRegValue("numHeight", numHeight.Value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void rdJpg_CheckedChanged(object sender, EventArgs e)
        {
            m_ext = ".jpg";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void rdPng_CheckedChanged(object sender, EventArgs e)
        {
            m_ext = ".png";
        }
    }
}
