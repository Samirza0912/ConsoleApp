using System;
using System.Collections.Generic;
using System.Text;
using Business.Services;
using Entities.Models;
using Utilities.Helper;

namespace AcademyApp.Controllers
{
    class StudentController
    {
        GroupService groupService = new GroupService();
        StudentService studentService { get; set; }
        
        public StudentController()
        {
            studentService = new StudentService();
        }
        public void CreateStudent()
        {
        EnterName:
            Extention.Print(ConsoleColor.Green, $"Student Name");
            string name = Console.ReadLine();
            bool isSize = false;
            if (isSize)
            {
                Student student = new Student
                {
                    Name = name,
                    
                };

                studentService.Create(student);
                Extention.Print(ConsoleColor.Green, $"{student.Name} created");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Enter the correct one");
                goto EnterName;
            }
        }
        public void GetAllStudents()
        {
            foreach (var item in studentService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveStudent()
        {
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{studentService.Delete(id).Name}");
        }
    }
}
