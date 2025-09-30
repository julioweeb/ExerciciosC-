using System;
using System.Globalization;

namespace AtividadeProduto
{
    class Produto
    {
        public String Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutos(int quantidade) 
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
