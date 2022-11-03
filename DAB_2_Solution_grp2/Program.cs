// See https://aka.ms/new-console-template for more information

using DAB_2_Solution_grp2.Data;
using DAB_2_Solution_grp2.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Inserting data");
using (var context = new MyDbContext())
{
    var userNiels = new User()
    {
        Name = "Niels",
        PhoneNumber = 27324596,
        Email = "niels@hotmail.com",
        Category = "PrivatePerson",
    };
    
    var userAnders = new User()                
    {                                     
        Name = "Anders",                   
        PhoneNumber = 26232321,           
        Email = "anderrs@gmail.com",      
        Category = "PrivatePerson",       
    };                                    
    
    var userKlaus = new User()            
    {                                 
        Name = "Klaus",              
        PhoneNumber = 24343434,       
        Email = "klaus@live.dk",  
        Category = "PrivatePerson",   
    };
    
    var userCult = new User()       
    {                                
        Name = "Cult",              
        PhoneNumber = 38383838,      
        Email = "cult@cult.dk",     
        Category = "Company",
        CompanyId = 1,
    };

    var reservation1 = new Reservation()
    {
        DateIn = Convert.ToDateTime("2022-09-28 09:00:00"),
        DateOut = Convert.ToDateTime("2022-09-28 10:00:00"),
        NumberOfPeople = 4,
        Note = null,
        Document = null,
        UserId = 1,
    };
    //context.Add(userAnders);  
    //context.Add(userAnders);
    //context.Add(userKlaus);
    //context.Add(userCult);
    
    context.Add(reservation1);
    
    context.Add(userCult); 
    context.SaveChanges();
    Console.WriteLine("Data saved");
}

