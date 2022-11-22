using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string fileName;

        public FileSaver(string fileName)
        {
            this.fileName = fileName;
        }

        public void Update(AbstractStringSubject subj)
        {
            File.AppendAllText(fileName, subj.Item + "\n");
        }
    }
}