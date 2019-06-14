using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.CRUD.Transacao
{
    interface ITransacao
    {

        //CUD
        void Salvar(decimal valorInserido, int idCategoria, string descricaoInserida);
        void Atualizar(int idTransacao, decimal valor, int idCategoria, string descricao);
        void Excluir(int idTransacao);

        //Quantificadores
        int GetQuantidade();
        decimal GetValorTotal();

    }

    interface IReceita : ITransacao
    {
        List<vwreceita> Listar();
        vwreceita GetReceitaSelecionada(int idTransacao);
    }

    interface IDespesa : ITransacao
    {
        //Listagem
        List<vwdespesa> Listar();
        List<vwdespesa> ListarDespesasPagas();
        List <vwdespesa> ListarDespesasAtivas();

        //Getters
        vwdespesa GetDespesaSelecionada(int idTransacao);
        decimal GetValorTotalDespesasAtivas();
        decimal GetValorTotalDespesasPagas();
        int GetQuantidadeDespesasPagas();

        //Ação
        void Pagar(int idTransacao);
        



    }
}
