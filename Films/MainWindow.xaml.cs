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

namespace Films
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Список для хранения всех сущностей цен
        /// </summary>
        private List<Films> prices = new List<Films>();


        /// <summary>
        /// Конструктор окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //Задание стартовых параметров окна
            Combo.SelectedIndex = 0;

        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                prices.Add(new Films(double.Parse(textBox.Text), double.Parse(textBox2.Text), double.Parse(textBox1.Text)));

            }
            catch (FormatException exception)
            {
                MessageBox.Show("Перепроверьте правильность введённых данных", "Error!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            RefreshListBox(); //обновление ЛистБокса
        }

        private void RefreshListBox()
        {
            throw new NotImplementedException();
        }
    }
}
