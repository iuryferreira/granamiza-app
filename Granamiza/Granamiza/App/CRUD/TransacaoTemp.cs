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
    class TransacaoTemp
    {

        //Recebe os valores inseridos já formatados
        internal static void Salvar(decimal valorInserido, int idCategoria, string descricaoInserida, sbyte tipoTransacao)
        {

            /*try
            {*/
                using (var bd = new granamizaEntities())
                {
                    //Salvar.
                    DateTime dt = DateTime.Now;

                    //Preencher os dados da categoria.
                    int user_id = Sessao.IdUsuario;

                    transacao tr = new transacao
                    {
                        valor = valorInserido,
                        categoria_id = idCategoria,
                        descricao = descricaoInserida,
                        //É preciso restringir campo a valores numéricos
                        tipo_transacao = tipoTransacao,
                        hora_insercao = dt.Hour.ToString() + ":" + dt.Minute.ToString(),
                        data_insercao = dt.Day.ToString() + ":" + dt.Month + ":" + dt.Year,
                        data_criacao = dt,

                        //Para teste
                        usuario_id = user_id,
                    };
                    //Adicionar Transacao
                    bd.transacao.Add(tr);
                    bd.SaveChanges();
                    _ = new FrmPopup("Remuneração inserida com sucesso!", "Sucesso");
                    

                }
            //}

            /*catch
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }*/
        }

    }

}
           
