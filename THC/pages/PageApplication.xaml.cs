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
    /// Логика взаимодействия для PageApplication.xaml
    /// </summary>
    public partial class PageApplication : Page
    {
        public PageApplication()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            TableClient client = clasess.ClassBase.Base.TableClient.FirstOrDefault(z => z.ClientNumberPhone == tbNumberPhone.Text);
            if(client==null)
            {
                MessageBox.Show("Нет пользователя с таким номером телефона!!!");
            }
            else
            {
                if(client.ClientSurname.ToLower() != tbSurname.Text.ToLower())
                {
                    MessageBox.Show("Пользователь не найден!!!");
                }
                else
                {
                    MessageBox.Show("успех!!!");
                    btnAddApplication.Visibility = Visibility;
                }
            }
        }

        private void btnAddApplication_Click(object sender, RoutedEventArgs e)
        {
            windows.WindowNewApplication window = new windows.WindowNewApplication();
            window.ShowDialog();
        }
    }
}
