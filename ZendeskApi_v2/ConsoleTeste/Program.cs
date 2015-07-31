using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendeskApi_v2;
using ZendeskApi_v2.Models.AccountsAndActivities;
using ZendeskApi_v2.Models.Constants;
using ZendeskApi_v2.Models.Tickets;

namespace ConsoleTeste
{
    class Program
    {

        private static ZendeskApi _api = new ZendeskApi("https://none822.zendesk.com", "fabiofarzat@gmail.com", "123456");

        static void Main(string[] args)
        {

            _api.Tickets.CreateTicket(new Ticket()
                {
                    Subject = "Segudna via de boleto",
                    Comment = new Comment() { Body = "Solicito segunda via de boleto da competência 07/2015. Enviar para o email teste@vital.com.br" },
                    Priority = TicketPriorities.Urgent
                });


            var lista = _api.Tickets.GetAllTickets(10).Tickets;

            foreach (var s in lista)
            {
                Console.WriteLine("{0}", s.Subject);
            }
        }
    }
}
