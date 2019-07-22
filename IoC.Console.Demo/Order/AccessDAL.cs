using System;
using System.Collections.Generic;
using System.Text;

namespace IoCConsole.Demo.Order
{
    class AccessDAL : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("在ACCESS数据库中添加一条记录！");
        }
    }
}
