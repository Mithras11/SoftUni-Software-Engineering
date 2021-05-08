namespace P01.Stream_Progress.Contracts
{
    public interface IStreamable : ISource
    {

        public int BytesSent { get; set; }
    }

}
