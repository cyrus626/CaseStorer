using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace EFCC.Models
{
    public class CaseFile
    {
        [BsonId(true)] public int Id { get; set; }
        public string Title { get; set; }
        public  string Description{ get; set; }
        public string DateSaved { get; set; }
    }
}
