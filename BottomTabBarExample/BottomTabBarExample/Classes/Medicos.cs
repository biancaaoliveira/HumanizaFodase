using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class Medicos : Usuarios
    {
        private string CMR;
        public string cmr
        {
            get { return CMR; }
            set { CMR = value; }
        }

        public void Adicionar(string nome, string email, string senha, string cmr, List<Medicos> lc) 
        {

            var m = new Medicos()
            {
                Nome = nome,
                Email = email,
                Status = "Médico",
                Senha = senha,
                CMR = cmr
            };
            lc.Add(m);
        }
        public void Remover(string email, List<Medicos> lc)
        {

            foreach (Medicos m in lc)
            {
                if (m.Email == email)
                {
                    lc.Remove(m);
                    break;
                }
            }

        }
       
    }
}
