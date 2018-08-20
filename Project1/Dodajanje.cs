using Project1;
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
using System.IO;

namespace Project1
{
    public partial class Dodajanje : MetroFramework.Forms.MetroForm
    {
        public Dodajanje()
        {
            InitializeComponent();
        }

       // Glavna posodobiTabelo = new Glavna();      //objekt za delo z metodami iz razreda Glavna

        string imgLocation = "";
        string connectionstring = @"Data Source=DAVID;Initial Catalog=EvidencaGoveda;Integrated Security=True";
        //spremenljivke tipa bool za preverjanje vnosov v polja
        bool kontrolaId = false;
        bool kontrolaIme = false;
        bool kontrolaPasma = false;
        bool kontrolaIdOceta = false;
        bool kontrolaIdMatere = false;
        bool kontrolaSpol = false;
        private void Validacija()   //metoda za preverjanje vnosov
        {
            //preverjanje vnosa Id živali
            if (textBoxIdZivali.Text == "")
            {
                errorProvider1.SetError(textBoxIdZivali, "Vnesite ID živali");
                kontrolaId = false;
            }
            else
            {
                errorProvider1.SetError(textBoxIdZivali, "");
                kontrolaId = true;
            }

            //preverjanje vnosa Ime živali
            if (textBoxImezivali.Text == "")
            {
                errorProvider1.SetError(textBoxImezivali, "Vnesite ime živali");
                kontrolaIme = false;
            }
            else
            {
                errorProvider1.SetError(textBoxImezivali, "");
                kontrolaIme = true;
            }

            //preverjanje izbire spola živali
            if (comboBoxSpol.Text == "")
            {
                errorProvider1.SetError(comboBoxSpol, "Izberite spol živali");
                kontrolaSpol = false;
            }
            else
            {
                errorProvider1.SetError(comboBoxSpol, "");
                kontrolaSpol = true;
            }

            //preverjanje vnosa Pasma živali
            if (comboBoxPasma.Text == "")
            {
                errorProvider1.SetError(comboBoxPasma, "Izberite pasmo živali");
                kontrolaPasma = false;
            }
            else
            {
                errorProvider1.SetError(comboBoxPasma, "");
                kontrolaPasma = true;
            }

            //preverjanje vnosa ID matere
            if (textBoxIdMatere.Text == "")
            {
                errorProvider1.SetError(textBoxIdMatere, "Vnesite ID številko matere");
                kontrolaIdMatere = false;
            }
            else
            {
                errorProvider1.SetError(textBoxIdMatere, "");
                kontrolaIdMatere = true;
            }

            //preverjanje vnosa ID očeta
            if (textBoxIdOceta.Text == "")
            {
                errorProvider1.SetError(textBoxIdOceta, "Vnesite ID številko očeta");
                kontrolaIdOceta = false;
            }
            else
            {
                errorProvider1.SetError(textBoxIdOceta, "");
                kontrolaIdOceta = true;
            }
        }

