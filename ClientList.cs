using System;
					
namespace clientList
{
	
	public struct Client
	{
		public String Name;
		public String PointOfContact;
		public String Telephone;
		public String Email;
		public String Website;
		public String Address1;
		public String Address2;
		public String City;
		public String Zip;
		public String ProjectName;
		public int DeadlineMonth;
		public int DeadlineYear;
		public int DeadlineDay;
	}
	
	public class List
	{
		public static void Main(string[] args)
		{
			int choice2, choice3, ClientCount;
			ClientCount=0;
			Client[] ClientList = new Client[500];
			do 
			{
				choice2=Funcs.PrintMenu();
				switch (choice2)
				{
					case 1:
						Console.WriteLine("In development...");
						break;
					case 2:
						ClientList[ClientCount].Name=Funcs.getName();
						ClientList[ClientCount].Address1=Funcs.getAddress1();
						ClientList[ClientCount].Address2=Funcs.getAddress2();
						ClientList[ClientCount].City=Funcs.getCity();
						ClientList[ClientCount].Zip=Funcs.getZip();
						ClientList[ClientCount].Telephone=Funcs.getPhone();
						ClientList[ClientCount].PointOfContact=Funcs.getPOC();
						Console.WriteLine("Does this client have a project with our organization?\n1. Yes \n2. No");
						choice3=int.Parse(Console.ReadLine());
						if (choice3==1)
						{
							ClientList[ClientCount].ProjectName = Funcs.getProject();
							ClientList[ClientCount].DeadlineMonth = Funcs.getDeadlineMonth();
							ClientList[ClientCount].DeadlineDay = Funcs.getDeadlineDay();
							ClientList[ClientCount].DeadlineYear = Funcs.getDeadlineYear();
						}
						else
						{
							ClientList[ClientCount].ProjectName = "N/A";
							ClientList[ClientCount].DeadlineYear = 0;
						}
								
						ClientCount++;
						break;
					case 3:
						Console.WriteLine("\nWhich client would you like to view?\n");
						
						for(int i=0; i<ClientCount; i++)
						{
							Console.WriteLine("{0}. {1}.", (i+1), ClientList[i].Name);
						}
						choice3 = int.Parse(Console.ReadLine());
						Console.WriteLine("Name: {0}", ClientList[choice3-1].Name);
						Console.WriteLine("Address: {0} {1} {2}, IN, {3}", ClientList[choice3-1].Address1, ClientList[choice3-1].Address2, ClientList[choice3-1].City, ClientList[choice3-1].Zip);
						Console.WriteLine("Telephone: {0}", ClientList[choice3-1].Telephone);
						Console.WriteLine("Point of Contact: {0}\n", ClientList[choice3-1].PointOfContact);
						break;
					case 4:
						Console.WriteLine("Thank you. Goodbye!");
						break;
				}
			} while (choice2 != 4);
		}
	}
	public class Funcs
	{
		public static int PrintMenu ()
		{
			Console.WriteLine("Welcome, please select a menu option.");
			Console.WriteLine("\t 1. UPCOMING DEADLINES.");
			Console.WriteLine("\t 2. ADD A NEW CLIENT.");
			Console.WriteLine("\t 3. PRINT CLIENT LIST.");
			Console.WriteLine("\t 4. EXIT.");
			int choice = int.Parse(Console.ReadLine());
			return choice;
		}
		public static String getName()
		{
			Console.WriteLine("Please enter the client's Name:");
			return Console.ReadLine();
		}
		public static String getAddress1()
		{
			Console.WriteLine("Please enter the client's address1:");
			return Console.ReadLine();
		}
		public static String getAddress2()
		{
			Console.WriteLine("Please enter the client's address2:");
			return Console.ReadLine();
		}
		public static String getCity()
		{
			Console.WriteLine("Please enter the client's City:");
			return Console.ReadLine();
		}
		
		public static String getState()
		{
			Console.WriteLine("Please enter the client's state:");
			return Console.ReadLine();
		}
		public static String getZip()
		{
			Console.WriteLine("Please enter the client's zip code:");
			return Console.ReadLine();
		}
		public static String getPhone()
		{
			Console.WriteLine("Please enter the client's phone number:");
			return Console.ReadLine();
		}
		
		public static String getEmail()
		{
			Console.WriteLine("Please enter the client's email address:");
			return Console.ReadLine();
		}
		public static String getWeb()
		{
			Console.WriteLine("Please enter the client's website url:");
			return Console.ReadLine();
		}
		public static String getPOC()
		{
			Console.WriteLine("Who is the primary Point of Contact for this Client?");
			return Console.ReadLine();
		}
		public static String getProject()
		{
			Console.WriteLine("What is the name of the project?");
			return Console.ReadLine();
		}
		public static int getDeadlineMonth()
		{
			Console.WriteLine("What is the month of the Client's Deadline?");
			return int.Parse(Console.ReadLine());
		}
		public static int getDeadlineDay()
		{
			Console.WriteLine("What is the day of the Client's Deadline?");
			return int.Parse(Console.ReadLine());
		}
		public static int getDeadlineYear()
		{
			Console.WriteLine("What is the year of the Client's Deadline?");
			return int.Parse(Console.ReadLine());
		}
	}
}