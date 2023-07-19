Numbers numbers = new();

numbers[1] = "One";
numbers[2] = "Two";

System.Console.WriteLine(numbers[1]);
// One
class Numbers
{
    Dictionary<int,string> numbers = new();

    public object this[int number]
    {
        get { return numbers[number]; }
        set { numbers.Add(number,(string)value); }
    }
}