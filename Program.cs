using System;
using System.Collections.Generic;

/**
Name: Cody Driver
Date of completion: 5/1/2020

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employeeNames = new string[10];
            int[] employeeDepartments = new int[10];
            double[] employeeSalary = new double[10];
            int[] employeeHours = new int[10];
            double[] grossSal = new double[10];

            string [] departmentNames = {"Personal", "Marketing", "Information Technology", "Computer Sciences", "Sales", "Legal", "Accounting" };
            double [] salaries = {0, 0, 0, 0, 0, 0, 0};

            int x = 0;

            string input = "0";

            while(input != "999"){
                
                Console.Write("Please enter Employee Name:  ");
                employeeNames[x] = Console.ReadLine();

                Console.WriteLine("1. Personal 2. Marketing 3. Information Technology, 4. Computer Sciences 5. Sales 6. Legal 7. Accounting" );
                Console.Write("Please enter your deparment number: ");
                employeeDepartments[x] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter your salary:  ");
                employeeSalary[x] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please Enter employee Hours: ");
                employeeHours[x] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter 0 to continue or 999 to quit:  ");
                string choice = Console.ReadLine();

                grossSal[x] = employeeSalary[x] * employeeHours[x];

                Console.WriteLine($"Employee Name: {employeeNames[x]} Department: {departmentNames[employeeDepartments[0] - 1]} Salary: {employeeSalary[0]} Gross Salary: {grossSal[x].ToString("c")}");

                if(choice == "999"){
                    input = "999";
                }else{
                    x=x+1;
                }
            }

            double [] departmentPayroll = new double [7];

            for(int e=0; e< employeeDepartments.Length; e++){
                if(employeeDepartments[e] == 1){
                    departmentPayroll[0] = departmentPayroll[0] + grossSal[e];
                }
                if(employeeDepartments[e] == 2){
                    departmentPayroll[1] = departmentPayroll[1] + grossSal[e];
                }
                if(employeeDepartments[e] == 3){
                    departmentPayroll[2] = departmentPayroll[2] + grossSal[e];
                }
                if(employeeDepartments[e] == 4){
                    departmentPayroll[3] = departmentPayroll[3] + grossSal[e];
                }
                if(employeeDepartments[e] == 5){
                    departmentPayroll[4] = departmentPayroll[4] + grossSal[e];
                }
                if(employeeDepartments[e] == 6){
                    departmentPayroll[5] = departmentPayroll[5] + grossSal[e];
                }
                if(employeeDepartments[e] == 7){
                    departmentPayroll[6] = departmentPayroll[6] + grossSal[e];
                }
            }
            Console.WriteLine($"Personnel Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Marketing Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Information Tech Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Computer Sciences Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Sales Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Legal Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Accounting Payroll: {departmentPayroll[0].ToString("c")}");

            }

        }  
    }



