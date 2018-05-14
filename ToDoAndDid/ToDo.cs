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
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            IncluirTarefa tarefa = new IncluirTarefa();
            tarefa.Show();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDoAndDidDataSet1.tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter1.Fill(this.toDoAndDidDataSet1.tasks);
            // TODO: This line of code loads data into the 'toDoAndDidDataSet.tasks' table. You can move, or remove it, as needed.
            //this.tasksTableAdapter.Fill(this.toDoAndDidDataSet.tasks);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
