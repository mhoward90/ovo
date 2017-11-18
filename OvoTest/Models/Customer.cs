namespace OvoTest.Models
{

    public interface ICustomer
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string gender { get; set; }
        string title { get; set; }
    }

    public class Customer : ICustomer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string title { get; set; }
    }
}