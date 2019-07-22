using System;
using System.Collections.Generic;
using System.Text;

namespace IoCConsole.Demo.Order
{
    /// <summary>
    /// 逻辑层
    /// </summary>
    public class OrderBLL : IDependent
    {
        #region 构造函数注入 、属性注入
        //private IDataAccess _ida;

        //public IDataAccess ida
        //{
        //    get { return _ida; }
        //    set { _ida = value; }
        //}

        //public OrderBLL()
        //{
        //}
        ///// <summary>
        ///// 构造函数注入
        ///// </summary>
        ///// <param name="ida"></param>
        //public OrderBLL(IDataAccess ida)
        //{
        //    _ida = ida;
        //}

        //public void Add()
        //{
        //    ida.Add();
        //}
        #endregion

        #region 接口注入
        // 私有变量保存抽象
        private IDataAccess _ida;
        //实现接口
        public void SetDependent(IDataAccess ida)
        {
            _ida = ida;
        }

        public void Add()
        {
            _ida.Add();
        }
        #endregion

    }
}
