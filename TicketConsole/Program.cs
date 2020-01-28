using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "ticket.csv";
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    
                        // accumulators needed for GPA
                        int gradePoints = 0;
                        int count = 0;
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split(',');
                            // display array data
                            Console.WriteLine("TicketID: {0}, Sumary: {1}, Status: {2}, Priority{3}, Submitter{4}, Assignment{5}, Watching{6}", arr[0], arr[1]);
                            
                        }
                        // calculate GPA
                        double GPA = (double)gradePoints / count;
                        Console.WriteLine("GPA: {0}", GPA);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
                else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file, append: true);
                    for (int i = 0; i < 7; i++)
                    {
                        // ask a question
                        Console.WriteLine("Enter another ticket (Y/N)?");
                        // input the response
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        // prompt for ticket ID
                        Console.WriteLine("Enter your ticket ID.");
                        // save the ticket ID
                        string ticketID = Console.ReadLine();
                        // prompt for course grade
                        Console.WriteLine("Enter the course grade.");
                        // save the course grade
                        string grade = Console.ReadLine().ToUpper();
                        sw.WriteLine("{0},{1},{3},{4},{5},{6}", ticketID, Summary, Status, Priority, Submitter,
                            Assigned, Watching);
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");

        }

    }
    }
}
