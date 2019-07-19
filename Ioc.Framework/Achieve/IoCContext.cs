using IoC.Framework.IoCBasics;
using IoC.Framework.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Achieve
{
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
