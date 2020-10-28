namespace RegisztracioAlkalmazas
{
    partial class RegisztracioAlkalmazas
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
            this.nev = new System.Windows.Forms.Label();
            this.szuldatum = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.r_ferfi = new System.Windows.Forms.RadioButton();
            this.r_no = new System.Windows.Forms.RadioButton();
            this.nevbe = new System.Windows.Forms.TextBox();
            this.hobbi = new System.Windows.Forms.Label();
            this.szulbe = new System.Windows.Forms.DateTimePicker();
            this.lb_hobbi = new System.Windows.Forms.ListBox();
            this.labelhobbi = new System.Windows.Forms.Label();
            this.tb_newhobbi = new System.Windows.Forms.TextBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nev.Location = new System.Drawing.Point(47, 48);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(56, 29);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            // 
            // szuldatum
            // 
            this.szuldatum.AutoSize = true;
            this.szuldatum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuldatum.Location = new System.Drawing.Point(47, 92);
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(130, 29);
            this.szuldatum.TabIndex = 1;
            this.szuldatum.Text = "Szül. dátum:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nem.Location = new System.Drawing.Point(47, 131);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(63, 29);
            this.nem.TabIndex = 2;
            this.nem.Text = "Nem:";
            // 
            // r_ferfi
            // 
            this.r_ferfi.AutoSize = true;
            this.r_ferfi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_ferfi.Location = new System.Drawing.Point(173, 131);
            this.r_ferfi.Name = "r_ferfi";
            this.r_ferfi.Size = new System.Drawing.Size(43, 28);
            this.r_ferfi.TabIndex = 3;
            this.r_ferfi.TabStop = true;
            this.r_ferfi.Text = "F";
            this.r_ferfi.UseVisualStyleBackColor = true;
            // 
            // r_no
            // 
            this.r_no.AutoSize = true;
            this.r_no.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_no.Location = new System.Drawing.Point(248, 131);
            this.r_no.Name = "r_no";
            this.r_no.Size = new System.Drawing.Size(43, 28);
            this.r_no.TabIndex = 4;
            this.r_no.TabStop = true;
            this.r_no.Text = "N";
            this.r_no.UseVisualStyleBackColor = true;
            // 
            // nevbe
            // 
            this.nevbe.Location = new System.Drawing.Point(183, 55);
            this.nevbe.Name = "nevbe";
            this.nevbe.Size = new System.Drawing.Size(155, 22);
            this.nevbe.TabIndex = 5;
            // 
            // hobbi
            // 
            this.hobbi.AutoSize = true;
            this.hobbi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hobbi.Location = new System.Drawing.Point(420, 55);
            this.hobbi.Name = "hobbi";
            this.hobbi.Size = new System.Drawing.Size(158, 24);
            this.hobbi.TabIndex = 7;
            this.hobbi.Text = "Kedvenc hobbi:";
            // 
            // szulbe
            // 
            this.szulbe.Location = new System.Drawing.Point(183, 95);
            this.szulbe.Name = "szulbe";
            this.szulbe.Size = new System.Drawing.Size(154, 22);
            this.szulbe.TabIndex = 8;
            // 
            // lb_hobbi
            // 
            this.lb_hobbi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_hobbi.FormattingEnabled = true;
            this.lb_hobbi.ItemHeight = 27;
            this.lb_hobbi.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.lb_hobbi.Location = new System.Drawing.Point(397, 92);
            this.lb_hobbi.Name = "lb_hobbi";
            this.lb_hobbi.Size = new System.Drawing.Size(216, 193);
            this.lb_hobbi.TabIndex = 9;
            // 
            // labelhobbi
            // 
            this.labelhobbi.AutoSize = true;
            this.labelhobbi.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelhobbi.Location = new System.Drawing.Point(278, 313);
            this.labelhobbi.Name = "labelhobbi";
            this.labelhobbi.Size = new System.Drawing.Size(97, 29);
            this.labelhobbi.TabIndex = 10;
            this.labelhobbi.Text = "Új hobbi:";
            // 
            // tb_newhobbi
            // 
            this.tb_newhobbi.Location = new System.Drawing.Point(397, 318);
            this.tb_newhobbi.Name = "tb_newhobbi";
            this.tb_newhobbi.Size = new System.Drawing.Size(216, 22);
            this.tb_newhobbi.TabIndex = 11;
            // 
            // hozzaad
            // 
            this.hozzaad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hozzaad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaad.Location = new System.Drawing.Point(468, 360);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(145, 39);
            this.hozzaad.TabIndex = 12;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = false;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // mentes
            // 
            this.mentes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mentes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentes.Location = new System.Drawing.Point(303, 501);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(145, 39);
            this.mentes.TabIndex = 13;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = false;
            // 
            // betoltes
            // 
            this.betoltes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.betoltes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betoltes.Location = new System.Drawing.Point(468, 501);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(145, 39);
            this.betoltes.TabIndex = 14;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = false;
            // 
            // RegisztracioAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 564);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.tb_newhobbi);
            this.Controls.Add(this.labelhobbi);
            this.Controls.Add(this.lb_hobbi);
            this.Controls.Add(this.szulbe);
            this.Controls.Add(this.hobbi);
            this.Controls.Add(this.nevbe);
            this.Controls.Add(this.r_no);
            this.Controls.Add(this.r_ferfi);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.nev);
            this.Name = "RegisztracioAlkalmazas";
            this.Text = "RegisztracioAlkalmazas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szuldatum;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.RadioButton r_ferfi;
        private System.Windows.Forms.RadioButton r_no;
        private System.Windows.Forms.TextBox nevbe;
        private System.Windows.Forms.Label hobbi;
        private System.Windows.Forms.DateTimePicker szulbe;
        private System.Windows.Forms.ListBox lb_hobbi;
        private System.Windows.Forms.Label labelhobbi;
        private System.Windows.Forms.TextBox tb_newhobbi;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button betoltes;
    }
}

