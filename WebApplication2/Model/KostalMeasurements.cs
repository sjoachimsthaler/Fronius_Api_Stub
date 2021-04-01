using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot("root")]
    public partial class KostalMeasurements
    {

        private rootDiv divField;

        private rootDevice deviceField;

        private byte slickuniqueidField;

        /// <remarks/>
        public rootDiv div
        {
            get
            {
                return this.divField;
            }
            set
            {
                this.divField = value;
            }
        }

        /// <remarks/>
        public rootDevice Device
        {
            get
            {
                return this.deviceField;
            }
            set
            {
                this.deviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("slick-uniqueid")]
        public byte slickuniqueid
        {
            get
            {
                return this.slickuniqueidField;
            }
            set
            {
                this.slickuniqueidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootDiv
    {

        private rootDivA aField;

        /// <remarks/>
        public rootDivA a
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootDivA
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootDevice
    {

        private rootDeviceMeasurement[] measurementsField;

        private string nameField;

        private string typeField;

        private string platformField;

        private string hmiPlatformField;

        private ushort nominalPowerField;

        private string userPowerLimitField;

        private string countryPowerLimitField;

        private string serialField;

        private uint oEMSerialField;

        private byte busAddressField;

        private string netBiosNameField;

        private string webPortalField;

        private string manufacturerURLField;

        private string ipAddressField;

        private System.DateTime dateTimeField;

        private ushort milliSecondsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Measurement", IsNullable = false)]
        public rootDeviceMeasurement[] Measurements
        {
            get
            {
                return this.measurementsField;
            }
            set
            {
                this.measurementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HmiPlatform
        {
            get
            {
                return this.hmiPlatformField;
            }
            set
            {
                this.hmiPlatformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort NominalPower
        {
            get
            {
                return this.nominalPowerField;
            }
            set
            {
                this.nominalPowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserPowerLimit
        {
            get
            {
                return this.userPowerLimitField;
            }
            set
            {
                this.userPowerLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryPowerLimit
        {
            get
            {
                return this.countryPowerLimitField;
            }
            set
            {
                this.countryPowerLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serial
        {
            get
            {
                return this.serialField;
            }
            set
            {
                this.serialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint OEMSerial
        {
            get
            {
                return this.oEMSerialField;
            }
            set
            {
                this.oEMSerialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BusAddress
        {
            get
            {
                return this.busAddressField;
            }
            set
            {
                this.busAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetBiosName
        {
            get
            {
                return this.netBiosNameField;
            }
            set
            {
                this.netBiosNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WebPortal
        {
            get
            {
                return this.webPortalField;
            }
            set
            {
                this.webPortalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ManufacturerURL
        {
            get
            {
                return this.manufacturerURLField;
            }
            set
            {
                this.manufacturerURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IpAddress
        {
            get
            {
                return this.ipAddressField;
            }
            set
            {
                this.ipAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MilliSeconds
        {
            get
            {
                return this.milliSecondsField;
            }
            set
            {
                this.milliSecondsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootDeviceMeasurement
    {

        private decimal valueField;

        private bool valueFieldSpecified;

        private string unitField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


}
