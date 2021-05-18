
namespace GdS4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBd = new System.Windows.Forms.Label();
            this.labelmotspass = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.AdresseServer = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxBdNom = new System.Windows.Forms.TextBox();
            this.textBoxPasseword = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxAdServ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bouttonAjMarque = new System.Windows.Forms.Button();
            this.groupBoxAjMarMod = new System.Windows.Forms.GroupBox();
            this.labelMarque = new System.Windows.Forms.Label();
            this.textBoxMM = new System.Windows.Forms.TextBox();
            this.groupBoxAddMod = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGMod_marque = new System.Windows.Forms.Label();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.textBoxAddMod = new System.Windows.Forms.TextBox();
            this.comboBoxModMarque = new System.Windows.Forms.ComboBox();
            this.TableGestionGroupeBox = new System.Windows.Forms.GroupBox();
            this.buttonSupprTable = new System.Windows.Forms.Button();
            this.buttonVideTable = new System.Windows.Forms.Button();
            this.buttonSelectTable = new System.Windows.Forms.Button();
            this.comboxSelectTable = new System.Windows.Forms.ComboBox();
            this.textBoxNewTable = new System.Windows.Forms.TextBox();
            this.AjoutDeTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxAjMarMod.SuspendLayout();
            this.groupBoxAddMod.SuspendLayout();
            this.TableGestionGroupeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.labelBd);
            this.groupBox1.Controls.Add(this.labelmotspass);
            this.groupBox1.Controls.Add(this.uid);
            this.groupBox1.Controls.Add(this.AdresseServer);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.textBoxBdNom);
            this.groupBox1.Controls.Add(this.textBoxPasseword);
            this.groupBox1.Controls.Add(this.textBoxUID);
            this.groupBox1.Controls.Add(this.textBoxAdServ);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(78, 138);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 15);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Port";
            // 
            // labelBd
            // 
            this.labelBd.AutoSize = true;
            this.labelBd.Location = new System.Drawing.Point(12, 109);
            this.labelBd.Name = "labelBd";
            this.labelBd.Size = new System.Drawing.Size(95, 15);
            this.labelBd.TabIndex = 9;
            this.labelBd.Text = "Base de données";
            // 
            // labelmotspass
            // 
            this.labelmotspass.AutoSize = true;
            this.labelmotspass.Location = new System.Drawing.Point(20, 80);
            this.labelmotspass.Name = "labelmotspass";
            this.labelmotspass.Size = new System.Drawing.Size(82, 15);
            this.labelmotspass.TabIndex = 8;
            this.labelmotspass.Text = "Mots de passe";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Location = new System.Drawing.Point(81, 51);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(26, 15);
            this.uid.TabIndex = 7;
            this.uid.Text = "UID";
            // 
            // AdresseServer
            // 
            this.AdresseServer.AutoSize = true;
            this.AdresseServer.Location = new System.Drawing.Point(18, 22);
            this.AdresseServer.Name = "AdresseServer";
            this.AdresseServer.Size = new System.Drawing.Size(89, 15);
            this.AdresseServer.TabIndex = 6;
            this.AdresseServer.Text = "Adresse serveur";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(113, 135);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(126, 23);
            this.textBoxPort.TabIndex = 5;
            // 
            // textBoxBdNom
            // 
            this.textBoxBdNom.Location = new System.Drawing.Point(113, 106);
            this.textBoxBdNom.Name = "textBoxBdNom";
            this.textBoxBdNom.Size = new System.Drawing.Size(126, 23);
            this.textBoxBdNom.TabIndex = 4;
            // 
            // textBoxPasseword
            // 
            this.textBoxPasseword.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPasseword.Location = new System.Drawing.Point(113, 77);
            this.textBoxPasseword.Name = "textBoxPasseword";
            this.textBoxPasseword.Size = new System.Drawing.Size(126, 23);
            this.textBoxPasseword.TabIndex = 3;
            this.textBoxPasseword.UseSystemPasswordChar = true;
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(113, 48);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(126, 23);
            this.textBoxUID.TabIndex = 2;
            // 
            // textBoxAdServ
            // 
            this.textBoxAdServ.Location = new System.Drawing.Point(113, 19);
            this.textBoxAdServ.Name = "textBoxAdServ";
            this.textBoxAdServ.Size = new System.Drawing.Size(126, 23);
            this.textBoxAdServ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(113, 166);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bouttonAjMarque
            // 
            this.bouttonAjMarque.Location = new System.Drawing.Point(109, 51);
            this.bouttonAjMarque.Name = "bouttonAjMarque";
            this.bouttonAjMarque.Size = new System.Drawing.Size(148, 23);
            this.bouttonAjMarque.TabIndex = 0;
            this.bouttonAjMarque.Text = "Ajouter Marque";
            this.bouttonAjMarque.UseVisualStyleBackColor = true;
            this.bouttonAjMarque.Click += new System.EventHandler(this.bouttonAjMarque_Click);
            // 
            // groupBoxAjMarMod
            // 
            this.groupBoxAjMarMod.Controls.Add(this.labelMarque);
            this.groupBoxAjMarMod.Controls.Add(this.textBoxMM);
            this.groupBoxAjMarMod.Controls.Add(this.bouttonAjMarque);
            this.groupBoxAjMarMod.Location = new System.Drawing.Point(279, 2);
            this.groupBoxAjMarMod.Name = "groupBoxAjMarMod";
            this.groupBoxAjMarMod.Size = new System.Drawing.Size(291, 95);
            this.groupBoxAjMarMod.TabIndex = 1;
            this.groupBoxAjMarMod.TabStop = false;
            this.groupBoxAjMarMod.Text = "Ajout de Marque";
            this.groupBoxAjMarMod.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(55, 25);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(48, 15);
            this.labelMarque.TabIndex = 4;
            this.labelMarque.Text = "Marque";
            // 
            // textBoxMM
            // 
            this.textBoxMM.Location = new System.Drawing.Point(109, 22);
            this.textBoxMM.Name = "textBoxMM";
            this.textBoxMM.Size = new System.Drawing.Size(168, 23);
            this.textBoxMM.TabIndex = 2;
            // 
            // groupBoxAddMod
            // 
            this.groupBoxAddMod.Controls.Add(this.label1);
            this.groupBoxAddMod.Controls.Add(this.labelGMod_marque);
            this.groupBoxAddMod.Controls.Add(this.buttonAddModel);
            this.groupBoxAddMod.Controls.Add(this.textBoxAddMod);
            this.groupBoxAddMod.Controls.Add(this.comboBoxModMarque);
            this.groupBoxAddMod.Location = new System.Drawing.Point(279, 103);
            this.groupBoxAddMod.Name = "groupBoxAddMod";
            this.groupBoxAddMod.Size = new System.Drawing.Size(291, 136);
            this.groupBoxAddMod.TabIndex = 3;
            this.groupBoxAddMod.TabStop = false;
            this.groupBoxAddMod.Text = "Ajout de modèle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modèle";
            // 
            // labelGMod_marque
            // 
            this.labelGMod_marque.AutoSize = true;
            this.labelGMod_marque.Location = new System.Drawing.Point(64, 25);
            this.labelGMod_marque.Name = "labelGMod_marque";
            this.labelGMod_marque.Size = new System.Drawing.Size(48, 15);
            this.labelGMod_marque.TabIndex = 3;
            this.labelGMod_marque.Text = "Marque";
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Enabled = false;
            this.buttonAddModel.Location = new System.Drawing.Point(127, 80);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(122, 23);
            this.buttonAddModel.TabIndex = 2;
            this.buttonAddModel.Text = "Ajouter Modèle";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // textBoxAddMod
            // 
            this.textBoxAddMod.Enabled = false;
            this.textBoxAddMod.Location = new System.Drawing.Point(127, 51);
            this.textBoxAddMod.Name = "textBoxAddMod";
            this.textBoxAddMod.Size = new System.Drawing.Size(150, 23);
            this.textBoxAddMod.TabIndex = 1;
            this.textBoxAddMod.TextChanged += new System.EventHandler(this.textBoxAddMod_TextChanged);
            // 
            // comboBoxModMarque
            // 
            this.comboBoxModMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModMarque.FormattingEnabled = true;
            this.comboBoxModMarque.Location = new System.Drawing.Point(127, 22);
            this.comboBoxModMarque.Name = "comboBoxModMarque";
            this.comboBoxModMarque.Size = new System.Drawing.Size(122, 23);
            this.comboBoxModMarque.TabIndex = 0;
            this.comboBoxModMarque.SelectedIndexChanged += new System.EventHandler(this.comboBoxModMarque_SelectedIndexChanged);
            // 
            // TableGestionGroupeBox
            // 
            this.TableGestionGroupeBox.Controls.Add(this.buttonSupprTable);
            this.TableGestionGroupeBox.Controls.Add(this.buttonVideTable);
            this.TableGestionGroupeBox.Controls.Add(this.buttonSelectTable);
            this.TableGestionGroupeBox.Controls.Add(this.comboxSelectTable);
            this.TableGestionGroupeBox.Controls.Add(this.textBoxNewTable);
            this.TableGestionGroupeBox.Controls.Add(this.AjoutDeTable);
            this.TableGestionGroupeBox.Location = new System.Drawing.Point(9, 245);
            this.TableGestionGroupeBox.Name = "TableGestionGroupeBox";
            this.TableGestionGroupeBox.Size = new System.Drawing.Size(560, 110);
            this.TableGestionGroupeBox.TabIndex = 4;
            this.TableGestionGroupeBox.TabStop = false;
            this.TableGestionGroupeBox.Text = "Gestion de Table";
            // 
            // buttonSupprTable
            // 
            this.buttonSupprTable.Location = new System.Drawing.Point(316, 81);
            this.buttonSupprTable.Name = "buttonSupprTable";
            this.buttonSupprTable.Size = new System.Drawing.Size(113, 23);
            this.buttonSupprTable.TabIndex = 5;
            this.buttonSupprTable.Text = "Supprimer table";
            this.buttonSupprTable.UseVisualStyleBackColor = true;
            this.buttonSupprTable.Click += new System.EventHandler(this.buttonSupprTable_Click);
            // 
            // buttonVideTable
            // 
            this.buttonVideTable.Location = new System.Drawing.Point(456, 52);
            this.buttonVideTable.Name = "buttonVideTable";
            this.buttonVideTable.Size = new System.Drawing.Size(63, 23);
            this.buttonVideTable.TabIndex = 4;
            this.buttonVideTable.Text = "Vider";
            this.buttonVideTable.UseVisualStyleBackColor = true;
            this.buttonVideTable.Click += new System.EventHandler(this.buttonVideTable_Click);
            // 
            // buttonSelectTable
            // 
            this.buttonSelectTable.Location = new System.Drawing.Point(316, 52);
            this.buttonSelectTable.Name = "buttonSelectTable";
            this.buttonSelectTable.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectTable.TabIndex = 3;
            this.buttonSelectTable.Text = "Sélectionner";
            this.buttonSelectTable.UseVisualStyleBackColor = true;
            this.buttonSelectTable.Click += new System.EventHandler(this.buttonSelectTable_Click);
            // 
            // comboxSelectTable
            // 
            this.comboxSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSelectTable.FormattingEnabled = true;
            this.comboxSelectTable.Location = new System.Drawing.Point(316, 23);
            this.comboxSelectTable.Name = "comboxSelectTable";
            this.comboxSelectTable.Size = new System.Drawing.Size(203, 23);
            this.comboxSelectTable.TabIndex = 2;
            // 
            // textBoxNewTable
            // 
            this.textBoxNewTable.Location = new System.Drawing.Point(33, 23);
            this.textBoxNewTable.Name = "textBoxNewTable";
            this.textBoxNewTable.Size = new System.Drawing.Size(161, 23);
            this.textBoxNewTable.TabIndex = 1;
            // 
            // AjoutDeTable
            // 
            this.AjoutDeTable.Location = new System.Drawing.Point(33, 52);
            this.AjoutDeTable.Name = "AjoutDeTable";
            this.AjoutDeTable.Size = new System.Drawing.Size(75, 23);
            this.AjoutDeTable.TabIndex = 0;
            this.AjoutDeTable.Text = "Ajouter";
            this.AjoutDeTable.UseVisualStyleBackColor = true;
            this.AjoutDeTable.Click += new System.EventHandler(this.AjoutDeTable_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(582, 367);
            this.Controls.Add(this.TableGestionGroupeBox);
            this.Controls.Add(this.groupBoxAddMod);
            this.Controls.Add(this.groupBoxAjMarMod);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAjMarMod.ResumeLayout(false);
            this.groupBoxAjMarMod.PerformLayout();
            this.groupBoxAddMod.ResumeLayout(false);
            this.groupBoxAddMod.PerformLayout();
            this.TableGestionGroupeBox.ResumeLayout(false);
            this.TableGestionGroupeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBdNom;
        private System.Windows.Forms.TextBox textBoxPasseword;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxAdServ;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBd;
        private System.Windows.Forms.Label labelmotspass;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label AdresseServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button bouttonAjMarque;
        private System.Windows.Forms.GroupBox groupBoxAjMarMod;
        private System.Windows.Forms.TextBox textBoxMM;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.GroupBox groupBoxAddMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGMod_marque;
        private System.Windows.Forms.Button buttonAddModel;
        private System.Windows.Forms.TextBox textBoxAddMod;
        private System.Windows.Forms.ComboBox comboBoxModMarque;
        private System.Windows.Forms.GroupBox TableGestionGroupeBox;
        private System.Windows.Forms.Button buttonSelectTable;
        private System.Windows.Forms.ComboBox comboxSelectTable;
        private System.Windows.Forms.TextBox textBoxNewTable;
        private System.Windows.Forms.Button AjoutDeTable;
        private System.Windows.Forms.Button buttonSupprTable;
        private System.Windows.Forms.Button buttonVideTable;
    }
}