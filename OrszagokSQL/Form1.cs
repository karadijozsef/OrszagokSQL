using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrszagokSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `id`,`orszag`,`fovaros`,`terulet`,`nepesseg`,`allamforma` FROM `orszagok` WHERE 1";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Orszag orszag = new Orszag(dr.GetInt32("id"), dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetDouble("terulet"), dr.GetDouble("nepesseg"), dr.GetString("allamforma"));
                        listBox_Orszagok.Items.Add(orszag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
                
            }
        }

        private void listBox_Orszagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Orszagok.SelectedIndex < 0)
            {
                return;
            }
            Orszag kivalasztottOrszag = (Orszag) listBox_Orszagok.SelectedItem;
            textBox_id.Text = kivalasztottOrszag.Id.ToString();
            textBox_orsz.Text = kivalasztottOrszag.OrszagNev;
            textBox_fov.Text = kivalasztottOrszag.Allamforma;
            textBox_ter.Text = kivalasztottOrszag.Fovaros;
            textBox_nep.Text = kivalasztottOrszag.Nepesseg.ToString("#,##0");
            textBox_allam.Text = kivalasztottOrszag.Terulet.ToString("#,##0");

        }
    }
}
