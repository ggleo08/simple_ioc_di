using IoC.Framework.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework
{
    public class DefualtDITypeAnalyticalProivder : IDITypeAnalyticalProvider
    {
        public IDITypeAnalytical CreateDITypeAnalarytial()
        {
            return new DITypeAnalytical();
        }
    }
}
