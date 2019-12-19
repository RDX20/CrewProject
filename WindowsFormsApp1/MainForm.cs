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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBioData_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrewBioData biodata = new CrewBioData();
            biodata.Show();
        }

        private void buttonDoubleDuty_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoubleDutyEntry ddutyentry = new DoubleDutyEntry();
            ddutyentry.Show();
        }

        private void buttonAutoBooking_Click(object sender, EventArgs e)
        {
          /*  this.Hide();
            AutoBooking autobook = new AutoBooking();
            autobook.Show(); */
        }

        private void buttonSafetyCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            SafetyCourses safecourses = new SafetyCourses();
            safecourses.Show();
        }

        private void buttonDutyChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            DutyChangeEntry dutychgentry = new DutyChangeEntry();
            dutychgentry.Show();
        }

        private void buttonManualBooking_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            ManualBooking Manbook = new ManualBooking();
            Manbook.Show();*/
        }

        private void buttonProperSets_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            ProperSets psets = new ProperSets();
            psets.Show();*/
        }

        private void buttonNonRunning_Click(object sender, EventArgs e)
        {
            this.Hide();
            NonRunningDuty nonrunduty = new NonRunningDuty();
            nonrunduty.Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Reports reps = new Reports();
            reps.Show();*/
        }

        private void buttonScheduleBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleBook schbook = new ScheduleBook();
            schbook.Show();
        }

        private void buttonRequestBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestBook reqbook = new RequestBook();
            reqbook.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logform = new LoginForm();
            logform.Show();
        }
    }
}
