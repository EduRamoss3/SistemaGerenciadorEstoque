namespace SistemaGerenciadorInventario
{
    partial class EditClient
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblFinanc = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxCpf = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.groupSex = new System.Windows.Forms.GroupBox();
            this.radioFemini = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.boxRua = new System.Windows.Forms.TextBox();
            this.groupEndereço = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.TextBox();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.boxNum = new System.Windows.Forms.TextBox();
            this.groupMoney = new System.Windows.Forms.GroupBox();
            this.boxSaldo = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numericQnt = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTextID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateEnter = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.groupSex.SuspendLayout();
            this.groupEndereço.SuspendLayout();
            this.groupMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQnt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(64, 103);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(59, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(31, 195);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(63, 13);
            this.lblBirth.TabIndex = 3;
            this.lblBirth.Text = "Nascimento";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(24, 343);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(70, 13);
            this.lblFone.TabIndex = 4;
            this.lblFone.Text = "Telefone +55";
            // 
            // lblFinanc
            // 
            this.lblFinanc.AutoSize = true;
            this.lblFinanc.Location = new System.Drawing.Point(20, 0);
            this.lblFinanc.Name = "lblFinanc";
            this.lblFinanc.Size = new System.Drawing.Size(50, 13);
            this.lblFinanc.TabIndex = 7;
            this.lblFinanc.Text = "Finanças";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(20, 32);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 10;
            this.lblRua.Text = "Rua";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(358, 32);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 13);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "N.º";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 81);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(6, 42);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(85, 13);
            this.lblQnt.TabIndex = 13;
            this.lblQnt.Text = "Itens comprados";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.ForeColor = System.Drawing.Color.Red;
            this.lblDown.Location = new System.Drawing.Point(163, 42);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(93, 13);
            this.lblDown.TabIndex = 14;
            this.lblDown.Text = "Saldo devedor R$";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Location = new System.Drawing.Point(100, 195);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(228, 20);
            this.dateTimeNascimento.TabIndex = 15;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(101, 52);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(426, 20);
            this.boxName.TabIndex = 16;
            // 
            // boxCpf
            // 
            this.boxCpf.Location = new System.Drawing.Point(101, 103);
            this.boxCpf.Name = "boxCpf";
            this.boxCpf.Size = new System.Drawing.Size(194, 20);
            this.boxCpf.TabIndex = 17;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(100, 149);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(426, 20);
            this.boxEmail.TabIndex = 18;
            // 
            // groupSex
            // 
            this.groupSex.Controls.Add(this.radioFemini);
            this.groupSex.Controls.Add(this.radioMasc);
            this.groupSex.Location = new System.Drawing.Point(100, 240);
            this.groupSex.Name = "groupSex";
            this.groupSex.Size = new System.Drawing.Size(200, 69);
            this.groupSex.TabIndex = 19;
            this.groupSex.TabStop = false;
            this.groupSex.Text = "Sexo";
            // 
            // radioFemini
            // 
            this.radioFemini.AutoSize = true;
            this.radioFemini.Location = new System.Drawing.Point(94, 33);
            this.radioFemini.Name = "radioFemini";
            this.radioFemini.Size = new System.Drawing.Size(67, 17);
            this.radioFemini.TabIndex = 1;
            this.radioFemini.TabStop = true;
            this.radioFemini.Text = "Feminino";
            this.radioFemini.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(6, 33);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(100, 340);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(194, 20);
            this.boxPhone.TabIndex = 20;
            // 
            // boxRua
            // 
            this.boxRua.Location = new System.Drawing.Point(53, 29);
            this.boxRua.Name = "boxRua";
            this.boxRua.Size = new System.Drawing.Size(280, 20);
            this.boxRua.TabIndex = 21;
            // 
            // groupEndereço
            // 
            this.groupEndereço.Controls.Add(this.lblEstado);
            this.groupEndereço.Controls.Add(this.boxEstado);
            this.groupEndereço.Controls.Add(this.boxCity);
            this.groupEndereço.Controls.Add(this.boxNum);
            this.groupEndereço.Controls.Add(this.lblRua);
            this.groupEndereço.Controls.Add(this.boxRua);
            this.groupEndereço.Controls.Add(this.lblNum);
            this.groupEndereço.Controls.Add(this.lblCidade);
            this.groupEndereço.Location = new System.Drawing.Point(643, 49);
            this.groupEndereço.Name = "groupEndereço";
            this.groupEndereço.Size = new System.Drawing.Size(420, 130);
            this.groupEndereço.TabIndex = 22;
            this.groupEndereço.TabStop = false;
            this.groupEndereço.Text = "Endereço";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(235, 81);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado";
            // 
            // boxEstado
            // 
            this.boxEstado.Location = new System.Drawing.Point(281, 78);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(133, 20);
            this.boxEstado.TabIndex = 24;
            // 
            // boxCity
            // 
            this.boxCity.Location = new System.Drawing.Point(53, 78);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(150, 20);
            this.boxCity.TabIndex = 23;
            // 
            // boxNum
            // 
            this.boxNum.Location = new System.Drawing.Point(379, 29);
            this.boxNum.Name = "boxNum";
            this.boxNum.Size = new System.Drawing.Size(35, 20);
            this.boxNum.TabIndex = 22;
            // 
            // groupMoney
            // 
            this.groupMoney.Controls.Add(this.numericQnt);
            this.groupMoney.Controls.Add(this.boxSaldo);
            this.groupMoney.Controls.Add(this.lblQnt);
            this.groupMoney.Controls.Add(this.lblDown);
            this.groupMoney.Controls.Add(this.lblFinanc);
            this.groupMoney.ForeColor = System.Drawing.Color.Green;
            this.groupMoney.Location = new System.Drawing.Point(643, 240);
            this.groupMoney.Name = "groupMoney";
            this.groupMoney.Size = new System.Drawing.Size(357, 80);
            this.groupMoney.TabIndex = 23;
            this.groupMoney.TabStop = false;
            this.groupMoney.Text = "$";
            // 
            // boxSaldo
            // 
            this.boxSaldo.ForeColor = System.Drawing.Color.Red;
            this.boxSaldo.Location = new System.Drawing.Point(262, 39);
            this.boxSaldo.Name = "boxSaldo";
            this.boxSaldo.Size = new System.Drawing.Size(79, 20);
            this.boxSaldo.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(614, 413);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Concluir";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numericQnt
            // 
            this.numericQnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numericQnt.Location = new System.Drawing.Point(88, 40);
            this.numericQnt.Name = "numericQnt";
            this.numericQnt.Size = new System.Drawing.Size(30, 20);
            this.numericQnt.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(101, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 26;
            this.lblId.Text = ".";
            // 
            // lblTextID
            // 
            this.lblTextID.AutoSize = true;
            this.lblTextID.Location = new System.Drawing.Point(73, 13);
            this.lblTextID.Name = "lblTextID";
            this.lblTextID.Size = new System.Drawing.Size(18, 13);
            this.lblTextID.TabIndex = 27;
            this.lblTextID.Text = "ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(492, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Data de registro";
            // 
            // lblDateEnter
            // 
            this.lblDateEnter.AutoSize = true;
            this.lblDateEnter.Location = new System.Drawing.Point(582, 12);
            this.lblDateEnter.Name = "lblDateEnter";
            this.lblDateEnter.Size = new System.Drawing.Size(10, 13);
            this.lblDateEnter.TabIndex = 29;
            this.lblDateEnter.Text = ".";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(640, 358);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(10, 13);
            this.lblErrors.TabIndex = 30;
            this.lblErrors.Text = ".";
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1076, 455);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblDateEnter);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTextID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupMoney);
            this.Controls.Add(this.groupEndereço);
            this.Controls.Add(this.boxPhone);
            this.Controls.Add(this.groupSex);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxCpf);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblName);
            this.Name = "EditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de cliente";
            this.groupSex.ResumeLayout(false);
            this.groupSex.PerformLayout();
            this.groupEndereço.ResumeLayout(false);
            this.groupEndereço.PerformLayout();
            this.groupMoney.ResumeLayout(false);
            this.groupMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblFinanc;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxCpf;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.GroupBox groupSex;
        private System.Windows.Forms.RadioButton radioFemini;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.TextBox boxRua;
        private System.Windows.Forms.GroupBox groupEndereço;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox boxEstado;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.TextBox boxNum;
        private System.Windows.Forms.GroupBox groupMoney;
        private System.Windows.Forms.TextBox boxSaldo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericQnt;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTextID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateEnter;
        private System.Windows.Forms.Label lblErrors;
    }
}