


using _001_EF.Data;
using _001_EF.Models;

Console.WriteLine("Start .............");

using (DbAppContext context = new()) 
{
    context.Users.Add(new User("Liam", "Adams", 50));
    context.SaveChanges();
} 
