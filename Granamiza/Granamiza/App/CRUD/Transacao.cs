using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.App.CRUD
{
    class Transacao
    {
        internal static void Salvar(TextBox txtDescricao, TextBox txtValor, TextBox txtTipoTransacao, int idCategoria, int idTransacao)
        {
            //Tenta se conectar com o banco de dados.
            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Salvar.
                    if (idTransacao == 0)
                    {
                        DateTime dt = DateTime.Now;
                        //Preencher os dados da categoria.
                        transacao tr = new transacao
                        {
                            descricao = txtDescricao.Text,
                            //É preciso restringir campo a valores numéricos
                            valor = Decimal.Parse(txtValor.Text),
                            tipo_transacao = SByte.Parse(txtTipoTransacao.Text),
                            hora_insercao = dt.Hour.ToString(),
                            data_insercao = dt.Date.ToString(),
                            data_criacao = dt,
                            categoria_id = idCategoria,
                        };
                        //Adicionar categoria
                        bd.transacao.Add(tr);
                    }
                    //Atualizar
                    else
                    {
                        //Recuperar transacao através do id.
                        transacao tr = (from c in bd.transacao
                                         where c.id == idTransacao
                                         select c).FirstOrDefault();
                        //Testar se encontrou.
                        if (tr != null)
                        {
                            tr.descricao = txtDescricao.Text;
                            //É preciso restringir campo a valores numéricos
                            tr.valor = Decimal.Parse(txtValor.Text);
                            tr.tipo_transacao = SByte.Parse(txtTipoTransacao.Text);
                            //tr.data_insercao = ;
                            //tr.hora_insercao = ;
                            //tr.data_criacao = ;
                            tr.categoria_id = idCategoria;
                            
                        }
                    }
                    bd.SaveChanges();
                }
            }
            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }

        internal static void Excluir(int idTransacao)
        {
            //Tenta se conectar com o banco de dados.
            try
            {
                using (var bd = new granamizaEntities())
                {
                    transacao tr = (from t in bd.transacao
                                     where t.id == idTransacao
                                     select t).FirstOrDefault();
                    if (tr != null)
                    {
                        bd.transacao.Remove(tr);
                        bd.SaveChanges();
                    }
                }
            }

            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}
