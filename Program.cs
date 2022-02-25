using System;
using System.IO;
using System.Collections.Generic;

namespace TicketSystemOOP
{
    class Program
    {


        static void Main(string[] args)
        {
            string ticketFilePath = Directory.GetCurrentDirectory() + "\\tickets.csv";

            TicketFile ticketFile = new TicketFile(ticketFilePath);

            string choice = "";
            do{
                Console.WriteLine("1. Create a ticket");
                Console.WriteLine("2. Display all tickets");
                Console.WriteLine("3. Anything else to quit");
                choice = Console.ReadLine();
                Console.WriteLine("");


                if (choice == "1"){
                    //add ticket
                    Ticket ticket = new Ticket();
                    Console.WriteLine("What is the tickets ID?");
                        ticket.id = Console.ReadLine();
                        Console.WriteLine("A short ticket summary please.");
                        ticket.summary = Console.ReadLine();
                        Console.WriteLine("What is the tickets status?");
                        ticket.status = Console.ReadLine();
                        Console.WriteLine("What is the priority level of the ticket?");
                        ticket.priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        ticket.submitter = Console.ReadLine();
                        Console.WriteLine("Who was assigned the ticket?");
                        ticket.assigned = Console.ReadLine();
                        Console.WriteLine("Who is watching the ticket?");
                        ticket.watcher = Console.ReadLine();

                        ticketFile.AddTicket(ticket);
                }else if (choice == "2"){
                    //display all tickets
                    foreach(Ticket t in ticketFile.Tickets){
                        Console.WriteLine(t.Display());
                    }
                }


            } while (choice =="1" || choice == "2");

        }
    }
}
