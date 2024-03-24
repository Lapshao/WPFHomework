using Homework.Helper;
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

namespace Homework
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        private List<Product> originalData; // Хранение исходных данных перед фильтрацией

        public Admin()
        {
            InitializeComponent();
            originalData = ClassDB.entity.Product.ToList(); // Загружаем данные из бд и делаем список
            lstvDB.ItemsSource = originalData; // Привязка данных к listview
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Фильтрация данных на основе вписанного текста
            var filteredData = originalData.Where(p =>
                p.NameProduct.ToLower().Contains(searchBox.Text.ToLower()) ||
                p.PriceProduct.ToString().Contains(searchBox.Text.ToLower()) ||
                p.TypeProduct.NameTypeProduct.ToLower().Contains(searchBox.Text.ToLower())
            ).ToList();
            // .ToLower проверка на нижний регистр
            // .ToString преобразование в строку и проверка соответствия
            // .ToList преобразует результат запроса Where в список
            lstvDB.ItemsSource = filteredData;
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement your custom filtering logic based on additional criteria here
            // (e.g., prompt user for filter options in a dialog)
            MessageBox.Show("Filter button clicked! Implement your custom filtering logic here.");
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to open a new window or dialog for adding a new element
            MessageBox.Show("Add button clicked! Implement logic to add a new element here.");
        }
    }
}
