using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNIP.Models
{
    public class DT_Cadastro
    {
        [Display(Name = "Id")]
        public int ID { get; set; }
        [Display(Name = "Nome")]
        public string NOME { get; set; }
        [Display(Name = "Cpf")]
        public long CPF { get; set; }
        [Display(Name = "Endereço")]
        public string ENDERECO { get; set; }
        [Display(Name = "Logradouro")]
        public string LOGRADOURO { get; set; }
        [Display(Name = "Numero")]
        public int NUMERO { get; set; }
        [Display(Name = "Cep")]
        public int CEP { get; set; }
        [Display(Name = "Bairro")]
        public string BAIRRO { get; set; }
        [Display(Name = "Cidade")]
        public string CIDADE { get; set; }
        [Display(Name = "Estado")]
        public string ESTADO { get; set; }

        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
        [Display(Name = "DDD")]
        public int DDD { get; set; }
        [Display(Name = "Tipo")]
        public int TIPO { get; set; }


    }
}