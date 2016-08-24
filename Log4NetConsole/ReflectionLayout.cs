using log4net.Layout;
using log4net.Layout.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    /// <summary>
    /// 自定义Layout
    /// </summary>
    public class ReflectionLayout : PatternLayout
    {
        public ReflectionLayout()
        {

            this.AddConverter("property", typeof(ReflectionPatternConverter));

        }
    }
    
}
