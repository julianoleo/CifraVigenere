namespace CifraVigenere
{
    partial class Form_CifraVigenere
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
            this.txtMsgOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsgCriptografada = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMsgOriginal
            // 
            this.txtMsgOriginal.Location = new System.Drawing.Point(7, 24);
            this.txtMsgOriginal.Multiline = true;
            this.txtMsgOriginal.Name = "txtMsgOriginal";
            this.txtMsgOriginal.Size = new System.Drawing.Size(252, 77);
            this.txtMsgOriginal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensagem";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(7, 125);
            this.txtChave.Multiline = true;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(252, 28);
            this.txtChave.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mensagem Criptografada";
            // 
            // txtMsgCriptografada
            // 
            this.txtMsgCriptografada.Location = new System.Drawing.Point(7, 181);
            this.txtMsgCriptografada.Multiline = true;
            this.txtMsgCriptografada.Name = "txtMsgCriptografada";
            this.txtMsgCriptografada.Size = new System.Drawing.Size(252, 77);
            this.txtMsgCriptografada.TabIndex = 4;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(159, 264);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(100, 23);
            this.btnCriptografar.TabIndex = 6;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // Form_CifraVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 293);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsgCriptografada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsgOriginal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CifraVigenere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifra de Vigenere - IFTM 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsgOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsgCriptografada;
        private System.Windows.Forms.Button btnCriptografar;
    }
}

