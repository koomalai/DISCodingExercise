namespace DISCodingExercise.Models
{
    public class PaySummaryRecord
    {
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string EarningsCode { get; set; }
        public decimal TotalHours { get; set; }
        public double TotalPayAmount { get; set; }
        public double RateOfPay { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }
    }
}
