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

            dgSubscribers.ItemsSource = clasess.ClassBase.Base.TableClient.ToList();
        }

        private void cmbSearchDistrict_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void tbSearchSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            List<TableClient> listFilter = clasess.ClassBase.Base.TableClient.ToList();

            if(!string.IsNullOrWhiteSpace(tbSearchSurname.Text))
            {
                listFilter = listFilter.Where(z => z.ClientSurname.ToLower().Contains(tbSearchSurname.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(tbSearchLCh.Text))
            {
                listFilter = listFilter.Where(z => z.TableTreaty.TreatyPersonalAccount.ToString().ToLower().Contains(tbSearchLCh.Text.ToLower())).ToList();
            }

            if(cmbSearchDistrict.SelectedIndex>0)
            {
                listFilter = listFilter.Where(z => z.TableAddress1.TableDistrict.DistrictName == (string)cmbSearchDistrict.SelectedValue).ToList();
            }

            if(cmbSearchStreet.SelectedIndex>0)
            {
                listFilter = listFilter.Where(z => z.TableAddress.TableStreet.StreetName + ", " + z.TableAddress.AddressHouse == cmbSearchStreet.SelectedValue.ToString()).ToList();
            }

            dgSubscribers.ItemsSource = listFilter;
        }
    }
}
