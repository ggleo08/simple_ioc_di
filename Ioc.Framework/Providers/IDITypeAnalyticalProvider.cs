using IoC.Framework.IoCAbstractBasics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Providers
{
    /// <summary>
    /// 分析类型的抽象
    /// 在提供程序抽象中用以它来做返回类型，这也遵循着依赖倒置原则B条的抽象不依赖于具体
    /// </summary>
    public interface IDITypeAnalyticalProvider
    {
        IDITypeAnalytical CreateDITypeAnalarytial();
    }
}
