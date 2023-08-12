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
}
