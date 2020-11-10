using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIP.Models
{
    public class UsuarioDAL
    {
        public static bool VerificaEmail(string Nome)
        {
            using (DB_UNIPPIMEntities4 dc = new DB_UNIPPIMEntities4())
            {
                var existeEmail = (from u in dc.DT_Pessoa
                                   where u.NOME == Nome
                                   select u).FirstOrDefault();
                if (existeEmail != null)
                    return true;
                else
                    return false;
            }
        }
    }
}