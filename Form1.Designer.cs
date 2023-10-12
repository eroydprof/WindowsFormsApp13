namespace WindowsFormsApp13
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChBShowPassword = new System.Windows.Forms.CheckBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDaftar = new System.Windows.Forms.Label();
            this.TxtUsernameError = new System.Windows.Forms.TextBox();
            this.TxtPasswordError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(172, 340);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(224, 31);
            this.TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(172, 435);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(224, 31);
            this.TxtPassword.TabIndex = 4;
            // 
            // ChBShowPassword
            // 
            this.ChBShowPassword.AutoSize = true;
            this.ChBShowPassword.Location = new System.Drawing.Point(172, 486);
            this.ChBShowPassword.Name = "ChBShowPassword";
            this.ChBShowPassword.Size = new System.Drawing.Size(197, 29);
            this.ChBShowPassword.TabIndex = 5;
            this.ChBShowPassword.Text = "Show Password";
            this.ChBShowPassword.UseVisualStyleBackColor = true;
            this.ChBShowPassword.CheckedChanged += new System.EventHandler(this.ChBShowPassword_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(199, 548);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(129, 47);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sudah Punya Akun?";
            // 
            // LblDaftar
            // 
            this.LblDaftar.AutoSize = true;
            this.LblDaftar.ForeColor = System.Drawing.Color.Blue;
            this.LblDaftar.Location = new System.Drawing.Point(218, 672);
            this.LblDaftar.Name = "LblDaftar";
            this.LblDaftar.Size = new System.Drawing.Size(70, 25);
            this.LblDaftar.TabIndex = 8;
            this.LblDaftar.Text = "Daftar";
            this.LblDaftar.Click += new System.EventHandler(this.LblDaftar_Click);
            // 
            // TxtUsernameError
            // 
            this.TxtUsernameError.BackColor = System.Drawing.Color.Red;
            this.TxtUsernameError.Location = new System.Drawing.Point(172, 340);
            this.TxtUsernameError.Name = "TxtUsernameError";
            this.TxtUsernameError.Size = new System.Drawing.Size(224, 31);
            this.TxtUsernameError.TabIndex = 9;
            this.TxtUsernameError.Visible = false;
            // 
            // TxtPasswordError
            // 
            this.TxtPasswordError.BackColor = System.Drawing.Color.Red;
            this.TxtPasswordError.Location = new System.Drawing.Point(172, 435);
            this.TxtPasswordError.Name = "TxtPasswordError";
            this.TxtPasswordError.Size = new System.Drawing.Size(224, 31);
            this.TxtPasswordError.TabIndex = 10;
            this.TxtPasswordError.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 727);
            this.Controls.Add(this.TxtPasswordError);
            this.Controls.Add(this.TxtUsernameError);
            this.Controls.Add(this.LblDaftar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.ChBShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChBShowPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDaftar;
        private System.Windows.Forms.TextBox TxtUsernameError;
        private System.Windows.Forms.TextBox TxtPasswordError;
    }
}

