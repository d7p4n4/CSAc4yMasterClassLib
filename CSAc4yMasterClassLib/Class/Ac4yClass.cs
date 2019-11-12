using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4yClass.Class
{
    [Serializable]
    public class Ac4yClass
    {

        public Ac4yClass()
        {
            PropertyList = new List<Ac4yProperty>();
        }

        public Ac4yClass(String aName) : this()
        {
            Name = aName;
        }

        public Ac4yClass(String aName, String aAncestor) : this(aName)
        {
            Ancestor = aAncestor;
        }

        public Ac4yClass(String aName, String aAncestor, List<Ac4yProperty> aPropertyList) : this(aName, aAncestor)
        {
            PropertyList = aPropertyList;
        }

        public String Name { get; set;  }
        public String Ancestor { get; set; }
        public List<Ac4yProperty> PropertyList { get; set; }
        public string GUID { get; set; }
    }
}
