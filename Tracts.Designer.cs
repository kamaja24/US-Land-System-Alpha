namespace US_Land_System_Alpha
{
    partial class Tracts
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
            groupBox4 = new GroupBox();
            label7 = new Label();
            CountyID_Value = new TextBox();
            label6 = new Label();
            StateID_Value = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            TotalAcreage_Value = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            FullDescription_Value = new TextBox();
            label3 = new Label();
            Tract_Name = new TextBox();
            Active_Value = new CheckBox();
            label2 = new Label();
            TractStatus_Value = new TextBox();
            label1 = new Label();
            TractID_Value = new TextBox();
            tabPage2 = new TabPage();
            label11 = new Label();
            Field4_Value = new TextBox();
            label10 = new Label();
            Field3_Value = new TextBox();
            label9 = new Label();
            Field2_Value = new TextBox();
            label8 = new Label();
            Field1_Value = new TextBox();
            BackButton = new Button();
            SaveButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 372);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(CountyID_Value);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(StateID_Value);
            groupBox4.Location = new Point(6, 237);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(840, 95);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Location Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 69);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "County ID";
            // 
            // CountyID_Value
            // 
            CountyID_Value.Location = new Point(101, 66);
            CountyID_Value.Name = "CountyID_Value";
            CountyID_Value.Size = new Size(205, 23);
            CountyID_Value.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "State ID";
            // 
            // StateID_Value
            // 
            StateID_Value.Location = new Point(101, 22);
            StateID_Value.Name = "StateID_Value";
            StateID_Value.Size = new Size(205, 23);
            StateID_Value.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TotalAcreage_Value);
            groupBox2.Location = new Point(6, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(840, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acreage Information";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(840, 101);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 9;
            label5.Text = "Total Acreage";
            // 
            // TotalAcreage_Value
            // 
            TotalAcreage_Value.Location = new Point(101, 22);
            TotalAcreage_Value.Name = "TotalAcreage_Value";
            TotalAcreage_Value.Size = new Size(205, 23);
            TotalAcreage_Value.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(FullDescription_Value);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Tract_Name);
            groupBox1.Controls.Add(Active_Value);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TractStatus_Value);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TractID_Value);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identification";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Full Description";
            // 
            // FullDescription_Value
            // 
            FullDescription_Value.Location = new Point(101, 80);
            FullDescription_Value.Multiline = true;
            FullDescription_Value.Name = "FullDescription_Value";
            FullDescription_Value.Size = new Size(733, 69);
            FullDescription_Value.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Tract Name";
            // 
            // Tract_Name
            // 
            Tract_Name.Location = new Point(101, 51);
            Tract_Name.Name = "Tract_Name";
            Tract_Name.Size = new Size(570, 23);
            Tract_Name.TabIndex = 5;
            // 
            // Active_Value
            // 
            Active_Value.AutoSize = true;
            Active_Value.Location = new Point(770, 24);
            Active_Value.Name = "Active_Value";
            Active_Value.Size = new Size(64, 19);
            Active_Value.TabIndex = 4;
            Active_Value.Text = "Active?";
            Active_Value.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 25);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Tract Status";
            // 
            // TractStatus_Value
            // 
            TractStatus_Value.Location = new Point(466, 22);
            TractStatus_Value.Name = "TractStatus_Value";
            TractStatus_Value.Size = new Size(205, 23);
            TractStatus_Value.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Tract ID";
            // 
            // TractID_Value
            // 
            TractID_Value.Location = new Point(101, 22);
            TractID_Value.Name = "TractID_Value";
            TractID_Value.Size = new Size(205, 23);
            TractID_Value.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(Field4_Value);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(Field3_Value);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(Field2_Value);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(Field1_Value);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Defined Text Search Fields";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 318);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 7;
            label11.Text = "Field 4";
            // 
            // Field4_Value
            // 
            Field4_Value.Location = new Point(53, 315);
            Field4_Value.Name = "Field4_Value";
            Field4_Value.Size = new Size(793, 23);
            Field4_Value.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 210);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 5;
            label10.Text = "Field 3";
            // 
            // Field3_Value
            // 
            Field3_Value.Location = new Point(53, 207);
            Field3_Value.Name = "Field3_Value";
            Field3_Value.Size = new Size(793, 23);
            Field3_Value.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 111);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 3;
            label9.Text = "Field 2";
            // 
            // Field2_Value
            // 
            Field2_Value.Location = new Point(53, 108);
            Field2_Value.Name = "Field2_Value";
            Field2_Value.Size = new Size(793, 23);
            Field2_Value.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 1;
            label8.Text = "Field 1";
            // 
            // Field1_Value
            // 
            Field1_Value.Location = new Point(53, 6);
            Field1_Value.Name = "Field1_Value";
            Field1_Value.Size = new Size(793, 23);
            Field1_Value.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 11;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Tracts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(tabControl1);
            Name = "Tracts";
            Text = "Tracts";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox TotalAcreage_Value;
        private Label label4;
        private TextBox FullDescription_Value;
        private Label label3;
        private TextBox Tract_Name;
        private CheckBox Active_Value;
        private Label label2;
        private TextBox TractStatus_Value;
        private Label label1;
        private TextBox TractID_Value;
        private GroupBox groupBox4;
        private Label label7;
        private TextBox CountyID_Value;
        private Label label6;
        private TextBox StateID_Value;
        private Label label11;
        private TextBox Field4_Value;
        private Label label10;
        private TextBox Field3_Value;
        private Label label9;
        private TextBox Field2_Value;
        private Label label8;
        private TextBox Field1_Value;
        private Button BackButton;
        private Button SaveButton;
    }
}