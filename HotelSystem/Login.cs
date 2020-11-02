﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point((this.Width / 2) - 166, (this.Height / 2) - 170);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
            txtUsuario.ForeColor = Color.FromArgb(36, 113, 163);
            txtSenha.ForeColor = Color.FromArgb(255, 195, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text.Length <= 0) && (txtSenha.Text.Length <= 0))
            {
                MessageBox.Show("Informe o Usuário e a Senha");
                txtUsuario.Focus();
                return;
            }

            else if(txtUsuario.Text.Length <= 0)
            {
                MessageBox.Show("Informe o Usuário");
                txtUsuario.Focus();
                return;
            }

            else
            {
                MessageBox.Show("Informe a Senha");
                txtUsuario.Focus();
                return;
            }

            //Escrever aqui o código para Login
        }
    }
}
