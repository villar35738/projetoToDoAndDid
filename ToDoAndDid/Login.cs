using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoAndDid
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Entrar();
        }

        public void Entrar()
        {
            int id = Convert.ToInt32(txtUsuario.Text);
            string senha = txtSenha.Text;
            toDoAndDidDB db = new toDoAndDidDB();
            var userId = db.tela_login.Select(u => new { u.id_user, u.senha }).Where(l => l.id_user.Equals(id) && l.senha.Equals(senha));
            if (userId.Count() > 0)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
