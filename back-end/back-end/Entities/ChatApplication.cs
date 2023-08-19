using System.ComponentModel.DataAnnotations;

namespace back_end.Entities
{
    public class Account
    {
        [Key]
        public int account_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

     public class ChatBox
    {
        [Key]
        public int chat_box_id { get; set; }
        public int room { get; set; }
        public ICollection<Account> accounts { get; set; } = new List<Account>();
    }
}
