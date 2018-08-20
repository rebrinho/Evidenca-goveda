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
using Project1;

namespace Project1
{
    public partial class Prijava : MetroFramework.Forms.MetroForm
    {
        public Prijava()
        {
            InitializeComponent();
        }
        Uporabnik editprofil = new Uporabnik();
        string connectionstring = "Data Source=DAVID;Initial Catalog=EvidencaGoveda;Integrated Security=True";
        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPrekliči_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int poiskus = 0;
        private void ButtonPrijava_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [EvidencaGoveda].[dbo].[Uporabniki] WHERE Ime='" + textBoxIme.Text + "' AND Geslo='" + textBoxGeslo.Text + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (textBoxIme.Text == "" || textBoxGeslo.Text == "")
            {
                poiskus++;  //šteje poiskuse vnosov gesla
                MetroFramework.MetroMessageBox.Show(this,"Vnosno polje je prazno, prosim vnesite ime in geslo!", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (poiskus >= 3)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Zaradi prekoračitve maksimalnega števila poiskusov, se bo program zasilno zaustavil!", "Prisilna zaustavitev", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (dt.Rows.Count == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Pozdravljeni, uspešno ste se prijavili. Želimo vam prijetno delo!", "Uspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Glavna prva = new Glavna();
                this.Hide();
                prva.Show();
            }

            else
            {
                poiskus++;    //šteje piskuse
                MetroFramework.MetroMessageBox.Show(this,"Uporabnik s tem imenom ne obstaja ali pa je vpisano geslo napačno. Prosim, ponovno vnesite svoje ime in geslo.", "Zavrnjen vstop!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxIme.Clear();
                textBoxGeslo.Clear();   //pobriše vrednost v polju za vnos gesla

                if (poiskus == 3)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Zaradi prekoračitve maksimalnega števila poiskusov se bo program zasilno zaustavil!", "Prisilna zaustavitev", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void ButtonInfo_Click_1(object sender, EventArgs e)
        {
                MessageBox.Show("Za prijavo v program morate vnesti svoje ime in geslo.\n" +
                "Če gesla nimate, ustvarite nov profil s klikom na spodnji desni gumb.", "Pomoč", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonRegistracija_Click_1(object sender, EventArgs e)
        {
            Uporabnik uporabnika = new Uporabnik();
            uporabnika.Show();
        }
    }
}
