namespace lista_de_contatos_tessete
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
            this.Telefone = new System.Windows.Forms.TextBox();
            this.ButtonEnviar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListadeContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(71, 233);
            this.Telefone.Multiline = true;
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(163, 31);
            this.Telefone.TabIndex = 1;
            // 
            // ButtonEnviar
            // 
            this.ButtonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnviar.Location = new System.Drawing.Point(71, 298);
            this.ButtonEnviar.Name = "ButtonEnviar";
            this.ButtonEnviar.Size = new System.Drawing.Size(163, 98);
            this.ButtonEnviar.TabIndex = 4;
            this.ButtonEnviar.Text = "ENVIAR";
            this.ButtonEnviar.UseVisualStyleBackColor = true;
            this.ButtonEnviar.Click += new System.EventHandler(this.ButtonEnviar_Click);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(71, 70);
            this.Nome.Multiline = true;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(163, 31);
            this.Nome.TabIndex = 5;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(71, 150);
            this.Sobrenome.Multiline = true;
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(163, 31);
            this.Sobrenome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefone";
            // 
            // ListadeContatos
            // 
            this.ListadeContatos.FormattingEnabled = true;
            this.ListadeContatos.Location = new System.Drawing.Point(258, 68);
            this.ListadeContatos.Name = "ListadeContatos";
            this.ListadeContatos.Size = new System.Drawing.Size(255, 329);
            this.ListadeContatos.TabIndex = 10;
            this.ListadeContatos.SelectedIndexChanged += new System.EventHandler(this.ListadeContatos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 480);
            this.Controls.Add(this.ListadeContatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ButtonEnviar);
            this.Controls.Add(this.Telefone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Button ButtonEnviar;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListadeContatos;
    }
}

