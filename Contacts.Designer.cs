namespace US_Land_System_Alpha
{
    partial class Contacts
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            InHouseOwner_Value = new CheckBox();
            FederalTaxWithold_Value = new CheckBox();
            OtherExempt_Value = new CheckBox();
            ExpenseExempt_Value = new CheckBox();
            SeveranceTaxExempt_Value = new CheckBox();
            Send1099_Value = new CheckBox();
            Active_Value = new CheckBox();
            label19 = new Label();
            NoPayCode_Value = new ComboBox();
            label18 = new Label();
            WebPage_Value = new TextBox();
            label17 = new Label();
            Email_Value = new TextBox();
            TaxIDType_Value = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            TaxID_Value = new TextBox();
            label14 = new Label();
            AlternateID_Value = new TextBox();
            label13 = new Label();
            BankAccountNumber_Value = new TextBox();
            label12 = new Label();
            DefaultBankID_Value = new TextBox();
            label11 = new Label();
            GeneralClass_Value = new TextBox();
            label10 = new Label();
            TenureCode_Value = new TextBox();
            label9 = new Label();
            Home_Value = new TextBox();
            label8 = new Label();
            Work_Value = new TextBox();
            label7 = new Label();
            Mobile_Value = new TextBox();
            label6 = new Label();
            Address_Value = new TextBox();
            label5 = new Label();
            FullName_Value = new TextBox();
            label4 = new Label();
            OwnerID_Value = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label3 = new Label();
            Reminder_Value = new CheckBox();
            Notes_Value = new TextBox();
            label2 = new Label();
            ContactDate_Value = new TextBox();
            label1 = new Label();
            ContactType_Value = new ComboBox();
            BackButton = new Button();
            SaveButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 372);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(InHouseOwner_Value);
            tabPage1.Controls.Add(FederalTaxWithold_Value);
            tabPage1.Controls.Add(OtherExempt_Value);
            tabPage1.Controls.Add(ExpenseExempt_Value);
            tabPage1.Controls.Add(SeveranceTaxExempt_Value);
            tabPage1.Controls.Add(Send1099_Value);
            tabPage1.Controls.Add(Active_Value);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(NoPayCode_Value);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(WebPage_Value);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(Email_Value);
            tabPage1.Controls.Add(TaxIDType_Value);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(TaxID_Value);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(AlternateID_Value);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(BankAccountNumber_Value);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(DefaultBankID_Value);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(GeneralClass_Value);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(TenureCode_Value);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(Home_Value);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(Work_Value);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(Mobile_Value);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(Address_Value);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(FullName_Value);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(OwnerID_Value);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // InHouseOwner_Value
            // 
            InHouseOwner_Value.AutoSize = true;
            InHouseOwner_Value.Location = new Point(699, 156);
            InHouseOwner_Value.Name = "InHouseOwner_Value";
            InHouseOwner_Value.Size = new Size(116, 19);
            InHouseOwner_Value.TabIndex = 39;
            InHouseOwner_Value.Text = "In House Owner?";
            InHouseOwner_Value.UseVisualStyleBackColor = true;
            // 
            // FederalTaxWithold_Value
            // 
            FederalTaxWithold_Value.AutoSize = true;
            FederalTaxWithold_Value.Location = new Point(699, 131);
            FederalTaxWithold_Value.Name = "FederalTaxWithold_Value";
            FederalTaxWithold_Value.Size = new Size(134, 19);
            FederalTaxWithold_Value.TabIndex = 38;
            FederalTaxWithold_Value.Text = "Federal Tax Withold?";
            FederalTaxWithold_Value.UseVisualStyleBackColor = true;
            FederalTaxWithold_Value.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // OtherExempt_Value
            // 
            OtherExempt_Value.AutoSize = true;
            OtherExempt_Value.Location = new Point(699, 106);
            OtherExempt_Value.Name = "OtherExempt_Value";
            OtherExempt_Value.Size = new Size(113, 19);
            OtherExempt_Value.TabIndex = 37;
            OtherExempt_Value.Text = "\"Other\" Exempt?";
            OtherExempt_Value.UseVisualStyleBackColor = true;
            // 
            // ExpenseExempt_Value
            // 
            ExpenseExempt_Value.AutoSize = true;
            ExpenseExempt_Value.Location = new Point(699, 81);
            ExpenseExempt_Value.Name = "ExpenseExempt_Value";
            ExpenseExempt_Value.Size = new Size(115, 19);
            ExpenseExempt_Value.TabIndex = 36;
            ExpenseExempt_Value.Text = "Expense Exempt?";
            ExpenseExempt_Value.UseVisualStyleBackColor = true;
            // 
            // SeveranceTaxExempt_Value
            // 
            SeveranceTaxExempt_Value.AutoSize = true;
            SeveranceTaxExempt_Value.Location = new Point(699, 56);
            SeveranceTaxExempt_Value.Name = "SeveranceTaxExempt_Value";
            SeveranceTaxExempt_Value.Size = new Size(146, 19);
            SeveranceTaxExempt_Value.TabIndex = 35;
            SeveranceTaxExempt_Value.Text = "Severance Tax Exempt?";
            SeveranceTaxExempt_Value.UseVisualStyleBackColor = true;
            // 
            // Send1099_Value
            // 
            Send1099_Value.AutoSize = true;
            Send1099_Value.Location = new Point(699, 31);
            Send1099_Value.Name = "Send1099_Value";
            Send1099_Value.Size = new Size(84, 19);
            Send1099_Value.TabIndex = 34;
            Send1099_Value.Text = "Send 1099?";
            Send1099_Value.UseVisualStyleBackColor = true;
            // 
            // Active_Value
            // 
            Active_Value.AutoSize = true;
            Active_Value.Location = new Point(699, 6);
            Active_Value.Name = "Active_Value";
            Active_Value.Size = new Size(64, 19);
            Active_Value.TabIndex = 33;
            Active_Value.Text = "Active?";
            Active_Value.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(396, 159);
            label19.Name = "label19";
            label19.Size = new Size(88, 15);
            label19.TabIndex = 32;
            label19.Text = "\"No-Pay\" Code";
            // 
            // NoPayCode_Value
            // 
            NoPayCode_Value.FormattingEnabled = true;
            NoPayCode_Value.Location = new Point(490, 154);
            NoPayCode_Value.Name = "NoPayCode_Value";
            NoPayCode_Value.Size = new Size(203, 23);
            NoPayCode_Value.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(424, 128);
            label18.Name = "label18";
            label18.Size = new Size(60, 15);
            label18.TabIndex = 30;
            label18.Text = "Web Page";
            // 
            // WebPage_Value
            // 
            WebPage_Value.Location = new Point(490, 125);
            WebPage_Value.Name = "WebPage_Value";
            WebPage_Value.Size = new Size(203, 23);
            WebPage_Value.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(448, 99);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 28;
            label17.Text = "Email";
            // 
            // Email_Value
            // 
            Email_Value.Location = new Point(490, 96);
            Email_Value.Name = "Email_Value";
            Email_Value.Size = new Size(203, 23);
            Email_Value.TabIndex = 27;
            // 
            // TaxIDType_Value
            // 
            TaxIDType_Value.FormattingEnabled = true;
            TaxIDType_Value.Location = new Point(490, 67);
            TaxIDType_Value.Name = "TaxIDType_Value";
            TaxIDType_Value.Size = new Size(203, 23);
            TaxIDType_Value.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(419, 70);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 25;
            label16.Text = "Tax ID Type";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(446, 41);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 23;
            label15.Text = "Tax ID";
            // 
            // TaxID_Value
            // 
            TaxID_Value.Location = new Point(490, 38);
            TaxID_Value.Name = "TaxID_Value";
            TaxID_Value.Size = new Size(203, 23);
            TaxID_Value.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(415, 12);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 21;
            label14.Text = "Alternate ID";
            // 
            // AlternateID_Value
            // 
            AlternateID_Value.Location = new Point(490, 9);
            AlternateID_Value.Name = "AlternateID_Value";
            AlternateID_Value.Size = new Size(203, 23);
            AlternateID_Value.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 270);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 19;
            label13.Text = "Bank Account Number";
            // 
            // BankAccountNumber_Value
            // 
            BankAccountNumber_Value.Location = new Point(140, 267);
            BankAccountNumber_Value.Name = "BankAccountNumber_Value";
            BankAccountNumber_Value.Size = new Size(203, 23);
            BankAccountNumber_Value.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 241);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 17;
            label12.Text = "Default Bank ID";
            // 
            // DefaultBankID_Value
            // 
            DefaultBankID_Value.Location = new Point(140, 238);
            DefaultBankID_Value.Name = "DefaultBankID_Value";
            DefaultBankID_Value.Size = new Size(203, 23);
            DefaultBankID_Value.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 212);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 15;
            label11.Text = "General Class";
            // 
            // GeneralClass_Value
            // 
            GeneralClass_Value.Location = new Point(140, 209);
            GeneralClass_Value.Name = "GeneralClass_Value";
            GeneralClass_Value.Size = new Size(203, 23);
            GeneralClass_Value.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 183);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 13;
            label10.Text = "Tenure Code";
            // 
            // TenureCode_Value
            // 
            TenureCode_Value.Location = new Point(140, 180);
            TenureCode_Value.Name = "TenureCode_Value";
            TenureCode_Value.Size = new Size(203, 23);
            TenureCode_Value.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 154);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 11;
            label9.Text = "Home";
            // 
            // Home_Value
            // 
            Home_Value.Location = new Point(140, 151);
            Home_Value.Name = "Home_Value";
            Home_Value.Size = new Size(203, 23);
            Home_Value.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 125);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 9;
            label8.Text = "Work";
            // 
            // Work_Value
            // 
            Work_Value.Location = new Point(140, 122);
            Work_Value.Name = "Work_Value";
            Work_Value.Size = new Size(203, 23);
            Work_Value.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 96);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 7;
            label7.Text = "Mobile";
            // 
            // Mobile_Value
            // 
            Mobile_Value.Location = new Point(140, 93);
            Mobile_Value.Name = "Mobile_Value";
            Mobile_Value.Size = new Size(203, 23);
            Mobile_Value.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // Address_Value
            // 
            Address_Value.Location = new Point(140, 64);
            Address_Value.Name = "Address_Value";
            Address_Value.Size = new Size(203, 23);
            Address_Value.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 38);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Full Name";
            // 
            // FullName_Value
            // 
            FullName_Value.Location = new Point(140, 35);
            FullName_Value.Name = "FullName_Value";
            FullName_Value.Size = new Size(203, 23);
            FullName_Value.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 1;
            label4.Text = "OwnerID";
            // 
            // OwnerID_Value
            // 
            OwnerID_Value.Location = new Point(140, 6);
            OwnerID_Value.Name = "OwnerID_Value";
            OwnerID_Value.Size = new Size(203, 23);
            OwnerID_Value.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "More";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(Reminder_Value);
            tabPage3.Controls.Add(Notes_Value);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(ContactDate_Value);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(ContactType_Value);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(852, 344);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Contact History";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Notes";
            // 
            // Reminder_Value
            // 
            Reminder_Value.AutoSize = true;
            Reminder_Value.Location = new Point(88, 270);
            Reminder_Value.Name = "Reminder_Value";
            Reminder_Value.Size = new Size(82, 19);
            Reminder_Value.TabIndex = 5;
            Reminder_Value.Text = "Reminder?";
            Reminder_Value.UseVisualStyleBackColor = true;
            // 
            // Notes_Value
            // 
            Notes_Value.Location = new Point(88, 64);
            Notes_Value.Multiline = true;
            Notes_Value.Name = "Notes_Value";
            Notes_Value.Size = new Size(758, 154);
            Notes_Value.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Contact Date";
            // 
            // ContactDate_Value
            // 
            ContactDate_Value.Location = new Point(88, 35);
            ContactDate_Value.Name = "ContactDate_Value";
            ContactDate_Value.Size = new Size(302, 23);
            ContactDate_Value.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Contact Type";
            // 
            // ContactType_Value
            // 
            ContactType_Value.FormattingEnabled = true;
            ContactType_Value.Location = new Point(88, 6);
            ContactType_Value.Name = "ContactType_Value";
            ContactType_Value.Size = new Size(302, 23);
            ContactType_Value.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(tabControl1);
            Name = "Contacts";
            Text = "Contacts";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private CheckBox Reminder_Value;
        private TextBox Notes_Value;
        private Label label2;
        private TextBox ContactDate_Value;
        private Label label1;
        private ComboBox ContactType_Value;
        private TextBox Work_Value;
        private Label label7;
        private TextBox Mobile_Value;
        private Label label6;
        private TextBox Address_Value;
        private Label label5;
        private TextBox FullName_Value;
        private Label label4;
        private TextBox OwnerID_Value;
        private Label label12;
        private TextBox DefaultBankID_Value;
        private Label label11;
        private TextBox GeneralClass_Value;
        private Label label10;
        private TextBox TenureCode_Value;
        private Label label9;
        private TextBox Home_Value;
        private Label label8;
        private Label label17;
        private TextBox Email_Value;
        private ComboBox TaxIDType_Value;
        private Label label16;
        private Label label15;
        private TextBox TaxID_Value;
        private Label label14;
        private TextBox AlternateID_Value;
        private Label label13;
        private TextBox BankAccountNumber_Value;
        private CheckBox FederalTaxWithold_Value;
        private CheckBox OtherExempt_Value;
        private CheckBox ExpenseExempt_Value;
        private CheckBox SeveranceTaxExempt_Value;
        private CheckBox Send1099_Value;
        private CheckBox Active_Value;
        private Label label19;
        private ComboBox NoPayCode_Value;
        private Label label18;
        private TextBox WebPage_Value;
        private CheckBox InHouseOwner_Value;
        private Button BackButton;
        private Button SaveButton;
    }
}