using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Alunos
{
    public partial class frmCadastro : Form
    {
        int matricula = 0;
        string turno;
    
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matricula += 1;
            txtMatricula.Text = matricula.ToString();
            dtNasc.MaxDate = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //GENÊRO
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnMasc.Checked = rdBtnMasc.Checked;
            gpBoxSexo.Text = "Masculino";
        }

        
        //SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string curso = txtCurso.Text;
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = mtBoxNumCelular.Text;
            string rg = mtBoxRG.Text;
            string cpf = mtBoxCpf.Text;
            string data = dtNasc.Text;      
            string email = txtEmail.Text;
            DateTime dtAtual = DateTime.Now;

           
                if (!mtBoxCpf.MaskCompleted || !mtBoxRG.MaskCompleted || !mtBoxNumCelular.MaskCompleted || gpBoxSexo.Text == "" || gpBoxTurno.Text == "") 
                {
                    string msg = "Dados Incompletos!";
                    string titulo = "AVISO";
                    var result = MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                         if (!email.Contains('@') || !email.Contains('.'))
                         {
                             string msg1 = "Email Inexistente!";
                             string titulo1 = "AVISO";
                             var result1 = MessageBox.Show(msg1, titulo1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                         else
                         {
                            DateTime dtnascimento = DateTime.Parse(data);
                            int codTurma = int.Parse(mtBoxCodTurma.Text);

                            dtGridView01.Rows.Add(txtMatricula.Text, mtBoxCodTurma.Text, txtCurso.Text, gpBoxTurno.Text, txtNome.Text, txtSobrenome.Text, mtBoxNumCelular.Text, mtBoxRG.Text, mtBoxCpf.Text, (dtnascimento.Day + "/" + dtnascimento.Month + "/" + dtnascimento.Year), txtEmail.Text, gpBoxSexo.Text);
                            matricula += 1;
                            txtMatricula.Text = matricula.ToString();

                            string msg = "O aluno " + txtNome.Text + " " + txtSobrenome.Text + " foi registrado com sucesso!";
                            string titulo = "Sucesso!";
                            var result = MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         }
   
                }
            
              
        }
      
        //TURNO
        private void rdBtnVespertino_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnVespertino.Checked = rdBtnVespertino.Checked;
            gpBoxTurno.Text = "Vespertino";
        }

        private void rdBtnNoturno_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnNoturno.Checked = rdBtnNoturno.Checked;
            gpBoxTurno.Text = "Noturno";
        }

        //LIMPAR
        private void btnLimapar_Click(object sender, EventArgs e)
        {
            mtBoxCodTurma.Text = "";
            txtCurso.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            mtBoxNumCelular.Text = "";
            mtBoxRG.Text = "";
            mtBoxCpf.Text = "";
            txtEmail.Text = "";
            rdBtnFem.Checked = false;
            rdBtnMasc.Checked = false;
            rdBtnMatutino.Checked = false;
            rdBtnVespertino.Checked = false;
            rdBtnNoturno.Checked = false;
            gpBoxTurno.Text = "";
            gpBoxSexo.Text = "";

        }

        //SAIR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //IRRELEVANTE
        }

        //EDITAR
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }
       
        //GENÊRO
        private void rdBtnFem_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnFem.Checked = rdBtnFem.Checked;
            gpBoxSexo.Text = "Feminino";
        }

       //TURNO
        private void rdBtnMatutino_CheckedChanged_1(object sender, EventArgs e)
        {
            rdBtnMatutino.Checked = rdBtnMatutino.Checked;
            gpBoxTurno.Text = "Matutino";
        }

        private void dtNasc_ValueChanged(object sender, EventArgs e)
        {
            dtNasc.Text = dtNasc.Value.ToString();
        }

        
    }
}
