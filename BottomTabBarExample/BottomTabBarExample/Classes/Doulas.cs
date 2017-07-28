using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class Doulas : Usuarios
    {
        private string Cursos;
        public string cursos
        {
            get { return Cursos; }
            set { Cursos = value; }
        }
        protected string Telefone;
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }

        public void Adicionar(string nome, string email, string curso, List<Doulas>lc, string telefone)
        {

            var d = new Doulas()
            {
                Nome = nome,
                Email = email,
                Status = "Doula",
               Telefone = telefone,
                Cursos = curso
            };
            
            lc.Add(d);
        }

        public void Remover(string email, List<Doulas> lc)
        {

           foreach (Doulas d in lc)
           {
                if(d.Email == email)
                {
                    lc.Remove(d);
                    break;
                }
           }
            
        }
    }
}
