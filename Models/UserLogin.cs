using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace EFCC.Models
{
    public class UserLogin
    {
        [BsonId (true)] public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
