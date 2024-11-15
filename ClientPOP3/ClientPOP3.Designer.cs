﻿namespace ClientPOP3
{
    partial class ClientPOP3
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAffichage = new System.Windows.Forms.ListBox();
            this.labelAffichage = new System.Windows.Forms.Label();
            this.listBoxVerbose = new System.Windows.Forms.ListBox();
            this.labelVerbose = new System.Windows.Forms.Label();
            this.buttonSTAT = new System.Windows.Forms.Button();
            this.buttonQUIT = new System.Windows.Forms.Button();
            this.buttonLIST = new System.Windows.Forms.Button();
            this.numericUpDownMessage = new System.Windows.Forms.NumericUpDown();
            this.buttonAfficherMessage = new System.Windows.Forms.Button();
            this.buttonRetrinfo = new System.Windows.Forms.Button();
            this.ButtonTopAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAffichage
            // 
            this.listBoxAffichage.FormattingEnabled = true;
            this.listBoxAffichage.Location = new System.Drawing.Point(24, 38);
            this.listBoxAffichage.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAffichage.Name = "listBoxAffichage";
            this.listBoxAffichage.Size = new System.Drawing.Size(649, 433);
            this.listBoxAffichage.TabIndex = 0;
            // 
            // labelAffichage
            // 
            this.labelAffichage.AutoSize = true;
            this.labelAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichage.Location = new System.Drawing.Point(21, 13);
            this.labelAffichage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAffichage.Name = "labelAffichage";
            this.labelAffichage.Size = new System.Drawing.Size(199, 17);
            this.labelAffichage.TabIndex = 1;
            this.labelAffichage.Text = "Affichage pour l\'utilisateur";
            // 
            // listBoxVerbose
            // 
            this.listBoxVerbose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxVerbose.FormattingEnabled = true;
            this.listBoxVerbose.Location = new System.Drawing.Point(701, 38);
            this.listBoxVerbose.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVerbose.Name = "listBoxVerbose";
            this.listBoxVerbose.Size = new System.Drawing.Size(484, 433);
            this.listBoxVerbose.TabIndex = 2;
            // 
            // labelVerbose
            // 
            this.labelVerbose.AutoSize = true;
            this.labelVerbose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerbose.Location = new System.Drawing.Point(699, 13);
            this.labelVerbose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVerbose.Name = "labelVerbose";
            this.labelVerbose.Size = new System.Drawing.Size(330, 17);
            this.labelVerbose.TabIndex = 3;
            this.labelVerbose.Text = "VERBOSE : Communication \"brute\" avec le serveur";
            // 
            // buttonSTAT
            // 
            this.buttonSTAT.Location = new System.Drawing.Point(974, 511);
            this.buttonSTAT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSTAT.Name = "buttonSTAT";
            this.buttonSTAT.Size = new System.Drawing.Size(77, 40);
            this.buttonSTAT.TabIndex = 4;
            this.buttonSTAT.Text = "STAT";
            this.buttonSTAT.UseVisualStyleBackColor = true;
            this.buttonSTAT.Click += new System.EventHandler(this.ButtonSTAT_Click);
            // 
            // buttonQUIT
            // 
            this.buttonQUIT.Location = new System.Drawing.Point(1098, 510);
            this.buttonQUIT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQUIT.Name = "buttonQUIT";
            this.buttonQUIT.Size = new System.Drawing.Size(77, 40);
            this.buttonQUIT.TabIndex = 5;
            this.buttonQUIT.Text = "QUIT";
            this.buttonQUIT.UseVisualStyleBackColor = true;
            this.buttonQUIT.Click += new System.EventHandler(this.ButtonQUIT_Click);
            // 
            // buttonLIST
            // 
            this.buttonLIST.Location = new System.Drawing.Point(846, 511);
            this.buttonLIST.Name = "buttonLIST";
            this.buttonLIST.Size = new System.Drawing.Size(77, 40);
            this.buttonLIST.TabIndex = 12;
            this.buttonLIST.Text = "LIST";
            this.buttonLIST.UseVisualStyleBackColor = true;
            this.buttonLIST.Click += new System.EventHandler(this.ButtonLIST_Click);
            // 
            // numericUpDownMessage
            // 
            this.numericUpDownMessage.Location = new System.Drawing.Point(603, 523);
            this.numericUpDownMessage.Name = "numericUpDownMessage";
            this.numericUpDownMessage.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMessage.TabIndex = 13;
            this.numericUpDownMessage.ValueChanged += new System.EventHandler(this.numericUpDownMessage_ValueChanged);
            // 
            // buttonAfficherMessage
            // 
            this.buttonAfficherMessage.Location = new System.Drawing.Point(745, 511);
            this.buttonAfficherMessage.Name = "buttonAfficherMessage";
            this.buttonAfficherMessage.Size = new System.Drawing.Size(77, 40);
            this.buttonAfficherMessage.TabIndex = 14;
            this.buttonAfficherMessage.Text = "Message n°0";
            this.buttonAfficherMessage.UseVisualStyleBackColor = true;
            this.buttonAfficherMessage.Click += new System.EventHandler(this.buttonAfficherMessage_Click);
            // 
            // buttonRetrinfo
            // 
            this.buttonRetrinfo.Location = new System.Drawing.Point(487, 511);
            this.buttonRetrinfo.Name = "buttonRetrinfo";
            this.buttonRetrinfo.Size = new System.Drawing.Size(92, 40);
            this.buttonRetrinfo.TabIndex = 15;
            this.buttonRetrinfo.Text = "Info message n°0";
            this.buttonRetrinfo.UseVisualStyleBackColor = true;
            this.buttonRetrinfo.Click += new System.EventHandler(this.buttonRetrinfo_Click);
            // 
            // ButtonTopAll
            // 
            this.ButtonTopAll.Location = new System.Drawing.Point(361, 510);
            this.ButtonTopAll.Name = "ButtonTopAll";
            this.ButtonTopAll.Size = new System.Drawing.Size(92, 40);
            this.ButtonTopAll.TabIndex = 16;
            this.ButtonTopAll.Text = "Info tout les messages";
            this.ButtonTopAll.UseVisualStyleBackColor = true;
            this.ButtonTopAll.Click += new System.EventHandler(this.ButtonTopAll_Click);
            // 
            // ClientPOP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 603);
            this.Controls.Add(this.ButtonTopAll);
            this.Controls.Add(this.buttonRetrinfo);
            this.Controls.Add(this.buttonAfficherMessage);
            this.Controls.Add(this.numericUpDownMessage);
            this.Controls.Add(this.buttonLIST);
            this.Controls.Add(this.buttonQUIT);
            this.Controls.Add(this.buttonSTAT);
            this.Controls.Add(this.labelVerbose);
            this.Controls.Add(this.listBoxVerbose);
            this.Controls.Add(this.labelAffichage);
            this.Controls.Add(this.listBoxAffichage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientPOP3";
            this.Text = "ClientPOP3";
            this.Load += new System.EventHandler(this.ClientPOP3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAffichage;
        private System.Windows.Forms.Label labelAffichage;
        private System.Windows.Forms.ListBox listBoxVerbose;
        private System.Windows.Forms.Label labelVerbose;
        private System.Windows.Forms.Button buttonSTAT;
        private System.Windows.Forms.Button buttonQUIT;
        private System.Windows.Forms.Button buttonLIST;
        private System.Windows.Forms.NumericUpDown numericUpDownMessage;
        private System.Windows.Forms.Button buttonAfficherMessage;
        private System.Windows.Forms.Button buttonRetrinfo;
        private System.Windows.Forms.Button ButtonTopAll;
    }
}

