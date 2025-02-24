namespace US_Land_System_Alpha
{
    partial class PPI
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
            Home = new TabPage();
            PPIMultiplier_Label = new Label();
            PPIMultiplier_Value = new TextBox();
            ExpirationDate_Label = new Label();
            ExpirationDate_Value = new TextBox();
            EffectiveDate_Label = new Label();
            EffectiveDate_Value = new TextBox();
            PPI_Value = new TextBox();
            PPIID_Label = new Label();
            Notes = new TabPage();
            SaveButton = new Button();
            BackButton = new Button();
            tabControl1.SuspendLayout();
            Home.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Home);
            tabControl1.Controls.Add(Notes);
            tabControl1.Location = new Point(12, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 372);
            tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            Home.Controls.Add(PPIMultiplier_Label);
            Home.Controls.Add(PPIMultiplier_Value);
            Home.Controls.Add(ExpirationDate_Label);
            Home.Controls.Add(ExpirationDate_Value);
            Home.Controls.Add(EffectiveDate_Label);
            Home.Controls.Add(EffectiveDate_Value);
            Home.Controls.Add(PPI_Value);
            Home.Controls.Add(PPIID_Label);
            Home.Location = new Point(4, 24);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.Size = new Size(852, 344);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // PPIMultiplier_Label
            // 
            PPIMultiplier_Label.AutoSize = true;
            PPIMultiplier_Label.Location = new Point(6, 96);
            PPIMultiplier_Label.Name = "PPIMultiplier_Label";
            PPIMultiplier_Label.Size = new Size(78, 15);
            PPIMultiplier_Label.TabIndex = 7;
            PPIMultiplier_Label.Text = "PPI Multiplier";
            // 
            // PPIMultiplier_Value
            // 
            PPIMultiplier_Value.Location = new Point(99, 93);
            PPIMultiplier_Value.Name = "PPIMultiplier_Value";
            PPIMultiplier_Value.Size = new Size(318, 23);
            PPIMultiplier_Value.TabIndex = 6;
            // 
            // ExpirationDate_Label
            // 
            ExpirationDate_Label.AutoSize = true;
            ExpirationDate_Label.Location = new Point(6, 67);
            ExpirationDate_Label.Name = "ExpirationDate_Label";
            ExpirationDate_Label.Size = new Size(87, 15);
            ExpirationDate_Label.TabIndex = 5;
            ExpirationDate_Label.Text = "Expiration Date";
            // 
            // ExpirationDate_Value
            // 
            ExpirationDate_Value.Location = new Point(99, 64);
            ExpirationDate_Value.Name = "ExpirationDate_Value";
            ExpirationDate_Value.Size = new Size(318, 23);
            ExpirationDate_Value.TabIndex = 4;
            // 
            // EffectiveDate_Label
            // 
            EffectiveDate_Label.AutoSize = true;
            EffectiveDate_Label.Location = new Point(6, 38);
            EffectiveDate_Label.Name = "EffectiveDate_Label";
            EffectiveDate_Label.Size = new Size(79, 15);
            EffectiveDate_Label.TabIndex = 3;
            EffectiveDate_Label.Text = "Effective Date";
            // 
            // EffectiveDate_Value
            // 
            EffectiveDate_Value.Location = new Point(99, 35);
            EffectiveDate_Value.Name = "EffectiveDate_Value";
            EffectiveDate_Value.Size = new Size(318, 23);
            EffectiveDate_Value.TabIndex = 2;
            // 
            // PPI_Value
            // 
            PPI_Value.Location = new Point(99, 6);
            PPI_Value.Name = "PPI_Value";
            PPI_Value.Size = new Size(318, 23);
            PPI_Value.TabIndex = 1;
            // 
            // PPIID_Label
            // 
            PPIID_Label.AutoSize = true;
            PPIID_Label.Location = new Point(6, 9);
            PPIID_Label.Name = "PPIID_Label";
            PPIID_Label.Size = new Size(38, 15);
            PPIID_Label.TabIndex = 0;
            PPIID_Label.Text = "PPI ID";
            // 
            // Notes
            // 
            Notes.Location = new Point(4, 24);
            Notes.Name = "Notes";
            Notes.Padding = new Padding(3);
            Notes.Size = new Size(852, 344);
            Notes.TabIndex = 1;
            Notes.Text = "Notes";
            Notes.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(793, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // PPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(tabControl1);
            Name = "PPI";
            Text = "PPI";
            tabControl1.ResumeLayout(false);
            Home.ResumeLayout(false);
            Home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Home;
        private TabPage Notes;
        private Label ExpirationDate_Label;
        private TextBox ExpirationDate_Value;
        private Label EffectiveDate_Label;
        private TextBox EffectiveDate_Value;
        private TextBox PPI_Value;
        private Label PPIID_Label;
        private TextBox PPIMultiplier_Value;
        private Label PPIMultiplier_Label;
        private Button SaveButton;
        private Button BackButton;
    }
}