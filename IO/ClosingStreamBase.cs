using System.IO;

namespace SharpFileSystem.IO
{
    public abstract class ClosingStreamBase : Stream
    {
        //AG: they forgot Stream.Close in .NET Core so adding it
        public virtual void Close()
        {
            this.Dispose();
        }
    }
}
