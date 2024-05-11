namespace Personas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblSexo = new Label();
            LblFallecido = new Label();
            Lst = new ListBox();
            LblApellido = new TextBox();
            LblNombre = new TextBox();
            LblTipoDni = new TextBox();
            LblNumeroDni = new TextBox();
            LblEstadoCivil = new TextBox();
            RadioBtnFemenino = new RadioButton();
            RadioBtnMaculino = new RadioButton();
            CheckBox = new CheckBox();
            BtnNuevo = new Button();
            BtnEditar = new Button();
            BtnBorrar = new Button();
            BtnGrabar = new Button();
            BtnCancelar = new Button();
            BtnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 68);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 110);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 154);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 198);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado Civil";
            // 
            // LblSexo
            // 
            LblSexo.AutoSize = true;
            LblSexo.Location = new Point(111, 239);
            LblSexo.Name = "LblSexo";
            LblSexo.Size = new Size(32, 15);
            LblSexo.TabIndex = 5;
            LblSexo.Text = "Sexo";
            // 
            // LblFallecido
            // 
            LblFallecido.AutoSize = true;
            LblFallecido.Enabled = false;
            LblFallecido.Location = new Point(89, 313);
            LblFallecido.Name = "LblFallecido";
            LblFallecido.Size = new Size(54, 15);
            LblFallecido.TabIndex = 6;
            LblFallecido.Text = "Fallecido";
            // 
            // Lst
            // 
            Lst.FormattingEnabled = true;
            Lst.ItemHeight = 15;
            Lst.Location = new Point(411, 25);
            Lst.Name = "Lst";
            Lst.Size = new Size(219, 304);
            Lst.TabIndex = 8;
            Lst.Tag = "";
            // 
            // LblApellido
            // 
            LblApellido.Enabled = false;
            LblApellido.Location = new Point(189, 25);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(194, 23);
            LblApellido.TabIndex = 0;
            LblApellido.Text = "Perez";
            LblApellido.TextChanged += textBox1_TextChanged;
            // 
            // LblNombre
            // 
            LblNombre.Enabled = false;
            LblNombre.Location = new Point(189, 64);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(194, 23);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Juan";
            // 
            // LblTipoDni
            // 
            LblTipoDni.Enabled = false;
            LblTipoDni.Location = new Point(189, 106);
            LblTipoDni.Name = "LblTipoDni";
            LblTipoDni.Size = new Size(194, 23);
            LblTipoDni.TabIndex = 2;
            LblTipoDni.Text = "DNI";
            // 
            // LblNumeroDni
            // 
            LblNumeroDni.Enabled = false;
            LblNumeroDni.Location = new Point(189, 150);
            LblNumeroDni.Name = "LblNumeroDni";
            LblNumeroDni.Size = new Size(194, 23);
            LblNumeroDni.TabIndex = 3;
            LblNumeroDni.Text = "123456";
            // 
            // LblEstadoCivil
            // 
            LblEstadoCivil.Enabled = false;
            LblEstadoCivil.Location = new Point(189, 194);
            LblEstadoCivil.Name = "LblEstadoCivil";
            LblEstadoCivil.Size = new Size(194, 23);
            LblEstadoCivil.TabIndex = 4;
            LblEstadoCivil.Text = "SOLTERO";
            // 
            // RadioBtnFemenino
            // 
            RadioBtnFemenino.AutoSize = true;
            RadioBtnFemenino.Enabled = false;
            RadioBtnFemenino.Location = new Point(189, 237);
            RadioBtnFemenino.Name = "RadioBtnFemenino";
            RadioBtnFemenino.Size = new Size(78, 19);
            RadioBtnFemenino.TabIndex = 5;
            RadioBtnFemenino.Text = "Femenino";
            RadioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // RadioBtnMaculino
            // 
            RadioBtnMaculino.AutoSize = true;
            RadioBtnMaculino.Checked = true;
            RadioBtnMaculino.Enabled = false;
            RadioBtnMaculino.Location = new Point(189, 271);
            RadioBtnMaculino.Name = "RadioBtnMaculino";
            RadioBtnMaculino.Size = new Size(75, 19);
            RadioBtnMaculino.TabIndex = 6;
            RadioBtnMaculino.TabStop = true;
            RadioBtnMaculino.Text = "Maculino";
            RadioBtnMaculino.UseVisualStyleBackColor = true;
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.Enabled = false;
            CheckBox.Location = new Point(189, 311);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(15, 14);
            CheckBox.TabIndex = 7;
            CheckBox.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(28, 369);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 23);
            BtnNuevo.TabIndex = 9;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(128, 369);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Location = new Point(229, 369);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(75, 23);
            BtnBorrar.TabIndex = 11;
            BtnBorrar.Text = "Borrar";
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnGrabar
            // 
            BtnGrabar.Enabled = false;
            BtnGrabar.Location = new Point(337, 369);
            BtnGrabar.Name = "BtnGrabar";
            BtnGrabar.Size = new Size(75, 23);
            BtnGrabar.TabIndex = 12;
            BtnGrabar.Text = "Grabar";
            BtnGrabar.UseVisualStyleBackColor = true;
            BtnGrabar.Click += button4_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Location = new Point(446, 369);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(544, 369);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 14;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 416);
            Controls.Add(BtnSalir);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGrabar);
            Controls.Add(BtnBorrar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNuevo);
            Controls.Add(CheckBox);
            Controls.Add(RadioBtnMaculino);
            Controls.Add(RadioBtnFemenino);
            Controls.Add(LblEstadoCivil);
            Controls.Add(LblNumeroDni);
            Controls.Add(LblTipoDni);
            Controls.Add(LblNombre);
            Controls.Add(LblApellido);
            Controls.Add(Lst);
            Controls.Add(LblFallecido);
            Controls.Add(LblSexo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "A B M Personas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblSexo;
        private Label LblFallecido;
        private ListBox Lst;
        private TextBox LblApellido;
        private TextBox LblNombre;
        private TextBox LblTipoDni;
        private TextBox LblNumeroDni;
        private TextBox LblEstadoCivil;
        private RadioButton RadioBtnFemenino;
        private RadioButton RadioBtnMaculino;
        private CheckBox CheckBox;
        private Button BtnNuevo;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Button BtnGrabar;
        private Button BtnCancelar;
        private Button BtnSalir;
    }
}
