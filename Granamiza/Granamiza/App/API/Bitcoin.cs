using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.API
{
    public static class Bitcoin
    {
        private static string nomeMoeda;
        private static string valorAlta;
        private static string valorBaixa;
        private static DateTime dataConsulta;

        public static string NomeMoeda { get => nomeMoeda; set => nomeMoeda = value; }
        public static string ValorAlta { get => valorAlta; set => valorAlta = value; }
        public static string ValorBaixa { get => valorBaixa; set => valorBaixa = value; }
        public static DateTime DataConsulta { get => dataConsulta; set => dataConsulta = value; }
    }
}
