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

namespace Project1
{
    public partial class Uporabnik : MetroFramework.Forms.MetroForm
    {
        string connectionstring = @"Data Source=DAVID;Initial Catalog=EvidencaGoveda;Integrated Security=True";
        public Uporabnik()
        {
            InitializeComponent();

        }

        public bool buttonClicked = false;      //če je gumb shrani pritisnjen ali ne-privzeto na false

        bool kontrolaIme = false;
        bool kontrolaPriimek = false;
        bool kontrolaUporabniškoGeslo = false;

        private void Validacija()   //metoda za preverjanje vnosov
        {
            //preverjanje vnosa Ime osebe
            if (textBoxIme.Text == "")
            {
                errorProvider1.SetError(textBoxIme, "Vnesite svoje ime");
                kontrolaIme = false;
            }
            else
            {
                errorProvider1.SetError(textBoxIme, "");
                kontrolaIme = true;
            }
            //preverjanje vnosa Priimka osebe
            if (textBoxPriimek.Text == "")
            {
                errorProvider1.SetError(textBoxPriimek, "Vnesite svoj priimek");
                kontrolaPriimek = false;
            }
            else
            {
                errorProvider1.SetError(textBoxPriimek, "");
                kontrolaPriimek = true;
            }
            //preverjanje vnosa uporabniškega gesla
            if (textBoxGeslo.Text == "")
            {
                errorProvider1.SetError(textBoxGeslo, "Vnesite željeno geslo");
                kontrolaUporabniškoGeslo = false;
            }
            else
            {
                errorProvider1.SetError(textBoxGeslo, "");
                kontrolaUporabniškoGeslo = true;
            }
        }
        private void ValidateForm()
        {
            if (kontrolaIme=true && (kontrolaPriimek=true) && (kontrolaUporabniškoGeslo=true))
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    sqlConnection.Open();
                    string sqlquery = "INSERT INTO Uporabniki (Ime, Priimek, Geslo) VALUES (@Ime,@Priimek,@Geslo)";

                    SqlCommand sqlCmd = new SqlCommand(sqlquery, sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Ime", textBoxIme.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Priimek", textBoxPriimek.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Geslo", textBoxGeslo.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registracija novega uporabnika je bila uspešna");
                    Pobrisi();  //po uspešni registraciji pobrišemo vrednosti polj
                }
                if (MessageBox.Show("Ali želite zaključiti dodajanje?", "Želite nadaljevati...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                      DialogResult.Yes)
                {
                    Close();  //in zapremo okno  
                }
            }
            else
            {
                Pobrisi();
            }
        }
        private void ButtonPreklici_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Pobrisi()
        {
            textBoxIme.Clear();
            textBoxPriimek.Clear();
            textBoxGeslo.Clear();
        }
        private void ButtonPobrisi_Click(object sender, EventArgs e)
        {
            Pobrisi();
        }

        private void ButtonShrani_Click(object sender, EventArgs e)
        {
                buttonClicked = true;
                Validacija();   //preverjanje vnosov z validacijo
                ValidateForm(); //dialogno okno, če si uporabnik premisli
        }
    }
}
