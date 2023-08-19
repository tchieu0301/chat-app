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
        ICollection<Friend> friends { get; set; } = new List<Friend>();
    }

    public class Friend
    {
        [Key]
        public int friend_list_id { get; set;}
        public Account? account { get; set; }
        public int friend_id { get; set; }
    }
}
