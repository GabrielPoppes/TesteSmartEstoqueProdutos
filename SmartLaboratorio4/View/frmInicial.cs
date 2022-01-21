using SmartLaboratorio4.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLaboratorio4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            EsconderSubMenus();
        }

        #region Método para esconder os sub menus do botão Produto
        private void EsconderSubMenus()
        {
            pnlSubBotoes.Visible = false;
        }
        #endregion

        #region Exibir os sub menus do botão Produto
        private void ExibirSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false) // Se o sub menu estiver fechado - abre
            {
                EsconderSubMenus();
                subMenu.Visible = true;
            }

            else // Se o sub menu estiver aberto - fecha
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Método para abrir uma nova form
        private Form activeForm = null;
        private void AbrirForm(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            pnlDefault.Controls.Add(newForm);
            pnlDefault.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }
        #endregion

        #region Evento click no botão Produto - vai abrir o submenu
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ExibirSubMenu(pnlSubBotoes);
        }
        #endregion

        #region Evento click no botão Cadastrar Produto
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadastrarProduto());
        }
        #endregion
    }
}
