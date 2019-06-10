using Granamiza.App.Autenticacao;
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
    class SimulacaoInvestimento
    {
        internal static void Salvar(decimal valorInserido, decimal valorJuros, decimal aplicacoes_mes, int quantidadeMeses, double rendTotal)
        {
            DateTime dt = DateTime.Now;
            int user_id = Sessao.IdUsuario;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Preencher os dados da simulação.
                    simulacao s = new simulacao
                    {
                        valor_inserido = valorInserido,
                        juros = valorJuros,
                        qnt_meses = quantidadeMeses,
                        data_criacao = dt,
                        usuario_id = user_id,
                        aplicacoes_mensais = aplicacoes_mes,
                        rendimento_total = rendTotal,
                    };
                    //Adicionar Simulação
                    bd.simulacao.Add(s);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        internal static void Excluir(int idSimulacao)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Consulta usando LINQ
                    simulacao s = (from sim in bd.simulacao
                                                       where sim.id == idSimulacao
                                                       select sim).FirstOrDefault();
                    //Se encontrar simulação, deleta a ocorrência
                    if (s != null)
                    {
                        bd.simulacao.Remove(s);
                        bd.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }
    }
}
