using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLaboratorio4.Models
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public double Preco { get; set; }
        public double TotalBrutoFaturado { get; set; }
        public int QuantidadeDeVendas { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public List<Produto> ListaProdutos = new List<Produto>();

        public Produto(int _codigo, string _nome,  string _fabricante, double _preco, double _totalbrutofaturado, int _quantidadedevendas, int _quantidadeemestoque)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Fabricante = _fabricante;
            this.Preco = _preco;
            this.TotalBrutoFaturado = _totalbrutofaturado;
            this.QuantidadeDeVendas = _quantidadedevendas;
            this.QuantidadeEmEstoque = _quantidadeemestoque;
        }

        public Produto()
        {

        }
    }
}
