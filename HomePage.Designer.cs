namespace US_Land_System_Alpha
{
    partial class HomePage
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
            PPIButton = new Button();
            BankButton = new Button();
            CodesButton = new Button();
            ContactsButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // PPIButton
            // 
            PPIButton.Location = new Point(12, 12);
            PPIButton.Name = "PPIButton";
            PPIButton.Size = new Size(163, 23);
            PPIButton.TabIndex = 0;
            PPIButton.Text = "PPI";
            PPIButton.UseVisualStyleBackColor = true;
            PPIButton.Click += PPIButton_Click;
            // 
            // BankButton
            // 
            BankButton.Location = new Point(12, 41);
            BankButton.Name = "BankButton";
            BankButton.Size = new Size(163, 23);
            BankButton.TabIndex = 1;
            BankButton.Text = "Bank";
            BankButton.UseVisualStyleBackColor = true;
            BankButton.Click += BankButton_Click;
            // 
            // CodesButton
            // 
            CodesButton.Location = new Point(12, 70);
            CodesButton.Name = "CodesButton";
            CodesButton.Size = new Size(163, 23);
            CodesButton.TabIndex = 2;
            CodesButton.Text = "Codes";
            CodesButton.UseVisualStyleBackColor = true;
            CodesButton.Click += CodesButton_Click;
            // 
            // ContactsButton
            // 
            ContactsButton.Location = new Point(12, 99);
            ContactsButton.Name = "ContactsButton";
            ContactsButton.Size = new Size(163, 23);
            ContactsButton.TabIndex = 3;
            ContactsButton.Text = "Contacts";
            ContactsButton.UseVisualStyleBackColor = true;
            ContactsButton.Click += ContactsButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 128);
            button1.Name = "button1";
            button1.Size = new Size(163, 23);
            button1.TabIndex = 4;
            button1.Text = "District";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 157);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 5;
            button2.Text = "DOI Interest";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 186);
            button3.Name = "button3";
            button3.Size = new Size(163, 23);
            button3.TabIndex = 6;
            button3.Text = "DOI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 215);
            button4.Name = "button4";
            button4.Size = new Size(163, 23);
            button4.TabIndex = 7;
            button4.Text = "Formations";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 244);
            button5.Name = "button5";
            button5.Size = new Size(163, 23);
            button5.TabIndex = 8;
            button5.Text = "Land Identifier";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 273);
            button6.Name = "button6";
            button6.Size = new Size(163, 23);
            button6.TabIndex = 9;
            button6.Text = "Leases";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 302);
            button7.Name = "button7";
            button7.Size = new Size(163, 23);
            button7.TabIndex = 10;
            button7.Text = "Mining Production Payable";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ContactsButton);
            Controls.Add(CodesButton);
            Controls.Add(BankButton);
            Controls.Add(PPIButton);
            Name = "HomePage";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button PPIButton;
        private Button BankButton;
        private Button CodesButton;
        private Button ContactsButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
