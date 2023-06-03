
namespace DuAn
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Days = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Pos = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.id = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDel = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.gunaPictureBox5 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.SalarySlip);
            this.gunaPanel1.Controls.Add(this.btnDel);
            this.gunaPanel1.Controls.Add(this.btnHome);
            this.gunaPanel1.Controls.Add(this.Days);
            this.gunaPanel1.Controls.Add(this.btnEdit);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.btnAdd);
            this.gunaPanel1.Controls.Add(this.Pos);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.name);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.id);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(-12, 60);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1104, 431);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // Days
            // 
            this.Days.BaseColor = System.Drawing.Color.White;
            this.Days.BorderColor = System.Drawing.Color.Black;
            this.Days.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Days.FocusedBaseColor = System.Drawing.Color.White;
            this.Days.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Days.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Days.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(29, 290);
            this.Days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Days.Name = "Days";
            this.Days.PasswordChar = '\0';
            this.Days.SelectedText = "";
            this.Days.Size = new System.Drawing.Size(219, 37);
            this.Days.TabIndex = 22;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(29, 263);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 23);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Worked Days";
            // 
            // Pos
            // 
            this.Pos.BaseColor = System.Drawing.Color.White;
            this.Pos.BorderColor = System.Drawing.Color.Black;
            this.Pos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pos.FocusedBaseColor = System.Drawing.Color.White;
            this.Pos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Pos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Pos.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos.Location = new System.Drawing.Point(29, 212);
            this.Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pos.Name = "Pos";
            this.Pos.PasswordChar = '\0';
            this.Pos.ReadOnly = true;
            this.Pos.SelectedText = "";
            this.Pos.Size = new System.Drawing.Size(219, 37);
            this.Pos.TabIndex = 20;
            this.Pos.Visible = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(29, 184);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 23);
            this.gunaLabel3.TabIndex = 19;
            this.gunaLabel3.Text = "EmPosition";
            // 
            // name
            // 
            this.name.BaseColor = System.Drawing.Color.White;
            this.name.BorderColor = System.Drawing.Color.Black;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FocusedBaseColor = System.Drawing.Color.White;
            this.name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(29, 139);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ReadOnly = true;
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(219, 37);
            this.name.TabIndex = 18;
            this.name.Visible = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(29, 113);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 23);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "EmName";
            // 
            // id
            // 
            this.id.BaseColor = System.Drawing.Color.White;
            this.id.BorderColor = System.Drawing.Color.Black;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.FocusedBaseColor = System.Drawing.Color.White;
            this.id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(29, 72);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.SelectedText = "";
            this.id.Size = new System.Drawing.Size(219, 37);
            this.id.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(29, 47);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 23);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "EmID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Salaries";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::DuAn.Properties.Resources.Exit;
            this.gunaPictureBox2.Location = new System.Drawing.Point(1030, 8);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(49, 47);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 24;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // btnDel
            // 
            this.btnDel.AnimationHoverSpeed = 0.07F;
            this.btnDel.AnimationSpeed = 0.03F;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BaseColor = System.Drawing.Color.White;
            this.btnDel.BorderColor = System.Drawing.Color.Black;
            this.btnDel.BorderSize = 3;
            this.btnDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDel.FocusedColor = System.Drawing.Color.Empty;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageSize = new System.Drawing.Size(0, 0);
            this.btnDel.Location = new System.Drawing.Point(321, 64);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDel.OnHoverImage = null;
            this.btnDel.OnPressedColor = System.Drawing.Color.Black;
            this.btnDel.Radius = 5;
            this.btnDel.Size = new System.Drawing.Size(83, 41);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "SEARCH";
            this.btnDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BaseColor = System.Drawing.Color.White;
            this.btnHome.BorderColor = System.Drawing.Color.Black;
            this.btnHome.BorderSize = 3;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(0, 0);
            this.btnHome.Location = new System.Drawing.Point(321, 208);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnPressedColor = System.Drawing.Color.Black;
            this.btnHome.Radius = 5;
            this.btnHome.Size = new System.Drawing.Size(83, 41);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderSize = 3;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageSize = new System.Drawing.Size(0, 0);
            this.btnEdit.Location = new System.Drawing.Point(321, 286);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(83, 41);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "PRINT";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderSize = 3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAdd.Location = new System.Drawing.Point(321, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(83, 41);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "VIEWS";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalarySlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarySlip.Location = new System.Drawing.Point(465, 28);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(574, 334);
            this.SalarySlip.TabIndex = 31;
            this.SalarySlip.Text = "";
            // 
            // gunaPictureBox5
            // 
            this.gunaPictureBox5.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox5.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox5.Image = global::DuAn.Properties.Resources.salary;
            this.gunaPictureBox5.Location = new System.Drawing.Point(12, 8);
            this.gunaPictureBox5.Name = "gunaPictureBox5";
            this.gunaPictureBox5.Size = new System.Drawing.Size(45, 45);
            this.gunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox5.TabIndex = 32;
            this.gunaPictureBox5.TabStop = false;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1087, 541);
            this.Controls.Add(this.gunaPictureBox5);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.Text = "Salary";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox Days;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox Pos;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox id;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton btnDel;
        private Guna.UI.WinForms.GunaButton btnHome;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox SalarySlip;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox5;
    }
}