namespace AppProductos
{
    partial class FrmProducto
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
            LblCodigo = new Label();
            BtnCargar = new Button();
            TxtCodigo = new TextBox();
            TxtMarca = new TextBox();
            LblMarca = new Label();
            TxtPrecioUnitario = new TextBox();
            LblPrecio = new Label();
            Rbt = new RadioButton();
            RbtPack = new RadioButton();
            BtnMostrar = new Button();
            LstProductos = new ListBox();
            SuspendLayout();
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(55, 78);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código";
            // 
            // BtnCargar
            // 
            BtnCargar.Location = new Point(55, 268);
            BtnCargar.Name = "BtnCargar";
            BtnCargar.Size = new Size(75, 23);
            BtnCargar.TabIndex = 5;
            BtnCargar.Text = "button1";
            BtnCargar.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(160, 75);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(149, 23);
            TxtCodigo.TabIndex = 2;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(160, 133);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(149, 23);
            TxtMarca.TabIndex = 3;
            // 
            // LblMarca
            // 
            LblMarca.AutoSize = true;
            LblMarca.Location = new Point(55, 136);
            LblMarca.Name = "LblMarca";
            LblMarca.Size = new Size(40, 15);
            LblMarca.TabIndex = 3;
            LblMarca.Text = "Marca";
            // 
            // TxtPrecioUnitario
            // 
            TxtPrecioUnitario.Location = new Point(160, 190);
            TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            TxtPrecioUnitario.Size = new Size(149, 23);
            TxtPrecioUnitario.TabIndex = 4;
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(55, 193);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(85, 15);
            LblPrecio.TabIndex = 5;
            LblPrecio.Text = "Precio Unitario";
            // 
            // Rbt
            // 
            Rbt.AutoSize = true;
            Rbt.Location = new Point(55, 32);
            Rbt.Name = "Rbt";
            Rbt.Size = new Size(58, 19);
            Rbt.TabIndex = 0;
            Rbt.TabStop = true;
            Rbt.Text = "Suelto";
            Rbt.UseVisualStyleBackColor = true;
            // 
            // RbtPack
            // 
            RbtPack.AutoSize = true;
            RbtPack.Location = new Point(160, 32);
            RbtPack.Name = "RbtPack";
            RbtPack.Size = new Size(50, 19);
            RbtPack.TabIndex = 1;
            RbtPack.TabStop = true;
            RbtPack.Text = "Pack";
            RbtPack.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(234, 268);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(75, 23);
            BtnMostrar.TabIndex = 6;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // LstProductos
            // 
            LstProductos.FormattingEnabled = true;
            LstProductos.ItemHeight = 15;
            LstProductos.Location = new Point(382, 32);
            LstProductos.Name = "LstProductos";
            LstProductos.Size = new Size(182, 259);
            LstProductos.TabIndex = 7;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(616, 327);
            Controls.Add(LstProductos);
            Controls.Add(BtnMostrar);
            Controls.Add(RbtPack);
            Controls.Add(Rbt);
            Controls.Add(TxtPrecioUnitario);
            Controls.Add(LblPrecio);
            Controls.Add(TxtMarca);
            Controls.Add(LblMarca);
            Controls.Add(TxtCodigo);
            Controls.Add(BtnCargar);
            Controls.Add(LblCodigo);
            Name = "FrmProducto";
            Text = "Productos";
            Load += this.FrmProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCodigo;
        private Button BtnCargar;
        private TextBox TxtCodigo;
        private TextBox TxtMarca;
        private Label LblMarca;
        private TextBox TxtPrecioUnitario;
        private Label LblPrecio;
        private RadioButton Rbt;
        private RadioButton RbtPack;
        private Button BtnMostrar;
        private ListBox LstProductos;
    }
}
