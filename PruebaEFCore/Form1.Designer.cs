namespace PruebaEFCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLavel = new System.Windows.Forms.Label();
            this.subtitleTextBox = new System.Windows.Forms.TextBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Location = new System.Drawing.Point(22, 348);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(150, 23);
            this.btnAddRegister.TabIndex = 0;
            this.btnAddRegister.Text = "Añadir Registro";
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.btnAddRegister_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blogIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.subTitleDataGridViewTextBoxColumn,
            this.dateTimeAddDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.blogViewModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(602, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // blogIdDataGridViewTextBoxColumn
            // 
            this.blogIdDataGridViewTextBoxColumn.DataPropertyName = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.HeaderText = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.Name = "blogIdDataGridViewTextBoxColumn";
            this.blogIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.blogIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTitleDataGridViewTextBoxColumn
            // 
            this.subTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subTitleDataGridViewTextBoxColumn.DataPropertyName = "SubTitle";
            this.subTitleDataGridViewTextBoxColumn.HeaderText = "SubTitle";
            this.subTitleDataGridViewTextBoxColumn.Name = "subTitleDataGridViewTextBoxColumn";
            this.subTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeAddDataGridViewTextBoxColumn
            // 
            this.dateTimeAddDataGridViewTextBoxColumn.DataPropertyName = "DateTimeAdd";
            this.dateTimeAddDataGridViewTextBoxColumn.HeaderText = "DateTimeAdd";
            this.dateTimeAddDataGridViewTextBoxColumn.Name = "dateTimeAddDataGridViewTextBoxColumn";
            this.dateTimeAddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blogViewModelBindingSource
            // 
            this.blogViewModelBindingSource.DataSource = typeof(PruebaEFCore.ViewModel.BlogViewModel);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(658, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(124, 23);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(658, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(38, 15);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "label1";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(658, 95);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(267, 23);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // titleLavel
            // 
            this.titleLavel.AutoSize = true;
            this.titleLavel.Location = new System.Drawing.Point(658, 77);
            this.titleLavel.Name = "titleLavel";
            this.titleLavel.Size = new System.Drawing.Size(38, 15);
            this.titleLavel.TabIndex = 3;
            this.titleLavel.Text = "label1";
            // 
            // subtitleTextBox
            // 
            this.subtitleTextBox.Location = new System.Drawing.Point(658, 154);
            this.subtitleTextBox.Multiline = true;
            this.subtitleTextBox.Name = "subtitleTextBox";
            this.subtitleTextBox.Size = new System.Drawing.Size(267, 73);
            this.subtitleTextBox.TabIndex = 2;
            this.subtitleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(658, 136);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(38, 15);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "label1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(658, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(468, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(549, 348);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(772, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 377);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLavel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.subtitleTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddRegister;
        private DataGridView dataGridView1;
        private BindingSource blogViewModelBindingSource;
        private DataGridViewTextBoxColumn blogIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeAddDataGridViewTextBoxColumn;
        private TextBox idTextBox;
        private Label idLabel;
        private TextBox titleTextBox;
        private Label titleLavel;
        private TextBox subtitleTextBox;
        private Label subtitleLabel;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnLimpiar;
    }
}