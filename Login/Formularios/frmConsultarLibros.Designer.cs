namespace TP_Aplicaciones_Visuales.Formularios
{
    partial class frmConsultarLibros
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
            this.grdLibros = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLibros
            // 
            this.grdLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLibros.Location = new System.Drawing.Point(74, 208);
            this.grdLibros.Name = "grdLibros";
            this.grdLibros.Size = new System.Drawing.Size(675, 150);
            this.grdLibros.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(71, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(195, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(195, 97);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(122, 20);
            this.txtAño.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(195, 62);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(122, 20);
            this.txtTitulo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Genero";
            // 
            // txtEstante
            // 
            this.txtEstante.Location = new System.Drawing.Point(195, 166);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(122, 20);
            this.txtEstante.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estante";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(195, 133);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(122, 20);
            this.txtSector.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sector";
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(539, 28);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboPerfil.TabIndex = 30;
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(539, 62);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 31;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(539, 97);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(121, 21);
            this.cboEditorial.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 51);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 51);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 51);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(700, 387);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 51);
            this.button7.TabIndex = 41;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(623, 387);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 51);
            this.button8.TabIndex = 40;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(546, 387);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 51);
            this.button9.TabIndex = 39;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(326, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 51);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmConsultarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtEstante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.grdLibros);
            this.Name = "frmConsultarLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.ConsultarLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLibros;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
    }
}