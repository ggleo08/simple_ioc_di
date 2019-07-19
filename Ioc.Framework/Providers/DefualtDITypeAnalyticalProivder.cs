using IoC.Framework.IoCAbstractBasics;
using IoC.Framework.IoCBasics;
using IoC.Framework.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Providers
{
    /// <summary>
    /// 默认的分析上层类型提供程序,默认返回的就是我们框架中默认的分析上层类型对象
    /// </summary>
    public class DefualtDITypeAnalyticalProivder : IDITypeAnalyticalProvider
    {
        public IDITypeAnalytical CreateDITypeAnalarytial()
        {
            return new DITypeAnalytical();
        }
    }
}
