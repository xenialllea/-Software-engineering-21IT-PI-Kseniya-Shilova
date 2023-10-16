// See https://aka.ms/new-console-template for more information

namespace Laboratory_work_2;

internal static class Program
{
    private static void Main(string[] args)
    {
        var tarasov = new Tutor(
            "Тарасов Сергей Борисович",
            "29.09.2002",
            "12235"
        );
        var isacov = new Tutor(
            "Исаков Сергей Сергеевич",
            "28.02.2020",
            "12236"
        );
        var zorin = new Tutor(
            "Зорин Иван Андреевич",
            "25.08.2023",
            "12237"
        );
        var markasheva = new Tutor(
            "Маркашева Вера Алексеевна",
            "10.07.2018",
            "12238"
        );
        var kolotovkin = new Tutor(
            "Колотовкин Игорь Сергеевич ",
            "20.08.2019",
            "12239"
        );

        var zaychenko = new Student(
            "Зайченко Антон Викторович",
            "21it",
            "6656436463");

        var shilova = new Student(
            "Шилова Ксения Владимировна",
            "21it",
            "6656436464");

        var prokhortsev = new Student(
            "Прохорцев Андрей Владиславович",
            "21it",
            "6656436465");

        var sidorov = new Student(
            "Сидоров Игорь Викторович",
            "22it",
            "6656436466");

        var denisenko = new Student(
            "Денисенко Алексей Андреевич ",
            "23it",
            "6656436467");


        var list = new ListOfEmployees
            { tarasov, isacov, zorin, markasheva, kolotovkin, zaychenko, shilova, prokhortsev, sidorov, denisenko };
        Console.WriteLine("Общее количество преподавателей: " + list.TutorCount());
        Console.WriteLine("Количество студентов в группе 21it: " + list.GetStudentByGroup("21it"));
    }
}