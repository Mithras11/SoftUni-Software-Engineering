namespace P01.Stream_Progress.Streams
{
    using Contracts;

    public class StreamProgressInfo : StreamProgressor
    {
        private IStreamable file;
               
        public StreamProgressInfo(IStreamable file)
            :base(file)
        {           
        }
                
    }
}
