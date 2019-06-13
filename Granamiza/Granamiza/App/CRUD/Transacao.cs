using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.CRUD
{
    class Transacao
    {

        //Recebe os valores inseridos já formatados
        internal static void Salvar(decimal valorInserido, int idCategoria, string descricaoInserida, sbyte tipoTransacao, bool debitada)
        {

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Salvar.
                    DateTime dt = DateTime.Now;
                    int user_id = Sessao.IdUsuario;

                    //Preencher os dados da categoria.
                    transacao tr = new transacao
                    {
                        valor = valorInserido,
                        categoria_id = idCategoria,
                        descricao = descricaoInserida,
                        tipo_transacao = tipoTransacao,
                        debitada = debitada,
                        hora_insercao = dt.Hour.ToString() + ":" + dt.Minute.ToString(),
                        data_insercao = dt.Day.ToString() + "/" + dt.Month + "/" + dt.Year,
                        data_criacao = dt,
                        usuario_id = user_id,
                    };
                    //Adicionar Transacao
                    bd.transacao.Add(tr);
                    bd.SaveChanges();                    

                }
            }

            catch
            {
                _ = new FrmPopupErro();
            }
        }

        internal static List<vwreceita> ListarReceitas()
        {
            try
            {

                List<vwreceita> listaReceitas;

                using (var bd = new granamizaEntities())
                {
                    //Recupera o 
                    listaReceitas = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).ToList();

                }

                return listaReceitas;
            }

            catch
            {

                _ = new FrmPopupErro();

                return null;
            }

         


        }

        internal static List<vwdespesa> ListarDespesas(bool debitada=false)
        {
            try
            {
                List<vwdespesa> listaDespesas;

                using (var bd = new granamizaEntities())
                {

                    if (debitada == true)
                    {
                        listaDespesas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Where(d => d.debitada == true).ToList();

                    }

                    else
                    {
                        listaDespesas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Where(d => d.debitada != true).ToList();
                    }

                }

                return listaDespesas;
            }
            catch
            {
                _ = new FrmPopupErro();
                return null;
                
            }

        }

        internal static void Pagar(int idTransacao)
        {
            using (var bd = new granamizaEntities())
            {
                transacao tr = (from c in bd.transacao
                                where c.id == idTransacao
                                select c).FirstOrDefault();
                //Testar se encontrou.
                if (tr != null)
                {
                    tr.debitada = true;
                    bd.SaveChanges();
                }
            }
        }
    }

}
           
