using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonPatternExample
    {
        public void CreateExamcard()
        {
            Examcard examcard = Examcard.Instance;
        }
    }

    internal class Examcard
    {
        private static Examcard _examcardInstance;
        private static readonly object _locker = new object();
        private Examcard(){}

        public static Examcard Instance
        {
            get
            {
                //Implemented with double-checking lock
                if (_examcardInstance == null)
                {
                    lock (_locker)
                    {
                        if (_examcardInstance == null)
                        {
                            _examcardInstance = new Examcard();
                        }
                    }
                }

                return _examcardInstance;
            }
        }
    }
}
