using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void altaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Opacity = 1;
        }

        private void mediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Stretch=Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            episodioVIImage.Stretch = Stretch.None;
        }
    }
}
