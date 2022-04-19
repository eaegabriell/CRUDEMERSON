using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDZINHO
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoas;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Inserir(txtNome.Text,txtCelular.Text, txtEmail.Text, txtDataDeNascimento.Text);
            MessageBox.Show("Pessoa Cadastrada");
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoa;
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataDeNascimento.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Pessoa pessoa = new Pessoa();
            pessoa.Atualizar(Id, txtNome.Text, txtCelular.Text, txtEmail.Text, txtDataDeNascimento.Text);
            MessageBox.Show("Pessoa Editada");
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoa;
            txtId.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataDeNascimento.Text = "";

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Pessoa pessoa = new Pessoa();
            pessoa.Excluir(Id);
            MessageBox.Show("Pessoa Excluida");
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoa;
            txtId.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataDeNascimento.Text = "";
        }

        private void lblLocalizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Pessoa pessoa = new Pessoa();
            pessoa.Localizar(Id);
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataDeNascimento.Text = "";
        }

        private void dgvPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPessoa.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCelular.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtDataDeNascimento.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
