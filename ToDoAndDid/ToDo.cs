using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public static toDoAndDidDB db = new toDoAndDidDB();
        public static tasks task = new tasks();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string titulo = txtTask.Text;
            var dados = db.tasks.Where(f => f.titulo_task.Contains(titulo)).ToList();

            dataGridView1.DataSource = dados;
            dataGridView1.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IncluirTarefa tarefa = new IncluirTarefa();
            tarefa.Show();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        public void fillTable()
        {
            this.tasksTableAdapter1.Fill(this.toDoAndDidDataSet1.tasks);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //toDoAndDidDB db = new toDoAndDidDB();

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    var row = item.Index;
                    var rowId = item.DataGridView.SelectedCells[0].Value;
                    dataGridView1.Rows.RemoveAt(row);
                    task = db.tasks.Find(rowId);
                    db.tasks.Remove(task);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Para deletar uma tarefa, clique na seta para direita( > ) para selecionar toda a linha.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //toDoAndDidDB db = new toDoAndDidDB();

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    var row = item.Index;
                    var rowId = item.DataGridView.SelectedCells[0].Value;
                    string data = DateTime.Now.ToShortDateString();

                    dataGridView1.Rows.RemoveAt(row);
                    task = db.tasks.Find(rowId);
                    task.data_encerramento = Convert.ToDateTime(data);
                    db.Entry(task).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Para finalizar uma tarefa, clique na seta para direita( > ) para selecionar toda a linha.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //toDoAndDidDB db = new toDoAndDidDB();

            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell item in this.dataGridView1.SelectedCells)
                {
                    var rowId = item.OwningRow.Cells[0].Value;
                    var titulo = item.DataGridView.SelectedCells[0].Value;
                    task = db.tasks.Find(rowId);
                    task.titulo_task = (string)titulo;
                    db.Entry(task).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            fillTable();
            dataGridView1.DataSource = toDoAndDidDataSet1.tasks.ToList();
        }
    }
}
