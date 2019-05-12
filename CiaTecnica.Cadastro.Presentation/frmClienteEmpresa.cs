using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiaTecnica.Cadastro.Model;
using CiaTecnica.Cadastro.Service;

namespace CiaTecnica.Cadastro.Presentation
{
    public partial class frmClienteEmpresa : Form
    {
        PessoaFisicaService _pessoaFisicaService;
        PessoaJuridicaService _pessoaJuridicaService;
        const string TITULOMESSAGE = "Cadastro Cliente";

        public int IdPessoa { get; set; }
        public string EstadoAcao { get; set; }

        enum TipoPessoa
        {
            Fisica,
            Juridica

        };



        public frmClienteEmpresa()
        {
            InitializeComponent();
        }

        private void frmClienteEmpresa_Load(object sender, EventArgs e)
        {
            _pessoaFisicaService = new PessoaFisicaService();
            _pessoaJuridicaService = new PessoaJuridicaService();

            EstadoInicialUI();
            ConfigurarMaskEdits();

            PopularListaUF();

            CarregarPessoasFisicas();
            CarregarPessoasJuridicas();

        }


        private void EstadoInicialUI()
        {
            tcPessoa.TabPages.Remove(tabJuridica);
            tcListaPessoas.TabPages.Remove(tabPessoasJuridicas);
            btnExcluir.Enabled = false;
            EstadoAcao = "INCLUIR";

        }

        private void SelecionarTabPessoa(TipoPessoa pessoa)
        {
            if (pessoa == TipoPessoa.Fisica)
            {
                this.tcPessoa.TabPages.Remove(tabJuridica);
                tcListaPessoas.TabPages.Remove(tabPessoasJuridicas);

                this.tcPessoa.TabPages.Add(tabFisica);
                tcListaPessoas.TabPages.Add(tabPessoasFisicas);

            }
            else
            {

                this.tcPessoa.TabPages.Remove(tabFisica);
                tcListaPessoas.TabPages.Remove(tabPessoasFisicas);

                this.tcPessoa.TabPages.Add(tabJuridica);
                tcListaPessoas.TabPages.Add(tabPessoasJuridicas);


            }

            LimparDadosUI();
            btnExcluir.Enabled = false;

        }


        private void LimparDadosUI()
        {
            mskCEP.Text = string.Empty;
            mskCNPJ.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskDataNascimento.Text = string.Empty;

            cboUF.Text = string.Empty;

            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;


        }


        private void ConfigurarMaskEdits()
        {
            this.mskCNPJ.Mask = "00.000.000/0000-00";
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCEP.Mask = "00000-000";
            this.mskDataNascimento.Mask = "00/00/0000";
        }

        private void PopularListaUF()
        {
            cboUF.DataSource = Utils.ListasEstaticas.ListarUF();

        }



