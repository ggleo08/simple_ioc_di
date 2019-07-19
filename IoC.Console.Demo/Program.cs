using IoC.Framework.IoCAbstractBasics;
using IoC.Framework.IoCBasics;
using IoC.Framework.Test;
using System;

namespace IoCConsole.Demo
{

    /**
     * 依赖原则
     * A.高层次的模块不应该依赖于低层次的模块，他们都应该依赖于抽象。
     * B.抽象不应该依赖于具体，具体应该依赖于抽象。
     */
    class Program
    {
        static void Main(string[] args)
        {
            //// 下面两个demo违背的原则是：“具体应该依赖于抽象”
            //// 依赖倒置
            //// A.高层次的模块不应该依赖于低层次的模块，他们都应该依赖于抽象
            //IUnderly1 underly = new Underly1();
            //underly.WriteLine();

            //// B.抽象不应该依赖于具体
            //IUnderly2 underly2 = new Underly2();
            //underly2.WriteLine();

            //#region 依赖注入基本实现：依赖注入是把耦合的问题抛到了外部，抛到了要使用Top类型的对象中，这个问题就很严重了，我们怎么解决呢？
            //// 构造函数注入
            //Top top = new Top(new Underly3());
            //top.Execution();

            //// 属性注入
            //Top2 top2 = new Top2();
            //top2.Underly = new Underly3();
            //top2.Execution();

            //// 接口注入
            //Top3 top3 = new Top3();
            //top3.SetQuote(new Underly3());
            //top3.Execution();
            //#endregion

            #region IoCTest
            IIoCKernel iocKernel = new IoCKernel();
            iocKernel.Bind<IAbstractOne>().To<AchieveOne>();
            iocKernel.Bind<IAbstractTwo>().To<AchieveTwo>();
            iocKernel.Bind<IAbstractOne_One>().To<AbstractOne_One>();
            iocKernel.Bind<IAbstractOne_Two>().To<AbstractOne_Two>();
            DITest diType = iocKernel.GetValue<DITest>();
            diType.Writer("IoCFrameWorkTest");
            #endregion

            Console.ReadKey();
        }
    }

    #region  A.高层次的模块不应该依赖于低层次的模块，他们都应该依赖于抽象
    /// <summary>
    /// Interface
    /// </summary>

    public interface IUnderly1
    {
        void WriteLine();
    }

    /// <summary>
    /// Implement
    /// </summary>
    public class Underly1 : IUnderly1
    {
        public void WriteLine()
        {
            Console.WriteLine("这里是底层接口实现的输出...");
        }
    }
    #endregion

    #region B.抽象不应该依赖于具体
    public interface IUnderly2
    {
        void WriteLine();
        IWriter CreateWriterInstance();

    }
    public interface IWriter
    {
        void WriteLine();
    }
    public class Writer : IWriter
    {
        public void WriteLine()
        {
            Console.WriteLine("这只是一个输出");
        }
    }
    public class Underly2 : IUnderly2
    {
        public IWriter CreateWriterInstance()
        {
            return new Writer();
        }

        public void WriteLine()
        {
            CreateWriterInstance().WriteLine();
        }
    }
    #endregion

    // 为解决“具体应该依赖于抽象”完全实现依赖倒置原则，（依赖注入解决的问题是将具体到具体的依赖转换成具体到抽象的依赖）

    #region 构造函数注入
    public class Top
    {
        private IUnderly3 _underly;
        public Top(IUnderly3 underly3)
        {
            _underly = underly3;
        }
        public void Execution()
        {
            _underly.WriteLine();
        }
    }
    public interface IUnderly3
    {
        void WriteLine();
    }
    public class Underly3 : IUnderly3
    {
        public void WriteLine()
        {
            Console.WriteLine("这只是一个底层类型的输出");
        }
    }
    #endregion

    #region 属性注入
    public class Top2
    {
        private IUnderly3 _underly;
        public IUnderly3 Underly
        {
            get
            {
                return _underly;
            }
            set
            {
                _underly = value;
            }
        }
        public void Execution()
        {
            _underly.WriteLine();
        }
    }
    #endregion

    #region 接口注入
    public interface IQuote
    {
        void SetQuote(IUnderly3 underly3);
    }
    public class Top3 : IQuote
    {
        private IUnderly3 _underly;

        public void SetQuote(IUnderly3 underly)
        {
            _underly = underly;
        }
        public void Execution()
        {
            _underly.WriteLine();
        }
    }
    #endregion

}
