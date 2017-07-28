using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class Doulas : Usuarios
    {
        private List<string> Cursos;
        public List<string> cursos
        {
            get { return Cursos; }
            set { Cursos = value; }
        }

        public void Adicionar(string nome, string email, string senha, List<string> curso, List<Doulas>lc)
        {

            var d = new Doulas()
            {
                Nome = nome,
                Email = email,
                Status = "Doula",
                Senha = senha,
            };
            Cursos = new List<string>();
            foreach(string s in curso)
            {
                Cursos.Add(s);
            }
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
