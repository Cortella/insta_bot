using System;
using System.Collections.Generic;
using System.Text;

namespace insta_bot
{
    class Profile
    {
        public string Id { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int Seguidores { get; set; }
        public int Seguindo { get; set; }
        public bool Logado { get; set; }

        Profile(string Id_, string Senha_)
        {
            Id = Id_;
            Senha = Senha_;
            Nome = "";
            Seguidores = 0;
            Seguindo = 0;
            Logado = false;
        }

        public void Logar()
        {
            
        }

    }
}
