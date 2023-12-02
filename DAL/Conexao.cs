using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {

                //return @"User Id=Leandro_Sousa\leand;Initial Catalog=Gestao;Data Source=.\LEANDRO_SOUSA";

                // return "User ID=SA;Initial Catalog=sgreservas;Data Source=.\\SQLEXPRESS2019;Password=Senailab02";

                //return @"User Id = leand; Initial catalog= GestaoEscolar; Data Source= LEANDRO_SOUSA";



                if (String.IsNullOrEmpty(Constantes.StringDeConexao))
                {
                    if (File.Exists(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao))
                        Constantes.StringDeConexao = File.ReadAllText(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao);
                    else
                        throw new Exception("É preciso criar a string de conexão") { Data = { { "Id", 1 } } };
                }
                return Constantes.StringDeConexao;
            }
        }
    }
}


