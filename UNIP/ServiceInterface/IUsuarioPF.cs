using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Dynamic;

namespace UNIP.ServiceInterface
{
    public class IUsuarioPF
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Digite o Nome", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public int CPF { get; set; }

        public string Endereco { get; set; }

        public string logradouro { get; set; }

        public string Numero { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public int ddd { get; set; }



    }
}