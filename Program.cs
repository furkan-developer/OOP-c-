
Person person1 = new Person(){Name="Furkan",LastName="Aydın"};
Person person2 = person1 with {Name="Ferdi"};

System.Console.WriteLine($"person1 Name: {person1.Name} -- person2 Name: {person2.Name}");
// output: person1 Name: Furkan -- person2 Name: Ferdi

record Person
{
    public string Name { get; init; }
    public string LastName { get; init; }
}