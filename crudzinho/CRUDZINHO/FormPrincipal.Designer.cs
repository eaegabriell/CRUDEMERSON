namespace CRUDZINHO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblLocalizar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDataDeNascimento = new System.Windows.Forms.TextBox();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblId.Location = new System.Drawing.Point(22, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.AllowUserToAddRows = false;
            this.dgvPessoa.AllowUserToDeleteRows = false;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(25, 240);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.ReadOnly = true;
            this.dgvPessoa.Size = new System.Drawing.Size(409, 117);
            this.dgvPessoa.TabIndex = 1;
            this.dgvPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoa_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(22, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(25, 197);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(166, 20);
            this.txtCelular.TabIndex = 6;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdade.Location = new System.Drawing.Point(22, 181);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(46, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Celular";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Gray;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(374, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(66, 25);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(375, 213);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 21);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(374, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 24);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.BackColor = System.Drawing.Color.Gray;
            this.lblLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizar.Location = new System.Drawing.Point(223, 26);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(73, 23);
            this.lblLocalizar.TabIndex = 10;
            this.lblLocalizar.Text = "Localizar";
            this.lblLocalizar.UseVisualStyleBackColor = false;
            this.lblLocalizar.Click += new System.EventHandler(this.lblLocalizar_Click);
            // 
            // lblSair
            // 
            this.lblSair.BackColor = System.Drawing.Color.Red;
            this.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(379, 384);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(65, 24);
            this.lblSair.TabIndex = 11;
            this.lblSair.Text = "Sair";
            this.lblSair.UseVisualStyleBackColor = false;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(24, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtDataDeNascimento
            // 
            this.txtDataDeNascimento.Location = new System.Drawing.Point(25, 111);
            this.txtDataDeNascimento.Name = "txtDataDeNascimento";
            this.txtDataDeNascimento.Size = new System.Drawing.Size(166, 20);
            this.txtDataDeNascimento.TabIndex = 16;
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataDeNascimento.Location = new System.Drawing.Point(22, 95);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblDataDeNascimento.TabIndex = 15;
            this.lblDataDeNascimento.Text = "Data nascimento";
            this.lblDataDeNascimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(452, 415);
            this.Controls.Add(this.txtDataDeNascimento);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblLocalizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button lblLocalizar;
        private System.Windows.Forms.Button lblSair;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDataDeNascimento;
        private System.Windows.Forms.Label lblDataDeNascimento;
    }
}

