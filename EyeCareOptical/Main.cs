using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCareOptical
{
    public partial class Main : Form
    {
        decimal Total = 0.00m;
        decimal Discount = 0.00m;
        decimal TotalDue = 0.00m;
        decimal A, B, C, D, Z;
        int transNo;

        public Main()
        {
            InitializeComponent();
            squareComboBox.SelectedItem = "None";
            ovalComboBox.SelectedItem = "None";
            roundComboBox.SelectedItem = "None";
            micComboBox.SelectedItem = "None";
            timer.Enabled = true;
            timer.Interval = 1000;
        }

        private void homeTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addressRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (O1Button10am.BackColor == Color.SpringGreen)
                {
                    O1Button10am.BackColor = Color.Red;
                    O1Button10am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button10am.BackColor = Color.SpringGreen;
                    O1Button10am.Text = "10am-11am";
                }
            }
        }

        private void bookingsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || hpMaskedTextBox.Text == "" || icTextBox.Text == "")
            {
                MessageBox.Show("Please enter your Name, HP number and IC number.", "Insufficient Information");
            }
            else
                tabControl.SelectedIndex = 1;
        }

        private void O1Button11am_Click(object sender, EventArgs e)
        {
            {
                if (O1Button11am.BackColor == Color.SpringGreen)
                {
                    O1Button11am.BackColor = Color.Red;
                    O1Button11am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button11am.BackColor = Color.SpringGreen;
                    O1Button11am.Text = "11am-12noon";
                }
            }
        }

        private void O1Button12pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button12pm.BackColor == Color.SpringGreen)
                {
                    O1Button12pm.BackColor = Color.Red;
                    O1Button12pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button12pm.BackColor = Color.SpringGreen;
                    O1Button12pm.Text = "12noon-1pm";
                }
            }
        }

        private void O1Button1pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button1pm.BackColor == Color.SpringGreen)
                {
                    O1Button1pm.BackColor = Color.Red;
                    O1Button1pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button1pm.BackColor = Color.SpringGreen;
                    O1Button1pm.Text = "1pm-2pm";
                }
            }
        }

        private void O1Button2pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button2pm.BackColor == Color.SpringGreen)
                {
                    O1Button2pm.BackColor = Color.Red;
                    O1Button2pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button2pm.BackColor = Color.SpringGreen;
                    O1Button2pm.Text = "2pm-3pm";
                }
            }
        }

        private void O1Button3pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button3pm.BackColor == Color.SpringGreen)
                {
                    O1Button3pm.BackColor = Color.Red;
                    O1Button3pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button3pm.BackColor = Color.SpringGreen;
                    O1Button3pm.Text = "3pm-4pm";
                }
            }
        }

        private void O1Button4pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button4pm.BackColor == Color.SpringGreen)
                {
                    O1Button4pm.BackColor = Color.Red;
                    O1Button4pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button4pm.BackColor = Color.SpringGreen;
                    O1Button4pm.Text = "4pm-5pm";
                }
            }
        }

        private void O1Button5pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button5pm.BackColor == Color.SpringGreen)
                {
                    O1Button5pm.BackColor = Color.Red;
                    O1Button5pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button5pm.BackColor = Color.SpringGreen;
                    O1Button5pm.Text = "5pm-6pm";
                }
            }
        }

        private void O1Button6pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button6pm.BackColor == Color.SpringGreen)
                {
                    O1Button6pm.BackColor = Color.Red;
                    O1Button6pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button6pm.BackColor = Color.SpringGreen;
                    O1Button6pm.Text = "6pm-7pm";
                }
            }
        }

        private void O1Button7pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button7pm.BackColor == Color.SpringGreen)
                {
                    O1Button7pm.BackColor = Color.Red;
                    O1Button7pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button7pm.BackColor = Color.SpringGreen;
                    O1Button7pm.Text = "7pm-8pm";
                }
            }
        }

        private void O1Button8pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button8pm.BackColor == Color.SpringGreen)
                {
                    O1Button8pm.BackColor = Color.Red;
                    O1Button8pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button8pm.BackColor = Color.SpringGreen;
                    O1Button8pm.Text = "8pm-9pm";
                }
            }
        }

        private void O1Button10pm_Click(object sender, EventArgs e)
        {
            {
                if (O1Button9pm.BackColor == Color.SpringGreen)
                {
                    O1Button9pm.BackColor = Color.Red;
                    O1Button9pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O1Button9pm.BackColor = Color.SpringGreen;
                    O1Button9pm.Text = "9pm-10pm";
                }
            }
        }

        private void O2Button10am_Click(object sender, EventArgs e)
        {
            {
                if (O2Button10am.BackColor == Color.SpringGreen)
                {
                    O2Button10am.BackColor = Color.Red;
                    O2Button10am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button10am.BackColor = Color.SpringGreen;
                    O2Button10am.Text = "10am-11am";
                }
            }
        }

        private void O2Button11am_Click(object sender, EventArgs e)
        {
            {
                if (O2Button11am.BackColor == Color.SpringGreen)
                {
                    O2Button11am.BackColor = Color.Red;
                    O2Button11am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button11am.BackColor = Color.SpringGreen;
                    O2Button11am.Text = "11am-12noon";
                }
            }
        }

        private void O2Button12pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button12pm.BackColor == Color.SpringGreen)
                {
                    O2Button12pm.BackColor = Color.Red;
                    O2Button12pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button12pm.BackColor = Color.SpringGreen;
                    O2Button12pm.Text = "12noon-1pm";
                }
            }
        }

        private void O2Button1pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button1pm.BackColor == Color.SpringGreen)
                {
                    O2Button1pm.BackColor = Color.Red;
                    O2Button1pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button1pm.BackColor = Color.SpringGreen;
                    O2Button1pm.Text = "1pm-2pm";
                }
            }
        }

        private void O2Button2pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button2pm.BackColor == Color.SpringGreen)
                {
                    O2Button2pm.BackColor = Color.Red;
                    O2Button2pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button2pm.BackColor = Color.SpringGreen;
                    O2Button2pm.Text = "2pm-3pm";
                }
            }
        }

        private void O2Button3pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button3pm.BackColor == Color.SpringGreen)
                {
                    O2Button3pm.BackColor = Color.Red;
                    O2Button3pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button3pm.BackColor = Color.SpringGreen;
                    O2Button3pm.Text = "3pm-4pm";
                }
            }
        }

        private void O2Button4pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button4pm.BackColor == Color.SpringGreen)
                {
                    O2Button4pm.BackColor = Color.Red;
                    O2Button4pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button4pm.BackColor = Color.SpringGreen;
                    O2Button4pm.Text = "4pm-5pm";
                }
            }
        }

        private void O2Button5pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button5pm.BackColor == Color.SpringGreen)
                {
                    O2Button5pm.BackColor = Color.Red;
                    O2Button5pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button5pm.BackColor = Color.SpringGreen;
                    O2Button5pm.Text = "5pm-6pm";
                }
            }
        }

        private void O2Button6pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button6pm.BackColor == Color.SpringGreen)
                {
                    O2Button6pm.BackColor = Color.Red;
                    O2Button6pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button6pm.BackColor = Color.SpringGreen;
                    O2Button6pm.Text = "6pm-7pm";
                }
            }
        }

        private void O2Button7pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button7pm.BackColor == Color.SpringGreen)
                {
                    O2Button7pm.BackColor = Color.Red;
                    O2Button7pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button7pm.BackColor = Color.SpringGreen;
                    O2Button7pm.Text = "7pm-8pm";
                }
            }
        }

        private void O2Button8pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button8pm.BackColor == Color.SpringGreen)
                {
                    O2Button8pm.BackColor = Color.Red;
                    O2Button8pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button8pm.BackColor = Color.SpringGreen;
                    O2Button8pm.Text = "8pm-9pm";
                }
            }
        }

        private void O2Button9pm_Click(object sender, EventArgs e)
        {
            {
                if (O2Button9pm.BackColor == Color.SpringGreen)
                {
                    O2Button9pm.BackColor = Color.Red;
                    O2Button9pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O2Button9pm.BackColor = Color.SpringGreen;
                    O2Button9pm.Text = "9pm-10pm";
                }
            }
        }

        private void O3Button10am_Click(object sender, EventArgs e)
        {
            {
                if (O3Button10am.BackColor == Color.SpringGreen)
                {
                    O3Button10am.BackColor = Color.Red;
                    O3Button10am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button10am.BackColor = Color.SpringGreen;
                    O3Button10am.Text = "10am-11am";
                }
            }
        }

        private void O3Button11am_Click(object sender, EventArgs e)
        {
            {
                if (O3Button11am.BackColor == Color.SpringGreen)
                {
                    O3Button11am.BackColor = Color.Red;
                    O3Button11am.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button11am.BackColor = Color.SpringGreen;
                    O3Button11am.Text = "11am-12noon";
                }
            }
        }

        private void O3Button12pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button12pm.BackColor == Color.SpringGreen)
                {
                    O3Button12pm.BackColor = Color.Red;
                    O3Button12pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button12pm.BackColor = Color.SpringGreen;
                    O3Button12pm.Text = "12noon-1pm";
                }
            }
        }

        private void O3Button1pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button1pm.BackColor == Color.SpringGreen)
                {
                    O3Button1pm.BackColor = Color.Red;
                    O3Button1pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button1pm.BackColor = Color.SpringGreen;
                    O3Button1pm.Text = "1pm-2pm";
                }
            }
        }

        private void O3Button2pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button2pm.BackColor == Color.SpringGreen)
                {
                    O3Button2pm.BackColor = Color.Red;
                    O3Button2pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button2pm.BackColor = Color.SpringGreen;
                    O3Button2pm.Text = "2pm-3pm";
                }
            }
        }

        private void O3Button3pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button3pm.BackColor == Color.SpringGreen)
                {
                    O3Button3pm.BackColor = Color.Red;
                    O3Button3pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button3pm.BackColor = Color.SpringGreen;
                    O3Button3pm.Text = "3pm-4pm";
                }
            }
        }

        private void O3Button4pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button4pm.BackColor == Color.SpringGreen)
                {
                    O3Button4pm.BackColor = Color.Red;
                    O3Button4pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button4pm.BackColor = Color.SpringGreen;
                    O3Button4pm.Text = "4pm-5pm";
                }
            }
        }

        private void O3Button5pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button5pm.BackColor == Color.SpringGreen)
                {
                    O3Button5pm.BackColor = Color.Red;
                    O3Button5pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button5pm.BackColor = Color.SpringGreen;
                    O3Button5pm.Text = "5pm-6pm";
                }
            }
        }

        private void O3Button6pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button6pm.BackColor == Color.SpringGreen)
                {
                    O3Button6pm.BackColor = Color.Red;
                    O3Button6pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button6pm.BackColor = Color.SpringGreen;
                    O3Button6pm.Text = "6pm-7pm";
                }
            }
        }

        private void O3Button7pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button7pm.BackColor == Color.SpringGreen)
                {
                    O3Button7pm.BackColor = Color.Red;
                    O3Button7pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button7pm.BackColor = Color.SpringGreen;
                    O3Button7pm.Text = "7pm-8pm";
                }
            }
        }

        private void O3Button8pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button8pm.BackColor == Color.SpringGreen)
                {
                    O3Button8pm.BackColor = Color.Red;
                    O3Button8pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button8pm.BackColor = Color.SpringGreen;
                    O3Button8pm.Text = "8pm-9pm";
                }
            }
        }

        private void O3Button9pm_Click(object sender, EventArgs e)
        {
            {
                if (O3Button9pm.BackColor == Color.SpringGreen)
                {
                    O3Button9pm.BackColor = Color.Red;
                    O3Button9pm.Text += Environment.NewLine + "ID: " + firstNameTextBox.Text;
                }
                else
                {
                    O3Button9pm.BackColor = Color.SpringGreen;
                    O3Button9pm.Text = "9pm-10pm";
                }
            }
        }

        private void O1RadioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            facePictureBox.Image = EyeCareOptical.Properties.Resources.RyanLim;
            infoRichTextBox.Text = "Dr Ryan Lim Chuah obtained his basic medical degree in 1988 from the National University of Singapore, followed by his Fellowship of the Royal College of Surgeons of Edinburgh (FRCS Edinburgh) in 1993 and in 1994, he obtained his Master of Medicine in Ophthalmology from the Postgraduate School of Medicine, National University of Singapore.";
        }

        private void O2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            facePictureBox.Image = EyeCareOptical.Properties.Resources.GraceTan;
            infoRichTextBox.Text = "Dr Grace Tan is a US fellowship-trained Consultant Ophthalmologist and Adult & Paediatric Eye Surgeon. With over 15 years of experience, Dr Grace Tan currently serves as the Medical Director of the Focal Eye Centre and Co-Director of The Children’s Eye & ENT Centre. She embarked on her medical training with the National University of Singapore in 1995, followed by her residency training in Ophthalmology at the Singapore National Eye Centre.";
        }

        private void O3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            facePictureBox.Image = EyeCareOptical.Properties.Resources.KennyPoh;
            infoRichTextBox.Text = "Dr Kenny Poh has an experience of 28 years in this field. He completed MBBS from NUS-Singapore in 1988, FRCS (Ophth) from Royal College of Surgeons of Edinburgh (RCSE), U.K in 1993 and M Med (Ophthalmology) from NUS-Singapore in 1994. He is Registered with Singapore Medical Council. Some of the services provided by the doctor are: Cataract Surgery, Presbyopia Surgery, Retinal Surgery, Glaucoma Treatment and Lasik Surgery etc.";
        }

        private void OSelectionButton_Click(object sender, EventArgs e)
        {
            O1RadioButton.Checked = false;
            O2RadioButton.Checked = false;
            O3RadioButton.Checked = false;
            facePictureBox.Image = EyeCareOptical.Properties.Resources.Profile;
            infoRichTextBox.Text = "Please select your preferred optician.";
        }

        private void nextSButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerECODataSet.CustomerECO' table. You can move, or remove it, as needed.
            this.customerECOTableAdapter.Fill(this.customerECODataSet.CustomerECO);
            timer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void squareSpecsLabel_Click(object sender, EventArgs e)
        {

        }

        private void O1NotAvailableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (O1NotAvailableCheckBox.Checked == true)
            {
                O1Button10am.BackColor = Color.SlateGray;
                O1Button10am.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button10am.Enabled = false;

                O1Button11am.BackColor = Color.SlateGray;
                O1Button11am.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button11am.Enabled = false;

                O1Button12pm.BackColor = Color.SlateGray;
                O1Button12pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button12pm.Enabled = false;

                O1Button1pm.BackColor = Color.SlateGray;
                O1Button1pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button1pm.Enabled = false;

                O1Button2pm.BackColor = Color.SlateGray;
                O1Button2pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button2pm.Enabled = false;

                O1Button3pm.BackColor = Color.SlateGray;
                O1Button3pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button3pm.Enabled = false;

                O1Button4pm.BackColor = Color.SlateGray;
                O1Button4pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button4pm.Enabled = false;

                O1Button5pm.BackColor = Color.SlateGray;
                O1Button5pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button5pm.Enabled = false;

                O1Button6pm.BackColor = Color.SlateGray;
                O1Button6pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button6pm.Enabled = false;

                O1Button7pm.BackColor = Color.SlateGray;
                O1Button7pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button7pm.Enabled = false;

                O1Button8pm.BackColor = Color.SlateGray;
                O1Button8pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button8pm.Enabled = false;

                O1Button9pm.BackColor = Color.SlateGray;
                O1Button9pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O1Button9pm.Enabled = false;
            }

            if (O1NotAvailableCheckBox.Checked == false)
            {
                O1Button10am.BackColor = Color.SpringGreen;
                O1Button10am.Text = "10am-11am";
                O1Button10am.Enabled = true;

                O1Button11am.BackColor = Color.SpringGreen;
                O1Button11am.Text = "11am-12noon";
                O1Button11am.Enabled = true;

                O1Button12pm.BackColor = Color.SpringGreen;
                O1Button12pm.Text = "12noon-1pm";
                O1Button12pm.Enabled = true;

                O1Button1pm.BackColor = Color.SpringGreen;
                O1Button1pm.Text = "1pm-2pm";
                O1Button1pm.Enabled = true;

                O1Button2pm.BackColor = Color.SpringGreen;
                O1Button2pm.Text = "2pm-3pm";
                O1Button2pm.Enabled = true;

                O1Button3pm.BackColor = Color.SpringGreen;
                O1Button3pm.Text = "3pm-4pm";
                O1Button3pm.Enabled = true;

                O1Button4pm.BackColor = Color.SpringGreen;
                O1Button4pm.Text = "4pm-5pm";
                O1Button4pm.Enabled = true;

                O1Button5pm.BackColor = Color.SpringGreen;
                O1Button5pm.Text = "5pm-6pm";
                O1Button5pm.Enabled = true;

                O1Button6pm.BackColor = Color.SpringGreen;
                O1Button6pm.Text = "6pm-7pm";
                O1Button6pm.Enabled = true;

                O1Button7pm.BackColor = Color.SpringGreen;
                O1Button7pm.Text = "7pm-8pm";
                O1Button7pm.Enabled = true;

                O1Button8pm.BackColor = Color.SpringGreen;
                O1Button8pm.Text = "8pm-9pm";
                O1Button8pm.Enabled = true;

                O1Button9pm.BackColor = Color.SpringGreen;
                O1Button9pm.Text = "9pm-10pm";
                O1Button9pm.Enabled = true;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ovalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ovalComboBox.SelectedItem == "None")
            {
                ovalSpecsPictureBox.Image = null;
                B = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "OWNDAYS PCPC2002-N --- $60")
            {
                ovalSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.PC2002N;
                B = 60.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "OWNDAYS PCON2012 --- $60")
            {
                ovalSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.ON2012;
                B = 60.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "Graph BelleGB2003-J --- $158")
            {
                ovalSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.GB2003J;
                B = 158.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "FUWA CELLUTR2023 --- $118")
            {
                ovalSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.TR2023;
                B = 118.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roundComboBox.SelectedItem == "None")
            {
                roundSpecsPictureBox.Image = null;
                C = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "John DillingerJD1006-K --- $158")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.JD1006K;
                C = 158.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "John DillingerJD1005-K --- $158")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.JD1005K;
                C = 158.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "BasedBA1008-G --- $118")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.BA1008G;
                C = 118.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "Graph BelleGB1002-K --- $198")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.GB1002K;
                C = 198.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            printListBox.Items.Clear();
            tabControl.SelectedIndex = 3;
            transNo += 1;
            printTransNoLabel.Text = transNo.ToString();
            printNameLabel.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            printHPNumberLabel.Text = hpMaskedTextBox.Text;
            printEmailLabel.Text = emailTextBox.Text;
            if (O1RadioButton.Checked == true)
            {
                printOpticianLabel.Text = "Ryan Lim";
            }
            if (O2RadioButton.Checked == true)
            {
                printOpticianLabel.Text = "Grace Tan";
            }
            if (O3RadioButton.Checked == true)
            {
                printOpticianLabel.Text = "Kenny Poh";
            }
            printLeftLabel.Text = degreeLeftTextBox.Text;
            printRightLabel.Text = degreeRightTextBox.Text;
            printCostLabel.Text = totalTextBox.Text;
            if (memberCheckBox.Checked == true)
            {
                Discount = (A + B + C + D + Z) * .1m;
                printDiscountLabel.Text = "$" + Discount.ToString();
            }
            else
            {
                printDiscountLabel.Text = "$0";
            }
            TotalDue = Total - Discount;
            printAmountDueLabel.Text = "$" + TotalDue.ToString();
            if (squareComboBox.SelectedItem != "None")
            {
                printListBox.Items.Add(numericUpDown1.Value + "x   " + squareComboBox.SelectedItem);
            }
            if (ovalComboBox.SelectedItem != "None")
            {
                printListBox.Items.Add(numericUpDown2.Value + "x   " + ovalComboBox.SelectedItem);
            }
            if (roundComboBox.SelectedItem != "None")
            {
                printListBox.Items.Add(numericUpDown3.Value + "x   " + roundComboBox.SelectedItem);
            }
            if (micComboBox.SelectedItem != "None")
            {
                printListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            for (int i = 0; i < micListBox.Items.Count; i++)
            {
                printListBox.Items.Add(micListBox.Items[i].ToString());
            }
            if (printListBox.Items.Count == 0)
            {
                MessageBox.Show("Please select a spectacle type.", "Error");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Print This Receipt?", "Printing Receipt", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                printDocument.PrinterSettings.DefaultPageSettings.Landscape = true;
                printDocument.Print();
            }
            else if (dialogresult == DialogResult.No)
            {

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //Home Page
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.Text = "";
            dobDateTimePicker.Text = "";
            icTextBox.Clear();
            nationalityTextBox.Clear();
            hpMaskedTextBox.Clear();
            emailTextBox.Clear();
            addressRichTextBox.Clear();
            memberCheckBox.Checked = false;
            Z = 0.00m;

            //Booking Page
            O1RadioButton.Checked = false;
            O2RadioButton.Checked = false;
            O3RadioButton.Checked = false;
            facePictureBox.Image = EyeCareOptical.Properties.Resources.Profile;
            infoRichTextBox.Text = "Please select your preferred optician.";

            //Specs Page
            squareComboBox.SelectedItem = "None";
            ovalComboBox.SelectedItem = "None";
            roundComboBox.SelectedItem = "None";
            micComboBox.SelectedItem = "None";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            squareSpecsPictureBox.Image = null;
            ovalSpecsPictureBox.Image = null;
            roundSpecsPictureBox.Image = null;
            caseRadioButton.Checked = false;
            clothRadioButton.Checked = false;
            lensRadioButton.Checked = false;
            micListBox.Items.Clear();
            degreeLeftTextBox.Clear();
            degreeRightTextBox.Clear();
            totalTextBox.Clear();

            //Check Out Page
            printNameLabel.Text = "";
            printHPNumberLabel.Text = "";
            printEmailLabel.Text = "";
            printOpticianLabel.Text = "";
            printLeftLabel.Text = "";
            printRightLabel.Text = "";
            printListBox.Items.Clear();
            printCostLabel.Text = "";
            printDiscountLabel.Text = "";
            printAmountDueLabel.Text = "";

            //Back To Home Page
            tabControl.SelectedIndex = 0;

            //Set Focus
            firstNameTextBox.Focus();
        }

        private void backOButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void caseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (caseRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Black Specs Case --- $0");
                micComboBox.Items.Add("Standard Blue Specs Case --- $0");
                micComboBox.Items.Add("Standard Yellow Specs Case --- $0");
                micComboBox.Items.Add("Premium Leather Black Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather Silver Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather White Specs Case --- $7");
            }
            else if (clothRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Cleaning Cloth --- $0");
                micComboBox.Items.Add("ZEISS Lens Microfibre Cloth --- $4");
                micComboBox.Items.Add("Lotto Black Microfibre Cloth --- $9");
            }
            else if (lensRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Digital Lenses --- $45");
                micComboBox.Items.Add("Progressive Lenses --- $230");
                micComboBox.Items.Add("Self-tinting lenses --- $130");
                micComboBox.Items.Add("Polarised Lenses --- $87");
                micComboBox.Items.Add("LotuTec® Standard Lens Coating --- $115");
                micComboBox.Items.Add("DuraVision Premium Coatings --- $310");
            }
        }

        private void clothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (caseRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Black Specs Case --- $0");
                micComboBox.Items.Add("Standard Blue Specs Case --- $0");
                micComboBox.Items.Add("Standard Yellow Specs Case --- $0");
                micComboBox.Items.Add("Premium Leather Black Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather Silver Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather White Specs Case --- $7");
            }
            else if (clothRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Cleaning Cloth --- $0");
                micComboBox.Items.Add("ZEISS Lens Microfibre Cloth --- $4");
                micComboBox.Items.Add("Lotto Black Microfibre Cloth --- $9");
            }
            else if (lensRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Digital Lenses --- $45");
                micComboBox.Items.Add("Progressive Lenses --- $230");
                micComboBox.Items.Add("Self-tinting lenses --- $130");
                micComboBox.Items.Add("Polarised Lenses --- $87");
                micComboBox.Items.Add("LotuTec® Standard Lens Coating --- $115");
                micComboBox.Items.Add("DuraVision Premium Coatings --- $310");
            }
        }

        private void lensRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (caseRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Black Specs Case --- $0");
                micComboBox.Items.Add("Standard Blue Specs Case --- $0");
                micComboBox.Items.Add("Standard Yellow Specs Case --- $0");
                micComboBox.Items.Add("Premium Leather Black Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather Silver Specs Case --- $7");
                micComboBox.Items.Add("Premium Leather White Specs Case --- $7");
            }
            else if (clothRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Standard Cleaning Cloth --- $0");
                micComboBox.Items.Add("ZEISS Lens Microfibre Cloth --- $4");
                micComboBox.Items.Add("Lotto Black Microfibre Cloth --- $9");
            }
            else if (lensRadioButton.Checked)
            {
                micComboBox.Items.Clear();
                micComboBox.Items.Add("None");
                micComboBox.SelectedItem = "None";
                micComboBox.Items.Add("Digital Lenses --- $45");
                micComboBox.Items.Add("Progressive Lenses --- $230");
                micComboBox.Items.Add("Self-tinting lenses --- $130");
                micComboBox.Items.Add("Polarised Lenses --- $87");
                micComboBox.Items.Add("LotuTec® Standard Lens Coating --- $115");
                micComboBox.Items.Add("DuraVision Premium Coatings --- $310");
            }
        }

        private void micComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (micComboBox.SelectedItem == "None")
            {
                D = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Black Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Blue Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Yellow Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather Black Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather Silver Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather White Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Cleaning Cloth --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "ZEISS Lens Microfibre Cloth --- $4")
            {
                D = 4.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Lotto Black Microfibre Cloth --- $9")
            {
                D = 9.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Digital Lenses --- $45")
            {
                D = 45.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Progressive Lenses --- $230")
            {
                D = 230.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Self-tinting lenses --- $130")
            {
                D = 130.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Polarised Lenses --- $87")
            {
                D = 87.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "LotuTec® Standard Lens Coating --- $115")
            {
                D = 115.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "DuraVision Premium Coatings --- $310")
            {
                D = 310.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (squareComboBox.SelectedItem == "None")
            {
                squareSpecsPictureBox.Image = null;
                A = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "K.moriyama KM1107E-T --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.KM1107ET;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR UltemAU2013-M --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AU2013M;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR UltemAU2012-M --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AU2012M;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR For MenAR2006-T --- $138")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AR2006T;
                A = 138.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (roundComboBox.SelectedItem == "None")
            {
                roundSpecsPictureBox.Image = null;
                C = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "John DillingerJD1006-K --- $158")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.JD1006K;
                C = 158.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "John DillingerJD1005-K --- $158")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.JD1005K;
                C = 158.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "BasedBA1008-G --- $118")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.BA1008G;
                C = 118.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (roundComboBox.SelectedItem == "Graph BelleGB1002-K --- $198")
            {
                roundSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.GB1002K;
                C = 198.00m * numericUpDown3.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (ovalComboBox.SelectedItem == "None")
            {
                ovalSpecsPictureBox.Image = null;
                B = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "OWNDAYS PCPC2002-N --- $60")
            {
                ovalSpecsPictureBox.Image = null;
                B = 60.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "OWNDAYS PCON2012 --- $60")
            {
                ovalSpecsPictureBox.Image = null;
                B = 60.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "Graph BelleGB2003-J --- $158")
            {
                ovalSpecsPictureBox.Image = null;
                B = 158.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (ovalComboBox.SelectedItem == "FUWA CELLUTR2023 --- $118")
            {
                ovalSpecsPictureBox.Image = null;
                B = 118.00m * numericUpDown2.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void ovalSpecsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void squareSpecsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void roundSpecsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (micComboBox.SelectedItem == "None")
            {
                D = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Black Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Blue Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Yellow Specs Case --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather Black Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather Silver Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Premium Leather White Specs Case --- $7")
            {
                D = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Standard Cleaning Cloth --- $0")
            {
                D = 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "ZEISS Lens Microfibre Cloth --- $4")
            {
                D = 4.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Lotto Black Microfibre Cloth --- $9")
            {
                D = 9.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Digital Lenses --- $45")
            {
                D = 45.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Progressive Lenses --- $230")
            {
                D = 230.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Self-tinting lenses --- $130")
            {
                D = 130.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "Polarised Lenses --- $87")
            {
                D = 87.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "LotuTec® Standard Lens Coating --- $115")
            {
                D = 115.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (micComboBox.SelectedItem == "DuraVision Premium Coatings --- $310")
            {
                D = 310.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }

        private void addMicButton_Click(object sender, EventArgs e)
        {
            if (micComboBox.SelectedItem == "Standard Black Specs Case --- $0")
            {
                Z += 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Standard Blue Specs Case --- $0")
            {
                Z += 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Standard Yellow Specs Case --- $0")
            {
                Z += 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Premium Leather Black Specs Case --- $7")
            {
                Z = 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Premium Leather Silver Specs Case --- $7")
            {
                Z += 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Premium Leather White Specs Case --- $7")
            {
                Z += 7.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Standard Cleaning Cloth --- $0")
            {
                Z += 0.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "ZEISS Lens Microfibre Cloth --- $4")
            {
                Z += 4.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Lotto Black Microfibre Cloth --- $9")
            {
                Z += 9.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Digital Lenses --- $45")
            {
                Z += 45.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Progressive Lenses --- $230")
            {
                Z += 230.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Self-tinting lenses --- $130")
            {
                Z += 130.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "Polarised Lenses --- $87")
            {
                Z += 87.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "LotuTec® Standard Lens Coating --- $115")
            {
                Z += 115.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            else if (micComboBox.SelectedItem == "DuraVision Premium Coatings --- $310")
            {
                Z += 310.00m * numericUpDown4.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
                micListBox.Items.Add(numericUpDown4.Value + "x   " + micComboBox.SelectedItem);
            }
            // Insert Clear Mic Combo Box


        }

        private void micListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkoutTabPage_Click(object sender, EventArgs e)
        {

        }

        private void clearMicButton_Click(object sender, EventArgs e)
        {
            micListBox.Items.Clear();
        }

        private void facePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void O3LunchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //10am-11am
            if (O3AwayComboBox.SelectedItem == "10am-11am")
            {
                O3Button10am.BackColor = Color.Gold;
                O3Button10am.Text = "Away Period";
                O3Button10am.Enabled = true;
            }
            if (O3AwayComboBox.SelectedItem == "11am-12noon")
            {
                O3Button11am.BackColor = Color.Gold;
                O3Button11am.Text = "Away Period";
                O3Button11am.Enabled = true;
            }
            //12noon-1pm
            if (O3AwayComboBox.SelectedItem == "12noon-1pm")
            { 
                O3Button12pm.BackColor = Color.Gold;
                O3Button12pm.Text = "Away Period";
                O3Button12pm.Enabled = true;
            }
            //1pm-2pm
            if (O3AwayComboBox.SelectedItem == "1pm-2pm")
            {
                O3Button1pm.BackColor = Color.Gold;
                O3Button1pm.Text = "Away Period";
                O3Button1pm.Enabled = true;
            }
            //2pm-3pm
            if (O3AwayComboBox.SelectedItem == "2pm-3pm")
            {
                O3Button2pm.BackColor = Color.Gold;
                O3Button2pm.Text = "Away Period";
                O3Button2pm.Enabled = true;
            }
            //3pm-4pm
            if (O3AwayComboBox.SelectedItem == "3pm-4pm")
            {
                O3Button3pm.BackColor = Color.Gold;
                O3Button3pm.Text = "Away Period";
                O3Button3pm.Enabled = true;
            }
            //4pm-5pm
            if (O3AwayComboBox.SelectedItem == "4pm-5pm")
            {
                O3Button4pm.BackColor = Color.Gold;
                O3Button4pm.Text = "Away Period";
                O3Button4pm.Enabled = true;
            }
            //5pm-6pm
            if (O3AwayComboBox.SelectedItem == "5pm-6pm")
            {
                O3Button5pm.BackColor = Color.Gold;
                O3Button5pm.Text = "Away Period";
                O3Button5pm.Enabled = true;
            }
            //6pm-7pm
            if (O3AwayComboBox.SelectedItem == "6pm-7pm")
            {
                O3Button6pm.BackColor = Color.Gold;
                O3Button6pm.Text = "Away Period";
                O3Button6pm.Enabled = true;
            }
            //7pm-8pm
            if (O3AwayComboBox.SelectedItem == "7pm-8pm")
            {
                O3Button7pm.BackColor = Color.Gold;
                O3Button7pm.Text = "Away Period";
                O3Button7pm.Enabled = true;
            }
            //8pm-9pm
            if (O3AwayComboBox.SelectedItem == "8pm-9pm")
            {
                O3Button8pm.BackColor = Color.Gold;
                O3Button8pm.Text = "Away Period";
                O3Button8pm.Enabled = true;
            }
            //9pm-10pm
            if (O3AwayComboBox.SelectedItem == "9pm-10pm")
            {
                O3Button9pm.BackColor = Color.Gold;
                O3Button9pm.Text = "Away Period";
                O3Button9pm.Enabled = true;
            }
        }

        private void O2AwayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //10am-11am
            if (O2AwayComboBox.SelectedItem == "10am-11am")
            {
                O2Button10am.BackColor = Color.Gold;
                O2Button10am.Text = "Away Period";
                O2Button10am.Enabled = true;
            }
            if (O2AwayComboBox.SelectedItem == "11am-12noon")
            {
                O2Button11am.BackColor = Color.Gold;
                O2Button11am.Text = "Away Period";
                O2Button11am.Enabled = true;
            }
            //12noon-1pm
            if (O2AwayComboBox.SelectedItem == "12noon-1pm")
            {
                O2Button12pm.BackColor = Color.Gold;
                O2Button12pm.Text = "Away Period";
                O2Button12pm.Enabled = true;
            }
            //1pm-2pm
            if (O2AwayComboBox.SelectedItem == "1pm-2pm")
            {
                O2Button1pm.BackColor = Color.Gold;
                O2Button1pm.Text = "Away Period";
                O2Button1pm.Enabled = true;
            }
            //2pm-3pm
            if (O2AwayComboBox.SelectedItem == "2pm-3pm")
            {
                O2Button2pm.BackColor = Color.Gold;
                O2Button2pm.Text = "Away Period";
                O2Button2pm.Enabled = true;
            }
            //3pm-4pm
            if (O2AwayComboBox.SelectedItem == "3pm-4pm")
            {
                O2Button3pm.BackColor = Color.Gold;
                O2Button3pm.Text = "Away Period";
                O2Button3pm.Enabled = true;
            }
            //4pm-5pm
            if (O2AwayComboBox.SelectedItem == "4pm-5pm")
            {
                O2Button4pm.BackColor = Color.Gold;
                O2Button4pm.Text = "Away Period";
                O2Button4pm.Enabled = true;
            }
            //5pm-6pm
            if (O2AwayComboBox.SelectedItem == "5pm-6pm")
            {
                O2Button5pm.BackColor = Color.Gold;
                O2Button5pm.Text = "Away Period";
                O2Button5pm.Enabled = true;
            }
            //6pm-7pm
            if (O2AwayComboBox.SelectedItem == "6pm-7pm")
            { 
                O2Button6pm.BackColor = Color.Gold;
                O2Button6pm.Text = "Away Period";
                O2Button6pm.Enabled = true;
            }
            //7pm-8pm
            if (O2AwayComboBox.SelectedItem == "7pm-8pm")
            {
                O2Button7pm.BackColor = Color.Gold;
                O2Button7pm.Text = "Away Period";
                O2Button7pm.Enabled = true;
            }
            //8pm-9pm
            if (O2AwayComboBox.SelectedItem == "8pm-9pm")
            {
                O2Button8pm.BackColor = Color.Gold;
                O2Button8pm.Text = "Away Period";
                O2Button8pm.Enabled = true;
            }
            //9pm-10pm
            if (O2AwayComboBox.SelectedItem == "9pm-10pm")
            {
                O2Button9pm.BackColor = Color.Gold;
                O2Button9pm.Text = "Away Period";
                O2Button9pm.Enabled = true;
            }
        }

        private void O1AwayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //10am-11am
            if (O1AwayComboBox.SelectedItem == "10am-11am")
            {
                O1Button10am.BackColor = Color.Gold;
                O1Button10am.Text = "Away Period";
                O1Button10am.Enabled = true;
            }
            if (O1AwayComboBox.SelectedItem == "11am-12noon")
            {
                O1Button11am.BackColor = Color.Gold;
                O1Button11am.Text = "Away Period";
                O1Button11am.Enabled = true;
            }
            //12noon-1pm
            if (O1AwayComboBox.SelectedItem == "12noon-1pm")
            {
                O1Button12pm.BackColor = Color.Gold;
                O1Button12pm.Text = "Away Period";
                O1Button12pm.Enabled = true;
            }
            //1pm-2pm
            if (O1AwayComboBox.SelectedItem == "1pm-2pm")
            {
                O1Button1pm.BackColor = Color.Gold;
                O1Button1pm.Text = "Away Period";
                O1Button1pm.Enabled = true;
            }
            //2pm-3pm
            if (O1AwayComboBox.SelectedItem == "2pm-3pm")
            {
                O1Button2pm.BackColor = Color.Gold;
                O1Button2pm.Text = "Away Period";
                O1Button2pm.Enabled = true;
            }
            //3pm-4pm
            if (O1AwayComboBox.SelectedItem == "3pm-4pm")
            {
                O1Button3pm.BackColor = Color.Gold;
                O1Button3pm.Text = "Away Period";
                O1Button3pm.Enabled = true;
            }
            //4pm-5pm
            if (O1AwayComboBox.SelectedItem == "4pm-5pm")
            {
                O1Button4pm.BackColor = Color.Gold;
                O1Button4pm.Text = "Away Period";
                O1Button4pm.Enabled = true;
            }
            //5pm-6pm
            if (O1AwayComboBox.SelectedItem == "5pm-6pm")
            { 
                O1Button5pm.BackColor = Color.Gold;
                O1Button5pm.Text = "Away Period";
                O1Button5pm.Enabled = true;
            }
            //6pm-7pm
            if (O1AwayComboBox.SelectedItem == "6pm-7pm")
            {
                O1Button6pm.BackColor = Color.Gold;
                O1Button6pm.Text = "Away Period";
                O1Button6pm.Enabled = true;
            }
            //7pm-8pm
            if (O1AwayComboBox.SelectedItem == "7pm-8pm")
            {
                O1Button7pm.BackColor = Color.Gold;
                O1Button7pm.Text = "Away Period";
                O1Button7pm.Enabled = true;
            }
            //8pm-9pm
            if (O1AwayComboBox.SelectedItem == "8pm-9pm")
            {
                O1Button8pm.BackColor = Color.Gold;
                O1Button8pm.Text = "Away Period";
                O1Button8pm.Enabled = true;
            }
            //9pm-10pm
            if (O1AwayComboBox.SelectedItem == "9pm-10pm")
            {
                O1Button9pm.BackColor = Color.Gold;
                O1Button9pm.Text = "Away Period";
                O1Button9pm.Enabled = true;
            }
        }

        private void customerECOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerECOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerECODataSet);

        }

        private void CustomersDBTabPage_Click(object sender, EventArgs e)
        {

        }

        private void clearShopButton_Click(object sender, EventArgs e)
        {
            //Home Page
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.Text = "";
            dobDateTimePicker.Text = "";
            icTextBox.Clear();
            nationalityTextBox.Clear();
            hpMaskedTextBox.Clear();
            emailTextBox.Clear();
            addressRichTextBox.Clear();
            memberCheckBox.Checked = false;
            Z = 0.00m;

            //Booking Page
            O1RadioButton.Checked = false;
            O2RadioButton.Checked = false;
            O3RadioButton.Checked = false;
            facePictureBox.Image = EyeCareOptical.Properties.Resources.Profile;
            infoRichTextBox.Text = "Please select your preferred optician.";

            //Specs Page
            squareComboBox.SelectedItem = "None";
            ovalComboBox.SelectedItem = "None";
            roundComboBox.SelectedItem = "None";
            micComboBox.SelectedItem = "None";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            squareSpecsPictureBox.Image = null;
            ovalSpecsPictureBox.Image = null;
            roundSpecsPictureBox.Image = null;
            caseRadioButton.Checked = false;
            clothRadioButton.Checked = false;
            lensRadioButton.Checked = false;
            micListBox.Items.Clear();
            degreeLeftTextBox.Clear();
            degreeRightTextBox.Clear();
            totalTextBox.Clear();

            //Back To Home Page
            tabControl.SelectedIndex = 0;
        }

        private void O2NotAvailableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (O2NotAvailableCheckBox.Checked == true)
            {
                O2Button10am.BackColor = Color.SlateGray;
                O2Button10am.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button10am.Enabled = false;

                O2Button11am.BackColor = Color.SlateGray;
                O2Button11am.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button11am.Enabled = false;

                O2Button12pm.BackColor = Color.SlateGray;
                O2Button12pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button12pm.Enabled = false;

                O2Button1pm.BackColor = Color.SlateGray;
                O2Button1pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button1pm.Enabled = false;

                O2Button2pm.BackColor = Color.SlateGray;
                O2Button2pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button2pm.Enabled = false;

                O2Button3pm.BackColor = Color.SlateGray;
                O2Button3pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button3pm.Enabled = false;

                O2Button4pm.BackColor = Color.SlateGray;
                O2Button4pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button4pm.Enabled = false;

                O2Button5pm.BackColor = Color.SlateGray;
                O2Button5pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button5pm.Enabled = false;

                O2Button6pm.BackColor = Color.SlateGray;
                O2Button6pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button6pm.Enabled = false;

                O2Button7pm.BackColor = Color.SlateGray;
                O2Button7pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button7pm.Enabled = false;

                O2Button8pm.BackColor = Color.SlateGray;
                O2Button8pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button8pm.Enabled = false;

                O2Button9pm.BackColor = Color.SlateGray;
                O2Button9pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O2Button9pm.Enabled = false;
            }

            if (O2NotAvailableCheckBox.Checked == false)
            {
                O2Button10am.BackColor = Color.SpringGreen;
                O2Button10am.Text = "10am-11am";
                O2Button10am.Enabled = true;

                O2Button11am.BackColor = Color.SpringGreen;
                O2Button11am.Text = "11am-12noon";
                O2Button11am.Enabled = true;

                O2Button12pm.BackColor = Color.SpringGreen;
                O2Button12pm.Text = "12noon-1pm";
                O2Button12pm.Enabled = true;

                O2Button1pm.BackColor = Color.SpringGreen;
                O2Button1pm.Text = "1pm-2pm";
                O2Button1pm.Enabled = true;

                O2Button2pm.BackColor = Color.SpringGreen;
                O2Button2pm.Text = "2pm-3pm";
                O2Button2pm.Enabled = true;

                O2Button3pm.BackColor = Color.SpringGreen;
                O2Button3pm.Text = "3pm-4pm";
                O2Button3pm.Enabled = true;

                O2Button4pm.BackColor = Color.SpringGreen;
                O2Button4pm.Text = "4pm-5pm";
                O2Button4pm.Enabled = true;

                O2Button5pm.BackColor = Color.SpringGreen;
                O2Button5pm.Text = "5pm-6pm";
                O2Button5pm.Enabled = true;

                O2Button6pm.BackColor = Color.SpringGreen;
                O2Button6pm.Text = "6pm-7pm";
                O2Button6pm.Enabled = true;

                O2Button7pm.BackColor = Color.SpringGreen;
                O2Button7pm.Text = "7pm-8pm";
                O2Button7pm.Enabled = true;

                O2Button8pm.BackColor = Color.SpringGreen;
                O2Button8pm.Text = "8pm-9pm";
                O2Button8pm.Enabled = true;

                O2Button9pm.BackColor = Color.SpringGreen;
                O2Button9pm.Text = "9pm-10pm";
                O2Button9pm.Enabled = true;
            }
        }

        private void O3NotAvailableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (O3NotAvailableCheckBox.Checked == true)
            {
                O3Button10am.BackColor = Color.SlateGray;
                O3Button10am.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button10am.Enabled = false;

                O3Button11am.BackColor = Color.SlateGray;
                O3Button11am.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button11am.Enabled = false;

                O3Button12pm.BackColor = Color.SlateGray;
                O3Button12pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button12pm.Enabled = false;

                O3Button1pm.BackColor = Color.SlateGray;
                O3Button1pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button1pm.Enabled = false;

                O3Button2pm.BackColor = Color.SlateGray;
                O3Button2pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button2pm.Enabled = false;

                O3Button3pm.BackColor = Color.SlateGray;
                O3Button3pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button3pm.Enabled = false;

                O3Button4pm.BackColor = Color.SlateGray;
                O3Button4pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button4pm.Enabled = false;

                O3Button5pm.BackColor = Color.SlateGray;
                O3Button5pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button5pm.Enabled = false;

                O3Button6pm.BackColor = Color.SlateGray;
                O3Button6pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button6pm.Enabled = false;

                O3Button7pm.BackColor = Color.SlateGray;
                O3Button7pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button7pm.Enabled = false;

                O3Button8pm.BackColor = Color.SlateGray;
                O3Button8pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button8pm.Enabled = false;

                O3Button9pm.BackColor = Color.SlateGray;
                O3Button9pm.Text += Environment.NewLine + "NOT AVAILABLE";
                O3Button9pm.Enabled = false;
            }

            if (O3NotAvailableCheckBox.Checked == false)
            {
                O3Button10am.BackColor = Color.SpringGreen;
                O3Button10am.Text = "10am-11am";
                O3Button10am.Enabled = true;

                O3Button11am.BackColor = Color.SpringGreen;
                O3Button11am.Text = "11am-12noon";
                O3Button11am.Enabled = true;

                O3Button12pm.BackColor = Color.SpringGreen;
                O3Button12pm.Text = "12noon-1pm";
                O3Button12pm.Enabled = true;

                O3Button1pm.BackColor = Color.SpringGreen;
                O3Button1pm.Text = "1pm-2pm";
                O3Button1pm.Enabled = true;

                O3Button2pm.BackColor = Color.SpringGreen;
                O3Button2pm.Text = "2pm-3pm";
                O3Button2pm.Enabled = true;

                O3Button3pm.BackColor = Color.SpringGreen;
                O3Button3pm.Text = "3pm-4pm";
                O3Button3pm.Enabled = true;

                O3Button4pm.BackColor = Color.SpringGreen;
                O3Button4pm.Text = "4pm-5pm";
                O3Button4pm.Enabled = true;

                O3Button5pm.BackColor = Color.SpringGreen;
                O3Button5pm.Text = "5pm-6pm";
                O3Button5pm.Enabled = true;

                O3Button6pm.BackColor = Color.SpringGreen;
                O3Button6pm.Text = "6pm-7pm";
                O3Button6pm.Enabled = true;

                O3Button7pm.BackColor = Color.SpringGreen;
                O3Button7pm.Text = "7pm-8pm";
                O3Button7pm.Enabled = true;

                O3Button8pm.BackColor = Color.SpringGreen;
                O3Button8pm.Text = "8pm-9pm";
                O3Button8pm.Enabled = true;

                O3Button9pm.BackColor = Color.SpringGreen;
                O3Button9pm.Text = "9pm-10pm";
                O3Button9pm.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (squareComboBox.SelectedItem == "None")
            {
                squareSpecsPictureBox.Image = null;
                A = 0.00m;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "K.moriyama KM1107E-T --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.KM1107ET;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR UltemAU2013-M --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AU2013M;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR UltemAU2012-M --- $198")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AU2012M;
                A = 198.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
            else if (squareComboBox.SelectedItem == "AIR For MenAR2006-T --- $138")
            {
                squareSpecsPictureBox.Image = EyeCareOptical.Properties.Resources.AR2006T;
                A = 138.00m * numericUpDown1.Value;
                Total = A + B + C + D + Z;
                totalTextBox.Text = Total.ToString("C");
            }
        }
    }
}
