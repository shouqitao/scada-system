using System.Runtime.Serialization;

namespace SCADACommon.Model {
    [DataContract]
    public class AddressValue {
        public AddressValue() { }

        public AddressValue(string address, double value) {
            Address = address;
            Value = value;
        }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public double Value { get; set; }
    }
}