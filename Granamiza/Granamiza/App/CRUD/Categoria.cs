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
        internal static int Salvar(string nomeCategoria, sbyte isGasto)
        {

            try
            {
                using (var bd = new granamizaEntities())
                {

                    

                    //Recuperar categoria através do id.
                    categoria cat = (from c in bd.categoria
                                     where c.nome == nomeCategoria
                                     select c).FirstOrDefault();
                    
                    if(cat != null)
                    {
                        int id_categoria = cat.id;
                        return id_categoria;
                    }


                    // se não encontrou.
                    else
                    {
                        categoria nova_cat = new categoria
                        {
                            nome = nomeCategoria,
                            is_gasto = isGasto
                        };

                        bd.categoria.Add(nova_cat);
                        bd.SaveChanges();

                        int id = nova_cat.id;

                        return id;

                    }

                }

            }

        //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");

                return 0;
            }
        }

        //internal static void Excluir(int idCategoria)
        //{
        //    //Tenta se conectar com o banco de dados.
        //    try
        //    {
        //        using (var bd = new granamizaEntities())
        //        {
        //            categoria cat = (from c in bd.categoria
        //                             where c.id == idCategoria
        //                             select c).FirstOrDefault();
        //            if (cat != null)
        //            {
        //                //Essa linha permite que transações que possuem id dessa categoria sejam removidas.
        //                cat.transacao.Clear();
        //                bd.categoria.Remove(cat);
        //                bd.SaveChanges();
        //            }
        //        }
        //    }

        //    //Se ocorrer erro ao conectar.
        //    catch (Exception)
        //    {
        //        _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
        //    }
        //}
    }
}