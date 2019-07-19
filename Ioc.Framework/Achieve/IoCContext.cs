using IoC.Framework.IoCBasics;
using IoC.Framework.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Achieve
{
    /// <summary>
    /// 维护框架中必要对象上下文，单例模式
    /// 维护着所要依赖注入的抽象、具体类型维护的对象
    /// 分析上层类型的提供程序对象，分析上层类型的提供程序对象是用以生成分析上层类型对象的，便于对外扩展
    /// </summary>
    public class IoCContext
    {
        private IoCContext() { }
        private static IoCContext _context;
        public static IoCContext Context
        {
            get
            {
                if (_context==null)
                {
                    _context = new IoCContext();
                }
                return _context;
            }
        }
        private IDITypeAnalyticalProvider _DITypeAnalyticalProvider;
        public IDITypeAnalyticalProvider DITypeAnalyticalProvider
        {
            get
            {
                if (_DITypeAnalyticalProvider==null)
                {
                    _DITypeAnalyticalProvider = new DefualtDITypeAnalyticalProivder();
                }
                return _DITypeAnalyticalProvider;
            }
            set
            {
                _DITypeAnalyticalProvider = value;
            }
        }
        public DITypeInfoManage DITypeInfoManage { get; set; }
    }
}
