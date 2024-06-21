using Microsoft.EntityFrameworkCore;

namespace Senac.T14.WF.Exercicio
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        private void CriarBancoDeDados()
        {
            using (var banco = new AppDbContext()) 
            {
                banco.Database.Migrate();
            }
        }

        private void btnChamadas_Click(object sender, EventArgs e)
        {
            new FrmChamadas().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
