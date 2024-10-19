﻿namespace MultiplasJanelas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            buttonViewClientes = new Button();
            buttonViewProdutos = new Button();
            buttonViewVendas = new Button();
            buttonAdicionarProd = new Button();
            buttonRemoverProd = new Button();
            buttonViewCompras = new Button();
            buttonViewFornecedores = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonAdicionarClient = new Button();
            buttonAdicionarCompra = new Button();
            button3 = new Button();
            buttonRemoverClient = new Button();
            buttonAdicionarFornecedores = new Button();
            button7 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(2, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1138, 433);
            dataGridView1.TabIndex = 2;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.Anchor = AnchorStyles.Top;
            buttonViewClientes.BackColor = Color.DarkGray;
            buttonViewClientes.Cursor = Cursors.Hand;
            buttonViewClientes.FlatStyle = FlatStyle.Flat;
            buttonViewClientes.ForeColor = Color.White;
            buttonViewClientes.Image = Properties.Resources.cliente;
            buttonViewClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewClientes.Location = new Point(674, 30);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(182, 32);
            buttonViewClientes.TabIndex = 5;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.UseVisualStyleBackColor = false;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.Anchor = AnchorStyles.Top;
            buttonViewProdutos.BackColor = Color.DarkGray;
            buttonViewProdutos.Cursor = Cursors.Hand;
            buttonViewProdutos.FlatStyle = FlatStyle.Flat;
            buttonViewProdutos.ForeColor = Color.White;
            buttonViewProdutos.Image = Properties.Resources.produto;
            buttonViewProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewProdutos.Location = new Point(469, 30);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(183, 32);
            buttonViewProdutos.TabIndex = 4;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.UseVisualStyleBackColor = false;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.Anchor = AnchorStyles.Top;
            buttonViewVendas.BackColor = Color.DarkGray;
            buttonViewVendas.Cursor = Cursors.Hand;
            buttonViewVendas.FlatStyle = FlatStyle.Flat;
            buttonViewVendas.ForeColor = Color.White;
            buttonViewVendas.Image = Properties.Resources.venda;
            buttonViewVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewVendas.Location = new Point(264, 30);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(182, 32);
            buttonViewVendas.TabIndex = 6;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonAdicionarProd
            // 
            buttonAdicionarProd.BackColor = Color.DarkGray;
            buttonAdicionarProd.Cursor = Cursors.Hand;
            buttonAdicionarProd.FlatAppearance.BorderSize = 0;
            buttonAdicionarProd.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProd.ForeColor = Color.White;
            buttonAdicionarProd.Location = new Point(469, 68);
            buttonAdicionarProd.Name = "buttonAdicionarProd";
            buttonAdicionarProd.Size = new Size(183, 25);
            buttonAdicionarProd.TabIndex = 0;
            buttonAdicionarProd.Text = "Adicionar Produtos";
            buttonAdicionarProd.UseVisualStyleBackColor = false;
            buttonAdicionarProd.Click += buttonAdicionarProd_Click;
            // 
            // buttonRemoverProd
            // 
            buttonRemoverProd.BackColor = Color.DarkGray;
            buttonRemoverProd.Cursor = Cursors.Hand;
            buttonRemoverProd.FlatAppearance.BorderSize = 0;
            buttonRemoverProd.FlatStyle = FlatStyle.Flat;
            buttonRemoverProd.ForeColor = Color.White;
            buttonRemoverProd.Location = new Point(469, 99);
            buttonRemoverProd.Name = "buttonRemoverProd";
            buttonRemoverProd.Size = new Size(183, 25);
            buttonRemoverProd.TabIndex = 1;
            buttonRemoverProd.Text = "Remover Produtos";
            buttonRemoverProd.UseVisualStyleBackColor = false;
            buttonRemoverProd.Click += buttonRemoverProd_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.Anchor = AnchorStyles.None;
            buttonViewCompras.BackColor = Color.DarkGray;
            buttonViewCompras.Cursor = Cursors.Hand;
            buttonViewCompras.FlatStyle = FlatStyle.Flat;
            buttonViewCompras.ForeColor = Color.White;
            buttonViewCompras.Image = Properties.Resources.compra;
            buttonViewCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewCompras.Location = new Point(52, 30);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(182, 32);
            buttonViewCompras.TabIndex = 8;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.Anchor = AnchorStyles.Top;
            buttonViewFornecedores.BackColor = Color.DarkGray;
            buttonViewFornecedores.Cursor = Cursors.Hand;
            buttonViewFornecedores.FlatStyle = FlatStyle.Flat;
            buttonViewFornecedores.ForeColor = Color.White;
            buttonViewFornecedores.Image = Properties.Resources.fornecedor;
            buttonViewFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewFornecedores.Location = new Point(880, 30);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(182, 32);
            buttonViewFornecedores.TabIndex = 7;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(264, 68);
            button2.Name = "button2";
            button2.Size = new Size(182, 25);
            button2.TabIndex = 9;
            button2.Text = "Adicionar Vendas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 98);
            button1.Name = "button1";
            button1.Size = new Size(182, 27);
            button1.TabIndex = 10;
            button1.Text = "Remover Vendas";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionarClient
            // 
            buttonAdicionarClient.BackColor = Color.DarkGray;
            buttonAdicionarClient.Cursor = Cursors.Hand;
            buttonAdicionarClient.FlatAppearance.BorderSize = 0;
            buttonAdicionarClient.FlatStyle = FlatStyle.Flat;
            buttonAdicionarClient.ForeColor = Color.White;
            buttonAdicionarClient.Location = new Point(674, 68);
            buttonAdicionarClient.Name = "buttonAdicionarClient";
            buttonAdicionarClient.Size = new Size(182, 25);
            buttonAdicionarClient.TabIndex = 13;
            buttonAdicionarClient.Text = "Adicionar Cliente";
            buttonAdicionarClient.UseVisualStyleBackColor = false;
            buttonAdicionarClient.Click += buttonAdicionarClient_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = Color.DarkGray;
            buttonAdicionarCompra.Cursor = Cursors.Hand;
            buttonAdicionarCompra.FlatAppearance.BorderSize = 0;
            buttonAdicionarCompra.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCompra.ForeColor = Color.White;
            buttonAdicionarCompra.Location = new Point(52, 68);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(182, 25);
            buttonAdicionarCompra.TabIndex = 11;
            buttonAdicionarCompra.Text = "Adicionar Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(52, 100);
            button3.Name = "button3";
            button3.Size = new Size(182, 25);
            button3.TabIndex = 12;
            button3.Text = "Remover Compra";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonRemoverClient
            // 
            buttonRemoverClient.BackColor = Color.DarkGray;
            buttonRemoverClient.Cursor = Cursors.Hand;
            buttonRemoverClient.FlatAppearance.BorderSize = 0;
            buttonRemoverClient.FlatStyle = FlatStyle.Flat;
            buttonRemoverClient.ForeColor = Color.White;
            buttonRemoverClient.Location = new Point(674, 99);
            buttonRemoverClient.Name = "buttonRemoverClient";
            buttonRemoverClient.Size = new Size(182, 25);
            buttonRemoverClient.TabIndex = 14;
            buttonRemoverClient.Text = "Remover Cliente";
            buttonRemoverClient.UseVisualStyleBackColor = false;
            buttonRemoverClient.Click += buttonRemoverClient_Click;
            // 
            // buttonAdicionarFornecedores
            // 
            buttonAdicionarFornecedores.BackColor = Color.DarkGray;
            buttonAdicionarFornecedores.Cursor = Cursors.Hand;
            buttonAdicionarFornecedores.FlatAppearance.BorderSize = 0;
            buttonAdicionarFornecedores.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFornecedores.ForeColor = Color.White;
            buttonAdicionarFornecedores.Location = new Point(880, 68);
            buttonAdicionarFornecedores.Name = "buttonAdicionarFornecedores";
            buttonAdicionarFornecedores.Size = new Size(182, 25);
            buttonAdicionarFornecedores.TabIndex = 15;
            buttonAdicionarFornecedores.Text = "Adicionar Fornecedor";
            buttonAdicionarFornecedores.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedores.Click += buttonAdicionarFornecedores_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkGray;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(880, 99);
            button7.Name = "button7";
            button7.Size = new Size(182, 25);
            button7.TabIndex = 16;
            button7.Text = "Remover Fornecedor";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(buttonViewCompras);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonAdicionarFornecedores);
            panel1.Controls.Add(buttonAdicionarCompra);
            panel1.Controls.Add(buttonRemoverClient);
            panel1.Controls.Add(buttonViewVendas);
            panel1.Controls.Add(buttonAdicionarClient);
            panel1.Controls.Add(buttonViewFornecedores);
            panel1.Controls.Add(buttonRemoverProd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonAdicionarProd);
            panel1.Controls.Add(buttonViewClientes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonViewProdutos);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 167);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1142, 625);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonViewClientes;
        private Button buttonViewProdutos;
        private Button buttonViewVendas;
        private Button buttonAdicionarProd;
        private Button buttonRemoverProd;
        private Button buttonViewCompras;
        private Button buttonViewFornecedores;
        private Button button2;
        private Button button1;
        private Button buttonAdicionarClient;
        private Button buttonAdicionarCompra;
        private Button button3;
        private Button buttonRemoverClient;
        private Button buttonAdicionarFornecedores;
        private Button button7;
        private Panel panel1;
    }
}
