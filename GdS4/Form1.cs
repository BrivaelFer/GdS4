using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.IO;

namespace GdS4
{
    public partial class Form1 : Form
    {
        int idApp;

        string truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            
            textBoxNumSerie.KeyPress += TextBoxNumSerie_KeyPress;
            
            listViewSelectedTable.MouseDoubleClick += ListViewSelectedTable_MouseDoubleClick;
        }

        private void ListViewSelectedTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSelectedTable.Items.Count >= 1)
            {
                ListViewItem item = listViewSelectedTable.SelectedItems[0];

                if (item.Bounds.Contains(e.Location))
                {
                    textBoxNumSerie.Text = item.Text;
                    rechercher(true);
                }

            }
        }

        private void TextBoxNumSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == 13 && buttonAjout.Enabled)
            {
                e.Handled = true;
                Ajout(comboBoxSelectedTable.Text);

            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            _creeTablefonctionnement();
            columnHeaderDate.Width = listViewSelectedTable.Width * 20 / 100;
            columnHeaderNumSerie.Width = listViewSelectedTable.Width * 30 / 100;
            comboBoxMarque.Width = listViewSelectedTable.Width * 20 / 100;
            comboBoxModel.Width = listViewSelectedTable.Width * 20 / 100;
            _listComboBoxMarque();
            _listComboBoxTable();
            

        }
        private void comboBoxSelectedTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxTableSync.Checked)
                comboBoxTableAfficher.SelectedIndex = comboBoxSelectedTable.SelectedIndex;
        }
        private void comboBoxTableAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpDateTableau();
            upDateCount();
            if (checkBoxTableSync.Checked)
                comboBoxSelectedTable.SelectedIndex = comboBoxTableAfficher.SelectedIndex;
        }
        private void textBoxNumSerie_TextChanged(object sender, EventArgs e)
        {
            buttonAjout.Enabled = true;
            buttonSuppr.Enabled = false;
        }
        private void comboBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listComboBoxModel(comboBoxMarque.Text);
            buttonSuppr.Enabled = false;
            buttonTranfer.Enabled = false;
            buttonCopier.Enabled = false;
        }
        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            rechercher(false);
            
        }
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            Ajout(comboBoxSelectedTable.Text);
        }
        private void buttonSuppr_Click(object sender, EventArgs e)
        {
            Suppr(comboBoxSelectedTable.Text);
        }
        private void buttonParametre_Click(object sender, EventArgs e)
        {
            lanceParametreWindo();
        }
        private void buttonCSV_Click(object sender, EventArgs e)
        {
            _creeCSV();
            UpDateTableau();
        }
        private void checkBoxAffichage_CheckedChanged(object sender, EventArgs e)
        {
            UpDateTableau();
        }

        private void buttonTranfer_Click(object sender, EventArgs e)
        {
            if(comboBoxSelectedTable.Text != comboBoxTableToTransfer.Text)
            {
                if (!checkBoxToutCopTrans.Checked)
                {
                    Ajout(comboBoxTableToTransfer.Text);
                    Suppr(comboBoxSelectedTable.Text);
                }
                else
                {
                    copieTable(comboBoxTableToTransfer.Text);
                    supprAllTable();

                }
                UpDateTableau();
            }
            else
            {
                MessageBox.Show("La Table de Copie doit être différente\nde la Table principal.");
            }
                
        }

        private void buttonCopier_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectedTable.Text != comboBoxTableToTransfer.Text)
            {
                if (!checkBoxToutCopTrans.Checked)
                {
                    Ajout(comboBoxTableToTransfer.Text);
                }
                else
                {
                    copieTable(comboBoxTableToTransfer.Text);

                }
                UpDateTableau();
            }
            else
                MessageBox.Show("La Table de Copie doit être différente\nde la Table principal.");
                
        }
        private void checkBoxToutCopTrans_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumSerie.Enabled = !checkBoxToutCopTrans.Checked;
            buttonCopier.Enabled = checkBoxToutCopTrans.Checked;
            buttonTranfer.Enabled = checkBoxToutCopTrans.Checked;
        }
        private void checkBoxTableSync_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTableSync.Checked)
                comboBoxTableAfficher.SelectedIndex = comboBoxSelectedTable.SelectedIndex;
        }
        private void Ajout(string tableViser)
        {
            _connUpDate();
            
            if (!CheckInTable(tableViser))
            {
                if(textBoxNumSerie.Text == "")
                {
                    MessageBox.Show("Veuillez renseigner N/S");
                    return;
                }    
                try
                {
                    conn.Open();
                    
                    MySqlCommand ajapp = new MySqlCommand("INSERT INTO " + tableViser +
                        "(Date,numSeri,model,marque) values(@Date,@numSeri,@model,@marque)", conn);
                    ajapp.Parameters.AddWithValue("@marque", comboBoxMarque.Text);
                    ajapp.Parameters.AddWithValue("@numSeri", textBoxNumSerie.Text);
                    ajapp.Parameters.AddWithValue("@model", comboBoxModel.Text);
                    ajapp.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    ajapp.ExecuteNonQuery();
                    ajapp.Parameters.Clear();
                    textBoxNumSerie.Clear();
                    UpDateTableau();
                    upDateCount();
                    
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec de l'ajout\n" + ex.Message);
                }
            }
            else
                MessageBox.Show("La table contient déjà ce N/S");

            
        }
        private void Suppr(string tableVise)
        {
            try
            {
                conn.Open();
                

                MySqlCommand suppApp = new MySqlCommand("DELETE FROM " + tableVise + " WHERE id = " + idApp, conn);
                suppApp.ExecuteNonQuery();

                MessageBox.Show("suppression réussie");
                UpDateTableau();
                upDateCount();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression\n" + ex.Message);
            }
            

        }
        private void rechercher(bool inListView)
        {
            _connUpDate();
            bool trouver = false;

            MySqlCommand lireNS;
            MySqlDataReader dataR;

           

            conn.Open();
            lireNS = new MySqlCommand("select * from " + comboBoxSelectedTable.Text, conn);
            dataR = lireNS.ExecuteReader();
            while (dataR.Read())
            {
                if (textBoxNumSerie.Text == (string)dataR["numSeri"])
                {
                    if(!inListView)
                        MessageBox.Show("apparail trouvé");
                        
                    comboBoxMarque.Text = (string)dataR["marque"];
                    comboBoxModel.Text = (string)dataR["model"];
                    idApp = (int)dataR["id"];

                    trouver = true;

                    buttonAjout.Enabled = false;
                    buttonTranfer.Enabled = true;
                    buttonCopier.Enabled = true;
                    buttonSuppr.Enabled = true;
                    comboBoxModel.Enabled = false;
                    

                    break;
                }


            }


            conn.Close();
                
               

            
            if (!trouver)
            {
                if(!inListView)
                    MessageBox.Show("Numéro de série invalide");
                if (inListView)
                    MessageBox.Show("L'entrée n'exite pas dans la table " + comboBoxSelectedTable.Text);
            }
        }
        private void _connUpDate()
        {
            truc = "SERVER=" + ConfigurationManager.AppSettings["adServ"] + ";PORT=" + ConfigurationManager.AppSettings["port"] +
            ";DATABASE=" + ConfigurationManager.AppSettings["bdnom"] + ";UID=" + ConfigurationManager.AppSettings["uid"] +
            ";PASSWORD=" + ConfigurationManager.AppSettings["motDePasse"];
            conn = new MySqlConnection(truc);
        }
        private void _creeCSV()
        {
            _connUpDate();
            List<string> CSV = new List<string> {"\" id\",\"Date\",\"N/S\",\"Marque\",\"Modèle\"" };
            string LeCSV = "\" id\",\"Date\",\"N/S\",\"Marque\",\"Modèle\"";
            try
            {
                listViewSelectedTable.Items.Clear();
                conn.Open();
                MySqlCommand readTable = new MySqlCommand("SELECT * FROM " + comboBoxTableAfficher.Text , conn);
                MySqlDataReader lec = readTable.ExecuteReader();
                while (lec.Read())
                {
                    string id = lec["id"].ToString();
                    string date = lec["Date"].ToString();
                    string Nseri = lec["numSeri"].ToString();
                    string Marq = lec["marque"].ToString();
                    string Mod = lec["model"].ToString();
                    date = date.Replace("00:00:00", String.Empty);
                    string toList = "\"" + id + "\",\"" + date + "\",\"" + Nseri + "\",\"" + Marq + "\",\"" + Mod + "\"";
                    CSV.Add(toList);
                    LeCSV = LeCSV + "\n" + toList;



                }
                
                conn.Close();
                saveFileDialogCSV.FileName = comboBoxTableAfficher.Text;
                saveFileDialogCSV.ShowDialog();
                File.WriteAllText(saveFileDialogCSV.FileName, LeCSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void upDateCount()
        {
            _connUpDate();
            string count;
            conn.Open();
            MySqlCommand lireCompteur = new MySqlCommand("SELECT COUNT(*) FROM " + comboBoxTableAfficher.Text, conn);
            count = lireCompteur.ExecuteScalar().ToString();
            
            conn.Close();
            labelConteur.Text = "Nombre d'entrée : "+ count;
        }
        private void UpDateTableau()
        {
            _connUpDate();
            string limite = "";
            if (!checkBoxAffichage.Checked)
                limite = "LIMIT 0,9";

            try
            {
                listViewSelectedTable.Items.Clear();
                conn.Open();
                MySqlCommand readTable = new MySqlCommand("SELECT * FROM " + comboBoxTableAfficher.Text + " ORDER BY id DESC " + limite, conn);
                MySqlDataReader lec = readTable.ExecuteReader();
                while (lec.Read())
                {

                    string date = lec["Date"].ToString();
                    string Nseri = lec["numSeri"].ToString();
                    string Marq = lec["marque"].ToString();
                    string Mod = lec["model"].ToString();
                    date = date.Replace("00:00:00", String.Empty);
                    listViewSelectedTable.Items.Add(new ListViewItem(new[] {  Nseri, Marq, Mod, date }));

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void _listComboBoxMarque()
        {
            _connUpDate();
            MySqlCommand lireBddM = new MySqlCommand("SELECT * FROM marque", conn);
            

            conn.Open();
            MySqlDataReader dataR = lireBddM.ExecuteReader();
            comboBoxMarque.Items.Clear();
            while (dataR.Read())
            {
                comboBoxMarque.Items.Add(dataR["nmarque"]);
            }

            conn.Close();
            try
            {
                comboBoxMarque.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Aucune marque n'a été trouvé.\nVeuillez en ajouter une dans paramètres.");
            }
            
            
        }    
        private void _listComboBoxModel(string marque)
        {
            bool trouver = false;
            
            _connUpDate();

            MySqlCommand lireListMod;
            MySqlDataReader dataR;

            conn.Open();

            lireListMod = new MySqlCommand("select * from  model", conn);
            dataR = lireListMod.ExecuteReader();
            comboBoxModel.Items.Clear();
            while (dataR.Read())
            {
                if (marque == (string)dataR["marque"])
                {
                    comboBoxModel.Items.Add(dataR["nummod"]);
                    comboBoxModel.Enabled = true;
                    trouver = true;
                }
            }
            if (!trouver)
                MessageBox.Show("Aucun modèle de correspond à cette marque");
            else
                comboBoxModel.SelectedIndex = 0;

            conn.Close();
            
        }
        private void _listComboBoxTable()
        {
            _connUpDate();
            int parDefautTable;
            try
            {
                nombreTableVerif(comboBoxSelectedTable.Items.Count);
                parDefautTable = int.Parse(ConfigurationManager.AppSettings["tableActive"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur config table par défaut.\n"+ ex.Message);
                parDefautTable = 0;
            }
            
            
            conn.Open();
            MySqlCommand realTable = new MySqlCommand("Show tables from " + ConfigurationManager.AppSettings["bdnom"], conn);
            MySqlDataReader dataR = realTable.ExecuteReader();
            comboBoxSelectedTable.Items.Clear();
            comboBoxTableAfficher.Items.Clear();
            comboBoxTableToTransfer.Items.Clear();
            while (dataR.Read())
            {
                if(dataR.GetString(0) != "model" && dataR.GetString(0) != "marque")
                {
                    comboBoxSelectedTable.Items.Add(dataR.GetString(0));
                    comboBoxTableAfficher.Items.Add(dataR.GetString(0));
                    comboBoxTableToTransfer.Items.Add(dataR.GetString(0));
                }
                
            }
            
            conn.Close();

            try
            {
                comboBoxSelectedTable.SelectedIndex = parDefautTable;
                comboBoxTableAfficher.SelectedIndex = parDefautTable;
                comboBoxTableToTransfer.SelectedIndex = parDefautTable;
            }
            catch
            {
                MessageBox.Show("Seules les tables de fonctionnement ont été trouvé\n veuillez créer une table dans paramètres");
            }
            
        }
        private void lanceParametreWindo()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            _connUpDate();
            _listComboBoxMarque();
            _listComboBoxTable();
            UpDateTableau();
        }
        private bool CheckInTable(string tableViser)
        {
            bool inTable = false;
            MySqlCommand lireNS = new MySqlCommand("select * from " + tableViser, conn);
            conn.Open();
            MySqlDataReader dataR = lireNS.ExecuteReader();
            while(dataR.Read())
            {
                if((string)dataR["numSeri"] == textBoxNumSerie.Text)
                {
                    inTable = true;
                    break;
                }
            }
            conn.Close();
            
            return inTable;
        }
        private void _creeTablefonctionnement()
        {
            _connUpDate();
            MySqlCommand tableMarque = new MySqlCommand("CREATE TABLE IF NOT EXISTS `marque`(`id` INT AUTO_INCREMENT ,`nmarque` varchar(100) NOT NULL, PRIMARY KEY(`id`)) COLLATE=`utf8_general_ci` ENGINE=InnoDB;", conn);
            MySqlCommand tableModel = new MySqlCommand("CREATE TABLE IF NOT EXISTS `model`(`id` INT AUTO_INCREMENT ,`nummod` varchar(100) NOT NULL,`marque` varchar(100) NOT NULL, PRIMARY KEY(`id`)) COLLATE=`utf8_general_ci` ENGINE=InnoDB;", conn);
            conn.Open();
            tableMarque.ExecuteNonQuery();
            tableModel.ExecuteNonQuery();
            conn.Close();
        }
        private void supprAllTable()
        {
            MySqlCommand Vidage = new MySqlCommand("TRUNCATE table " + comboBoxSelectedTable.Text, conn);
            conn.Open();
            Vidage.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Le Contenu de la table "+comboBoxSelectedTable.Text+" a été supprimé.");
        }
        private void copieTable(string tableViser)
        {
            _connUpDate();
            MySqlConnection conn2 = new MySqlConnection(truc);
            MySqlCommand lireTable = new MySqlCommand("select * from " + comboBoxSelectedTable.Text, conn);
            MySqlCommand ajapp = new MySqlCommand("INSERT INTO " + tableViser +
                       "(Date,numSeri,model,marque) values(@Date,@numSeri,@model,@marque)", conn2);
            conn.Open();
            MySqlDataReader dataR = lireTable.ExecuteReader();
            while(dataR.Read())
            {
                if(!CheckForCopie(dataR["numSeri"].ToString()))
                {
                    conn2.Open();
                    ajapp.Parameters.AddWithValue("@marque", dataR["marque"]);
                    ajapp.Parameters.AddWithValue("@numSeri", dataR["numSeri"]);
                    ajapp.Parameters.AddWithValue("@model", dataR["model"]);
                    ajapp.Parameters.AddWithValue("@Date", dataR["Date"]);
                    ajapp.ExecuteNonQuery();
                    ajapp.Parameters.Clear();
                    conn2.Close();

                }
                
            }
            MessageBox.Show("Le Contenu de la table " + comboBoxSelectedTable.Text + " a été copié\n" +
                "dans la table" + comboBoxTableToTransfer.Text + ".");
            UpDateTableau();

        }
        private bool CheckForCopie(string NS)
        {
            bool inTable = false;
            MySqlConnection conn3 = new MySqlConnection(truc);
            MySqlCommand lireNS = new MySqlCommand("select * from " + comboBoxTableToTransfer.Text, conn3);
            conn3.Open();
            MySqlDataReader dataR = lireNS.ExecuteReader();
            while (dataR.Read())
            {
                if ((dataR["numSeri"].ToString()) == NS)
                {
                    inTable = true;
                    break;
                }
            }
            conn3.Close();

            return inTable;
        }
        private void nombreTableVerif(int tableCount)
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            int TA = int.Parse(ConfigurationManager.AppSettings["tableActive"]);
            if (tableCount  <= TA && TA != 0)
            {
                conf.AppSettings.Settings.Remove("tableActive");
                conf.AppSettings.Settings.Add("tableActive", "0");
                conf.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }


    } 
}
