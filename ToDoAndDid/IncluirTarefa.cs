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
            Cursor.Current = Cursors.WaitCursor;
            string titulo = txtTitulo.Text;
            string data = DateTime.Now.ToShortDateString();
            toDoAndDidDB db = new toDoAndDidDB();
            tasks task = new tasks();

            task.titulo_task = titulo;
            task.data_abertura = Convert.ToDateTime(data);

            db.tasks.Add(task);
            db.SaveChanges();

            MessageBox.Show("Tarefa adicionada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ToDo todo = new ToDo();
            todo.fillTable();

            this.Close();
        }

        private void IncluirTarefa_Load(object sender, EventArgs e)
        {
            txtDataI.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtTitulo.Clear();
        }

        public void IncluirTarefa_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(var form in Application.OpenForms)
            {
                if(form.GetType().Name.Equals("ToDo"))
                {
                    ToDo teasjdasjjdasdsa = (ToDo)form;
                    teasjdasjjdasdsa.fillTable();
                }
            }
        }
    }
}
