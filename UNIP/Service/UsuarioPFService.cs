using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.Script.Serialization;

namespace UNIP.Service
{
    public class UsuarioPFService
    {
            public int Salvar(ServiceInterface.IUsuarioPF usuario, int idCaptacao)
            {
                var idRetorno = 0;
                using (UNIPPIMEntities save = new UNIPPIMEntities())
                {
                    try
                    {
                        Models.DT_USUARIO_PF usuarioDT = new Models.DT_USUARIO_PF();
                        usuarioDT.Nome = usuario.Nome;
                        usuarioDT.CPF = usuario.CPF.Replace("_", "").Trim(); ;
                        usuarioDT.Endereco = usuario.Endereco.Replace("_", "").Trim(); ;
                        usuarioDT.Complemento = usuario.Complemento;
                        usuarioDT.Numero = usuario.Numero.Replace("_", "").Trim();
                        usuarioDT.Cidade = usuario.Cidade;
                        usuarioDT.Telefone = usuario.Telefone.Replace("_", "").Trim(); ;
                        usuarioDT.Cep = usuario.Cep.Replace("_", "").Trim();
                        usuarioDT.NomeMae = usuario.NomeMae;
                        if (existeCPF == null )
                        {
                            save.DT_USUARIO_PF.Add(usuarioDT);
                            save.SaveChanges();
                            idRetorno = usuarioDT.ID;
                        }

                        else
                        {
                            idRetorno = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        return idRetorno;
                        throw;
                    }
                }
                return idRetorno;
            }

        }
    }
}