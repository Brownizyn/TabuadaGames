namespace TabuadaGames
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
            this.components = new System.ComponentModel.Container();
            this.txtprimeiroNum = new System.Windows.Forms.TextBox();
            this.txtsegundoNum = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtprimeiroNum
            // 
            this.txtprimeiroNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimeiroNum.Location = new System.Drawing.Point(50, 68);
            this.txtprimeiroNum.Name = "txtprimeiroNum";
            this.txtprimeiroNum.Size = new System.Drawing.Size(39, 38);
            this.txtprimeiroNum.TabIndex = 0;
            // 
            // txtsegundoNum
            // 
            this.txtsegundoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNum.Location = new System.Drawing.Point(134, 68);
            this.txtsegundoNum.Name = "txtsegundoNum";
            this.txtsegundoNum.Size = new System.Drawing.Size(39, 38);
            this.txtsegundoNum.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(216, 68);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(39, 38);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResultado_KeyDown);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(95, 75);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(33, 31);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(21, 152);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(152, 38);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(226, 152);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(152, 38);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.White;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Lime;
            this.lblA.Location = new System.Drawing.Point(37, 222);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(136, 39);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "Acertos";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.Location = new System.Drawing.Point(89, 282);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(31, 33);
            this.lblAcertos.TabIndex = 8;
            this.lblAcertos.Text = "0";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.Red;
            this.lblE.Location = new System.Drawing.Point(254, 222);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(101, 39);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "Erros";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.Location = new System.Drawing.Point(261, 282);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(31, 33);
            this.lblErros.TabIndex = 10;
            this.lblErros.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tempo:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(355, 368);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(31, 33);
            this.lblTempo.TabIndex = 12;
            this.lblTempo.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 408);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtsegundoNum);
            this.Controls.Add(this.txtprimeiroNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TabuadaGames";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprimeiroNum;
        private System.Windows.Forms.TextBox txtsegundoNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer timer1;
    }
}

