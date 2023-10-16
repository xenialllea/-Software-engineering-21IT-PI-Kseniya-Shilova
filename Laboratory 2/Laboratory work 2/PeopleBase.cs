namespace Laboratory_work_2;

public abstract class PeopleBase
{
    public string Fullname { get; set; }

    protected PeopleBase(string fullname)
    {
        if (!string.IsNullOrEmpty(fullname))
            Fullname = fullname;
        else
            throw new ArgumentException(null, nameof(fullname));
    }
}