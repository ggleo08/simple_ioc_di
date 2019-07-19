using System;

namespace IoC.Framework.IoCAbstractBasics
{
    /// <summary>
    /// 对于IIoCKernel类型的定义，Bind和To两个方法用于绑定抽象、具体到关系维护的对象中，而GetValue()方法则是用以获取上层对象的实例
    /// 模仿的Ninject框架
    /// </summary>
    public interface IIoCKernel
    {
        /// <summary>
        /// 绑定抽象类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IIoCKernel Bind<T>();
        /// <summary>
        /// 绑定具体实现类型
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <returns></returns>
        IIoCKernel To<U>() where U : class;
        /// <summary>
        /// 获取上层对象的实例
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <returns></returns>
        V GetValue<V>() where V : class;
    }
}
