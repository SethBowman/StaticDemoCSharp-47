namespace StaticDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var twoPlusTWO = MathHelper.Add(2, 2);

            var roomOne = new Classroom();
            roomOne.Teacher = "Seth";

            Classroom.Subject = "C#";

            Console.WriteLine(Classroom.Subject);

            var roomTwo = new Classroom();
            roomTwo.Teacher = "Mack";

            Classroom.Subject = "Java";

            Console.WriteLine(Classroom.Subject);

        }
    }
}
