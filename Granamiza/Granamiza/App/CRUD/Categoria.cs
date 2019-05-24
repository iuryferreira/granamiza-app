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
        internal static void Salvar(TextBox txtNome, RadioButton rbGasto, int idCategoria)
        {
            //Tenta se conectar com o banco de dados.
            /*try
            {*/
                using (var bd = new granamizaEntities())
                {
                    //Salvar.
                    if (idCategoria == 0)
                    {
                        SByte is_gasto = 0;

                        if(rbGasto.Checked)
                        {
                            is_gasto = 1;
                        }
                        //Preencher os dados da categoria.
                        categoria cat = new categoria
                        {
                            nome = txtNome.Text,
                            is_gasto = is_gasto,
                            //Icone padrão
                            icone = "C:\\Users\\iuryf\\Documents\\GitHub\\granamiza-app\\Granamiza\\Granamiza\\Imagens\\info-icon"
                        };
                        //Adicionar categoria
                        bd.categoria.Add(cat);
                    }
                    //Atualizar
                    else
                    {
                        //Recuperar categoria através do id.
                        categoria cat = (from c in bd.categoria
                                         where c.id == idCategoria
                                         select c).FirstOrDefault();
                        //Testar se encontrou.
                        if (cat != null)
                        {
                            cat.nome = txtNome.Text;
                        }
                    }
                    bd.SaveChanges();
                }
            /*}*/
            //Se ocorrer erro ao conectar.
            /*catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }*/
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
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}