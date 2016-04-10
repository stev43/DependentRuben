using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;
using WCF_Tamagotchi.service;



namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

// Step 1 Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://wcftamagotchiservice.azurewebsites.net/");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "WCFService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("Right");
                
         

                // Close the ServiceHostBase to shutdown the service.
                //selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("WRONG");
                selfHost.Abort();
            }
            Console.ReadLine();

            using (Service1)
            {
            
            }
        }
    }
}
