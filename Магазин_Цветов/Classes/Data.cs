using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин_Цветов
{
    public partial class Product
    {
        public string getURL
        {
            get
            {
                if (ProductPhotoURL == null)
                    return "/Resources/picture.png";
                return $"/Resources/{ProductPhotoURL}";
            }
        }
    }
}
