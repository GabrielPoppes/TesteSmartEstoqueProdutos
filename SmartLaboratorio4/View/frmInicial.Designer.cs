
namespace SmartLaboratorio4
{
    partial class frmInicio
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlSubBotoes = new System.Windows.Forms.Panel();
            this.btnMostrarProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.pnlLateralTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.pnlSubBotoes.SuspendLayout();
            this.pnlLateralTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLateral.Controls.Add(this.pnlSubBotoes);
            this.pnlLateral.Controls.Add(this.btnProdutos);
            this.pnlLateral.Controls.Add(this.pnlLateralTop);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(189, 633);
            this.pnlLateral.TabIndex = 0;
            // 
            // pnlSubBotoes
            // 
            this.pnlSubBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.pnlSubBotoes.Controls.Add(this.btnMostrarProdutos);
            this.pnlSubBotoes.Controls.Add(this.btnCadastrarProduto);
            this.pnlSubBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubBotoes.Location = new System.Drawing.Point(0, 188);
            this.pnlSubBotoes.Name = "pnlSubBotoes";
            this.pnlSubBotoes.Size = new System.Drawing.Size(189, 69);
            this.pnlSubBotoes.TabIndex = 2;
            // 
            // btnMostrarProdutos
            // 
            this.btnMostrarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.btnMostrarProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarProdutos.FlatAppearance.BorderSize = 0;
            this.btnMostrarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProdutos.Location = new System.Drawing.Point(0, 37);
            this.btnMostrarProdutos.Name = "btnMostrarProdutos";
            this.btnMostrarProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.btnMostrarProdutos.Size = new System.Drawing.Size(189, 37);
            this.btnMostrarProdutos.TabIndex = 4;
            this.btnMostrarProdutos.Text = "Exibir";
            this.btnMostrarProdutos.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.btnCadastrarProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Padding = new System.Windows.Forms.Padding(0, 0, 46, 0);
            this.btnCadastrarProduto.Size = new System.Drawing.Size(189, 37);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Estoque";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Location = new System.Drawing.Point(0, 151);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.btnProdutos.Size = new System.Drawing.Size(189, 37);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // pnlLateralTop
            // 
            this.pnlLateralTop.Controls.Add(this.pictureBox1);
            this.pnlLateralTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLateralTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLateralTop.Name = "pnlLateralTop";
            this.pnlLateralTop.Size = new System.Drawing.Size(189, 151);
            this.pnlLateralTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartLaboratorio4.Properties.Resources._2799204_management_business_office_setting_success_icon__2_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDefault
            // 
            this.pnlDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDefault.Location = new System.Drawing.Point(189, 0);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(970, 633);
            this.pnlDefault.TabIndex = 1;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 633);
            this.Controls.Add(this.pnlDefault);
            this.Controls.Add(this.pnlLateral);
            this.Name = "frmInicio";
            this.Text = "Gestão de estoque";
            this.pnlLateral.ResumeLayout(false);
            this.pnlSubBotoes.ResumeLayout(false);
            this.pnlLateralTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlLateralTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel pnlSubBotoes;
        private System.Windows.Forms.Button btnMostrarProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Panel pnlDefault;
    }
}

