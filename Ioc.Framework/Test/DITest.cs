using IoC.Framework.IoCBasics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Framework.Test
{
    public class DITest
    {
        private IAbstractOne _AbstractOne;
        public DITest(IAbstractOne abstractone)
        {
            _AbstractOne = abstractone;
        }

        private IAbstractTwo _AbstractTwo;

        [DIType]
        public IAbstractTwo AbstractTwo
        {
            get
            {
                return _AbstractTwo;
            }
            set
            {
                _AbstractTwo = value;
            }
        }

        public void Writer(string meg)
        {
            _AbstractOne.WriterLine(meg);
            _AbstractTwo.WriterLine(meg);
        }
    }
}
