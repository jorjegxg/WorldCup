using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCup
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private async void pickImageButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == passwordTextBox.Text && emailTextBox.Text != null && emailTextBox.Text != "")
            {
                signInProgressBar.Value = 10;
                await Task.Delay(2000);
                signInProgressBar.Value = 50;
                await Task.Delay(3000);
                signInProgressBar.Value = 100;

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                signInProgressBar.Value = 10;
                await Task.Delay(2000);
                signInProgressBar.Value = 40;
                await Task.Delay(4000);
                signInProgressBar.Value = 80;
                await Task.Delay(7000);

                signInProgressBar.Value = 95;
                await Task.Delay(1000);
                signInProgressBar.Value = 0;


                MessageBox.Show("Ti-ai uitat parola [Parola Gresita] ?");
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
