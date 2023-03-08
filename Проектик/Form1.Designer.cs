namespace Проектик
{
    partial class regform
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vxod = new System.Windows.Forms.Button();
            this.PassssField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vihod = new System.Windows.Forms.Button();
            this.avtoriz = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 65);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.vxod);
            this.panel1.Controls.Add(this.PassssField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.RegField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 363);
            this.panel1.TabIndex = 1;
            // 
            // vxod
            // 
            this.vxod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vxod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vxod.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vxod.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.vxod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vxod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vxod.Location = new System.Drawing.Point(247, 272);
            this.vxod.Name = "vxod";
            this.vxod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vxod.Size = new System.Drawing.Size(272, 64);
            this.vxod.TabIndex = 6;
            this.vxod.Text = "Зарегестрировать";
            this.vxod.UseVisualStyleBackColor = false;
            this.vxod.Click += new System.EventHandler(this.vxod_Click);
            // 
            // PassssField
            // 
            this.PassssField.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassssField.Location = new System.Drawing.Point(492, 151);
            this.PassssField.MaxLength = 8;
            this.PassssField.Name = "PassssField";
            this.PassssField.Size = new System.Drawing.Size(246, 57);
            this.PassssField.TabIndex = 5;
            this.PassssField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Проектик.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(406, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // RegField
            // 
            this.RegField.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegField.Location = new System.Drawing.Point(98, 151);
            this.RegField.MaxLength = 10;
            this.RegField.Multiline = true;
            this.RegField.Name = "RegField";
            this.RegField.Size = new System.Drawing.Size(246, 64);
            this.RegField.TabIndex = 3;
            this.RegField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Проектик.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.vihod);
            this.panel2.Controls.Add(this.avtoriz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 123);
            this.panel2.TabIndex = 0;
            // 
            // vihod
            // 
            this.vihod.Location = new System.Drawing.Point(751, 12);
            this.vihod.Name = "vihod";
            this.vihod.Size = new System.Drawing.Size(31, 29);
            this.vihod.TabIndex = 2;
            this.vihod.Text = "X";
            this.vihod.UseVisualStyleBackColor = true;
            this.vihod.Click += new System.EventHandler(this.vihod_Click);
            // 
            // avtoriz
            // 
            this.avtoriz.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtoriz.ForeColor = System.Drawing.Color.White;
            this.avtoriz.Location = new System.Drawing.Point(222, 21);
            this.avtoriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avtoriz.Name = "avtoriz";
            this.avtoriz.Size = new System.Drawing.Size(376, 83);
            this.avtoriz.TabIndex = 0;
            this.avtoriz.Text = "Регестрация";
            this.avtoriz.Click += new System.EventHandler(this.avtoriz_Click);
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vxod;
        private System.Windows.Forms.TextBox PassssField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox RegField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button vihod;
        private System.Windows.Forms.Label avtoriz;
    }
}