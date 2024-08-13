using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using Relaxation.FormsUser;

namespace Relaxation
{
    public partial class UserControlDays : UserControl
    {
        private OleDbConnection con = new OleDbConnection();
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;data Source=db_users1.mdb";
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }
        public void days(int numday)
        {
            lbldays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            timer1.Start();
            CalendarEvent calendarEvent = new CalendarEvent();
            calendarEvent.Show();
        }
        private void displayEvent()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string Event = "SELECT * FROM appointment WHERE AppDate = ? and Username = '" + frmLogin.username + "'";
            cmd.CommandText = Event;
            cmd.Parameters.AddWithValue("date",CalendarUsers.static_year+"-"+CalendarUsers.static_month+"-"+lbldays.Text);
            
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblevent.Text = dr["event"].ToString();
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
