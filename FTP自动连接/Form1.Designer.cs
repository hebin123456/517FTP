namespace FTP自动连接
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getIP_button = new System.Windows.Forms.Button();
            this.IP_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getIP_button
            // 
            this.getIP_button.Location = new System.Drawing.Point(13, 90);
            this.getIP_button.Margin = new System.Windows.Forms.Padding(2);
            this.getIP_button.Name = "getIP_button";
            this.getIP_button.Size = new System.Drawing.Size(56, 27);
            this.getIP_button.TabIndex = 0;
            this.getIP_button.Text = "获取IP";
            this.getIP_button.UseVisualStyleBackColor = true;
            this.getIP_button.Click += new System.EventHandler(this.getIP_button_Click);
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(9, 7);
            this.IP_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(23, 12);
            this.IP_label.TabIndex = 1;
            this.IP_label.Text = "IP:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(9, 32);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(47, 12);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "用户名:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(9, 57);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(35, 12);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密码:";
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(69, 5);
            this.IP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(98, 21);
            this.IP_textBox.TabIndex = 4;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(69, 30);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(98, 21);
            this.username_textBox.TabIndex = 5;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(69, 54);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(98, 21);
            this.password_textBox.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(107, 90);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(56, 27);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "登陆";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 124);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.IP_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.IP_label);
            this.Controls.Add(this.getIP_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "517课题组FTP登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getIP_button;
        private System.Windows.Forms.Label IP_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
    }
}

