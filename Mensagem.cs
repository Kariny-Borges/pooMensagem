using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PooMensagem
{
    public class Mensagem
    {
        //private string TextoMensagem;

        //// Método correto
        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(TextoMensagem);
        //}

        //public String getTextoMensagem()
        //{
        //    return this.TextoMensagem;
        //}
        //public void setTextoMensagem(String valor)
        //{
        //    this.TextoMensagem = valor.ToUpper();

        //}

        private String textomensagem;
        public String Textomensagem
        { 
            get //representa método de acesso que vai pegar um valor da propriedade 
            { return this.textomensagem; 
            } 
            set // define o valor da propriedade
            { this.textomensagem = value.ToUpper(); 
            } 
        }

        public void ExibirMensagem()
        {
           Console.WriteLine(this.Textomensagem);
        }
    }

}


