using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THC
{
    public partial class TableClient
    {
        public string FIO
        {
            get
            {
                return ClientSurname + " " + ClientName + " " + ClientPatronymic;
            } 
        }
        public string ClientServises
        {
            get
            {
                List<TableServiceTreaty> tableServiceTreaties = clasess.ClassBase.Base.TableServiceTreaty.Where(z => z.ServiceTreatyTreatyID == TableTreaty.TreatyNumber).ToList();
                string str = "";
                foreach(TableServiceTreaty treaty in tableServiceTreaties)
                {
                    str += treaty.TableService.ServiceName + ", ";
                }
                str = str.Substring(0, str.Length - 2);
                return str;
            }
        }
    }
}
