using ListaDeEsperaPacientes.Data;
using ListaDeEsperaPacientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeEsperaPacientes
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        //========================================================================================================

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            using (var _context = new AppDbContext())
            {
                var clientes = _context.Paciente.OrderBy(x => x.DataCadastro).ToList();

                grdCadastro.DataSource = clientes;

                grdCadastro.Columns["Id"].Visible = false;

                grdCadastro.Columns["Nome"].HeaderText = "Paciente";
                grdCadastro.Columns["Email"].HeaderText = "E-mail";
                grdCadastro.Columns["Telefone"].HeaderText = "Telefone";
                grdCadastro.Columns["DataCadastro"].HeaderText = "Criado Em";
                grdCadastro.Columns["Observacao"].HeaderText = "OBS";
            }
        }

        //========================================================================================================

        private void CadastrartoolStripButton1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Paciente paciente = new Paciente();

                paciente.Nome = txtNome.Text;
                paciente.Email = txtEmail.Text;
                paciente.Telefone = txtTelefone.Text;
                paciente.DataCadastro = Convert.ToDateTime(dtCadastro.Value);
                paciente.Finalizado = ckFinalizado.Checked;
                paciente.Observacao = txtObs.Text.Trim();

                try
                {
                    CadastrarSalvar(paciente);
                    LimparCampos();
                    CarregarGrid();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CadastrarSalvar(Paciente paciente)
        {
            using (var _context = new AppDbContext())
            {
                _context.Paciente.Add(paciente);
                _context.SaveChanges();
            }
        }

        //========================================================================================================

        private void AlterartoolStripButton1_Click(object sender, EventArgs e)
        {
            Paciente pacienteAlterar = new Paciente();

            pacienteAlterar.Id = Convert.ToInt32(txtId.Text);
            pacienteAlterar.Nome = txtNome.Text;
            pacienteAlterar.Email = txtEmail.Text;
            pacienteAlterar.Telefone = txtTelefone.Text;
            pacienteAlterar.DataCadastro = Convert.ToDateTime(dtCadastro.Value);
            pacienteAlterar.Finalizado = ckFinalizado.Checked;
            pacienteAlterar.Observacao = txtObs.Text.Trim();

            try
            {
                Alterar(pacienteAlterar);
                LimparCampos();
                CarregarGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("CLIENTE NAO ALTERADO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar(Paciente paciente)
        {
            using (var _context = new AppDbContext())
            {
                _context.Paciente.AddOrUpdate(paciente);
                _context.SaveChanges();
            }
        }

        //========================================================================================================

        private void ExcluirtoolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("SELECIONE UM PACIENTE CLICANDO NO NOME DA TABELA");
            }
            else
            {
                try
                {
                    Paciente pacienteClicado = grdCadastro.CurrentRow.DataBoundItem as Paciente;
                    Excluir(pacienteClicado);

                }
                catch (Exception)
                {
                    MessageBox.Show("SELECIONE UM CLIENTE PARA DELETAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimparCampos();
            CarregarGrid();
        }

        private static void Excluir(Paciente pacienteClicado)
        {
            using (var _context = new AppDbContext())
            {
                Paciente excluir = _context.Paciente.FirstOrDefault(x => x.Id == pacienteClicado.Id);
                if (excluir != null)
                {
                    _context.Paciente.Remove(excluir);
                    _context.SaveChanges();
                }
            }
        }

        //========================================================================================================

        private void LimpartoolStripButton3_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //========================================================================================================

        private void SairtoolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //========================================================================================================

        private void grdCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CapturarLinhaClicadaNaGridView();
        }
                
        private void CapturarLinhaClicadaNaGridView()
        {
            if (grdCadastro.Rows.Count > 0)
            {
                Paciente paciente = grdCadastro.CurrentRow.DataBoundItem as Paciente;

                txtId.Text = paciente.Id.ToString();
                txtNome.Text = paciente.Nome.Trim();
                txtEmail.Text = paciente.Email.Trim().ToLower();
                txtTelefone.Text = paciente.Telefone;
                dtCadastro.Value = paciente.DataCadastro;
                txtObs.Text = paciente.Observacao;
                ckFinalizado.Checked = paciente.Finalizado;
            }
        }

        //========================================================================================================

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            ckFinalizado.Checked = false;
            dtCadastro.Value = DateTime.Now;
            txtObs.Clear();
            txtId.Clear();
        }

        //========================================================================================================


        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome Completo \n";
            }
            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- Email \n ";
            }
            if (txtTelefone.Text == "")
            {
                ret = false;
                campos += "- Telefone \n ";
            }


            if (!ret)
            {
                MessageBox.Show("Complete os campos solicitados \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
    }
}
