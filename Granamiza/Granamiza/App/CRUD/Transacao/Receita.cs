using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;

namespace Granamiza.App.CRUD.Transacao
{
    class Receita : IReceita
    {

        public void Salvar(decimal valorInserido, int idCategoria, string descricaoInserida)
        {
            try
            {

                //sbyte tipoTransacao, bool debitada
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
                        tipo_transacao = 0,
                        debitada = false,
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

        public void Atualizar(int idTransacao, decimal valor, int idCategoria, string descricao)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    transacao tr = (from c in bd.transacao
                                    where c.id == idTransacao
                                    select c).FirstOrDefault();
                    if (tr != null)
                    {
                        tr.valor = valor;
                        tr.descricao = descricao;
                        tr.categoria_id = idCategoria;
                    }

                    bd.SaveChanges();
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }
        }

        public void Excluir(int idTransacao)
        {

            try
            {
                using (var bd = new granamizaEntities())
                {
                    transacao tr = (from c in bd.transacao
                                    where c.id == idTransacao
                                    select c).FirstOrDefault();
                    if (tr != null)
                    {
                        bd.transacao.Remove(tr);
                    }

                    bd.SaveChanges();
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }
    }

        public List<vwreceita> Listar()
        {
            try
            {
                List<vwreceita> listaReceitas;

                using (var bd = new granamizaEntities())
                {
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

        public int GetQuantidade()
        {
            int qtdReceita = 0;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    qtdReceita = bd.vwreceita.Count(r => r.usuario_id == Sessao.IdUsuario);
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }

            return qtdReceita;
        }

        public vwreceita GetReceitaSelecionada(int idTransacao)
        {
            try
            {
                vwreceita r;

                using (var bd = new granamizaEntities())
                {
                    r = bd.vwreceita.Where(re => re.id == idTransacao).FirstOrDefault();
                }
                return r;
            }
            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public decimal GetValorTotal()
        {
            decimal valorReceitaTotal = 0;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    valorReceitaTotal = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor);

                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }

            return valorReceitaTotal;
        }
    }
}
