

using System.Collections;
using Domain;
using Infrastructure;

var student1=new Student();
student1.Id=1;
student1.FirstName="Alijon";
student1.LastName="Sattorov";
student1.BirthDate=new (2002,04,17);
student1.Address="District Hamadoni";

var student2=new Student();
student2.Id=2;
student2.FirstName="Mansur";
student2.LastName="Azamzoda";
student2.BirthDate=new (2006,01,01);
student2.Address="District Sino";



var studentservice=new StudentService();

studentservice.AddStudent(student1);
studentservice.AddStudent(student2);

foreach (var item in studentservice.GetStudent())
{
    System.Console.WriteLine();
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine("   Id : "+item.Id);
    System.Console.WriteLine("   FirstName : "+item.FirstName);
    System.Console.WriteLine("   LastName  : "+item.LastName);
    System.Console.WriteLine("   BirthDate : "+item.BirthDate);
    System.Console.WriteLine("   Address   : "+item.Address);
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine();
}




var teacher1=new Teacher();
teacher1.Id=1;
teacher1.FirstName="Alijon";
teacher1.LastName="Zabirov";
teacher1.Position="backend, C#, .Net";
teacher1.ExperienceAmount=2;

var teacher2=new Teacher();
teacher2.Id=2;
teacher2.FirstName="Muhammadjon";
teacher2.LastName="Mirzoev";
teacher2.Position="backend, C++";
teacher2.ExperienceAmount=3;



var teacherservice=new TeacherService();

teacherservice.AddTeacher(teacher1);
teacherservice.AddTeacher(teacher2);

foreach (var item in teacherservice.GetTeacher())
{
    System.Console.WriteLine();
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine("   Id : "+item.Id);
    System.Console.WriteLine("   FirstName : "+item.FirstName);
    System.Console.WriteLine("   LastName  : "+item.LastName);
    System.Console.WriteLine("   Position  : "+item.Position);
    System.Console.WriteLine("   ExperienceAmount   : "+item.ExperienceAmount);
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine();
}





var course1=new Course();
course1.Id=1;
course1.Title="C++";
course1.Description="Davomnokii kurs yak moh, darsho dar yak hafta 6-ruz,bali guzarish az kurs ba kursi digar az 85 bolo ";
course1.Fee=1000;
course1.HasDiscount=true;

var course2=new Course();
course2.Id=2;
course2.Title="C#";
course2.Description="Davomnokii kurs yak moh, darsho dar yak hafta 6-ruz,bali guzarish az kurs ba kursi digar az 85 bolo ";
course2.Fee=1500;
course2.HasDiscount=true;



var courseservice=new CourseService();

courseservice.AddCourse(course1);
courseservice.AddCourse(course2);

foreach (var item in courseservice.GetCourse())
{
    System.Console.WriteLine();
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine("   Id : "+item.Id);
    System.Console.WriteLine("   Title : "+item.Title);
    System.Console.WriteLine("   Description  : "+item.Description);
    System.Console.WriteLine("   Fee  : "+item.Fee);
    System.Console.WriteLine("   HasDiscount   : "+item.HasDiscount);
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine();
}



var post1=new Post();
post1.Id=1;
post1.Title="C++";
post1.Description="Davomnokii kurs yak moh, darsho dar yak hafta 6-ruz,bali guzarish az kurs ba kursi digar az 85 bolo ";
post1.VoteAmount=100;
post1.CreatedAt=new(2024,02,25);

var post2=new Post();
post2.Id=2;
post2.Title="C#";
post2.Description="Davomnokii kurs yak moh, darsho dar yak hafta 6-ruz,bali guzarish az kurs ba kursi digar az 85 bolo ";
post2.VoteAmount=150;
post2.CreatedAt=new(2024,02,26);



var postservice=new PostService();

postservice.AddPost(post1);
postservice.AddPost(post2);

foreach (var item in postservice.GetPost())
{
    System.Console.WriteLine();
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine("   Id : "+item.Id);
    System.Console.WriteLine("   Title : "+item.Title);
    System.Console.WriteLine("   Description  : "+item.Description);
    System.Console.WriteLine("   VoteAmount  : "+item.VoteAmount);
    System.Console.WriteLine("   CreatedAt   : "+item.CreatedAt);
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine();
}