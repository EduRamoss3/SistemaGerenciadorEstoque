namespace SistemaGerenciadorInventario
{
    partial class ClientAddScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boxCPF = new System.Windows.Forms.TextBox();
            this.boxStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateNasc = new System.Windows.Forms.Label();
            this.grouplSex = new System.Windows.Forms.GroupBox();
            this.radioFemini = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.groupEnde = new System.Windows.Forms.GroupBox();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblEstate = new System.Windows.Forms.Label();
            this.boxState = new System.Windows.Forms.TextBox();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.boxTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grouplSex.SuspendLayout();
            this.groupEnde.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(90, 60);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(269, 20);
            this.boxName.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // boxCPF
            // 
            this.boxCPF.Location = new System.Drawing.Point(90, 86);
            this.boxCPF.Name = "boxCPF";
            this.boxCPF.Size = new System.Drawing.Size(131, 20);
            this.boxCPF.TabIndex = 4;
            // 
            // boxStreet
            // 
            this.boxStreet.Location = new System.Drawing.Point(78, 26);
            this.boxStreet.Name = "boxStreet";
            this.boxStreet.Size = new System.Drawing.Size(269, 20);
            this.boxStreet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(38, 57);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "Cidade";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(45, 29);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(27, 13);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "Rua";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblDateNasc
            // 
            this.lblDateNasc.AutoSize = true;
            this.lblDateNasc.Location = new System.Drawing.Point(144, 118);
            this.lblDateNasc.Name = "lblDateNasc";
            this.lblDateNasc.Size = new System.Drawing.Size(102, 13);
            this.lblDateNasc.TabIndex = 15;
            this.lblDateNasc.Text = "Data de nascimento";
            // 
            // grouplSex
            // 
            this.grouplSex.Controls.Add(this.radioFemini);
            this.grouplSex.Controls.Add(this.radioMasc);
            this.grouplSex.Location = new System.Drawing.Point(100, 160);
            this.grouplSex.Name = "grouplSex";
            this.grouplSex.Size = new System.Drawing.Size(193, 84);
            this.grouplSex.TabIndex = 16;
            this.grouplSex.TabStop = false;
            this.grouplSex.Text = "Sexo:";
            // 
            // radioFemini
            // 
            this.radioFemini.AutoSize = true;
            this.radioFemini.Location = new System.Drawing.Point(109, 45);
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
            this.radioMasc.Location = new System.Drawing.Point(11, 45);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // groupEnde
            // 
            this.groupEnde.Controls.Add(this.boxNumero);
            this.groupEnde.Controls.Add(this.lblN);
            this.groupEnde.Controls.Add(this.lblEstate);
            this.groupEnde.Controls.Add(this.boxState);
            this.groupEnde.Controls.Add(this.boxCity);
            this.groupEnde.Controls.Add(this.lblEnd);
            this.groupEnde.Controls.Add(this.lblCity);
            this.groupEnde.Controls.Add(this.boxStreet);
            this.groupEnde.Location = new System.Drawing.Point(12, 254);
            this.groupEnde.Name = "groupEnde";
            this.groupEnde.Size = new System.Drawing.Size(365, 88);
            this.groupEnde.TabIndex = 17;
            this.groupEnde.TabStop = false;
            this.groupEnde.Text = "Endereço";
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(305, 54);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(42, 20);
            this.boxNumero.TabIndex = 25;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(277, 57);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 13);
            this.lblN.TabIndex = 24;
            this.lblN.Text = "N.º";
            // 
            // lblEstate
            // 
            this.lblEstate.AutoSize = true;
            this.lblEstate.Location = new System.Drawing.Point(145, 57);
            this.lblEstate.Name = "lblEstate";
            this.lblEstate.Size = new System.Drawing.Size(40, 13);
            this.lblEstate.TabIndex = 19;
            this.lblEstate.Text = "Estado";
            // 
            // boxState
            // 
            this.boxState.Location = new System.Drawing.Point(191, 54);
            this.boxState.Name = "boxState";
            this.boxState.Size = new System.Drawing.Size(67, 20);
            this.boxState.TabIndex = 16;
            // 
            // boxCity
            // 
            this.boxCity.Location = new System.Drawing.Point(78, 54);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(59, 20);
            this.boxCity.TabIndex = 14;
            // 
            // boxTel
            // 
            this.boxTel.Location = new System.Drawing.Point(90, 361);
            this.boxTel.Name = "boxTel";
            this.boxTel.Size = new System.Drawing.Size(140, 20);
            this.boxTel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Telefone +55";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(52, 408);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "Email";
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(90, 401);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(269, 20);
            this.boxEmail.TabIndex = 22;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(247, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.register_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(82, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Retornar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(9, 461);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(172, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "exemplo@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cadastro de cliente";
            // 
            // ClientAddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxTel);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupEnde);
            this.Controls.Add(this.grouplSex);
            this.Controls.Add(this.lblDateNasc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCPF);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ClientAddScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.grouplSex.ResumeLayout(false);
            this.grouplSex.PerformLayout();
            this.groupEnde.ResumeLayout(false);
            this.groupEnde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox boxCPF;
        private System.Windows.Forms.TextBox boxStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateNasc;
        private System.Windows.Forms.GroupBox grouplSex;
        private System.Windows.Forms.RadioButton radioFemini;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.GroupBox groupEnde;
        private System.Windows.Forms.TextBox boxTel;
        private System.Windows.Forms.TextBox boxState;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label lblEstate;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}