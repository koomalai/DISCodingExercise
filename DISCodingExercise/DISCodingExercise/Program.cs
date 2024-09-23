using DISCodingExercise.Models;
using DISCodingExercise.PayInformation;

public class PaySummaryMain
{
    public static void Main(string[] args)
    {
        List<TimecardRecord> records = new List<TimecardRecord>()
    {
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,01),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,02),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,03),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,04),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,05),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Kyle James",
            EmployeeNumber = "110011",
            DateWorked = new DateTime(2023,01,06),
            EarningsCode = "Regular",
            Job = "Labourer",
            Dept = "001",
            Hours = 8,
            Rate = 15.5,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,01),
            EarningsCode = "Regular",
            Job = "Scrapper",
            Dept = "002",
            Hours = 10,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,02),
            EarningsCode = "Regular",
            Job = "Scrapper",
            Dept = "002",
            Hours = 10,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,03),
            EarningsCode = "Regular",
            Job = "Scrapper",
            Dept = "002",
            Hours = 10,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,04),
            EarningsCode = "Regular",
            Job = "Scrapper",
            Dept = "004",
            Hours = 10,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,05),
            EarningsCode = "Overtime",
            Job = "Scrapper",
            Dept = "004",
            Hours = 6,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,06),
            EarningsCode = "Overtime",
            Job = "Scrapper",
            Dept = "002",
            Hours = 6,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Jane Smith",
            EmployeeNumber = "120987",
            DateWorked = new DateTime(2023,01,07),
            EarningsCode = "Double Time",
            Job = "Scrapper",
            Dept = "002",
            Hours = 5,
            Rate = 17.65,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Amy Penn",
            EmployeeNumber = "100002",
            DateWorked = new DateTime(2023,01,01),
            EarningsCode = "Regular",
            Job = "Foreman",
            Dept = "003",
            Hours = 8,
            Rate = 17.75,
            Bonus = 0
        },
        new TimecardRecord()
        {
            EmployeeName = "Amy Penn",
            EmployeeNumber = "100002",
            DateWorked = new DateTime(2023,01,02),
            EarningsCode = "Overtime",
            Job = "Foreman",
            Dept = "003",
            Hours = 5,
            Rate = 17.75,
            Bonus = 125
        },
        new TimecardRecord()
        {
            EmployeeName = "Amy Penn",
            EmployeeNumber = "100002",
            DateWorked = new DateTime(2023,01,03),
            EarningsCode = "Overtime",
            Job = "Foreman",
            Dept = "003",
            Hours = 5,
            Rate = 17.75,
            Bonus = 175
        }
    };

        List<RateTableRow> rate = new List<RateTableRow>()
    {
        new RateTableRow()
        {
           Job = "Labourer",
           Dept = "001",
           EffectiveStart = new DateTime(2023,1,1),
           EffectiveEnd = new DateTime(2024,1,1),
           HourlyRate = 18.75
        },
        new RateTableRow()
        {
           Job = "Labourer",
           Dept = "002",
           EffectiveStart = new DateTime(2023,1,1),
           EffectiveEnd = new DateTime(2024,1,1),
           HourlyRate = 17.85
        },
        new RateTableRow()
        {
           Job = "Scrapper",
           Dept = "001",
           EffectiveStart = new DateTime(2023,1,1),
           EffectiveEnd = new DateTime(2024,1,1),
           HourlyRate = 19.45
        },
        new RateTableRow()
        {
           Job = "Scrapper",
           Dept = "002",
           EffectiveStart = new DateTime(2023,1,3),
           EffectiveEnd = new DateTime(2024,1,3),
           HourlyRate = 20.55
        },
        new RateTableRow()
        {
           Job = "Scrapper",
           Dept = "003",
           EffectiveStart = new DateTime(2023,1,3),
           EffectiveEnd = new DateTime(2024,1,3),
           HourlyRate = 22.15
        },
        new RateTableRow()
        {
           Job = "Foreman",
           Dept = "001",
           EffectiveStart = new DateTime(2023,1,3),
           EffectiveEnd = new DateTime(2024,1,3),
           HourlyRate = 13.55
        },
        new RateTableRow()
        {
           Job = "Foreman",
           Dept = "002",
           EffectiveStart = new DateTime(2023,1,3),
           EffectiveEnd = new DateTime(2024,1,3),
           HourlyRate = 14.50
        },
        new RateTableRow()
        {
           Job = "Foreman",
           Dept = "003",
           EffectiveStart = new DateTime(2023,1,3),
           EffectiveEnd = new DateTime(2024,1,3),
           HourlyRate = 15.60
        },
    };

        var payInformation = new PayInformation();

        var paySummary = payInformation.Summarize_Pay_Info(records, rate);

        Console.WriteLine("Pay Summary:");
        foreach (var record in paySummary)
        {
            Console.WriteLine($"Employee: {record.EmployeeName}, Number: {record.EmployeeNumber}, " +
                              $"Job: {record.Job}, Dept: {record.Dept}, " +
                              $"Total Hours: {record.TotalHours}, Total Pay: {record.TotalPayAmount}, Rate of Pay: {record.RateOfPay}, Earnings Code: {record.EarningsCode}");
        }
    }
}



