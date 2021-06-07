using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Subject { get; set; }
    }
}
