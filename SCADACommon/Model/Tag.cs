using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SCADACommon.Model {
    [DataContract]
    [XmlInclude(typeof(AnalogInputTag))]
    [XmlInclude(typeof(AnalogOutputTag))]
    [XmlInclude(typeof(DigitalInputTag))]
    [XmlInclude(typeof(DigitalOutputTag))]
    [KnownType(typeof(AnalogInputTag))]
    [KnownType(typeof(AnalogOutputTag))]
    [KnownType(typeof(DigitalInputTag))]
    [KnownType(typeof(DigitalOutputTag))]
    public class Tag {
        [DataMember]
        private SimulationDriver _driver;

        public Tag() { }

        public Tag(string id, string description, SimulationDriver driver, string address) {
            Id = id;
            Description = description;
            _driver = driver;
            Address = address;
            Driver?.AddressValues.Add(new AddressValue(Address, 0));
        }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        public SimulationDriver Driver {
            get { return _driver; }
            set {
                _driver = value;
                var addressValue = Driver.AddressValues.FirstOrDefault(av => av.Address == Address);
                if (addressValue == null)
                    _driver.AddressValues.Add(new AddressValue(Address, 0));
            }
        }

        [DataMember]
        public string Address { get; set; }

        public double GetValue() {
            return Driver?.AddressValues.First(av => av.Address == Address).Value ?? 0;
        }

        public void SetValue(double value) {
            if (Driver != null)
                Driver.AddressValues.First(av => av.Address == Address).Value = value;
        }
    }
}