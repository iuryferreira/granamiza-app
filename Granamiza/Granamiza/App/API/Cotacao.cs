using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;
using Granamiza.Modelo;
using Granamiza.Forms.Popup;
using System.Collections.Generic;
using Granamiza.App.Autenticacao;
using System.Linq;

namespace Granamiza.App.API
{
    class Cotacao
    {
        private readonly string apiUrl = "https://economia.awesomeapi.com.br/all/";

        public Cotacao()
        {
            AtualizarMoedasAsync();

        }

        private async Task<dynamic> EnviarRequisicaoAsync(string url)
        {

            dynamic dadosDaRequisicao;

            // Criando um WebRequest para a URL
            var webReq = (HttpWebRequest)WebRequest.Create(url);

            // Send the request to the Internet resource and wait for
            // the response.
            using (WebResponse response = await webReq.GetResponseAsync())

            {
                // Get the data stream that is associated with the specified url.
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream);
                    object json = reader.ReadToEnd();
                    dadosDaRequisicao = JsonConvert.DeserializeObject<dynamic>(json.ToString());
                }
            }
            // Return the result as a byte array.
            return dadosDaRequisicao;

        }

        internal static List<cotacao> Listar()
        {
            List<cotacao> listaCotacao;

            try
            {
                using(var bd = new granamizaEntities())
                {
                    listaCotacao = bd.cotacao.Where(c => c.usuario_id == Sessao.IdUsuario).ToList();
                }
                return listaCotacao;
            }
            catch
            {
                _ = new FrmPopupErro();
                return null;
            }

        }

        internal async Task AtualizarMoedasAsync()
        {
            await AtualizarDolarAsync();
            await AtualizarEuroAsync();
            await AtualizarBitcoinAsync();
        }

        internal async Task AtualizarDolarAsync()
        {
            string url;
            url = apiUrl + "USD-BRL";

            var dados = await EnviarRequisicaoAsync(url);

            Dolar.ValorAlta = dados.USD.high;
            Dolar.ValorBaixa = dados.USD.low;
            Dolar.DataConsulta = dados.USD.create_date;


        }

        internal async Task AtualizarEuroAsync()
        {
            string url;
            url = apiUrl + "EUR-BRL";

            var dados = await EnviarRequisicaoAsync(url);

            Euro.ValorAlta = dados.EUR.high;
            Euro.ValorBaixa = dados.EUR.low;
            Euro.DataConsulta = dados.EUR.create_date;
        }


        internal async Task AtualizarBitcoinAsync()
        {
            string url;
            url = apiUrl + "BTC-BRL";

            var dados = await EnviarRequisicaoAsync(url);

            Bitcoin.ValorAlta = dados.BTC.high;
            Bitcoin.ValorBaixa = dados.BTC.low;
            Bitcoin.DataConsulta = dados.BTC.create_date;
        }


        internal void Salvar(string valor_dolar, string valor_euro, string valor_bitcoin)
        {

            decimal valorUSD = Convert.ToDecimal(valor_dolar);
            decimal valorEUR = Convert.ToDecimal(valor_euro);
            decimal valorBTC = Convert.ToDecimal(valor_bitcoin);

            try
            {
                using(var bd = new granamizaEntities())
                {
                    cotacao c = new cotacao
                    {
                        valor_dolar = valorUSD,
                        valor_bitcoin = valorBTC,
                        valor_euro = valorEUR,
                        data_consulta = DateTime.Now,
                        usuario_id = Sessao.IdUsuario
                    };

                    bd.cotacao.Add(c);
                    bd.SaveChanges();
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }



        }

        internal void Excluir(int idCotacao)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    cotacao c = bd.cotacao.Where(ct => ct.id == idCotacao).FirstOrDefault();
                    if (c != null)
                    {
                        bd.cotacao.Remove(c);
                    }
                    bd.SaveChanges();
                }
            }
            catch
            {
                _ = new FrmPopupErro();
            }
        }

    }
}
