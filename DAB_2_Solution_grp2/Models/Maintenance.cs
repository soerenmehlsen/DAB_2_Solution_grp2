namespace DAB_2_Solution_grp2.Models;

public class Maintenance
{
    public int MaintenanceId { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }

    public Reservation? Reservation { get; set; }
}