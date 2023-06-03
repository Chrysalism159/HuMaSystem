
namespace DuAn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Myprogress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ByChrysalism";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Myprogress
            // 
            this.Myprogress.AnimationSpeed = 0.6F;
            this.Myprogress.BaseColor = System.Drawing.Color.White;
            this.Myprogress.Controls.Add(this.gunaPictureBox1);
            this.Myprogress.IdleColor = System.Drawing.Color.Gainsboro;
            this.Myprogress.IdleOffset = 20;
            this.Myprogress.IdleThickness = 10;
            this.Myprogress.Image = null;
            this.Myprogress.ImageSize = new System.Drawing.Size(52, 52);
            this.Myprogress.Location = new System.Drawing.Point(219, 68);
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressMaxColor = System.Drawing.Color.Black;
            this.Myprogress.ProgressMinColor = System.Drawing.Color.Black;
            this.Myprogress.ProgressOffset = 20;
            this.Myprogress.ProgressThickness = 10;
            this.Myprogress.Size = new System.Drawing.Size(200, 200);
            this.Myprogress.TabIndex = 3;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DuAn.Properties.Resources.Untitled_design2;
            this.gunaPictureBox1.InitialImage = global::DuAn.Properties.Resources.Untitled_design1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(50, 48);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 307);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCircleProgressBar Myprogress;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

