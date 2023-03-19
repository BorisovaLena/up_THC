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

namespace THC.pages
{
    /// <summary>
    /// Логика взаимодействия для PageSubscribers.xaml
    /// </summary>
    public partial class PageSubscribers : Page
    {
        public PageSubscribers()
        {
            InitializeComponent();

            List<TableDistrict> districts = clasess.ClassBase.Base.TableDistrict.ToList(); //заполнение comboBox с районами
            cmbSearchDistrict.Items.Add("нет");
            foreach(TableDistrict district in districts)
            {
                cmbSearchDistrict.Items.Add(district.DistrictName);
            }
            cmbSearchDistrict.SelectedIndex = 0;

            List<TableAddress> addresses = clasess.ClassBase.Base.TableAddress.ToList(); //заполнение comboBox с улицами
            cmbSearchStreet.Items.Add("нет");
            foreach (TableAddress addres in addresses)
            {
                if(addres.AddressHouse!=null)
                {
                    cmbSearchStreet.Items.Add(addres.TableStreet.StreetName + ", " + addres.AddressHouse);
                }
                else
                {
                    cmbSearchStreet.Items.Add(addres.TableStreet.StreetName);
                }
                
            }
            cmbSearchStreet.SelectedIndex = 0;
        }

        private void cmbSearchDistrict_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
