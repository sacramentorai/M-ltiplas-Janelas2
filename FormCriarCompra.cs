using System.ComponentModel;
using System.Globalization;

namespace MultiplasJanelas
{
    public partial class FormCriarCompra : Form
    {
        private BindingList<Fornecedor> Forcedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxFornecedor.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }



        public FormCriarCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";
            comboBoxFornecedor.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxProduto.DataSource = Produto;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.SelectedIndex = 0;
        }

        public BindingList<Fornecedor> Fornecedores { get; }
        public BindingList<Produto> produtos { get; }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
        private void AtualizarValores()
        {
            if (Produtos != null)
            {
                textBoxPrecoUnitario.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCriarCompra_Load(object sender, EventArgs e)
        {

        }
    }

}
