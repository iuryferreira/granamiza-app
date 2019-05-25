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
        internal static void Salvar(TextBox txtDescricao, TextBox txtValor, TextBox txtTipoTransacao, ComboBox cbCategoria, TextBox txtIdTransacao)
        {
            //Tenta se conectar com o banco de dados.
            try
            {
            using (var bd = new granamizaEntities())
            {
                int idTransacao = int.Parse(txtIdTransacao.Text);
                int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
                //Salvar.
                if (idTransacao == -1)
                {
                    DateTime dt = DateTime.Now;
                    //Preencher os dados da categoria.
                    transacao tr = new transacao
                    {
                        descricao = txtDescricao.Text,
                        //É preciso restringir campo a valores numéricos
                        valor = Decimal.Parse(txtValor.Text.Trim()),
                        tipo_transacao = SByte.Parse(txtTipoTransacao.Text),
                        hora_insercao = dt.Hour.ToString() + ":" + dt.Minute.ToString(),
                        data_insercao = dt.Day.ToString() + ":" + dt.Month + ":" + dt.Year,
                        data_criacao = dt,
                        categoria_id = idCategoria,
                        usuario_id = 18,
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
