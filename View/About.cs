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

namespace View
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label2.Font = new Font(CusFont.Font("Dosis"), 14F, FontStyle.Regular);
            label3.Font = new Font(CusFont.Font("Dosis"), 14F, FontStyle.Regular);
            label4.Font = new Font(CusFont.Font("Dosis"), 14F, FontStyle.Regular);
            label5.Font = new Font(CusFont.Font("Dosis"), 10F, FontStyle.Regular);
            label6.Font = new Font(CusFont.Font("Dosis"), 12F, FontStyle.Regular);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
