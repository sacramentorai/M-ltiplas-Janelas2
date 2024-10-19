using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }


        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.Visible = false;

        }

        private void buttonAdicionarProd_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resulta = fcp.ShowDialog();
            if (resulta == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;
                produto.Nome = fcp.nomeProduto;
                produto.Fabricante = fcp.nomeFabricante;
                produto.PrecoCompra = fcp.precoCompra;
                produto.PrecoVenda = fcp.precoVenda;

                produtos.Add(produto);
            }
        }

        private void buttonRemoverProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    produtos.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado para remo��o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Erro ao tentar remover o produto: o �ndice est� fora do intervalo." +
                                "\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewProdutos_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; this.dataGridView1.Visible = true; }
        private void buttonViewClientes_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = clientes; this.dataGridView1.Visible = true; }
        private void buttonViewVendas_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = vendas; this.dataGridView1.Visible = true; }
        private void buttonViewFornecedores_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; this.dataGridView1.Visible = true; }
        private void buttonViewCompras_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = compras; this.dataGridView1.Visible = true; }




        private void buttonAdicionarClient_Click(object sender, EventArgs e)
        {
            FormCriarCliente fcc = new FormCriarCliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(x => x.Id) + 1;

                cliente.nome = fcc.Name;
                cliente.endereco = fcc.Endereco;
                cliente.email = fcc.EmailCliente;
                cliente.fone = fcc.TelefoneCliente;

                clientes.Add(cliente);
            }
        }

        private void buttonRemoverClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarFornecedores_Click(object sender, EventArgs e)
        {
            FormCriarFornecedor fcc = new FormCriarFornecedor();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(x => x.Id) + 1;

                fornecedor.nome = fcc.nomeFornecedor;
                fornecedor.endereco = fcc.Endereco;
                fornecedor.email = fcc.EmailFornecedor;
                fornecedor.fone = fcc.TelefoneFornecedor;

                fornecedores.Add(fornecedor);
            }
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Voc� Precisa Cadastrar Fornecedores antes de efetuar uma compra."); return;
            }

            if (produtos.Count == 0)
            {
                MessageBox.Show("Voc� Precisa Cadastrar Produtos antes de efetuar uma compra."); return;
            }

            FormCriarCompra fcc = new FormCriarCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog(); 
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.Id = 1; else compra.Id = compras.Max(x => x.Id) + 1;

                compra.IdProduto = fcc.IdProduto;
                compra.IdFornecedor = fcc.IdFornecedor;
                compra.Quantidade = (int)fcc.Quantidade;
                compra.Desconto = (float)fcc.Desconto; 
                compra.DataCompra = DateTime.Now;

                compras.Add(compra);
            }

        }
    }
}
