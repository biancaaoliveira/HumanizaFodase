using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class TextosPlanoDeParto
    {
        private string Titulo;
        public string titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        private string Textos;
        public string textos
        {
            get { return Textos; }
            set { Textos = value; }
        }
        public void TextoPlanoDeParto(string titulo, string texto)
        {
            Titulo = titulo;
            textos = texto;
            
        }
    }
}
