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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tAREFASAFAZERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ToDo toDo = new ToDo();
            toDo.Show();
        }

        private void tAREFASFINALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Did did = new Did();
            did.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
        }
    }
}
