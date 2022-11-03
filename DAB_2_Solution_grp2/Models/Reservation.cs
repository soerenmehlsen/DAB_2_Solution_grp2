namespace DAB_2_Solution_grp2.Models;

public class Reservation
{
    public int ReservationId { get; set; }
    public DateTime DateIn { get; set; }
    public DateTime DateOut { get; set; }
    public int NumberOfPeople { get; set; }
    public string? Note { get; set; }
    public string? Document { get; set; }
    
    public int UserId { get; set; } // Foreign key
    public List<User>? Users { get; set; } // Navigational property
    
    public int Maintenance { get; set; } // Foreign key
    public List<Maintenance>? Maintenances { get; set; } // Navigational property

    public List<Facility>? Facilities { get; set; } // Navigational property
}