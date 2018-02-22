using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DemoREST.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoREST.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /*
        [HttpGet]
        public IEnumerable<string> Get()
        {++————
            return new string[] { "value1", "value2" };
        }
        */
        [HttpGet]
        public Demo Get()
        {
            Demo result = new Demo();
            Dictionary<string, string> columnInfo = new Dictionary<string, string>();
            columnInfo.Add("title", "User Id");
            Dictionary<string, Dictionary<string, string>> column = new Dictionary<string, Dictionary<string, string>>();
            column.Add("userId", columnInfo);
            result.Columns = column;
            //columnInfo = new Dictionary<string, string>();
            List<RowData> datalist = new List<RowData>();
            RowData data;
            for (int i = 0; i < 2; i++)
            {
                data = new RowData();
                data.Id = i;
                data.UserId = "User" + i.ToString();
                data.Email = data.UserId + "@mail.com";
                datalist.Add(data);
            }
            result.Data = datalist;

            return result;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
