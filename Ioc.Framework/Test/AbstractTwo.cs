using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Test
{
    public interface IAbstractTwo
    {
        void WriterLine(string meg);
    }

    public class AchieveTwo : IAbstractTwo
    {
        public void WriterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestTwo");
        }
    }
}
