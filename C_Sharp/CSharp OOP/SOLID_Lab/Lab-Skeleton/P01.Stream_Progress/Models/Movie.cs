namespace P01.Stream_Progress.Models
{
    using Contracts;


    public class Movie : IStreamable
    {
        public Movie(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;

        }

        public int Length { get; set; }
        public int BytesSent { get; set; }
    }
}
