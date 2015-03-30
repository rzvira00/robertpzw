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

namespace robertpzw
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


        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Lbutton.Click += new RoutedEventHandler(Lbutton_Click);
            this.Rbutton.Click += new RoutedEventHandler(Rbutton_Click);

        }

        void Lbutton_Click(object sender, RoutedEventArgs e)
        {

            var rectangle = new Rectangle()
            {
                Width = 60,
                Height = 60,
                Fill = Brushes.Brown,
                Margin = new Thickness(5),
            };
            this.RecContainer.Children.Add(rectangle);

        }

        void Rbutton_Click(object sender, RoutedEventArgs e)
        {

            var rectangle = new Rectangle()
            {
                Width = 300,
                Height = 30,
                Fill = Brushes.Red,
                Margin = new Thickness(5),
            };
            this.RightContainer.Children.Add(rectangle);

        }

    }
}
