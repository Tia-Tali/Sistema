using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class EmpresaInformation
    {
        private int IdEmpresa { get; set; }
        private int Datacadastro { get; set; }
        private string RazaoSocial { get; set; }
        private string Nomefantasia { get; set; }
        private int CNPJ { get; set; }
        private int IncricaoEstadual { get; set; }
        private string EnderecoEmpresa { get; set; }
        private int Numero { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private int CEP { get; set; }
        private string TipoFornecedor { get; set; }
        private string Segmento { get; set; }
        private string RegimeTributario { get; set; }
        private string TipoCobranca { get; set; }
        private string EmailEmpresa { get; set; }
        private int DadosBancarios { get; set; }
        private string Observacao { get; set; }
    }
}
