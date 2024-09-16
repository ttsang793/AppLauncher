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
    public partial class InfoPM : Form
    {
        private string MaPM;
        public InfoPM(string usage)
        {
            InitializeComponent();
            /*
            txtTenPM.Text = "Tên phần mềm";
            txtDuongDan.Text = @"VD: C:\hello.exe";
            txtTenPM.ForeColor = Color.LightGray;
            txtDuongDan.ForeColor = Color.LightGray;*/
            btnAdd.Text = usage;
            lblTitle.Text = usage + " phần mềm";
            txtTenPM.Font = txtDuongDan.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
        }

        public InfoPM(PhanMem pm, string usage)
        {
            InitializeComponent();
            this.MaPM = pm.MaPM;
            txtTenPM.Text = pm.TenPM;
            txtDuongDan.Text = pm.DuongDan;
            iconPM.ImageLocation = pm.Anh;
            btnAdd.Text = usage;
            lblTitle.Text = usage + " phần mềm";
            txtTenPM.Font = txtDuongDan.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
        }

        internal PhanMem GetData()
        {
            string Anh = string.Format("iconPM\\{0}.png", Path.GetFileNameWithoutExtension(txtDuongDan.Text));
            iconPM.Image.Save(Anh, ImageFormat.Png);

            if (!string.IsNullOrEmpty(MaPM))
                return new PhanMem(MaPM, txtTenPM.Text, txtDuongDan.Text, Anh);
            return new PhanMem(DatabasePM.CreateMaPM(), txtTenPM.Text, txtDuongDan.Text, Anh);
        }

        private void iconPM_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog()
            {
                Multiselect = false,
                InitialDirectory = Path.GetFullPath(".\\iconPM")
            };
            ofd.Filters.Add(new CommonFileDialogFilter("Image Files", "*.JPG; *.PNG; *.GIF; *.JPEG; *.BMP"));
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
                iconPM.ImageLocation = ofd.FileName;
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog()
            {
                Multiselect = false
            };
            ofd.Filters.Add(new CommonFileDialogFilter("Executable Files", "*.exe"));
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtTenPM.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                txtDuongDan.Text = ofd.FileName;
                iconPM.Image = Bitmap.FromHicon(Icon.ExtractAssociatedIcon(ofd.FileName).Handle);
            }
        }

        private void btnLink_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnLink_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPM.Text) || string.IsNullOrEmpty(txtDuongDan.Text)
                || iconPM.Image == null)
            {
                MessageBox.Show("Phần mềm không đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!System.IO.File.Exists(txtDuongDan.Text))
            {
                MessageBox.Show("Phần mềm không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
