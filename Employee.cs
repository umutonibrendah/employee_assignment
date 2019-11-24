using System;
					
public class Program
{
	public static void Main()
	{
		int employee_type;
		Console.WriteLine("Select type of employee:");
		Console.WriteLine("_________________________");
		Console.WriteLine("1.Montly Employee");
		Console.WriteLine("1.daily Employee");
		Console.WriteLine("1.One Time employee");
		
		employee_type = Convert.ToInt32(Console.ReadLine());
		
		if(employee_type==1){
		
		 MonhtlyEmployee emp = new  MonhtlyEmployee();
		 emp.salary_calc();
		
		}
	  else if(employee_type==2){
		
		 HourlyEmployee emp = new  HourlyEmployee();
		 emp.salary_calc();
		
		}
	 else if(employee_type==3){
		
		 OneTimeEmployee emp = new  OneTimeEmployee();
		 emp.salary_calc();
		
		}
		
		else {
		Console.WriteLine("Invalid choice");
	
	}
		
		
	}
	
	

	
}





class Employee{
	public int employee_id;
	public string employee_name;
	public string employee_position;
	public string employee_gender ;
	
	
	}

class MonhtlyEmployee : Employee{
	
	int gross_salry;
	int net_salary;
	
	 
	public void salary_calc(){
	int rssb;
	int insurance;
	int tax;
		
	Console.WriteLine("Enter montly salary");
		
	 MonhtlyEmployee emp = new  MonhtlyEmployee();
	 
    emp.gross_salry = Convert.ToInt32(Console.ReadLine());
		
	Console.WriteLine("Enter employee id");
	emp.employee_id = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter employee name");
	emp.employee_name = Console.ReadLine();
	Console.WriteLine("Enter employee position");
	emp.employee_position = Console.ReadLine();
	Console.WriteLine("Enter employee gender");
	emp.employee_gender = Console.ReadLine();
	
	tax= (emp.gross_salry*30)/100;
		
	rssb=  (emp.gross_salry*5)/100;
	insurance =(emp.gross_salry*3)/100;
	emp.net_salary=emp.gross_salry -(tax+rssb+insurance);
	Console.WriteLine("*********************************************");
	Console.WriteLine("Enter employee id is:"+ emp.employee_id);
	Console.WriteLine("Enter employee name is:" + emp.employee_name);
	Console.WriteLine("Enter employee gender is:" + emp.employee_gender);
	Console.WriteLine("Enter employee position is:" + emp.employee_position);
	Console.WriteLine("Enter employee net salary is:" + emp.net_salary);
	
	Console.WriteLine("*********************************************");
		
	}
	


}



class HourlyEmployee : Employee{
	
	int rate_per_hour;
	int num_of_hour;
	int gross_salry;
	int net_salary;
	
	 
	public void salary_calc(){
	int rssb;
	int insurance;
	HourlyEmployee emp = new  HourlyEmployee();
		
	Console.WriteLine("enter rate per hour:");
	emp.rate_per_hour = Convert.ToInt32(Console.ReadLine());
		
	
	Console.WriteLine("Enter number of hours:");
		
	
	 
    emp.num_of_hour = Convert.ToInt32(Console.ReadLine());
	emp.gross_salry=(emp.rate_per_hour*emp.num_of_hour);
		
	Console.WriteLine("Enter employee id");
	emp.employee_id = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter employee name");
	emp.employee_name = Console.ReadLine();
	Console.WriteLine("Enter employee position");
	emp.employee_position = Console.ReadLine();
	Console.WriteLine("Enter employee gender");
	emp.employee_gender = Console.ReadLine();
	
	
		
	rssb=  (emp.gross_salry*5)/100;
	insurance =(emp.gross_salry*3)/100;
	emp.net_salary=emp.gross_salry -(rssb+insurance);
	Console.WriteLine("*********************************************");
	Console.WriteLine("Enter employee id is:"+ emp.employee_id);
	Console.WriteLine("Enter employee name is:" + emp.employee_name);
	Console.WriteLine("Enter employee gender is:" + emp.employee_gender);
	Console.WriteLine("Enter employee position is:" + emp.employee_position);
	Console.WriteLine("Enter employee net salary is:" + emp.net_salary);
	
	Console.WriteLine("*********************************************");
		
	}
	


}

class OneTimeEmployee : Employee{
	
	int gross_salry;
	int net_salary;
	
	 
	public void salary_calc(){
	
	int tax;
		
	Console.WriteLine("Enter Gross salary");
		
	 OneTimeEmployee emp = new  OneTimeEmployee();
	 
    emp.gross_salry = Convert.ToInt32(Console.ReadLine());
		
	Console.WriteLine("Enter employee id");
	emp.employee_id = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter employee name");
	emp.employee_name = Console.ReadLine();
	Console.WriteLine("Enter employee position");
	emp.employee_position = Console.ReadLine();
	Console.WriteLine("Enter employee gender");
	emp.employee_gender = Console.ReadLine();
	
	tax= (emp.gross_salry*30)/100;
		
	
	emp.net_salary=emp.gross_salry -(tax);
	Console.WriteLine("*********************************************");
	Console.WriteLine("Enter employee id is:"+ emp.employee_id);
	Console.WriteLine("Enter employee name is:" + emp.employee_name);
	Console.WriteLine("Enter employee gender is:" + emp.employee_gender);
	Console.WriteLine("Enter employee position is:" + emp.employee_position);
	Console.WriteLine("Enter employee net salary is:" + emp.net_salary);
	
	Console.WriteLine("*********************************************");
		
	}
	


}

	



	