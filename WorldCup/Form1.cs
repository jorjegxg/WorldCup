using Models;

using NivelStocareDate;

using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorldCup
{
    public partial class Form1 : Form

    {

        private IStocareData fisierStocare;
        private string imagePath = "";



        public Form1()
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
            try
            {

                if (!valuesAreValid())
                {
                    return;
                }

                fisierStocare.AddPlayer(
                 new PlayerEntity(
                 nameTextBox.Text,
                 secondNameTextBox.Text,
                 positionComboBox.Text,
                 getRadioButtonValue(),
                 positionCheckBox.Checked,
                 imagePath

                 ));
                

                DataTable table = new DataTable();
                table.Columns.Add("Nume", typeof(string));
                table.Columns.Add("Prenume", typeof(string));
                table.Columns.Add("Positie", typeof(string));
                table.Columns.Add("Positie orizontala", typeof(string));

                table.Columns.Add("Poate juca altundeva", typeof(string));


                foreach (PlayerEntity playerEntity in fisierStocare.GetPlayers())
                {
                    table.Rows.Add(
                        playerEntity.name,
                        playerEntity.secondName,
                        playerEntity.position,
                        playerEntity.positionInField,
                        playerEntity.canPlayOtherPosition );

                }


                // Asociază sursa de date a DataGridView la tabelul de date
                

                dataGridView1.DataSource = table;

                dataGridView1.AutoResizeColumns();

                //dataGridView1.AutoResizeColumn(2);



                ResetForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private bool valuesAreValid()
        {

            if (playerImage.Image == null)
            {
                throw new Exception(Constants.pickImageError);
            }

            if (nameTextBox.Text == "" )
            {
                throw new Exception(Constants.pickNameError);
            }

            if (secondNameTextBox.Text == "")
            {
                throw new Exception(Constants.pickFirstNameeError);
            }

            if (positionComboBox.Text == "" || positionCheckBox.Text == null)
            {
                throw new Exception(Constants.pickPositionError);
            }

            if (leftRadioButton.Checked == false && rightRadioButton.Checked == false && middleRadioButton.Checked == false)
            {
                throw new Exception(Constants.pickPositionOnHorizontalError);
            }

            return true;

            
        }

        private void ResetForm()
        {
            nameTextBox.Text = "";
            secondNameTextBox.Text = "";
            playerImage.Image = null;
            positionComboBox.SelectedValue = null;
            leftRadioButton.Checked = true;
            positionCheckBox.Checked = false;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}