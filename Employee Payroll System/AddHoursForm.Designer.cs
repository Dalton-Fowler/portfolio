namespace WinFormsApp1
{
    partial class AddHoursForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextBotton = new Button();
            clearButton = new Button();
            closeAndSaveButton = new Button();
            hoursDataGroupBox = new GroupBox();
            hoursWorked = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            hoursTextBox = new TextBox();
            nameTextBoxHours = new TextBox();
            idTextBoxHours = new TextBox();
            hoursDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nextBotton
            // 
            nextBotton.Location = new Point(50, 304);
            nextBotton.Name = "nextBotton";
            nextBotton.Size = new Size(75, 23);
            nextBotton.TabIndex = 0;
            nextBotton.Text = "&Next";
            nextBotton.UseVisualStyleBackColor = true;
            nextBotton.Click += nextBotton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(172, 304);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // closeAndSaveButton
            // 
            closeAndSaveButton.Location = new Point(294, 304);
            closeAndSaveButton.Name = "closeAndSaveButton";
            closeAndSaveButton.Size = new Size(112, 23);
            closeAndSaveButton.TabIndex = 2;
            closeAndSaveButton.Text = "Cl&ose and Save";
            closeAndSaveButton.UseVisualStyleBackColor = true;
            closeAndSaveButton.Click += closeAndSaveButton_Click;
            // 
            // hoursDataGroupBox
            // 
            hoursDataGroupBox.Controls.Add(hoursWorked);
            hoursDataGroupBox.Controls.Add(nameLabel);
            hoursDataGroupBox.Controls.Add(idLabel);
            hoursDataGroupBox.Location = new Point(24, 24);
            hoursDataGroupBox.Name = "hoursDataGroupBox";
            hoursDataGroupBox.Size = new Size(397, 255);
            hoursDataGroupBox.TabIndex = 3;
            hoursDataGroupBox.TabStop = false;
            hoursDataGroupBox.Text = "Hours Data";
            // 
            // hoursWorked
            // 
            hoursWorked.AutoSize = true;
            hoursWorked.Location = new Point(80, 204);
            hoursWorked.Name = "hoursWorked";
            hoursWorked.Size = new Size(83, 15);
            hoursWorked.TabIndex = 2;
            hoursWorked.Text = "Hours Worked";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(80, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Employee Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(80, 59);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(73, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Employee ID";
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(269, 228);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(100, 23);
            hoursTextBox.TabIndex = 3;
            // 
            // nameTextBoxHours
            // 
            nameTextBoxHours.Location = new Point(269, 148);
            nameTextBoxHours.Name = "nameTextBoxHours";
            nameTextBoxHours.Size = new Size(100, 23);
            nameTextBoxHours.TabIndex = 4;
            // 
            // idTextBoxHours
            // 
            idTextBoxHours.Location = new Point(269, 75);
            idTextBoxHours.Name = "idTextBoxHours";
            idTextBoxHours.Size = new Size(100, 23);
            idTextBoxHours.TabIndex = 5;
            // 
            // AddHoursForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 360);
            Controls.Add(hoursTextBox);
            Controls.Add(nameTextBoxHours);
            Controls.Add(idTextBoxHours);
            Controls.Add(hoursDataGroupBox);
            Controls.Add(closeAndSaveButton);
            Controls.Add(clearButton);
            Controls.Add(nextBotton);
            Name = "AddHoursForm";
            Text = "AddHoursForm";
            Load += AddHoursForm_Load;
            hoursDataGroupBox.ResumeLayout(false);
            hoursDataGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextBotton;
        private Button clearButton;
        private Button closeAndSaveButton;
        private GroupBox hoursDataGroupBox;
        private Label hoursWorked;
        private Label nameLabel;
        private Label idLabel;
        private TextBox hoursTextBox;
        private TextBox nameTextBoxHours;
        private TextBox idTextBoxHours;
    }
}