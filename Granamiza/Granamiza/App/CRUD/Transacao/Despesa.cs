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
    class Despesa : IDespesa
    {
        public void Salvar(decimal valorInserido, int idCategoria, string descricaoInserida)
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
                        tipo_transacao = 1,
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

        public List<vwdespesa> Listar()
        {
            try 
            {
                List<vwdespesa> listaDespesas;

                using (var bd = new granamizaEntities())
                {
                    listaDespesas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario)
                        .Where(d => d.debitada == false).ToList();
                }

                return listaDespesas;
            }

            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public List<vwdespesa> ListarDespesasAtivas()
        {
            try 
            {
                List<vwdespesa> listaDespesasAtivas;

                using (var bd = new granamizaEntities())
                {
                    listaDespesasAtivas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario)
                        .Where(d => d.debitada == false).ToList();
                }

                return listaDespesasAtivas;
            }

            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public List<vwdespesa> ListarDespesasPagas()
        {
            try 
            {
                List<vwdespesa> listaDespesas;

                using (var bd = new granamizaEntities())
                {
                    listaDespesas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario)
                        .Where(d => d.debitada == true).ToList();
                }

                return listaDespesas;
            }

            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public vwdespesa GetDespesaSelecionada(int idTransacao)
        {
            try 
            {
                vwdespesa d;

                using (var bd = new granamizaEntities())
                {
                    d = bd.vwdespesa.Where(re => re.id == idTransacao).FirstOrDefault();
                }
                return d;
            }

            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public int GetQuantidade()
        {
            int qtdDespesas = 0;
            try 
            {
                using (var bd = new granamizaEntities())
                {
                    qtdDespesas = bd.vwdespesa.Count(r => r.usuario_id == Sessao.IdUsuario);
                }
            }

            catch
            {
                _ = new FrmPopupErro();
            }

            return qtdDespesas;
        }

        public int GetQuantidadeDespesasPagas()
        {
            int qtdDespesasPagas = 0;

            try 
            {
                using (var bd = new granamizaEntities())
                {
                    qtdDespesasPagas = bd.vwdespesa.Where(dp => dp.usuario_id == Sessao.IdUsuario)
                        .Where(dp => dp.debitada == true).Count();
                }
            }

            catch
            {
                _ = new FrmPopupErro();
            }

            return qtdDespesasPagas;
        }

        public decimal GetValorTotal()
        {
            decimal valorDespesaTotal = 0;

            try 
            {
                using (var bd = new granamizaEntities())
                {
                    valorDespesaTotal = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Sum(d => (decimal?)d.valor) ?? 0;
                }
            }
             
            catch
            {
                _ = new FrmPopupErro();
            }
            return valorDespesaTotal;
        }

        public decimal GetValorTotalDespesasAtivas()
        {
            decimal valorDespesasAtivas = 0;

            try 
            {
                using (var bd = new granamizaEntities())
                {
                    valorDespesasAtivas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario)
                        .Where(d => d.debitada == false).Sum(d => (decimal?)d.valor) ?? 0;
                }
            }
             
            catch
            {
                _ = new FrmPopupErro();
            }

            return valorDespesasAtivas;
        }

        public decimal GetValorTotalDespesasPagas()
        {
            decimal valorDespesasPagas = 0;

            try 
            {
                using (var bd = new granamizaEntities())
                {
                    valorDespesasPagas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario)
                        .Where(d => d.debitada == true).Sum(d => (decimal?)d.valor) ?? 0;
                }
            }
             
            catch

            {
                _ = new FrmPopupErro();
            }

            return valorDespesasPagas;
        }

        public void Pagar(int idTransacao)
        {
            try 
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

            catch
            {
                _ = new FrmPopupErro();
            }

        }
    }
}
