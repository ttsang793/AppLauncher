using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace View
{
    public partial class InfoDL : Form
    {
        private string MaDL;
        private string duoiFile;
        private bool defaultIcon;
        public InfoDL(string usage)
        {
            InitializeComponent();
            /*
            txtTenDL.Text = "Tên file/folder";
            txtDuongDan.Text = @"VD: C:\hello.exe";
            txtTenDL.ForeColor = Color.LightGray;
            txtDuongDan.ForeColor = Color.LightGray;*/
            btnAdd.Text = usage;
            lblTitle.Text = usage + " file/folder";
            txtTenDL.Font = txtDuongDan.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
        }

        public InfoDL(DuLieu dl, string usage)
        {
            InitializeComponent();
            this.MaDL = dl.MaDL;
            txtTenDL.Text = dl.TenDL;
            txtDuongDan.Text = dl.DuongDan;
            iconDL.ImageLocation = dl.Anh;
            btnAdd.Text = usage;
            lblTitle.Text = usage + " file/folder";
            txtTenDL.Font = txtDuongDan.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
        }

        internal DuLieu GetData()
        {
            if (!defaultIcon)
            {
                string Anh = string.Format("iconDL\\{0}.png", Path.GetFileNameWithoutExtension(txtDuongDan.Text));
                iconDL.Image.Save(Anh, ImageFormat.Png);
            }

            if (!string.IsNullOrEmpty(MaDL))
                return new DuLieu(MaDL, txtTenDL.Text, txtDuongDan.Text, duoiFile, iconDL.ImageLocation);
            return new DuLieu(DatabaseDL.CreateMaDL(), txtTenDL.Text, txtDuongDan.Text, duoiFile, iconDL.ImageLocation);
        }

        private void iconDL_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog()
            {
                Multiselect = false,
                InitialDirectory = Path.GetFullPath(".\\iconDL")
            };
            ofd.Filters.Add(new CommonFileDialogFilter("Image Files", "*.JPG; *.PNG; *.GIF; *.JPEG; *.BMP"));
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                iconDL.ImageLocation = ofd.FileName;
                defaultIcon = false;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog()
            {
                Multiselect = false,
                IsFolderPicker = true
            };
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtTenDL.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                txtDuongDan.Text = ofd.FileName;
                iconDL.ImageLocation = @"iconDL\folder.png";
                defaultIcon = true;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog()
            {
                Multiselect = false
            };
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtTenDL.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                txtDuongDan.Text = ofd.FileName;
                defaultIcon = true;
                duoiFile = Path.GetExtension(ofd.FileName);
                switch (duoiFile)
                {
                    case ".pdf":
                        iconDL.ImageLocation = @"iconDL\pdf.png";
                        break;
                    case ".doc": case ".docx":
                        iconDL.ImageLocation = @"iconDL\word.png";
                        break;
                    case ".xls": case ".xlsx":
                        iconDL.ImageLocation = @"iconDL\excel.png";
                        break;
                    case ".ppt": case ".pptx":
                        iconDL.ImageLocation = @"iconDL\ppt.png";
                        break;
                    case ".txt": case ".rtf":
                        iconDL.ImageLocation = @"iconDL\txt.png";
                        break;
                    case ".jpg": case ".jpeg": case ".png": case ".gif": case ".bmp": case ".webp":
                        iconDL.ImageLocation = @"iconDL\photo.png";
                        break;
                    case ".mp3": case ".wav": case ".mp4": case ".wmv": case ".ogg":
                        iconDL.ImageLocation = @"iconDL\media.png";
                        break;
                    default:
                        iconDL.ImageLocation = @"iconDL\file.png";
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDL.Text) || string.IsNullOrEmpty(txtDuongDan.Text)
                || iconDL.Image == null)
            {
                MessageBox.Show("Dữ liệu không đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (duoiFile != null && !File.Exists(txtDuongDan.Text))
            {
                MessageBox.Show("File không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (duoiFile == null && !Directory.Exists(txtDuongDan.Text))
            {
                MessageBox.Show("Folder không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(255, 0, 152, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Bold);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LightGray;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Font = new Font(btnAdd.Font, FontStyle.Regular);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(255, 152, 0, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Font = new Font(btnAdd.Font, FontStyle.Bold);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LightGray;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Font = new Font(btnAdd.Font, FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
