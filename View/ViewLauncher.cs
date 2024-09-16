using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ViewLauncher : Form
    {
        public ViewLauncher()
        {
            InitializeComponent();
        }

        private void ViewLauncher_Load(object sender, EventArgs e)
        {
            btnPM.PerformClick();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*
        private void btnScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                btnScreen.Image = Properties.Resources.normal;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnScreen.Image = Properties.Resources.maximize;
                WindowState = FormWindowState.Normal;
            }
        }*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Làm cửa sổ thu nhỏ và phóng to khi nhấn vào icon trong taskbar
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        //Làm cửa sổ di chuyển được
        private bool mouseDown;
        private Point lastLocation;

        private void move_MouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void move_MouseMove(MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void move_MouseUp() => mouseDown = false;

        private void panelTitle_MouseDown(object sender, MouseEventArgs e) => move_MouseDown(e);
        private void panelTitle_MouseMove(object sender, MouseEventArgs e) => move_MouseMove(e);
        private void panelTitle_MouseUp(object sender, MouseEventArgs e) => move_MouseUp();

        private void lblTitle_MouseDown(object sender, MouseEventArgs e) => move_MouseDown(e);
        private void lblTitle_MouseMove(object sender, MouseEventArgs e) => move_MouseMove(e);
        private void lblTitle_MouseUp(object sender, MouseEventArgs e) => move_MouseUp();

        //Mo form con
        private Form activeForm;
        private void btnPM_Click(object sender, EventArgs e) => OpenChildForm(new ViewPM(), sender);
        private void btnDL_Click(object sender, EventArgs e) => OpenChildForm(new ViewDL(), sender);

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Dispose();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        //Lam nut Active khong an duoc
        private Button currentButton;
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(215, 231, 245);
                    currentButton.Enabled = false;
                }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Enabled = true;
                    previousBtn.BackColor = Color.RoyalBlue;
                }
        }

        //Thay doi kich thuoc cua so

        //Mo form About
        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
