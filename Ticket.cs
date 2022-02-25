using System;
using System.Collections.Generic;

namespace TicketSystemOOP
{
    public class Ticket
    {
        public string id { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public string watcher { get; set; }

        public string Display(){
            return $"{id}, {summary}, {status}, {priority}, {submitter}, {assigned}, {watcher} \n";
        }
    }
}