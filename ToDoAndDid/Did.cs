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
    public partial class Did : Form
    {
        public Did()
        {
            InitializeComponent();
        }
        
        public static toDoAndDidDB db = new toDoAndDidDB();
        public static tasks task = new tasks();

        private void Did_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDoAndDidDataSet11.tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.FillByDataEnd(this.toDoAndDidDataSet11.tasks);
            fillTable();
        }
        public void fillTable()
        {
            this.tasksTableAdapter.FillByDataEnd(this.toDoAndDidDataSet11.tasks);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            fillTable();
            dataGridView1.DataSource = db.tasks.Where(f => f.data_encerramento != null).ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        var row = item.Index;
                        var rowId = item.DataGridView.SelectedCells[0].Value;
                        task = db.tasks.Find(rowId);
                        db.tasks.Remove(task);
                        db.SaveChanges();
                        //dataGridView1.Rows.RemoveAt(row);
                        fillTable();
                    }
                }
                else
                {
                    MessageBox.Show("Para deletar uma tarefa, clique na seta para direita( > ) para selecionar toda a linha.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro: " + er.Message + "\n Tente novamente mais tarde.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string titulo = txtTask.Text;
                var dados = db.tasks.Where(f => f.titulo_task.Contains(titulo) && f.data_encerramento != null).ToList();
                dataGridView1.DataSource = dados;
                dataGridView1.Refresh();
            }
            catch (Exception er)
            {

                MessageBox.Show("Erro: " + er.Message + "\n Tente novamente mais tarde.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Did_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Visible = true;
        }
    }
}
