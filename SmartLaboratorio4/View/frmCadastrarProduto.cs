using SmartLaboratorio4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLaboratorio4.View
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }
        Produto p = new Produto();

        #region Evento click do botão adicionar produto - adicionar produto na lista
        public void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionarProdutoNaLista();
        }
        #endregion

        #region Método para adicionar uma produto na lista
        public void AdicionarProdutoNaLista()
        {
            Produto produto = new Produto(Convert.ToInt32(txbCodigo.Text), txbNome.Text, txbFabricante.Text, Convert.ToDouble(txbPreco.Text), Convert.ToDouble(txbTotalBrutoFaturado.Text), Convert.ToInt32(txbQntEmVendas.Text), Convert.ToInt32(txbQntEmEstoque.Text));
            p.ListaProdutos.Add(produto);
            MessageBox.Show("Teste");
            InserirCodigoNoComboBox();
        }
        #endregion

        #region Método para passar os códigos do produto na Combo Box
        public void InserirCodigoNoComboBox()
        {
            comboBoxCodigo.Items.Clear(); // Limpando a combo box a cada atualização - para não ter duplicidade de itens
            foreach (Produto c in p.ListaProdutos)
            {
                comboBoxCodigo.Items.Add(c.Codigo);
            }
        }
        #endregion

        public void btnTeste_Click(object sender, EventArgs e)
        {
            foreach (Produto c in p.ListaProdutos)
            {                
                MessageBox.Show(c.Nome);                
                MessageBox.Show(c.Fabricante);                
                MessageBox.Show(Convert.ToString(c.QuantidadeEmEstoque));                
                MessageBox.Show(Convert.ToString(c.TotalBrutoFaturado));                
            }
        }

        #region Evento click do botão Atualizar Estoque - para atualizar o número de produtos em estoque
        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            AtualizarEstoque();
        }
        #endregion

        #region Método para atualizar o estoque de produtos, e o valor total faturado
        public void AtualizarEstoque()
        {
            #region Pegando o codigo do produto informado pelo usuário
            string _codigoProduto = comboBoxCodigo.SelectedItem.ToString();
            int codigoProduto = Convert.ToInt32(_codigoProduto);
            #endregion

            #region Pegando a quantidade de vendas feitas naquele produto - informado pelo usuário
            int qntVendas = Convert.ToInt32(txbQntVendida.Text);
            #endregion

            #region Atualizando a quantidade em estoque do produto, e o valor total faturado - com base na entrada de dados do usuário
            Produto produtoAtualizacao = p.ListaProdutos.FirstOrDefault(a => a.Codigo == codigoProduto);
            produtoAtualizacao.QuantidadeEmEstoque -= qntVendas;
            produtoAtualizacao.TotalBrutoFaturado += (produtoAtualizacao.Preco * qntVendas);
            #endregion
        }
        #endregion
    }
}
