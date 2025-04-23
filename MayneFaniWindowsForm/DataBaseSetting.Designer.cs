namespace MayneFaniWindowsForm
{
    partial class DataBaseSetting
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            servernametxt = new TextBox();
            userNametxt = new TextBox();
            instanceNametxt = new TextBox();
            dataBaseNameTxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            passwordTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 45);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "نام سرور";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 147);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "اسم نمونه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 200);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "نام کاربری";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 94);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "نام پایگاه داده";
            // 
            // servernametxt
            // 
            servernametxt.Location = new Point(129, 64);
            servernametxt.Name = "servernametxt";
            servernametxt.Size = new Size(194, 23);
            servernametxt.TabIndex = 5;
            // 
            // userNametxt
            // 
            userNametxt.Location = new Point(129, 209);
            userNametxt.Name = "userNametxt";
            userNametxt.Size = new Size(194, 23);
            userNametxt.TabIndex = 6;
            // 
            // instanceNametxt
            // 
            instanceNametxt.Location = new Point(129, 163);
            instanceNametxt.Name = "instanceNametxt";
            instanceNametxt.Size = new Size(194, 23);
            instanceNametxt.TabIndex = 7;
            // 
            // dataBaseNameTxt
            // 
            dataBaseNameTxt.Location = new Point(129, 122);
            dataBaseNameTxt.Name = "dataBaseNameTxt";
            dataBaseNameTxt.Size = new Size(194, 23);
            dataBaseNameTxt.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(129, 322);
            button1.Name = "button1";
            button1.Size = new Size(97, 40);
            button1.TabIndex = 9;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 322);
            button2.Name = "button2";
            button2.Size = new Size(97, 40);
            button2.TabIndex = 10;
            button2.Text = "حذف پایگاه داده";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 244);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 11;
            label6.Text = "رمز عبور";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(129, 263);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(194, 23);
            passwordTxt.TabIndex = 12;
            // 
            // DataBaseSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(passwordTxt);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataBaseNameTxt);
            Controls.Add(instanceNametxt);
            Controls.Add(userNametxt);
            Controls.Add(servernametxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DataBaseSetting";
            Text = "DataBaseSetting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox servernametxt;
        private TextBox userNametxt;
        private TextBox instanceNametxt;
        private TextBox dataBaseNameTxt;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox passwordTxt;
    }
}