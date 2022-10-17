using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfarm.DAL.Entities.Prescriptions
{
    public class RequestPrescriptionStatus
    {
        public string prescriptionId { get; set; }      //  Идентификатор назначения
        public short statusId { get; set; }            //  Статус назначения
    }
}
