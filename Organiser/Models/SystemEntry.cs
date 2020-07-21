using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiser.Models
{
    public class SystemEntry
    {
        //Will be static, so 0
        public int Id { get; set; }

        public DateTime LastDatabaseUpdate { get; set; }
    }
}
