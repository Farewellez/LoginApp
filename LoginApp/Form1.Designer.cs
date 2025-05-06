namespace LoginApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_autentikasi = new Label();
            label_nama = new Label();
            namaPetualang_value = new TextBox();
            codeRahasia_value = new TextBox();
            label_codeRahasia = new Label();
            masuk_button = new Button();
            keluar_button = new Button();
            daftar_button = new Button();
            LihatPassword = new CheckBox();
            SuspendLayout();
            // 
            // label_autentikasi
            // 
            label_autentikasi.AutoSize = true;
            label_autentikasi.Font = new Font("Old English Text MT", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_autentikasi.ForeColor = Color.White;
            label_autentikasi.Location = new Point(176, 25);
            label_autentikasi.Name = "label_autentikasi";
            label_autentikasi.Size = new Size(423, 33);
            label_autentikasi.TabIndex = 0;
            label_autentikasi.Text = "⚔️Selamat Datang Petualang⚔️";
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.BackColor = Color.Transparent;
            label_nama.Font = new Font("Clesmont Demo", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_nama.ForeColor = Color.White;
            label_nama.Location = new Point(103, 110);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(218, 23);
            label_nama.TabIndex = 1;
            label_nama.Text = "Nama Petualang";
            // 
            // namaPetualang_value
            // 
            namaPetualang_value.Location = new Point(103, 151);
            namaPetualang_value.Name = "namaPetualang_value";
            namaPetualang_value.Size = new Size(496, 27);
            namaPetualang_value.TabIndex = 2;
            namaPetualang_value.TextChanged += nama_petualang_value_TextChanged;
            namaPetualang_value.Enter += namaPetualang_value_Enter;
            namaPetualang_value.Leave += namaPetualang_value_Leave;
            // 
            // codeRahasia_value
            // 
            codeRahasia_value.Location = new Point(103, 238);
            codeRahasia_value.Name = "codeRahasia_value";
            codeRahasia_value.Size = new Size(496, 27);
            codeRahasia_value.TabIndex = 4;
            codeRahasia_value.TextChanged += codeRahasia_value_TextChanged;
            codeRahasia_value.Enter += codeRahasia_value_Enter;
            codeRahasia_value.Leave += codeRahasia_value_Leave;
            // 
            // label_codeRahasia
            // 
            label_codeRahasia.AutoSize = true;
            label_codeRahasia.BackColor = Color.Transparent;
            label_codeRahasia.Font = new Font("Clesmont Demo", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_codeRahasia.ForeColor = Color.White;
            label_codeRahasia.Location = new Point(103, 197);
            label_codeRahasia.Name = "label_codeRahasia";
            label_codeRahasia.Size = new Size(215, 23);
            label_codeRahasia.TabIndex = 3;
            label_codeRahasia.Text = "Code Petualang";
            // 
            // masuk_button
            // 
            masuk_button.BackColor = Color.Lime;
            masuk_button.Font = new Font("Algerian", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            masuk_button.Location = new Point(103, 310);
            masuk_button.Name = "masuk_button";
            masuk_button.Size = new Size(112, 39);
            masuk_button.TabIndex = 5;
            masuk_button.Text = "Masuk";
            masuk_button.UseVisualStyleBackColor = false;
            // 
            // keluar_button
            // 
            keluar_button.BackColor = Color.Red;
            keluar_button.Font = new Font("Algerian", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keluar_button.Location = new Point(487, 310);
            keluar_button.Name = "keluar_button";
            keluar_button.Size = new Size(112, 39);
            keluar_button.TabIndex = 6;
            keluar_button.Text = "Keluar";
            keluar_button.UseVisualStyleBackColor = false;
            // 
            // daftar_button
            // 
            daftar_button.BackColor = Color.FromArgb(0, 0, 192);
            daftar_button.Font = new Font("Algerian", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            daftar_button.Location = new Point(281, 295);
            daftar_button.Name = "daftar_button";
            daftar_button.Size = new Size(141, 69);
            daftar_button.TabIndex = 7;
            daftar_button.Text = "Daftar";
            daftar_button.UseVisualStyleBackColor = false;
            // 
            // Lihat Password
            // 
            LihatPassword.AutoSize = true;
            LihatPassword.Location = new Point(610, 240);
            LihatPassword.Name = "LihatPassword";
            LihatPassword.Size = new Size(101, 24);
            LihatPassword.TabIndex = 8;
            LihatPassword.Text = "Tampilkan";
            LihatPassword.UseVisualStyleBackColor = true;
            LihatPassword.ForeColor = Color.White;
            LihatPassword.CheckedChanged += LihatPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(LihatPassword);
            Controls.Add(daftar_button);
            Controls.Add(keluar_button);
            Controls.Add(masuk_button);
            Controls.Add(codeRahasia_value);
            Controls.Add(label_codeRahasia);
            Controls.Add(namaPetualang_value);
            Controls.Add(label_nama);
            Controls.Add(label_autentikasi);
            Name = "Form1";
            Text = "Guild Petualang";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label_autentikasi;
        private Label label_nama;
        private TextBox namaPetualang_value;
        private TextBox codeRahasia_value;
        private Label label_codeRahasia;
        private Button masuk_button;
        private Button keluar_button;
        private Button daftar_button;
        private CheckBox LihatPassword;
    }
}
