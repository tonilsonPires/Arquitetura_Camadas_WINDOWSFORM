using MODEL;
using DAL;
using BLL;

namespace UIL
{
    public partial class Form1 : Form
    {
        ModelUser model = new ModelUser();
        private int codigo;

        public Form1()
        {
            InitializeComponent();
        }

        public void preencherGrid()
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosdeConexao.StringConexao);
                BLLUser bll = new BLLUser(conexao);
                dataUser.DataSource = bll.listar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void limparFormularios() 
        { 
            textNome.Text = "";
            textIdade.Text = "";
            cbSexo.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosdeConexao.StringConexao);
                BLLUser bll = new BLLUser(conexao);
                model.Nome = textNome.Text;
                model.Idade = textIdade.Text;
                model.Sexo = cbSexo.SelectedItem.ToString();
                bool result = bll.adicionar(model);

                if (result == false)
                {
                    MessageBox.Show("Houve erro na inserção dos dados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Dados inseridod com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGrid();
                    limparFormularios();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencherGrid();
            cbSexo.SelectedIndex = 0;
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numeroLinha = e.RowIndex;

            if (numeroLinha >= 0)
            {
                this.codigo = Convert.ToInt16(dataUser.Rows[numeroLinha].Cells[0].Value);
                textNome.Text = dataUser.Rows[numeroLinha].Cells[1].Value.ToString();
                textIdade.Text = dataUser.Rows[numeroLinha].Cells[2].Value.ToString();
                cbSexo.SelectedItem = dataUser.Rows[numeroLinha].Cells[3].Value.ToString();
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.codigo <= 0)
            {
                MessageBox.Show("Selecione para poder actualizar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DALConexao conexao = new DALConexao(DadosdeConexao.StringConexao);
                    BLLUser bll = new BLLUser(conexao);
                    model.Nome = textNome.Text;
                    model.Idade = textIdade.Text;
                    model.Sexo = cbSexo.SelectedItem.ToString();
                    model.Id = this.codigo;
                    bool result = bll.actualizar(model);

                    if (result == false)
                    {
                        MessageBox.Show("Houve erro na actualização dos dados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Dados actualizados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        preencherGrid();
                        limparFormularios();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.codigo <= 0)
            {
                MessageBox.Show("Selecione para poder Eliminar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DALConexao conexao = new DALConexao(DadosdeConexao.StringConexao);
                    BLLUser bll = new BLLUser(conexao);
                   
                    var confirmacao = MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (confirmacao == DialogResult.Yes)
                    {
                        bll.delete(this.codigo);
                        MessageBox.Show("Eliminado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        preencherGrid();
                        limparFormularios();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Houve erro ao eliminar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    preencherGrid();

                }
            }
        }
    }
}
