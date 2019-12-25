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
    public partial class SafetyCourses : Form
    {
        public SafetyCourses()
        {
            InitializeComponent();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mform = new MainForm();
            mform.Show();
        }

        private void SafetyCourses_Load(object sender, EventArgs e)
        {
            dateTimePickerMedD.Value = DateTime.Now;
            dateTimePickerUdzD.Value = DateTime.Now;
            dateTimePickerVrD.Value = DateTime.Now;
            dateTimePickerCompD.Value = DateTime.Now;
            dateTimePickerSimD.Value = DateTime.Now;
            dateTimePickerMedDue.Value = dateTimePickerMedD.Value.AddYears(1);
            dateTimePickerUdzDue.Value = dateTimePickerUdzD.Value.AddYears(3);
            dateTimePickerVrDue.Value = dateTimePickerVrD.Value.AddYears(1).AddMonths(6);
            dateTimePickerCompDue.Value = dateTimePickerCompD.Value.AddYears(1);
            dateTimePickerSimDue.Value = dateTimePickerSimD.Value.AddYears(1);
        }

        private void buttonEditDue_Click(object sender, EventArgs e)
        {
            dateTimePickerMedDue.Enabled = true;
        }
    }
}
