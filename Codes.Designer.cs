namespace US_Land_System_Alpha
{
    partial class Codes
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
            Active_Value = new CheckBox();
            label3 = new Label();
            Description_Value = new TextBox();
            label2 = new Label();
            CodeID_Value = new TextBox();
            label1 = new Label();
            CodeType_Value = new ComboBox();
            tabPage2 = new TabPage();
            GLChart_Value = new TextBox();
            label4 = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 323);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Active_Value);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Description_Value);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(CodeID_Value);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(CodeType_Value);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 295);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Active_Value
            // 
            Active_Value.AutoSize = true;
            Active_Value.Location = new Point(6, 165);
            Active_Value.Name = "Active_Value";
            Active_Value.Size = new Size(64, 19);
            Active_Value.TabIndex = 6;
            Active_Value.Text = "Active?";
            Active_Value.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // Description_Value
            // 
            Description_Value.Location = new Point(79, 64);
            Description_Value.Name = "Description_Value";
            Description_Value.Size = new Size(388, 23);
            Description_Value.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Code ID";
            // 
            // CodeID_Value
            // 
            CodeID_Value.Location = new Point(79, 35);
            CodeID_Value.Name = "CodeID_Value";
            CodeID_Value.Size = new Size(388, 23);
            CodeID_Value.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Code Type";
            // 
            // CodeType_Value
            // 
            CodeType_Value.FormattingEnabled = true;
            CodeType_Value.Location = new Point(79, 6);
            CodeType_Value.Name = "CodeType_Value";
            CodeType_Value.Size = new Size(388, 23);
            CodeType_Value.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 295);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Notes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GLChart_Value
            // 
            GLChart_Value.Location = new Point(95, 426);
            GLChart_Value.Name = "GLChart_Value";
            GLChart_Value.Size = new Size(388, 23);
            GLChart_Value.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 429);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "GL Chart";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Codes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(label4);
            Controls.Add(GLChart_Value);
            Controls.Add(tabControl1);
            Name = "Codes";
            Text = "Codes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox Active_Value;
        private Label label3;
        private TextBox Description_Value;
        private Label label2;
        private TextBox CodeID_Value;
        private Label label1;
        private ComboBox CodeType_Value;
        private TabPage tabPage2;
        private TextBox GLChart_Value;
        private Label label4;
        private Button BackButton;
        private Button SaveButton;
    }
}