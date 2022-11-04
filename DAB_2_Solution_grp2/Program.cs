// See https://aka.ms/new-console-template for more information

using DAB_2_Solution_grp2.Data;
using DAB_2_Solution_grp2.Models;
using Microsoft.EntityFrameworkCore;

#region Insert data
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
    
    var reservation2 = new Reservation()                      
    {                                                         
        DateIn = Convert.ToDateTime("2022-09-28 10:00:00"),   
        DateOut = Convert.ToDateTime("2022-09-28 12:00:00"),  
        NumberOfPeople = 2,                                   
        Note = null,                                          
        Document = null,                                      
        UserId = 2,                                           
    };
    
    var reservation3 = new Reservation()                     
    {                                                        
        DateIn = Convert.ToDateTime("2022-09-28 13:00:00"),  
        DateOut = Convert.ToDateTime("2022-09-28 14:00:00"), 
        NumberOfPeople = 10,                                  
        Note = null,                                         
        Document = null,                                     
        UserId = 3,                                          
    };
    
    var reservation4 = new Reservation()                      
    {                                                         
        DateIn = Convert.ToDateTime("2022-09-28 16:00:00"),   
        DateOut = Convert.ToDateTime("2022-09-28 20:00:00"),  
        NumberOfPeople = 20,                                  
        Note = null,                                          
        Document = null,                                      
        UserId = 4,                                           
    };

    var item1 = new Item()
    {
        ItemType = "Lighter",
    };
    
    var item2 = new Item()    
    {                         
        ItemType = "Keys", 
    };
    
    var item3 = new Item()  
    {                       
        ItemType = "Flashlight",  
    };
    
    var item4 = new Item()  
    {                       
        ItemType = "Kitchen stuff",  
    }; 
    
    var facility1 = new Facility()           
    {                                
        FacilityKind = "Fire pit",
        ClosestAddress = "Mollerup forest",
        Information = "There is room for 30 day guests and 8 overnight guests in hammocks",
        RulesOfUse = "First come, first served",
        ItemId = 5,
        ReservationId = 1,
    };                               
    
    var facility2 = new Facility()                                                         
    {                                                                                      
        FacilityKind = "Gear base",                                                         
        ClosestAddress = "Marselisborg forest",                                                  
        Information = "It has a unique location in the forest and it's close to the city",
        RulesOfUse = "Maximum 5 people",                                           
        ItemId = 6,                                                                        
        ReservationId = 2,                                                                 
    };
    
    var facility3 = new Facility()                                                        
    {                                                                                     
        FacilityKind = "Shelter",                                                       
        ClosestAddress = "Moesgaard forest",                                           
        Information = "The shelter is located near the Skelbaekken",
        RulesOfUse = "No kids alone",                                                  
        ItemId = 7,                                                                       
        ReservationId = 3,                                                                
    };
    
    var facility4 = new Facility()                                   
    {                                                                
        FacilityKind = "Education center",                                    
        ClosestAddress = "Damgaards",                         
        Information = "One of the best", 
        RulesOfUse = "Go hard og go home",                                
        ItemId = 8,                                                  
        ReservationId = 4,                                           
    };

    var company = new Company()
    {
        CVRNumber = 43473421,
    };
    
    // context.Add(userNiels);      
    // context.Add(userAnders);      
    // context.Add(userKlaus);       
    // context.Add(userCult);        
                                
     // context.Add(reservation1);    
     // context.Add(reservation2);    
     // context.Add(reservation3);    
     // context.Add(reservation4);    
    //                             
    // context.Add(item1);           
    // context.Add(item2);           
    // context.Add(item3);           
    // context.Add(item4);           
    
    // context.Add(facility1);
    // context.Add(facility2);
    // context.Add(facility3);
    // context.Add(facility4); 
    //
    context.Add(company);
    
    context.SaveChanges();
    Console.WriteLine("Data saved");
    
    // var query = context.Facilities
    //     .Include(p => p.FacilityKind)
    //     .Include(b => b.ClosestAddress)
    //     .ToList();
    
    // Get all available facilities names and closest/"nærmeste" address
    var query1 = context.Facilities
        .Select(x => new{x.FacilityKind, x.ClosestAddress})
        .ToList();

    foreach (var a in query1)
    {
        Console.WriteLine("Name: " + a.FacilityKind + " " + "Closest-address: " +  a.ClosestAddress);
    }
    
    // Get all facilities as a table of names and address ordered by their kind. (Alternatively: Get the number of facilities grouped by their kind)
    var query2 = context.Facilities
        .Select(x => new{x.FacilityKind, x.ClosestAddress})
        .OrderBy(x => x.FacilityKind)
        .ToList();
    Console.WriteLine("");
    foreach (var a in query2)
    {
        Console.WriteLine("Name: " + a.FacilityKind + " " + "Closest-address: " +  a.ClosestAddress);
    }
    
    // Get a list of booked facilities name with the booking user (and possibly business) and the timeslot it is booked in.
    var query3 = context.Facilities
        .Select(x => new{x.FacilityKind, x.Reservation.DateIn, x.Reservation.DateOut, x.Reservation.User.Name})
        .ToList();
    Console.WriteLine("");
    foreach (var a in query3)
    {
        Console.WriteLine("Name: " + a.FacilityKind + " " + "User: " + a.Name + "," + "DateIn: " + a.DateIn + "," + "DateOut " + a.DateOut);
    }
}
#endregion

