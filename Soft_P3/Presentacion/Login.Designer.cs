namespace Soft_P3.Presentacion
{
    partial class Login
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(59, 247);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 29);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(59, 279);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(209, 29);
            this.txtPass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 162);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Image = global::Soft_P3.Properties.Resources.login;
            this.btnLogin.Location = new System.Drawing.Point(1, 410);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(328, 93);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(330, 504);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
    }
}