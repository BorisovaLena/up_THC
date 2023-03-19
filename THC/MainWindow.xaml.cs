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

namespace THC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            clasess.ClassBase.Base = new Entities();
            clasess.ClassFrame.mainFrame = frmMain;
            cmbUsers.Items.Add("Выберите пользователя");
            List<TableUser> users = clasess.ClassBase.Base.TableUser.ToList();
            foreach(TableUser user in users)
            {
                cmbUsers.Items.Add(user.UserSurname+ " "+user.UserName+" "+user.UserPatronymic);
            }
            cmbUsers.SelectedIndex = 0;
            spAbon.Visibility = Visibility.Collapsed;
            spActive.Visibility = Visibility.Collapsed;
            spBill.Visibility = Visibility.Collapsed;
            spCRM.Visibility = Visibility.Collapsed;
            spPP.Visibility = Visibility.Collapsed;
            spUO.Visibility = Visibility.Collapsed;
        }

        private void cmbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spAbon.Visibility = Visibility.Collapsed;
            spActive.Visibility = Visibility.Collapsed;
            spBill.Visibility = Visibility.Collapsed;
            spCRM.Visibility = Visibility.Collapsed;
            spPP.Visibility = Visibility.Collapsed;
            spUO.Visibility = Visibility.Collapsed;
            if(cmbUsers.SelectedIndex != 0)
            {
                TableUser user = clasess.ClassBase.Base.TableUser.FirstOrDefault(x => x.UserID == cmbUsers.SelectedIndex);
                clasess.ClassFrame.mainFrame.Navigate(new pages.PageSubscribers());
                spAbon.Background = (Brush)new BrushConverter().ConvertFrom("#B5DEFA");
                List<TableInformation> events = clasess.ClassBase.Base.TableInformation.Where(z => z.InformationRole == user.UserRole).ToList();
                lvEvents.ItemsSource = events;
                switch (user.UserRole)
                {
                    case 1:
                        spBill.Visibility = Visibility.Visible;
                        spCRM.Visibility = Visibility.Visible;
                        spAbon.Visibility = Visibility.Visible;   
                        break;
                    case 2:
                        spCRM.Visibility = Visibility.Visible;
                        spAbon.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        spCRM.Visibility = Visibility.Visible;
                        spAbon.Visibility = Visibility.Visible;
                        spPP.Visibility = Visibility.Visible;
                        spUO.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        spCRM.Visibility = Visibility.Visible;
                        spAbon.Visibility = Visibility.Visible;
                        spPP.Visibility = Visibility.Visible;
                        spUO.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        spAbon.Visibility = Visibility.Visible;
                        spBill.Visibility = Visibility.Visible;
                        spActive.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        spAbon.Visibility = Visibility.Visible;
                        spActive.Visibility = Visibility.Visible;
                        spBill.Visibility = Visibility.Visible;
                        spCRM.Visibility = Visibility.Visible;
                        spPP.Visibility = Visibility.Visible;
                        spUO.Visibility = Visibility.Visible;
                        break;
                    case 7:
                        spAbon.Visibility = Visibility.Visible;
                        spActive.Visibility = Visibility.Visible;
                        spCRM.Visibility = Visibility.Visible;
                        spUO.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }

                imUser.ImageSource = new BitmapImage(new Uri("../../pictures/" + user.UserPhoto, UriKind.Relative));
            }            
        }

        private void spAbon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            spAbon.Background = (Brush)new BrushConverter().ConvertFrom("#B5DEFA");
            clasess.ClassFrame.mainFrame.Navigate(new pages.PageSubscribers());
        }
    }
}
