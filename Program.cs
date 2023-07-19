using System.Text;

Numbers numbers = new();

numbers[1] = "One";
numbers[2,true] = "İki";

System.Console.WriteLine(numbers[2]);
// İki

class Numbers
{
    Dictionary<int, string> numbers = new();

    public object this[int number]
    {
        get { return numbers[number]; }
        set { numbers.Add(number, (string)value); }
    }

    public object this[int number, bool isTurkish]
    {
        get { return numbers[number]; }
        set
        {   
            StringBuilder builder = new((string)value);
            if(isTurkish)
                builder.Append(" -tr");

            string result = builder.ToString();

            numbers.Add(number,result);
        }
    }
}