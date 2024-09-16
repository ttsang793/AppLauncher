using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DAL;
using DTO;
using System.IO;

namespace View
{
    public partial class ButtonPM : UserControl
    {
        private PhanMem pm;
        public ButtonPM(PhanMem pm)
        {
            InitializeComponent();
            this.pm = pm;
            iconPM.ImageLocation = pm.Anh;
            btnTenPM.Text = pm.TenPM;
            btnTenPM.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
        }

        private void ButtonPM_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process pro = new Process()
                {
                    StartInfo = new ProcessStartInfo(pm.DuongDan)
                    {
                        WindowStyle = ProcessWindowStyle.Maximized,
                        WorkingDirectory = Path.GetDirectoryName(pm.DuongDan)
                    }
                };
                pro.Start();
            }
            catch
            {
                MessageBox.Show("Chương trình không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            InfoPM update = new InfoPM(this.pm, "Sửa");
            try
            {
                if (update.ShowDialog() == DialogResult.OK)
                {
                    this.pm = update.GetData();
                    iconPM.ImageLocation = this.pm.Anh;
                    btnTenPM.Text = this.pm.TenPM;
                    DatabasePM.Update(this.pm);
                    MessageBox.Show("Sửa phần mềm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa phần mềm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phần mềm? Nó sẽ xóa luôn ở cả CSDL?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                DatabasePM.Delete(pm.MaPM);
                this.Dispose();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
