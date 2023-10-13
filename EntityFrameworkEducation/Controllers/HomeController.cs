using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft;
using EntityFrameworkEducation.Models;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-L1BOF4K\\SQLEXPRESS;Database=Database1;Integrated Security=true;TrustServerCertificate=True");

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from SimpleTables", connection);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);

            var result = Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);

            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("insert into SimpleTables(Name) values('"+ simpleTable.Name +"')",connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Kayıt işlemi gerçekleştirildi.");
        }
        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("update SimpleTables set Name =@parametreName where Id=@parametreId",connection);
            command.Parameters.AddWithValue("@parametreName", simpleTable.Name);
            command.Parameters.AddWithValue("@parametreId", simpleTable.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close() ;
            return Ok("Güncelleme işlemi tamamlandı");

        }
        [HttpPost("[action]")]
        public IActionResult Delete(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("delete from SimpleTables where Id=@parametreId", connection);
            command.Parameters.AddWithValue("@parametreId", simpleTable.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Silme işlemi tamamlandı");

        }

    }
}
