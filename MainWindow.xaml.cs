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

namespace OOD_PracticeExam2020
{
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Phones
                        select c;

            LBX_PhoneList.ItemsSource = query.ToList();

        }

        private void LBX_PhoneList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = LBX_PhoneList.SelectedItem as Phone;
            

            if (selectedPhone != null)
            {
                TXT_PhonePrice.Text = selectedPhone.Price.ToString();
                IMG_PhoneImage.Source = new BitmapImage(new Uri(selectedPhone.PhoneImage, UriKind.Relative));
            }

                        
            
            
        }
    }
}
