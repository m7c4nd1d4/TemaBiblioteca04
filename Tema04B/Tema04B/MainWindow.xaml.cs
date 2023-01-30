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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema04B
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

        private void Button_Genero_Click(object sender, RoutedEventArgs e)
        {
            Janela_Genero x = new Janela_Genero();
            x.ShowDialog();
        }

        private void Button_Livro_Click(object sender, RoutedEventArgs e)
        {
            Janela_Livro y = new Janela_Livro();
            y.ShowDialog();
        }

        private void Button_Exemplar_Click(object sender, RoutedEventArgs e)
        {
            Janela_Exemplar z = new Janela_Exemplar();
            z.ShowDialog();
        }
    }
}
