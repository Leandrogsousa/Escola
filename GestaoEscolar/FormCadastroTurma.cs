﻿using BLL;
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
    public partial class FormCadastroTurma : Form
    {
        public FormCadastroTurma()
        {
            InitializeComponent();
        }

        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(lblUsuarioLogado.Text))
                {
                    MessageBox.Show("Insira o nome da turma");
                    return;
                }

                Turma turma = new Turma();

                turma.Nome = txtTurma.Text;

                new TurmaBLL().Cadastrar(turma);
                MessageBox.Show("Turma cadastrada com sucesso!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroTurma_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
