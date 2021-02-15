using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowController : ControllerBase
    {
        BinaryFormatter formet = new BinaryFormatter();
        // GET: api/Window
        [HttpGet]
        public ActionResult<Window> GetWindow()
        {
            using (FileStream file = new FileStream("Windows.dat", FileMode.OpenOrCreate))
            {
                if (file.Length != 0)
                {
                    return (ActionResult<Window>)formet.Deserialize(file);
                }
                return null;

            }
        }

        // GET: api/Window/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Window
        [HttpPost]
        public ActionResult<Window> PostWindow([FromBody] Window window)
        {
            using (FileStream file = new FileStream("Window.dat", FileMode.OpenOrCreate))
            {
                formet.Serialize(file, window);
            }
            return Ok(window);
        }

        // PUT: api/Window/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
