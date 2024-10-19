namespace MultiplasJanelas
{
    partial class FormCriarCompra
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
            comboBoxFornecedor = new ComboBox();
            comboBoxProduto = new ComboBox();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            textBoxValorTotal = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            textBoxTotalComDesconto = new TextBox();
            buttonCancelar = new Button();
            buttonOk = new Button();
            labelProduto = new Label();
            labelFornecedor = new Label();
            labelQuantidade = new Label();
            labelDesconto = new Label();
            labelPrecoUnitario = new Label();
            labelValorTotal = new Label();
            labelTotalComDesconto = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(164, 61);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(214, 23);
            comboBoxFornecedor.TabIndex = 0;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(164, 31);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(214, 23);
            comboBoxProduto.TabIndex = 0;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(164, 90);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(214, 23);
            numericUpDownQuantidade.TabIndex = 1;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Location = new Point(164, 119);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(214, 23);
            numericUpDownDesconto.TabIndex = 1;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ControlDarkDark;
            textBoxValorTotal.Location = new Point(165, 182);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(213, 23);
            textBoxValorTotal.TabIndex = 2;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.ControlDarkDark;
            textBoxPrecoUnitario.Location = new Point(165, 153);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(213, 23);
            textBoxPrecoUnitario.TabIndex = 2;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = SystemColors.ControlDarkDark;
            textBoxTotalComDesconto.Location = new Point(165, 211);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(213, 23);
            textBoxTotalComDesconto.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(289, 263);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(185, 263);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(35, 39);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(56, 15);
            labelProduto.TabIndex = 4;
            labelProduto.Text = "Produto :";
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new Point(35, 69);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(73, 15);
            labelFornecedor.TabIndex = 4;
            labelFornecedor.Text = "Fornecedor :";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(35, 98);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(75, 15);
            labelQuantidade.TabIndex = 4;
            labelQuantidade.Text = "Quantidade :";
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(35, 124);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(84, 15);
            labelDesconto.TabIndex = 4;
            labelDesconto.Text = "Desconto (%) :";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(35, 153);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(91, 15);
            labelPrecoUnitario.TabIndex = 4;
            labelPrecoUnitario.Text = "Preço Unitário : ";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(35, 192);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(70, 15);
            labelValorTotal.TabIndex = 4;
            labelValorTotal.Text = "Valor Total : ";
            // 
            // labelTotalComDesconto
            // 
            labelTotalComDesconto.AutoSize = true;
            labelTotalComDesconto.Location = new Point(35, 220);
            labelTotalComDesconto.Name = "labelTotalComDesconto";
            labelTotalComDesconto.Size = new Size(123, 15);
            labelTotalComDesconto.TabIndex = 4;
            labelTotalComDesconto.Text = "Total Com Desconto : ";
            // 
            // FormCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 310);
            Controls.Add(labelTotalComDesconto);
            Controls.Add(labelValorTotal);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelDesconto);
            Controls.Add(labelQuantidade);
            Controls.Add(labelFornecedor);
            Controls.Add(labelProduto);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(comboBoxProduto);
            Controls.Add(comboBoxFornecedor);
            Name = "FormCriarCompra";
            Text = "FormCriarCompra";
            Load += FormCriarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFornecedor;
        private ComboBox comboBoxProduto;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxValorTotal;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxTotalComDesconto;
        private Button buttonCancelar;
        private Button buttonOk;
        private Label labelProduto;
        private Label labelFornecedor;
        private Label labelQuantidade;
        private Label labelDesconto;
        private Label labelPrecoUnitario;
        private Label labelValorTotal;
        private Label labelTotalComDesconto;
    }
}