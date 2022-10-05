using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGG_Model
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public int PriorityLevel { get; set; }
        public string Branch { get; set; }
    }
}
