using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Test
{
    public interface IAbstractOne_One
    {
        void WirterLine(string meg);
    }

    public class AbstractOne_One : IAbstractOne_One
    {
        public void WirterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestOne_One");
        }
    }

    public interface IAbstractOne_Two
    {
        void WriterLine(string meg);
    }

    public class AbstractOne_Two : IAbstractOne_Two
    {
        public void WriterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestOne_Two");
        }
    }
}
