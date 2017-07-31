using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    public class Gravidas : Usuarios
    {
        public Gravidas()
        {

        }
        public Gravidas(string n, string e, string s)
        {
            nome = n;
            email = e;
            senha = s;
        }
        public void Adicionar(string nome, string email, string senha, List<Gravidas> lc)
        {
            var g = new Gravidas()
            {
                Nome = nome,
                Email = email,
                Status = "Grávida ou Planejando Gravidez",
                Senha = senha
            };
            lc.Add(g);

        }
        public void Remover(string email, List<Gravidas> lc)
        {

            foreach (Gravidas g in lc)
            {
                if (g.Email == email)
                {
                    lc.Remove(g);
                    break;
                }
            }

        }
        
    }
}
