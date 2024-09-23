using DISCodingExercise.Models;

namespace DISCodingExercise.PayInformation
{
    public class PayInformation
    {
        public List<PaySummaryRecord> Summarize_Pay_Info(List<TimecardRecord> timecard, List<RateTableRow> rateTable)
        {
            List<PaySummaryRecord> result = new List<PaySummaryRecord>();

            var groupedTimeCard = timecard.GroupBy(time => new { time.EmployeeNumber, time.EarningsCode, time.Dept, time.Job });

            foreach (var group in groupedTimeCard) {
                var timeCardRecord = group.ToList();
                var firstRecord = timeCardRecord.First();

                var rateInfo = rateTable.FirstOrDefault(rate =>
                   rate.Job == firstRecord.Job &&
                   rate.Dept == firstRecord.Dept &&
                   rate.EffectiveStart <= firstRecord.DateWorked &&
                   rate.EffectiveEnd >= firstRecord.DateWorked 
                );

                var rateUsed = rateInfo?.HourlyRate ?? 0;
                decimal totalHours = 0;
                double totalPayAmount = 0;

                foreach (var record in timeCardRecord) { 
                    if(record.Rate > rateUsed)
                    {
                        rateUsed = record.Rate;
                    }

                    double payAmount;

                    switch (record.EarningsCode) {
                        case "Regular":
                            payAmount = rateUsed * (double)record.Hours;
                            break;
                        case "Overtime":
                            payAmount = (rateUsed*1.5) * (double)record.Hours;
                            break;
                        case "Double Time":
                            payAmount = (rateUsed * 2) * (double)record.Hours;
                            break;
                        default:
                            payAmount = 0;
                            break;
                    }

                    //Add bonus where applicable
                    payAmount = payAmount+(double)record.Bonus;
                    //Add and calculate Total Hours
                    totalHours = totalHours+record.Hours;
                    //Total pay amount
                    totalPayAmount = totalPayAmount+payAmount;
                }

                result.Add(new PaySummaryRecord
                {
                    EmployeeName = firstRecord.EmployeeName,
                    EmployeeNumber = firstRecord.EmployeeNumber,
                    EarningsCode = firstRecord.EarningsCode,
                    TotalHours = totalHours,
                    TotalPayAmount = totalPayAmount,
                    RateOfPay = rateUsed,
                    Job = firstRecord.Job,
                    Dept = firstRecord.Dept
                });
            }
            return result;
        }
    }
}
