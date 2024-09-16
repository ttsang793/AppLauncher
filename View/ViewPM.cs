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
    public partial class ViewPM : Form
    {
        public ViewPM()
        {
            InitializeComponent();
            txtSearch.Font = new Font(CusFont.Font("Dosis"), 16F, FontStyle.Regular);
            readFile();
        }

        private void readFile()
        {
            List<PhanMem> dspm = DatabasePM.Init();
            foreach (PhanMem pm in dspm)
            {
                ButtonPM button = new ButtonPM(pm);
                button.Name = pm.MaPM;
                menuPM.Controls.Add(button);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                MessageBox.Show("Vui lòng nhập phần mềm cần tìm kiếm");
            else
            {
                menuPM.Controls.Clear();
                List<PhanMem> dspm = DatabasePM.Search(txtSearch.Text);
                foreach (PhanMem pm in dspm)
                {
                    ButtonPM button = new ButtonPM(pm);
                    button.Name = pm.MaPM;
                    menuPM.Controls.Add(button);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            menuPM.Controls.Clear();
            readFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InfoPM add = new InfoPM("Thêm");
            try
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    PhanMem pm = add.GetData();
                    ButtonPM button = new ButtonPM(pm);
                    button.Name = pm.MaPM;
                    DatabasePM.Insert(pm);
                    menuPM.Controls.Add(button);
                    MessageBox.Show("Thêm phần mềm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
            catch
            {
                MessageBox.Show("Thêm phần mềm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
