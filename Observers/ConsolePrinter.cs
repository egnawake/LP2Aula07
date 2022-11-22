using System;

namespace Observers
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        public void Update(AbstractStringSubject subj)
        {
            Console.WriteLine(subj.Item);
        }
    }
}