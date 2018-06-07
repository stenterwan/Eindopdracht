using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace StoreWebservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        int Inloggen(string u, string p);

        [OperationContract]
        string Registreren(string u);

        [OperationContract]
        Product[] GetAllProducts();

        [OperationContract]
        Order[] GetAllOrdersByCustomer(int customer);

        [OperationContract]
        string Buy(int pid, int id);

        [OperationContract]
        Customer GetCustomerById(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "StoreWebservice.ContractType".
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public bool BoolValue { get; set; } = true;

        [DataMember]
        public string StringValue { get; set; } = "Hello ";
    }
}