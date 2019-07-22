using System;
using System.Collections.Generic;
using System.Text;

namespace IoCConsole.Demo.Order
{
    public interface IDependent
    {
        // 设置依赖项
        void SetDependent(IDataAccess ida);
    }
}
