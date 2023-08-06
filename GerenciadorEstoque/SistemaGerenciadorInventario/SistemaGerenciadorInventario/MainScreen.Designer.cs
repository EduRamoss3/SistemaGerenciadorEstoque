namespace SistemaGerenciadorInventario
{
    partial class MainScreen
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
            this.btnItens = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnFatur = new System.Windows.Forms.Button();
            this.btnTotalReceiv = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnAdcClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnExcludeClient = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItens
            // 
            this.btnItens.Location = new System.Drawing.Point(1225, 622);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(192, 63);
            this.btnItens.TabIndex = 0;
            this.btnItens.Text = "Estoque";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 45);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(1405, 528);
            this.dataGridClientes.TabIndex = 1;
            // 
            // btnFatur
            // 
            this.btnFatur.Location = new System.Drawing.Point(920, 622);
            this.btnFatur.Name = "btnFatur";
            this.btnFatur.Size = new System.Drawing.Size(192, 63);
            this.btnFatur.TabIndex = 2;
            this.btnFatur.Text = "Clientes com Faturas";
            this.btnFatur.UseVisualStyleBackColor = true;
            this.btnFatur.Click += new System.EventHandler(this.btnFatur_Click);
            // 
            // btnTotalReceiv
            // 
            this.btnTotalReceiv.Location = new System.Drawing.Point(603, 622);
            this.btnTotalReceiv.Name = "btnTotalReceiv";
            this.btnTotalReceiv.Size = new System.Drawing.Size(192, 63);
            this.btnTotalReceiv.TabIndex = 3;
            this.btnTotalReceiv.Text = "Total a receber";
            this.btnTotalReceiv.UseVisualStyleBackColor = true;
            this.btnTotalReceiv.Click += new System.EventHandler(this.btnTotalReceiv_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(299, 622);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(192, 63);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Resumo";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnAdcClient
            // 
            this.btnAdcClient.Location = new System.Drawing.Point(1195, 19);
            this.btnAdcClient.Name = "btnAdcClient";
            this.btnAdcClient.Size = new System.Drawing.Size(85, 23);
            this.btnAdcClient.TabIndex = 5;
            this.btnAdcClient.Text = "Novo";
            this.btnAdcClient.UseVisualStyleBackColor = true;
            this.btnAdcClient.Click += new System.EventHandler(this.btnAdcClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(1300, 19);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(85, 23);
            this.btnEditClient.TabIndex = 6;
            this.btnEditClient.Text = "Editar";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnExcludeClient
            // 
            this.btnExcludeClient.Location = new System.Drawing.Point(1087, 20);
            this.btnExcludeClient.Name = "btnExcludeClient";
            this.btnExcludeClient.Size = new System.Drawing.Size(85, 23);
            this.btnExcludeClient.TabIndex = 7;
            this.btnExcludeClient.Text = "Excluir";
            this.btnExcludeClient.UseVisualStyleBackColor = true;
            this.btnExcludeClient.Click += new System.EventHandler(this.btnExcludeClient_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(497, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(479, 20);
            this.textSearch.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(714, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 13;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.ForeColor = System.Drawing.Color.Lime;
            this.lblValue.Location = new System.Drawing.Point(770, 19);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(100, 23);
            this.lblValue.TabIndex = 14;
            // 
            // btnAtt
            // 
            this.btnAtt.Location = new System.Drawing.Point(980, 20);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(75, 23);
            this.btnAtt.TabIndex = 16;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = true;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(12, 622);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(192, 63);
            this.btnCompra.TabIndex = 15;
            this.btnCompra.Text = "Nova compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1429, 722);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExcludeClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAdcClient);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnTotalReceiv);
            this.Controls.Add(this.btnFatur);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.btnItens);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btnFatur;
        private System.Windows.Forms.Button btnTotalReceiv;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnAdcClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnExcludeClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCompra;
    }
}

