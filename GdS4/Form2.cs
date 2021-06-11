using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GdS4
{
    public partial class Form2 : Form
    {
       
        
        Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        string truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
        
        


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxAdServ.Text = ConfigurationManager.AppSettings["adServ"];
            textBoxBdNom.Text = ConfigurationManager.AppSettings["bdnom"];
            textBoxPasseword.Text = ConfigurationManager.AppSettings["motDePasse"];
            textBoxPort.Text = ConfigurationManager.AppSettings["port"];
            textBoxUID.Text = ConfigurationManager.AppSettings["uid"];
            _ListerMarque();
            remplirSelectTable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifConnectSetting();
            _creeTablefonctionnement();
            _ListerMarque();
            remplirSelectTable();
            
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void bouttonAjMarque_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();
                MySqlCommand ajoutMarque = new MySqlCommand("insert into marque(nmarque) values(@nmarque)", conn);
                ajoutMarque.Parameters.AddWithValue("@nmarque", textBoxMM.Text);
                ajoutMarque.ExecuteNonQuery();
                ajoutMarque.Parameters.Clear();
                textBoxMM.Clear();
                _ListerMarque();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                
            }
            
           
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(truc);

            try
            {
                conn.Open();
                MySqlCommand ajoutModel = new MySqlCommand("insert into model(nummod,marque) values(@nummod,@marque)", conn);
                ajoutModel.Parameters.AddWithValue("@nummod", textBoxAddMod.Text);
                ajoutModel.Parameters.AddWithValue("@marque", comboBoxModMarque.Text);
                ajoutModel.ExecuteNonQuery();
                ajoutModel.Parameters.Clear();
                textBoxAddMod.Clear();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");

            }
            
        }
        private void _ListerMarque()
        {
            comboBoxModMarque.Items.Clear();
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand lireBdd = new MySqlCommand("SELECT * FROM marque", conn);

            conn.Open();
            MySqlDataReader dataR = lireBdd.ExecuteReader();
            while (dataR.Read())
            {
                comboBoxModMarque.Items.Add(dataR["nmarque"]);
            }

            conn.Close();
        }

        private void comboBoxModMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAddMod.Enabled = true;
        }

        private void textBoxAddMod_TextChanged(object sender, EventArgs e)
        {
            buttonAddModel.Enabled = true;
        }
        private void CreationDeTable(string nomDeTable)
        {
            MySqlConnection conn = new MySqlConnection(truc);
            
            if(nomDeTable == "")
            {
                MessageBox.Show("Vous devez nommer la Table.");
                return;
            }
           
            try
            {
                conn.Open();
            
                MySqlCommand Table = new MySqlCommand ("CREATE TABLE IF NOT EXISTS `" + nomDeTable + "`(`id` INT AUTO_INCREMENT ,`Date` DATE NOT NULL,`numSeri` varchar(100) NOT NULL," +
                    "`marque` varchar(100) NOT NULL, `model` varchar(100) NOT NULL, PRIMARY KEY(`id`)) COLLATE=`utf8_general_ci` ENGINE=InnoDB;", conn);
                Table.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans l'ajout de table.\n" + ex);
            }
            
        }
        private bool rechercheTable(string nomEntrer)
        {
            bool trouver = false;
            MySqlConnection conn = new MySqlConnection(truc);

            conn.Open();
            MySqlCommand realTable = new MySqlCommand("Show tables from " + ConfigurationManager.AppSettings["bdnom"], conn);
            MySqlDataReader dataR = realTable.ExecuteReader();
            while (dataR.Read())
            {
                if (nomEntrer == dataR.GetString(0))
                    trouver = true;
            }
            conn.Close();

            return trouver;
        }
        private void remplirSelectTable()
        {
            int parDefautTable = 0;
            try
            {
                parDefautTable = int.Parse(ConfigurationManager.AppSettings["tableActive"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur config table par défaut.");
            }
            comboxSelectTable.Items.Clear();
            MySqlConnection conn = new MySqlConnection(truc);

            conn.Open();
            MySqlCommand realTable = new MySqlCommand("Show tables from "+ ConfigurationManager.AppSettings["bdnom"], conn);
            MySqlDataReader dataR = realTable.ExecuteReader();
            while (dataR.Read())
            {
                if (dataR.GetString(0) != "model" && dataR.GetString(0) != "marque")
                    comboxSelectTable.Items.Add(dataR.GetString(0));
            }
            nombreTableVerif(comboxSelectTable.Items.Count);
            try
            {
                comboxSelectTable.SelectedIndex = parDefautTable;
            }
            catch
            {

            }
            conn.Close();
        }

        private void AjoutDeTable_Click(object sender, EventArgs e)
        {
            if(!rechercheTable(textBoxNewTable.Text))
            { 
                CreationDeTable(textBoxNewTable.Text);
                textBoxNewTable.Clear();
                remplirSelectTable();
            }
            else
            {
                MessageBox.Show("Cette Table existe déjà.");
            }
                
        }

        private void buttonSelectTable_Click(object sender, EventArgs e)
        {
            conf.AppSettings.Settings.Remove("tableActive");
            conf.AppSettings.Settings.Add("tableActive", comboxSelectTable.SelectedIndex.ToString());
            conf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void buttonVideTable_Click(object sender, EventArgs e)
        {
            ViderTable();
        }
        private void ViderTable()
        { 
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand Vidage = new MySqlCommand("TRUNCATE table " + comboxSelectTable.Text, conn);
            conn.Open();
            Vidage.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("La Contenu de la table a été supprimé.");
        }
        private void buttonSupprTable_Click(object sender, EventArgs e)
        {
            SupprTable();
        }
        private void SupprTable()
        {
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand SuppT = new MySqlCommand("DROP table `" + comboxSelectTable.Text+"`", conn);
            conn.Open();
            SuppT.ExecuteNonQuery();
            conn.Close();
            remplirSelectTable();
            MessageBox.Show("Table supprimée.");
        }
        private void ModifConnectSetting()
        {
            conf.AppSettings.Settings.Remove("adServ");
            conf.AppSettings.Settings.Add("adServ", textBoxAdServ.Text);
            conf.AppSettings.Settings.Remove("motDePasse");
            conf.AppSettings.Settings.Add("motDePasse", textBoxPasseword.Text);
            conf.AppSettings.Settings.Remove("bdnom");
            conf.AppSettings.Settings.Add("bdnom", textBoxBdNom.Text);
            conf.AppSettings.Settings.Remove("uid");
            conf.AppSettings.Settings.Add("uid", textBoxUID.Text);
            conf.AppSettings.Settings.Remove("port");
            conf.AppSettings.Settings.Add("port", textBoxPort.Text);
            conf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
            try
            {
                MySqlConnection conn = new MySqlConnection(truc);
                conn.Open();
                conn.Close();
                MessageBox.Show("Modification validée.");
                
            }
            catch
            {
                MessageBox.Show("Configuration invalide.");
            }
        }
        private void _creeTablefonctionnement()
        {
            MySqlConnection conn = new MySqlConnection(truc);
            MySqlCommand tableMarque = new MySqlCommand("CREATE TABLE IF NOT EXISTS `marque`(`id` INT AUTO_INCREMENT ,`nmarque` varchar(100) NOT NULL, PRIMARY KEY(`id`)) COLLATE=`utf8_general_ci` ENGINE=InnoDB;", conn);
            MySqlCommand tableModel = new MySqlCommand("CREATE TABLE IF NOT EXISTS `model`(`id` INT AUTO_INCREMENT ,`nummod` varchar(100) NOT NULL,`marque` varchar(100) NOT NULL, PRIMARY KEY(`id`)) COLLATE=`utf8_general_ci` ENGINE=InnoDB;", conn);
            conn.Open();
            tableMarque.ExecuteNonQuery();
            tableModel.ExecuteNonQuery();
            conn.Close();
        }
        private void nombreTableVerif(int tableCount)
        {
            int TA = int.Parse(ConfigurationManager.AppSettings["tableActive"]);
            if(tableCount  <= TA && TA != 0)
            {
                conf.AppSettings.Settings.Remove("tableActive");
                conf.AppSettings.Settings.Add("tableActive", "0");
                conf.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }
    }
    
}
