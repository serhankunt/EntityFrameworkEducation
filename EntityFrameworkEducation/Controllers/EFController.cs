using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFController : ControllerBase
    {
        DenemeContext context = new();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            //crud
            //create ==> .add
            //read ==> LINQ ile
            //update ==> .update
            //delete ==> .remove
            var result = context.SimpleTables.ToList();
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            context.SimpleTables.Add(simpleTable);
            context.SaveChanges();

            return Ok("Kayıt işlemi EntityFramework ile başarıyla tamamlandı");
        }

        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable)
        {
            context.SimpleTables.Update(simpleTable);
            context.SaveChanges();

            return Ok("Ef ile güncelleme gerçekleştirildi.");
        }
        [HttpPost("[action]")]
        public IActionResult Delete(SimpleTable simpleTable)
        {
            context.SimpleTables.Remove(simpleTable);
            context.SaveChanges();

            return Ok("Ef ile silme işlemi gerçekleştirildi.");
        }
        //ORM ==> Entity Framework =>T-SQL
        [HttpPost("[action]")]
        public IActionResult DeleteRange(SimpleTable[] simpleTables)
        {
            context.SimpleTables.RemoveRange(simpleTables);
            context.SaveChanges();

            return Ok("Ef ile range silme işlemi gerçekleştirildi.");
        }
    }
}
