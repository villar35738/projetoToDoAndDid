namespace ToDoAndDid
{
    partial class ToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulotaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataencerramentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoAndDidDataSet1 = new ToDoAndDid.toDoAndDidDataSet1();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoAndDidDataSet = new ToDoAndDid.toDoAndDidDataSet();
            this.tasksTableAdapter = new ToDoAndDid.toDoAndDidDataSetTableAdapters.tasksTableAdapter();
            this.tasksTableAdapter1 = new ToDoAndDid.toDoAndDidDataSet1TableAdapters.tasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(514, 190);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 51);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Busca";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.Location = new System.Drawing.Point(126, 11);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(491, 20);
            this.txbName.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.Location = new System.Drawing.Point(412, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 51);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tarefas a fazer:";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCopy.Location = new System.Drawing.Point(208, 190);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(96, 51);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Finalizar Tarefa";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.Location = new System.Drawing.Point(106, 190);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(96, 51);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Incluir Nova Tarefa";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRemove.Location = new System.Drawing.Point(310, 190);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(96, 51);
            this.BtnRemove.TabIndex = 17;
            this.BtnRemove.Text = "Deletar Selecionada";
            this.BtnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(2, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 51);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Editar Selecionada";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.titulotaskDataGridViewTextBoxColumn,
            this.dataaberturaDataGridViewTextBoxColumn,
            this.dataencerramentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tasksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 147);
            this.dataGridView1.TabIndex = 22;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "id_task";
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulotaskDataGridViewTextBoxColumn
            // 
            this.titulotaskDataGridViewTextBoxColumn.DataPropertyName = "titulo_task";
            this.titulotaskDataGridViewTextBoxColumn.HeaderText = "titulo_task";
            this.titulotaskDataGridViewTextBoxColumn.Name = "titulotaskDataGridViewTextBoxColumn";
            // 
            // dataaberturaDataGridViewTextBoxColumn
            // 
            this.dataaberturaDataGridViewTextBoxColumn.DataPropertyName = "data_abertura";
            this.dataaberturaDataGridViewTextBoxColumn.HeaderText = "data_abertura";
            this.dataaberturaDataGridViewTextBoxColumn.Name = "dataaberturaDataGridViewTextBoxColumn";
            // 
            // dataencerramentoDataGridViewTextBoxColumn
            // 
            this.dataencerramentoDataGridViewTextBoxColumn.DataPropertyName = "data_encerramento";
            this.dataencerramentoDataGridViewTextBoxColumn.HeaderText = "data_encerramento";
            this.dataencerramentoDataGridViewTextBoxColumn.Name = "dataencerramentoDataGridViewTextBoxColumn";
            // 
            // tasksBindingSource1
            // 
            this.tasksBindingSource1.DataMember = "tasks";
            this.tasksBindingSource1.DataSource = this.toDoAndDidDataSet1;
            // 
            // toDoAndDidDataSet1
            // 
            this.toDoAndDidDataSet1.DataSetName = "toDoAndDidDataSet1";
            this.toDoAndDidDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.toDoAndDidDataSet;
            // 
            // toDoAndDidDataSet
            // 
            this.toDoAndDidDataSet.DataSetName = "toDoAndDidDataSet";
            this.toDoAndDidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter1
            // 
            this.tasksTableAdapter1.ClearBeforeFill = true;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(629, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "ToDo";
            this.Text = "Tarafas a fazer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private toDoAndDidDataSet toDoAndDidDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private toDoAndDidDataSetTableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulotaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataencerramentoDataGridViewTextBoxColumn;
        private toDoAndDidDataSet1 toDoAndDidDataSet1;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private toDoAndDidDataSet1TableAdapters.tasksTableAdapter tasksTableAdapter1;
    }
}

