namespace SistemaGerenciadorInventario
{
    partial class ResumeScreen
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
            this.dataGridResume = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPayed = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResume)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResume
            // 
            this.dataGridResume.AllowUserToAddRows = false;
            this.dataGridResume.AllowUserToDeleteRows = false;
            this.dataGridResume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResume.Location = new System.Drawing.Point(12, 38);
            this.dataGridResume.MultiSelect = false;
            this.dataGridResume.Name = "dataGridResume";
            this.dataGridResume.ReadOnly = true;
            this.dataGridResume.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResume.Size = new System.Drawing.Size(1196, 546);
            this.dataGridResume.TabIndex = 0;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(13, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(537, 20);
            this.textSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(556, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPayed
            // 
            this.lblPayed.Location = new System.Drawing.Point(1133, 594);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(75, 23);
            this.lblPayed.TabIndex = 3;
            this.lblPayed.Text = "Pagamento";
            this.lblPayed.UseVisualStyleBackColor = true;
            this.lblPayed.Click += new System.EventHandler(this.lblPayed_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.Location = new System.Drawing.Point(1033, 594);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(75, 23);
            this.lblEdit.TabIndex = 4;
            this.lblEdit.Text = "Alterar";
            this.lblEdit.UseVisualStyleBackColor = true;
            // 
            // ResumeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1228, 629);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblPayed);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataGridResume);
            this.Name = "ResumeScreen";
            this.Text = "Resumo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResume;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button lblPayed;
        private System.Windows.Forms.Button lblEdit;
    }
}