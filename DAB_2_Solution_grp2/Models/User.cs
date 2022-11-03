namespace DAB_2_Solution_grp2.Models;

public class User
{
    public int Userid { get; set; }
    public string? Name { get; set; }
    public int PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Category { get; set; }
    
    public int? CompanyId { get; set; } // Foreign key
    public List<Company>? Companies { get; set; } // Navigational property

    public Facility? Facility { get; set; } // Navigational property
    public Reservation? Reservation { get; set; } // Navigational property
}