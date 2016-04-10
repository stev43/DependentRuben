using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
 

namespace WCF_Tamagotchi.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        //[OperationContract]
       // CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Tamagotchi[] GetTamagotchis();
        [OperationContract]
        Dummy[] GetDummies();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Tamagotchi
    {


        [DataMember]
        public int Id {
            get {
                return Id;
            }
            set {
                Id = value;
            }
        }
        [DataMember]
        public bool Overleden {
            get {
                return Overleden;
            }
            set {
                Overleden = value;
            }
        }
        [DataMember]
        public int Honger {
            get;
            set;
        }
        [DataMember]
        public string Naam {
            get;
            set;
        }
        [DataMember]
        public int Vermoeidheid {
            get;
            set;
        }
        [DataMember]
        public int Leven {
            get;
            set;
        }
        [DataMember]
        public int Slaaptekort {
            get;
            set;
        }
        [DataMember]
        public int Verveling {
            get;
            set;
        }
        [DataMember]
        public int Isolatie {
            get;
            set;
        }
     
        [DataMember]
        public Boolean Voedseltekort {
            get;
            set;
        }
    
        [DataMember]
        public Boolean Trek {
            get;
            set;
        }
        [DataMember]
        public Boolean TopAtleet {
            get;
            set;
        }
        [DataMember]
        public Boolean Crazy {
            get;
            set;
        }
        [DataMember]
        public DateTime LastAccess {
            get;
            set;
        }
    }
}
