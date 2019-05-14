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

        public static void CorFocoLinhaForm(Panel linha) => linha.BackColor = System.Drawing.Color.LimeGreen;


        public static void CorLinhaForm(Panel linha) => linha.BackColor = System.Drawing.Color.White;




    }
}
