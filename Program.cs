using BusProject.BL;
using BusProject.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusBusiness busBusiness = new BusBusiness(new BusRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Bus> _listBus = busBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("Bus ID   |  Bus Name    ");
                        foreach (Bus _bus in _listBus)
                        {
                            Console.WriteLine(_bus.BusId + "  |   " + _bus.BusName);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Bus aBus = busBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aBus.BusId + ". " + aBus.BusName);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Bus aBus = new Bus();
                        aBus.BusId = Convert.ToInt32(id);
                        aBus.BusName = name;
                        bool isExecuted = busBusiness.Add(aBus);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Bus aBus = new Bus();
                        aBus.BusId = Convert.ToInt32(id);
                        aBus.BusName = name;
                        bool isExecuted = busBusiness.Update(aBus);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = busBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            
        }
    }
}
