
string firstName = "salih";
string lastName = "cantekin";

//string name = string.Format("{0}{1}{2}", firstName, " ", lastName);
// Özel karakter ", {}, $, @, \
string name = $"{firstName} {lastName}";

name = "{\"name \":\"John \", \"age \":30, \"car \":null}";

name = $$"""""
        {
            "name":"{{firstName}}",
            "age":30, 
            "car":" """"  "
        }
    """"";

Console.WriteLine(name);

