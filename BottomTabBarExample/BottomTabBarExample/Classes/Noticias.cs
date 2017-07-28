using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class Noticias
    {

        private string Titulo;
        public string titulo 
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        private string Descricao;
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

        private string Imagem;
        public string imagem
        {
            get { return Imagem; }
            set { Imagem = value; }
        }

        public void Adicionar(string titulo, string descrição, string imagem, List<Noticias> lc)
        {

            var n = new Noticias()
            {
                Titulo = titulo,
                Descricao = descrição,
                Imagem = imagem
            };
            lc.Add(n);
        }
        public void Remover(string titulo, List<Noticias> lc)
        {

            foreach (Noticias n in lc)
            {
                if (n.Titulo == titulo)
                {
                    lc.Remove(n);
                    break;
                }
            }

        }

    }
}
