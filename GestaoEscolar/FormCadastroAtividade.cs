using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class FormCadastroAtividade : Form
    {
        private Turma turma = new Turma();
        public int fechar = 0;
        public FormCadastroAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }


        private void FormCadastroAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                Hide();
                lblTurma.Text = turma.Nome;
                lblUsuarioLogado.Text = Constantes.UsuarioLogado;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {
            fechar = 1;
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txtAtividade.Text))
                {
                    MessageBox.Show("Insira uma atividade");
                    txtAtividade.Focus();
                    return;
                }
                Atividade atividade = new Atividade();
                atividade.Nome = txtAtividade.Text;


                new AtividadeBLL().Cadastrar(atividade, turma.Id);

                MessageBox.Show("Atividade castrada com sucesso!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
     
    }
}
