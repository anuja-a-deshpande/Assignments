namespace TcpIpDemo
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
            this.StratBtn = new System.Windows.Forms.Button();
            this.Host = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StratBtn
            // 
            this.StratBtn.Location = new System.Drawing.Point(347, 5);
            this.StratBtn.Name = "StratBtn";
            this.StratBtn.Size = new System.Drawing.Size(55, 20);
            this.StratBtn.TabIndex = 1;
            this.StratBtn.Text = "Start";
            this.StratBtn.UseVisualStyleBackColor = true;
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(12, 9);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(29, 13);
            this.Host.TabIndex = 2;
            this.Host.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(47, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(98, 20);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "127.0.01";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(185, 6);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(156, 20);
            this.txtPost.TabIndex = 5;
            this.txtPost.Text = "8910";
            // 
            // Post
            // 
            this.Post.AutoSize = true;
            this.Post.Location = new System.Drawing.Point(151, 9);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(28, 13);
            this.Post.TabIndex = 4;
            this.Post.Text = "Post";
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(408, 5);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 20);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(15, 32);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(467, 115);
            this.txtStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 159);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.StratBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StratBtn;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

