using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class MainWindow : Form
    {

        List<Usuario> listaUsuarios = Backup.GetBackup();
        LoginPage logincadastro;
        CadastroPage cadastropage;


        public MainWindow()
        {
            InitializeComponent();
             logincadastro = new LoginPage(this);
             cadastropage = new CadastroPage(this);
            logincadastro.Show();
            cadastropage.Show();
        }
        public LoginEnum CreateAccount(Usuario usuario)
        {
            lock (listaUsuarios)
            {
                var repeated = listaUsuarios.Where(x => x.Nome == usuario.Nome).DefaultIfEmpty(null).First();
                if (repeated != null)
                {
                    return LoginEnum.CreateRepeated;
                }
                listaUsuarios.Add(usuario);
            }
            Backup.AddBackup(usuario);
            return LoginEnum.CreateOk;
        }

        public LoginEnum GetSession(string Nome, string Hash)
        {
            Usuario usuario = listaUsuarios.Where(x => x.Nome.Equals(Nome)).DefaultIfEmpty(null).First();
            if(usuario == null)
            {
                return LoginEnum.LoginNotFound;
            }
            if (usuario.Hash == Hash)
            {
                return LoginEnum.LoginOk;
            }
            return LoginEnum.LoginWrong;
        }

        private void BruteForceButton_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                var lista = Backup.GetBackup();
                string[] array = new string[lista.Count];
                var time = new Stopwatch();
                time.Start();
                for (int i = 0; i < lista.Count; i++)
                {
                    array[i] = md5.CrackMd5(lista[i].Hash);
                }
                time.Stop();
                string message = "Quebrado em " + time.ElapsedMilliseconds / 1000 + " segundos \n";
                for (int i = 0; i < lista.Count; i++)
                {
                    message += "Login:" + lista[i].Nome + " Senha:" + array[i] + "\n";
                }
                MessageBox.Show(message);
            }).Start();
        }
    }
}
