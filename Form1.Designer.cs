namespace Cadastro_de_Alunos
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpBoxTurno = new System.Windows.Forms.GroupBox();
            this.rdBtnMatutino = new System.Windows.Forms.RadioButton();
            this.rdBtnVespertino = new System.Windows.Forms.RadioButton();
            this.rdBtnNoturno = new System.Windows.Forms.RadioButton();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtBoxNumCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.mtBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.gpBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdBtnFem = new System.Windows.Forms.RadioButton();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtGridView01 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtBoxCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gpBoxTurno.SuspendLayout();
            this.gpBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView01)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código da turma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sobrenome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "RG:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "CPF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data de Nascimento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "E-mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Número de Celular:";
            // 
            // gpBoxTurno
            // 
            this.gpBoxTurno.Controls.Add(this.rdBtnMatutino);
            this.gpBoxTurno.Controls.Add(this.rdBtnVespertino);
            this.gpBoxTurno.Controls.Add(this.rdBtnNoturno);
            this.gpBoxTurno.Location = new System.Drawing.Point(440, 50);
            this.gpBoxTurno.Name = "gpBoxTurno";
            this.gpBoxTurno.Size = new System.Drawing.Size(87, 100);
            this.gpBoxTurno.TabIndex = 16;
            this.gpBoxTurno.TabStop = false;
            // 
            // rdBtnMatutino
            // 
            this.rdBtnMatutino.AutoSize = true;
            this.rdBtnMatutino.Location = new System.Drawing.Point(8, 24);
            this.rdBtnMatutino.Name = "rdBtnMatutino";
            this.rdBtnMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdBtnMatutino.TabIndex = 37;
            this.rdBtnMatutino.TabStop = true;
            this.rdBtnMatutino.Text = "Matutino";
            this.rdBtnMatutino.UseVisualStyleBackColor = true;
            this.rdBtnMatutino.CheckedChanged += new System.EventHandler(this.rdBtnMatutino_CheckedChanged_1);
            // 
            // rdBtnVespertino
            // 
            this.rdBtnVespertino.AutoSize = true;
            this.rdBtnVespertino.Location = new System.Drawing.Point(8, 47);
            this.rdBtnVespertino.Name = "rdBtnVespertino";
            this.rdBtnVespertino.Size = new System.Drawing.Size(75, 17);
            this.rdBtnVespertino.TabIndex = 38;
            this.rdBtnVespertino.TabStop = true;
            this.rdBtnVespertino.Text = "Vespertino";
            this.rdBtnVespertino.UseVisualStyleBackColor = true;
            this.rdBtnVespertino.CheckedChanged += new System.EventHandler(this.rdBtnVespertino_CheckedChanged);
            // 
            // rdBtnNoturno
            // 
            this.rdBtnNoturno.AutoSize = true;
            this.rdBtnNoturno.Location = new System.Drawing.Point(8, 70);
            this.rdBtnNoturno.Name = "rdBtnNoturno";
            this.rdBtnNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdBtnNoturno.TabIndex = 39;
            this.rdBtnNoturno.TabStop = true;
            this.rdBtnNoturno.Text = "Noturno";
            this.rdBtnNoturno.UseVisualStyleBackColor = true;
            this.rdBtnNoturno.CheckedChanged += new System.EventHandler(this.rdBtnNoturno_CheckedChanged);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(12, 38);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(124, 20);
            this.txtMatricula.TabIndex = 17;
            this.txtMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(12, 91);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(303, 20);
            this.txtCurso.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 20;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(224, 142);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(187, 20);
            this.txtSobrenome.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // mtBoxNumCelular
            // 
            this.mtBoxNumCelular.Location = new System.Drawing.Point(12, 198);
            this.mtBoxNumCelular.Mask = "(00) 00000-0000";
            this.mtBoxNumCelular.Name = "mtBoxNumCelular";
            this.mtBoxNumCelular.Size = new System.Drawing.Size(100, 20);
            this.mtBoxNumCelular.TabIndex = 22;
            // 
            // mtBoxRG
            // 
            this.mtBoxRG.Location = new System.Drawing.Point(148, 198);
            this.mtBoxRG.Mask = "000000000";
            this.mtBoxRG.Name = "mtBoxRG";
            this.mtBoxRG.Size = new System.Drawing.Size(85, 20);
            this.mtBoxRG.TabIndex = 23;
            // 
            // mtBoxCpf
            // 
            this.mtBoxCpf.Location = new System.Drawing.Point(268, 198);
            this.mtBoxCpf.Mask = "000.000.000-00";
            this.mtBoxCpf.Name = "mtBoxCpf";
            this.mtBoxCpf.Size = new System.Drawing.Size(132, 20);
            this.mtBoxCpf.TabIndex = 24;
            // 
            // gpBoxSexo
            // 
            this.gpBoxSexo.Controls.Add(this.rdBtnFem);
            this.gpBoxSexo.Controls.Add(this.rdBtnMasc);
            this.gpBoxSexo.Location = new System.Drawing.Point(560, 50);
            this.gpBoxSexo.Name = "gpBoxSexo";
            this.gpBoxSexo.Size = new System.Drawing.Size(88, 66);
            this.gpBoxSexo.TabIndex = 32;
            this.gpBoxSexo.TabStop = false;
            // 
            // rdBtnFem
            // 
            this.rdBtnFem.AutoSize = true;
            this.rdBtnFem.Location = new System.Drawing.Point(8, 43);
            this.rdBtnFem.Name = "rdBtnFem";
            this.rdBtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFem.TabIndex = 50;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            this.rdBtnFem.CheckedChanged += new System.EventHandler(this.rdBtnFem_CheckedChanged);
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(8, 19);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 40;
            this.rdBtnMasc.TabStop = true;
            this.rdBtnMasc.Text = "Masculino";
            this.rdBtnMasc.UseVisualStyleBackColor = true;
            this.rdBtnMasc.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1130, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 31);
            this.btnFechar.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnFechar, "Fechar o programa");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(12, 353);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(189, 41);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "SALVAR";
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar cadastro");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(1084, 353);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 41);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "EXCLUIR";
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir cadastro");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(389, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 41);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "LIMPAR";
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpar campos prenchidos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimapar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(568, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 41);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "EDITAR";
            this.toolTip1.SetToolTip(this.btnEditar, "Editar cadastro");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtGridView01
            // 
            this.dtGridView01.AllowUserToAddRows = false;
            this.dtGridView01.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtGridView01.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridView01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12});
            this.dtGridView01.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGridView01.Location = new System.Drawing.Point(0, 409);
            this.dtGridView01.Name = "dtGridView01";
            this.dtGridView01.ReadOnly = true;
            this.dtGridView01.Size = new System.Drawing.Size(1234, 176);
            this.dtGridView01.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matrícula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cod. da Turma";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Curso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Turno";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nome";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sobrenome";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Num. Celular";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "RG";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "CPF";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Data Nasc.";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "E-mail";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Sexo";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // mtBoxCodTurma
            // 
            this.mtBoxCodTurma.Location = new System.Drawing.Point(166, 38);
            this.mtBoxCodTurma.Mask = "0000";
            this.mtBoxCodTurma.Name = "mtBoxCodTurma";
            this.mtBoxCodTurma.Size = new System.Drawing.Size(35, 20);
            this.mtBoxCodTurma.TabIndex = 18;
            this.mtBoxCodTurma.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sexo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Turno:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(423, 198);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(91, 20);
            this.dtNasc.TabIndex = 41;
            this.dtNasc.Value = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            this.dtNasc.ValueChanged += new System.EventHandler(this.dtNasc_ValueChanged);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1234, 585);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.mtBoxCodTurma);
            this.Controls.Add(this.dtGridView01);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpBoxSexo);
            this.Controls.Add(this.mtBoxCpf);
            this.Controls.Add(this.mtBoxRG);
            this.Controls.Add(this.mtBoxNumCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.gpBoxTurno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBoxTurno.ResumeLayout(false);
            this.gpBoxTurno.PerformLayout();
            this.gpBoxSexo.ResumeLayout(false);
            this.gpBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpBoxTurno;
        private System.Windows.Forms.RadioButton rdBtnVespertino;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtBoxNumCelular;
        private System.Windows.Forms.MaskedTextBox mtBoxRG;
        private System.Windows.Forms.MaskedTextBox mtBoxCpf;
        private System.Windows.Forms.GroupBox gpBoxSexo;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.RadioButton rdBtnNoturno;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dtGridView01;
        private System.Windows.Forms.MaskedTextBox mtBoxCodTurma;
        private System.Windows.Forms.RadioButton rdBtnMatutino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

