using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPOP3
{
    public partial class Form1 : Form
    {
        public string Serveur { get { return textBoxMachine.Text; } } 
        public string identifiant { get { return textBoxId.Text; } }
        public string mdp { get { return textBoxMdp.Text; } }
        public Form1(string s , string i , string m)
        {
            InitializeComponent();
            textBoxMachine.Text = s;
            textBoxId.Text = i;
            textBoxMdp.Text = m;
            Refresh();
        }

        private void textBoxMachine_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Preferences.username = identifiant;
            Preferences.password = mdp;
            Preferences.nomServeur = Serveur;
        }
    }
}
