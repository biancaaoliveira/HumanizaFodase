using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    class Locais
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Endereco { get; set; }


        public void Adicionar(string nome, string telefone, string descricao, string endereco, double latitude, double longitude, List<Locais>lc) 
        {

            var l = new Locais()
            {
                Nome = nome,
                Telefone = telefone,
                Descricao = descricao,
                Endereco = endereco,
                Latitude = latitude,
                Longitude = longitude
            };

            lc.Add(l);
        }
        public void Remover(string nome, List<Locais> lc)
        {

            foreach (Locais l in lc)
            {
                if (l.Nome == nome)
                {
                    lc.Remove(l);
                    break;
                }
            }

        }
    }
}
