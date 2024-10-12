namespace MultiplasJanelas
{
    partial class FormCriarProduto
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
            buttonOk = new Button();
            buttonCancelar = new Button();
            labelPrecodeVenda = new Label();
            labelFabricante = new Label();
            labelPrecodeCompra = new Label();
            labelNomedoProduto = new Label();
            inputPrecoCompra = new NumericUpDown();
            InputPrecoVenda = new NumericUpDown();
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(34, 203);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(143, 203);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelPrecodeVenda
            // 
            labelPrecodeVenda.AutoSize = true;
            labelPrecodeVenda.Location = new Point(34, 146);
            labelPrecodeVenda.Name = "labelPrecodeVenda";
            labelPrecodeVenda.Size = new Size(88, 15);
            labelPrecodeVenda.TabIndex = 0;
            labelPrecodeVenda.Text = "Preço de Venda";
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.Location = new Point(34, 90);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(62, 15);
            labelFabricante.TabIndex = 0;
            labelFabricante.Text = "Fabricante";
            // 
            // labelPrecodeCompra
            // 
            labelPrecodeCompra.AutoSize = true;
            labelPrecodeCompra.Location = new Point(34, 121);
            labelPrecodeCompra.Name = "labelPrecodeCompra";
            labelPrecodeCompra.Size = new Size(99, 15);
            labelPrecodeCompra.TabIndex = 0;
            labelPrecodeCompra.Text = "Preço de Compra";
            // 
            // labelNomedoProduto
            // 
            labelNomedoProduto.AutoSize = true;
            labelNomedoProduto.Location = new Point(34, 62);
            labelNomedoProduto.Name = "labelNomedoProduto";
            labelNomedoProduto.Size = new Size(103, 15);
            labelNomedoProduto.TabIndex = 0;
            labelNomedoProduto.Text = "Nome do Produto";
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(143, 113);
            inputPrecoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(120, 23);
            inputPrecoCompra.TabIndex = 3;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // InputPrecoVenda
            // 
            InputPrecoVenda.DecimalPlaces = 2;
            InputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InputPrecoVenda.Location = new Point(143, 146);
            InputPrecoVenda.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            InputPrecoVenda.Name = "InputPrecoVenda";
            InputPrecoVenda.Size = new Size(120, 23);
            InputPrecoVenda.TabIndex = 4;
            InputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(143, 62);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(120, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(143, 87);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(120, 23);
            textBoxFabricante.TabIndex = 2;
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(284, 270);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(InputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(labelNomedoProduto);
            Controls.Add(labelPrecodeCompra);
            Controls.Add(labelFabricante);
            Controls.Add(labelPrecodeVenda);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormCriarProduto";
            Text = "FormCriarProduto";
            Load += FormCriarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancelar;
        private Label labelPrecodeVenda;
        private Label labelFabricante;
        private Label labelPrecodeCompra;
        private Label labelNomedoProduto;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown InputPrecoVenda;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
    }
}