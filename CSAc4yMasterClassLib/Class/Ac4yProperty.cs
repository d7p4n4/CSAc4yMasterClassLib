using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4yClass.Class
{

    [Serializable]
    public class Ac4yProperty
    {

        public String Name { get; set; }
        public String Type { get; set; }
        public String InternalName { get; set; }

        public Ac4yProperty() { }

        public Ac4yProperty(String aName, String aType) : this()
        {
            Name = aName;
            Type = aType;
        }

        public Ac4yProperty(String aName, String aType, String aInternalName) : this(aName, aType)
        {
            InternalName = aInternalName;
        }

    }
}
