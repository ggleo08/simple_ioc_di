using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.IoCBasics
{
    /// <summary>
    /// DI类型关系信息管理
    /// 表示着抽象、具体类型关系的信息维护，实则就是在内部封装了键值对(key:抽象类型,value:实现类型>)
    /// </summary>
    public class DITypeInfoManage
    {
        private Dictionary<Type, Type> _DITypeInfo;
        public DITypeInfoManage()
        {
            _DITypeInfo = new Dictionary<Type, Type>();
        }

        /// <summary>
        /// 添加DI类型关系
        /// </summary>
        /// <param name="key">抽象类型</param>
        /// <param name="value">实现类型</param>
        public void AddTypeInfo(Type key, Type value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            if (_DITypeInfo.ContainsKey(key))
            {
                return;
            }
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            _DITypeInfo.Add(key, value);
        }

        /// <summary>
        /// 获取DI类型关系的实现类型
        /// </summary>
        /// <param name="key">抽象类型</param>
        /// <returns></returns>
        public Type GetTypeInfo(Type key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            if (_DITypeInfo.ContainsKey(key))
            {
                return _DITypeInfo[key];
            }
            return null;
        }

        public bool ContainsKey(Type key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            return _DITypeInfo.ContainsKey(key);
        }
    }
}
