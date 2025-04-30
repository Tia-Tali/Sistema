using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class ProdutoInformation
    {
        private int IdProdutos { get; set; }
        private DateTime DataCadastro { get; set; }
        private string Produto { get; set; }
        private int NumeroSerie { get; set; }
        private int ValorCompra { get; set; }
        private int ValorVenda { get; set; }
        private int Quantidade { get; set; }
        private int MargemLucro { get; set; }
        private string Observação { get; set; }
    }
}
