using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfarm.DAL.Entities.Prescriptions
{
    public class RequestNewPrescription
    {
        public string mo { get; set; }                                              //  OID ЛПУ
        public string prescriptionId { get; set; }                                  //  Идентификатор назначения
        public List<Patient> patient { get; set; }                                  //  Информация о пациенте
        public string beginDate { get; set; }                                       //  Дата с
        public int introductionMetod { get; set; }                                  //  Классификатор способов введения лекарственных средств (НСИ)
        public string submissionCondition { get; set; }                             //  Условия введения назначения
        public List<Signa> signa { get; set; }                                      //  Периодичность выполнения назначения
        public int reiterationCount { get; set; }                                   //  Количество повторений
        public string signaText { get; set; }                                       //  Количество повторений
        public List<PrescriptionSpecItem> items { get; set; }                       //  Элементы назначения
        public List<PrescriptionExecuteElement> executeElements { get; set; }       //  Элементы выполнения назначения
    }

    public class RequestNewPrescriptionToSave 
    {
        public string mo { get; set; }                                              //  OID ЛПУ
        public string prescriptionId { get; set; }                                  //  Идентификатор назначения
        public string beginDate { get; set; }                                       //  Дата с
        public int introductionMetod { get; set; }                                  //  Классификатор способов введения лекарственных средств (НСИ)
        public string submissionCondition { get; set; }                             //  Условия введения назначения
        public int reiterationCount { get; set; }                                   //  Количество повторений
        public string signaText { get; set; }                                       //  Количество повторений
    }

    public class Patient
    {
        public string firstName { get; set; }       //  Имя
        public string lastName { get; set; }        //  Фамилия
        public string fatherName { get; set; }      //  Отчество
        public DateTime birthday { get; set; }      //  Дата рождения
        public int sex { get; set; }                //  Пол (1 – Мужской, 2 - Женский)
        public string snils { get; set; }           //  СНИЛС
        public string docSeries { get; set; }       //  Серия документа
        public string docNumber { get; set; }       //  Номер документа
        public string omsNumber { get; set; }       //  Номер полиса
        public string omsSerial { get; set; }       //  Серия полиса
        public string phone { get; set; }           //  Телефон
    }

    public class Signa
    {
        public string timeStart { get; set; }       //  Время начала приема (HH:mm)
        public string timeEnd { get; set; }         //  Время окончания приема (HH:mm)
        public int intervalType { get; set; }       //  Тип интервала (0 – день, 1 – неделя, 2 – по графику)
        public int Amount { get; set; }             //  Количество
        public int interval { get; set; }           //  Интервал
        public int daysOfWeek { get; set; }         //  Дни недели (справочник)
        public string name { get; set; }            //  Описание
    }

    public class PrescriptionSpecItem
    {
        public string prescriptionItemId { get; set; }      //  Идентификатор элемента
        public decimal dose { get; set; }                   //  Доза
        public int measurementUnitsCode { get; set; }       //  Код единиц измерения
        public string measurementUnitsName { get; set; }    //  Наименование единиц измерения
        public int measurementUnitsType { get; set; }       //  Тип единиц измеререния (справочник)
        public int mnnCode { get; set; }                    //  Код МНН
        public string mnnName { get; set; }                 //  Наименование МНН
        public int trnCode { get; set; }                    //  Код ТН
        public string trnName { get; set; }                 //  Наименование ТН
        public int lfCode { get; set; }                     //  Код ЛФ
        public string lfName { get; set; }                  //  Наименование ЛФ
    }

    public class PrescriptionExecuteElement
    {
        public string destinationExecuteElementID { get; set; }     //  Идентификатор
        public string declareDateTime { get; set; }                 //  Запланированная дата и время выполнения
    }
}
