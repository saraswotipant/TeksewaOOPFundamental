// File - Reports.cs

internal class Reports
{
	static List<Trainee> trainees = [
        new("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
        new("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
	];
		
	public static void LetsQuery()
	{

		// Get all trainees grouped by their college
		
        Console.WriteLine("Trainees grouped by College:");

         var traineeGroupedByCollege = trainees.GroupBy(t => t.college);
            foreach (var traineeGroup in traineeGroupedByCollege)
            {
                Console.WriteLine($"College: {traineeGroup.Key}");
                foreach (var trainee in traineeGroup)
                {
                    Console.WriteLine($"Name: {trainee.name}");
                }
            }
            Console.WriteLine();
            

		// Get name and age of trainees who are on their teens
		
         Console.WriteLine("Name and age of trainees on their teens:");

            var teens = trainees
                .Select(t => new { Name = t.name, Age = t.CalculateAge()})
                .Where(teens => teens.Age.Item2 / 365 >= 13 && teens.Age.Item2 /365 <= 19);
            foreach (var teen in teens)
            {
                Console.WriteLine($"{teen.Name}, Age: {teen.Age.Item1}");
            }
            Console.WriteLine();


		// Get name initial, age and academic program of trainees and order result by initials
		
           Console.WriteLine("Trainees Ordered by Initials:");
            var traineeOrderByInitials = trainees
                .Select(t => new { Initials = t.GetInitials(), Age = t.CalculateAge().Item1, Program = t.program})
                .OrderBy(t => t.Initials);
            
            foreach (var trainee in traineeOrderByInitials)
            {
                Console.WriteLine($"{trainee.Initials}=> Age: {trainee.Age}, Program: {trainee.Program}");
            }


	}
}