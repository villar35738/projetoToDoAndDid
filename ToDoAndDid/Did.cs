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
            txbTask.Clear();
        }
    }
}
