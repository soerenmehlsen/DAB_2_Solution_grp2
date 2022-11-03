// See https://aka.ms/new-console-template for more information

using DAB_2_Solution_grp2.Data;
using DAB_2_Solution_grp2.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var context = new MyDbContext())
{
    var user = new User()
    {
        Userid = 1,
        Name = "Niels",
        PhoneNumber = 27324596,
        Email = "niels@hotmail.com",
        Category = "PrivatePerson",
    };
    context.Add(user);
    await context.SaveChangesAsync();
    
}
