using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.IoCAbstractBasics
{
    /// <summary>
    /// 泛型类型是所需要执行依赖注入并且生成的上层对象类型
    /// </summary>
    public interface IDITypeAnalytical
    {
        /// <summary>
        /// 泛型类型是所需要执行依赖注入并且生成的上层对象类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetValue<T>();
    }
}
