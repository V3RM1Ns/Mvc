using Microsoft.AspNetCore.Mvc;

using PracticeApp.Models;
using PracticeApp.ViewModels;

namespace Practice.Data.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student
            {
                Id = 5,
                Name = "Ayşe Kaya",
                Age = 22,
                Email = "ayse.kaya@istanbul.edu.tr",
                Address = "Kadıköy Mahallesi, İstanbul",
                PhoneNumber = "0532-987-6543",
            };

            Group group = new Group
            {
                Id = 3,
                Name = "Yazılım Mühendisliği",
                Description = "Modern yazılım geliştirme teknikleri ve metodolojileri üzerine odaklanan öğrenci grubu",
                Students = new List<Student> { student }
            };

            HomeVm homeVm = new HomeVm
            {
                Student = student,
                Group = group
            };

            ViewData["Message"] = "Yazılım Dünyasına Hoş Geldiniz!";
            ViewBag.WelcomeMessage = "Merhaba, bu modern ASP.NET Core MVC teknolojilerini gösteren gelişmiş bir uygulamadır.";
            TempData["TempMessage"] = "Yeni özellikler yakında geliyor - takipte kalın!";

            ViewBag.Students = new List<Student>()
            {
                student,
                new Student
                {
                    Id = 7,
                    Name = "Mehmet Özkan",
                    Age = 24,
                    Email = "mehmet.ozkan@bogazici.edu.tr",
                    Address = "Beşiktaş, İstanbul",
                    PhoneNumber = "0505-123-4567"
                },
                new Student
                {
                    Id = 9,
                    Name = "Zeynep Demir",
                    Age = 21,
                    Email = "zeynep.demir@metu.edu.tr",
                    Address = "Çankaya, Ankara",
                    PhoneNumber = "0543-789-0123"
                },
                new Student
                {
                    Id = 12,
                    Name = "Can Yılmaz",
                    Age = 23,
                    Email = "can.yilmaz@ege.edu.tr",
                    Address = "Bornova, İzmir",
                    PhoneNumber = "0533-456-7890"
                },
                new Student
                {
                    Id = 15,
                    Name = "Elif Şahin",
                    Age = 20,
                    Email = "elif.sahin@hacettepe.edu.tr",
                    Address = "Sıhhiye, Ankara",
                    PhoneNumber = "0542-654-3210"
                }
            };

            ViewBag.Groups = new List<Group>()
            {
                group,
                new Group
                {
                    Id = 5,
                    Name = "Veri Bilimi",
                    Description = "Büyük veri analizi, makine öğrenmesi ve yapay zeka konularında uzmanlaşan grup"
                },
                new Group
                {
                    Id = 8,
                    Name = "Siber Güvenlik",
                    Description = "Bilgi güvenliği, etik hacking ve ağ güvenliği üzerine çalışan öğrenci topluluğu"
                },
                new Group
                {
                    Id = 11,
                    Name = "Mobil Uygulama Geliştirme",
                    Description = "iOS, Android ve cross-platform mobil uygulama geliştirme odaklı grup"
                }
            };

            return View(homeVm);
        }
    }
}
