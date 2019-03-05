﻿namespace Crypter
{
    partial class SHA256Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dec_button = new System.Windows.Forms.Button();
            this.enc_button = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dec_plain = new System.Windows.Forms.Label();
            this.enc_cipher = new System.Windows.Forms.Label();
            this.dec_key = new System.Windows.Forms.Label();
            this.enc_text = new System.Windows.Forms.Label();
            this.enc_key = new System.Windows.Forms.Label();
            this.ClrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dec_button
            // 
            this.dec_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.dec_button.FlatAppearance.BorderSize = 2;
            this.dec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_button.ForeColor = System.Drawing.Color.LightGray;
            this.dec_button.Location = new System.Drawing.Point(299, 355);
            this.dec_button.Name = "dec_button";
            this.dec_button.Size = new System.Drawing.Size(132, 38);
            this.dec_button.TabIndex = 25;
            this.dec_button.Text = "Decrypt";
            this.dec_button.UseVisualStyleBackColor = true;
            this.dec_button.Click += new System.EventHandler(this.dec_button_Click);
            this.dec_button.MouseEnter += new System.EventHandler(this.dec_button_MouseEnter);
            this.dec_button.MouseLeave += new System.EventHandler(this.dec_button_MouseLeave);
            // 
            // enc_button
            // 
            this.enc_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.enc_button.FlatAppearance.BorderSize = 2;
            this.enc_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_button.ForeColor = System.Drawing.Color.LightGray;
            this.enc_button.Location = new System.Drawing.Point(299, 118);
            this.enc_button.Name = "enc_button";
            this.enc_button.Size = new System.Drawing.Size(132, 38);
            this.enc_button.TabIndex = 24;
            this.enc_button.Text = "Encrypt";
            this.enc_button.UseVisualStyleBackColor = true;
            this.enc_button.Click += new System.EventHandler(this.enc_button_Click);
            this.enc_button.MouseEnter += new System.EventHandler(this.enc_button_MouseEnter);
            this.enc_button.MouseLeave += new System.EventHandler(this.enc_button_MouseLeave);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(215, 409);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(355, 103);
            this.textBox6.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(215, 313);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(355, 23);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(215, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(355, 23);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(215, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 94);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(215, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 23);
            this.textBox1.TabIndex = 19;
            // 
            // dec_plain
            // 
            this.dec_plain.AutoSize = true;
            this.dec_plain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_plain.ForeColor = System.Drawing.Color.LightGray;
            this.dec_plain.Location = new System.Drawing.Point(84, 409);
            this.dec_plain.Name = "dec_plain";
            this.dec_plain.Size = new System.Drawing.Size(55, 25);
            this.dec_plain.TabIndex = 18;
            this.dec_plain.Text = "Plain";
            // 
            // enc_cipher
            // 
            this.enc_cipher.AutoSize = true;
            this.enc_cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_cipher.ForeColor = System.Drawing.Color.LightGray;
            this.enc_cipher.Location = new System.Drawing.Point(84, 172);
            this.enc_cipher.Name = "enc_cipher";
            this.enc_cipher.Size = new System.Drawing.Size(70, 25);
            this.enc_cipher.TabIndex = 17;
            this.enc_cipher.Text = "Cipher";
            // 
            // dec_key
            // 
            this.dec_key.AutoSize = true;
            this.dec_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_key.ForeColor = System.Drawing.Color.LightGray;
            this.dec_key.Location = new System.Drawing.Point(84, 313);
            this.dec_key.Name = "dec_key";
            this.dec_key.Size = new System.Drawing.Size(47, 25);
            this.dec_key.TabIndex = 16;
            this.dec_key.Text = "Key";
            // 
            // enc_text
            // 
            this.enc_text.AutoSize = true;
            this.enc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_text.ForeColor = System.Drawing.Color.LightGray;
            this.enc_text.Location = new System.Drawing.Point(84, 81);
            this.enc_text.Name = "enc_text";
            this.enc_text.Size = new System.Drawing.Size(51, 25);
            this.enc_text.TabIndex = 15;
            this.enc_text.Text = "Text";
            // 
            // enc_key
            // 
            this.enc_key.AutoSize = true;
            this.enc_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_key.ForeColor = System.Drawing.Color.LightGray;
            this.enc_key.Location = new System.Drawing.Point(84, 26);
            this.enc_key.Name = "enc_key";
            this.enc_key.Size = new System.Drawing.Size(47, 25);
            this.enc_key.TabIndex = 14;
            this.enc_key.Text = "Key";
            // 
            // ClrButton
            // 
            this.ClrButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.ClrButton.FlatAppearance.BorderSize = 2;
            this.ClrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrButton.ForeColor = System.Drawing.Color.LightGray;
            this.ClrButton.Location = new System.Drawing.Point(299, 534);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(132, 38);
            this.ClrButton.TabIndex = 26;
            this.ClrButton.Text = "Reset";
            this.ClrButton.UseVisualStyleBackColor = true;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            this.ClrButton.MouseEnter += new System.EventHandler(this.ClrButton_MouseEnter);
            this.ClrButton.MouseLeave += new System.EventHandler(this.ClrButton_MouseLeave);
            // 
            // SHA256Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ClrButton);
            this.Controls.Add(this.dec_button);
            this.Controls.Add(this.enc_button);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dec_plain);
            this.Controls.Add(this.enc_cipher);
            this.Controls.Add(this.dec_key);
            this.Controls.Add(this.enc_text);
            this.Controls.Add(this.enc_key);
            this.Name = "SHA256Control";
            this.Size = new System.Drawing.Size(744, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dec_button;
        private System.Windows.Forms.Button enc_button;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dec_plain;
        private System.Windows.Forms.Label enc_cipher;
        private System.Windows.Forms.Label dec_key;
        private System.Windows.Forms.Label enc_text;
        private System.Windows.Forms.Label enc_key;
        private System.Windows.Forms.Button ClrButton;
    }
}
