namespace mid_term
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnGeneratePassword = new Button();
            lblGeneratedPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(193, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(202, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 23);
            txtLastName.TabIndex = 1;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(195, 165);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(75, 23);
            btnGeneratePassword.TabIndex = 2;
            btnGeneratePassword.Text = "Generate password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += btnGeneratePassword_Click_1;
            // 
            // lblGeneratedPassword
            // 
            lblGeneratedPassword.Location = new Point(398, 165);
            lblGeneratedPassword.Name = "lblGeneratedPassword";
            lblGeneratedPassword.Size = new Size(75, 23);
            lblGeneratedPassword.TabIndex = 3;
            lblGeneratedPassword.Text = "button2";
            lblGeneratedPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 93);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGeneratedPassword);
            Controls.Add(btnGeneratePassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnGeneratePassword;
        private Button lblGeneratedPassword;
        private Label label1;
        private Label label2;
    }
}