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
    public partial class IncluirTarefa : Form
    {
        public IncluirTarefa()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string data = DateTime.Now.ToShortDateString();
            toDoAndDidDB db = new toDoAndDidDB();
            tasks task = new tasks();

            task.titulo_task = titulo;
            task.data_abertura = Convert.ToDateTime(data);

            db.tasks.Add(task);
            db.SaveChanges();

            MessageBox.Show("Tarefa adicionada com sucesso!");
        }

        private void IncluirTarefa_Load(object sender, EventArgs e)
        {
            txtDataI.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
        }
    }
}
