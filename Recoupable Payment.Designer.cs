namespace US_Land_System_Alpha
{
    partial class Recoupable_Payment
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
            RecoupEffectiveDate_Value = new TextBox();
            label1 = new Label();
            Category_Value = new ComboBox();
            NetAmountDue_Value = new TextBox();
            label2 = new Label();
            label3 = new Label();
            RecoupExpirationDate_Value = new TextBox();
            SeveranceTax_Value = new TextBox();
            OtherExpenses_Value = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            PaymentID_Value = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // RecoupEffectiveDate_Value
            // 
            RecoupEffectiveDate_Value.Location = new Point(140, 106);
            RecoupEffectiveDate_Value.Name = "RecoupEffectiveDate_Value";
            RecoupEffectiveDate_Value.Size = new Size(121, 23);
            RecoupEffectiveDate_Value.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Recoup Effective Date";
            // 
            // Category_Value
            // 
            Category_Value.FormattingEnabled = true;
            Category_Value.Location = new Point(140, 164);
            Category_Value.Name = "Category_Value";
            Category_Value.Size = new Size(121, 23);
            Category_Value.TabIndex = 2;
            // 
            // NetAmountDue_Value
            // 
            NetAmountDue_Value.Location = new Point(140, 135);
            NetAmountDue_Value.Name = "NetAmountDue_Value";
            NetAmountDue_Value.Size = new Size(121, 23);
            NetAmountDue_Value.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Net Amount Due";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // RecoupExpirationDate_Value
            // 
            RecoupExpirationDate_Value.Location = new Point(751, 77);
            RecoupExpirationDate_Value.Name = "RecoupExpirationDate_Value";
            RecoupExpirationDate_Value.Size = new Size(121, 23);
            RecoupExpirationDate_Value.TabIndex = 6;
            // 
            // SeveranceTax_Value
            // 
            SeveranceTax_Value.Location = new Point(751, 106);
            SeveranceTax_Value.Name = "SeveranceTax_Value";
            SeveranceTax_Value.Size = new Size(121, 23);
            SeveranceTax_Value.TabIndex = 7;
            // 
            // OtherExpenses_Value
            // 
            OtherExpenses_Value.Location = new Point(751, 135);
            OtherExpenses_Value.Name = "OtherExpenses_Value";
            OtherExpenses_Value.Size = new Size(121, 23);
            OtherExpenses_Value.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 80);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 9;
            label4.Text = "Recoup Expiration Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(665, 109);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "Severance Tax";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(658, 138);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 11;
            label6.Text = "Other Expenses";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PaymentID_Value
            // 
            PaymentID_Value.Location = new Point(140, 77);
            PaymentID_Value.Name = "PaymentID_Value";
            PaymentID_Value.Size = new Size(121, 23);
            PaymentID_Value.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 80);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "Payment ID";
            // 
            // Recoupable_Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(label7);
            Controls.Add(PaymentID_Value);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(OtherExpenses_Value);
            Controls.Add(SeveranceTax_Value);
            Controls.Add(RecoupExpirationDate_Value);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NetAmountDue_Value);
            Controls.Add(Category_Value);
            Controls.Add(label1);
            Controls.Add(RecoupEffectiveDate_Value);
            Name = "Recoupable_Payment";
            Text = "Recoupable_Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RecoupEffectiveDate_Value;
        private Label label1;
        private ComboBox Category_Value;
        private TextBox NetAmountDue_Value;
        private Label label2;
        private Label label3;
        private TextBox RecoupExpirationDate_Value;
        private TextBox SeveranceTax_Value;
        private TextBox OtherExpenses_Value;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BackButton;
        private Button SaveButton;
        private TextBox PaymentID_Value;
        private Label label7;
    }
}