        private void CarregarPessoasFisicas()
        {
            try
            {
                List<PessoaFisica> pessoas = _pessoaFisicaService.ListarPessoas();

  
                grvPessoasFisicas.DataSource = pessoas;

                grvPessoasFisicas.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void CarregarPessoasJuridicas()
        {
            try
            {
                grvPessoasJuridicas.DataSource = _pessoaJuridicaService.ListarPessoas();

               // grvPessoasJuridicas.Columns[3].Width = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbPessoaFisica_Click(object sender, EventArgs e)
        {
           
        }

        private void rbPessoaJuridica_Click(object sender, EventArgs e)
        {
           
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPessoaFisica.Checked == false)
            {
                SelecionarTabPessoa(TipoPessoa.Juridica);
            }
            else
            {
                SelecionarTabPessoa(TipoPessoa.Fisica);
            }

            EstadoAcao = "INCLUIR";
            
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDadosUI();
            //rbPessoaFisica.Checked = true;
            //rbPessoaJuridica.Checked = false;
            //tcPessoa.TabPages.Remove(tabFisica);
            //tcListaPessoas.TabPages.Remove(tabPessoasFisicas);
            //SelecionarTabPessoa(TipoPessoa.Fisica);
            btnExcluir.Enabled = false;
            EstadoAcao = "INCLUIR";

            if(rbPessoaFisica.Checked)
            {
                txtNome.Focus();
            }
            else
            {
                txtNomeFantasia.Focus();

            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private bool ValidarDados()
        {
            bool ret = true;
            string msg = "Os seguintes campos estão incorretos :" + Environment.NewLine;

            if (rbPessoaFisica.Checked)
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    ret = false;
                    msg += "Informar o nome." + Environment.NewLine;
                }

                if (string.IsNullOrEmpty(txtSobrenome.Text))
                {
                    ret = false;
                    msg += "Informar o sobrenome." + Environment.NewLine;
                }

                if (mskDataNascimento.Text == "  /  /")
                {
                    ret = false;
                    msg += "Informar a data de nascimento." + Environment.NewLine;

                }

                if(mskDataNascimento.Text != "  /  /")
                {
                    try
                    {
                        DateTime dataInformada = Convert.ToDateTime(mskDataNascimento.Text);

                        var idade = Utils.Calculo.CalcularIdade(mskDataNascimento.Text);

                        if (idade < 19)
                        {
                            ret = false;
                            msg += "Informar uma idade de 19 anos ou mais." + Environment.NewLine;

                        }

                    }
                    catch (Exception ex)
                    {
                        ret = false;
                        msg += "Informar uma data válida." + Environment.NewLine;

                    }



                }



                if(mskCPF.Text == "   ,   ,   -")
                {
                    ret = false;
                    msg += "Informar o CPF." + Environment.NewLine;
                }


            }
            else
            {


                if (string.IsNullOrEmpty(txtNomeFantasia.Text))
                {
                    ret = false;
                    msg += "Informar o nome fantasia." + Environment.NewLine;
                }

                if (string.IsNullOrEmpty(txtRazaoSocial.Text))
                {
                    ret = false;
                    msg += "Informar a razão social." + Environment.NewLine;
                }


                if(mskCNPJ.Text == "  ,   ,   /    -")
                {
                    ret = false;
                    msg += "Informar o CNPJ." + Environment.NewLine;

                }

            }

            if(string.IsNullOrEmpty(txtLogradouro.Text))
            {
                ret = false;
                msg += "Informar o logradouro." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                ret = false;
                msg += "Informar o número." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                ret = false;
                msg += "Informar o bairro." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                ret = false;
                msg += "Informar a cidade." + Environment.NewLine;
            }


            if(mskCEP.Text == "     -")
            {
                ret = false;
                msg += "Informar o CEP." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(cboUF.Text))
            {
                ret = false;
                msg += "Informar a UF." + Environment.NewLine;
            }


            if (!ret) MessageBox.Show(msg, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return ret;


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDados()) return;


                if (EstadoAcao == "INCLUIR")
                {
                    IncluirPessoa();


                }
                else
                {

                    AlterarPessoa(IdPessoa);

                }

                btnNovo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AlterarPessoa(int idPessoa)
        {
            if (rbPessoaFisica.Checked == true)
            {
                var pessoaFisica = new PessoaFisica()
                {
                    Id = idPessoa,
                    Nome = txtNome.Text.Trim(),
                    Sobrenome = txtSobrenome.Text.Trim(),
                    DataNascimento = Convert.ToDateTime(mskDataNascimento.Text),
                    CPF = mskCPF.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    CEP = mskCEP.Text,
                    UF = cboUF.Text

                };

                var pessoaFisicaBanco = _pessoaFisicaService.BuscarPessoa(idPessoa);


                pessoaFisicaBanco.Nome = pessoaFisica.Nome;
                pessoaFisicaBanco.Sobrenome = pessoaFisica.Sobrenome;
                pessoaFisicaBanco.DataNascimento = pessoaFisica.DataNascimento;
                pessoaFisicaBanco.CPF = pessoaFisica.CPF;
                pessoaFisicaBanco.Bairro = pessoaFisica.Bairro;
                pessoaFisicaBanco.Numero = pessoaFisica.Numero;
                pessoaFisicaBanco.Complemento = pessoaFisica.Complemento;
                pessoaFisicaBanco.Logradouro = pessoaFisica.Logradouro;
                pessoaFisicaBanco.Cidade = pessoaFisica.Cidade;
                pessoaFisicaBanco.CEP = pessoaFisica.CEP;
                pessoaFisicaBanco.UF = pessoaFisica.UF;

                _pessoaFisicaService.Atualizar(pessoaFisicaBanco);
                CarregarPessoasFisicas();

            }
            else
            {
                var pessoaJuridica = new PessoaJuridica()
                {
                    Id = idPessoa,
                    NomeFantasia = txtNomeFantasia.Text.Trim(),
                    RazaoSocial = txtRazaoSocial.Text.Trim(),
                    CNPJ = mskCNPJ.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    CEP = mskCEP.Text,
                    UF = cboUF.Text

                };

                var pessoaJuridicaBanco = _pessoaJuridicaService.BuscarPessoa(idPessoa);


                pessoaJuridicaBanco.NomeFantasia = pessoaJuridica.NomeFantasia;
                pessoaJuridicaBanco.RazaoSocial = pessoaJuridica.RazaoSocial;
                pessoaJuridicaBanco.CNPJ = pessoaJuridica.CNPJ;
                pessoaJuridicaBanco.Bairro = pessoaJuridica.Bairro;
                pessoaJuridicaBanco.Numero = pessoaJuridica.Numero;
                pessoaJuridicaBanco.Complemento = pessoaJuridica.Complemento;
                pessoaJuridicaBanco.Logradouro = pessoaJuridica.Logradouro;
                pessoaJuridicaBanco.Cidade = pessoaJuridica.Cidade;
                pessoaJuridicaBanco.CEP = pessoaJuridica.CEP;
                pessoaJuridicaBanco.UF = pessoaJuridica.UF;


                _pessoaJuridicaService.Atualizar(pessoaJuridicaBanco);
                CarregarPessoasJuridicas();


            }


        }

        private void IncluirPessoa()
        {
            if (rbPessoaFisica.Checked == true)
            {
                var pessoaFisica = new PessoaFisica()
                {
                    Nome = txtNome.Text.Trim(),
                    Sobrenome = txtSobrenome.Text.Trim(),
                    DataNascimento = Convert.ToDateTime(mskDataNascimento.Text),
                    CPF = mskCPF.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    CEP = mskCEP.Text,
                    UF = cboUF.Text

                };

                _pessoaFisicaService.Inserir(pessoaFisica);
                CarregarPessoasFisicas();

            }
            else
            {
                var pessoaJuridica = new PessoaJuridica()
                {
                    NomeFantasia = txtNomeFantasia.Text.Trim(),
                    RazaoSocial = txtRazaoSocial.Text.Trim(),
                    CNPJ = mskCNPJ.Text.Trim(),
                    Bairro = txtBairro.Text.Trim(),
                    Numero = txtNumero.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Logradouro = txtLogradouro.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    CEP = mskCEP.Text,
                    UF = cboUF.Text

                };

                _pessoaJuridicaService.Inserir(pessoaJuridica);
                CarregarPessoasJuridicas();


            }

        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Excluir o cliente selecionado ?";

                if (MessageBox.Show(msg, TITULOMESSAGE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(rbPessoaFisica.Checked == true)
                    {
                        _pessoaFisicaService.Excluir(IdPessoa);
                        CarregarPessoasFisicas();
                    }
                    else
                    {

                        _pessoaJuridicaService.Excluir(IdPessoa);
                        CarregarPessoasJuridicas();
                    }

                    btnNovo_Click(sender, e);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void grvPessoasFisicas_MouseClick(object sender, MouseEventArgs e)
        {
            if (grvPessoasFisicas.Rows.Count == 0) return;

            try
            {
                DataGridViewRow linhaAtual = grvPessoasFisicas.CurrentRow;

                if (linhaAtual != null)
                {
                    int indice = linhaAtual.Index;

                    IdPessoa = Convert.ToInt32(grvPessoasFisicas.Rows[indice].Cells[4].Value);

                    EstadoAcao = "ALTERAR";

                    var pessoaFisica = _pessoaFisicaService.BuscarPessoa(IdPessoa);

                    txtNome.Text = pessoaFisica.Nome;
                    txtSobrenome.Text = pessoaFisica.Sobrenome;
                    mskCPF.Text = pessoaFisica.CPF;
                    mskDataNascimento.Text = Convert.ToString(pessoaFisica.DataNascimento);

                    txtLogradouro.Text = pessoaFisica.Logradouro;
                    txtNumero.Text = pessoaFisica.Numero;
                    txtComplemento.Text = pessoaFisica.Complemento;
                    txtLogradouro.Text = pessoaFisica.Logradouro;
                    txtBairro.Text = pessoaFisica.Bairro;
                    txtCidade.Text = pessoaFisica.Cidade;
                    mskCEP.Text = pessoaFisica.CEP;
                    cboUF.Text = pessoaFisica.UF;

                    btnExcluir.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grvPessoasJuridicas_MouseClick(object sender, MouseEventArgs e)
        {
            if (grvPessoasJuridicas.Rows.Count == 0) return;

            try
            {
                DataGridViewRow linhaAtual = grvPessoasJuridicas.CurrentRow;

                if (linhaAtual != null)
                {
                    int indice = linhaAtual.Index;

                    IdPessoa = Convert.ToInt32(grvPessoasJuridicas.Rows[indice].Cells[3].Value);

                    EstadoAcao = "ALTERAR";

                    var pessoaJuridica = _pessoaJuridicaService.BuscarPessoa(IdPessoa);

                    txtNomeFantasia.Text = pessoaJuridica.NomeFantasia;
                    txtRazaoSocial.Text = pessoaJuridica.RazaoSocial;
                    mskCNPJ.Text = pessoaJuridica.CNPJ;


                    txtLogradouro.Text = pessoaJuridica.Logradouro;
                    txtNumero.Text = pessoaJuridica.Numero;
                    txtComplemento.Text = pessoaJuridica.Complemento;
                    txtLogradouro.Text = pessoaJuridica.Logradouro;
                    txtBairro.Text = pessoaJuridica.Bairro;
                    txtCidade.Text = pessoaJuridica.Cidade;
                    mskCEP.Text = pessoaJuridica.CEP;
                    cboUF.Text = pessoaJuridica.UF;

                    btnExcluir.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TITULOMESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvPessoasFisicas_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           // grvPessoasFisicas_MouseClick(sender, null);
        }

        private void grvPessoasJuridicas_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           // grvPessoasJuridicas_MouseClick(sender, null);
        }
    }
}
