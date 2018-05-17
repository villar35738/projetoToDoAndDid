namespace ToDoAndDid
{
    partial class Did
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
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.toDoAndDidDataSet1 = new ToDoAndDid.toDoAndDidDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulotaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataencerramentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoAndDidDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoAndDidDataSet11 = new ToDoAndDid.toDoAndDidDataSet1();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new ToDoAndDid.toDoAndDidDataSet1TableAdapters.tasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRemove.Location = new System.Drawing.Point(263, 235);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(104, 63);
            this.BtnRemove.TabIndex = 26;
            this.BtnRemove.Text = "Deletar Selecionada";
            this.BtnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tarefas feitas:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.Location = new System.Drawing.Point(375, 235);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 63);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar busca";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.Location = new System.Drawing.Point(176, 15);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(653, 22);
            this.txtTask.TabIndex = 22;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPesquisar.Image = global::ToDoAndDid.Properties.Resources.Icone_busca5;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(487, 235);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 63);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Busca";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // toDoAndDidDataSet1
            // 
            this.toDoAndDidDataSet1.DataSetName = "toDoAndDidDataSet";
            this.toDoAndDidDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.titulotaskDataGridViewTextBoxColumn,
            this.dataaberturaDataGridViewTextBoxColumn,
            this.dataencerramentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tasksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 181);
            this.dataGridView1.TabIndex = 31;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulotaskDataGridViewTextBoxColumn
            // 
            this.titulotaskDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titulotaskDataGridViewTextBoxColumn.DataPropertyName = "titulo_task";
            this.titulotaskDataGridViewTextBoxColumn.HeaderText = "TITULO DA TAREFA";
            this.titulotaskDataGridViewTextBoxColumn.Name = "titulotaskDataGridViewTextBoxColumn";
            this.titulotaskDataGridViewTextBoxColumn.Width = 154;
            // 
            // dataaberturaDataGridViewTextBoxColumn
            // 
            this.dataaberturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataaberturaDataGridViewTextBoxColumn.DataPropertyName = "data_abertura";
            this.dataaberturaDataGridViewTextBoxColumn.HeaderText = "DATA DE ABERTURA";
            this.dataaberturaDataGridViewTextBoxColumn.Name = "dataaberturaDataGridViewTextBoxColumn";
            // 
            // dataencerramentoDataGridViewTextBoxColumn
            // 
            this.dataencerramentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataencerramentoDataGridViewTextBoxColumn.DataPropertyName = "data_encerramento";
            this.dataencerramentoDataGridViewTextBoxColumn.HeaderText = "DATA DE FECHAMENTO";
            this.dataencerramentoDataGridViewTextBoxColumn.Name = "dataencerramentoDataGridViewTextBoxColumn";
            // 
            // tasksBindingSource1
            // 
            this.tasksBindingSource1.DataMember = "tasks";
            this.tasksBindingSource1.DataSource = this.toDoAndDidDataSet11BindingSource;
            // 
            // toDoAndDidDataSet11BindingSource
            // 
            this.toDoAndDidDataSet11BindingSource.DataSource = this.toDoAndDidDataSet11;
            this.toDoAndDidDataSet11BindingSource.Position = 0;
            // 
            // toDoAndDidDataSet11
            // 
            this.toDoAndDidDataSet11.DataSetName = "toDoAndDidDataSet1";
            this.toDoAndDidDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.toDoAndDidDataSet11BindingSource;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // Did
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnPesquisar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Did";
            this.Text = "Tarefas finalizadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Did_FormClosing);
            this.Load += new System.EventHandler(this.Did_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoAndDidDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnPesquisar;
        private toDoAndDidDataSet toDoAndDidDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource toDoAndDidDataSet11BindingSource;
        private toDoAndDidDataSet1 toDoAndDidDataSet11;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private toDoAndDidDataSet1TableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulotaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataencerramentoDataGridViewTextBoxColumn;
    }
}