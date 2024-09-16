using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace View
{
    public partial class ViewDL : Form
    {
        public ViewDL()
        {
            InitializeComponent();
            txtSearch.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
            readFile();
        }

        private void readFile()
        {
            List<DuLieu> dsdl = DatabaseDL.Init();
            foreach (DuLieu dl in dsdl)
            {
                ButtonDL button = new ButtonDL(dl);
                button.Name = dl.MaDL;
                menuDL.Controls.Add(button);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                MessageBox.Show("Vui lòng nhập file/folder cần tìm kiếm");
            else
            {
                menuDL.Controls.Clear();
                List<DuLieu> dsdl = DatabaseDL.Search(txtSearch.Text);
                foreach (DuLieu dl in dsdl)
                {
                    ButtonDL button = new ButtonDL(dl);
                    button.Name = dl.MaDL;
                    menuDL.Controls.Add(button);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            menuDL.Controls.Clear();
            readFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InfoDL add = new InfoDL("Thêm");
            try
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    DuLieu dl = add.GetData();
                    ButtonDL button = new ButtonDL(dl);
                    button.Name = dl.MaDL;
                    DatabaseDL.Insert(dl);
                    menuDL.Controls.Add(button);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
