using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadeContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            contato contato = new contato();
            contato.Nome = Sobrenome.Text;
            contato.Nome = Nome.Text;
            contato.Nome = Telefone.Text;

            ListadeContatos.Items.Add(contato.ToString());
        }
    }
}
