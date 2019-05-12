namespace CiaTecnica.Cadastro.Presentation
{
    partial class frmClienteEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteEmpresa));
            this.grpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.tcPessoa = new System.Windows.Forms.TabControl();
            this.tabFisica = new System.Windows.Forms.TabPage();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabJuridica = new System.Windows.Forms.TabPage();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tcListaPessoas = new System.Windows.Forms.TabControl();
            this.tabPessoasFisicas = new System.Windows.Forms.TabPage();
            this.grvPessoasFisicas = new System.Windows.Forms.DataGridView();
            this.tabPessoasJuridicas = new System.Windows.Forms.TabPage();
            this.grvPessoasJuridicas = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpTipoPessoa.SuspendLayout();
            this.tcPessoa.SuspendLayout();
            this.tabFisica.SuspendLayout();
            this.tabJuridica.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.tcListaPessoas.SuspendLayout();
            this.tabPessoasFisicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoasFisicas)).BeginInit();
            this.tabPessoasJuridicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoasJuridicas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTipoPessoa
            // 
            this.grpTipoPessoa.Controls.Add(this.rbPessoaJuridica);
            this.grpTipoPessoa.Controls.Add(this.rbPessoaFisica);
            this.grpTipoPessoa.Location = new System.Drawing.Point(12, 12);
            this.grpTipoPessoa.Name = "grpTipoPessoa";
            this.grpTipoPessoa.Size = new System.Drawing.Size(246, 37);
            this.grpTipoPessoa.TabIndex = 0;
            this.grpTipoPessoa.TabStop = false;
            this.grpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(114, 12);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            this.rbPessoaJuridica.Click += new System.EventHandler(this.rbPessoaJuridica_Click);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Checked = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(36, 12);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(54, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            this.rbPessoaFisica.Click += new System.EventHandler(this.rbPessoaFisica_Click);
            // 
            // tcPessoa
            // 
            this.tcPessoa.Controls.Add(this.tabFisica);
            this.tcPessoa.Controls.Add(this.tabJuridica);
            this.tcPessoa.Location = new System.Drawing.Point(12, 55);
            this.tcPessoa.Name = "tcPessoa";
            this.tcPessoa.SelectedIndex = 0;
            this.tcPessoa.Size = new System.Drawing.Size(776, 92);
            this.tcPessoa.TabIndex = 7;
            // 
            // tabFisica
            // 
            this.tabFisica.Controls.Add(this.mskCPF);
            this.tabFisica.Controls.Add(this.mskDataNascimento);
            this.tabFisica.Controls.Add(this.txtSobrenome);
            this.tabFisica.Controls.Add(this.txtNome);
            this.tabFisica.Controls.Add(this.lblCPF);
            this.tabFisica.Controls.Add(this.lblDataNascimento);
            this.tabFisica.Controls.Add(this.lblSobrenome);
            this.tabFisica.Controls.Add(this.lblNome);
            this.tabFisica.Location = new System.Drawing.Point(4, 22);
            this.tabFisica.Name = "tabFisica";
            this.tabFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisica.Size = new System.Drawing.Size(768, 66);
            this.tabFisica.TabIndex = 0;
            this.tabFisica.Text = "Física";
            this.tabFisica.UseVisualStyleBackColor = true;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(413, 36);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(140, 20);
            this.mskCPF.TabIndex = 7;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(110, 36);
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(80, 20);
            this.mskDataNascimento.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(413, 10);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(192, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(324, 40);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(6, 40);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(324, 14);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tabJuridica
            // 
            this.tabJuridica.Controls.Add(this.mskCNPJ);
            this.tabJuridica.Controls.Add(this.txtRazaoSocial);
            this.tabJuridica.Controls.Add(this.txtNomeFantasia);
            this.tabJuridica.Controls.Add(this.lblCNPJ);
            this.tabJuridica.Controls.Add(this.lblRazaoSocial);
            this.tabJuridica.Controls.Add(this.lblNomeFantasia);
            this.tabJuridica.Location = new System.Drawing.Point(4, 22);
            this.tabJuridica.Name = "tabJuridica";
            this.tabJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridica.Size = new System.Drawing.Size(768, 66);
            this.tabJuridica.TabIndex = 1;
            this.tabJuridica.Text = "Jurídica";
            this.tabJuridica.UseVisualStyleBackColor = true;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(116, 39);
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(186, 20);
            this.mskCNPJ.TabIndex = 5;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(437, 12);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(186, 20);
            this.txtRazaoSocial.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(116, 12);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(186, 20);
            this.txtNomeFantasia.TabIndex = 3;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 43);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(345, 16);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 1;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(6, 16);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 0;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.mskCEP);
            this.grpEndereco.Controls.Add(this.cboUF);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.txtLogradouro);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.lblUF);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.lblComplemento);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.lblLogradouro);
            this.grpEndereco.Location = new System.Drawing.Point(16, 153);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(776, 83);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(617, 47);
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(118, 20);
            this.mskCEP.TabIndex = 13;
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(440, 48);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(64, 21);
            this.cboUF.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(270, 48);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(137, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(76, 48);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(142, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(617, 21);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(142, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(398, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(67, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(76, 21);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(266, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(528, 52);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(413, 52);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(224, 52);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 52);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(528, 25);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(348, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 25);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(619, 242);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "  Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(717, 242);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tcListaPessoas
            // 
            this.tcListaPessoas.Controls.Add(this.tabPessoasFisicas);
            this.tcListaPessoas.Controls.Add(this.tabPessoasJuridicas);
            this.tcListaPessoas.Location = new System.Drawing.Point(16, 271);
            this.tcListaPessoas.Name = "tcListaPessoas";
            this.tcListaPessoas.SelectedIndex = 0;
            this.tcListaPessoas.Size = new System.Drawing.Size(776, 146);
            this.tcListaPessoas.TabIndex = 16;
            // 
            // tabPessoasFisicas
            // 
            this.tabPessoasFisicas.Controls.Add(this.grvPessoasFisicas);
            this.tabPessoasFisicas.Location = new System.Drawing.Point(4, 22);
            this.tabPessoasFisicas.Name = "tabPessoasFisicas";
            this.tabPessoasFisicas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoasFisicas.Size = new System.Drawing.Size(768, 120);
            this.tabPessoasFisicas.TabIndex = 0;
            this.tabPessoasFisicas.Text = "Pessoas Físicas";
            this.tabPessoasFisicas.UseVisualStyleBackColor = true;
            // 
            // grvPessoasFisicas
            // 
            this.grvPessoasFisicas.AllowUserToAddRows = false;
            this.grvPessoasFisicas.AllowUserToDeleteRows = false;
            this.grvPessoasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPessoasFisicas.Location = new System.Drawing.Point(5, 16);
            this.grvPessoasFisicas.Name = "grvPessoasFisicas";
            this.grvPessoasFisicas.ReadOnly = true;
            this.grvPessoasFisicas.Size = new System.Drawing.Size(757, 98);
            this.grvPessoasFisicas.TabIndex = 0;
            this.grvPessoasFisicas.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoasFisicas_RowLeave);
            this.grvPessoasFisicas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvPessoasFisicas_MouseClick);
            // 
            // tabPessoasJuridicas
            // 
            this.tabPessoasJuridicas.Controls.Add(this.grvPessoasJuridicas);
            this.tabPessoasJuridicas.Location = new System.Drawing.Point(4, 22);
            this.tabPessoasJuridicas.Name = "tabPessoasJuridicas";
            this.tabPessoasJuridicas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoasJuridicas.Size = new System.Drawing.Size(768, 120);
            this.tabPessoasJuridicas.TabIndex = 1;
            this.tabPessoasJuridicas.Text = "Pessoas Jurídicas";
            this.tabPessoasJuridicas.UseVisualStyleBackColor = true;
            // 
            // grvPessoasJuridicas
            // 
            this.grvPessoasJuridicas.AllowUserToAddRows = false;
            this.grvPessoasJuridicas.AllowUserToDeleteRows = false;
            this.grvPessoasJuridicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPessoasJuridicas.Location = new System.Drawing.Point(6, 11);
            this.grvPessoasJuridicas.Name = "grvPessoasJuridicas";
            this.grvPessoasJuridicas.ReadOnly = true;
            this.grvPessoasJuridicas.Size = new System.Drawing.Size(757, 98);
            this.grvPessoasJuridicas.TabIndex = 1;
            this.grvPessoasJuridicas.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoasJuridicas_RowLeave);
            this.grvPessoasJuridicas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvPessoasJuridicas_MouseClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(20, 424);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "  Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(717, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmClienteEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tcListaPessoas);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.tcPessoa);
            this.Controls.Add(this.grpTipoPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmClienteEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmClienteEmpresa_Load);
            this.grpTipoPessoa.ResumeLayout(false);
            this.grpTipoPessoa.PerformLayout();
            this.tcPessoa.ResumeLayout(false);
            this.tabFisica.ResumeLayout(false);
            this.tabFisica.PerformLayout();
            this.tabJuridica.ResumeLayout(false);
            this.tabJuridica.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.tcListaPessoas.ResumeLayout(false);
            this.tabPessoasFisicas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoasFisicas)).EndInit();
            this.tabPessoasJuridicas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoasJuridicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoPessoa;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.TabControl tcPessoa;
        private System.Windows.Forms.TabPage tabFisica;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabJuridica;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tcListaPessoas;
        private System.Windows.Forms.TabPage tabPessoasFisicas;
        private System.Windows.Forms.DataGridView grvPessoasFisicas;
        private System.Windows.Forms.TabPage tabPessoasJuridicas;
        private System.Windows.Forms.DataGridView grvPessoasJuridicas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
    }
}