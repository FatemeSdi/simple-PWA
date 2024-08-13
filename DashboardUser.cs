using Relaxation.FormsUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaxation
{
    public partial class DashboardUser : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public DashboardUser()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
              index =  random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(60, 0, 0, 0);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(ChildForm);
            this.panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblTitle.Text = ChildForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Meditation(), sender);
        }

        private void DashboardUser_Load(object sender, EventArgs e)
        {
            lblusernameh.Text = frmLogin.username;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.CalendarUsers(),sender);
        }

        private void btnMyNote_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Note(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Setting(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new frmLogin().Show();
            this.Close();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendar_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.CalendarUsers(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Meditation(), sender);
        }

        private void btnMyNote_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Note(), sender);
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Setting(), sender);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new frmLogin().Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new DashboardUser().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new Text1().Show();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Meditation(), sender);
        }

        private void btnCalendar_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.CalendarUsers(), sender);
        }

        private void btnMyNote_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Note(), sender);
        }

        private void btnSetting_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FormsUser.Setting(), sender);
        }

        private void btnLogOut_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender);
            new frmLogin().Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Text2().Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Text3().Show();
        }

        private void lblusernameh_Click(object sender, EventArgs e)
        {

        }
    }
}
