using System.ComponentModel.DataAnnotations;

namespace DiscGolfTrackingModels;

public class User
{
    [Key]
    public string email { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}
