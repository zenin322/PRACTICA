namespace practica
{
    partial class Registration
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
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passRegistr = new System.Windows.Forms.TextBox();
            this.loginRegistr = new System.Windows.Forms.TextBox();
            this.Копка_пароля = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Копка_пароля.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRegistr.FlatAppearance.BorderSize = 0;
            this.buttonRegistr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRegistr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistr.Location = new System.Drawing.Point(245, 339);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(239, 40);
            this.buttonRegistr.TabIndex = 5;
            this.buttonRegistr.Text = "Зарегистрироваться";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::practica.Properties.Resources.zamok;
            this.pictureBox2.Location = new System.Drawing.Point(34, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practica.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(35, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // passRegistr
            // 
            this.passRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegistr.Location = new System.Drawing.Point(171, 260);
            this.passRegistr.Name = "passRegistr";
            this.passRegistr.PasswordChar = '*';
            this.passRegistr.Size = new System.Drawing.Size(402, 38);
            this.passRegistr.TabIndex = 2;
            this.passRegistr.UseSystemPasswordChar = true;
            this.passRegistr.TextChanged += new System.EventHandler(this.passRegistr_TextChanged);
            // 
            // loginRegistr
            // 
            this.loginRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistr.Location = new System.Drawing.Point(171, 157);
            this.loginRegistr.Name = "loginRegistr";
            this.loginRegistr.Size = new System.Drawing.Size(402, 38);
            this.loginRegistr.TabIndex = 1;
            this.loginRegistr.TextChanged += new System.EventHandler(this.loginRegistr_TextChanged);
            this.loginRegistr.Enter += new System.EventHandler(this.loginRegistr_Enter);
            this.loginRegistr.Leave += new System.EventHandler(this.loginRegistr_Leave);
            // 
            // Копка_пароля
            // 
            this.Копка_пароля.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Копка_пароля.Controls.Add(this.buttonRegistr);
            this.Копка_пароля.Controls.Add(this.pictureBox2);
            this.Копка_пароля.Controls.Add(this.pictureBox1);
            this.Копка_пароля.Controls.Add(this.passRegistr);
            this.Копка_пароля.Controls.Add(this.loginRegistr);
            this.Копка_пароля.Controls.Add(this.panel2);
            this.Копка_пароля.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Копка_пароля.Location = new System.Drawing.Point(0, 0);
            this.Копка_пароля.Name = "Копка_пароля";
            this.Копка_пароля.Size = new System.Drawing.Size(684, 403);
            this.Копка_пароля.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 95);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 403);
            this.Controls.Add(this.Копка_пароля);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Копка_пароля.ResumeLayout(false);
            this.Копка_пароля.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passRegistr;
        private System.Windows.Forms.TextBox loginRegistr;
        private System.Windows.Forms.Panel Копка_пароля;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}