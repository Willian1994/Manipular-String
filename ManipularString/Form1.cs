using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region Contains / ToString
            //string texto = "Este tipo de variável é alfanumerica.";

            //if (Text.Contains("tipo"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não Contém.";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = num.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "Willian";

            //string nomeM = nome.ToUpper();

            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Willian Ribeiro";

            //int indice = nome.IndexOf('i', 3);
            //int indice = nome.LastIndexOf('a');

            //label1.Text = "Indice: " + indice;
            #endregion

            #region Insert / Replace
            //string nome = "Willian Ribeiro";

            //string nomeFinal = nome.Insert(0, "Lucas ");

            //string nomeFinal = nome.Replace("Ribeiro", "Silva");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            //string nome = "Willian Ribeiro";

            //int tam = nome.Length;

            //label1.Text = " O nome " + nome + " contém " + tam + " letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;
            #endregion

            #region Split
            //string nomes = "Willian_+_Danny_+_Arthur_+_Gloria_+_Bia_+_Flavio";

            //char[] separador = { ' ', '-', '_' };

            //string[] resultado = nomes.Split(separador);

            //foreach (string  nome in resultado)
            //{
            //    label1.Text += nome + "\n";
            //}
            #endregion

            #region StartsWith / EndsWith
            //string nome = "Gabriel";

            //bool res = nome.StartsWith("Gab", StringComparison.OrdinalIgnoreCase);

            //bool res = nome.EndsWith("Gab", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo.";
            //}
            //else
            //{
            //    label1.Text = "Negativo. ";
            //}
            #endregion

            #region Trim / TrimStart / TrimEnd
            //string mensagem = "  Ola Willian  ";

            ////char[] c = { ' ', '-', '_', '5' };
            ////string nome = mensagem.Trim(c);
            ////mensagem.Trim(c);

            //label1.Text = ">" + mensagem.TrimStart() + "<";
            #endregion

            #region Equals / CompareTo
            //string nome = "Willian";

            //string nome2 = "Gabriel";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();
            #endregion

            #region Format
            //decimal valor = 19.95m;
            //int temp = 32;

            ////string s = String.Format("O valor do produto é {0:C2} é a temperatura é {1}", valor, temp);

            ////string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

            ////string s = $"O valor do produto é {valor:C2} é a temperatura é {temp}";

            //string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";
            //label1.Text = s;
            #endregion
        }
    }
}
