namespace MayneFaniWindowsForm
{
    partial class LoginFrm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 80);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "شناسه کاربر";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 203);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "رمز عبور";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(124, 309);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(154, 35);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "ورود";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 415);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginFrm";
            Text = "LoginFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button LoginBtn;
    }
}