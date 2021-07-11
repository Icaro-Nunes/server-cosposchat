namespace TheServer.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int Source { get; set; }
        //This one will be the contact ID
        public int Destination {get; set;}
        public string Content { get; set; }
    }
}