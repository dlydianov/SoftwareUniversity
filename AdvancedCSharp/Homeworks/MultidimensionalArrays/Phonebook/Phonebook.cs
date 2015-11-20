using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        // Write a program that receives some info from the console about people and their phone numbers. You are free to choose the manner in which the data is entered; each entry should have just one name and one number (both of them strings). After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name and print her details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." 

        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string command = Console.ReadLine();
        while(command != "search")
        {
            string[] information = command.Split('-');
            phonebook.Add(information[0], information[1]);
            command = Console.ReadLine();
        }
        while(true)
        {
            string search = Console.ReadLine(); 
            if(phonebook.ContainsKey(search))
            {
                Console.WriteLine("{0} -> {1}", search, phonebook[search]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", search);
            }
        }
      
    }
}

