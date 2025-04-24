namespace MayneFaniWindowsForm
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userTypetxt = new TextBox();
            BaseNametxt = new TextBox();
            NetworkStatus = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "دسترسی کاربر :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "وضعیت شبکه :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 158);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "نام مرکز :";
            // 
            // userTypetxt
            // 
            userTypetxt.Enabled = false;
            userTypetxt.Location = new Point(178, 30);
            userTypetxt.Name = "userTypetxt";
            userTypetxt.Size = new Size(223, 23);
            userTypetxt.TabIndex = 4;
            // 
            // BaseNametxt
            // 
            BaseNametxt.Enabled = false;
            BaseNametxt.Location = new Point(178, 155);
            BaseNametxt.Name = "BaseNametxt";
            BaseNametxt.Size = new Size(223, 23);
            BaseNametxt.TabIndex = 5;
            // 
            // NetworkStatus
            // 
            NetworkStatus.Enabled = false;
            NetworkStatus.Location = new Point(178, 89);
            NetworkStatus.Name = "NetworkStatus";
            NetworkStatus.Size = new Size(223, 23);
            NetworkStatus.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(113, 235);
            button1.Name = "button1";
            button1.Size = new Size(188, 42);
            button1.TabIndex = 7;
            button1.Text = "پذیرش";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(113, 303);
            button2.Name = "button2";
            button2.Size = new Size(188, 45);
            button2.TabIndex = 8;
            button2.Text = "بستن شیفت";
            button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 150000;
            timer1.Tick += timer1_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NetworkStatus);
            Controls.Add(BaseNametxt);
            Controls.Add(userTypetxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userTypetxt;
        private TextBox BaseNametxt;
        private TextBox NetworkStatus;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}