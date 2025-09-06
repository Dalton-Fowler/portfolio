namespace WinFormsApp1
{
    partial class AddEmployee
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
            newEmployeeGroupBox = new GroupBox();
            payRateTextBox = new TextBox();
            nameTextBox = new TextBox();
            employeeID = new Label();
            employeeName = new Label();
            idTextBox = new TextBox();
            payRate = new Label();
            saveButton = new Button();
            clearButton = new Button();
            closeButton = new Button();
            newEmployeeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // newEmployeeGroupBox
            // 
            newEmployeeGroupBox.Controls.Add(payRateTextBox);
            newEmployeeGroupBox.Controls.Add(nameTextBox);
            newEmployeeGroupBox.Controls.Add(employeeID);
            newEmployeeGroupBox.Controls.Add(employeeName);
            newEmployeeGroupBox.Controls.Add(idTextBox);
            newEmployeeGroupBox.Controls.Add(payRate);
            newEmployeeGroupBox.Location = new Point(0, 0);
            newEmployeeGroupBox.Name = "newEmployeeGroupBox";
            newEmployeeGroupBox.Size = new Size(468, 259);
            newEmployeeGroupBox.TabIndex = 0;
            newEmployeeGroupBox.TabStop = false;
            newEmployeeGroupBox.Text = "New Employee";
            // 
            // payRateTextBox
            // 
            payRateTextBox.Location = new Point(271, 172);
            payRateTextBox.Name = "payRateTextBox";
            payRateTextBox.Size = new Size(100, 23);
            payRateTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(271, 117);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 9;
            // 
            // employeeID
            // 
            employeeID.AutoSize = true;
            employeeID.Location = new Point(68, 58);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(73, 15);
            employeeID.TabIndex = 1;
            employeeID.Text = "Employee ID";
            // 
            // employeeName
            // 
            employeeName.AutoSize = true;
            employeeName.Location = new Point(68, 106);
            employeeName.Name = "employeeName";
            employeeName.Size = new Size(94, 15);
            employeeName.TabIndex = 2;
            employeeName.Text = "Employee Name";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(271, 58);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 7;
            // 
            // payRate
            // 
            payRate.AutoSize = true;
            payRate.Location = new Point(68, 161);
            payRate.Name = "payRate";
            payRate.Size = new Size(52, 15);
            payRate.TabIndex = 3;
            payRate.Text = "Pay Rate";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(51, 294);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(197, 294);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(339, 294);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 6;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 329);
            Controls.Add(saveButton);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(newEmployeeGroupBox);
            Name = "AddEmployee";
            Text = "AddEmployee";
            newEmployeeGroupBox.ResumeLayout(false);
            newEmployeeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox newEmployeeGroupBox;
        private TextBox payRateTextBox;
        private TextBox nameTextBox;
        private Label employeeID;
        private Label employeeName;
        private TextBox idTextBox;
        private Label payRate;
        private Button saveButton;
        private Button clearButton;
        private Button closeButton;
    }
}