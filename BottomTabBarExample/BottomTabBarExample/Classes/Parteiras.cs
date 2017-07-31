using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    public class Parteiras : Usuarios
    {
        private string CursoUni;
        public string cursouni
        {
            get { return CursoUni; }
            set { CursoUni = value; }
        }

        protected string Telefone;
        public string telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public void Adicionar(string nome, string email, string senha, string cursouni, List<Parteiras> lc)
        {

            var p = new Parteiras()
            {
                Nome = nome,
                Email = email,
                Status = "Parteira",
                Senha = senha,
                CursoUni = cursouni
            };
            lc.Add(p);
        }
        public void Remover(string email, List<Parteiras> lc)
        {

            foreach (Parteiras p in lc)
            {
                if (p.Email == email)
                {
                    lc.Remove(p);
                    break;
                }
            }

        }
    }
}
