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
            fillTable();
            // TODO: This line of code loads data into the 'toDoAndDidDataSet.tasks' table. You can move, or remove it, as needed.
            //this.tasksTableAdapter.Fill(this.toDoAndDidDataSet.tasks);

        }

        public void fillTable()
        {
            this.tasksTableAdapter1.Fill(this.toDoAndDidDataSet1.tasks);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            toDoAndDidDB db = new toDoAndDidDB();
            
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                var row = item.Index;
                var rowId = item.DataGridView.SelectedCells[0].Value;
                dataGridView1.Rows.RemoveAt(row);
                tasks task = db.tasks.Find(rowId);
                db.tasks.Remove(task);
                db.SaveChanges();
            }
        }
    }
}
