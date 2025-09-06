namespace WinFormsApp1
{
    partial class MainForm
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
            label1 = new Label();
            addEmployeeButton = new Button();
            addHoursWorkedButton = new Button();
            displayAllButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 22);
            label1.Name = "label1";
            label1.Size = new Size(450, 41);
            label1.TabIndex = 0;
            label1.Text = "Employee Payroll System";
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.Location = new Point(73, 100);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(75, 43);
            addEmployeeButton.TabIndex = 1;
            addEmployeeButton.Text = "&Add Employee";
            addEmployeeButton.UseVisualStyleBackColor = true;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // addHoursWorkedButton
            // 
            addHoursWorkedButton.Location = new Point(302, 100);
            addHoursWorkedButton.Name = "addHoursWorkedButton";
            addHoursWorkedButton.Size = new Size(75, 43);
            addHoursWorkedButton.TabIndex = 2;
            addHoursWorkedButton.Text = "Add Hours Worked";
            addHoursWorkedButton.UseVisualStyleBackColor = true;
            addHoursWorkedButton.Click += addHoursWorkedButton_Click;
            // 
            // displayAllButton
            // 
            displayAllButton.Location = new Point(73, 180);
            displayAllButton.Name = "displayAllButton";
            displayAllButton.Size = new Size(75, 43);
            displayAllButton.TabIndex = 3;
            displayAllButton.Text = "&Display All";
            displayAllButton.UseVisualStyleBackColor = true;
            displayAllButton.Click += displayAllButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(302, 180);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 43);
            exitButton.TabIndex = 4;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 263);
            Controls.Add(exitButton);
            Controls.Add(displayAllButton);
            Controls.Add(addHoursWorkedButton);
            Controls.Add(addEmployeeButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addEmployeeButton;
        private Button addHoursWorkedButton;
        private Button displayAllButton;
        private Button exitButton;
    }
}
