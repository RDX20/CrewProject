using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DutyChangeEntry : Form
    {
        public DutyChangeEntry()
        {
            InitializeComponent();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mform = new MainForm();
            mform.Show();
        }


        private void DutyChangeEntry_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            textBoxTodayDate.Text = thisDay.ToString("d");
        }
    }
}
