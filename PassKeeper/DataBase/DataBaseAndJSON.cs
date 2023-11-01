using PassKeeper.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PassKeeper.DataBase;

public static class DataBaseAndJSON
{

    public static List<User> ? UsersInDataBase { get; set; }

    public static User CheckUserIsInTheSystem(string email , string  password)
    {
        if (UsersInDataBase != null)
            foreach (var user in UsersInDataBase)
            {
                if (user.Email == email && user.Password == password) return user;
            }
            return null!;
    }

    public static void AddUserToTheSystem(User user)
    {
        if (UsersInDataBase != null) UsersInDataBase.Add(user);
        else if (UsersInDataBase == null) UsersInDataBase = new List<User>() { user };
        WriteUsersToJsonFile();

    }

    public static void WriteUsersToJsonFile()
    {
        string jsonString = JsonSerializer.Serialize(UsersInDataBase);
        File.WriteAllText(@"../../../../users.json",jsonString);
    }

    public static void ReadUsersFromFile()
    {
        if (File.Exists(@"../../../../users.json"))
        {
            List<User> ? Users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("../../../../users.json"));
            UsersInDataBase = Users;
        }

        else
        {
            List<User>? Users = new List<User>() { new User("Saed", "Mamedov", "seid13463@gmail.com", "saed123321" )};
            UsersInDataBase = Users;
        }
    }

    public static void FindUserByMailAndChangePassword(string mail,string new_pass)
    {
        if(UsersInDataBase != null)
            foreach (var user in UsersInDataBase)
            {
                if (user.Email == mail)
                {
                    user.Password = new_pass;
                    WriteUsersToJsonFile();
                    return;
                }
            }
    }


    public static bool FindUserByMail(string mail)
    {
        if (UsersInDataBase != null)
            foreach (var user in UsersInDataBase)
            {
                if (user.Email == mail)
                    return true;
            }
            return false;
    }

}
