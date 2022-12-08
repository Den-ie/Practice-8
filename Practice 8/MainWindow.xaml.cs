using System;
using System.CodeDom;
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

namespace Practice_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        Father _father1 = new("", "", 0);
        Father _father2 = new("", "", 0);

        private void Create(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Age.Text, out int age) && !int.TryParse(Name.Text, out int x) && !int.TryParse(LastName.Text, out int y))
                _father1 = new Father(Name.Text, LastName.Text, age);
            else MessageBox.Show("Неверные данные");

            Dad1.Text = _father1.ToString();

            Work1.Text = _father1.Working(_father1);
            Earn1.Text = _father1.Earning(_father1);
        }

        private void Create2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Age.Text, out int age) && !int.TryParse(Name.Text, out int x) && !int.TryParse(LastName.Text, out int y))
                _father2 = new Father(Name.Text, LastName.Text, age);
            else MessageBox.Show("Неверные данные");

            Dad2.Text = _father2.ToString();

            Work2.Text = _father2.Working(_father2);
            Earn2.Text = _father2.Earning(_father2);
        }


        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейсы - работник и отец-семейства. Создать класс работника-отца семейства. Класс должен включать конструктор, функцию для формирования строки информации о работнике. Сравнение производить по фамилии.\r\n");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Comparing(object sender, RoutedEventArgs e)
        {
            if (_father1.CompareTo(_father2) < 0)
                MessageBox.Show("Первый ?больше?");
            else if (_father1.CompareTo(_father2) > 0)
                MessageBox.Show("Второй ?больше?");
            else
                MessageBox.Show("Отцы равны");
        }
    }
}
