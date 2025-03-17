namespace US_Land_System_Alpha
{
    partial class WI_Decks_Interest
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
            OwnerID_Value = new TextBox();
            label1 = new Label();
            InterestFormula_Value = new TextBox();
            label2 = new Label();
            Interest_Value = new TextBox();
            label3 = new Label();
            Effective_Value = new TextBox();
            label4 = new Label();
            ExpirationDate_Value = new TextBox();
            label5 = new Label();
            SuspenseCode_Value = new TextBox();
            label6 = new Label();
            label7 = new Label();
            InterestType_Value = new ComboBox();
            SendReports_Value = new CheckBox();
            Active_Value = new CheckBox();
            BackButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // OwnerID_Value
            // 
            OwnerID_Value.Location = new Point(111, 77);
            OwnerID_Value.Name = "OwnerID_Value";
            OwnerID_Value.Size = new Size(218, 23);
            OwnerID_Value.TabIndex = 0;
            OwnerID_Value.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Owner ID";
            // 
            // InterestFormula_Value
            // 
            InterestFormula_Value.Location = new Point(111, 106);
            InterestFormula_Value.Multiline = true;
            InterestFormula_Value.Name = "InterestFormula_Value";
            InterestFormula_Value.Size = new Size(687, 88);
            InterestFormula_Value.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Interest Formula";
            // 
            // Interest_Value
            // 
            Interest_Value.Location = new Point(111, 200);
            Interest_Value.Name = "Interest_Value";
            Interest_Value.Size = new Size(218, 23);
            Interest_Value.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Interest";
            // 
            // Effective_Value
            // 
            Effective_Value.Location = new Point(111, 229);
            Effective_Value.Name = "Effective_Value";
            Effective_Value.Size = new Size(218, 23);
            Effective_Value.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Effective";
            // 
            // ExpirationDate_Value
            // 
            ExpirationDate_Value.Location = new Point(111, 258);
            ExpirationDate_Value.Name = "ExpirationDate_Value";
            ExpirationDate_Value.Size = new Size(218, 23);
            ExpirationDate_Value.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 261);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 9;
            label5.Text = "Expiration Date";
            // 
            // SuspenseCode_Value
            // 
            SuspenseCode_Value.Location = new Point(111, 287);
            SuspenseCode_Value.Name = "SuspenseCode_Value";
            SuspenseCode_Value.Size = new Size(218, 23);
            SuspenseCode_Value.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 11;
            label6.Text = "Suspense Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 319);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 13;
            label7.Text = "Interest Type";
            // 
            // InterestType_Value
            // 
            InterestType_Value.FormattingEnabled = true;
            InterestType_Value.Location = new Point(111, 316);
            InterestType_Value.Name = "InterestType_Value";
            InterestType_Value.Size = new Size(218, 23);
            InterestType_Value.TabIndex = 14;
            // 
            // SendReports_Value
            // 
            SendReports_Value.AutoSize = true;
            SendReports_Value.Location = new Point(698, 202);
            SendReports_Value.Name = "SendReports_Value";
            SendReports_Value.Size = new Size(100, 19);
            SendReports_Value.TabIndex = 15;
            SendReports_Value.Text = "Send Reports?";
            SendReports_Value.UseVisualStyleBackColor = true;
            // 
            // Active_Value
            // 
            Active_Value.AutoSize = true;
            Active_Value.Location = new Point(698, 318);
            Active_Value.Name = "Active_Value";
            Active_Value.Size = new Size(64, 19);
            Active_Value.TabIndex = 16;
            Active_Value.Text = "Active?";
            Active_Value.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // WI_Decks_Interest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(Active_Value);
            Controls.Add(SendReports_Value);
            Controls.Add(InterestType_Value);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(SuspenseCode_Value);
            Controls.Add(label5);
            Controls.Add(ExpirationDate_Value);
            Controls.Add(label4);
            Controls.Add(Effective_Value);
            Controls.Add(label3);
            Controls.Add(Interest_Value);
            Controls.Add(label2);
            Controls.Add(InterestFormula_Value);
            Controls.Add(label1);
            Controls.Add(OwnerID_Value);
            Name = "WI_Decks_Interest";
            Text = "WI_Decks_Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OwnerID_Value;
        private Label label1;
        private TextBox InterestFormula_Value;
        private Label label2;
        private TextBox Interest_Value;
        private Label label3;
        private TextBox Effective_Value;
        private Label label4;
        private TextBox ExpirationDate_Value;
        private Label label5;
        private TextBox SuspenseCode_Value;
        private Label label6;
        private Label label7;
        private ComboBox InterestType_Value;
        private CheckBox SendReports_Value;
        private CheckBox Active_Value;
        private Button BackButton;
        private Button SaveButton;
    }
}