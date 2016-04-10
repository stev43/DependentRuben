using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Tamagotchi.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public Service1(){
            string baseAddress = "http://tamagotchiserviceje.azurewebsites.net/";
             BasicHttpBinding binding1 = new BasicHttpBinding();
        
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.AddServiceEndpoint(typeof(IService1), binding1, baseAddress);

            }
        }
 

        public string GetData(int value) {
            return string.Format("You entered: {0}", value);
        }
        
        
        //public Dummy[] GetDummies() {
        
//        }

       public Tamagotchi[] GetTamagotchis() {

           Tamagotchi[] array;
           
       //    array = new Tamagotchi[2];
           using (var context = new Context()){
            //   context.Tamagotchis.Add(new Tamagotchi());
               array = context.Tamagotchis.ToArray();
              
               //array = context.Tamagotchis.g
               
           }

           return array;

  
        }
       public void AddNewTamagotchi(string name) {

           using (var context = new Context())
           {
              Tamagotchi Default = new Tamagotchi();
              Default.Naam = name;
              context.Tamagotchis.Add(Default);
           }
       }


    

      public Dummy[] GetDummies() {
           return AllDummies();
       }

       private Dummy[] AllDummies() {
           Dummy[] dummies;

           dummies = new Dummy[1];
           return dummies;
       }
    }
}
