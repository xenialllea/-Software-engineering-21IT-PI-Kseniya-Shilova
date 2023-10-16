namespace Laboratory_work_2;

public class Student : PeopleBase
{
    public string CardNumber { get; set; }
    public string Group { get; set; }

    public Student(string fullname, string group, string cardNumber) : base(fullname)
    {
        if (!string.IsNullOrEmpty(group))
            Group = group;
        else
            throw new ArgumentException(null, nameof(group));

        if (!string.IsNullOrEmpty(cardNumber))
            CardNumber = cardNumber;
        else
            throw new ArgumentException(null, nameof(cardNumber));
    }
}