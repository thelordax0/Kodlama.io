using Business.Concretes;
using Entities.Concretes;

var categoryManager = new CategoryManager();
categoryManager.Create(new Category() { Name = "web" });

var courseManager = new CourseManager();
courseManager.Create(new Course() { Name = "web" });
var instructorManager = new InstructorManager();
var instructors = instructorManager.GetAll();
System.Console.WriteLine(instructors);