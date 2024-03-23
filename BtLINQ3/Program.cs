using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtLINQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            List<Position> positions = new List<Position>();
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.Write("Nhap ten phong ban( done de ket thuc): ");
                string departmentName = Console.ReadLine();
                if (departmentName.ToLower() == "done")
                    break;
                Console.Write("Nhap mo ta phong ban: ");
                string departmentDescription = Console.ReadLine();
                departments.Add(new Department(departmentName, departmentDescription));
            }

            while (true)
            {
                Console.Write("Nhap vi tri cong viec (done de ket thuc): ");
                string positionTitle = Console.ReadLine();
                if (positionTitle.ToLower() == "done")
                    break;
                Console.Write("Nhap mo ta vi tri cong viec: ");
                string positionDescription = Console.ReadLine();
                positions.Add(new Position(positionTitle, positionDescription));
            }

            while (true)
            {
                Console.Write("Nhap ten nhan vien (done de ket thuc): ");
                string employeeName = Console.ReadLine();
                if (employeeName.ToLower() == "done")
                    break;
                Console.Write("Nhap tuoi nhan vien: ");
                int employeeAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Danh sach phong ban:");
                for (int i = 0; i < departments.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {departments[i].Name}");
                }
                Console.Write("Chon phong ban cho nhan vien: ");
                int departmentChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                Department selectedDepartment = departments[departmentChoice];

                Console.WriteLine("Danh sach vi tri cong viec:");
                for (int i = 0; i < positions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {positions[i].Title}");
                }
                Console.Write("Chon vi tri cong viec cho nhan vien: ");
                int positionChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                Position selectedPosition = positions[positionChoice];

                employees.Add(new Employee(employeeName, employeeAge, selectedPosition, selectedDepartment));
            }

            List<Employee> Search(string keyword, int minAge, int maxAge, string position, string department)
            {
                List<Employee> results = new List<Employee>();
                foreach (var employee in employees)
                {
                    if ((keyword.ToLower() == employee.Name.ToLower() ||
                         keyword.ToLower() == employee.Position.Title.ToLower() ||
                         keyword.ToLower() == employee.Department.Name.ToLower() ||
                         keyword.ToLower() == employee.Position.Description.ToLower() ||
                         keyword.ToLower() == employee.Department.Description.ToLower()) &&
                         minAge <= employee.Age && employee.Age <= maxAge &&
                         (position == null || position.ToLower() == employee.Position.Title.ToLower()) &&
                         (department == null || department.ToLower() == employee.Department.Name.ToLower()))
                    {
                        results.Add(employee);
                    }
                }
                return results;
            }

            Console.Write("Tu khoa tim kiem: ");
            string keyword = Console.ReadLine();
            Console.Write("Tuoi tu: ");
            int minAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Den tuoi: ");
            int maxAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vi tri (de trong neu khong muon tim theo vi tri): ");
            string searchPosition = Console.ReadLine();
            Console.Write("Phong ban (de trong neu khong muon tim theo phong ban): ");
            string searchDepartment = Console.ReadLine();

            List<Employee> searchResults = Search(keyword, minAge, maxAge, searchPosition, searchDepartment);
            Console.WriteLine("Ket qua tim kiem:");
            if (searchResults.Count > 0)
            {
                foreach (var employee in searchResults)
                {
                    Console.WriteLine($"Ten: {employee.Name}, Tuoi: {employee.Age}, Vi tri: {employee.Position.Title}, Phong ban: {employee.Department.Name}");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay ket qua nao.");
            }
        }
    }
}
