using MagicTheGathering_DAL;
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

namespace ProjectDataManipulatie
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbRarity.ItemsSource = DatabaseOperations.OphalenRarity();
            cmbType.ItemsSource = DatabaseOperations.OphalenType();
            cmbColor.ItemsSource = DatabaseOperations.OphalenColor();
            cmbExpansion.ItemsSource = DatabaseOperations.OphalenExpansion();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dataMTG.ItemsSource = DatabaseOperations.OphalenKaart();
                
            }
            else
            {
                dataMTG.ItemsSource = DatabaseOperations.OphalenKaartViaZoeken(txtSearch.Text);
            }

            
            




        }

            
         
    }
    
}

