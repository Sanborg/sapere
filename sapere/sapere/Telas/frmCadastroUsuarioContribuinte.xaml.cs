using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace sapere.View
{
    /// <summary>
    /// Lógica interna para frmCadastroUsuarioContribuinte.xaml
    /// </summary>
    public partial class frmCadastroUsuarioContribuinte : Window
    {
        public Usuario usuario { get; }
        public Evento evento { get; }
        public bool respondeuEvento { get; }
        public frmCadastroUsuarioContribuinte()
        {
            InitializeComponent();
        }
        public frmCadastroUsuarioContribuinte(Usuario usuario, Evento evento, bool respondeuEvento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;
            this.respondeuEvento = respondeuEvento;
        }
        private bool VerificaCampos()
        {
            if (boxIdade.Text != "" && boxCpf.Text != "" && boxTelefone.Text != "" && boxCursoDeGraduacao.Text != "" && boxInstituicaoEnsinoSuperior.Text != "")
            {
                return true;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                "Preencha todos os campos",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
                return false;
            }
        }
        private void TornarContribuinte()
        {
            if(VerificaCampos() == true)
            {
                bool tornouContribuinte = cUsuario.TornarContribuinte(usuario.id, boxCpf.Text, int.Parse(boxIdade.Text), boxTelefone.Text, boxCursoDeGraduacao.Text, boxInstituicaoEnsinoSuperior.Text);
                if (tornouContribuinte == true)
                {
                    frmMenu frmMenu = new frmMenu(usuario, evento, respondeuEvento);
                    frmMenu.Show();
                    Close();
                }
            }
        }
        private void PressionarBtnTornarContribuidor(object sender, MouseButtonEventArgs e)
        {
            TornarContribuinte();
        }
        private void PressionarBtnVoltar(object sender, MouseButtonEventArgs e)
        {
            frmOpcaoDeCadastro frmOpcaoDeCadastro = new frmOpcaoDeCadastro(usuario, evento, respondeuEvento);
            frmOpcaoDeCadastro.Show();
            Close();
        }
    }
}
