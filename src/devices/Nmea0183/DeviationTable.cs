﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.8.3928.0.
// 
namespace Iot.Device.Nmea0183 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/DeviationTable.xsd", IsNullable=false)]
    public partial class CompassCalibration {
        
        private Identification identificationField;
        
        private DeviationPoint[] calibrationDataFromCompassReadingField;
        
        private DeviationPoint[] calibrationDataToCompassReadingField;
        
        private RawData rawDataReadingsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Identification Identification {
            get {
                return this.identificationField;
            }
            set {
                this.identificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable=false)]
        public DeviationPoint[] CalibrationDataFromCompassReading {
            get {
                return this.calibrationDataFromCompassReadingField;
            }
            set {
                this.calibrationDataFromCompassReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable=false)]
        public DeviationPoint[] CalibrationDataToCompassReading {
            get {
                return this.calibrationDataToCompassReadingField;
            }
            set {
                this.calibrationDataToCompassReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public RawData RawDataReadings {
            get {
                return this.rawDataReadingsField;
            }
            set {
                this.rawDataReadingsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    public partial class Identification {
        
        private string shipNameField;
        
        private string callsignField;
        
        private string mMSIField;
        
        private System.DateTime calibrationDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ShipName {
            get {
                return this.shipNameField;
            }
            set {
                this.shipNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Callsign {
            get {
                return this.callsignField;
            }
            set {
                this.callsignField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string MMSI {
            get {
                return this.mMSIField;
            }
            set {
                this.mMSIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime CalibrationDate {
            get {
                return this.calibrationDateField;
            }
            set {
                this.calibrationDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    public partial class GnssReading {
        
        private System.DateTime timeStampField;
        
        private float trackReadingField;
        
        private float deltaToPreviousField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime TimeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float TrackReading {
            get {
                return this.trackReadingField;
            }
            set {
                this.trackReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float DeltaToPrevious {
            get {
                return this.deltaToPreviousField;
            }
            set {
                this.deltaToPreviousField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    public partial class MagneticReading {
        
        private System.DateTime timeStampField;
        
        private float magneticCompassReadingField;
        
        private float deltaToPreviousField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime TimeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float MagneticCompassReading {
            get {
                return this.magneticCompassReadingField;
            }
            set {
                this.magneticCompassReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float DeltaToPrevious {
            get {
                return this.deltaToPreviousField;
            }
            set {
                this.deltaToPreviousField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    public partial class RawData {
        
        private MagneticReading[] compassField;
        
        private GnssReading[] trackField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Compass", Order=0)]
        public MagneticReading[] Compass {
            get {
                return this.compassField;
            }
            set {
                this.compassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Track", Order=1)]
        public GnssReading[] Track {
            get {
                return this.trackField;
            }
            set {
                this.trackField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/DeviationTable.xsd")]
    public partial class DeviationPoint {
        
        private float compassReadingField;
        
        private float compassReadingSmoothField;
        
        private float magneticHeadingField;
        
        private float deviationField;
        
        private float deviationSmoothField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float CompassReading {
            get {
                return this.compassReadingField;
            }
            set {
                this.compassReadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float CompassReadingSmooth {
            get {
                return this.compassReadingSmoothField;
            }
            set {
                this.compassReadingSmoothField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float MagneticHeading {
            get {
                return this.magneticHeadingField;
            }
            set {
                this.magneticHeadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float Deviation {
            get {
                return this.deviationField;
            }
            set {
                this.deviationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public float DeviationSmooth {
            get {
                return this.deviationSmoothField;
            }
            set {
                this.deviationSmoothField = value;
            }
        }
    }
}
