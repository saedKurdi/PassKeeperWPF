using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper.Classes;

public class User
{

    public string? Password { get; set; }
    public string? Email { get; set; }  
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public User(string firstName,string lastName,string email , string password)
    {
        Password = password;
        FirstName = firstName;
        LastName = lastName;
            Email = email;
    }

}
