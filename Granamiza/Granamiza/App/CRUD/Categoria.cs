﻿using Granamiza.App.Autenticacao;
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
    class Categoria
    {

        //Esse metodo é chamado quando vamos salvar uma categoria nova, caso ela já exista, retorna 
        //o id para o usuário
        internal static int Salvar(string nomeCategoria, sbyte isGasto)
        {

            try
            {
                using (var bd = new granamizaEntities())
                {

                    

                    //Recuperar categoria através do nome.
                    categoria cat = (from c in bd.categoria
                                     where c.nome == nomeCategoria
                                     select c)
                                     .Where(u => u.usuario_id == Sessao.IdUsuario)
                                     .FirstOrDefault();
                    
                    if(cat != null)
                    {
                        //Retorna o id para o usuario
                        int id_categoria = cat.id;
                        return id_categoria;
                    }


                    // se não encontrou.
                    else
                    {
                        int id_user = Sessao.IdUsuario;
                        //cria uma nova
                        categoria nova_cat = new categoria
                        {
                            nome = nomeCategoria,
                            is_gasto = isGasto,
                            usuario_id = id_user
                        };

                        bd.categoria.Add(nova_cat);
                        bd.SaveChanges();

                        int id = nova_cat.id;

                        //Retorna o id ao usuário
                        return id;

                    }

                }

            }

            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return 0;
            }
        }


        internal static void Excluir(int idCategoria)
        {
            //Tenta se conectar com o banco de dados.
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
                        cat.transacao.Clear();
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
    }
}