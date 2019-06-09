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
            //int user_id = Sessao.IdUsuario;
            //teste
            int user_id = 12;

            MessageBox.Show("Valor juros: " + valorJuros);

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Preencher os dados da simualação.
                    simulacao simulacaoInvestimento = new simulacao
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
                    bd.simulacao.Add(simulacaoInvestimento);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }
    }
}
