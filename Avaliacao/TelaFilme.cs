using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao
{
    public partial class TelaFilme : Form
    {
        public TelaFilme()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        
        private void CarregaTabela()
        {
            dgvBanco.DataSource = null;
            DataTable banco = con.Retorna(
                "select codigo, titulo, " +
                "sinopse, genero, classificacao" +
                " from tb_filme");
            dgvBanco.DataSource = banco;
        }

        private void TelaFilme_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_filme values(null, '" +
                 txtTitulo.Text + "','" + txtSinopse.Text + "','" +
                cbxGenero.SelectedValue + "','" + txtClassificacao.Text + "')";
            if (con.Executa(sql))
            {
                MessageBox.Show("Salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao salvar!");
            }
            CarregaTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "update tb_produto set codigo" +
                txtCodigo.Text.ToString() + "',titulo=" + txtTitulo.Text +
                "',sinopse=" + txtSinopse.Text +
                ",genero=" + cbxGenero.SelectedValue + "',classificacao=" + txtClassificacao.Text;
            if (con.Executa(sql))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }
            CarregaTabela();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select from tb_filme where codigo="
                + Convert.ToDouble(txtCodigo.Text);
            CarregaTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_filme where codigo="
                + txtCodigo.Text;
            if (con.Executa(sql))
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir.");
            }
            CarregaTabela();
        }

        private void dgvBanco_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(dgvBanco["codigo",
                e.RowIndex].Value);
            DataTable banco = con.Retorna("select * from tb_filme " +
                "where codigo=" + codigo);
            txtCodigo.Text = codigo.ToString();
            txtTitulo.Text = banco.Rows[0]["titulo"].ToString();
            txtSinopse.Text = banco.Rows[0]["sinopse"].ToString();
            cbxGenero.SelectedValue = Convert.ToInt32(banco.Rows[0]["genero"]);
            txtClassificacao.Text = banco.Rows[0]["classificacao"].ToString();
        }
    }
}
