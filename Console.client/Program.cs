using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChatService.IChatService service = new ChatService.ChatServiceClient();

            Console.WriteLine("Loading messages...");

            String[] messages =  service.GetMessages();
            PrintMessages(messages);

            String line = Console.ReadLine();
            while(!line.Equals("exit")){
                messages = service.SendMessage(line);
                PrintMessages(messages);
                line = Console.ReadLine();
               
                    
            }
        }

    }
}
