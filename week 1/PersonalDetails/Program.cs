namespace PersonalDetails
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO 1: declare one variable per detail.
            //         Text uses string, a whole number uses int.
            //         The first one is done for you.
            string name = "Bipeen Baral";


            // TODO 2: declare a variable for the address, contact number,
            //         email, college, course, and year of study.
            string address = "Lekhnath, Kaski, Nepal";
            string contactNumber = "9816159535";
            string email = "bipeenbaral@example.com";
            string college = "ICP";
            string course = "BIT";
            int yearOfStudy = 2;

            // TODO 3: print a heading line, then one labelled line per detail.
            //         The first two are done for you as a model.
            Console.WriteLine("========== Personal Details ==========");
            Console.WriteLine($"Name          : {name}");
            Console.WriteLine($"Address           : {address}");
            Console.WriteLine($"Contact Number    : {contactNumber}");
            Console.WriteLine($"Email             : {email}");
            Console.WriteLine($"College           : {college}");
            Console.WriteLine($"Course            : {course}");
            Console.WriteLine($"Year of Study     : {yearOfStudy}");

            // TODO 4: print a line for every remaining detail.
        }
    }
}
