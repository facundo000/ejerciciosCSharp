namespace Problema_5_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBoxDetalle = new TextBox();
            RBtnNotebook = new RadioButton();
            RBtnNetbook = new RadioButton();
            TBoxCodigo = new TextBox();
            TBoxPrecio = new TextBox();
            DTimeFecha = new DateTimePicker();
            BtnNuevo = new Button();
            BtnCancelar = new Button();
            BtnGrabar = new Button();
            BtnSalir = new Button();
            CBoxMarca = new ComboBox();
            TBoxProductos = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 217);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha";
            // 
            // TBoxDetalle
            // 
            TBoxDetalle.Enabled = false;
            TBoxDetalle.Location = new Point(81, 48);
            TBoxDetalle.Name = "TBoxDetalle";
            TBoxDetalle.Size = new Size(183, 23);
            TBoxDetalle.TabIndex = 7;
            // 
            // RBtnNotebook
            // 
            RBtnNotebook.AutoSize = true;
            RBtnNotebook.Enabled = false;
            RBtnNotebook.Location = new Point(81, 110);
            RBtnNotebook.Name = "RBtnNotebook";
            RBtnNotebook.Size = new Size(78, 19);
            RBtnNotebook.TabIndex = 9;
            RBtnNotebook.TabStop = true;
            RBtnNotebook.Text = "Notebook";
            RBtnNotebook.UseVisualStyleBackColor = true;
            // 
            // RBtnNetbook
            // 
            RBtnNetbook.AutoSize = true;
            RBtnNetbook.Enabled = false;
            RBtnNetbook.Location = new Point(81, 144);
            RBtnNetbook.Name = "RBtnNetbook";
            RBtnNetbook.Size = new Size(71, 19);
            RBtnNetbook.TabIndex = 10;
            RBtnNetbook.TabStop = true;
            RBtnNetbook.Text = "Netbook";
            RBtnNetbook.UseVisualStyleBackColor = true;
            // 
            // TBoxCodigo
            // 
            TBoxCodigo.Enabled = false;
            TBoxCodigo.Location = new Point(81, 13);
            TBoxCodigo.Name = "TBoxCodigo";
            TBoxCodigo.Size = new Size(130, 23);
            TBoxCodigo.TabIndex = 6;
            // 
            // TBoxPrecio
            // 
            TBoxPrecio.Enabled = false;
            TBoxPrecio.Location = new Point(81, 181);
            TBoxPrecio.Name = "TBoxPrecio";
            TBoxPrecio.Size = new Size(130, 23);
            TBoxPrecio.TabIndex = 11;
            // 
            // DTimeFecha
            // 
            DTimeFecha.Enabled = false;
            DTimeFecha.Location = new Point(81, 213);
            DTimeFecha.Name = "DTimeFecha";
            DTimeFecha.Size = new Size(130, 23);
            DTimeFecha.TabIndex = 13;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(22, 291);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 66);
            BtnNuevo.TabIndex = 14;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Location = new Point(121, 291);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 66);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGrabar
            // 
            BtnGrabar.Enabled = false;
            BtnGrabar.Location = new Point(218, 291);
            BtnGrabar.Name = "BtnGrabar";
            BtnGrabar.Size = new Size(75, 66);
            BtnGrabar.TabIndex = 16;
            BtnGrabar.Text = "Grabar";
            BtnGrabar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(457, 291);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 66);
            BtnSalir.TabIndex = 17;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // CBoxMarca
            // 
            CBoxMarca.Enabled = false;
            CBoxMarca.FormattingEnabled = true;
            CBoxMarca.Location = new Point(81, 81);
            CBoxMarca.Name = "CBoxMarca";
            CBoxMarca.Size = new Size(183, 23);
            CBoxMarca.TabIndex = 18;
            // 
            // TBoxProductos
            // 
            TBoxProductos.Location = new Point(325, 13);
            TBoxProductos.Name = "TBoxProductos";
            TBoxProductos.Size = new Size(208, 258);
            TBoxProductos.TabIndex = 19;
            TBoxProductos.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 375);
            Controls.Add(TBoxProductos);
            Controls.Add(CBoxMarca);
            Controls.Add(BtnSalir);
            Controls.Add(BtnGrabar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnNuevo);
            Controls.Add(DTimeFecha);
            Controls.Add(TBoxPrecio);
            Controls.Add(RBtnNetbook);
            Controls.Add(RBtnNotebook);
            Controls.Add(TBoxDetalle);
            Controls.Add(TBoxCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TBoxDetalle;
        private RadioButton RBtnNotebook;
        private RadioButton RBtnNetbook;
        private TextBox TBoxCodigo;
        private TextBox TBoxPrecio;
        private DateTimePicker DTimeFecha;
        private Button BtnNuevo;
        private Button BtnCancelar;
        private Button BtnGrabar;
        private Button BtnSalir;
        private ComboBox CBoxMarca;
        private RichTextBox TBoxProductos;
    }
}