        public void ButtonPoisci_Click(object sender, EventArgs e)     //preverjanje dokumenta
        {
            try
            {   //odpremo dialog za odprtje datoteke

                OpenFileDialog dokument = new OpenFileDialog
                {
                    Title = "Izberite željen dokument"
                };

                if (dokument.ShowDialog() == DialogResult.OK)
                {   //shranimo datoteko v spremenljivko slika
                    Image slika = Image.FromFile(dokument.FileName);
                    pictureBox.Image = slika;   //slika prikažemo na pictureBox-u
                    imgLocation = dokument.FileName.ToString();
                    pictureBox.ImageLocation = imgLocation;
                }
                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(Stream);
                images = br.ReadBytes((int)Stream.Length);

            }
            catch
            {   //če odpiranje datoteke ne uspe, vrne napako
                MessageBox.Show("Napaka pri odpiranju datoteke!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pobrisi()      //metoda za pobris vnosnih polj
        {
            textBoxIdZivali.Clear();
            textBoxImezivali.Clear();
            dateTimePickerRojstvo.ResetText();
            comboBoxSpol.Refresh();
            comboBoxPasma.Refresh();
            textBoxIdMatere.Clear();
            textBoxIdOceta.Clear();
            pictureBox.Image = null;
        }

        public bool IfGovedoExits(SqlConnection sqlConnection, string ID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT 1 FROM Govedo WHERE [ID]= '"+ ID +"'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void Shrani()     //če je pri preverjanju vse ok, potem vpraša po nadaljevanju
        {
            Glavna posodobiTabelo = new Glavna();
            // Validacija();
            if ((kontrolaId = true) && (kontrolaIme = true) && (kontrolaPasma = true) && (kontrolaIdMatere = true) && (kontrolaIdOceta = true))
            {  
                using(SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {    
                    var sqlquery = "";
                    if (IfGovedoExits(sqlConnection, textBox1.Text))
                    {
                        sqlquery = @"UPDATE [dbo].[Govedo]
                                        SET [IDzivali] = @IDzivali,[Imezivali] = @Imezivali,[Datumrojstva] = @Datumrojstva,[Spol] = @Spol,[Pasma] = @Pasma,[IDmatere] = @IDmatere,[IDoceta] = IDoceta,[Dokument] = @Dokument WHERE [ID] ='" + textBox1.Text + "'";
                    }
                    else
                    {
                        sqlquery = @"INSERT INTO Govedo (IDzivali, Imezivali, Datumrojstva, Spol, Pasma, IDmatere, IDoceta, Dokument) VALUES (@IDzivali,@Imezivali,@Datumrojstva,@Spol,@Pasma,@IDmatere,@IDoceta,@Dokument)";
                    }

                    byte[] images = null;
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(Stream);
                    images = br.ReadBytes((int)Stream.Length);

                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Govedo", sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    SqlCommand sqlCmd = new SqlCommand(sqlquery, sqlConnection);
                    //  sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@IDzivali", textBoxIdZivali.Text);
                        sqlCmd.Parameters.AddWithValue("@Imezivali", textBoxImezivali.Text);
                        sqlCmd.Parameters.AddWithValue("@Datumrojstva", SqlDbType.Date).Value = dateTimePickerRojstvo.Value.Date;   //dateTimePickerRojstvo.Value.ToString("dd/MM/yyyy"));
                        sqlCmd.Parameters.AddWithValue("@Spol", comboBoxSpol.Text);
                        sqlCmd.Parameters.AddWithValue("@Pasma", comboBoxPasma.Text);
                        sqlCmd.Parameters.AddWithValue("@IDmatere", textBoxIdMatere.Text);
                        sqlCmd.Parameters.AddWithValue("@IDoceta", textBoxIdOceta.Text);
                        sqlCmd.Parameters.AddWithValue("@Dokument", images);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodajanje nove živali je bilo uspešno");
                        Pobrisi();  //po uspešnem dodajanju pobrišemo vrednosti polj

                    //Branje podatkov neposredno po shranjevanju
                    //še ne štima nekaj, ne posodobi pred klikom za izpis tabele....
                    adapter.Update(dt);
                    sqlConnection.Close();
                    posodobiTabelo.PrikazTabele();

                    //vprašalni dialog po nadaljevanju dodajanja
                    if (MessageBox.Show("Ali želite dodati več živali?", "Želite nadaljevati...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        //shranimo vnesene podatke v bazo
                        this.Close();  //in zapremo okno  
                    }
                }
                
             //   Glavna posodobiTabelo = new Glavna();   //posodobimo tabelo na glavni strani
                posodobiTabelo.dataGridViewZivali.Refresh();
                posodobiTabelo.PrikazTabele();  //ne posodobi avtomatsko..... ????
                posodobiTabelo.Stetje();
            }
            else
            {   //pobrišemo vsa vnosna polja
                Pobrisi();
            }
        }

        private void Preklici_Click(object sender, EventArgs e)
        {   //gumb prekliči zapre okno za dodajanje
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {   //gumbek x na vrhu okna zapre okno za dodajanje
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {   //gumb Pobriši pobriše vse vnose v poljih
                Pobrisi();
        }

        private void Shrani_Click(object sender, EventArgs e)
        {   //gumb shrani sproži,
            Glavna posodobiTabelo = new Glavna();
            Validacija();   //preveri vnose z validacijo
            if ((kontrolaId=true) && (kontrolaIme=true) && (kontrolaPasma=true) && (kontrolaSpol=true) && (kontrolaIdMatere=true) && (kontrolaIdOceta=true))
            {
                Shrani();     //če je forma prestala validacijo metoda shrani podatke in vrne dialog z vprašanjem
              //  posodobiTabelo.dataGridViewZivali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               // posodobiTabelo.dataGridViewZivali.RowTemplate.Height = 100;
              //  posodobiTabelo.dataGridViewZivali.Refresh();
                posodobiTabelo.PrikazTabele();  //zakaj ne posodobi avtomatsko..... ????
                posodobiTabelo.Stetje();        //tudi tega ne posodobi avtomatsko....
            }
            else
            {
                Validacija();   //ponovno preverjanje vnosa podatkov
            }
        }
    }
}
