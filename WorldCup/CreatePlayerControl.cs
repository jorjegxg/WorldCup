using Models;

using NivelStocareDate;

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
    public partial class CreatePlayerControl : UserControl
    {
        private IStocareData fisierStocare;
        private string imagePath = "";

        public CreatePlayerControl()
        {
            InitializeComponent();

            fisierStocare = new AdministrareJucatori_Cache();
        }

          private void pickImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                imagePath = selectedImagePath;

                // Display the selected image
                playerImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            fisierStocare.AddPlayer(
                new PlayerEntity(
                nameTextBox.Text,
                secondNameTextBox.Text,
                positionComboBox.Text,
                getRadioButtonValue(),
                positionCheckBox.Checked,
                imagePath

                ));
            imagePath = "";


            MessageBox.Show(fisierStocare.GetPlayers()[0].ToString());


        }

        private Position getRadioButtonValue()
        {
            if (leftRadioButton.Checked)
            {
                return Position.left;
            }
            else if (rightRadioButton.Checked)
            {
                return Position.right;
            }
            else
            {
                return Position.middle;
            }
        }

        private void createPlayerControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
