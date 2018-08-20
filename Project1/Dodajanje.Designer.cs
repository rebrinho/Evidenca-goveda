using System.ComponentModel;
using System.Windows.Forms;


namespace Project1
{
    partial class Dodajanje
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodajanje));
            this.Id_zivali = new System.Windows.Forms.Label();
            this.textBoxIdZivali = new System.Windows.Forms.TextBox();
            this.textBoxIdMatere = new System.Windows.Forms.TextBox();
            this.textBoxIdOceta = new System.Windows.Forms.TextBox();
            this.labelDatumRojstva = new System.Windows.Forms.Label();
            this.labelSpol = new System.Windows.Forms.Label();
            this.labelPasma = new System.Windows.Forms.Label();
            this.labelIdMatere = new System.Windows.Forms.Label();
            this.labelIdOčeta = new System.Windows.Forms.Label();
            this.labelZunanjaGradiva = new System.Windows.Forms.Label();
            this.textBoxImezivali = new System.Windows.Forms.TextBox();
            this.labelImezivali = new System.Windows.Forms.Label();
            this.comboBoxPasma = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRojstvo = new System.Windows.Forms.DateTimePicker();
            this.buttonPreklici = new System.Windows.Forms.Button();
            this.buttonShrani = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPobrisi = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPoisci = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSpol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_zivali
            // 
            this.Id_zivali.AutoSize = true;
            this.Id_zivali.BackColor = System.Drawing.Color.Transparent;
            this.Id_zivali.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id_zivali.ForeColor = System.Drawing.Color.Green;
            this.Id_zivali.Location = new System.Drawing.Point(68, 186);
            this.Id_zivali.Name = "Id_zivali";
            this.Id_zivali.Size = new System.Drawing.Size(93, 26);
            this.Id_zivali.TabIndex = 1;
            this.Id_zivali.Text = "Id živali";
            // 
            // textBoxIdZivali
            // 
            this.textBoxIdZivali.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIdZivali.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdZivali.Location = new System.Drawing.Point(281, 186);
            this.textBoxIdZivali.Name = "textBoxIdZivali";
            this.textBoxIdZivali.Size = new System.Drawing.Size(246, 30);
            this.textBoxIdZivali.TabIndex = 2;
            // 
            // textBoxIdMatere
            // 
            this.textBoxIdMatere.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIdMatere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdMatere.Location = new System.Drawing.Point(281, 460);
            this.textBoxIdMatere.Name = "textBoxIdMatere";
            this.textBoxIdMatere.Size = new System.Drawing.Size(246, 30);
            this.textBoxIdMatere.TabIndex = 7;
            // 
            // textBoxIdOceta
            // 
            this.textBoxIdOceta.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIdOceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdOceta.Location = new System.Drawing.Point(281, 505);
            this.textBoxIdOceta.Name = "textBoxIdOceta";
            this.textBoxIdOceta.Size = new System.Drawing.Size(246, 30);
            this.textBoxIdOceta.TabIndex = 8;
            // 
            // labelDatumRojstva
            // 
            this.labelDatumRojstva.AutoSize = true;
            this.labelDatumRojstva.BackColor = System.Drawing.Color.Transparent;
            this.labelDatumRojstva.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumRojstva.ForeColor = System.Drawing.Color.Green;
            this.labelDatumRojstva.Location = new System.Drawing.Point(66, 295);
            this.labelDatumRojstva.Name = "labelDatumRojstva";
            this.labelDatumRojstva.Size = new System.Drawing.Size(158, 26);
            this.labelDatumRojstva.TabIndex = 10;
            this.labelDatumRojstva.Text = "Datum rojstva";
            // 
            // labelSpol
            // 
            this.labelSpol.AutoSize = true;
            this.labelSpol.BackColor = System.Drawing.Color.Transparent;
            this.labelSpol.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpol.ForeColor = System.Drawing.Color.Green;
            this.labelSpol.Location = new System.Drawing.Point(68, 352);
            this.labelSpol.Name = "labelSpol";
            this.labelSpol.Size = new System.Drawing.Size(57, 26);
            this.labelSpol.TabIndex = 11;
            this.labelSpol.Text = "Spol";
            // 
            // labelPasma
            // 
            this.labelPasma.AutoSize = true;
            this.labelPasma.BackColor = System.Drawing.Color.Transparent;
            this.labelPasma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasma.ForeColor = System.Drawing.Color.Green;
            this.labelPasma.Location = new System.Drawing.Point(68, 411);
            this.labelPasma.Name = "labelPasma";
            this.labelPasma.Size = new System.Drawing.Size(79, 26);
            this.labelPasma.TabIndex = 12;
            this.labelPasma.Text = "Pasma";
            // 
            // labelIdMatere
            // 
            this.labelIdMatere.AutoSize = true;
            this.labelIdMatere.BackColor = System.Drawing.Color.Transparent;
            this.labelIdMatere.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdMatere.ForeColor = System.Drawing.Color.Green;
            this.labelIdMatere.Location = new System.Drawing.Point(68, 463);
            this.labelIdMatere.Name = "labelIdMatere";
            this.labelIdMatere.Size = new System.Drawing.Size(112, 26);
            this.labelIdMatere.TabIndex = 13;
            this.labelIdMatere.Text = "Id matere";
            // 
            // labelIdOčeta
            // 
            this.labelIdOčeta.AutoSize = true;
            this.labelIdOčeta.BackColor = System.Drawing.Color.Transparent;
            this.labelIdOčeta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdOčeta.ForeColor = System.Drawing.Color.Green;
            this.labelIdOčeta.Location = new System.Drawing.Point(68, 509);
            this.labelIdOčeta.Name = "labelIdOčeta";
            this.labelIdOčeta.Size = new System.Drawing.Size(94, 26);
            this.labelIdOčeta.TabIndex = 14;
            this.labelIdOčeta.Text = "Id očeta";
            // 
            // labelZunanjaGradiva
            // 
            this.labelZunanjaGradiva.AutoSize = true;
            this.labelZunanjaGradiva.BackColor = System.Drawing.Color.Transparent;
            this.labelZunanjaGradiva.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZunanjaGradiva.ForeColor = System.Drawing.Color.Green;
            this.labelZunanjaGradiva.Location = new System.Drawing.Point(66, 563);
            this.labelZunanjaGradiva.Name = "labelZunanjaGradiva";
            this.labelZunanjaGradiva.Size = new System.Drawing.Size(208, 26);
            this.labelZunanjaGradiva.TabIndex = 15;
            this.labelZunanjaGradiva.Text = "Zunanji dokumenti";
            // 
            // textBoxImezivali
            // 
            this.textBoxImezivali.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxImezivali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImezivali.Location = new System.Drawing.Point(281, 238);
            this.textBoxImezivali.Name = "textBoxImezivali";
            this.textBoxImezivali.Size = new System.Drawing.Size(246, 30);
            this.textBoxImezivali.TabIndex = 17;
            // 
            // labelImezivali
            // 
            this.labelImezivali.AutoSize = true;
            this.labelImezivali.BackColor = System.Drawing.Color.Transparent;
            this.labelImezivali.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImezivali.ForeColor = System.Drawing.Color.Green;
            this.labelImezivali.Location = new System.Drawing.Point(68, 241);
            this.labelImezivali.Name = "labelImezivali";
            this.labelImezivali.Size = new System.Drawing.Size(110, 26);
            this.labelImezivali.TabIndex = 16;
            this.labelImezivali.Text = "Ime živali";
            // 
            // comboBoxPasma
            // 
            this.comboBoxPasma.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxPasma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPasma.FormattingEnabled = true;
            this.comboBoxPasma.Items.AddRange(new object[] {
            "ČB",
            "LIM",
            "LS",
            "RJ"});
            this.comboBoxPasma.Location = new System.Drawing.Point(281, 408);
            this.comboBoxPasma.Name = "comboBoxPasma";
            this.comboBoxPasma.Size = new System.Drawing.Size(246, 33);
            this.comboBoxPasma.Sorted = true;
            this.comboBoxPasma.TabIndex = 19;
            // 
            // dateTimePickerRojstvo
            // 
            this.dateTimePickerRojstvo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRojstvo.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePickerRojstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRojstvo.Location = new System.Drawing.Point(281, 290);
            this.dateTimePickerRojstvo.Name = "dateTimePickerRojstvo";
            this.dateTimePickerRojstvo.Size = new System.Drawing.Size(246, 30);
            this.dateTimePickerRojstvo.TabIndex = 20;
            // 
            // buttonPreklici
            // 
            this.buttonPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPreklici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreklici.ForeColor = System.Drawing.Color.White;
            this.buttonPreklici.Location = new System.Drawing.Point(72, 611);
            this.buttonPreklici.Name = "buttonPreklici";
            this.buttonPreklici.Size = new System.Drawing.Size(153, 63);
            this.buttonPreklici.TabIndex = 21;
            this.buttonPreklici.Text = "Prekliči";
            this.buttonPreklici.UseVisualStyleBackColor = false;
            this.buttonPreklici.Click += new System.EventHandler(this.Preklici_Click);
            // 
            // buttonShrani
            // 
            this.buttonShrani.BackColor = System.Drawing.Color.Green;
            this.buttonShrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShrani.ForeColor = System.Drawing.Color.White;
            this.buttonShrani.Location = new System.Drawing.Point(514, 611);
            this.buttonShrani.Name = "buttonShrani";
            this.buttonShrani.Size = new System.Drawing.Size(153, 63);
            this.buttonShrani.TabIndex = 22;
            this.buttonShrani.Text = "Shrani";
            this.buttonShrani.UseVisualStyleBackColor = false;
            this.buttonShrani.Click += new System.EventHandler(this.Shrani_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(901, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(34, 33);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonPobrisi
            // 
            this.buttonPobrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPobrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPobrisi.ForeColor = System.Drawing.Color.White;
            this.buttonPobrisi.Location = new System.Drawing.Point(290, 611);
            this.buttonPobrisi.Name = "buttonPobrisi";
            this.buttonPobrisi.Size = new System.Drawing.Size(153, 63);
            this.buttonPobrisi.TabIndex = 29;
            this.buttonPobrisi.Text = "Pobriši";
            this.buttonPobrisi.UseVisualStyleBackColor = false;
            this.buttonPobrisi.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(533, 417);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(203, 172);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            // 
            // buttonPoisci
            // 
            this.buttonPoisci.BackColor = System.Drawing.SystemColors.Info;
            this.buttonPoisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPoisci.Location = new System.Drawing.Point(281, 560);
            this.buttonPoisci.Name = "buttonPoisci";
            this.buttonPoisci.Size = new System.Drawing.Size(246, 30);
            this.buttonPoisci.TabIndex = 31;
            this.buttonPoisci.Text = "Poišči datoteko";
            this.buttonPoisci.UseVisualStyleBackColor = false;
            this.buttonPoisci.Click += new System.EventHandler(this.ButtonPoisci_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(68, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(281, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 30);
            this.textBox1.TabIndex = 33;
            // 
            // comboBoxSpol
            // 
            this.comboBoxSpol.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpol.FormattingEnabled = true;
            this.comboBoxSpol.Items.AddRange(new object[] {
            "moški",
            "ženski"});
            this.comboBoxSpol.Location = new System.Drawing.Point(281, 345);
            this.comboBoxSpol.Name = "comboBoxSpol";
            this.comboBoxSpol.Size = new System.Drawing.Size(246, 33);
            this.comboBoxSpol.Sorted = true;
            this.comboBoxSpol.TabIndex = 34;
            // 
            // Dodajanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Project1.Properties.Resources._815fdf01fc54cbb50145fe022a0a9c2e__facts_about_cows_cow_appreciation_day;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 778);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxSpol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPoisci);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonPobrisi);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShrani);
            this.Controls.Add(this.buttonPreklici);
            this.Controls.Add(this.dateTimePickerRojstvo);
            this.Controls.Add(this.comboBoxPasma);
            this.Controls.Add(this.textBoxImezivali);
            this.Controls.Add(this.labelImezivali);
            this.Controls.Add(this.labelZunanjaGradiva);
            this.Controls.Add(this.labelIdOčeta);
            this.Controls.Add(this.labelIdMatere);
            this.Controls.Add(this.labelPasma);
            this.Controls.Add(this.labelSpol);
            this.Controls.Add(this.labelDatumRojstva);
            this.Controls.Add(this.textBoxIdOceta);
            this.Controls.Add(this.textBoxIdMatere);
            this.Controls.Add(this.textBoxIdZivali);
            this.Controls.Add(this.Id_zivali);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dodajanje";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Evidence";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Id_zivali;
        private System.Windows.Forms.Label labelDatumRojstva;
        private System.Windows.Forms.Label labelSpol;
        private System.Windows.Forms.Label labelPasma;
        private System.Windows.Forms.Label labelIdMatere;
        private System.Windows.Forms.Label labelIdOčeta;
        private System.Windows.Forms.Label labelZunanjaGradiva;
        private System.Windows.Forms.Label labelImezivali;
        private ErrorProvider errorProvider1;
        private Button buttonExit;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        public TextBox textBoxIdZivali;
        public TextBox textBoxIdMatere;
        public TextBox textBoxIdOceta;
        public TextBox textBoxImezivali;
        public ComboBox comboBoxPasma;
        public DateTimePicker dateTimePickerRojstvo;
        public PictureBox pictureBox;
        public Button buttonPoisci;
        public TextBox textBox1;
        public ComboBox comboBoxSpol;
        public Button buttonShrani;
        protected Button buttonPreklici;
        protected Button buttonPobrisi;
    }
}

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>

        #endregion