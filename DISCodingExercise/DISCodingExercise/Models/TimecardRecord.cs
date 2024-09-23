namespace DISCodingExercise.Models
{
    public class TimecardRecord
    {
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime DateWorked {get; set;}
        public string EarningsCode { get; set; }
        public decimal Hours { get; set; }
        public double Rate { get; set; }
        public decimal Bonus { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }
    }
}
