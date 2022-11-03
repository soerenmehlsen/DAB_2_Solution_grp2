namespace DAB_2_Solution_grp2.Models;

public class Facility
{
    public int FacilityId { get; set; }
    public string? FacilityKind { get; set; }
    public string? ClosestAddress { get; set; }
    public string? Information { get; set; }
    public string? RulesOfUse { get; set; }

    public int ItemId { get; set; } // Foreign Key
    public Item? Item { get; set; } // Navigational property
    
    public int ReservationId { get; set; } // Foreign Key
    public Reservation? Reservation { get; set; } // Navigational property
    
    public int UserId { get; set; } // Foreign Key
    public List<User>? Users { get; set; } // Navigational property
    
}