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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
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
            this.btnCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItens
            // 
            resources.ApplyResources(this.btnItens, "btnItens");
            this.btnItens.Name = "btnItens";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // dataGridClientes
            // 
            resources.ApplyResources(this.dataGridClientes, "dataGridClientes");
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnFatur
            // 
            resources.ApplyResources(this.btnFatur, "btnFatur");
            this.btnFatur.Name = "btnFatur";
            this.btnFatur.UseVisualStyleBackColor = true;
            this.btnFatur.Click += new System.EventHandler(this.btnFatur_Click);
            // 
            // btnTotalReceiv
            // 
            resources.ApplyResources(this.btnTotalReceiv, "btnTotalReceiv");
            this.btnTotalReceiv.Name = "btnTotalReceiv";
            this.btnTotalReceiv.UseVisualStyleBackColor = true;
            this.btnTotalReceiv.Click += new System.EventHandler(this.btnTotalReceiv_Click);
            // 
            // btnResume
            // 
            resources.ApplyResources(this.btnResume, "btnResume");
            this.btnResume.Name = "btnResume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnAdcClient
            // 
            resources.ApplyResources(this.btnAdcClient, "btnAdcClient");
            this.btnAdcClient.Name = "btnAdcClient";
            this.btnAdcClient.UseVisualStyleBackColor = true;
            this.btnAdcClient.Click += new System.EventHandler(this.btnAdcClient_Click);
            // 
            // btnEditClient
            // 
            resources.ApplyResources(this.btnEditClient, "btnEditClient");
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnExcludeClient
            // 
            resources.ApplyResources(this.btnExcludeClient, "btnExcludeClient");
            this.btnExcludeClient.Name = "btnExcludeClient";
            this.btnExcludeClient.UseVisualStyleBackColor = true;
            this.btnExcludeClient.Click += new System.EventHandler(this.btnExcludeClient_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            resources.ApplyResources(this.textSearch, "textSearch");
            this.textSearch.Name = "textSearch";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Name = "lblTotal";
            // 
            // lblValue
            // 
            resources.ApplyResources(this.lblValue, "lblValue");
            this.lblValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValue.ForeColor = System.Drawing.Color.Lime;
            this.lblValue.Name = "lblValue";
            // 
            // btnCompra
            // 
            resources.ApplyResources(this.btnCompra, "btnCompra");
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
        private System.Windows.Forms.Button btnCompra;
    }
}

