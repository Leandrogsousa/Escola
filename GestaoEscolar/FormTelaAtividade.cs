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
    public partial class FormTelaAtividade : Form
    {
    
        private Turma turma = new Turma();
        public FormTelaAtividade(Turma _turma)
        {
            InitializeComponent();
            turma = _turma;
        }
         

        private void FormTelaAtividade_Load(object sender, EventArgs e)
        {

                try
            {
                this.Hide();
                lblTurma.Text = turma.Nome;
                lblUsuario.Text = Constantes.UsuarioLogado;

                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroAtividade frm = new FormCadastroAtividade(turma))
                {
                    frm.ShowDialog();
                    if (frm.fechar == 1)
                    {
                        Close();
                    }
                }
                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(turma.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}


