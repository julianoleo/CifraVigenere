using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifraVigenere
{
    public partial class Form_CifraVigenere : Form
    {
        public Form_CifraVigenere()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static string CifraVigenere(string mensagem, string chave, bool flag)
        {
            if(flag)
            {
                var codigo = "";
                for (int i = 0, j = 0; i < mensagem.Length; i++, j++) {
                    char c = char.ToUpper(mensagem[i]);
                    if (c < 'A' || c > 'Z') continue;
                    codigo += (char)((c + char.ToUpper(chave[j % chave.Length]) - 2 * 'A') % 26 + 'A');
                }
                return codigo;
            }
            return "";
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if(txtMsgOriginal.Text == string.Empty || txtChave.Text == string.Empty)
            {
                MessageBox.Show("Favor informar uma mensagem ou uma chave válida!");
            }
            else
            {
                string textoOriginal = txtMsgOriginal.Text.ToUpper();
                string chave = txtChave.Text.ToUpper();
                string resultado = CifraVigenere(textoOriginal, chave, true);
                txtMsgCriptografada.Text = string.Empty;
                txtMsgCriptografada.Text = resultado;
            }
        }
    }
}
