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
    public partial class LoginPage : Form
    {
        private MainWindow _mainWindow;
        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void LogarButton_Click(object sender, EventArgs e)
        {
            if(SenhaTxt.Text == "")
            {
                MessageBox.Show("Erro", "Não deixe a senha vazia");
                return;
            }
            if(LoginTxt.Text == "")
            {
                MessageBox.Show("Erro", "Não deixe o login");
                return;
            }
            var usuario = new Usuario(LoginTxt.Text, SenhaTxt.Text);
            var result = _mainWindow.CreateAccount(usuario);
            if(result == LoginEnum.CreateOk)
            {
                MessageBox.Show("Usuário " + usuario.Nome + " cadastrado", "OK");
            }
            else
            {
                MessageBox.Show("Usuário " + usuario.Nome + " já existe", "OK");
            }
        }
    }
}
