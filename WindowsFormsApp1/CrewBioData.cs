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
            String status ="" , fatherName ="", cmsId="";
            DateTime dob = DateTime.Now;
            DateTime doa = DateTime.Now;
            DateTime dotc= DateTime.Now;
            String initAppoint ="";
            String qualify="";
            String Address1="";
            String Address2="";
            Int32 phNo1=0;
            Int32 phNo2=0;
            String email="";
            String bloodGroup="";
            String vision="";
            Char gradation= 'A';
            String lobby="";
            Int32 proper=0;
            String cliCodeName="";
            String remarks="";
            try
            {
                status = comboBoxStatus.SelectedItem.ToString();
                fatherName = textBoxFatherName.Text;
                cmsId = textBoxCmsId.Text;
                dob = Convert.ToDateTime(dateTimePickerDob.Text);
                doa = Convert.ToDateTime(dateTimePickerDoa.Text);
                dotc = Convert.ToDateTime(dateTimePickerDotc.Text);
                initAppoint = textBoxInitAppoint.Text;
                qualify = textBoxQualify.Text;
                Address1 = textBoxAddress1.Text;
                Address2 = textBoxAddress2.Text;
                phNo1 = Convert.ToInt32(textBoxPhNo1.Text);
                phNo2 = Convert.ToInt32(textBoxPhNo2.Text);
                email = textBoxEmail.Text;
                bloodGroup = comboBoxBloodGroup.SelectedItem.ToString();
                vision = comboBoxVision.SelectedItem.ToString();
                gradation = Convert.ToChar(comboBoxGradation.SelectedItem.ToString());
                lobby = comboBoxLobby.SelectedItem.ToString();
                proper = Convert.ToInt32(textBoxProper.Text);
                cliCodeName = comboBoxCliCodeName.SelectedItem.ToString();
                remarks = textBoxRemarks.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

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


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Int32 crewid = Convert.ToInt32(textBoxCrewIdS.Text);
            DataRow result = crew.searchcrew(crewid);
            if (result != null)
            {
                textBoxCrewId.Text =Convert.ToString(crewid);
                comboBoxStatus.SelectedItem = Convert.ToString(result[1]);
                textBoxFatherName.Text = Convert.ToString(result[2]);
                textBoxCmsId.Text = Convert.ToString(result[3]);
                dateTimePickerDob.Text = Convert.ToString(result[4]);
                dateTimePickerDoa.Text = Convert.ToString(result[5]);
                dateTimePickerDotc.Text = Convert.ToString(result[6]);
                textBoxInitAppoint.Text = Convert.ToString(result[7]);
                textBoxQualify.Text = Convert.ToString(result[8]);
                textBoxAddress1.Text = Convert.ToString(result[9]);
                textBoxAddress2.Text = Convert.ToString(result[10]);
                textBoxPhNo1.Text = Convert.ToString(result[11]);
                textBoxPhNo2.Text = Convert.ToString(result[12]);
                textBoxEmail.Text = Convert.ToString(result[13]);
                comboBoxBloodGroup.SelectedItem = Convert.ToString(result[14]);
                comboBoxVision.SelectedItem = Convert.ToString(result[15]);
                comboBoxGradation.SelectedItem = Convert.ToString(result[16]);
                comboBoxLobby.SelectedItem = Convert.ToString(result[17]);
                textBoxProper.Text = Convert.ToString(result[18]);
                comboBoxCliCodeName.SelectedItem = Convert.ToString(result[19]);
                textBoxRemarks.Text = Convert.ToString(result[20]);
            }
            else
            {
                MessageBox.Show("No record found for the given Crew Id!", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
