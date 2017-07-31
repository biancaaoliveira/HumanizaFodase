using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomTabBarExample.Classes
{
    public class Usuarios
    {
        protected string Nome;
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
      

        protected string Email;
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        protected string Status;
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

        protected string Senha;
        public string senha
        {
            get { return Senha; }
            set { Senha = value; }
        }

       
    }
}
