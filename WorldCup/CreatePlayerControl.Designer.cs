namespace WorldCup
{
    partial class CreatePlayerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
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
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.playerImage.Location = new System.Drawing.Point(39, 20);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(100, 50);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerImage.TabIndex = 30;
            this.playerImage.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.createButton.Location = new System.Drawing.Point(173, 422);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(265, 54);
            this.createButton.TabIndex = 29;
            this.createButton.Text = "Create Player";
            this.createButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 28;
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
            this.positionComboBox.Location = new System.Drawing.Point(173, 196);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(265, 23);
            this.positionComboBox.TabIndex = 27;
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.Location = new System.Drawing.Point(51, 364);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(53, 19);
            this.rightRadioButton.TabIndex = 26;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // middleRadioButton
            // 
            this.middleRadioButton.AutoSize = true;
            this.middleRadioButton.Location = new System.Drawing.Point(50, 322);
            this.middleRadioButton.Name = "middleRadioButton";
            this.middleRadioButton.Size = new System.Drawing.Size(62, 19);
            this.middleRadioButton.TabIndex = 25;
            this.middleRadioButton.TabStop = true;
            this.middleRadioButton.Text = "Middle";
            this.middleRadioButton.UseVisualStyleBackColor = true;
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.Location = new System.Drawing.Point(51, 279);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(45, 19);
            this.leftRadioButton.TabIndex = 24;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionCheckBox
            // 
            this.positionCheckBox.AutoSize = true;
            this.positionCheckBox.Location = new System.Drawing.Point(374, 322);
            this.positionCheckBox.Name = "positionCheckBox";
            this.positionCheckBox.Size = new System.Drawing.Size(152, 19);
            this.positionCheckBox.TabIndex = 23;
            this.positionCheckBox.Text = "Poate juca si alta pozitie";
            this.positionCheckBox.UseVisualStyleBackColor = true;
            // 
            // pickImageButton
            // 
            this.pickImageButton.Location = new System.Drawing.Point(173, 20);
            this.pickImageButton.Name = "pickImageButton";
            this.pickImageButton.Size = new System.Drawing.Size(159, 41);
            this.pickImageButton.TabIndex = 22;
            this.pickImageButton.Text = "Pick Image";
            this.pickImageButton.UseVisualStyleBackColor = true;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(173, 137);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(265, 23);
            this.secondNameTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prenume";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(173, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 23);
            this.nameTextBox.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 89);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 15);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Nume";
            // 
            // createPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "createPlayerControl";
            this.Size = new System.Drawing.Size(874, 532);
            this.Load += new System.EventHandler(this.createPlayerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}
