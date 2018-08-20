using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;
using Dapper;

namespace Project1
{
    public partial class Glavna : MetroFramework.Forms.MetroForm
    {
        public Glavna()
        {
            InitializeComponent();
            timer1.Start();
        }

        Dodajanje dodaj = new Dodajanje();          //Forma iz  dodajanja tudi za urejanje goveda
        Prijava logedUser = new Prijava();
        Uporabnik editprofil = new Uporabnik();

        string connectionstring = @"Data Source=DAVID;Initial Catalog=EvidencaGoveda;Integrated Security=True";
        string imgLocation = "";
        private void IzhodIzProgramaToolStripMenuItem_Click(object sender, EventArgs e) //izhod v orodni vrstici
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Ali ste prepričani, da želite zapustiti program?", "Izhod iz programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Nasvidenje, želimo vam lep dan.");
                Application.Exit(); //kličemo metodo za zaprtje celotne aplikacije
            }
        }

        // orodna vrstica, dogodki gumbov za zapiranje, minimiziranje in maksimiziranje okna  
        private void ButtonIzhod_Click(object sender, EventArgs e)  //ob kliku gumb ButtonIzhod
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Ali ste prepričani, da želite zapustiti program?","Izhod iz programa", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Nasvidenje, želimo vam lep dan.");
                Application.Exit(); //kličemo metodo za zaprtje celotne aplikacije
            }
        }

        private void ButtonMin_Click(object sender, EventArgs e)    //ob kliku gumba ButtonMin
        {
            WindowState = FormWindowState.Minimized;    //kličemo metodo za minimiziranje okna
        }

        private void ButtonMax_Click(object sender, EventArgs e)    //ob kliku na gumb ButtonMax
        {
            WindowState = FormWindowState.Maximized;    //kličemo metodo za maksimiziranje okna
        }

        private void GovedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodaj.Show();       //prikažemo okno dodaj
        }

        private void PrikaziUpo()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT 1 FROM Uporabniki", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
       
          //  if (dt.Rows.Count == 1)
          
            foreach (DataRow item in dt.Rows)   //sprehodimo se skozi vrstice z vsemi podatki iz podatkovne baze
            {
                editprofil.textBoxID.Text = item["ID"].ToString();
                editprofil.textBoxIme.Text = item["Ime"].ToString();
                editprofil.textBoxPriimek.Text = item["Priimek"].ToString();
                editprofil.textBoxGeslo.Text = item["Geslo"].ToString();
            }
            conn.Close();
        }
        
        private void ButtonProfil_Click(object sender, EventArgs e) //ob kliku na gumb 
        {
            Uporabnik editprofil = new Uporabnik();     //ustvarimo novi objekt za urejanje uporabnika
            Prijava logedUser = new Prijava();          //in še za ugotavljanje prijavljenega uporabnik
            editprofil.Text = "Urejanje profila";

            editprofil.Show();      //prikažemo okno s podatki uporabnika
            PrikaziUpo();           //klic metode za branje podatkov trenutnega iz baze

            if (editprofil.buttonClicked)
            {
                if ((MetroFramework.MetroMessageBox.Show(this,"Ali ste prepričani, da želite shraniti nove podatke?", "Želite nadaljevati...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes))
                {
                    try
                    {
                        //metoda z poizvedbo za posodabljanje podatkov v podatkovni bazi
                        using (SqlConnection povezi = new SqlConnection(connectionstring))  //povezava
                        {
                            povezi.Open();
                            string poizvedba = "UPDATE Uporabniki SET Ime=@Ime,Priimek=@Priimek,Geslo=@Geslo WHERE ID=@Id";     //sql poizvedba
                            SqlCommand comm = new SqlCommand(poizvedba, povezi);
                            comm.Parameters.Add(new SqlParameter("@Id", editprofil.textBoxID.SelectedText));
                            comm.Parameters.Add(new SqlParameter("@Ime", editprofil.textBoxIme.SelectedText));      //textBox v @Ime 
                            comm.Parameters.Add(new SqlParameter("@Priimek", editprofil.textBoxPriimek.SelectedText));  //textBox v @Priimek
                            comm.Parameters.Add(new SqlParameter("@Geslo", editprofil.textBoxGeslo.SelectedText));      //textBox v @Geslo
                            comm.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Napaka pri shranjevanju novih podatkov uporabnika!");  //javi napako v primeru neuspešne posodobitve podatkov
                    }
                }
                else
                {
                    editprofil.textBoxIme.Focus();      //fokusira pogled na textBox za vnos imena
                }
            }
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            Dodajanje dodaj = new Dodajanje();
            dodaj.Text = "Dodajanje novih živali";
            dodaj.Show();
        }

        public void PrikazTabele()
        {
            labelTabela.Text = "VSE ŽIVALI";
            string poizvedba = "SELECT * FROM Govedo";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();
            dataGridViewZivali.RowTemplate.Height = 100;

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {
                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            sqlConnection.Close();
            labelTabela.Text = "VSE ŽIVALI: " + stetje.ToString();
        }

        private void Glavna_Load(object sender, EventArgs e)    //dogodeki ob odpiranju glavnega okna
        {

            Stetje();           //metoda vrne vrednosti seštevkov vseh živali, moških in žensk
            PrikazTabele();     //prikaže tabelo s podatki iz baze
        }

        private void ListaGovedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //posodobitev podatkov, ponoven izpis istih podatkov na isto mesto oz prepis starih
            dataGridViewZivali.Refresh();
            PrikazTabele();
        }

        public void ButtonUredi_Click(object sender, EventArgs e)      //klic urejanja podatkov----
        {
            /*
                Če je označena vrstica potem omogoči urejanje, če ne javi napako ali disabled gumb za urejanje
            */
                Dodajanje dodaj = new Dodajanje();
                dodaj.Text = "Urejanje podatkov goveda";

                dodaj.textBox1.SelectedText = dataGridViewZivali.CurrentRow.Cells[0].Value.ToString();
                dodaj.textBoxIdZivali.SelectedText = dataGridViewZivali.CurrentRow.Cells[1].Value.ToString();
                dodaj.textBoxImezivali.SelectedText = dataGridViewZivali.CurrentRow.Cells[2].Value.ToString();
                dodaj.dateTimePickerRojstvo.Value = Convert.ToDateTime(dataGridViewZivali.CurrentRow.Cells[3].Value);
                dodaj.comboBoxSpol.Text = dataGridViewZivali.CurrentRow.Cells[4].Value.ToString();
                dodaj.comboBoxPasma.Text = dataGridViewZivali.CurrentRow.Cells[5].Value.ToString();
                dodaj.textBoxIdMatere.SelectedText = dataGridViewZivali.CurrentRow.Cells[6].Value.ToString();
                dodaj.textBoxIdOceta.SelectedText = dataGridViewZivali.CurrentRow.Cells[7].Value.ToString();
                //za prikaz slike v pictureBox iz data
                var img = (byte[])(dataGridViewZivali.CurrentRow.Cells[8].Value);
                MemoryStream stream = new MemoryStream(img);
                dodaj.pictureBox.Image = Image.FromStream(stream);  //za prikaz slike v pictureBox iz data

                dodaj.Show();

                try
                {
                    //napisati IF stavek, če izberemo gumb "Poišči datoteko" potem se izvede nasledneje:
                    byte[] image = null;
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(Stream);
                    image = br.ReadBytes((int)Stream.Length);

                    //else (drugače) shranimo ponovno isto sliko, ki je prišla iz baze
                /*
                        var image?;
                        ()
                        MemoryStream strim = new MemoryStream(slika);
                        image = 
                */
                    using (SqlConnection povezi = new SqlConnection(connectionstring))
                    {
                        povezi.Open();
                        string poizvedba = "UPDATE Govedo SET IDzivali=@IDzivali,Imezivali=@Imezivali,Datumrojstva=@Datumrojstva,Spol=@Spol,Pasma=@Pasma,IDmatere=@IDmatere,IDoceta=@IDoceta,Dokument=@Dokument WHERE ID=@ID";
                        SqlCommand cmd = new SqlCommand(poizvedba, povezi);
                        cmd.Parameters.Add(new SqlParameter("@IDzivali", dodaj.textBoxIdZivali.Text));
                        cmd.Parameters.Add(new SqlParameter("@Imezivali", dodaj.textBoxImezivali.Text));
                        cmd.Parameters.Add(new SqlParameter("@Datumrojstva", SqlDbType.Date).Value = dodaj.dateTimePickerRojstvo.Value.Date);
                        cmd.Parameters.Add(new SqlParameter("@Spol", dodaj.comboBoxSpol.Text));
                        cmd.Parameters.Add(new SqlParameter("@Pasma", dodaj.comboBoxPasma.Text));
                        cmd.Parameters.Add(new SqlParameter("@IDmatere", dodaj.textBoxIdMatere.Text));
                        cmd.Parameters.Add(new SqlParameter("@IDoceta", dodaj.textBoxIdOceta.Text));
                        //      cmd.Parameters.Add(new SqlParameter("@Dokument", image));
                        cmd.ExecuteNonQuery();

                        povezi.Close();
                    PrikazTabele();     //posodabljanje tabele
                    }
                }
                catch
                {
                   MetroFramework.MetroMessageBox.Show(this, "Napaka pri shranjevanju novih podatkov živali!");
                }
        }

        private void Shrani_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(Stream);
                image = br.ReadBytes((int)Stream.Length);
                using (SqlConnection povezi = new SqlConnection(connectionstring))
                {
                    povezi.Open();
                    string poizvedba = "UPDATE Govedo SET IDzivali=@IDzivali,Imezivali=@Imezivali,Datumrojstva=@Datumrojstva,Spol=@Spol,Pasma=@Pasma,IDmatere=@IDmatere,IDoceta=@IDoceta,Dokument=@Dokument WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(poizvedba, povezi);
                    cmd.Parameters.Add(new SqlParameter("@IDzivali", dodaj.textBoxIdZivali.Text));
                    cmd.Parameters.Add(new SqlParameter("@Imezivali", dodaj.textBoxImezivali.Text));
                    cmd.Parameters.Add(new SqlParameter("@Datumrojstva", SqlDbType.Date).Value = dodaj.dateTimePickerRojstvo.Value.Date);
                    cmd.Parameters.Add(new SqlParameter("@Spol", dodaj.comboBoxSpol.Text));
                    cmd.Parameters.Add(new SqlParameter("@Pasma", dodaj.comboBoxPasma.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDmatere", dodaj.textBoxIdMatere.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDoceta", dodaj.textBoxIdOceta.Text));
                    cmd.Parameters.Add(new SqlParameter("@Dokument", image));
                    cmd.ExecuteNonQuery();

                    povezi.Close();
                    PrikazTabele();     //prikaže tabelo
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Napaka pri shranjevanju novih podatkov živali!");
            }
            //dataGridViewZivali.Refresh();   //posodobi tabelo
        }
        public bool IfGovedoExits(SqlConnection sqlConnection, string ID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT 1 FROM Govedo WHERE [ID]= '" + ID + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void ButtonBrisi_Click(object sender, EventArgs e)      ///dogodok ob kliku na gumb Briši
        {
            //če je vrstica v tabeli izbrana, potem omogoči brisanje izbrane vrsice, drugače javi napako
            //ali disabled gumb Izbriši

            if (MessageBox.Show("Ste prepričani, da želite izbrisati izbrano vrstico?",
                "Brisanje vrstice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)      //dodatno vprašanje
            {
                try
                {
                    int zaporedna = Convert.ToInt32(dataGridViewZivali.CurrentRow.Cells[0].Value);
                    using (SqlConnection povezava = new SqlConnection(connectionstring))
                    {
                        povezava.Open();
                        string poizvedba = "DELETE FROM Govedo WHERE ID=@ID";
                        using (SqlCommand cmd = new SqlCommand(poizvedba, povezava))
                        {
                            cmd.Parameters.Add(new SqlParameter("@ID", zaporedna));
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Napaka pri brisanju izbrane vrstice!");
                }
                PrikazTabele();     //prikaže posodobljenotabelo
                Stetje();
            }
        }
        public void Izbran(int vrstica)     //označi izbrano vrstico
        {
            try
            {
                if (vrstica == -1)      //če je vrstica -1, ker 0 je že prvo polje v katerem so podatki
                    vrstica = 0;
                dataGridViewZivali.ClearSelection();
                dataGridViewZivali.FirstDisplayedScrollingColumnIndex = vrstica;
                dataGridViewZivali.Rows[vrstica].Selected = true;
                dataGridViewZivali.CurrentCell = dataGridViewZivali.Rows[vrstica].Cells[1];
            }
            catch
            {
                dataGridViewZivali.Rows[1].Selected = true;
                dataGridViewZivali.CurrentCell = dataGridViewZivali.Rows[1].Cells[1];
            }
        }

        private void IzpišiŽenskeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "ŽENSKE ŽIVALI";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Govedo WHERE Spol='ženski'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;     //spremenljivka za štetje vrstic
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;   //ob vsakem sprehodu čez zanko povečamo števec za 1
            }
            labelTabela.Text = "ŽENSKE ŽIVALI: " + stetje.ToString();
        }

        private void IzpišiMoškeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "MOŠKE ŽIVALI";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Govedo WHERE Spol='moški'", sqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "MOŠKE ŽIVALI: " + stetje.ToString();
        }

        private void MlajšeOdTrehMesecevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "ŽIVALI MLAJŠE OD 3 MESECEV ";
            string poizvedba = "SELECT * FROM [EvidencaGoveda].[dbo].[Govedo] WHERE Datumrojstva > DATEADD(MONTH, -3, CAST(GETDATE() AS DATE))";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "ŽIVALI MLAJŠE OD 3 MESECEV: " + stetje.ToString();
        }

        private void MedTriInŠestMesecevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "ŽIVALI STARE MED 3 IN 6 MESECEV";
            string poizvedba = "SELECT * FROM [EvidencaGoveda].[dbo].[Govedo] WHERE Datumrojstva < DATEADD(MONTH, -3, CAST(GETDATE() AS DATE)) " +
                "AND Datumrojstva > DATEADD(MONTH, -6, CAST(GETDATE() AS DATE))";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "ŽIVALI STARE MED 3 IN 6 MESECEV: " + stetje.ToString();
        }

        private void MedŠestInDvanajstMesecevToolStripMenuItem_Click(object sender, EventArgs e)
        {

            labelTabela.Text = "ŽIVALI STARE MED 6 IN 12 MESECEV";
            string poizvedba = "SELECT * FROM [EvidencaGoveda].[dbo].[Govedo] WHERE Datumrojstva < DATEADD(MONTH, -6, CAST(GETDATE() AS DATE)) " +
                "AND Datumrojstva > DATEADD(MONTH, -12, CAST(GETDATE() AS DATE))";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba,sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "ŽIVALI STARE MED 6 IN 12 MESECEV: " + stetje.ToString();
        }

        private void MedEnimInDrugimLetomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "ŽIVALI STARE MED 1 IN 2 LETOM";
            string poizvedba = "SELECT * FROM [EvidencaGoveda].[dbo].[Govedo] WHERE Datumrojstva < DATEADD(YEAR, -1, CAST(GETDATE() AS DATE)) " +
                "AND Datumrojstva > DATEADD(YEAR, -2, CAST(GETDATE() AS DATE))";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {

                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "ŽIVALI STARE MED 1 IN 2 LETOM: " + stetje.ToString();
        }

        private void StarejšeOdDvehLetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTabela.Text = "ŽIVALI STAREJŠE OD 2 LET";
            string poizvedba = "SELECT * FROM [EvidencaGoveda].[dbo].[Govedo] WHERE Datumrojstva < DATEADD(YEAR, -2, CAST(GETDATE() AS DATE))";
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(poizvedba, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewZivali.Rows.Clear();

            int stetje = 0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi podatki iz podatkovne baze
            {
                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stetje++;
            }
            labelTabela.Text = "ŽIVALI STAREJŠE OD 2 LET: " + stetje.ToString();
        }

        public void ŠtetjeVseh()
        {
            string poizvedba;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();

            //naredi z if stavkom pogoje, katera sql poizvedba naj se izvede,
            //glede na to kateri text je bil kliknjen...

            poizvedba = "SELECT * FROM Govedo";

            SqlCommand komanda = new SqlCommand(poizvedba, sqlConnection);
            SqlDataReader branje = komanda.ExecuteReader();

            int stevec = 0;             //števec, ki šteje vse živali

            while (branje.Read())       //ponavljamo branje dokler so zapisi
            {
                stevec++;           //in vmes vsakokrat povečamo števec za 1
            }
            stzivali.Text = "Število vseh živali: " + stevec.ToString();      //izpis vrednosti števca v label

            branje.Close();
            sqlConnection.Close();
        }

        public void ŠtetjeMoških()
        {
            string poizvedba;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();

            poizvedba = "SELECT * FROM Govedo WHERE Spol='moški'";

            SqlCommand komanda = new SqlCommand(poizvedba, sqlConnection);
            SqlDataReader branje = komanda.ExecuteReader();

            int stevecmoski = 0;             //števec, ki šteje moške

            while (branje.Read())       //ponavljamo branje dokler so zapisi
            {
                stevecmoski++;           //in vmes vsakokrat povečamo števec za 1
            }
            stmoski.Text = "Število moških živali: " + stevecmoski.ToString();      //izpis vrednosti števca v label
            branje.Close();
            sqlConnection.Close();
        }
        
        public void ŠtetjeŽensk()
        {
            string poizvedba;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();

            poizvedba = "SELECT * FROM Govedo WHERE Spol='ženski'";

            SqlCommand komanda = new SqlCommand(poizvedba, sqlConnection);
            SqlDataReader branje = komanda.ExecuteReader();

            int steveczenske = 0;             //števec, ki šteje ženske

            while (branje.Read())       //ponavljamo branje dokler so zapisi
            {
                steveczenske++;           //in vmes vsakokrat povečamo števec za 1
            }

            stzenske.Text = "Število ženskih živali: " + steveczenske.ToString();      //izpis vrednosti števca v label
            branje.Close();
            sqlConnection.Close();
        }

        public void Stetje()       //metoda za štetje zapisov v podatkovni bazi
        {
            //v metodi štetje bi rad imel samo sprehod po bazi in štetje posameznih vrstic,
            //glede na poizvedbo, ali vse ali samo moški ali samo ženske, ali po starosti...
            //if (click label stvse) then poizvedba="SELECT * FROM Govedo";
            ŠtetjeVseh();           //klic metode za preštevanje vseh živali
            ŠtetjeMoških();         //klic metode s katero preštejemo vse moške
            ŠtetjeŽensk();          //klic metode s katero preštejemo vse ženske
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;
            this.labelDatum.Text = datum.ToString();
        }

        //iskanje s pomočjo SQL poizvedbe po bazi
        private void TextBoxIskanje_TextChanged(object sender, EventArgs e)
        {
          //  string poizvedba;

            SqlConnection povezava = new SqlConnection(connectionstring);
            povezava.Open();
           // poizvedba = ("SELECT * FROM Govedo WHERE LIKE '" + textBoxIskanje.Text + "%'", povezava);
           //za iskanje po datumu... format datuma v podatkovni bazi je 2018-03-19!!!
            SqlCommand komanda = new SqlCommand("SELECT * FROM Govedo WHERE ImeZivali LIKE '" + textBoxIskanje.Text + "%' OR ID LIKE '"+ textBoxIskanje.Text + "%' OR IDzivali LIKE '"
                + textBoxIskanje.Text + "%' OR IDoceta LIKE '" + textBoxIskanje.Text + "%' OR IDmatere LIKE '" + textBoxIskanje.Text + "%' OR Datumrojstva LIKE '" + textBoxIskanje.Text + "%'", povezava);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewZivali.Rows.Clear();
            //dataGridViewZivali.DataSource = dt;
            int stevec=0;
            foreach (DataRow item in dt.Rows)   //napolnimo tabelo dataGridViewZivali z vsemi iskanimi podatki iz podatkovne baze
            {
                int n = dataGridViewZivali.Rows.Add();
                dataGridViewZivali.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridViewZivali.Rows[n].Cells[1].Value = item["IDzivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[2].Value = item["Imezivali"].ToString();
                dataGridViewZivali.Rows[n].Cells[3].Value = item["Datumrojstva"].ToString();
                dataGridViewZivali.Rows[n].Cells[4].Value = item["Spol"].ToString();
                dataGridViewZivali.Rows[n].Cells[5].Value = item["Pasma"].ToString();
                dataGridViewZivali.Rows[n].Cells[6].Value = item["IDmatere"].ToString();
                dataGridViewZivali.Rows[n].Cells[7].Value = item["IDoceta"].ToString();
                dataGridViewZivali.Rows[n].Cells[8].Value = item["Dokument"];

                stevec++;
                if (n < 1)
                {
                    labelTabela.Text = "Ne najdem iskanih podatkov";
                }
            }
            labelTabela.Text = "Trenutno število živali v tabeli: " + stevec.ToString();
        }
    }
}
