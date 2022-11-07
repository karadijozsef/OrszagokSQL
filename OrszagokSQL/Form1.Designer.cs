namespace OrszagokSQL
{
    partial class Form1
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
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.OrszagNev = new System.Windows.Forms.Label();
            this.Fovaros = new System.Windows.Forms.Label();
            this.Terulet = new System.Windows.Forms.Label();
            this.Nepesseg = new System.Windows.Forms.Label();
            this.Allamforma = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_orsz = new System.Windows.Forms.TextBox();
            this.textBox_fov = new System.Windows.Forms.TextBox();
            this.textBox_ter = new System.Windows.Forms.TextBox();
            this.textBox_nep = new System.Windows.Forms.TextBox();
            this.textBox_allam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(160, 450);
            this.listBox_Orszagok.TabIndex = 0;
            this.listBox_Orszagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Orszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_allam);
            this.groupBox1.Controls.Add(this.textBox_nep);
            this.groupBox1.Controls.Add(this.textBox_ter);
            this.groupBox1.Controls.Add(this.textBox_fov);
            this.groupBox1.Controls.Add(this.textBox_orsz);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.Allamforma);
            this.groupBox1.Controls.Add(this.Nepesseg);
            this.groupBox1.Controls.Add(this.Terulet);
            this.groupBox1.Controls.Add(this.Fovaros);
            this.groupBox1.Controls.Add(this.OrszagNev);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(160, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott ország adatai";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(19, 42);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // OrszagNev
            // 
            this.OrszagNev.AutoSize = true;
            this.OrszagNev.Location = new System.Drawing.Point(19, 83);
            this.OrszagNev.Name = "OrszagNev";
            this.OrszagNev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrszagNev.Size = new System.Drawing.Size(67, 13);
            this.OrszagNev.TabIndex = 1;
            this.OrszagNev.Text = "Ország neve";
            // 
            // Fovaros
            // 
            this.Fovaros.AutoSize = true;
            this.Fovaros.Location = new System.Drawing.Point(19, 132);
            this.Fovaros.Name = "Fovaros";
            this.Fovaros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fovaros.Size = new System.Drawing.Size(58, 13);
            this.Fovaros.TabIndex = 2;
            this.Fovaros.Text = "Államforma";
            // 
            // Terulet
            // 
            this.Terulet.AutoSize = true;
            this.Terulet.Location = new System.Drawing.Point(19, 178);
            this.Terulet.Name = "Terulet";
            this.Terulet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Terulet.Size = new System.Drawing.Size(45, 13);
            this.Terulet.TabIndex = 3;
            this.Terulet.Text = "Főváros";
            // 
            // Nepesseg
            // 
            this.Nepesseg.AutoSize = true;
            this.Nepesseg.Location = new System.Drawing.Point(19, 223);
            this.Nepesseg.Name = "Nepesseg";
            this.Nepesseg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nepesseg.Size = new System.Drawing.Size(55, 13);
            this.Nepesseg.TabIndex = 4;
            this.Nepesseg.Text = "Népesség";
            // 
            // Allamforma
            // 
            this.Allamforma.AutoSize = true;
            this.Allamforma.Location = new System.Drawing.Point(19, 271);
            this.Allamforma.Name = "Allamforma";
            this.Allamforma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Allamforma.Size = new System.Drawing.Size(40, 13);
            this.Allamforma.TabIndex = 5;
            this.Allamforma.Text = "Terület";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(104, 39);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(63, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_orsz
            // 
            this.textBox_orsz.Location = new System.Drawing.Point(104, 80);
            this.textBox_orsz.Name = "textBox_orsz";
            this.textBox_orsz.Size = new System.Drawing.Size(166, 20);
            this.textBox_orsz.TabIndex = 7;
            // 
            // textBox_fov
            // 
            this.textBox_fov.Location = new System.Drawing.Point(104, 129);
            this.textBox_fov.Name = "textBox_fov";
            this.textBox_fov.Size = new System.Drawing.Size(166, 20);
            this.textBox_fov.TabIndex = 8;
            // 
            // textBox_ter
            // 
            this.textBox_ter.Location = new System.Drawing.Point(104, 175);
            this.textBox_ter.Name = "textBox_ter";
            this.textBox_ter.Size = new System.Drawing.Size(166, 20);
            this.textBox_ter.TabIndex = 9;
            // 
            // textBox_nep
            // 
            this.textBox_nep.Location = new System.Drawing.Point(104, 220);
            this.textBox_nep.Name = "textBox_nep";
            this.textBox_nep.Size = new System.Drawing.Size(166, 20);
            this.textBox_nep.TabIndex = 10;
            // 
            // textBox_allam
            // 
            this.textBox_allam.Location = new System.Drawing.Point(104, 268);
            this.textBox_allam.Name = "textBox_allam";
            this.textBox_allam.Size = new System.Drawing.Size(166, 20);
            this.textBox_allam.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagok);
            this.Name = "Form1";
            this.Text = "Form_Orszagok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Fovaros;
        private System.Windows.Forms.Label OrszagNev;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label Terulet;
        private System.Windows.Forms.Label Allamforma;
        private System.Windows.Forms.Label Nepesseg;
        private System.Windows.Forms.TextBox textBox_allam;
        private System.Windows.Forms.TextBox textBox_nep;
        private System.Windows.Forms.TextBox textBox_ter;
        private System.Windows.Forms.TextBox textBox_fov;
        private System.Windows.Forms.TextBox textBox_orsz;
        private System.Windows.Forms.TextBox textBox_id;
    }
}

