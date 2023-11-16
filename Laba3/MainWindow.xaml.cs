using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Laba3
{
    public partial class MainWindow : Window
    {
        private ShowHelper showHelper;
        public MainWindow()
        {
            InitializeComponent();
            showHelper = new ShowHelper();
            Table.ItemsSource = showHelper.PopulationCollection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try{
                string type = comboBox.Text;
                string name = Text0.Text;
                int countHouses = int.Parse(Text1.Text);
                if(countHouses < 1)
                    throw new Exception("Введіть коректну кількість будинків!");
                int countPeople = int.Parse(Text2.Text);
                if (countPeople < 1)
                    throw new Exception("Введіть коректну кількість людей!");
                double area = double.Parse(Text3.Text);
                if (area < 3)
                    throw new Exception("Введіть коректне значення площі!");
                Locality local;
                if (type == "Місто")
                {
                    local = new City(name, countHouses, countPeople, area);
                }
                else if (type == "Село")
                {
                    local = new Village(name, countHouses, countPeople, area);
                }
                else
                {
                    throw new Exception("Тип поселення не обрано!");
                }

                double density = local.PopulationDensity();

                showHelper.AddPopulation(local, density);

                // Найменше значення щільності населення:
                double min = showHelper.FindMinimumDensity();
                Min.Content=$"Min щн: {min}";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
    }
}