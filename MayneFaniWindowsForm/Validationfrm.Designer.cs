namespace MayneFaniWindowsForm
{
    partial class Validationfrm
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
            platenumber = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            Datelbl = new Label();
            textBox3 = new TextBox();
            CarInfo = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // platenumber
            // 
            platenumber.AutoSize = true;
            platenumber.Location = new Point(334, 31);
            platenumber.Name = "platenumber";
            platenumber.Size = new Size(62, 15);
            platenumber.TabIndex = 0;
            platenumber.Text = "شماره پلاک";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 15;
            comboBox1.Items.AddRange(new object[] { "الف ", "ب", "پ", "ت", "ث", "ج", "چ", "ح", "خ", "د", "ذ", "ر", "ز", "ژ", "س", "ش", "ص", "ض", "ط", "ظ", "ع", "غ", "ف", "ق", "ک", "ل", "م", "ن", "و", "ه", "ی" });
            comboBox1.Location = new Point(80, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(40, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.Location = new Point(337, 125);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(59, 15);
            Datelbl.TabIndex = 4;
            Datelbl.Text = "تاریخ نوبت";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 5;
            // 
            // CarInfo
            // 
            CarInfo.AutoSize = true;
            CarInfo.Location = new Point(330, 204);
            CarInfo.Name = "CarInfo";
            CarInfo.Size = new Size(64, 15);
            CarInfo.TabIndex = 6;
            CarInfo.Text = "وسیله نقلیه";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 247);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(356, 110);
            textBox4.TabIndex = 7;
            // 
            // Validationfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 392);
            Controls.Add(textBox4);
            Controls.Add(CarInfo);
            Controls.Add(textBox3);
            Controls.Add(Datelbl);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(platenumber);
            Name = "Validationfrm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label platenumber;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label Datelbl;
        private TextBox textBox3;
        private Label CarInfo;
        private TextBox textBox4;
    }
}