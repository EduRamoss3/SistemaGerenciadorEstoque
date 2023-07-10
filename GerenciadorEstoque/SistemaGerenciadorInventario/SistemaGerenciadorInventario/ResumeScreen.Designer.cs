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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResume)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResume
            // 
            this.dataGridResume.AllowUserToAddRows = false;
            this.dataGridResume.AllowUserToDeleteRows = false;
            this.dataGridResume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResume.Location = new System.Drawing.Point(12, 30);
            this.dataGridResume.MultiSelect = false;
            this.dataGridResume.Name = "dataGridResume";
            this.dataGridResume.ReadOnly = true;
            this.dataGridResume.Size = new System.Drawing.Size(824, 481);
            this.dataGridResume.TabIndex = 0;
            // 
            // ResumeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 579);
            this.Controls.Add(this.dataGridResume);
            this.Name = "ResumeScreen";
            this.Text = "ResumeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResume;
    }
}