using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.IoCBasics
{
    /// <summary>
    /// 特性类定义，用作规范约束。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DITypeAttribute : Attribute
    {
        public DITypeAttribute() { }
    }
}
