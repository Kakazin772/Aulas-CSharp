using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX_03
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }

            set
            {
                _preco = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

            set
            {
                _quantidade = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
