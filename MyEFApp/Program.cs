// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MyEFApp.Models;



using(var ctx = new EftestDbContext())
{
    var activeUsers = ctx.Users.Where(u => u.IsActive);

    foreach (var user2 in activeUsers)
    {
        Console.WriteLine(user2.Name);
    }


    ctx.Users.Add(new User());



    //wypisać na konsolę liczbę użytkowników - count()
    int allUsers = ctx.Users.Count();
    Console.WriteLine(allUsers);

    //wypisać na konsolę użytkowników z ich rolami w formacie user.Name : group.Name

    foreach (var user1 in ctx.Users.Include(u => u.UserGroups).ThenInclude(ug => ug.Group))
    {
        foreach (var gr in user1.UserGroups.Select(ug => ug.Group))
        {
            Console.WriteLine($"{user1.Name} : {gr.Name}");
        }
    }

    var userWithGroups = ctx.Users
        .SelectMany(us => us.UserGroups
                .Select(ug => new { UserName = us.Name, GroupName = ug.Group.Name }))
        .ToArray();

    //Dodać nowego użytkownika
    var user = ctx.Users.Add(new User {Name = "Test;", IsActive = true, Password = "Test"});


    //przypisać użytkownikowi rolę
    var adminRole = ctx.Groups.Single(g => g.Name == "Administrator");

    ctx.UserGroups.Add(
        new UserGroup {
            Id = ctx.UserGroups.Max(ug => ug.Id) + 1, 
            User = user.Entity, 
            Group = adminRole }
        );

    ctx.SaveChanges();


    ctx.SaveChanges();
}



Console.ReadLine();