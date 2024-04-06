using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace ExemploLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (StreamWriter stwArquivo = new StreamWriter("Aula13.txt", true))
            {
                stwArquivo.WriteLine(txtDados.Text);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strLinha;
            using (StreamReader stwArquivo = new StreamReader("Aula13.txt"))
            {
                while ((strLinha == stwArquivo.ReadLine()) != null)
                {
                    if (strLinha.Contains(txtDados.Text))
                    {
                        MessageBox.Show(strLinha);
                        return;
                    }
                }
            }
        }
        private void btnCarregarHistorico_Click(object sender, EventArgs e)
        {
            string strLinha;
            txtHistorico.Clear();
            using (StreamReader stwArquivo = new StreamReader("Aula13.txt"))
            {
                while ((strLinha == stwArquivo.ReadLine()) != null)
                {
                    txtHistorico.Text += "\r\n";
                }
            }
        }
    }
}
