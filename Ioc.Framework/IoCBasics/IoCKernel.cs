using IoC.Framework.Achieve;
using IoC.Framework.IoCAbstractBasics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.IoCBasics
{
    /// <summary>
    /// 实现了IIoCKernel接口
    /// 首先在其构造函数中，我们对抽象、具体关系维护的对象进行了初始化
    /// 并且设置到了当前IoC框架的上下文中
    /// </summary>
    public class IoCKernel : IIoCKernel
    {
        private Type _BaseType;
        public IoCKernel()
        {
            IoCContext.Context.DITypeInfoManage = new DITypeInfoManage();
        }
        public IIoCKernel Bind<T>()
        {
            _BaseType = typeof(T);
            return this;
        }
        public IIoCKernel To<U>() where U : class
        {
            Type achieveType = typeof(U);
            if (achieveType.BaseType == _BaseType || achieveType.GetInterface(_BaseType.Name) != null)
            {
                IoCContext.Context.DITypeInfoManage.AddTypeInfo(_BaseType, achieveType);
            }
            return this;
        }

        public V GetValue<V>() where V : class
        {
            return IoCContext.Context.DITypeAnalyticalProvider.CreateDITypeAnalarytial().GetValue<V>();
        }

    }
}
