﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;

namespace Granamiza.App.CRUD.Categoria
{
    class CategoriaDespesa : ICategoriaDespesa
    {
        public int Salvar(string nomeCategoria)
        {
            int idCategoria = 0;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Tenta recuperar categoria através do nome:
                    categoria cat = (from c in bd.categoria
                                     where c.nome == nomeCategoria
                                     select c)
                                     .Where(u => u.usuario_id == Sessao.IdUsuario)
                                     .FirstOrDefault();

                    if (cat != null)
                    {
                        //Retorna o id para o usuario
                        idCategoria = cat.id;
                    }

                    // se não encontrou:
                    else
                    {
                        //cria uma nova
                        categoria nova_cat = new categoria
                        {
                            nome = nomeCategoria,
                            is_gasto = 1,
                            usuario_id = Sessao.IdUsuario
                        };

                        bd.categoria.Add(nova_cat);

                        bd.SaveChanges();

                        //Retorna o id ao usuário
                        idCategoria = nova_cat.id;
                    }
                }

                return idCategoria;
            }

            catch
            {
                _ = new FrmPopupErro();
                return idCategoria;
            }
        }
        public void Excluir(int idCategoria)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    categoria cat = (from c in bd.categoria
                                     where c.id == idCategoria
                                     select c).FirstOrDefault();
                    if (cat != null)
                    {
                        //Essa linha permite que transações que possuem id dessa categoria sejam removidas.
                        //cat.transacao.Clear();
                        bd.categoria.Remove(cat);
                        bd.SaveChanges();
                    }
                }
            }

            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        public List<vwcategoriadespesa> Listar()
        {
            List<vwcategoriadespesa> cr;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    cr = bd.vwcategoriadespesa.Where(c => c.usuario_id == Sessao.IdUsuario).ToList();
                }

                if (cr != null)
                {
                    return cr;
                }

                var listaCategoria = cr ?? null;
                return listaCategoria;
            }
            catch
            {
                _ = new FrmPopupErro();
                return null;
            }
        }

        public List<vwtotalcategoria> ListarQuantidadeCategorias()
        {
            List<vwtotalcategoria> tc;

            //try
            //{
                using (var bd = new granamizaEntities())
                {
                    tc = bd.vwtotalcategoria.Where(c => c.usuario_id == Sessao.IdUsuario).ToList();
                }

                if (tc != null)
                {
                    return tc;
                }

                var listaCategoria = tc ?? null;
                return listaCategoria;
            /*}
            catch
            {
                _ = new FrmPopupErro();
                return null;
            }*/
        }

        public List<vwcategoriadespesa> ListarCategoriasDespesasPagas()
        {
            List<vwcategoriadespesa> listaCategoriaDespesasPagas = new List<vwcategoriadespesa>();
            var tr = new Transacao.Despesa();
            var listaDespesasPagas = tr.ListarDespesasPagas();

            try
            {
                using (var bd = new granamizaEntities())
                {
                    foreach (var despesa in listaDespesasPagas)
                    {
                        var categoriaDP = bd.vwcategoriadespesa.Where(c => c.id == despesa.id).FirstOrDefault();
                        listaCategoriaDespesasPagas.Add(categoriaDP);
                    }
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }
            return listaCategoriaDespesasPagas;
        }

        public void VerificarCategorias()
        {
            List<vwcategoriadespesa> listaCategoria = Listar();

            using (var bd = new granamizaEntities())
            {
                foreach (var cat in listaCategoria)
                {
                    var categoria = bd.vwtransacaocategoria.Where(c => c.nome == cat.nome).FirstOrDefault();

                    if (categoria != null)
                    {
                        continue;
                    }
                    else
                    {
                        Excluir(cat.id);
                    }
                }
            }
        }


    }
}
