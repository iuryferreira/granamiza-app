using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.API
{
    class Cotacao
    {
        private readonly string apiUrl = "https://economia.awesomeapi.com.br/all/";

        public Cotacao()
        {
            AtualizarDolar();
            AtualizarEuro();

        }

        private dynamic EnviarRequisicao(string url)
        {

            WebRequest requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            dynamic dados;
            using (var resposta = requisicaoWeb.GetResponse())
            {

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object json = reader.ReadToEnd();
                dados =  JsonConvert.DeserializeObject<dynamic>(json.ToString());
                streamDados.Close();
                resposta.Close();
            }

            return dados;

        }

        internal void AtualizarMoedas()
        {
            AtualizarDolar();
            AtualizarEuro();
        }

        internal void AtualizarDolar()
        {
            string url;
            url = apiUrl + "USD-BRL";

            var dados = EnviarRequisicao(url);

            Dolar.ValorAlta = dados.USD.high;
            Dolar.ValorBaixa = dados.USD.low;
            Dolar.DataConsulta = dados.USD.create_date;


        }

        internal void AtualizarEuro()
        {
            string url;
            url = apiUrl + "EUR-BRL";

            var dados = EnviarRequisicao(url);

            Euro.ValorAlta = dados.EUR.high;
            Euro.ValorBaixa = dados.EUR.low;
            Euro.DataConsulta = dados.EUR.create_date;
        }

    }
}
