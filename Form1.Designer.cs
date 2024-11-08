namespace juki__coba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Buku = new RadioButton();
            pendaftaran = new RadioButton();
            Login = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.2956524F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 40);
            label1.Name = "label1";
            label1.Size = new Size(370, 52);
            label1.TabIndex = 0;
            label1.Text = "SELAMAT DATANG";
            // 
            // Buku
            // 
            Buku.AutoSize = true;
            Buku.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Buku.Location = new Point(16, 45);
            Buku.Name = "Buku";
            Buku.Size = new Size(91, 40);
            Buku.TabIndex = 1;
            Buku.TabStop = true;
            Buku.Text = "Buku";
            Buku.UseVisualStyleBackColor = true;
            Buku.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // pendaftaran
            // 
            pendaftaran.AutoSize = true;
            pendaftaran.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendaftaran.Location = new Point(16, 110);
            pendaftaran.Name = "pendaftaran";
            pendaftaran.Size = new Size(171, 40);
            pendaftaran.TabIndex = 2;
            pendaftaran.TabStop = true;
            pendaftaran.Text = "Pendaftaran";
            pendaftaran.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(16, 179);
            Login.Name = "Login";
            Login.Size = new Size(96, 40);
            Login.TabIndex = 3;
            Login.TabStop = true;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(600, 391);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 4;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 472);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Buku);
            groupBox1.Controls.Add(pendaftaran);
            groupBox1.Controls.Add(Login);
            groupBox1.Location = new Point(158, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 236);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilihan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton Buku;
        private RadioButton pendaftaran;
        private RadioButton Login;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}
