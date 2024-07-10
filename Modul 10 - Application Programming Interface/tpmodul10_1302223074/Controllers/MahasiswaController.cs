using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223074.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Jeremy Mathew Fabian Sitepu", "1302220143"),
        new Mahasiswa(" Puri Lalita Anagata", "1302223019"),
        new Mahasiswa(" Alvan Marvianto", "1302223074"),
        new Mahasiswa(" Muhammad Fajar Mufid" , "1302223032"),
        new Mahasiswa(" Aaron Joseph Daimbani", "1302223083"),
        new Mahasiswa(" Yazid Al Ghazali", "1302223047")
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}