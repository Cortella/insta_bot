using System;
using System.Collections.Generic;
using System.Text;

namespace insta_bot
{
    class Profile
    {
        public string UserName { get; private set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
        public int NumSeguidores { get; set; }
        public int NumSeguindo { get; set; }

        public Profile(string userName,string senha)
        {
            UserName = userName;
            Senha = senha;
            Descricao = "Descricao";
        }
    }
}
