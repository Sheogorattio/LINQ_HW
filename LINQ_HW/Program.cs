using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CompanyClass;

namespace LINQ_HW
{
    internal class Program
    {
        //  ВНИМАНИЕ!!!
        //  НЕ ОСОБО ВДАВАЛСЯ В АБСТРАКЦИЮ ПРИ НАИСАНИИ МЕТОДОВ
        //  ЗАДАНИЕ ДЛЯ ОТРАБОТКИ LINQ
        //  ЗАДАВАТЬСЯ ВОПРОСАМИ АБСТРАКЦИИ БЫЛО БЫ БЕСПОЛЕЗНОЙ ТРАТОЙ ВРЕМЕНИ 
        //  СПАСИБО ЗА ПОНИМАНИЕ
        static void Main(string[] args)
        {
        }
        public static IEnumerable<Company> GetCompanyInfo(Company[] arr)
        {
            return from i in arr
                   select i;
         
        }

        public static IEnumerable<Company> GetFood(Company[] arr)
        {
            Regex r = new Regex(@".|\w{0,}Food(.|\w{0,})");
            return from i in arr
                   where r.IsMatch(i.Name) == true
                   select i;
        }

        public static IEnumerable<Company> GetMarketing(Company[] arr)
        {
            return from i in arr
                   where i.MainActivity == "Marketing"
                   select i;
        }
        public static IEnumerable<Company> GetMarketingAndIT(Company[] arr)
        {
            return from i in arr where i.MainActivity == "Marketing" || i.MainActivity == "IT" select i;
        }
        public static IEnumerable<Company> GetMore100Employee(Company[] arr)
        {
            return from i in arr where i.EmployeeNumber>100 select i;
        }
        public static IEnumerable<Company> GetFrom100To300Emplye(Company[] arr)
        {
            return from i in arr where i.EmployeeNumber > 100 && i.EmployeeNumber < 300 select i; 
        }
        public static IEnumerable<Company> GetLondon(Company[] arr) 
        {
            return from i in arr where i.Addr.City == "London" select i;
        }
        public static  IEnumerable<Company> GetWhiteDir(Company[] arr)
        {
            return from i in arr where i.Director.Surname == "White" select i;
        }
        public static IEnumerable<Company> GetWhiteBlack(Company[] arr)
        {
            Regex r = new Regex(@".|\w{0,}Black(.|\w){0,}");
            return from i in arr where r.IsMatch(i.Name) == true && i.Director.Surname == "Black" select i;
        }
        public static IEnumerable<Company> More2Years(Company[] arr)
        {
            return from i in arr where DateTime.Now.Ticks - i.EstablishmentDate.Ticks > new DateTime(2,0,0).Ticks select i;
        }


        public static IEnumerable<Company> _GetFood(Company[] arr)
        {
            return arr.Where(i => i.Name.Contains("Food") == true);
        }
        public static IEnumerable<Company> _GetMarketing(Company[] arr)
        {
            return arr.Where(i => i.MainActivity.Equals("Marketing"));
        }
        public static IEnumerable<Company> _GetMarketingAndIT(Company[] arr)
        {
            return arr.Where(i => i.MainActivity.Equals("Marketing") || i.MainActivity.Equals("IT"));
        }
        public static IEnumerable<Company> _GetMore100Employee(Company[] arr)
        {
            return arr.Where(i => i.EmployeeNumber > 100);
        }
        public static IEnumerable<Company> _GetFrom100To300Emplye(Company[] arr)
        {
            return arr.Where(i => i.EmployeeNumber > 100 && i.EmployeeNumber < 300);
        }
        public static IEnumerable<Company> _GetLondon(Company[] arr)
        {
            return arr.Where(i => i.Addr.City.Equals("London"));
        }
    }

   
}
