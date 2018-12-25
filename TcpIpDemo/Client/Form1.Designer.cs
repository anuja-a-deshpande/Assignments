namespace Client
{
    partial class Form1
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
            this.txtPost = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(185, 6);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(156, 20);
            this.txtPost.TabIndex = 10;
            this.txtPost.Text = "8910";
            // 
            // Post
            // 
            this.Post.AutoSize = true;
            this.Post.Location = new System.Drawing.Point(151, 9);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(28, 13);
            this.Post.TabIndex = 9;
            this.Post.Text = "Post";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(47, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(98, 20);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.01";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(12, 9);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(29, 13);
            this.Host.TabIndex = 7;
            this.Host.Text = "Host";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(347, 5);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(55, 20);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(47, 45);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(352, 61);
            this.textMessage.TabIndex = 12;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(347, 112);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(55, 20);
            this.SendBtn.TabIndex = 11;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 152);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 143);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 311);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.ConnectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}

