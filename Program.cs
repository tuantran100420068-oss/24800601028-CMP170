using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinhLinq
{
    public class Student
    {
        public int Id { get; set; }         
        public string Name { get; set; }     
        public int Age { get; set; }         

        public override string ToString()
        {
            return $"Id: {Id,-3} | Tên: {Name,-15} | Tuổi: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Anh",    Age = 15 },
                new Student { Id = 2, Name = "Ba",  Age = 17 },
                new Student { Id = 3, Name = "Ánh",   Age = 18 },
                new Student { Id = 4, Name = "Dung",  Age = 20 },
                new Student { Id = 5, Name = "Hà",   Age = 14 },
                new Student { Id = 6, Name = "Linh",  Age = 16 }
            };

        
            Console.WriteLine("a. Danh sách toàn bộ học sinh:");
            foreach (var s in students)
                Console.WriteLine(s);

          
            Console.WriteLine("\nb. Học sinh có tuổi từ 15 đến 18:");
            var from15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in from15to18)
                Console.WriteLine(s);

           
            Console.WriteLine("\nc. Học sinh có tên bắt đầu bằng chữ \"A\":");
            var startWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var s in startWithA)
                Console.WriteLine(s);

            
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nd. Tổng tuổi của tất cả học sinh: {totalAge}");

            
            Console.WriteLine("\ne. Học sinh có tuổi lớn nhất:");
            int maxAge = students.Max(s => s.Age);
            foreach (var s in students.Where(s => s.Age == maxAge))
                Console.WriteLine(s);

           
            Console.WriteLine("\nf. Danh sách sau khi sắp xếp theo tuổi tăng dần:");
            var sorted = students.OrderBy(s => s.Age);
            foreach (var s in sorted)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
