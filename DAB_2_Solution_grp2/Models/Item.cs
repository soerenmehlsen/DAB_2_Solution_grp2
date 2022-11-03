namespace DAB_2_Solution_grp2.Models;

public class Item
{
    public int ItemId { get; set; }
    public string? ItemType { get; set; }

    public List<Facility>? Facilities { get; set; } // Navigational property
}