using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.CRUD.Categoria
{
    interface ICategoria
    {
        int Salvar(string nomeCategoria);
        void Excluir(int idCategoria);
        void VerificarCategorias();

    }

    interface ICategoriaReceita : ICategoria
    {
        List<vwcategoriareceita> Listar();
    }

    interface ICategoriaDespesa : ICategoria
    {
        List<vwcategoriadespesa> Listar();

        List<vwcategoriadespesa> ListarCategoriasDespesasPagas();

        List<vwtotalcategoria> ListarQuantidadeCategorias();
    }
}
