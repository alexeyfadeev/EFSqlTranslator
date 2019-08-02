namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Account entity </summary>
    [Table("account", Schema="public")]
    public class Account
    {
        /// <summary> Data </summary>
        [Column("data")]
        public string Data { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> Login </summary>
        [Column("login")]
        public string Login { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> Password </summary>
        [Column("password")]
        public string Password { get; set; }
        
        /// <summary> Role </summary>
        [Column("role")]
        public int Role { get; set; }
    }
}
