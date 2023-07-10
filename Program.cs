namespace EmployeeeWage;
class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int Emp_Rate_hr = 20;
    public const int Num_Days = 20;
    public const int Max_Working_Hrs_Month = 100;

    static void Main(string[] args)
    {
        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalEmpWage = 0;
        int totalWorkingDays = 0;

        while (totalEmpHrs <= Max_Working_Hrs_Month && totalWorkingDays < Num_Days)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

                    totalEmpWage += empHrs;
                    Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
        totalEmpWage = totalEmpHrs * Emp_Rate_hr;
        Console.WriteLine("Total emp wage : " + totalEmpWage);
    }
}
