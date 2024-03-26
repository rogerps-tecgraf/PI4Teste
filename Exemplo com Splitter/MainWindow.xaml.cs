using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exemplo_com_Splitter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastrarProdutoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Executando Cadastrar Produto", "Em Execução", MessageBoxButton.OKCancel);
        }

        private void AlterarProdutoClick(object sender, RoutedEventArgs e)
        {
            //AlterarProdutoWindow janela = new AlterarProdutoWindow();
            //janela.ShowDialog();

            AlterarProdutoWindow janela = new AlterarProdutoWindow() { Owner = this };
            janela.Show();
        }

        private void RemoverProdutoClick(object sender, RoutedEventArgs e)
        {
            // Comentario inutil
            RemoverProdutoControl controle = new RemoverProdutoControl();
            PainelDireito.Children.Add(controle);
        }
    }
}