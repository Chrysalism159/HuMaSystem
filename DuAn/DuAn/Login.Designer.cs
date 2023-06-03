
namespace DuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnClr = new Guna.UI.WinForms.GunaButton();
            this.btnLog = new Guna.UI.WinForms.GunaButton();
            this.password = new Guna.UI.WinForms.GunaTextBox();
            this.user = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "HuReManagement";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(263, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 28);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Username";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(263, 135);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Password";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnClr);
            this.gunaPanel1.Controls.Add(this.btnLog);
            this.gunaPanel1.Controls.Add(this.password);
            this.gunaPanel1.Controls.Add(this.user);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 62);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(666, 246);
            this.gunaPanel1.TabIndex = 5;
            // 
            // btnClr
            // 
            this.btnClr.AnimationHoverSpeed = 0.07F;
            this.btnClr.AnimationSpeed = 0.03F;
            this.btnClr.BackColor = System.Drawing.Color.Transparent;
            this.btnClr.BaseColor = System.Drawing.Color.White;
            this.btnClr.BorderColor = System.Drawing.Color.Black;
            this.btnClr.BorderSize = 3;
            this.btnClr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClr.FocusedColor = System.Drawing.Color.Empty;
            this.btnClr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClr.ForeColor = System.Drawing.Color.Black;
            this.btnClr.Image = ((System.Drawing.Image)(resources.GetObject("btnClr.Image")));
            this.btnClr.ImageSize = new System.Drawing.Size(0, 0);
            this.btnClr.Location = new System.Drawing.Point(530, 188);
            this.btnClr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClr.Name = "btnClr";
            this.btnClr.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnClr.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClr.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClr.OnHoverImage = null;
            this.btnClr.OnPressedColor = System.Drawing.Color.Black;
            this.btnClr.Radius = 5;
            this.btnClr.Size = new System.Drawing.Size(83, 41);
            this.btnClr.TabIndex = 26;
            this.btnClr.Text = "SHOW";
            this.btnClr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnLog
            // 
            this.btnLog.AnimationHoverSpeed = 0.07F;
            this.btnLog.AnimationSpeed = 0.03F;
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.BaseColor = System.Drawing.Color.White;
            this.btnLog.BorderColor = System.Drawing.Color.Black;
            this.btnLog.BorderSize = 3;
            this.btnLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLog.FocusedColor = System.Drawing.Color.Empty;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageSize = new System.Drawing.Size(0, 0);
            this.btnLog.Location = new System.Drawing.Point(393, 188);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnLog.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLog.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLog.OnHoverImage = null;
            this.btnLog.OnPressedColor = System.Drawing.Color.Black;
            this.btnLog.Radius = 5;
            this.btnLog.Size = new System.Drawing.Size(83, 41);
            this.btnLog.TabIndex = 25;
            this.btnLog.Text = "LOGIN";
            this.btnLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // password
            // 
            this.password.BaseColor = System.Drawing.Color.White;
            this.password.BorderColor = System.Drawing.Color.Black;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedBaseColor = System.Drawing.Color.White;
            this.password.FocusedBorderColor = System.Drawing.Color.Gray;
            this.password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.Location = new System.Drawing.Point(408, 135);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(188, 32);
            this.password.TabIndex = 7;
            // 
            // user
            // 
            this.user.BaseColor = System.Drawing.Color.White;
            this.user.BorderColor = System.Drawing.Color.Black;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.FocusedBaseColor = System.Drawing.Color.White;
            this.user.FocusedBorderColor = System.Drawing.Color.Gray;
            this.user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user.Location = new System.Drawing.Point(408, 57);
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.SelectedText = "";
            this.user.Size = new System.Drawing.Size(188, 32);
            this.user.TabIndex = 6;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DuAn.Properties.Resources.k;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, -16);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(298, 288);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::DuAn.Properties.Resources.Exit;
            this.gunaPictureBox2.Location = new System.Drawing.Point(605, 9);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(49, 47);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 27;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 346);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox password;
        private Guna.UI.WinForms.GunaTextBox user;
        private Guna.UI.WinForms.GunaButton btnClr;
        private Guna.UI.WinForms.GunaButton btnLog;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
    }
}