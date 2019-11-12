using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4yClass.Class
{

    [Serializable]
    public class Ac4yPropertyList
    {

        public List<Ac4yProperty> Property { get; set; }

        public Ac4yPropertyList() {

            Property = new List<Ac4yProperty>();

        }

    }

}
