namespace Project1
{
    partial class Glavna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.natisniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodIzProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpišoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstaGovedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mlajšeOdTrehMesecevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medTriInŠestMesecevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medŠestInDvanajstMesecevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medEnimInDrugimLetomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starejšeOdDvehLetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpišiŽenskeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kraveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpišiMoškeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moškiSPotomciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIzhod = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewZivali = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecIDzivali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecSpol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecPasma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecIDmatere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecIDoceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stolpecDokument = new System.Windows.Forms.DataGridViewImageColumn();
            this.govedoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidencaGovedaDataSet = new Project1.EvidencaGovedaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIskanje = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.govedoTableAdapter = new Project1.EvidencaGovedaDataSetTableAdapters.GovedoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stzenske = new System.Windows.Forms.Label();
            this.stmoski = new System.Windows.Forms.Label();
            this.stzivali = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.buttonIsci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTabela = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZivali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govedoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencaGovedaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.izpišoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1222, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.natisniToolStripMenuItem,
            this.izhodIzProgramaToolStripMenuItem});
            this.datotekaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datotekaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(105, 37);
            this.datotekaToolStripMenuItem.Text = "Program";
            // 
            // natisniToolStripMenuItem
            // 
            this.natisniToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.natisniToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.natisniToolStripMenuItem.Name = "natisniToolStripMenuItem";
            this.natisniToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.natisniToolStripMenuItem.Text = "Natisni";
            // 
            // izhodIzProgramaToolStripMenuItem
            // 
            this.izhodIzProgramaToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.izhodIzProgramaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.izhodIzProgramaToolStripMenuItem.Name = "izhodIzProgramaToolStripMenuItem";
            this.izhodIzProgramaToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.izhodIzProgramaToolStripMenuItem.Text = "Izhod iz programa";
            this.izhodIzProgramaToolStripMenuItem.Click += new System.EventHandler(this.IzhodIzProgramaToolStripMenuItem_Click);
            // 
            // izpišoToolStripMenuItem
            // 
            this.izpišoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIstaGovedaToolStripMenuItem,
            this.izpišiŽenskeToolStripMenuItem,
            this.izpišiMoškeToolStripMenuItem});
            this.izpišoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izpišoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.izpišoToolStripMenuItem.Name = "izpišoToolStripMenuItem";
            this.izpišoToolStripMenuItem.Size = new System.Drawing.Size(73, 37);
            this.izpišoToolStripMenuItem.Text = "Izpiši";
            // 
            // lIstaGovedaToolStripMenuItem
            // 
            this.lIstaGovedaToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.lIstaGovedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mlajšeOdTrehMesecevToolStripMenuItem,
            this.medTriInŠestMesecevToolStripMenuItem,
            this.medŠestInDvanajstMesecevToolStripMenuItem,
            this.medEnimInDrugimLetomToolStripMenuItem,
            this.starejšeOdDvehLetToolStripMenuItem});
            this.lIstaGovedaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lIstaGovedaToolStripMenuItem.Name = "lIstaGovedaToolStripMenuItem";
            this.lIstaGovedaToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.lIstaGovedaToolStripMenuItem.Text = "Izpiši vse";
            this.lIstaGovedaToolStripMenuItem.Click += new System.EventHandler(this.ListaGovedaToolStripMenuItem_Click);
            // 
            // mlajšeOdTrehMesecevToolStripMenuItem
            // 
            this.mlajšeOdTrehMesecevToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.mlajšeOdTrehMesecevToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mlajšeOdTrehMesecevToolStripMenuItem.Name = "mlajšeOdTrehMesecevToolStripMenuItem";
            this.mlajšeOdTrehMesecevToolStripMenuItem.Size = new System.Drawing.Size(371, 32);
            this.mlajšeOdTrehMesecevToolStripMenuItem.Text = "mlajše od treh mesecev";
            this.mlajšeOdTrehMesecevToolStripMenuItem.Click += new System.EventHandler(this.MlajšeOdTrehMesecevToolStripMenuItem_Click);
            // 
            // medTriInŠestMesecevToolStripMenuItem
            // 
            this.medTriInŠestMesecevToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.medTriInŠestMesecevToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medTriInŠestMesecevToolStripMenuItem.Name = "medTriInŠestMesecevToolStripMenuItem";
            this.medTriInŠestMesecevToolStripMenuItem.Size = new System.Drawing.Size(371, 32);
            this.medTriInŠestMesecevToolStripMenuItem.Text = "med tri in šest mesecev";
            this.medTriInŠestMesecevToolStripMenuItem.Click += new System.EventHandler(this.MedTriInŠestMesecevToolStripMenuItem_Click);
            // 
            // medŠestInDvanajstMesecevToolStripMenuItem
            // 
            this.medŠestInDvanajstMesecevToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.medŠestInDvanajstMesecevToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medŠestInDvanajstMesecevToolStripMenuItem.Name = "medŠestInDvanajstMesecevToolStripMenuItem";
            this.medŠestInDvanajstMesecevToolStripMenuItem.Size = new System.Drawing.Size(371, 32);
            this.medŠestInDvanajstMesecevToolStripMenuItem.Text = "med šest in dvanajst mesecev";
            this.medŠestInDvanajstMesecevToolStripMenuItem.Click += new System.EventHandler(this.MedŠestInDvanajstMesecevToolStripMenuItem_Click);
            // 
            // medEnimInDrugimLetomToolStripMenuItem
            // 
            this.medEnimInDrugimLetomToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.medEnimInDrugimLetomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medEnimInDrugimLetomToolStripMenuItem.Name = "medEnimInDrugimLetomToolStripMenuItem";
            this.medEnimInDrugimLetomToolStripMenuItem.Size = new System.Drawing.Size(371, 32);
            this.medEnimInDrugimLetomToolStripMenuItem.Text = "med prvim in drugim letom";
            this.medEnimInDrugimLetomToolStripMenuItem.Click += new System.EventHandler(this.MedEnimInDrugimLetomToolStripMenuItem_Click);
            // 
            // starejšeOdDvehLetToolStripMenuItem
            // 
            this.starejšeOdDvehLetToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.starejšeOdDvehLetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.starejšeOdDvehLetToolStripMenuItem.Name = "starejšeOdDvehLetToolStripMenuItem";
            this.starejšeOdDvehLetToolStripMenuItem.Size = new System.Drawing.Size(371, 32);
            this.starejšeOdDvehLetToolStripMenuItem.Text = "starejše od dveh let";
            this.starejšeOdDvehLetToolStripMenuItem.Click += new System.EventHandler(this.StarejšeOdDvehLetToolStripMenuItem_Click);
            // 
            // izpišiŽenskeToolStripMenuItem
            // 
            this.izpišiŽenskeToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.izpišiŽenskeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kraveToolStripMenuItem,
            this.teliceToolStripMenuItem});
            this.izpišiŽenskeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.izpišiŽenskeToolStripMenuItem.Name = "izpišiŽenskeToolStripMenuItem";
            this.izpišiŽenskeToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.izpišiŽenskeToolStripMenuItem.Text = "Izpiši ženske";
            this.izpišiŽenskeToolStripMenuItem.Click += new System.EventHandler(this.IzpišiŽenskeToolStripMenuItem_Click);
            // 
            // kraveToolStripMenuItem
            // 
            this.kraveToolStripMenuItem.Name = "kraveToolStripMenuItem";
            this.kraveToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.kraveToolStripMenuItem.Text = "krave";
            // 
            // teliceToolStripMenuItem
            // 
            this.teliceToolStripMenuItem.Name = "teliceToolStripMenuItem";
            this.teliceToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.teliceToolStripMenuItem.Text = "telice";
            // 
            // izpišiMoškeToolStripMenuItem
            // 
            this.izpišiMoškeToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.izpišiMoškeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moškiSPotomciToolStripMenuItem});
            this.izpišiMoškeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.izpišiMoškeToolStripMenuItem.Name = "izpišiMoškeToolStripMenuItem";
            this.izpišiMoškeToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.izpišiMoškeToolStripMenuItem.Text = "Izpiši moške";
            this.izpišiMoškeToolStripMenuItem.Click += new System.EventHandler(this.IzpišiMoškeToolStripMenuItem_Click);
            // 
            // moškiSPotomciToolStripMenuItem
            // 
            this.moškiSPotomciToolStripMenuItem.Name = "moškiSPotomciToolStripMenuItem";
            this.moškiSPotomciToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.moškiSPotomciToolStripMenuItem.Text = "moški s potomci";
            // 
            // buttonIzhod
            // 
            this.buttonIzhod.AllowDrop = true;
            this.buttonIzhod.AutoSize = true;
            this.buttonIzhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonIzhod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIzhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzhod.ForeColor = System.Drawing.Color.White;
            this.buttonIzhod.Location = new System.Drawing.Point(1179, 17);
            this.buttonIzhod.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonIzhod.Name = "buttonIzhod";
            this.buttonIzhod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonIzhod.Size = new System.Drawing.Size(42, 39);
            this.buttonIzhod.TabIndex = 1;
            this.buttonIzhod.Text = "X";
            this.buttonIzhod.UseVisualStyleBackColor = false;
            this.buttonIzhod.Click += new System.EventHandler(this.ButtonIzhod_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.AllowDrop = true;
            this.buttonMax.AutoSize = true;
            this.buttonMax.BackColor = System.Drawing.Color.Green;
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMax.ForeColor = System.Drawing.Color.White;
            this.buttonMax.Location = new System.Drawing.Point(1127, 17);
            this.buttonMax.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMax.Size = new System.Drawing.Size(42, 39);
            this.buttonMax.TabIndex = 2;
            this.buttonMax.Text = "O";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.AllowDrop = true;
            this.buttonMin.AutoSize = true;
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(1075, 17);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMin.Size = new System.Drawing.Size(42, 39);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vodenje evidenc živali";
            // 
            // dataGridViewZivali
            // 
            this.dataGridViewZivali.AllowDrop = true;
            this.dataGridViewZivali.AllowUserToAddRows = false;
            this.dataGridViewZivali.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewZivali.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewZivali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZivali.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewZivali.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewZivali.ColumnHeadersHeight = 60;
            this.dataGridViewZivali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.stolpecIDzivali,
            this.stolpecIme,
            this.stolpecDatum,
            this.stolpecSpol,
            this.stolpecPasma,
            this.stolpecIDmatere,
            this.stolpecIDoceta,
            this.stolpecDokument});
            this.dataGridViewZivali.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewZivali.Location = new System.Drawing.Point(252, 245);
            this.dataGridViewZivali.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewZivali.MaximumSize = new System.Drawing.Size(1000, 450);
            this.dataGridViewZivali.Name = "dataGridViewZivali";
            this.dataGridViewZivali.ReadOnly = true;
            this.dataGridViewZivali.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewZivali.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridViewZivali.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewZivali.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewZivali.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewZivali.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewZivali.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewZivali.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewZivali.RowTemplate.DividerHeight = 5;
            this.dataGridViewZivali.RowTemplate.Height = 120;
            this.dataGridViewZivali.RowTemplate.ReadOnly = true;
            this.dataGridViewZivali.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewZivali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZivali.Size = new System.Drawing.Size(922, 450);
            this.dataGridViewZivali.StandardTab = true;
            this.dataGridViewZivali.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 80;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Width = 80;
            // 
            // stolpecIDzivali
            // 
            this.stolpecIDzivali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecIDzivali.Frozen = true;
            this.stolpecIDzivali.HeaderText = "ID živali";
            this.stolpecIDzivali.MinimumWidth = 50;
            this.stolpecIDzivali.Name = "stolpecIDzivali";
            this.stolpecIDzivali.ReadOnly = true;
            this.stolpecIDzivali.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // stolpecIme
            // 
            this.stolpecIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecIme.HeaderText = "Ime živali";
            this.stolpecIme.MinimumWidth = 50;
            this.stolpecIme.Name = "stolpecIme";
            this.stolpecIme.ReadOnly = true;
            this.stolpecIme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecIme.Width = 112;
            // 
            // stolpecDatum
            // 
            this.stolpecDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecDatum.HeaderText = "Datum rojstva";
            this.stolpecDatum.MinimumWidth = 50;
            this.stolpecDatum.Name = "stolpecDatum";
            this.stolpecDatum.ReadOnly = true;
            this.stolpecDatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecDatum.Width = 150;
            // 
            // stolpecSpol
            // 
            this.stolpecSpol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecSpol.HeaderText = "Spol";
            this.stolpecSpol.MinimumWidth = 50;
            this.stolpecSpol.Name = "stolpecSpol";
            this.stolpecSpol.ReadOnly = true;
            this.stolpecSpol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecSpol.Width = 81;
            // 
            // stolpecPasma
            // 
            this.stolpecPasma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecPasma.HeaderText = "Pasma";
            this.stolpecPasma.MinimumWidth = 50;
            this.stolpecPasma.Name = "stolpecPasma";
            this.stolpecPasma.ReadOnly = true;
            this.stolpecPasma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecPasma.Width = 96;
            // 
            // stolpecIDmatere
            // 
            this.stolpecIDmatere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecIDmatere.HeaderText = "ID matere";
            this.stolpecIDmatere.MinimumWidth = 50;
            this.stolpecIDmatere.Name = "stolpecIDmatere";
            this.stolpecIDmatere.ReadOnly = true;
            this.stolpecIDmatere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecIDmatere.Width = 116;
            // 
            // stolpecIDoceta
            // 
            this.stolpecIDoceta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stolpecIDoceta.HeaderText = "ID očeta";
            this.stolpecIDoceta.MinimumWidth = 50;
            this.stolpecIDoceta.Name = "stolpecIDoceta";
            this.stolpecIDoceta.ReadOnly = true;
            this.stolpecIDoceta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecIDoceta.Width = 104;
            // 
            // stolpecDokument
            // 
            this.stolpecDokument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stolpecDokument.FillWeight = 150F;
            this.stolpecDokument.HeaderText = "Dokument";
            this.stolpecDokument.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.stolpecDokument.MinimumWidth = 150;
            this.stolpecDokument.Name = "stolpecDokument";
            this.stolpecDokument.ReadOnly = true;
            this.stolpecDokument.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stolpecDokument.Width = 150;
            // 
            // govedoBindingSource
            // 
            this.govedoBindingSource.DataMember = "Govedo";
            this.govedoBindingSource.DataSource = this.evidencaGovedaDataSet;
            // 
            // evidencaGovedaDataSet
            // 
            this.evidencaGovedaDataSet.DataSetName = "EvidencaGovedaDataSet";
            this.evidencaGovedaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(325, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iskanje";
            // 
            // textBoxIskanje
            // 
            this.textBoxIskanje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxIskanje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIskanje.Location = new System.Drawing.Point(404, 193);
            this.textBoxIskanje.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxIskanje.MaximumSize = new System.Drawing.Size(800, 35);
            this.textBoxIskanje.Name = "textBoxIskanje";
            this.textBoxIskanje.Size = new System.Drawing.Size(688, 34);
            this.textBoxIskanje.TabIndex = 7;
            this.textBoxIskanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIskanje.TextChanged += new System.EventHandler(this.TextBoxIskanje_TextChanged);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.Green;
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(341, 704);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(121, 58);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.ButtonDodaj_Click);
            // 
            // buttonUredi
            // 
            this.buttonUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUredi.ForeColor = System.Drawing.Color.White;
            this.buttonUredi.Location = new System.Drawing.Point(623, 704);
            this.buttonUredi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(121, 58);
            this.buttonUredi.TabIndex = 10;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = false;
            this.buttonUredi.Click += new System.EventHandler(this.ButtonUredi_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBrisi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonBrisi.ForeColor = System.Drawing.Color.White;
            this.buttonBrisi.Location = new System.Drawing.Point(908, 704);
            this.buttonBrisi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(121, 58);
            this.buttonBrisi.TabIndex = 11;
            this.buttonBrisi.Text = "Izbriši";
            this.buttonBrisi.UseVisualStyleBackColor = false;
            this.buttonBrisi.Click += new System.EventHandler(this.ButtonBrisi_Click);
            // 
            // govedoTableAdapter
            // 
            this.govedoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.stzenske);
            this.panel1.Controls.Add(this.stmoski);
            this.panel1.Controls.Add(this.stzivali);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 657);
            this.panel1.TabIndex = 14;
            // 
            // stzenske
            // 
            this.stzenske.AutoSize = true;
            this.stzenske.ForeColor = System.Drawing.Color.White;
            this.stzenske.Location = new System.Drawing.Point(15, 375);
            this.stzenske.Name = "stzenske";
            this.stzenske.Size = new System.Drawing.Size(120, 28);
            this.stzenske.TabIndex = 6;
            this.stzenske.Text = "Število živali";
            // 
            // stmoski
            // 
            this.stmoski.AutoSize = true;
            this.stmoski.ForeColor = System.Drawing.Color.White;
            this.stmoski.Location = new System.Drawing.Point(15, 268);
            this.stmoski.Name = "stmoski";
            this.stmoski.Size = new System.Drawing.Size(120, 28);
            this.stmoski.TabIndex = 5;
            this.stmoski.Text = "Število živali";
            // 
            // stzivali
            // 
            this.stzivali.AutoSize = true;
            this.stzivali.ForeColor = System.Drawing.Color.White;
            this.stzivali.Location = new System.Drawing.Point(15, 168);
            this.stzivali.Name = "stzivali";
            this.stzivali.Size = new System.Drawing.Size(125, 28);
            this.stzivali.TabIndex = 4;
            this.stzivali.Text = "Število živali ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vse živali";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.ListaGovedaToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ženske živali";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.IzpišiŽenskeToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Moške živali";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.IzpišiMoškeToolStripMenuItem_Click);
            // 
            // buttonProfil
            // 
            this.buttonProfil.AutoSize = true;
            this.buttonProfil.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfil.BackgroundImage")));
            this.buttonProfil.Location = new System.Drawing.Point(1162, 116);
            this.buttonProfil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonProfil.Size = new System.Drawing.Size(59, 56);
            this.buttonProfil.TabIndex = 8;
            this.buttonProfil.UseVisualStyleBackColor = false;
            this.buttonProfil.Click += new System.EventHandler(this.ButtonProfil_Click);
            // 
            // buttonIsci
            // 
            this.buttonIsci.Location = new System.Drawing.Point(0, 0);
            this.buttonIsci.Name = "buttonIsci";
            this.buttonIsci.Size = new System.Drawing.Size(75, 23);
            this.buttonIsci.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 764);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Developer DaRe 2017-18";
            // 
            // labelTabela
            // 
            this.labelTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTabela.AutoSize = true;
            this.labelTabela.BackColor = System.Drawing.Color.Transparent;
            this.labelTabela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTabela.ForeColor = System.Drawing.Color.Green;
            this.labelTabela.Location = new System.Drawing.Point(618, 116);
            this.labelTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTabela.MaximumSize = new System.Drawing.Size(350, 35);
            this.labelTabela.Name = "labelTabela";
            this.labelTabela.Size = new System.Drawing.Size(62, 28);
            this.labelTabela.TabIndex = 13;
            this.labelTabela.Text = "napis";
            this.labelTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.Color.Green;
            this.labelDatum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.ForeColor = System.Drawing.Color.White;
            this.labelDatum.Location = new System.Drawing.Point(1096, 70);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(122, 28);
            this.labelDatum.TabIndex = 20;
            this.labelDatum.Text = "labelDatum";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Glavna
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1283, 753);
            this.ControlBox = false;
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonProfil);
            this.Controls.Add(this.buttonIsci);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTabela);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxIskanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewZivali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonIzhod);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Glavna";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Vodenje evidenc živali";
            this.MaximumSizeChanged += new System.EventHandler(this.ButtonMax_Click);
            this.MinimumSizeChanged += new System.EventHandler(this.ButtonMin_Click);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZivali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govedoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencaGovedaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodIzProgramaToolStripMenuItem;
        private System.Windows.Forms.Button buttonIzhod;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.ToolStripMenuItem natisniToolStripMenuItem;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.ToolStripMenuItem izpišoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstaGovedaToolStripMenuItem;
        private EvidencaGovedaDataSet evidencaGovedaDataSet;
        private EvidencaGovedaDataSetTableAdapters.GovedoTableAdapter govedoTableAdapter;
        private System.Windows.Forms.BindingSource govedoBindingSource;
        public System.Windows.Forms.DataGridView dataGridViewZivali;
        public System.Windows.Forms.TextBox textBoxIskanje;
        private System.Windows.Forms.ToolStripMenuItem mlajšeOdTrehMesecevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medTriInŠestMesecevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medŠestInDvanajstMesecevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medEnimInDrugimLetomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starejšeOdDvehLetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpišiŽenskeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kraveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpišiMoškeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moškiSPotomciToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIsci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecIDzivali;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecSpol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecPasma;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecIDmatere;
        private System.Windows.Forms.DataGridViewTextBoxColumn stolpecIDoceta;
        private System.Windows.Forms.DataGridViewImageColumn stolpecDokument;
        public System.Windows.Forms.Label stzivali;
        public System.Windows.Forms.Label stzenske;
        public System.Windows.Forms.Label stmoski;
        private System.Windows.Forms.Label labelTabela;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Timer timer1;
    }
}