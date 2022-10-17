using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfarm.DAL.Entities.Prescriptions
{
    public class ResponseDivisionItem
    {
        public int divisionCode { get; set; }
        public int divisionParentCode { get; set; }
        public string divisionName { get; set; }
    }

    public class ResponseDivision 
    {
        public List<ResponseDivisionItem> items { get; set; }
    }
}
