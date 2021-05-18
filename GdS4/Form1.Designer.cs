
namespace GdS4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.comboBoxSelectedTable = new System.Windows.Forms.ComboBox();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxTableToTransfer = new System.Windows.Forms.ComboBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonTranfer = new System.Windows.Forms.Button();
            this.buttonSuppr = new System.Windows.Forms.Button();
            this.buttonCopier = new System.Windows.Forms.Button();
            this.comboBoxTableAfficher = new System.Windows.Forms.ComboBox();
            this.checkBoxAffichage = new System.Windows.Forms.CheckBox();
            this.listViewSelectedTable = new System.Windows.Forms.ListView();
            this.columnHeaderNumSerie = new System.Windows.Forms.ColumnHeader();
            this.columnHeadermarque = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderModel = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.labelConteur = new System.Windows.Forms.Label();
            this.labelTable1 = new System.Windows.Forms.Label();
            this.labelNumSerie = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelTable2 = new System.Windows.Forms.Label();
            this.buttonParametre = new System.Windows.Forms.Button();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxToutCopTrans = new System.Windows.Forms.CheckBox();
            this.checkBoxTableSync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.AllowDrop = true;
            this.textBoxNumSerie.Location = new System.Drawing.Point(119, 82);
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(147, 23);
            this.textBoxNumSerie.TabIndex = 0;
            this.textBoxNumSerie.TextChanged += new System.EventHandler(this.textBoxNumSerie_TextChanged);
            // 
            // comboBoxSelectedTable
            // 
            this.comboBoxSelectedTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedTable.FormattingEnabled = true;
            this.comboBoxSelectedTable.Location = new System.Drawing.Point(119, 28);
            this.comboBoxSelectedTable.Name = "comboBoxSelectedTable";
            this.comboBoxSelectedTable.Size = new System.Drawing.Size(147, 23);
            this.comboBoxSelectedTable.TabIndex = 1;
            this.comboBoxSelectedTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedTable_SelectedIndexChanged);
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(119, 111);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(147, 23);
            this.comboBoxMarque.TabIndex = 2;
            this.comboBoxMarque.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarque_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(119, 140);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(147, 23);
            this.comboBoxModel.TabIndex = 3;
            // 
            // comboBoxTableToTransfer
            // 
            this.comboBoxTableToTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableToTransfer.FormattingEnabled = true;
            this.comboBoxTableToTransfer.Location = new System.Drawing.Point(119, 270);
            this.comboBoxTableToTransfer.Name = "comboBoxTableToTransfer";
            this.comboBoxTableToTransfer.Size = new System.Drawing.Size(147, 23);
            this.comboBoxTableToTransfer.TabIndex = 4;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(272, 82);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(75, 23);
            this.buttonRecherche.TabIndex = 5;
            this.buttonRecherche.Text = "rechercher";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(119, 179);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjout.TabIndex = 6;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonTranfer
            // 
            this.buttonTranfer.Enabled = false;
            this.buttonTranfer.Location = new System.Drawing.Point(119, 318);
            this.buttonTranfer.Name = "buttonTranfer";
            this.buttonTranfer.Size = new System.Drawing.Size(75, 23);
            this.buttonTranfer.TabIndex = 7;
            this.buttonTranfer.Text = "Transférer";
            this.buttonTranfer.UseVisualStyleBackColor = true;
            this.buttonTranfer.Click += new System.EventHandler(this.buttonTranfer_Click);
            // 
            // buttonSuppr
            // 
            this.buttonSuppr.Enabled = false;
            this.buttonSuppr.Location = new System.Drawing.Point(219, 179);
            this.buttonSuppr.Name = "buttonSuppr";
            this.buttonSuppr.Size = new System.Drawing.Size(102, 23);
            this.buttonSuppr.TabIndex = 8;
            this.buttonSuppr.Text = "Supprimer";
            this.buttonSuppr.UseVisualStyleBackColor = true;
            this.buttonSuppr.Click += new System.EventHandler(this.buttonSuppr_Click);
            // 
            // buttonCopier
            // 
            this.buttonCopier.Enabled = false;
            this.buttonCopier.Location = new System.Drawing.Point(219, 318);
            this.buttonCopier.Name = "buttonCopier";
            this.buttonCopier.Size = new System.Drawing.Size(75, 23);
            this.buttonCopier.TabIndex = 9;
            this.buttonCopier.Text = "Copier";
            this.buttonCopier.UseVisualStyleBackColor = true;
            this.buttonCopier.Click += new System.EventHandler(this.buttonCopier_Click);
            // 
            // comboBoxTableAfficher
            // 
            this.comboBoxTableAfficher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableAfficher.FormattingEnabled = true;
            this.comboBoxTableAfficher.Location = new System.Drawing.Point(399, 25);
            this.comboBoxTableAfficher.Name = "comboBoxTableAfficher";
            this.comboBoxTableAfficher.Size = new System.Drawing.Size(165, 23);
            this.comboBoxTableAfficher.TabIndex = 11;
            this.comboBoxTableAfficher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableAfficher_SelectedIndexChanged);
            // 
            // checkBoxAffichage
            // 
            this.checkBoxAffichage.AutoSize = true;
            this.checkBoxAffichage.Location = new System.Drawing.Point(788, 28);
            this.checkBoxAffichage.Name = "checkBoxAffichage";
            this.checkBoxAffichage.Size = new System.Drawing.Size(93, 19);
            this.checkBoxAffichage.TabIndex = 12;
            this.checkBoxAffichage.Text = "Afficher tout";
            this.checkBoxAffichage.UseVisualStyleBackColor = true;
            this.checkBoxAffichage.CheckedChanged += new System.EventHandler(this.checkBoxAffichage_CheckedChanged);
            // 
            // listViewSelectedTable
            // 
            this.listViewSelectedTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumSerie,
            this.columnHeadermarque,
            this.columnHeaderModel,
            this.columnHeaderDate});
            this.listViewSelectedTable.HideSelection = false;
            this.listViewSelectedTable.Location = new System.Drawing.Point(398, 56);
            this.listViewSelectedTable.Name = "listViewSelectedTable";
            this.listViewSelectedTable.Size = new System.Drawing.Size(602, 382);
            this.listViewSelectedTable.TabIndex = 13;
            this.listViewSelectedTable.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNumSerie
            // 
            this.columnHeaderNumSerie.Text = "N/S";
            this.columnHeaderNumSerie.Width = 150;
            // 
            // columnHeadermarque
            // 
            this.columnHeadermarque.Text = "Marque";
            this.columnHeadermarque.Width = 150;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Modèle";
            this.columnHeaderModel.Width = 150;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 100;
            // 
            // buttonCSV
            // 
            this.buttonCSV.Location = new System.Drawing.Point(887, 24);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(113, 23);
            this.buttonCSV.TabIndex = 14;
            this.buttonCSV.Text = "Créer un CSV";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // labelConteur
            // 
            this.labelConteur.AutoSize = true;
            this.labelConteur.Location = new System.Drawing.Point(569, 30);
            this.labelConteur.Name = "labelConteur";
            this.labelConteur.Size = new System.Drawing.Size(136, 15);
            this.labelConteur.TabIndex = 16;
            this.labelConteur.Text = "Nombre d\'entrée : 00000";
            // 
            // labelTable1
            // 
            this.labelTable1.AutoSize = true;
            this.labelTable1.Location = new System.Drawing.Point(24, 32);
            this.labelTable1.Name = "labelTable1";
            this.labelTable1.Size = new System.Drawing.Size(89, 15);
            this.labelTable1.TabIndex = 17;
            this.labelTable1.Text = "Table principale";
            // 
            // labelNumSerie
            // 
            this.labelNumSerie.AutoSize = true;
            this.labelNumSerie.Location = new System.Drawing.Point(86, 85);
            this.labelNumSerie.Name = "labelNumSerie";
            this.labelNumSerie.Size = new System.Drawing.Size(27, 15);
            this.labelNumSerie.TabIndex = 18;
            this.labelNumSerie.Text = "N/S";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(65, 114);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(48, 15);
            this.labelMarque.TabIndex = 19;
            this.labelMarque.Text = "Marque";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(66, 143);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(47, 15);
            this.labelModel.TabIndex = 20;
            this.labelModel.Text = "Modèle";
            // 
            // labelTable2
            // 
            this.labelTable2.AutoSize = true;
            this.labelTable2.Location = new System.Drawing.Point(31, 273);
            this.labelTable2.Name = "labelTable2";
            this.labelTable2.Size = new System.Drawing.Size(82, 15);
            this.labelTable2.TabIndex = 21;
            this.labelTable2.Text = "Table de copie";
            // 
            // buttonParametre
            // 
            this.buttonParametre.Location = new System.Drawing.Point(218, 396);
            this.buttonParametre.Name = "buttonParametre";
            this.buttonParametre.Size = new System.Drawing.Size(129, 23);
            this.buttonParametre.TabIndex = 22;
            this.buttonParametre.Text = "Paramètres";
            this.buttonParametre.UseVisualStyleBackColor = true;
            this.buttonParametre.Click += new System.EventHandler(this.buttonParametre_Click);
            // 
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.Filter = "Fichiers CSV|*.csv";
            // 
            // checkBoxToutCopTrans
            // 
            this.checkBoxToutCopTrans.AutoSize = true;
            this.checkBoxToutCopTrans.Location = new System.Drawing.Point(66, 227);
            this.checkBoxToutCopTrans.Name = "checkBoxToutCopTrans";
            this.checkBoxToutCopTrans.Size = new System.Drawing.Size(147, 19);
            this.checkBoxToutCopTrans.TabIndex = 23;
            this.checkBoxToutCopTrans.Text = "Copie/Tranfert de table";
            this.checkBoxToutCopTrans.UseVisualStyleBackColor = true;
            this.checkBoxToutCopTrans.CheckedChanged += new System.EventHandler(this.checkBoxToutCopTrans_CheckedChanged);
            // 
            // checkBoxTableSync
            // 
            this.checkBoxTableSync.AutoSize = true;
            this.checkBoxTableSync.Location = new System.Drawing.Point(398, 0);
            this.checkBoxTableSync.Name = "checkBoxTableSync";
            this.checkBoxTableSync.Size = new System.Drawing.Size(206, 19);
            this.checkBoxTableSync.TabIndex = 24;
            this.checkBoxTableSync.Text = "Synchroniser avec Table principale";
            this.checkBoxTableSync.UseVisualStyleBackColor = true;
            this.checkBoxTableSync.CheckedChanged += new System.EventHandler(this.checkBoxTableSync_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.checkBoxTableSync);
            this.Controls.Add(this.checkBoxToutCopTrans);
            this.Controls.Add(this.buttonParametre);
            this.Controls.Add(this.labelTable2);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.labelNumSerie);
            this.Controls.Add(this.labelTable1);
            this.Controls.Add(this.labelConteur);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.listViewSelectedTable);
            this.Controls.Add(this.checkBoxAffichage);
            this.Controls.Add(this.comboBoxTableAfficher);
            this.Controls.Add(this.buttonCopier);
            this.Controls.Add(this.buttonSuppr);
            this.Controls.Add(this.buttonTranfer);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.comboBoxTableToTransfer);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.comboBoxSelectedTable);
            this.Controls.Add(this.textBoxNumSerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GdS4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.ComboBox comboBoxSelectedTable;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxTableToTransfer;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonTranfer;
        private System.Windows.Forms.Button buttonSuppr;
        private System.Windows.Forms.Button buttonCopier;
        private System.Windows.Forms.ComboBox comboBoxTableAfficher;
        private System.Windows.Forms.CheckBox checkBoxAffichage;
        private System.Windows.Forms.ListView listViewSelectedTable;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderNumSerie;
        private System.Windows.Forms.ColumnHeader columnHeadermarque;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.Button buttonCSV;
        private System.Windows.Forms.Label labelConteur;
        private System.Windows.Forms.Label labelTable1;
        private System.Windows.Forms.Label labelNumSerie;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelTable2;
        private System.Windows.Forms.Button buttonParametre;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
        private System.Windows.Forms.CheckBox checkBoxToutCopTrans;
        private System.Windows.Forms.CheckBox checkBoxTableSync;
    }
}

