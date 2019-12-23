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
    public partial class CrewBioData : Form
    {
        Crew crew = new Crew();
        public CrewBioData()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mform = new MainForm();
            mform.Show();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String status = comboBoxStatus.SelectedItem.ToString();
            String fatherName = textBoxFatherName.Text;
            String cmsId = textBoxCmsId.Text;
            DateTime dob = Convert.ToDateTime(dateTimePickerDob.Text);
            DateTime doa = Convert.ToDateTime(dateTimePickerDoa.Text);
            DateTime dotc = Convert.ToDateTime(dateTimePickerDotc.Text);
            String initAppoint = textBoxInitAppoint.Text;
            String qualify = textBoxQualify.Text;
            String Address1 = textBoxAddress1.Text;
            String Address2 = textBoxAddress2.Text;
            Int32 phNo1 = Convert.ToInt32( textBoxPhNo1.Text );
            Int32 phNo2 = Convert.ToInt32(textBoxPhNo2.Text);
            String email = textBoxEmail.Text;
            String bloodGroup = comboBoxBloodGroup.SelectedItem.ToString();
            String vision = comboBoxVision.SelectedItem.ToString();
            Char gradation = Convert.ToChar(comboBoxGradation.SelectedItem.ToString());
            String lobby = comboBoxLobby.SelectedItem.ToString();
            Int32 proper = Convert.ToInt32(textBoxProper.Text);
            String cliCodeName = comboBoxCliCodeName.SelectedItem.ToString();
            String remarks = textBoxRemarks.Text;

            

            if(
                fatherName.Trim().Equals("") || 
                cmsId.Trim().Equals("") || 
                initAppoint.Trim().Equals("") || 
                qualify.Trim().Equals("") || 
                Address1.Trim().Equals("") ||
                Address2.Trim().Equals("") ||
                email.Trim().Equals("")||
                proper == 0 ||
                remarks.Trim().Equals("") ||
                phNo1 == 0 ||
                phNo2 == 0
                )
            {
                MessageBox.Show("Fill out the complete form!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                Boolean insertCrew = crew.insertCrew(status, fatherName, cmsId, dob, doa, dotc, initAppoint, qualify, Address1, Address2, phNo1, phNo2, email, bloodGroup, vision, gradation, lobby, proper, cliCodeName, remarks);
                if (insertCrew)
                {
                    MessageBox.Show("New Crew Data Inserted Successfully!", "Add Crew", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Crew Data not Inserted!", "Add Crew", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CrewBioData_Load(object sender, EventArgs e)
        {
            Int32 initCrew = crew.initCrew();
            textBoxCrewId.Text = Convert.ToString( initCrew ); 
            comboBoxBloodGroup.SelectedIndex = 0;
            comboBoxCliCodeName.SelectedIndex = 0;
            comboBoxGradation.SelectedIndex = 0;
            comboBoxLobby.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxVision.SelectedIndex = 0;
        }

        private void textBoxCrewId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
