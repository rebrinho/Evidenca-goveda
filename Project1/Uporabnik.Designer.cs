namespace Project1
{
    partial class Uporabnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uporabnik));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxGeslo = new System.Windows.Forms.TextBox();
            this.buttonPreklici = new System.Windows.Forms.Button();
            this.buttonPobrisi = new System.Windows.Forms.Button();
            this.buttonShrani = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(107, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(107, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(107, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uporabniško geslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(299, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moj profil";
            // 
            // textBoxIme
            // 
            this.textBoxIme.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIme.Location = new System.Drawing.Point(336, 206);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(300, 30);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPriimek.Location = new System.Drawing.Point(336, 300);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(300, 30);
            this.textBoxPriimek.TabIndex = 5;
            // 
            // textBoxGeslo
            // 
            this.textBoxGeslo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxGeslo.Location = new System.Drawing.Point(336, 387);
            this.textBoxGeslo.Name = "textBoxGeslo";
            this.textBoxGeslo.Size = new System.Drawing.Size(300, 30);
            this.textBoxGeslo.TabIndex = 6;
            // 
            // buttonPreklici
            // 
            this.buttonPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPreklici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreklici.ForeColor = System.Drawing.Color.White;
            this.buttonPreklici.Location = new System.Drawing.Point(112, 498);
            this.buttonPreklici.Name = "buttonPreklici";
            this.buttonPreklici.Size = new System.Drawing.Size(130, 68);
            this.buttonPreklici.TabIndex = 7;
            this.buttonPreklici.Text = "Prekliči";
            this.buttonPreklici.UseVisualStyleBackColor = false;
            this.buttonPreklici.Click += new System.EventHandler(this.ButtonPreklici_Click);
            // 
            // buttonPobrisi
            // 
            this.buttonPobrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPobrisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPobrisi.ForeColor = System.Drawing.Color.White;
            this.buttonPobrisi.Location = new System.Drawing.Point(307, 498);
            this.buttonPobrisi.Name = "buttonPobrisi";
            this.buttonPobrisi.Size = new System.Drawing.Size(130, 68);
            this.buttonPobrisi.TabIndex = 8;
            this.buttonPobrisi.Text = "Pobriši";
            this.buttonPobrisi.UseVisualStyleBackColor = false;
            this.buttonPobrisi.Click += new System.EventHandler(this.ButtonPobrisi_Click);
            // 
            // buttonShrani
            // 
            this.buttonShrani.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.buttonShrani.BackColor = System.Drawing.Color.Green;
            this.buttonShrani.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShrani.ForeColor = System.Drawing.Color.White;
            this.buttonShrani.Location = new System.Drawing.Point(506, 498);
            this.buttonShrani.Name = "buttonShrani";
            this.buttonShrani.Size = new System.Drawing.Size(130, 68);
            this.buttonShrani.TabIndex = 9;
            this.buttonShrani.Text = "Shrani";
            this.buttonShrani.UseVisualStyleBackColor = false;
            this.buttonShrani.Click += new System.EventHandler(this.ButtonShrani_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(112, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(336, 139);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(300, 30);
            this.textBoxID.TabIndex = 11;
            // 
            // Uporabnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 624);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonShrani);
            this.Controls.Add(this.buttonPobrisi);
            this.Controls.Add(this.buttonPreklici);
            this.Controls.Add(this.textBoxGeslo);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uporabnik";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Dodajanje in urejanje uporabnika";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxIme;
        public System.Windows.Forms.TextBox textBoxPriimek;
        public System.Windows.Forms.TextBox textBoxGeslo;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Button buttonPreklici;
        public System.Windows.Forms.Button buttonPobrisi;
        public System.Windows.Forms.Button buttonShrani;
    }
}