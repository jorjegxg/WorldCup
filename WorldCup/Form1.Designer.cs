namespace WorldCup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.middleRadioButton = new System.Windows.Forms.RadioButton();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.positionCheckBox = new System.Windows.Forms.CheckBox();
            this.pickImageButton = new System.Windows.Forms.Button();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.playerImage.Location = new System.Drawing.Point(33, 26);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(100, 50);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerImage.TabIndex = 43;
            this.playerImage.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createButton.Location = new System.Drawing.Point(167, 429);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(265, 54);
            this.createButton.TabIndex = 42;
            this.createButton.Text = "Create Player";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.label2.Location = new System.Drawing.Point(34, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "Pozitie";
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Portar",
            "Fundas",
            "Mijlocas",
            "Atacant"});
            this.positionComboBox.Location = new System.Drawing.Point(167, 203);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(265, 40);
            this.positionComboBox.TabIndex = 40;
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rightRadioButton.Location = new System.Drawing.Point(38, 357);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(88, 36);
            this.rightRadioButton.TabIndex = 39;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // middleRadioButton
            // 
            this.middleRadioButton.AutoSize = true;
            this.middleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.middleRadioButton.Location = new System.Drawing.Point(37, 315);
            this.middleRadioButton.Name = "middleRadioButton";
            this.middleRadioButton.Size = new System.Drawing.Size(107, 36);
            this.middleRadioButton.TabIndex = 38;
            this.middleRadioButton.TabStop = true;
            this.middleRadioButton.Text = "Middle";
            this.middleRadioButton.UseVisualStyleBackColor = true;
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.leftRadioButton.Location = new System.Drawing.Point(38, 272);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(72, 36);
            this.leftRadioButton.TabIndex = 37;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionCheckBox
            // 
            this.positionCheckBox.AutoSize = true;
            this.positionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.positionCheckBox.Location = new System.Drawing.Point(194, 329);
            this.positionCheckBox.Name = "positionCheckBox";
            this.positionCheckBox.Size = new System.Drawing.Size(289, 36);
            this.positionCheckBox.TabIndex = 36;
            this.positionCheckBox.Text = "Poate juca si alta pozitie";
            this.positionCheckBox.UseVisualStyleBackColor = true;
            // 
            // pickImageButton
            // 
            this.pickImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.pickImageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pickImageButton.Location = new System.Drawing.Point(167, 26);
            this.pickImageButton.Name = "pickImageButton";
            this.pickImageButton.Size = new System.Drawing.Size(159, 41);
            this.pickImageButton.TabIndex = 35;
            this.pickImageButton.Text = "Pick Image";
            this.pickImageButton.UseVisualStyleBackColor = false;
            this.pickImageButton.Click += new System.EventHandler(this.pickImageButton_Click);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(167, 144);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(265, 39);
            this.secondNameTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(34, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Prenume";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 39);
            this.nameTextBox.TabIndex = 32;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.nameLabel.Location = new System.Drawing.Point(34, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 32);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Nume";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(850, 522);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1373, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.rightRadioButton);
            this.Controls.Add(this.middleRadioButton);
            this.Controls.Add(this.leftRadioButton);
            this.Controls.Add(this.positionCheckBox);
            this.Controls.Add(this.pickImageButton);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "crea";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CreatePlayerControl createPlayerControl1;
        private Panel panelPagina2;
        private PictureBox playerImage;
        private Button createButton;
        private Label label2;
        private ComboBox positionComboBox;
        private RadioButton rightRadioButton;
        private RadioButton middleRadioButton;
        private RadioButton leftRadioButton;
        private CheckBox positionCheckBox;
        private Button pickImageButton;
        private TextBox secondNameTextBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label nameLabel;
        private DataGridView dataGridView1;
    }
}