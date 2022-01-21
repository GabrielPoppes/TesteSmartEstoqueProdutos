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
            LimparCamposNovoProduto(); // Limpando os campos do novo Produto
        }
        #endregion

        #region Método para adicionar uma produto na lista - estrutura condicional para verificar se os campos estão preenchidos corretamente!
        public void AdicionarProdutoNaLista()
        {
            try
            {
                Produto produto = new Produto(Convert.ToInt32(txbCodigo.Text), txbNome.Text, txbFabricante.Text, Convert.ToDouble(txbPreco.Text), Convert.ToDouble(txbTotalBrutoFaturado.Text), Convert.ToInt32(txbQntEmVendas.Text), Convert.ToInt32(txbQntEmEstoque.Text));
                p.ListaProdutos.Add(produto);
                InserirCodigoNoComboBox();
            }

            catch(Exception error)
            {
                MessageBox.Show($"{error}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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

        #region Evento click do botão Atualizar Estoque - para atualizar o número de produtos em estoque
        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            #region Estrutura condicional verificando se todos os campos estão preenchidos corretamente
            if (comboBoxCodigo.SelectedIndex.Equals(-1) || txbQntVendida.Text == string.Empty)
            {
                MessageBox.Show("Por favor, verifique se selecionou a ID do produto, e informou a quantidade vendida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                AtualizarEstoque();
                LimparCamposGerenciadorDeEstoque();
            }
            #endregion
        }
        #endregion

        #region Método para atualizar o estoque de produtos, valor total faturado,  quantidade em estoque - e a estrutura condicional para validar se estão corretas as informações
        public void AtualizarEstoque()
        {
            #region Pegando o codigo do produto informado pelo usuário
            string _codigoProduto = comboBoxCodigo.SelectedItem.ToString();
            int codigoProduto = Convert.ToInt32(_codigoProduto);
            #endregion

            #region Pegando a quantidade de vendas feitas naquele produto - informado pelo usuário
            int qntVendas = Convert.ToInt32(txbQntVendida.Text);
            #endregion

            #region Atualizando a quantidade em estoque do produto, e o valor total faturado - com base na entrada de dados do usuário / Estrutura condicional para verificar se tem estoque suficiente para a venda
            Produto produtoAtualizacao = p.ListaProdutos.FirstOrDefault(a => a.Codigo == codigoProduto);

            #region Estrutura condicional - verificando se o usuário não passou um número de vendas, maior que o número do produto disponível em estoque
            int qntEstoqueAtual = produtoAtualizacao.QuantidadeEmEstoque;
            if(qntEstoqueAtual >= qntVendas)
            {
                produtoAtualizacao.QuantidadeEmEstoque -= qntVendas; // Atualizando a quantidade do produto em estoque
                produtoAtualizacao.QuantidadeDeVendas += qntVendas; // Atualizando a quantidade de vendas do produto
                produtoAtualizacao.TotalBrutoFaturado += (produtoAtualizacao.Preco * qntVendas); // Atualizando o valor total vendido daquele produto
            }

            else
            {
                MessageBox.Show("Atenção! A quantidade de venda informada, é maior que a quantidade de estoque disponível do produto! Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            #endregion

            #region Exibindo informações atualizadas sobre o produto - no campo "Informações atualizadas
            ExibirRegistrosAtualizados(codigoProduto);
            #endregion
        }
        #endregion

        #region Método para exibir os registros do produto atualizados - após alterar a quantidade de vendas
        public void ExibirRegistrosAtualizados(int codigoProduto)
        {
            Produto produtoAtualizacao = p.ListaProdutos.FirstOrDefault(a => a.Codigo == codigoProduto);

            #region Atualizando os campos Text Box
            txbNomeAtualizado.Text = produtoAtualizacao.Nome;
            txbPrecoAtualizado.Text = Convert.ToString(produtoAtualizacao.Preco);
            txbTotalBrutoFaturadoAtualizado.Text = Convert.ToString(produtoAtualizacao.TotalBrutoFaturado);
            txbQntVendasAtualizado.Text = Convert.ToString(produtoAtualizacao.QuantidadeDeVendas);
            txbQntEstoqueAtualizado.Text = Convert.ToString(produtoAtualizacao.QuantidadeEmEstoque);
            #endregion

        }
        #endregion

        #region Métodos para limpar campos (todos estão aqui)

        #region Método para limpar os campos de um novo Produto
        public void LimparCamposNovoProduto()
        {
            txbCodigo.Clear();
            txbNome.Clear();
            txbFabricante.Clear();
            txbPreco.Clear();
            txbTotalBrutoFaturado.Clear();
            txbQntEmVendas.Clear();
            txbQntEmEstoque.Clear();
        }
        #endregion

        #region Método para limpar os campos do gerenciador de estoque
        public void LimparCamposGerenciadorDeEstoque()
        {
            comboBoxCodigo.SelectedItem = null;
            txbQntVendida.Clear();
        }
        #endregion

        #region Método para limpar os campos dos registros atualizados
        public void LimparCampoRegistrosAtualizados()
        {
            txbNomeAtualizado.Clear();
            txbPrecoAtualizado.Clear();
            txbTotalBrutoFaturadoAtualizado.Clear();
            txbQntVendasAtualizado.Clear();
            txbQntEstoqueAtualizado.Clear();
        }
        #endregion

        #endregion

        #region Evento click no botão Limpar Campos - Dos registros atualizados
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampoRegistrosAtualizados();
        }
        #endregion
    }
}
