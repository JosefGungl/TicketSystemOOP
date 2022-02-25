using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketSystemOOP
{
    public class TicketFile
    {
        public string filePath { get; set; }
        public List<Ticket> Tickets {get; set;}

        public TicketFile(string ticketFilePath)
        {
            filePath = ticketFilePath;
            Tickets = new List<Ticket>();

            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
                {
                    Ticket ticket = new Ticket();
                    string line = sr.ReadLine();
                    string[] arr = line.Split(',');
                    ticket.id = arr[0];
                    ticket.summary = arr[1];
                    ticket.status = arr[2];
                    ticket.priority = arr[3];
                    ticket.submitter = arr[4];
                    ticket.assigned = arr[5];
                    ticket.watcher = arr[6];

                    Tickets.Add(ticket);
                }
                sr.Close();
        }

        public void AddTicket(Ticket ticket){
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine($"ID: {ticket.id}, Summary: {ticket.summary}, Status: {ticket.status}, Priority: {ticket.priority}, Submitter: {ticket.submitter}, Assigned: {ticket.assigned}, Watching: {ticket.watcher}");
            sw.Close();
            Tickets.Add(ticket);
        }
    }
}