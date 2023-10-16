namespace Laboratory_work_2;

public class ListOfEmployees : List<PeopleBase>
{
    public int TutorCount() //Метод,возвращающий общее количество преподавателей 
    {
        return FindAll(element => element is Tutor).Count;
    }

    public int
        GetStudentByGroup(string groupName) //Метод,возращающий количество студентов в группе, заданной параметром
    {
        var counter = 0;
        foreach (var element in this)
            if (element is Student student)
                if (student.Group.Contains(groupName))
                    counter += 1;

        return counter;
    }
}