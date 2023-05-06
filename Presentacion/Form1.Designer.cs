namespace Presentacion
{
    partial class frRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpProfesor = new System.Windows.Forms.GroupBox();
            this.cbSemillero = new System.Windows.Forms.ComboBox();
            this.cbPosgrado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpCategory = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbOcasional = new System.Windows.Forms.ComboBox();
            this.rdCatedraticos = new System.Windows.Forms.RadioButton();
            this.rdOcasional = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpProfesor.SuspendLayout();
            this.gpCategory.SuspendLayout();
            this.gpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpProfesor
            // 
            this.gpProfesor.Controls.Add(this.cbSemillero);
            this.gpProfesor.Controls.Add(this.cbPosgrado);
            this.gpProfesor.Controls.Add(this.label10);
            this.gpProfesor.Controls.Add(this.label9);
            this.gpProfesor.Controls.Add(this.txtPhone);
            this.gpProfesor.Controls.Add(this.label5);
            this.gpProfesor.Controls.Add(this.txtEmail);
            this.gpProfesor.Controls.Add(this.label4);
            this.gpProfesor.Controls.Add(this.txtLName);
            this.gpProfesor.Controls.Add(this.txtName);
            this.gpProfesor.Controls.Add(this.label3);
            this.gpProfesor.Controls.Add(this.label2);
            this.gpProfesor.Controls.Add(this.txtId);
            this.gpProfesor.Controls.Add(this.label1);
            this.gpProfesor.Location = new System.Drawing.Point(41, 12);
            this.gpProfesor.Name = "gpProfesor";
            this.gpProfesor.Size = new System.Drawing.Size(347, 299);
            this.gpProfesor.TabIndex = 0;
            this.gpProfesor.TabStop = false;
            this.gpProfesor.Text = "Registro profesor";
            // 
            // cbSemillero
            // 
            this.cbSemillero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemillero.FormattingEnabled = true;
            this.cbSemillero.Location = new System.Drawing.Point(63, 255);
            this.cbSemillero.Name = "cbSemillero";
            this.cbSemillero.Size = new System.Drawing.Size(221, 21);
            this.cbSemillero.TabIndex = 12;
            // 
            // cbPosgrado
            // 
            this.cbPosgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosgrado.FormattingEnabled = true;
            this.cbPosgrado.Location = new System.Drawing.Point(63, 220);
            this.cbPosgrado.Name = "cbPosgrado";
            this.cbPosgrado.Size = new System.Drawing.Size(221, 21);
            this.cbPosgrado.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Semillero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Posgrado:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(63, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(64, 102);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(220, 20);
            this.txtLName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(63, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // gpCategory
            // 
            this.gpCategory.Controls.Add(this.txtValor);
            this.gpCategory.Controls.Add(this.label8);
            this.gpCategory.Controls.Add(this.label7);
            this.gpCategory.Controls.Add(this.txtHora);
            this.gpCategory.Controls.Add(this.cbOcasional);
            this.gpCategory.Controls.Add(this.rdCatedraticos);
            this.gpCategory.Controls.Add(this.rdOcasional);
            this.gpCategory.Controls.Add(this.label6);
            this.gpCategory.Location = new System.Drawing.Point(410, 84);
            this.gpCategory.Name = "gpCategory";
            this.gpCategory.Size = new System.Drawing.Size(389, 164);
            this.gpCategory.TabIndex = 1;
            this.gpCategory.TabStop = false;
            this.gpCategory.Text = "Categoria";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(254, 133);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(124, 20);
            this.txtValor.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "# Horas";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(67, 133);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(112, 20);
            this.txtHora.TabIndex = 4;
            // 
            // cbOcasional
            // 
            this.cbOcasional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOcasional.FormattingEnabled = true;
            this.cbOcasional.Location = new System.Drawing.Point(21, 81);
            this.cbOcasional.Name = "cbOcasional";
            this.cbOcasional.Size = new System.Drawing.Size(283, 21);
            this.cbOcasional.TabIndex = 3;
            // 
            // rdCatedraticos
            // 
            this.rdCatedraticos.AutoSize = true;
            this.rdCatedraticos.Location = new System.Drawing.Point(21, 110);
            this.rdCatedraticos.Name = "rdCatedraticos";
            this.rdCatedraticos.Size = new System.Drawing.Size(84, 17);
            this.rdCatedraticos.TabIndex = 2;
            this.rdCatedraticos.TabStop = true;
            this.rdCatedraticos.Text = "Catedráticos";
            this.rdCatedraticos.UseVisualStyleBackColor = true;
            this.rdCatedraticos.CheckedChanged += new System.EventHandler(this.rdCatedraticos_CheckedChanged);
            // 
            // rdOcasional
            // 
            this.rdOcasional.AutoSize = true;
            this.rdOcasional.Location = new System.Drawing.Point(21, 58);
            this.rdOcasional.Name = "rdOcasional";
            this.rdOcasional.Size = new System.Drawing.Size(72, 17);
            this.rdOcasional.TabIndex = 1;
            this.rdOcasional.TabStop = true;
            this.rdOcasional.Text = "Ocasional";
            this.rdOcasional.UseVisualStyleBackColor = true;
            this.rdOcasional.CheckedChanged += new System.EventHandler(this.rdOcasional_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione el tipo de profesor:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnCancelar);
            this.gpButtons.Controls.Add(this.btnAgregar);
            this.gpButtons.Location = new System.Drawing.Point(308, 317);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Size = new System.Drawing.Size(254, 46);
            this.gpButtons.TabIndex = 3;
            this.gpButtons.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.gpButtons);
            this.Controls.Add(this.gpCategory);
            this.Controls.Add(this.gpProfesor);
            this.Name = "frRegistro";
            this.Text = "Registro";
            this.gpProfesor.ResumeLayout(false);
            this.gpProfesor.PerformLayout();
            this.gpCategory.ResumeLayout(false);
            this.gpCategory.PerformLayout();
            this.gpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpCategory;
        private System.Windows.Forms.ComboBox cbOcasional;
        private System.Windows.Forms.RadioButton rdCatedraticos;
        private System.Windows.Forms.RadioButton rdOcasional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpButtons;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbSemillero;
        public System.Windows.Forms.ComboBox cbPosgrado;
    }
}

