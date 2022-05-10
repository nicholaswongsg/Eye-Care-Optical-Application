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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTextBox.Clear();
            passTextBox.Clear();
            userTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int attemptNO = 0;
        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "admin") && (passTextBox.Text == "pass"))
            {
                Main MMenu = new Main();
                MMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                userTextBox.Clear();
                passTextBox.Clear();
                userTextBox.Focus();
                errorLabel.Text = "Error: Please contact administrator if error persist. 3 login attempts permitted.";
                attemptNO++;
                attemptTextBox.Text = attemptNO.ToString();
            }

            if (attemptTextBox.Text == "1")
            {
                attemptLabel.Text = "2 More Tries Permitted.";
            }
            else if (attemptTextBox.Text == "2")
            {
                attemptLabel.Text = "1 More Try Permitted.";
            }
            else if (attemptTextBox.Text == "3")
            {
                attemptLabel.Text = "No More Try Permitted.";
                loginButton.Visible = false;
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked == true)
            {
                passTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
