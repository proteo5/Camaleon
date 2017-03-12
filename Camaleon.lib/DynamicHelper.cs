using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaleon.lib
{
    public static class DynamicHelper
    {
        public static bool IsSet(dynamic obj, string field)
        {
            var d = obj as IDictionary<string, object>;

            return d.ContainsKey(field);
        }
    }

}
