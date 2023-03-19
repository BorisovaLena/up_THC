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
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        public PageClient(TableClient client)
        {
            InitializeComponent();
            tbNumberClient.Text = client.ClientID;
            tbFIO.Text = client.ClientSurname + " " + client.ClientName + " " + client.ClientPatronymic;
            tbSeria.Text = "Серия: " + client.TablePassport.PassportSeries;
            tbNuber.Text = "Номер: " + client.TablePassport.PassportNumber;
            tbDate.Text = "Дата выдачи: " + client.TablePassport.PassportDateIssued;
            tbVidan.Text = "Кем выдан: " + client.TablePassport.PassportIssued;
            tbNumberTreaty.Text = "Номер договора: " + client.TableTreaty.TreatyNumber;
            tbDateTreaty.Text = "Дата заключения: " + client.TableTreaty.TreatyDateСonclusion;
            tbTypeTreaty.Text = "Тип договора: " + client.TableTreaty.TreatyType;
            tbDateTTreaty.Text = "Дата расторжения: " + client.TableTreaty.TreatyTerminationDate;
            tbDateTPTreaty.Text = "Причина расторжения: " + client.TableTreaty.TreatyReasonForTermination;
            tbPersonalAccount.Text = "Лицевой счет: " + client.TableTreaty.TreatyPersonalAccount;
            if(client.TableAddress1.TableStreet.StreetName != null)
            {
                if(client.TableAddress1.AddressHouse!=null)
                {
                    if (client.TableAddress1.AddressApartament!=null)
                    {
                        tbAddress.Text = client.TableAddress1.TableDistrict.DistrictName + ", " + client.TableAddress1.TableStreet.StreetName + ", " + client.TableAddress1.AddressHouse + ", " + client.TableAddress1.AddressApartament;
                    }
                    else
                    {
                        tbAddress.Text = client.TableAddress1.TableDistrict.DistrictName + ", " + client.TableAddress1.TableStreet.StreetName + ", " + client.TableAddress1.AddressHouse;
                    }     
                }
                else
                {
                    tbAddress.Text = client.TableAddress1.TableDistrict.DistrictName + ", " + client.TableAddress1.TableStreet.StreetName;
                }
            }
            else
            {
                tbAddress.Text = client.TableAddress1.TableDistrict.DistrictName;
            }
            
        }
    }
}
