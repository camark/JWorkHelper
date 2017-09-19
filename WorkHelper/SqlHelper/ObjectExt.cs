using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Utilities
{
    /// <summary>
    /// 对boject的扩展
    /// </summary>
    public static class ObjectExt
    {
        public static int ToInt(this object input)
        {
            int result = 0;
            if (input == null)
            {
                return result;
            }
            else
            {
                int.TryParse(string.Format("{0:N0}", input).Replace(",",""), out result);
                return result;
            }
        }

    }
}
