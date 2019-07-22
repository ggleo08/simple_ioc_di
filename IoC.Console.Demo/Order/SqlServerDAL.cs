using System;
using System.Collections.Generic;
using System.Text;

namespace IoCConsole.Demo.Order
{
    /// <summary>
    /// DB 操作
    /// </summary>
    public class SqlServerDAL:IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("在SQLSERVER数据库中添加一条订单");
        }
    }
}
