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
using Microsoft.VisualBasic;
using System.Xml.Linq;
using Relaxation.FormsUser;

namespace Relaxation
{
    public partial class CalendarEvent : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public CalendarEvent()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;data Source=db_users1.mdb";
        }

        private void CalendarEvent_Load(object sender, EventArgs e)
        {
            txtdate.Text = CalendarUsers.static_month+"/"+UserControlDays.static_day+"/"+CalendarUsers.static_year;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO appointment (AppDate , Event , Username) values( '" + txtdate.Text + "' , '" + txtevent.Text + "' , '" + frmLogin.username + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
