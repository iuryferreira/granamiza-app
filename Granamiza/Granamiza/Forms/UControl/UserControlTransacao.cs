using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms.UControl
{
    public partial class UserControlTransacao : UserControl
    {

        Button btn_clicado;
        public UserControlTransacao()
        {
            InitializeComponent();
        }

        //O construtor que vamos usar é esse!
        public UserControlTransacao(Button botao_clicado)
        {
            InitializeComponent();
            this.btn_clicado = botao_clicado;
        }

        //Metodo mais relevante!
        private void UserControlTransacao_Load(object sender, EventArgs e)
        {
            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasouce
            //do gridview para receber somente os dados de transacões que não são gastos

            if (btn_clicado.Name == "btnReceita")
            {

                //Transacao.ListaReceita();
            }
            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasouce
            //do gridview para receber somente os dados de transacões que são gastos
            if (btn_clicado.Name == "btnDespesa")
            {


                // Transacao.ListaDespesa();

            }

        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            //Se o botão clicado no menu lateral for o de receita,  ele vai chamar o form de receita

            if (btn_clicado.Name == "btnReceita")
            {

                FrmReceita frm = new FrmReceita();
                frm.Show();
                AtualizarGrid();

            }

            //  Se o botao clicado no menu lateral for o de despesa ele chama o form de despesa
            if (btn_clicado.Name == "btnDespesa")
            {
                FrmDespesa frm = new FrmDespesa();
                frm.Show();
                AtualizarGrid();
            }
        }

        private void AtualizarGrid()
        {
            throw new NotImplementedException();
        }


    }
}

