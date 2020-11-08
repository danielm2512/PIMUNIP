using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIP.ServiceInterface
{
    public class IUsuarioPF
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Endereco { get; set; }

        public string Complemento { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }


    }
}