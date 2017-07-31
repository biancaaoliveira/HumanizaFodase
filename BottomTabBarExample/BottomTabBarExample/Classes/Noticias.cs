using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarExample.Classes
{
    public class Noticias
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

        private ImageSource Imagem;
        public ImageSource imagem
        {
            get { return Imagem; }
            set { Imagem = value; }
        }

        public void Adicionar(string titulo, string descricao, string imagem, List<Noticias> lc)
        {

            var n = new Noticias()
            {
                Titulo = titulo,
                Descricao = descricao,
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

        public void Noticia(string titulo, string descricao, string imagem)
        {
            Titulo = titulo;
            Descricao = descricao;
            Imagem = imagem;
        }

    }
}
