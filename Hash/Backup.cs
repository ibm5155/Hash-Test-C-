using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public static class Backup
    {

        public static List<Usuario> GetBackup()
        {
            var lista = new List<Usuario>();
            if (!File.Exists("Backup.txt"))
            {
                File.Create("Backup.txt");
            }
            else
            {
                using (var tw = new StreamReader("Backup.txt", true))
                {
                    while (!tw.EndOfStream)
                    {
                        var login = tw.ReadLine();
                        var hash = tw.ReadLine();
                        lista.Add(new Usuario { Nome = login, Hash = hash });
                    }
                }

            }
            return lista;
        }

        public static void AddBackup(Usuario usuario)
        {
            using (var tw = new StreamWriter("Backup.txt", true))
            {
                tw.WriteLine(usuario.Nome);
                tw.WriteLine(usuario.Hash);
            }
        }
    }
}
