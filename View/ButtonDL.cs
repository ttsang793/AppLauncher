using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Diagnostics;
using System.IO;

namespace View
{
    public partial class ButtonDL : UserControl
    {
        private DuLieu dl;
        public ButtonDL(DuLieu dl)
        {
            InitializeComponent();
            this.dl = dl;
            btnTenDL.Text = dl.TenDL;
            iconDL.ImageLocation = dl.Anh;
            btnTenDL.Font = new Font(CusFont.Font("Dosis"), 14F, FontStyle.Regular);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            InfoDL update = new InfoDL(this.dl, "Sửa");
            try
            {
                if (update.ShowDialog() == DialogResult.OK)
                {
                    this.dl = update.GetData();
                    iconDL.ImageLocation = this.dl.Anh;
                    btnTenDL.Text = this.dl.TenDL;
                    DatabaseDL.Update(this.dl);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + btnTenDL.Text + "? Nó sẽ xóa luôn ở cả CSDL?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                DatabaseDL.Delete(dl.MaDL);
                this.Dispose();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDL_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process pro = new Process()
                {
                    StartInfo = new ProcessStartInfo(dl.DuongDan)
                    {
                        WindowStyle = ProcessWindowStyle.Maximized,
                        WorkingDirectory = Path.GetDirectoryName(dl.DuongDan)
                    }
                };
                pro.Start();
            }
            catch
            {
                MessageBox.Show("File/Folder không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
