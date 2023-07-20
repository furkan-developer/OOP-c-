

Person person1 = new Person(Name:"Furkan",LastName:"Aydın");
Person person2 = person1 with {Name="Ferdi"};

// Deconstruct support tuple
(string name, string lastName) = person1;

System.Console.WriteLine($"name variable: {name}");
// output: name variable: Furkan

System.Console.WriteLine($"person1 Name: {person1.Name} -- person2 Name: {person2.Name}");
// output: person1 Name: Furkan -- person2 Name: Ferdi

record Person(string Name, string LastName);

// following code created by compiler
// record Person
// {
//     public string Name { get; init; }
//     public string LastName { get; init; }
    
//     public Person(string Name, string LastName)
//     {
//         this.Name = Name;
//         this.LastName = LastName;
//     }

//     public void Deconstruct(out string Name, out string LastName)
//     {
//         Name = this.Name;
//         LastName = this.LastName;
//     }
// }
