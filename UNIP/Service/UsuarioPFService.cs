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
using System.Web.UI;
using UNIP.Models;

namespace UNIP.Service
{
    public class UsuarioPFService
    {
            public int Salvar(ServiceInterface.IUsuarioPF usuario)
            {
                var idRetorno = 0;
                using (DB_UNIPPIMEntities4 save = new DB_UNIPPIMEntities4())
                {
                    try
                    {
                    Models.DT_Pessoa usuarioPessoa = new Models.DT_Pessoa();
                    Models.DT_Endereco usuarioEndereco = new Models.DT_Endereco();
                    Models.DT_Telefone usuarioTelefone = new Models.DT_Telefone();
                    Models.DT_Telefone_Tipo usuarioTelefoneTipo = new Models.DT_Telefone_Tipo();

                    usuarioPessoa.ID = usuario.ID;
                    usuarioPessoa.NOME = usuario.Nome;
                    usuarioPessoa.CPF = usuario.CPF;
                    usuarioEndereco.ID = usuario.ID;
                    usuarioPessoa.ENDERECO = usuarioEndereco.ID;


                    var existeCPF = (from u in save.DT_Pessoa
                                     where (u.CPF == usuario.CPF)
                                     select u).FirstOrDefault();

                    if (existeCPF == null )
                        {
                            save.DT_Pessoa.Add(usuarioPessoa);
                            save.SaveChanges();
                            idRetorno = usuarioPessoa.ID;
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