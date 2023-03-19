using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace THC
{
    public partial class TableUser
    {
        public BitmapImage Img
        {
            get
            {
                if(UserPhoto!=null)
                {
                    return new BitmapImage(new Uri("../../pictures/" + UserPhoto, UriKind.Relative));
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
