using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lista_de_contatos_tessete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            exibir();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadeContato_TextChanged(object sender, EventArgs e)
        {

        }

        private contato[] contatos = new contato[1];

        private void Escrever(contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("contato.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++) 
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();
        }

        private void Ler()
        {
            StreamReader lerarquivo = new StreamReader("contatos.txt");
            contatos = new contato[Convert.ToInt32(lerarquivo.ReadLine())];


            for (int x = 0;x < contatos.Length; x++)
            {
                contatos[x] = new contato();
                contatos[x].Nome = lerarquivo.ReadLine();
                contatos[x].Sobrenome = lerarquivo.ReadLine();
                contatos[x].Telefone = lerarquivo.ReadLine();

            }

        }

        private void exibir()
        {
            ListadeContatos.Items.Clear();
            for (int x = 0; x < contatos.Length; x++)
            {
                ListadeContatos.Items.Add(contatos[x].ToString());
            }

        }

        private void LimparFormulario()
        {
            Nome.Text = String.Empty;
            Sobrenome.Text = String.Empty;
            Telefone.Text = String.Empty;

        }
        
        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            contato contato = new contato();
            contato.Nome = Sobrenome.Text;
            contato.Nome = Nome.Text;
            contato.Nome = Telefone.Text;

           // ListadeContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            exibir();
            LimparFormulario();
        }

        private void ListadeContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
