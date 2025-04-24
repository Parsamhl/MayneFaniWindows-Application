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
            userNametxt = new TextBox();
            passwordtxt = new TextBox();
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
            // userNametxt
            // 
            userNametxt.Location = new Point(98, 132);
            userNametxt.Name = "userNametxt";
            userNametxt.Size = new Size(208, 23);
            userNametxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(98, 242);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(208, 23);
            passwordtxt.TabIndex = 2;
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
            Controls.Add(passwordtxt);
            Controls.Add(userNametxt);
            Controls.Add(label1);
            Name = "LoginFrm";
            Text = "LoginFrm";
            Load += LoginFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNametxt;
        private TextBox passwordtxt;
        private Label label2;
        private Button LoginBtn;
    }
}