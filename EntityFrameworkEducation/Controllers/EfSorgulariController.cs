using EntityFrameworkEducation.Dtos;
using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfSorgulariController : ControllerBase
    {
        DenemeContext context = new DenemeContext();
        [HttpGet("[action]")]
        public IActionResult GetList()
        {

            //var products = context.Products.ToList();

            //var enPahaliUrunFiyati = context.Products.Max(p => p.Price);
            //var enPahaliUrun = context.Products.OrderByDescending(p => p.Price).FirstOrDefault();

            //var enUcuzUrunFiyati = context.Products.Min(p => p.Price);
            //var enUcuzUrun = context.Products.OrderBy((p) => p.Price).FirstOrDefault();

            //var list = context.Products.ToArray();

            //var list2 = context.Products.AsQueryable();

            //var result = context.Products.AsQueryable();
            //var result = from product in context.Products.Where(p=> p.Id ==4) //"context" nesnesi EF tarafından sağlanan DBContext sınıfından türetilmiş bir nesnedir.
            //             //context.Products ve context.Categories SQL'de Products ve Categories tablolarına ulaşmamızı sağlar.
            //             join category in context.Categories on product.CategoryId equals category.Id
            //             //SQL'deki iki tabloyu CategoryId üzerinden birleştirir.
            //             where product.Id ==4 && category.Name == "Taner"
            //             select new ProductDto
            //             {
            //                 Id = product.Id,
            //                 CategoryId = product.CategoryId,
            //                 CategoryName = category.Name,
            //                 Name = product.Name,
            //                 Price = product.Price,
            //                 Total = product.Price * 100,

            //             };

            //var result = context.Products.SingleOrDefault(p => p.Id == 4);
            var result = context.Products.Find(4);

            return Ok(result);
            

            //return Ok(enPahaliUrun);
            //return Ok(enPahaliUrunFiyati);





            
        }

        // List ,IList, IEnumarable,IQueryable
        //List<string> liste = new List<string>();
        //liste.Add("deneme");

        //IList<string> liste = new List<string>();
        //liste.Add("deneme");

        //IEnumerable<string> list = new List<string>();//Listeye add metodunu çağıramayız.Listede okuma işlemi yapılabiliyor.Db den veri çekip sorgulayabiliyoruz

        //IQueryable<string> list = new List<string>();//Ekleme,silme işlemleri yapılamaz.


        //IQueryable<SimpleTable> result = context.SimpleTables.AsQueryable();
        //result.Where(p => p.Id == 1 && p.Name =="Taner");

        //IEnumerable<SimpleTable> result2 = context.SimpleTables.ToList();
        //result2.Where(p => p.Id == 1 && p.Name.Contains("Taner"));

        //List<SimpleTable> result3 = context.SimpleTables.ToList();
        //result3.Where(p => p.Id == 1);

        //var result4 = context.SimpleTables.ToList().Where(p=> p.Id ==6).FirstOrDefault();
        //var result5 = context.SimpleTables.ToList().Where(p=> p.Id ==6).SingleOrDefault();
        //var result6 = context.SimpleTables.FirstOrDefault(p => p.Id == 6);
        //var result7 = context.SimpleTables.SingleOrDefault(p => p.Id == 6);

        //foreach(var item in result3)
        //{
        //    string name2 = item.Name;
        //}

        //string name = result3[1].Name;

        //var result8 = context.SimpleTables.SingleOrDefault(p=>p.Id == 6).Name;
        //var result9 = context.SimpleTables.ToList().Where(p => p.Id == 6).Select(p => p.Name).SingleOrDefault();

        //var result10 = context.SimpleTables.ToList().Where(p => p.Name.Contains("a")).Take(5);//a harfi olan ilk 5 kayıtı getir
        //var result11 = context.SimpleTables.ToList().Where(p => p.Name.Contains("a")).OrderBy(p=>p.Id).Take(5);//Sıraladıktan sonra ilk 5 kaydı getirir.
        //var result12 = context.SimpleTables.ToList().Where(p=>p.Name.Contains("a")).OrderByDescending(p=>p.Id).Take(5);//Idsi en büyük yukarı gelir. Bu sayede tersten 5 kayıta ulaşmış oluruz.
    }
}



/*List<T>:
List<T>, System.Collections.Generic namespace altında bulunan bir türdür ve genel olarak kullanılan bir koleksiyon türüdür. List, dinamik boyutlara sahip bir dizi (array) gibi davranır. Bu nedenle, içindeki öğeleri dinamik bir şekilde ekleyebilir, çıkarabilir ve güncelleyebilirsiniz.

IList<T>:
IList<T>, List<T>'nin bir interfacesidir. List<T> sınıfı, IList<T> arayüzünü uygular. Bu arayüz, koleksiyonun üzerinde döngülerle (loop) dolaşılmasını, öğe eklenmesini, çıkarılmasını, belirli bir konumda değiştirilmesini ve koleksiyonun boyutunu alınmasını sağlar.

IEnumerable<T>:
IEnumerable<T>, koleksiyonların üzerinde döngü (loop) dönmek için kullanılan bir interfacesidir. Bu arayüz, koleksiyonun üzerinde sıralı bir şekilde döngü yapmak için GetEnumerator() metodunu tanımlar. IEnumerable<T>, yalnızca koleksiyonlarda dolaşma yeteneği sağlar, ancak koleksiyon üzerinde değişiklik yapma yeteneği yoktur.

IQueryable<T>:
IQueryable<T>, LINQ (Language Integrated Query) sorgularını oluşturmak ve veritabanı sorgularını yürütmek için kullanılan bir interfacesidir. Bu arayüz, LINQ sorguları oluşturmanıza ve veritabanından veri çekmenize olanak tanır. IQueryable<T>, LINQ sorgularını optimize etmek ve veritabanında yürütmek için gerekli yöntemleri içerir.

Bu türler, Entity Framework veya genel olarak LINQ sorguları yazarken kullanabileceğiniz temel koleksiyon türleridir. List ve IList, bellekteki koleksiyonları temsil ederken, IEnumerable genellikle sorgu sonuçlarını temsil etmek için kullanılırken, IQueryable ise LINQ sorgularını yürütmek ve optimize etmek için kullanılır.*/