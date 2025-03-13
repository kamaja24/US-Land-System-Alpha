namespace US_Land_System_Alpha
{
    partial class Remarks
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
            RemarkID_Value = new TextBox();
            label1 = new Label();
            Description_Value = new TextBox();
            label2 = new Label();
            Type_Value = new TextBox();
            label3 = new Label();
            Active_Value = new CheckBox();
            Remark_Value = new TextBox();
            Remark = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // RemarkID_Value
            // 
            RemarkID_Value.Location = new Point(85, 77);
            RemarkID_Value.Name = "RemarkID_Value";
            RemarkID_Value.Size = new Size(256, 23);
            RemarkID_Value.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Remark ID";
            // 
            // Description_Value
            // 
            Description_Value.Location = new Point(85, 106);
            Description_Value.Name = "Description_Value";
            Description_Value.Size = new Size(256, 23);
            Description_Value.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // Type_Value
            // 
            Type_Value.Location = new Point(85, 135);
            Type_Value.Name = "Type_Value";
            Type_Value.Size = new Size(256, 23);
            Type_Value.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // Active_Value
            // 
            Active_Value.AutoSize = true;
            Active_Value.Location = new Point(633, 108);
            Active_Value.Name = "Active_Value";
            Active_Value.Size = new Size(64, 19);
            Active_Value.TabIndex = 6;
            Active_Value.Text = "Active?";
            Active_Value.UseVisualStyleBackColor = true;
            // 
            // Remark_Value
            // 
            Remark_Value.Location = new Point(85, 164);
            Remark_Value.Multiline = true;
            Remark_Value.Name = "Remark_Value";
            Remark_Value.Size = new Size(538, 185);
            Remark_Value.TabIndex = 7;
            // 
            // Remark
            // 
            Remark.AutoSize = true;
            Remark.Location = new Point(12, 167);
            Remark.Name = "Remark";
            Remark.Size = new Size(47, 15);
            Remark.TabIndex = 8;
            Remark.Text = "Remark";
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
            // Remarks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(Remark);
            Controls.Add(Remark_Value);
            Controls.Add(Active_Value);
            Controls.Add(label3);
            Controls.Add(Type_Value);
            Controls.Add(label2);
            Controls.Add(Description_Value);
            Controls.Add(label1);
            Controls.Add(RemarkID_Value);
            Name = "Remarks";
            Text = "Remarks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RemarkID_Value;
        private Label label1;
        private TextBox Description_Value;
        private Label label2;
        private TextBox Type_Value;
        private Label label3;
        private CheckBox Active_Value;
        private TextBox Remark_Value;
        private Label Remark;
        private Button BackButton;
        private Button SaveButton;
    }
}