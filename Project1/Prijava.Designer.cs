namespace Project1
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.buttonPrekliči = new System.Windows.Forms.Button();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGeslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.govedoTableAdapter1 = new Project1.EvidencaGovedaDataSetTableAdapters.GovedoTableAdapter();
            this.tableAdapterManager1 = new Project1.EvidencaGovedaDataSetTableAdapters.TableAdapterManager();
            this.uporabnikiTableAdapter1 = new Project1.EvidencaGovedaDataSetTableAdapters.UporabnikiTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrekliči
            // 
            this.buttonPrekliči.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrekliči.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrekliči.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrekliči.ForeColor = System.Drawing.Color.White;
            this.buttonPrekliči.Location = new System.Drawing.Point(96, 387);
            this.buttonPrekliči.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrekliči.Name = "buttonPrekliči";
            this.buttonPrekliči.Size = new System.Drawing.Size(195, 65);
            this.buttonPrekliči.TabIndex = 0;
            this.buttonPrekliči.Text = "Prekliči";
            this.buttonPrekliči.UseVisualStyleBackColor = false;
            this.buttonPrekliči.Click += new System.EventHandler(this.ButtonPrekliči_Click);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrijava.BackColor = System.Drawing.Color.Green;
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrijava.ForeColor = System.Drawing.Color.White;
            this.buttonPrijava.Location = new System.Drawing.Point(445, 387);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(195, 65);
            this.buttonPrijava.TabIndex = 1;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.ButtonPrijava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(84, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geslo";
            // 
            // textBoxGeslo
            // 
            this.textBoxGeslo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxGeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGeslo.Location = new System.Drawing.Point(222, 297);
            this.textBoxGeslo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGeslo.Name = "textBoxGeslo";
            this.textBoxGeslo.PasswordChar = '*';
            this.textBoxGeslo.Size = new System.Drawing.Size(298, 34);
            this.textBoxGeslo.TabIndex = 6;
            this.textBoxGeslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(180, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Evidenca živali na kmetiji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(154, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Informacije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(453, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registracija";
            // 
            // govedoTableAdapter1
            // 
            this.govedoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.GovedoTableAdapter = this.govedoTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Project1.EvidencaGovedaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UporabnikiTableAdapter = this.uporabnikiTableAdapter1;
            // 
            // uporabnikiTableAdapter1
            // 
            this.uporabnikiTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(90, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ime";
            // 
            // textBoxIme
            // 
            this.textBoxIme.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIme.Location = new System.Drawing.Point(222, 227);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(298, 34);
            this.textBoxIme.TabIndex = 13;
            this.textBoxIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Project1.Properties.Resources.geslo;
            this.pictureBox1.Location = new System.Drawing.Point(347, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistracija.BackgroundImage = global::Project1.Properties.Resources.registriranje_novega_jpg;
            this.buttonRegistracija.Location = new System.Drawing.Point(572, 523);
            this.buttonRegistracija.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(60, 60);
            this.buttonRegistracija.TabIndex = 3;
            this.buttonRegistracija.UseVisualStyleBackColor = false;
            this.buttonRegistracija.Click += new System.EventHandler(this.ButtonRegistracija_Click_1);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.BackgroundImage = global::Project1.Properties.Resources.info_jpg;
            this.buttonInfo.Location = new System.Drawing.Point(90, 523);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(60, 60);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Green;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(713, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 625);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Green;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(23, 11);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(10, 626);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Green;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 640);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(742, 7);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "REDADevelop 2017-18";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(742, 652);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGeslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.buttonPrekliči);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Prijava";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EvidencaGovedaDataSetTableAdapters.GovedoTableAdapter govedoTableAdapter1;
        private EvidencaGovedaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private EvidencaGovedaDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxGeslo;
        public System.Windows.Forms.TextBox textBoxIme;
        public System.Windows.Forms.Button buttonPrekliči;
        public System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
    }
}