namespace DAB_2_Solution_grp2.Models;

public class Company
{
    public int CompanyId { get; set; }
    public int CVRNumber { get; set; }

    public User? User { get; set; } // Navigational property
}