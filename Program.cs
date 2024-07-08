// See https://aka.ms/new-console-template for more information
using Json_Serailizer_Using_Recursion_and_Reflection;
using JsonFormattingAssignment;

Course course = new Course();
course.Title = "Asp.net";
course.Fees = 30000;
course.Teacher = new Instructor()
{
    Name = "Jalaluddin",
    Email = "jalal@example.com",
    PresentAddress = new Address() { Street = "123 Main St", City = "City", Country = "Country" },
    PermanentAddress = new Address() { Street = "456 Second St", City = "City", Country = "Country" },
    PhoneNumbers = new List<Phone>()
            {
                new Phone() { Number = "123456789", Extension = "101", CountryCode = "+1" },
                new Phone() { Number = "987654321", Extension = "102", CountryCode = "+1" }
            }
};
course.Topics = new List<Topic>()
        {
            new Topic()
            {
                Title = "Introduction to ASP.NET",
                Description = "Introduction to ASP.NET MVC",
                Sessions = new List<Session>()
                {
                    new Session() { DurationInHour = 2, LearningObjective = "Understanding MVC architecture" },
                    new Session() { DurationInHour = 3, LearningObjective = "Working with controllers and views" }
                }
            },
            new Topic()
            {
                Title = "Advanced ASP.NET",
                Description = "Advanced ASP.NET MVC concepts",
                Sessions = new List<Session>()
                {
                    new Session() { DurationInHour = 2, LearningObjective = "Implementing authentication and authorization" },
                    new Session() { DurationInHour = 3, LearningObjective = "Handling security and performance" }
                }
            }
        };
course.Tests = new List<AdmissionTest>()
        {
            new AdmissionTest() { StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(31), TestFees = 50 },
            new AdmissionTest() { StartDateTime = DateTime.Now.AddDays(35), EndDateTime = DateTime.Now.AddDays(36), TestFees = 60 }
        };

string json = JsonFormatter.Convert(course);
Console.WriteLine(json);
