using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Usuario
    {
        public string Nome;
        private string _senha;
        public string Hash;

        public Usuario(string nome, string senha)
        {

            Hash = md5.GetMd5AsString(senha);
            _senha = senha;
            Nome = nome;

        }

        public Usuario()
        {

        }
    }
}
