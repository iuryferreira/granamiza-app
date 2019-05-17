using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Granamiza.Forms
{


    //Esta classe tem como finalidade adicionar widgets personalizados que serão usados em toda a aplicação
    //Pra evitar reescrita de código desnecessária
    class MeusWidgets
    {
        // Define a cor da linha em LimeGreen
        public static void CorFocoLinhaForm(Panel linha) => linha.BackColor = System.Drawing.Color.Khaki;

        // Define a cor da linha em White
        public static void CorLinhaForm(Panel linha) => linha.BackColor = System.Drawing.Color.White;


        //Escreve o texto no label de validação
        public static string AvisoForm(Label aviso, string texto)
        {
            aviso.ForeColor = System.Drawing.Color.Khaki;
            aviso.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            return aviso.Text = texto;
        }


    }
}
