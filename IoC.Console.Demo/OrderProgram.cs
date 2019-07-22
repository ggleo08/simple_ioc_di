using System;
using System.Collections.Generic;
using System.Text;
using IoCConsole.Demo.Order;

namespace IoCConsole.Demo
{
    class OrderProgram
    {
        static void Main(string[] args)
        {

            #region 构造函数注入、属性注入
            //SqlServerDAL dal = new SqlServerDAL();
            //AccessDAL dal = new AccessDAL();
            ////OrderBLL order = new OrderBLL(dal);
            //OrderBLL order = new OrderBLL();
            //order.ida = dal;
            //order.Add();
            #endregion

            #region 接口注入
            AccessDAL dal = new AccessDAL();
            OrderBLL order = new OrderBLL();
            order.SetDependent(dal);
            order.Add();
            #endregion

            Console.ReadKey();

        }
    }
}
