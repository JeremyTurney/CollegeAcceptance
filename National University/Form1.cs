using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace National_University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {//Start Process
            if (None.Checked)
            {//Start None
                MessageBox.Show("Sorry, Admission Denied");
            }//End None

            if (HighSchool.Checked)
            {// Start HighSchool
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End HighSchool

            if (GED.Checked)
            {//Start GED
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End GED

            if (AttendedCollege.Checked)
            {//start AttendCollege
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End AttendCollege

            if (Bachelor.Checked)
            {//Start Bachelor
                MessageBox.Show("Admitted");
                return;
            }//End Bachelor

            if (Master.Checked)
            {//Start Master
                MessageBox.Show("Admitted");
                return;
            }//End Master

            if (Doctorate.Checked)
            {//Start Doctorate
                MessageBox.Show("Admitted");
                return;
            }//End Doctrate

            if (WorkExperience.Checked)
            {//Start WorkExperience
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End WorkExperience

            if (FamilyBusiness.Checked)
            {//Start Family
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End Family

            if (LabratoryResearch.Checked)
            {//Start LabratoryResearch
                if (SAT.Checked)
                {
                    int Sat = Convert.ToInt32(SATScore.Text);

                    if (Sat >= 1000)
                    {
                        if (Sat > 2400 || Sat < 0)
                        {
                            MessageBox.Show("Please enter valid SAT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else if (ACT.Checked)
                {
                    int Act = Convert.ToInt32(ACTScore.Text);

                    if (Act >= 15)
                    {
                        if (Act > 36 || Act < 0)
                        {
                            MessageBox.Show("Please enter valid ACT score");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Admitted");
                            return;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Sorry, Admission Denied");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Sorry, Admission Denied");
                    return;
                }
            }//End LabratoryResearch

        }//End Process

        private void SATScore_TextChanged(object sender, EventArgs e)
        {
            

        }
        

        private void ACTScore_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {//Start Clear

            foreach (Control c in EducationBox.Controls)
            {
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }

            foreach (Control c in CollegeEducation.Controls)
            {

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }

            foreach (Control c in AdditionalExperience.Controls)
            {
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }

            foreach (Control c in Tests.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }//End Clear

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SATScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (!char.IsDigit(key) && key != 8 && key != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void ACTScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;


            if (!char.IsDigit(key) && key != 8 && key != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
