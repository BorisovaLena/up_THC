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
using System.Windows.Shapes;

namespace THC.windows
{
    /// <summary>
    /// Логика взаимодействия для WindowNewApplication.xaml
    /// </summary>
    public partial class WindowNewApplication : Window
    {
        public WindowNewApplication( TableClient client)
        {
            InitializeComponent();
            tbNumberAppl.Text = client.TableTreaty.TreatyPersonalAccount + "/" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            dpDate.SelectedDate = DateTime.Now;
            tbNumberClient.Text = client.ClientID;
            tbNumberLC.Text = client.TableTreaty.TreatyPersonalAccount.ToString();
            cmbServices.Items.Add("Выберите услугу");
            List<TableServiceTreaty> tableServiceTreaties = clasess.ClassBase.Base.TableServiceTreaty.Where(z => z.ServiceTreatyTreatyID == client.TableTreaty.TreatyNumber).ToList();
            foreach (TableServiceTreaty treaty in tableServiceTreaties)
            {
                cmbServices.Items.Add(treaty.TableService.ServiceName);
            }
            cmbServices.SelectedIndex = 0;

            cmbServicesVid.Items.Add("Выберите вид услуги");
            List<TableServiceVid> tableServiceVids = clasess.ClassBase.Base.TableServiceVid.ToList();
            foreach(TableServiceVid vid in tableServiceVids)
            {
                cmbServicesVid.Items.Add(vid.ServiceVidName);
            }
            cmbServicesVid.SelectedIndex = 0;

            List<TableServiceStatus> tableServiceStatuses = clasess.ClassBase.Base.TableServiceStatus.ToList();
            foreach(TableServiceStatus status in tableServiceStatuses)
            {
                cmbStatus.Items.Add(status.ServiceStatusName);
            }
            cmbStatus.SelectedIndex = 0;

            tbTypeEq.Text = client.TableEquipment.EquipmentName;

            cmbTypeProblem.Items.Add("Выберите тип проблемы");
            List<TableProblemType> tableProblemTypes = clasess.ClassBase.Base.TableProblemType.ToList();
            foreach(TableProblemType type in tableProblemTypes)
            {
                cmbTypeProblem.Items.Add(type.ProblemTypeName);
            }
            cmbTypeProblem.SelectedIndex = 0;
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            TableApplication application = new TableApplication()
            {
                ApplicationNumber = tbNumberAppl.Text,
                ApplicationDate = (DateTime)dpDate.SelectedDate,
                ApplicationPersonalAccount = Convert.ToInt32(tbNumberLC.Text),
                ApplicationService = cmbServices.SelectedIndex,
                ApplicationServiceType = cmbServicesType.SelectedIndex,
                ApplicationVid = cmbServicesVid.SelectedIndex,
                ApplicationServiceStatus = cmbStatus.SelectedIndex + 1,
                ApplicationTypeEquipment = tbTypeEq.Text,
                ApplicationProblem = tbProblemDiscr.Text,
                ApplicationDateClosing = dpDateClosing.SelectedDate,
                ApplicationTypeProblem = cmbTypeProblem.SelectedIndex
            };
        }

        private void cmbServicesVid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbServicesType.Items.Clear();
            if(cmbServicesVid.SelectedIndex==0)
            {
                cmbServicesType.Items.Add("Сначала выберите тип услуги");
                cmbServicesType.SelectedIndex = 0;
            }
            else
            {
                cmbServicesType.Items.Add("Выберите тип услуги");
                List<TableServiceType> tableServiceTypes = clasess.ClassBase.Base.TableServiceType.Where(z => z.ServiceTypeVidID == cmbServicesVid.SelectedIndex).ToList();
                foreach (TableServiceType type in tableServiceTypes)
                {
                    cmbServicesType.Items.Add(type.ServiceTypeName);
                }
                cmbServicesType.SelectedIndex = 0;
            }
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int r = random.Next(2);
            if(r==0)
            {
                MessageBox.Show("Оборудование исправно!!!");
                cmbStatus.SelectedItem = "Закрыта";
                dpDateClosing.SelectedDate = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Оборудование исправно!!!");
                cmbStatus.SelectedItem = "Требует выезда";
            }
        }
    }
}
