namespace WindowsFormsApp2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.gbForcaDesenho = new System.Windows.Forms.GroupBox();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.labelTeste = new System.Windows.Forms.Label();
            this.btnConfirmarLetra = new System.Windows.Forms.Button();
            this.btnConfirmaPalavra = new System.Windows.Forms.Button();
            this.txtPalavraSecreta = new System.Windows.Forms.TextBox();
            this.txtDigitaLetra = new System.Windows.Forms.TextBox();
            this.gbTentativas = new System.Windows.Forms.GroupBox();
            this.gbAdvinhaLetra = new System.Windows.Forms.GroupBox();
            this.btnConfirmaLetra = new System.Windows.Forms.Button();
            this.gbPalavraSecreta = new System.Windows.Forms.GroupBox();
            this.lblLetrasDigitadas = new System.Windows.Forms.Label();
            this.pnJogo.SuspendLayout();
            this.gbForcaDesenho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            this.gbTentativas.SuspendLayout();
            this.gbAdvinhaLetra.SuspendLayout();
            this.gbPalavraSecreta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(314, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.gbPalavraSecreta);
            this.pnJogo.Controls.Add(this.gbAdvinhaLetra);
            this.pnJogo.Controls.Add(this.gbTentativas);
            this.pnJogo.Controls.Add(this.gbForcaDesenho);
            this.pnJogo.Controls.Add(this.labelTeste);
            this.pnJogo.Controls.Add(this.btnConfirmarLetra);
            this.pnJogo.Location = new System.Drawing.Point(12, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(776, 364);
            this.pnJogo.TabIndex = 1;
            this.pnJogo.Visible = false;
            // 
            // gbForcaDesenho
            // 
            this.gbForcaDesenho.Controls.Add(this.pbForca);
            this.gbForcaDesenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbForcaDesenho.Location = new System.Drawing.Point(530, 10);
            this.gbForcaDesenho.Name = "gbForcaDesenho";
            this.gbForcaDesenho.Size = new System.Drawing.Size(234, 191);
            this.gbForcaDesenho.TabIndex = 12;
            this.gbForcaDesenho.TabStop = false;
            this.gbForcaDesenho.Text = "Forca";
            this.gbForcaDesenho.Visible = false;
            // 
            // pbForca
            // 
            this.pbForca.Image = global::WindowsFormsApp2.Properties.Resources.forcaCerto;
            this.pbForca.Location = new System.Drawing.Point(46, 29);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(152, 135);
            this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForca.TabIndex = 7;
            this.pbForca.TabStop = false;
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.Location = new System.Drawing.Point(107, 68);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(0, 55);
            this.lblTentativas.TabIndex = 10;
            // 
            // labelTeste
            // 
            this.labelTeste.AutoSize = true;
            this.labelTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeste.Location = new System.Drawing.Point(328, 246);
            this.labelTeste.Name = "labelTeste";
            this.labelTeste.Size = new System.Drawing.Size(0, 32);
            this.labelTeste.TabIndex = 11;
            this.labelTeste.UseCompatibleTextRendering = true;
            // 
            // btnConfirmarLetra
            // 
            this.btnConfirmarLetra.Location = new System.Drawing.Point(328, 403);
            this.btnConfirmarLetra.Name = "btnConfirmarLetra";
            this.btnConfirmarLetra.Size = new System.Drawing.Size(86, 23);
            this.btnConfirmarLetra.TabIndex = 10;
            this.btnConfirmarLetra.Text = "Confirmar";
            this.btnConfirmarLetra.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaPalavra
            // 
            this.btnConfirmaPalavra.Location = new System.Drawing.Point(97, 76);
            this.btnConfirmaPalavra.Name = "btnConfirmaPalavra";
            this.btnConfirmaPalavra.Size = new System.Drawing.Size(182, 33);
            this.btnConfirmaPalavra.TabIndex = 2;
            this.btnConfirmaPalavra.Text = "Confirmar Palavra";
            this.btnConfirmaPalavra.UseVisualStyleBackColor = true;
            this.btnConfirmaPalavra.Click += new System.EventHandler(this.btnConfirmaPalavra_Click);
            // 
            // txtPalavraSecreta
            // 
            this.txtPalavraSecreta.Location = new System.Drawing.Point(23, 31);
            this.txtPalavraSecreta.Name = "txtPalavraSecreta";
            this.txtPalavraSecreta.PasswordChar = '*';
            this.txtPalavraSecreta.Size = new System.Drawing.Size(300, 30);
            this.txtPalavraSecreta.TabIndex = 1;
            // 
            // txtDigitaLetra
            // 
            this.txtDigitaLetra.Location = new System.Drawing.Point(20, 44);
            this.txtDigitaLetra.Name = "txtDigitaLetra";
            this.txtDigitaLetra.Size = new System.Drawing.Size(142, 30);
            this.txtDigitaLetra.TabIndex = 9;
            // 
            // gbTentativas
            // 
            this.gbTentativas.Controls.Add(this.lblLetrasDigitadas);
            this.gbTentativas.Controls.Add(this.lblTentativas);
            this.gbTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTentativas.Location = new System.Drawing.Point(532, 212);
            this.gbTentativas.Name = "gbTentativas";
            this.gbTentativas.Size = new System.Drawing.Size(232, 149);
            this.gbTentativas.TabIndex = 13;
            this.gbTentativas.TabStop = false;
            this.gbTentativas.Text = "Tentativas Restantes";
            this.gbTentativas.Visible = false;
            // 
            // gbAdvinhaLetra
            // 
            this.gbAdvinhaLetra.Controls.Add(this.txtDigitaLetra);
            this.gbAdvinhaLetra.Controls.Add(this.btnConfirmaLetra);
            this.gbAdvinhaLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdvinhaLetra.Location = new System.Drawing.Point(17, 161);
            this.gbAdvinhaLetra.Name = "gbAdvinhaLetra";
            this.gbAdvinhaLetra.Size = new System.Drawing.Size(202, 140);
            this.gbAdvinhaLetra.TabIndex = 14;
            this.gbAdvinhaLetra.TabStop = false;
            this.gbAdvinhaLetra.Text = "Advinhe a Letra";
            this.gbAdvinhaLetra.Visible = false;
            // 
            // btnConfirmaLetra
            // 
            this.btnConfirmaLetra.Location = new System.Drawing.Point(31, 97);
            this.btnConfirmaLetra.Name = "btnConfirmaLetra";
            this.btnConfirmaLetra.Size = new System.Drawing.Size(120, 37);
            this.btnConfirmaLetra.TabIndex = 15;
            this.btnConfirmaLetra.Text = "Confirmar";
            this.btnConfirmaLetra.UseVisualStyleBackColor = true;
            this.btnConfirmaLetra.Click += new System.EventHandler(this.btnConfirmaLetra_Click);
            // 
            // gbPalavraSecreta
            // 
            this.gbPalavraSecreta.Controls.Add(this.txtPalavraSecreta);
            this.gbPalavraSecreta.Controls.Add(this.btnConfirmaPalavra);
            this.gbPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPalavraSecreta.Location = new System.Drawing.Point(135, 10);
            this.gbPalavraSecreta.Name = "gbPalavraSecreta";
            this.gbPalavraSecreta.Size = new System.Drawing.Size(342, 135);
            this.gbPalavraSecreta.TabIndex = 15;
            this.gbPalavraSecreta.TabStop = false;
            this.gbPalavraSecreta.Text = "Digite a palavra secreta";
            // 
            // lblLetrasDigitadas
            // 
            this.lblLetrasDigitadas.AutoSize = true;
            this.lblLetrasDigitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasDigitadas.Location = new System.Drawing.Point(6, 123);
            this.lblLetrasDigitadas.Name = "lblLetrasDigitadas";
            this.lblLetrasDigitadas.Size = new System.Drawing.Size(0, 18);
            this.lblLetrasDigitadas.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnJogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.gbForcaDesenho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            this.gbTentativas.ResumeLayout(false);
            this.gbTentativas.PerformLayout();
            this.gbAdvinhaLetra.ResumeLayout(false);
            this.gbAdvinhaLetra.PerformLayout();
            this.gbPalavraSecreta.ResumeLayout(false);
            this.gbPalavraSecreta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.TextBox txtPalavraSecreta;
        private System.Windows.Forms.Button btnConfirmaPalavra;
        private System.Windows.Forms.Button btnConfirmarLetra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.TextBox txtDigitaLetra;
        private System.Windows.Forms.Label labelTeste;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.GroupBox gbForcaDesenho;
        private System.Windows.Forms.GroupBox gbAdvinhaLetra;
        private System.Windows.Forms.GroupBox gbTentativas;
        private System.Windows.Forms.Button btnConfirmaLetra;
        private System.Windows.Forms.GroupBox gbPalavraSecreta;
        private System.Windows.Forms.Label lblLetrasDigitadas;
    }
}

