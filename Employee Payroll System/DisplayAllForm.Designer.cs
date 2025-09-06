namespace WinFormsApp1
{
    partial class DisplayAllForm
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
            allEmployees = new Label();
            employeesListBox = new ListBox();
            closeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // allEmployees
            // 
            allEmployees.AutoSize = true;
            allEmployees.Location = new Point(44, 18);
            allEmployees.Name = "allEmployees";
            allEmployees.Size = new Size(81, 15);
            allEmployees.TabIndex = 0;
            allEmployees.Text = "All Employees";
            // 
            // employeesListBox
            // 
            employeesListBox.FormattingEnabled = true;
            employeesListBox.ItemHeight = 15;
            employeesListBox.Location = new Point(44, 36);
            employeesListBox.Name = "employeesListBox";
            employeesListBox.Size = new Size(395, 184);
            employeesListBox.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(98, 244);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            printButton.Location = new Point(287, 244);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 3;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // DisplayAllForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 292);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(employeesListBox);
            Controls.Add(allEmployees);
            Name = "DisplayAllForm";
            Text = "DisplayAll";
            Load += DisplayAllForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label allEmployees;
        private ListBox employeesListBox;
        private Button closeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}