namespace Laboratory_work_2;

public class Tutor : PeopleBase
{
    public DateOnly DateOfEmployment { get; set; }
    public string IdNumber { get; set; }

    public Tutor(string fullname, string dateOfEmploymentString, string idNumber) : base(fullname)
    {
        if (!string.IsNullOrEmpty(idNumber))
            IdNumber = idNumber;
        else
            throw new ArgumentException(null, nameof(idNumber));

        if (!string.IsNullOrEmpty(dateOfEmploymentString))
        {
            var dateOfEmployment =
                DateOnly.Parse(dateOfEmploymentString); //преобразуем строковый параметр даты в объект класса DateOnly

            if (DateOnly.FromDateTime(DateTime.Now).CompareTo(dateOfEmployment) >=
                0) //сравниваем введенную дату с текущей
                DateOfEmployment = dateOfEmployment;
            else
                throw new ArgumentException("Дата приема позднее текущей даты", nameof(dateOfEmployment));
        }
        else
        {
            throw new ArgumentException(null, nameof(dateOfEmploymentString));
        }
    }
}