using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class CadastroPage : Form
    {
        private MainWindow _mainWindow;
        public CadastroPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            if (SenhaTxt.Text == "")
            {
                MessageBox.Show("Erro", "Não deixe a senha vazia");
                return;
            }
            if (LoginTxt.Text == "")
            {
                MessageBox.Show("Erro", "Não deixe o login");
                return;
            }
            var usuario = new Usuario(LoginTxt.Text, SenhaTxt.Text);
            var session = _mainWindow.CreateAccount(usuario);
            if(session == LoginEnum.CreateRepeated)
            {
                MessageBox.Show("Erro!", "Usuario Já Cadastrado");
            }
            else
            {
                MessageBox.Show("Aviso!", "Usuario Cadastrado");

            }

        }
    }
}
