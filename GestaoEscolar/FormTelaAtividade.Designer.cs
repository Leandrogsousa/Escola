namespace GestaoEscolar
{
    partial class FormTelaAtividade
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCadastroAtividade = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.Label();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Location = new System.Drawing.Point(786, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 26);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btnCadastroAtividade
            // 
            this.btnCadastroAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastroAtividade.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAtividade.Location = new System.Drawing.Point(688, 285);
            this.btnCadastroAtividade.Name = "btnCadastroAtividade";
            this.btnCadastroAtividade.Size = new System.Drawing.Size(166, 37);
            this.btnCadastroAtividade.TabIndex = 2;
            this.btnCadastroAtividade.Text = "&Cadastrar Atividade";
            this.btnCadastroAtividade.UseVisualStyleBackColor = false;
            this.btnCadastroAtividade.Click += new System.EventHandler(this.btnCadastroAtividade_Click);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(297, 92);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(76, 26);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.Text = "Turma";
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataSource = typeof(Model.Atividade);
            // 
            // atividadeDataGridView
            // 
            this.atividadeDataGridView.AllowUserToAddRows = false;
            this.atividadeDataGridView.AllowUserToDeleteRows = false;
            this.atividadeDataGridView.AllowUserToOrderColumns = true;
            this.atividadeDataGridView.AutoGenerateColumns = false;
            this.atividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.atividadeDataGridView.DataSource = this.atividadeBindingSource;
            this.atividadeDataGridView.Location = new System.Drawing.Point(39, 201);
            this.atividadeDataGridView.Name = "atividadeDataGridView";
            this.atividadeDataGridView.ReadOnly = true;
            this.atividadeDataGridView.RowHeadersWidth = 51;
            this.atividadeDataGridView.RowTemplate.Height = 24;
            this.atividadeDataGridView.Size = new System.Drawing.Size(579, 235);
            this.atividadeDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // FormTelaAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.atividadeDataGridView);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.btnCadastroAtividade);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSair);
            this.Name = "FormTelaAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTelaAtividade";
            this.Load += new System.EventHandler(this.FormTelaAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCadastroAtividade;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private System.Windows.Forms.DataGridView atividadeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}