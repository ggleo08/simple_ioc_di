using IoC.Framework.IoCBasics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Test
{
    public interface IAbstractOne
    {
        void WriterLine(string meg);
    }

    public class AchieveOne : IAbstractOne
    {
        private IAbstractOne_One _AbstractOne_One;
        public AchieveOne(IAbstractOne_One abstractone)
        {
            _AbstractOne_One = abstractone;
        }


        private IAbstractOne_Two _AbstractOne_Two;

        [DIType]
        public IAbstractOne_Two AbstractOne_Two
        {
            get
            {
                return _AbstractOne_Two;
            }
            set
            {
                _AbstractOne_Two = value;
            }
        }

        public void WriterLine(string meg)
        {
            _AbstractOne_One.WirterLine(meg);
            _AbstractOne_Two.WriterLine(meg);
            Console.WriteLine(meg + "-This is TestOne");
        }
    }
}
