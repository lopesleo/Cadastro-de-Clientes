
namespace cad_clientes
{
    partial class Form1
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Tbx_Number = new System.Windows.Forms.TextBox();
            this.Tbx_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalvar_Click = new System.Windows.Forms.Button();
            this.BtnEditar_Click = new System.Windows.Forms.Button();
            this.BtnExcluir_Click = new System.Windows.Forms.Button();
            this.BtnConsultar_Click = new System.Windows.Forms.Button();
            this.BtnExibir_Click = new System.Windows.Forms.Button();
            this.BtnExportar_Click = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_CPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 179);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(776, 259);
            this.dgv_clientes.TabIndex = 11;
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Location = new System.Drawing.Point(55, 5);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.Size = new System.Drawing.Size(55, 20);
            this.Tbx_ID.TabIndex = 0;
            this.Tbx_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_ID_KeyPress);
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Location = new System.Drawing.Point(55, 31);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(209, 20);
            this.Tbx_Name.TabIndex = 1;
            this.Tbx_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Name_KeyPress);
            // 
            // Tbx_Number
            // 
            this.Tbx_Number.Location = new System.Drawing.Point(55, 57);
            this.Tbx_Number.Name = "Tbx_Number";
            this.Tbx_Number.Size = new System.Drawing.Size(209, 20);
            this.Tbx_Number.TabIndex = 2;
            this.Tbx_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Number_KeyPress);
            // 
            // Tbx_Email
            // 
            this.Tbx_Email.Location = new System.Drawing.Point(55, 83);
            this.Tbx_Email.Name = "Tbx_Email";
            this.Tbx_Email.Size = new System.Drawing.Size(209, 20);
            this.Tbx_Email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // BtnSalvar_Click
            // 
            this.BtnSalvar_Click.Location = new System.Drawing.Point(376, 150);
            this.BtnSalvar_Click.Name = "BtnSalvar_Click";
            this.BtnSalvar_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar_Click.TabIndex = 5;
            this.BtnSalvar_Click.Text = "Salvar";
            this.BtnSalvar_Click.UseVisualStyleBackColor = true;
            this.BtnSalvar_Click.Click += new System.EventHandler(this.BtnSalvar_Click_Click);
            // 
            // BtnEditar_Click
            // 
            this.BtnEditar_Click.Location = new System.Drawing.Point(457, 150);
            this.BtnEditar_Click.Name = "BtnEditar_Click";
            this.BtnEditar_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar_Click.TabIndex = 6;
            this.BtnEditar_Click.Text = "Editar";
            this.BtnEditar_Click.UseVisualStyleBackColor = true;
            this.BtnEditar_Click.Click += new System.EventHandler(this.BtnEditar_Click_Click);
            // 
            // BtnExcluir_Click
            // 
            this.BtnExcluir_Click.Location = new System.Drawing.Point(538, 150);
            this.BtnExcluir_Click.Name = "BtnExcluir_Click";
            this.BtnExcluir_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir_Click.TabIndex = 7;
            this.BtnExcluir_Click.Text = "Excluir";
            this.BtnExcluir_Click.UseVisualStyleBackColor = true;
            this.BtnExcluir_Click.Click += new System.EventHandler(this.BtnExcluir_Click_Click);
            // 
            // BtnConsultar_Click
            // 
            this.BtnConsultar_Click.Location = new System.Drawing.Point(619, 150);
            this.BtnConsultar_Click.Name = "BtnConsultar_Click";
            this.BtnConsultar_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar_Click.TabIndex = 8;
            this.BtnConsultar_Click.Text = "Consultar";
            this.BtnConsultar_Click.UseVisualStyleBackColor = true;
            this.BtnConsultar_Click.Click += new System.EventHandler(this.BtnConsultar_Click_Click);
            // 
            // BtnExibir_Click
            // 
            this.BtnExibir_Click.Location = new System.Drawing.Point(700, 150);
            this.BtnExibir_Click.Name = "BtnExibir_Click";
            this.BtnExibir_Click.Size = new System.Drawing.Size(75, 23);
            this.BtnExibir_Click.TabIndex = 9;
            this.BtnExibir_Click.Text = "Exibir";
            this.BtnExibir_Click.UseVisualStyleBackColor = true;
            this.BtnExibir_Click.Click += new System.EventHandler(this.BtnExibir_Click_Click);
            // 
            // BtnExportar_Click
            // 
            this.BtnExportar_Click.Location = new System.Drawing.Point(713, 8);
            this.BtnExportar_Click.Name = "BtnExportar_Click";
            this.BtnExportar_Click.Size = new System.Drawing.Size(75, 50);
            this.BtnExportar_Click.TabIndex = 10;
            this.BtnExportar_Click.Text = "Exportar";
            this.BtnExportar_Click.UseVisualStyleBackColor = true;
            this.BtnExportar_Click.Click += new System.EventHandler(this.BtnExportar_Click_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "CPF:";
            // 
            // Tbx_CPF
            // 
            this.Tbx_CPF.Location = new System.Drawing.Point(55, 110);
            this.Tbx_CPF.Mask = "000,000,000-00";
            this.Tbx_CPF.Name = "Tbx_CPF";
            this.Tbx_CPF.Size = new System.Drawing.Size(209, 20);
            this.Tbx_CPF.TabIndex = 4;
            this.Tbx_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbx_CPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnExportar_Click);
            this.Controls.Add(this.BtnExibir_Click);
            this.Controls.Add(this.BtnConsultar_Click);
            this.Controls.Add(this.BtnExcluir_Click);
            this.Controls.Add(this.BtnEditar_Click);
            this.Controls.Add(this.BtnSalvar_Click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Email);
            this.Controls.Add(this.Tbx_Number);
            this.Controls.Add(this.Tbx_Name);
            this.Controls.Add(this.Tbx_ID);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.TextBox Tbx_Number;
        private System.Windows.Forms.TextBox Tbx_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalvar_Click;
        private System.Windows.Forms.Button BtnEditar_Click;
        private System.Windows.Forms.Button BtnExcluir_Click;
        private System.Windows.Forms.Button BtnConsultar_Click;
        private System.Windows.Forms.Button BtnExibir_Click;
        private System.Windows.Forms.Button BtnExportar_Click;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Tbx_CPF;
    }
}

