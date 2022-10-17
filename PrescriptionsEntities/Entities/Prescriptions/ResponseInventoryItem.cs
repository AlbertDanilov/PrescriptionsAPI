using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfarm.DAL.Entities.Prescriptions
{
    public class ResponseInventoryItem
    {
        public decimal amount { get; set; }
        public DateTime expirationDate { get; set; }
        public string doseView { get; set; }
        public int mnnCode { get; set; }
        public string mnnName { get; set; }
        public int trnCode { get; set; }
        public string trnName { get; set; }
        public int lfCode { get; set; }
        public string lfName { get; set; }
    }

    public class ResponseInventory
    {
        public List<ResponseInventoryItem> items { get; set; }
    }
}
