using System.Data.Common;
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
using System.Xml.Linq;
using Lib_14;
using System;

namespace практическая_5
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
        /// <summary>
        /// метод для выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// метод для информирования о задании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Liquid (жидкость), имеющий поля названия, плотности и объема. Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров жидкости.", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        /// <summary>
        /// метод для информирования о разработчике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Андрианов Алексей Вариант 14.", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        /// <summary>
        /// метод для очистки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbDensityInput.Text = "";
            tbDensityOutput.Clear();
            tbNameInput.Clear();
            tbNameOutput.Clear();
            tbVolumeInput.Clear();
            tbVolumeOutput.Clear();
        }
        Liquid liquid = new Liquid();
        bool flagFillFull = false;
        /// <summary>
        /// метод для первоначальной записи характеристик жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbDensityInput.Text, out int density) && density > 0 && int.TryParse(tbVolumeInput.Text, out int volume) && volume > 0 && tbNameInput.Text != "")
            {
                string name = tbNameInput.Text;
                liquid.SetParams(name, density, volume);
                flagFillFull = true;
                MessageBox.Show("Значения присвоенны", "Выполнено", MessageBoxButton.OK);
            }
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// метод для изменения параметров жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbDensityInput.Text, out int density1) && density1 > 0 && int.TryParse(tbVolumeInput.Text, out int volume1) && volume1 > 0 && tbNameInput.Text != "" && flagFillFull == true)
            {
                MessageBox.Show("Если хотите изменить все три параметра, то используйте кнопку записать", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbNameInput.Text == "" && int.TryParse(tbDensityInput.Text, out int density2) && density2 > 0 && int.TryParse(tbVolumeInput.Text, out int volume2) && volume2 > 0 && flagFillFull == true)
            {
                liquid.SetParams(density2, volume2);

                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else if (tbNameInput.Text == "" && string.IsNullOrWhiteSpace(tbDensityInput.Text) && int.TryParse(tbVolumeInput.Text, out int volume3) && volume3 > 0 && flagFillFull == true)
            {
                liquid.SetParams(volume3);

                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else if (tbNameInput.Text != "" && string.IsNullOrWhiteSpace(tbDensityInput.Text) && string.IsNullOrWhiteSpace(tbVolumeInput.Text) && flagFillFull == true)
            {
                string name1 = tbNameInput.Text;
                liquid.SetParams(name1);
                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else if (tbNameInput.Text != "" && int.TryParse(tbDensityInput.Text, out int density4) && density4 > 0 && string.IsNullOrWhiteSpace(tbVolumeInput.Text) && flagFillFull == true)
            {
                string name2 = tbNameInput.Text;
                liquid.SetParams(name2, density4);
                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else if (tbNameInput.Text == "" && double.TryParse(tbDensityInput.Text, out double density5) && density5 > 0 && string.IsNullOrWhiteSpace(tbVolumeInput.Text) && flagFillFull == true)
            {
                liquid.SetParams(density5);
                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else if (tbNameInput.Text != "" && string.IsNullOrWhiteSpace(tbDensityInput.Text) && double.TryParse(tbVolumeInput.Text, out double volume5) && volume5 > 0 && flagFillFull == true)
            {
                string name3 = tbNameInput.Text;
                liquid.SetParams(name3, volume5);
                MessageBox.Show("Значения изменены", "Выполнено", MessageBoxButton.OK);
            }
            else MessageBox.Show("Введите правильное значение или запишите значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// метод для вывода параметров жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowLiquid_Click(object sender, RoutedEventArgs e)
        {
            if (flagFillFull == true)
            {
                tbVolumeOutput.Text = Convert.ToString(liquid.Volume);
                tbDensityOutput.Text = Convert.ToString(liquid.Density);
                tbNameOutput.Text = liquid.Name;
            }
            else MessageBox.Show("Введите характеристики", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
