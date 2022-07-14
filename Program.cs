namespace EmployeeManagement
{
    class Program
    {
        //The method is checking the Employee is Present or Absent
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empChk = random.Next(2);

            if (empChk == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }     
    }
}