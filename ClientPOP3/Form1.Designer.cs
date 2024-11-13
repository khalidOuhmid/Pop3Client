namespace ClientPOP3
{
    partial class Form1
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
            this.textBoxMachine = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMachine
            // 
            this.textBoxMachine.Location = new System.Drawing.Point(157, 79);
            this.textBoxMachine.Name = "textBoxMachine";
            this.textBoxMachine.Size = new System.Drawing.Size(100, 20);
            this.textBoxMachine.TabIndex = 0;
            this.textBoxMachine.TextChanged += new System.EventHandler(this.textBoxMachine_TextChanged);
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(157, 198);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMdp.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(157, 137);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Location = new System.Drawing.Point(166, 63);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(82, 13);
            this.labelMachine.TabIndex = 3;
            this.labelMachine.Text = "Nom du serveur";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(178, 121);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Identifiant";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(175, 182);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(73, 13);
            this.labelMdp.TabIndex = 5;
            this.labelMdp.Text = "mot de passe ";
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(325, 195);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 255);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxMachine);
            this.Name = "Form1";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMachine;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Button ButtonOK;
    }
}