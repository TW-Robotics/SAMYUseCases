/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace CRCL
{
    #region PubSubIPAddresses Class
    #if (!OPCUA_EXCLUDE_PubSubIPAddresses)
    /// <summary>
    /// PubSub IP addresses: IPAddress_Skill is the address where the SAMYCore is Publishing and the SAMYPlugIn is Subscribed; IPAddress_Status is the address where the SAMYCore is Subscribed and the SAMYCore is Publishing
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class PubSubIPAddresses : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public PubSubIPAddresses()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_iPAddress_Skill = null;
            m_iPAddress_Status = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "IPAddress_Skill", IsRequired = false, Order = 1)]
        public string IPAddress_Skill
        {
            get { return m_iPAddress_Skill;  }
            set { m_iPAddress_Skill = value; }
        }

        /// <remarks />
        [DataMember(Name = "IPAddress_Status", IsRequired = false, Order = 2)]
        public string IPAddress_Status
        {
            get { return m_iPAddress_Status;  }
            set { m_iPAddress_Status = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.PubSubIPAddresses; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.PubSubIPAddresses_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.PubSubIPAddresses_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("IPAddress_Skill", IPAddress_Skill);
            encoder.WriteString("IPAddress_Status", IPAddress_Status);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            IPAddress_Skill = decoder.ReadString("IPAddress_Skill");
            IPAddress_Status = decoder.ReadString("IPAddress_Status");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubIPAddresses value = encodeable as PubSubIPAddresses;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_iPAddress_Skill, value.m_iPAddress_Skill)) return false;
            if (!Utils.IsEqual(m_iPAddress_Status, value.m_iPAddress_Status)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PubSubIPAddresses)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubIPAddresses clone = (PubSubIPAddresses)base.MemberwiseClone();

            clone.m_iPAddress_Skill = (string)Utils.Clone(this.m_iPAddress_Skill);
            clone.m_iPAddress_Status = (string)Utils.Clone(this.m_iPAddress_Status);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_iPAddress_Skill;
        private string m_iPAddress_Status;
        #endregion
    }

    #region PubSubIPAddressesCollection Class
    /// <summary>
    /// A collection of PubSubIPAddresses objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubIPAddresses", Namespace = CRCL.Namespaces.CRCL, ItemName = "PubSubIPAddresses")]
    #if !NET_STANDARD
    public partial class PubSubIPAddressesCollection : List<PubSubIPAddresses>, ICloneable
    #else
    public partial class PubSubIPAddressesCollection : List<PubSubIPAddresses>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PubSubIPAddressesCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PubSubIPAddressesCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PubSubIPAddressesCollection(IEnumerable<PubSubIPAddresses> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PubSubIPAddressesCollection(PubSubIPAddresses[] values)
        {
            if (values != null)
            {
                return new PubSubIPAddressesCollection(values);
            }

            return new PubSubIPAddressesCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PubSubIPAddresses[](PubSubIPAddressesCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PubSubIPAddressesCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubIPAddressesCollection clone = new PubSubIPAddressesCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubIPAddresses)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_AngleUnitEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_AngleUnitEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_AngleUnitEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "DEGREE_0")]
        DEGREE = 0,

        /// <remarks />
        [EnumMember(Value = "RADIAN_1")]
        RADIAN = 1,
    }

    #region CRCL_AngleUnitEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_AngleUnitEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_AngleUnitEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_AngleUnitEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_AngleUnitEnumDataTypeCollection : List<CRCL_AngleUnitEnumDataType>, ICloneable
    #else
    public partial class CRCL_AngleUnitEnumDataTypeCollection : List<CRCL_AngleUnitEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_AngleUnitEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_AngleUnitEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_AngleUnitEnumDataTypeCollection(IEnumerable<CRCL_AngleUnitEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_AngleUnitEnumDataTypeCollection(CRCL_AngleUnitEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_AngleUnitEnumDataTypeCollection(values);
            }

            return new CRCL_AngleUnitEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_AngleUnitEnumDataType[](CRCL_AngleUnitEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_AngleUnitEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_AngleUnitEnumDataTypeCollection clone = new CRCL_AngleUnitEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_AngleUnitEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ForceUnitEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_ForceUnitEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_ForceUnitEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "NEWTON_0")]
        NEWTON = 0,

        /// <remarks />
        [EnumMember(Value = "POUND_1")]
        POUND = 1,

        /// <remarks />
        [EnumMember(Value = "OUNCE_2")]
        OUNCE = 2,
    }

    #region CRCL_ForceUnitEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ForceUnitEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ForceUnitEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ForceUnitEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ForceUnitEnumDataTypeCollection : List<CRCL_ForceUnitEnumDataType>, ICloneable
    #else
    public partial class CRCL_ForceUnitEnumDataTypeCollection : List<CRCL_ForceUnitEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ForceUnitEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ForceUnitEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ForceUnitEnumDataTypeCollection(IEnumerable<CRCL_ForceUnitEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ForceUnitEnumDataTypeCollection(CRCL_ForceUnitEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ForceUnitEnumDataTypeCollection(values);
            }

            return new CRCL_ForceUnitEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ForceUnitEnumDataType[](CRCL_ForceUnitEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ForceUnitEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ForceUnitEnumDataTypeCollection clone = new CRCL_ForceUnitEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ForceUnitEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_FractionDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_FractionDataType)
    /// <summary>
    /// Fraction structure
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_FractionDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_FractionDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fraction = (double)0;
            m_fractionMax = (double)0;
            m_fractionMin = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "fraction", IsRequired = false, Order = 1)]
        public double fraction
        {
            get { return m_fraction;  }
            set { m_fraction = value; }
        }

        /// <remarks />
        [DataMember(Name = "fractionMax", IsRequired = false, Order = 2)]
        public double fractionMax
        {
            get { return m_fractionMax;  }
            set { m_fractionMax = value; }
        }

        /// <remarks />
        [DataMember(Name = "fractionMin", IsRequired = false, Order = 3)]
        public double fractionMin
        {
            get { return m_fractionMin;  }
            set { m_fractionMin = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_FractionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_FractionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_FractionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("fraction", fraction);
            encoder.WriteDouble("fractionMax", fractionMax);
            encoder.WriteDouble("fractionMin", fractionMin);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fraction = decoder.ReadDouble("fraction");
            fractionMax = decoder.ReadDouble("fractionMax");
            fractionMin = decoder.ReadDouble("fractionMin");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_FractionDataType value = encodeable as CRCL_FractionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_fraction, value.m_fraction)) return false;
            if (!Utils.IsEqual(m_fractionMax, value.m_fractionMax)) return false;
            if (!Utils.IsEqual(m_fractionMin, value.m_fractionMin)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CRCL_FractionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_FractionDataType clone = (CRCL_FractionDataType)base.MemberwiseClone();

            clone.m_fraction = (double)Utils.Clone(this.m_fraction);
            clone.m_fractionMax = (double)Utils.Clone(this.m_fractionMax);
            clone.m_fractionMin = (double)Utils.Clone(this.m_fractionMin);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_fraction;
        private double m_fractionMax;
        private double m_fractionMin;
        #endregion
    }

    #region CRCL_FractionDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_FractionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_FractionDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_FractionDataType")]
    #if !NET_STANDARD
    public partial class CRCL_FractionDataTypeCollection : List<CRCL_FractionDataType>, ICloneable
    #else
    public partial class CRCL_FractionDataTypeCollection : List<CRCL_FractionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_FractionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_FractionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_FractionDataTypeCollection(IEnumerable<CRCL_FractionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_FractionDataTypeCollection(CRCL_FractionDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_FractionDataTypeCollection(values);
            }

            return new CRCL_FractionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_FractionDataType[](CRCL_FractionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_FractionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_FractionDataTypeCollection clone = new CRCL_FractionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_FractionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_LengthUnitEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_LengthUnitEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_LengthUnitEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "METER_0")]
        METER = 0,

        /// <remarks />
        [EnumMember(Value = "MILLIMETER_1")]
        MILLIMETER = 1,

        /// <remarks />
        [EnumMember(Value = "INCH_2")]
        INCH = 2,
    }

    #region CRCL_LengthUnitEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_LengthUnitEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_LengthUnitEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_LengthUnitEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_LengthUnitEnumDataTypeCollection : List<CRCL_LengthUnitEnumDataType>, ICloneable
    #else
    public partial class CRCL_LengthUnitEnumDataTypeCollection : List<CRCL_LengthUnitEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_LengthUnitEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_LengthUnitEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_LengthUnitEnumDataTypeCollection(IEnumerable<CRCL_LengthUnitEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_LengthUnitEnumDataTypeCollection(CRCL_LengthUnitEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_LengthUnitEnumDataTypeCollection(values);
            }

            return new CRCL_LengthUnitEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_LengthUnitEnumDataType[](CRCL_LengthUnitEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_LengthUnitEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_LengthUnitEnumDataTypeCollection clone = new CRCL_LengthUnitEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_LengthUnitEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_DataThingDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_DataThingDataType)
    /// <summary>
    /// Fraction structure
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_DataThingDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_DataThingDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_id = (uint)0;
            m_name = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "id", IsRequired = false, Order = 1)]
        public uint id
        {
            get { return m_id;  }
            set { m_id = value; }
        }

        /// <remarks />
        [DataMember(Name = "name", IsRequired = false, Order = 2)]
        public string name
        {
            get { return m_name;  }
            set { m_name = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_DataThingDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_DataThingDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_DataThingDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("id", id);
            encoder.WriteString("name", name);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            id = decoder.ReadUInt32("id");
            name = decoder.ReadString("name");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_DataThingDataType value = encodeable as CRCL_DataThingDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_id, value.m_id)) return false;
            if (!Utils.IsEqual(m_name, value.m_name)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CRCL_DataThingDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_DataThingDataType clone = (CRCL_DataThingDataType)base.MemberwiseClone();

            clone.m_id = (uint)Utils.Clone(this.m_id);
            clone.m_name = (string)Utils.Clone(this.m_name);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_id;
        private string m_name;
        #endregion
    }

    #region CRCL_DataThingDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_DataThingDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_DataThingDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_DataThingDataType")]
    #if !NET_STANDARD
    public partial class CRCL_DataThingDataTypeCollection : List<CRCL_DataThingDataType>, ICloneable
    #else
    public partial class CRCL_DataThingDataTypeCollection : List<CRCL_DataThingDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_DataThingDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_DataThingDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_DataThingDataTypeCollection(IEnumerable<CRCL_DataThingDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_DataThingDataTypeCollection(CRCL_DataThingDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_DataThingDataTypeCollection(values);
            }

            return new CRCL_DataThingDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_DataThingDataType[](CRCL_DataThingDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_DataThingDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_DataThingDataTypeCollection clone = new CRCL_DataThingDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_DataThingDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SAMYRobotDataType Class
    #if (!OPCUA_EXCLUDE_SAMYRobotDataType)
    /// <summary>
    /// CRCLProgramm
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SAMYRobotDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SAMYRobotDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_requested_Skill = new CRCLSkillDataType();
            m_requested_Skill_Success = true;
            m_active = true;
            m_online = true;
            m_iPAddresses = new PubSubIPAddresses();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Indicates the current requested skill by the SAMYCore to be executed by the robot
        /// </summary>
        [DataMember(Name = "Requested_Skill", IsRequired = false, Order = 1)]
        public CRCLSkillDataType Requested_Skill
        {
            get
            {
                return m_requested_Skill;
            }

            set
            {
                m_requested_Skill = value;

                if (value == null)
                {
                    m_requested_Skill = new CRCLSkillDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Requested_Skill_Success", IsRequired = false, Order = 2)]
        public bool Requested_Skill_Success
        {
            get { return m_requested_Skill_Success;  }
            set { m_requested_Skill_Success = value; }
        }

        /// <remarks />
        [DataMember(Name = "Active", IsRequired = false, Order = 3)]
        public bool Active
        {
            get { return m_active;  }
            set { m_active = value; }
        }

        /// <remarks />
        [DataMember(Name = "Online", IsRequired = false, Order = 4)]
        public bool Online
        {
            get { return m_online;  }
            set { m_online = value; }
        }

        /// <summary>
        /// IPAddresses where the Requested_Skills (IPAddress_Skill) and Status (IPAddress_Status) are published
        /// </summary>
        [DataMember(Name = "IPAddresses", IsRequired = false, Order = 5)]
        public PubSubIPAddresses IPAddresses
        {
            get
            {
                return m_iPAddresses;
            }

            set
            {
                m_iPAddresses = value;

                if (value == null)
                {
                    m_iPAddresses = new PubSubIPAddresses();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SAMYRobotDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SAMYRobotDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SAMYRobotDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("Requested_Skill", Requested_Skill, typeof(CRCLSkillDataType));
            encoder.WriteBoolean("Requested_Skill_Success", Requested_Skill_Success);
            encoder.WriteBoolean("Active", Active);
            encoder.WriteBoolean("Online", Online);
            encoder.WriteEncodeable("IPAddresses", IPAddresses, typeof(PubSubIPAddresses));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Requested_Skill = (CRCLSkillDataType)decoder.ReadEncodeable("Requested_Skill", typeof(CRCLSkillDataType));
            Requested_Skill_Success = decoder.ReadBoolean("Requested_Skill_Success");
            Active = decoder.ReadBoolean("Active");
            Online = decoder.ReadBoolean("Online");
            IPAddresses = (PubSubIPAddresses)decoder.ReadEncodeable("IPAddresses", typeof(PubSubIPAddresses));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SAMYRobotDataType value = encodeable as SAMYRobotDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_requested_Skill, value.m_requested_Skill)) return false;
            if (!Utils.IsEqual(m_requested_Skill_Success, value.m_requested_Skill_Success)) return false;
            if (!Utils.IsEqual(m_active, value.m_active)) return false;
            if (!Utils.IsEqual(m_online, value.m_online)) return false;
            if (!Utils.IsEqual(m_iPAddresses, value.m_iPAddresses)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SAMYRobotDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SAMYRobotDataType clone = (SAMYRobotDataType)base.MemberwiseClone();

            clone.m_requested_Skill = (CRCLSkillDataType)Utils.Clone(this.m_requested_Skill);
            clone.m_requested_Skill_Success = (bool)Utils.Clone(this.m_requested_Skill_Success);
            clone.m_active = (bool)Utils.Clone(this.m_active);
            clone.m_online = (bool)Utils.Clone(this.m_online);
            clone.m_iPAddresses = (PubSubIPAddresses)Utils.Clone(this.m_iPAddresses);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCLSkillDataType m_requested_Skill;
        private bool m_requested_Skill_Success;
        private bool m_active;
        private bool m_online;
        private PubSubIPAddresses m_iPAddresses;
        #endregion
    }

    #region SAMYRobotDataTypeCollection Class
    /// <summary>
    /// A collection of SAMYRobotDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSAMYRobotDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SAMYRobotDataType")]
    #if !NET_STANDARD
    public partial class SAMYRobotDataTypeCollection : List<SAMYRobotDataType>, ICloneable
    #else
    public partial class SAMYRobotDataTypeCollection : List<SAMYRobotDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SAMYRobotDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SAMYRobotDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SAMYRobotDataTypeCollection(IEnumerable<SAMYRobotDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SAMYRobotDataTypeCollection(SAMYRobotDataType[] values)
        {
            if (values != null)
            {
                return new SAMYRobotDataTypeCollection(values);
            }

            return new SAMYRobotDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SAMYRobotDataType[](SAMYRobotDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SAMYRobotDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SAMYRobotDataTypeCollection clone = new SAMYRobotDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SAMYRobotDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_PointDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_PointDataType)
    /// <summary>
    /// CRCL 3D Point DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_PointDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_PointDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_x = (double)0;
            m_y = (double)0;
            m_z = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "x", IsRequired = false, Order = 1)]
        public double x
        {
            get { return m_x;  }
            set { m_x = value; }
        }

        /// <remarks />
        [DataMember(Name = "y", IsRequired = false, Order = 2)]
        public double y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        /// <remarks />
        [DataMember(Name = "z", IsRequired = false, Order = 3)]
        public double z
        {
            get { return m_z;  }
            set { m_z = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_PointDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_PointDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_PointDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("x", x);
            encoder.WriteDouble("y", y);
            encoder.WriteDouble("z", z);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            x = decoder.ReadDouble("x");
            y = decoder.ReadDouble("y");
            z = decoder.ReadDouble("z");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_PointDataType value = encodeable as CRCL_PointDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_PointDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PointDataType clone = (CRCL_PointDataType)base.MemberwiseClone();

            clone.m_x = (double)Utils.Clone(this.m_x);
            clone.m_y = (double)Utils.Clone(this.m_y);
            clone.m_z = (double)Utils.Clone(this.m_z);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_x;
        private double m_y;
        private double m_z;
        #endregion
    }

    #region CRCL_PointDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_PointDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_PointDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_PointDataType")]
    #if !NET_STANDARD
    public partial class CRCL_PointDataTypeCollection : List<CRCL_PointDataType>, ICloneable
    #else
    public partial class CRCL_PointDataTypeCollection : List<CRCL_PointDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_PointDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_PointDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_PointDataTypeCollection(IEnumerable<CRCL_PointDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_PointDataTypeCollection(CRCL_PointDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_PointDataTypeCollection(values);
            }

            return new CRCL_PointDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_PointDataType[](CRCL_PointDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_PointDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PointDataTypeCollection clone = new CRCL_PointDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_PointDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_VectorDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_VectorDataType)
    /// <summary>
    /// CRCL 3D Vector DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_VectorDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_VectorDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_i = (double)0;
            m_j = (double)0;
            m_k = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "i", IsRequired = false, Order = 1)]
        public double i
        {
            get { return m_i;  }
            set { m_i = value; }
        }

        /// <remarks />
        [DataMember(Name = "j", IsRequired = false, Order = 2)]
        public double j
        {
            get { return m_j;  }
            set { m_j = value; }
        }

        /// <remarks />
        [DataMember(Name = "k", IsRequired = false, Order = 3)]
        public double k
        {
            get { return m_k;  }
            set { m_k = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_VectorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_VectorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_VectorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("i", i);
            encoder.WriteDouble("j", j);
            encoder.WriteDouble("k", k);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            i = decoder.ReadDouble("i");
            j = decoder.ReadDouble("j");
            k = decoder.ReadDouble("k");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_VectorDataType value = encodeable as CRCL_VectorDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_i, value.m_i)) return false;
            if (!Utils.IsEqual(m_j, value.m_j)) return false;
            if (!Utils.IsEqual(m_k, value.m_k)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_VectorDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_VectorDataType clone = (CRCL_VectorDataType)base.MemberwiseClone();

            clone.m_i = (double)Utils.Clone(this.m_i);
            clone.m_j = (double)Utils.Clone(this.m_j);
            clone.m_k = (double)Utils.Clone(this.m_k);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_i;
        private double m_j;
        private double m_k;
        #endregion
    }

    #region CRCL_VectorDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_VectorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_VectorDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_VectorDataType")]
    #if !NET_STANDARD
    public partial class CRCL_VectorDataTypeCollection : List<CRCL_VectorDataType>, ICloneable
    #else
    public partial class CRCL_VectorDataTypeCollection : List<CRCL_VectorDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_VectorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_VectorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_VectorDataTypeCollection(IEnumerable<CRCL_VectorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_VectorDataTypeCollection(CRCL_VectorDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_VectorDataTypeCollection(values);
            }

            return new CRCL_VectorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_VectorDataType[](CRCL_VectorDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_VectorDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_VectorDataTypeCollection clone = new CRCL_VectorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_VectorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_PoseDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_PoseDataType)
    /// <summary>
    /// CRCL 3D Pose DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_PoseDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_PoseDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_point = new CRCL_PointDataType();
            m_xAxis = new CRCL_VectorDataType();
            m_zAxis = new CRCL_VectorDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Point CRCL Pose DataType
        /// </summary>
        [DataMember(Name = "point", IsRequired = false, Order = 1)]
        public CRCL_PointDataType point
        {
            get
            {
                return m_point;
            }

            set
            {
                m_point = value;

                if (value == null)
                {
                    m_point = new CRCL_PointDataType();
                }
            }
        }

        /// <summary>
        /// x axis CRCL Pose DataType
        /// </summary>
        [DataMember(Name = "xAxis", IsRequired = false, Order = 2)]
        public CRCL_VectorDataType xAxis
        {
            get
            {
                return m_xAxis;
            }

            set
            {
                m_xAxis = value;

                if (value == null)
                {
                    m_xAxis = new CRCL_VectorDataType();
                }
            }
        }

        /// <summary>
        /// z axis CRCL Pose DataType
        /// </summary>
        [DataMember(Name = "zAxis", IsRequired = false, Order = 3)]
        public CRCL_VectorDataType zAxis
        {
            get
            {
                return m_zAxis;
            }

            set
            {
                m_zAxis = value;

                if (value == null)
                {
                    m_zAxis = new CRCL_VectorDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_PoseDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_PoseDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_PoseDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("point", point, typeof(CRCL_PointDataType));
            encoder.WriteEncodeable("xAxis", xAxis, typeof(CRCL_VectorDataType));
            encoder.WriteEncodeable("zAxis", zAxis, typeof(CRCL_VectorDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            point = (CRCL_PointDataType)decoder.ReadEncodeable("point", typeof(CRCL_PointDataType));
            xAxis = (CRCL_VectorDataType)decoder.ReadEncodeable("xAxis", typeof(CRCL_VectorDataType));
            zAxis = (CRCL_VectorDataType)decoder.ReadEncodeable("zAxis", typeof(CRCL_VectorDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_PoseDataType value = encodeable as CRCL_PoseDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_point, value.m_point)) return false;
            if (!Utils.IsEqual(m_xAxis, value.m_xAxis)) return false;
            if (!Utils.IsEqual(m_zAxis, value.m_zAxis)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_PoseDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseDataType clone = (CRCL_PoseDataType)base.MemberwiseClone();

            clone.m_point = (CRCL_PointDataType)Utils.Clone(this.m_point);
            clone.m_xAxis = (CRCL_VectorDataType)Utils.Clone(this.m_xAxis);
            clone.m_zAxis = (CRCL_VectorDataType)Utils.Clone(this.m_zAxis);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_PointDataType m_point;
        private CRCL_VectorDataType m_xAxis;
        private CRCL_VectorDataType m_zAxis;
        #endregion
    }

    #region CRCL_PoseDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_PoseDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_PoseDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_PoseDataType")]
    #if !NET_STANDARD
    public partial class CRCL_PoseDataTypeCollection : List<CRCL_PoseDataType>, ICloneable
    #else
    public partial class CRCL_PoseDataTypeCollection : List<CRCL_PoseDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_PoseDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_PoseDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_PoseDataTypeCollection(IEnumerable<CRCL_PoseDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_PoseDataTypeCollection(CRCL_PoseDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_PoseDataTypeCollection(values);
            }

            return new CRCL_PoseDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_PoseDataType[](CRCL_PoseDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_PoseDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseDataTypeCollection clone = new CRCL_PoseDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_PoseDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TorqueUnitEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_TorqueUnitEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_TorqueUnitEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "NEWTONMETER_0")]
        NEWTONMETER = 0,

        /// <remarks />
        [EnumMember(Value = "FOOTPOUND_1")]
        FOOTPOUND = 1,
    }

    #region CRCL_TorqueUnitEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TorqueUnitEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TorqueUnitEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TorqueUnitEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TorqueUnitEnumDataTypeCollection : List<CRCL_TorqueUnitEnumDataType>, ICloneable
    #else
    public partial class CRCL_TorqueUnitEnumDataTypeCollection : List<CRCL_TorqueUnitEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TorqueUnitEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TorqueUnitEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TorqueUnitEnumDataTypeCollection(IEnumerable<CRCL_TorqueUnitEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TorqueUnitEnumDataTypeCollection(CRCL_TorqueUnitEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TorqueUnitEnumDataTypeCollection(values);
            }

            return new CRCL_TorqueUnitEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TorqueUnitEnumDataType[](CRCL_TorqueUnitEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TorqueUnitEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TorqueUnitEnumDataTypeCollection clone = new CRCL_TorqueUnitEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TorqueUnitEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TwistDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TwistDataType)
    /// <summary>
    /// CRCL 3D Twist DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TwistDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TwistDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_linearVelocity = new CRCL_VectorDataType();
            m_angularVelocity = new CRCL_VectorDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Linear Velocity CRCL Twist DataType
        /// </summary>
        [DataMember(Name = "linearVelocity", IsRequired = false, Order = 1)]
        public CRCL_VectorDataType linearVelocity
        {
            get
            {
                return m_linearVelocity;
            }

            set
            {
                m_linearVelocity = value;

                if (value == null)
                {
                    m_linearVelocity = new CRCL_VectorDataType();
                }
            }
        }

        /// <summary>
        /// Angular Velocity CRCL Twist DataType
        /// </summary>
        [DataMember(Name = "angularVelocity", IsRequired = false, Order = 2)]
        public CRCL_VectorDataType angularVelocity
        {
            get
            {
                return m_angularVelocity;
            }

            set
            {
                m_angularVelocity = value;

                if (value == null)
                {
                    m_angularVelocity = new CRCL_VectorDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TwistDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TwistDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TwistDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("linearVelocity", linearVelocity, typeof(CRCL_VectorDataType));
            encoder.WriteEncodeable("angularVelocity", angularVelocity, typeof(CRCL_VectorDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            linearVelocity = (CRCL_VectorDataType)decoder.ReadEncodeable("linearVelocity", typeof(CRCL_VectorDataType));
            angularVelocity = (CRCL_VectorDataType)decoder.ReadEncodeable("angularVelocity", typeof(CRCL_VectorDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TwistDataType value = encodeable as CRCL_TwistDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_linearVelocity, value.m_linearVelocity)) return false;
            if (!Utils.IsEqual(m_angularVelocity, value.m_angularVelocity)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TwistDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TwistDataType clone = (CRCL_TwistDataType)base.MemberwiseClone();

            clone.m_linearVelocity = (CRCL_VectorDataType)Utils.Clone(this.m_linearVelocity);
            clone.m_angularVelocity = (CRCL_VectorDataType)Utils.Clone(this.m_angularVelocity);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_VectorDataType m_linearVelocity;
        private CRCL_VectorDataType m_angularVelocity;
        #endregion
    }

    #region CRCL_TwistDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TwistDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TwistDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TwistDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TwistDataTypeCollection : List<CRCL_TwistDataType>, ICloneable
    #else
    public partial class CRCL_TwistDataTypeCollection : List<CRCL_TwistDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TwistDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TwistDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TwistDataTypeCollection(IEnumerable<CRCL_TwistDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TwistDataTypeCollection(CRCL_TwistDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TwistDataTypeCollection(values);
            }

            return new CRCL_TwistDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TwistDataType[](CRCL_TwistDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TwistDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TwistDataTypeCollection clone = new CRCL_TwistDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TwistDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_WrenchDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_WrenchDataType)
    /// <summary>
    /// CRCL 3D Wrench DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_WrenchDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_WrenchDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_force = new CRCL_VectorDataType();
            m_moment = new CRCL_VectorDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Force CRCL Wrench DataType
        /// </summary>
        [DataMember(Name = "force", IsRequired = false, Order = 1)]
        public CRCL_VectorDataType force
        {
            get
            {
                return m_force;
            }

            set
            {
                m_force = value;

                if (value == null)
                {
                    m_force = new CRCL_VectorDataType();
                }
            }
        }

        /// <summary>
        /// Moment CRCL Wrench DataType
        /// </summary>
        [DataMember(Name = "moment", IsRequired = false, Order = 2)]
        public CRCL_VectorDataType moment
        {
            get
            {
                return m_moment;
            }

            set
            {
                m_moment = value;

                if (value == null)
                {
                    m_moment = new CRCL_VectorDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_WrenchDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_WrenchDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_WrenchDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("force", force, typeof(CRCL_VectorDataType));
            encoder.WriteEncodeable("moment", moment, typeof(CRCL_VectorDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            force = (CRCL_VectorDataType)decoder.ReadEncodeable("force", typeof(CRCL_VectorDataType));
            moment = (CRCL_VectorDataType)decoder.ReadEncodeable("moment", typeof(CRCL_VectorDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_WrenchDataType value = encodeable as CRCL_WrenchDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_force, value.m_force)) return false;
            if (!Utils.IsEqual(m_moment, value.m_moment)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_WrenchDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_WrenchDataType clone = (CRCL_WrenchDataType)base.MemberwiseClone();

            clone.m_force = (CRCL_VectorDataType)Utils.Clone(this.m_force);
            clone.m_moment = (CRCL_VectorDataType)Utils.Clone(this.m_moment);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_VectorDataType m_force;
        private CRCL_VectorDataType m_moment;
        #endregion
    }

    #region CRCL_WrenchDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_WrenchDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_WrenchDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_WrenchDataType")]
    #if !NET_STANDARD
    public partial class CRCL_WrenchDataTypeCollection : List<CRCL_WrenchDataType>, ICloneable
    #else
    public partial class CRCL_WrenchDataTypeCollection : List<CRCL_WrenchDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_WrenchDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_WrenchDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_WrenchDataTypeCollection(IEnumerable<CRCL_WrenchDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_WrenchDataTypeCollection(CRCL_WrenchDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_WrenchDataTypeCollection(values);
            }

            return new CRCL_WrenchDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_WrenchDataType[](CRCL_WrenchDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_WrenchDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_WrenchDataTypeCollection clone = new CRCL_WrenchDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_WrenchDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_PoseToleranceDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_PoseToleranceDataType)
    /// <summary>
    /// CRCL PoseTolerance DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_PoseToleranceDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_PoseToleranceDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_xPointTolerance = (double)0;
            m_yPointTolerance = (double)0;
            m_zPointTolerance = (double)0;
            m_xAxisTolerance = (double)0;
            m_zAxisTolerance = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "xPointTolerance", IsRequired = false, Order = 1)]
        public double xPointTolerance
        {
            get { return m_xPointTolerance;  }
            set { m_xPointTolerance = value; }
        }

        /// <remarks />
        [DataMember(Name = "yPointTolerance", IsRequired = false, Order = 2)]
        public double yPointTolerance
        {
            get { return m_yPointTolerance;  }
            set { m_yPointTolerance = value; }
        }

        /// <remarks />
        [DataMember(Name = "zPointTolerance", IsRequired = false, Order = 3)]
        public double zPointTolerance
        {
            get { return m_zPointTolerance;  }
            set { m_zPointTolerance = value; }
        }

        /// <remarks />
        [DataMember(Name = "xAxisTolerance", IsRequired = false, Order = 4)]
        public double xAxisTolerance
        {
            get { return m_xAxisTolerance;  }
            set { m_xAxisTolerance = value; }
        }

        /// <remarks />
        [DataMember(Name = "zAxisTolerance", IsRequired = false, Order = 5)]
        public double zAxisTolerance
        {
            get { return m_zAxisTolerance;  }
            set { m_zAxisTolerance = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_PoseToleranceDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_PoseToleranceDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_PoseToleranceDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("xPointTolerance", xPointTolerance);
            encoder.WriteDouble("yPointTolerance", yPointTolerance);
            encoder.WriteDouble("zPointTolerance", zPointTolerance);
            encoder.WriteDouble("xAxisTolerance", xAxisTolerance);
            encoder.WriteDouble("zAxisTolerance", zAxisTolerance);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            xPointTolerance = decoder.ReadDouble("xPointTolerance");
            yPointTolerance = decoder.ReadDouble("yPointTolerance");
            zPointTolerance = decoder.ReadDouble("zPointTolerance");
            xAxisTolerance = decoder.ReadDouble("xAxisTolerance");
            zAxisTolerance = decoder.ReadDouble("zAxisTolerance");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_PoseToleranceDataType value = encodeable as CRCL_PoseToleranceDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_xPointTolerance, value.m_xPointTolerance)) return false;
            if (!Utils.IsEqual(m_yPointTolerance, value.m_yPointTolerance)) return false;
            if (!Utils.IsEqual(m_zPointTolerance, value.m_zPointTolerance)) return false;
            if (!Utils.IsEqual(m_xAxisTolerance, value.m_xAxisTolerance)) return false;
            if (!Utils.IsEqual(m_zAxisTolerance, value.m_zAxisTolerance)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_PoseToleranceDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseToleranceDataType clone = (CRCL_PoseToleranceDataType)base.MemberwiseClone();

            clone.m_xPointTolerance = (double)Utils.Clone(this.m_xPointTolerance);
            clone.m_yPointTolerance = (double)Utils.Clone(this.m_yPointTolerance);
            clone.m_zPointTolerance = (double)Utils.Clone(this.m_zPointTolerance);
            clone.m_xAxisTolerance = (double)Utils.Clone(this.m_xAxisTolerance);
            clone.m_zAxisTolerance = (double)Utils.Clone(this.m_zAxisTolerance);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_xPointTolerance;
        private double m_yPointTolerance;
        private double m_zPointTolerance;
        private double m_xAxisTolerance;
        private double m_zAxisTolerance;
        #endregion
    }

    #region CRCL_PoseToleranceDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_PoseToleranceDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_PoseToleranceDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_PoseToleranceDataType")]
    #if !NET_STANDARD
    public partial class CRCL_PoseToleranceDataTypeCollection : List<CRCL_PoseToleranceDataType>, ICloneable
    #else
    public partial class CRCL_PoseToleranceDataTypeCollection : List<CRCL_PoseToleranceDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_PoseToleranceDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_PoseToleranceDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_PoseToleranceDataTypeCollection(IEnumerable<CRCL_PoseToleranceDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_PoseToleranceDataTypeCollection(CRCL_PoseToleranceDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_PoseToleranceDataTypeCollection(values);
            }

            return new CRCL_PoseToleranceDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_PoseToleranceDataType[](CRCL_PoseToleranceDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_PoseToleranceDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseToleranceDataTypeCollection clone = new CRCL_PoseToleranceDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_PoseToleranceDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ParameterSettingDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ParameterSettingDataType)
    /// <summary>
    /// CRCL ParameterSetting DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ParameterSettingDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ParameterSettingDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_parameterName = null;
            m_parameterValue = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "parameterName", IsRequired = false, Order = 1)]
        public string parameterName
        {
            get { return m_parameterName;  }
            set { m_parameterName = value; }
        }

        /// <remarks />
        [DataMember(Name = "parameterValue", IsRequired = false, Order = 2)]
        public string parameterValue
        {
            get { return m_parameterValue;  }
            set { m_parameterValue = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ParameterSettingDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ParameterSettingDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ParameterSettingDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("parameterName", parameterName);
            encoder.WriteString("parameterValue", parameterValue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            parameterName = decoder.ReadString("parameterName");
            parameterValue = decoder.ReadString("parameterValue");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ParameterSettingDataType value = encodeable as CRCL_ParameterSettingDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_parameterName, value.m_parameterName)) return false;
            if (!Utils.IsEqual(m_parameterValue, value.m_parameterValue)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ParameterSettingDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ParameterSettingDataType clone = (CRCL_ParameterSettingDataType)base.MemberwiseClone();

            clone.m_parameterName = (string)Utils.Clone(this.m_parameterName);
            clone.m_parameterValue = (string)Utils.Clone(this.m_parameterValue);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_parameterName;
        private string m_parameterValue;
        #endregion
    }

    #region CRCL_ParameterSettingDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ParameterSettingDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ParameterSettingDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ParameterSettingDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ParameterSettingDataTypeCollection : List<CRCL_ParameterSettingDataType>, ICloneable
    #else
    public partial class CRCL_ParameterSettingDataTypeCollection : List<CRCL_ParameterSettingDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ParameterSettingDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ParameterSettingDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ParameterSettingDataTypeCollection(IEnumerable<CRCL_ParameterSettingDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ParameterSettingDataTypeCollection(CRCL_ParameterSettingDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ParameterSettingDataTypeCollection(values);
            }

            return new CRCL_ParameterSettingDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ParameterSettingDataType[](CRCL_ParameterSettingDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ParameterSettingDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ParameterSettingDataTypeCollection clone = new CRCL_ParameterSettingDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ParameterSettingDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotAccelDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotAccelDataType)
    /// <summary>
    /// CRCL RotAccel DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotAccelDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotAccelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotAccelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotAccelDataType value = encodeable as CRCL_RotAccelDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotAccelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelDataType clone = (CRCL_RotAccelDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CRCL_RotAccelDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotAccelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotAccelDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotAccelDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotAccelDataTypeCollection : List<CRCL_RotAccelDataType>, ICloneable
    #else
    public partial class CRCL_RotAccelDataTypeCollection : List<CRCL_RotAccelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotAccelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotAccelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotAccelDataTypeCollection(IEnumerable<CRCL_RotAccelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotAccelDataTypeCollection(CRCL_RotAccelDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotAccelDataTypeCollection(values);
            }

            return new CRCL_RotAccelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotAccelDataType[](CRCL_RotAccelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotAccelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelDataTypeCollection clone = new CRCL_RotAccelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotAccelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotAccelAbsoluteDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotAccelAbsoluteDataType)
    /// <summary>
    /// CRCL RotAccelAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotAccelAbsoluteDataType : CRCL_RotAccelDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotAccelAbsoluteDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "setting", IsRequired = false, Order = 1)]
        public double setting
        {
            get { return m_setting;  }
            set { m_setting = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotAccelAbsoluteDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelAbsoluteDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelAbsoluteDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("setting", setting);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            setting = decoder.ReadDouble("setting");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotAccelAbsoluteDataType value = encodeable as CRCL_RotAccelAbsoluteDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotAccelAbsoluteDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelAbsoluteDataType clone = (CRCL_RotAccelAbsoluteDataType)base.MemberwiseClone();

            clone.m_setting = (double)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_setting;
        #endregion
    }

    #region CRCL_RotAccelAbsoluteDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotAccelAbsoluteDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotAccelAbsoluteDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotAccelAbsoluteDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotAccelAbsoluteDataTypeCollection : List<CRCL_RotAccelAbsoluteDataType>, ICloneable
    #else
    public partial class CRCL_RotAccelAbsoluteDataTypeCollection : List<CRCL_RotAccelAbsoluteDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotAccelAbsoluteDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotAccelAbsoluteDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotAccelAbsoluteDataTypeCollection(IEnumerable<CRCL_RotAccelAbsoluteDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotAccelAbsoluteDataTypeCollection(CRCL_RotAccelAbsoluteDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotAccelAbsoluteDataTypeCollection(values);
            }

            return new CRCL_RotAccelAbsoluteDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotAccelAbsoluteDataType[](CRCL_RotAccelAbsoluteDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotAccelAbsoluteDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelAbsoluteDataTypeCollection clone = new CRCL_RotAccelAbsoluteDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotAccelAbsoluteDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotAccelRelativeDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotAccelRelativeDataType)
    /// <summary>
    /// CRCL RotAccelRelative DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotAccelRelativeDataType : CRCL_RotAccelDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotAccelRelativeDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fraction = new CRCL_FractionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// fraction CRCL RotAccelRelative DataType
        /// </summary>
        [DataMember(Name = "fraction", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType fraction
        {
            get
            {
                return m_fraction;
            }

            set
            {
                m_fraction = value;

                if (value == null)
                {
                    m_fraction = new CRCL_FractionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotAccelRelativeDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelRelativeDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotAccelRelativeDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("fraction", fraction, typeof(CRCL_FractionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fraction = (CRCL_FractionDataType)decoder.ReadEncodeable("fraction", typeof(CRCL_FractionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotAccelRelativeDataType value = encodeable as CRCL_RotAccelRelativeDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_fraction, value.m_fraction)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotAccelRelativeDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelRelativeDataType clone = (CRCL_RotAccelRelativeDataType)base.MemberwiseClone();

            clone.m_fraction = (CRCL_FractionDataType)Utils.Clone(this.m_fraction);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_fraction;
        #endregion
    }

    #region CRCL_RotAccelRelativeDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotAccelRelativeDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotAccelRelativeDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotAccelRelativeDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotAccelRelativeDataTypeCollection : List<CRCL_RotAccelRelativeDataType>, ICloneable
    #else
    public partial class CRCL_RotAccelRelativeDataTypeCollection : List<CRCL_RotAccelRelativeDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotAccelRelativeDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotAccelRelativeDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotAccelRelativeDataTypeCollection(IEnumerable<CRCL_RotAccelRelativeDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotAccelRelativeDataTypeCollection(CRCL_RotAccelRelativeDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotAccelRelativeDataTypeCollection(values);
            }

            return new CRCL_RotAccelRelativeDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotAccelRelativeDataType[](CRCL_RotAccelRelativeDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotAccelRelativeDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotAccelRelativeDataTypeCollection clone = new CRCL_RotAccelRelativeDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotAccelRelativeDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotSpeedDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotSpeedDataType)
    /// <summary>
    /// CRCL RotSpeedDataType DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotSpeedDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotSpeedDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotSpeedDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotSpeedDataType value = encodeable as CRCL_RotSpeedDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotSpeedDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedDataType clone = (CRCL_RotSpeedDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CRCL_RotSpeedDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotSpeedDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotSpeedDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotSpeedDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotSpeedDataTypeCollection : List<CRCL_RotSpeedDataType>, ICloneable
    #else
    public partial class CRCL_RotSpeedDataTypeCollection : List<CRCL_RotSpeedDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotSpeedDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotSpeedDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotSpeedDataTypeCollection(IEnumerable<CRCL_RotSpeedDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotSpeedDataTypeCollection(CRCL_RotSpeedDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotSpeedDataTypeCollection(values);
            }

            return new CRCL_RotSpeedDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotSpeedDataType[](CRCL_RotSpeedDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotSpeedDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedDataTypeCollection clone = new CRCL_RotSpeedDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotSpeedDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotSpeedAbsoluteDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotSpeedAbsoluteDataType)
    /// <summary>
    /// CRCL RotSpeedAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotSpeedAbsoluteDataType : CRCL_RotSpeedDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotSpeedAbsoluteDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "setting", IsRequired = false, Order = 1)]
        public double setting
        {
            get { return m_setting;  }
            set { m_setting = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotSpeedAbsoluteDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedAbsoluteDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedAbsoluteDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("setting", setting);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            setting = decoder.ReadDouble("setting");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotSpeedAbsoluteDataType value = encodeable as CRCL_RotSpeedAbsoluteDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotSpeedAbsoluteDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedAbsoluteDataType clone = (CRCL_RotSpeedAbsoluteDataType)base.MemberwiseClone();

            clone.m_setting = (double)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_setting;
        #endregion
    }

    #region CRCL_RotSpeedAbsoluteDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotSpeedAbsoluteDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotSpeedAbsoluteDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotSpeedAbsoluteDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotSpeedAbsoluteDataTypeCollection : List<CRCL_RotSpeedAbsoluteDataType>, ICloneable
    #else
    public partial class CRCL_RotSpeedAbsoluteDataTypeCollection : List<CRCL_RotSpeedAbsoluteDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotSpeedAbsoluteDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotSpeedAbsoluteDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotSpeedAbsoluteDataTypeCollection(IEnumerable<CRCL_RotSpeedAbsoluteDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotSpeedAbsoluteDataTypeCollection(CRCL_RotSpeedAbsoluteDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotSpeedAbsoluteDataTypeCollection(values);
            }

            return new CRCL_RotSpeedAbsoluteDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotSpeedAbsoluteDataType[](CRCL_RotSpeedAbsoluteDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotSpeedAbsoluteDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedAbsoluteDataTypeCollection clone = new CRCL_RotSpeedAbsoluteDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotSpeedAbsoluteDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_RotSpeedRelativeDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_RotSpeedRelativeDataType)
    /// <summary>
    /// CRCL RotSpeedRelative DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_RotSpeedRelativeDataType : CRCL_RotSpeedDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_RotSpeedRelativeDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fraction = new CRCL_FractionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// fraction CRCL RotSpeedRelative DataType
        /// </summary>
        [DataMember(Name = "fraction", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType fraction
        {
            get
            {
                return m_fraction;
            }

            set
            {
                m_fraction = value;

                if (value == null)
                {
                    m_fraction = new CRCL_FractionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_RotSpeedRelativeDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedRelativeDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_RotSpeedRelativeDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("fraction", fraction, typeof(CRCL_FractionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fraction = (CRCL_FractionDataType)decoder.ReadEncodeable("fraction", typeof(CRCL_FractionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_RotSpeedRelativeDataType value = encodeable as CRCL_RotSpeedRelativeDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_fraction, value.m_fraction)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_RotSpeedRelativeDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedRelativeDataType clone = (CRCL_RotSpeedRelativeDataType)base.MemberwiseClone();

            clone.m_fraction = (CRCL_FractionDataType)Utils.Clone(this.m_fraction);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_fraction;
        #endregion
    }

    #region CRCL_RotSpeedRelativeDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_RotSpeedRelativeDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_RotSpeedRelativeDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_RotSpeedRelativeDataType")]
    #if !NET_STANDARD
    public partial class CRCL_RotSpeedRelativeDataTypeCollection : List<CRCL_RotSpeedRelativeDataType>, ICloneable
    #else
    public partial class CRCL_RotSpeedRelativeDataTypeCollection : List<CRCL_RotSpeedRelativeDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_RotSpeedRelativeDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_RotSpeedRelativeDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_RotSpeedRelativeDataTypeCollection(IEnumerable<CRCL_RotSpeedRelativeDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_RotSpeedRelativeDataTypeCollection(CRCL_RotSpeedRelativeDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_RotSpeedRelativeDataTypeCollection(values);
            }

            return new CRCL_RotSpeedRelativeDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_RotSpeedRelativeDataType[](CRCL_RotSpeedRelativeDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_RotSpeedRelativeDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_RotSpeedRelativeDataTypeCollection clone = new CRCL_RotSpeedRelativeDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_RotSpeedRelativeDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransAccelDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransAccelDataType)
    /// <summary>
    /// CRCL TransAccelAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransAccelDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransAccelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransAccelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransAccelDataType value = encodeable as CRCL_TransAccelDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransAccelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelDataType clone = (CRCL_TransAccelDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CRCL_TransAccelDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransAccelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransAccelDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransAccelDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransAccelDataTypeCollection : List<CRCL_TransAccelDataType>, ICloneable
    #else
    public partial class CRCL_TransAccelDataTypeCollection : List<CRCL_TransAccelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransAccelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransAccelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransAccelDataTypeCollection(IEnumerable<CRCL_TransAccelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransAccelDataTypeCollection(CRCL_TransAccelDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransAccelDataTypeCollection(values);
            }

            return new CRCL_TransAccelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransAccelDataType[](CRCL_TransAccelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransAccelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelDataTypeCollection clone = new CRCL_TransAccelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransAccelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransAccelAbsoluteDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransAccelAbsoluteDataType)
    /// <summary>
    /// CRCL TransAccelAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransAccelAbsoluteDataType : CRCL_TransAccelDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransAccelAbsoluteDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "setting", IsRequired = false, Order = 1)]
        public double setting
        {
            get { return m_setting;  }
            set { m_setting = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransAccelAbsoluteDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelAbsoluteDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelAbsoluteDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("setting", setting);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            setting = decoder.ReadDouble("setting");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransAccelAbsoluteDataType value = encodeable as CRCL_TransAccelAbsoluteDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransAccelAbsoluteDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelAbsoluteDataType clone = (CRCL_TransAccelAbsoluteDataType)base.MemberwiseClone();

            clone.m_setting = (double)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_setting;
        #endregion
    }

    #region CRCL_TransAccelAbsoluteDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransAccelAbsoluteDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransAccelAbsoluteDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransAccelAbsoluteDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransAccelAbsoluteDataTypeCollection : List<CRCL_TransAccelAbsoluteDataType>, ICloneable
    #else
    public partial class CRCL_TransAccelAbsoluteDataTypeCollection : List<CRCL_TransAccelAbsoluteDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransAccelAbsoluteDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransAccelAbsoluteDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransAccelAbsoluteDataTypeCollection(IEnumerable<CRCL_TransAccelAbsoluteDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransAccelAbsoluteDataTypeCollection(CRCL_TransAccelAbsoluteDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransAccelAbsoluteDataTypeCollection(values);
            }

            return new CRCL_TransAccelAbsoluteDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransAccelAbsoluteDataType[](CRCL_TransAccelAbsoluteDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransAccelAbsoluteDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelAbsoluteDataTypeCollection clone = new CRCL_TransAccelAbsoluteDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransAccelAbsoluteDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransAccelRelativeDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransAccelRelativeDataType)
    /// <summary>
    /// CRCL TransAccelRelative DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransAccelRelativeDataType : CRCL_TransAccelDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransAccelRelativeDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fraction = new CRCL_FractionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// fraction CRCL TransAccelRelative DataType
        /// </summary>
        [DataMember(Name = "fraction", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType fraction
        {
            get
            {
                return m_fraction;
            }

            set
            {
                m_fraction = value;

                if (value == null)
                {
                    m_fraction = new CRCL_FractionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransAccelRelativeDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelRelativeDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransAccelRelativeDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("fraction", fraction, typeof(CRCL_FractionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fraction = (CRCL_FractionDataType)decoder.ReadEncodeable("fraction", typeof(CRCL_FractionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransAccelRelativeDataType value = encodeable as CRCL_TransAccelRelativeDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_fraction, value.m_fraction)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransAccelRelativeDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelRelativeDataType clone = (CRCL_TransAccelRelativeDataType)base.MemberwiseClone();

            clone.m_fraction = (CRCL_FractionDataType)Utils.Clone(this.m_fraction);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_fraction;
        #endregion
    }

    #region CRCL_TransAccelRelativeDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransAccelRelativeDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransAccelRelativeDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransAccelRelativeDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransAccelRelativeDataTypeCollection : List<CRCL_TransAccelRelativeDataType>, ICloneable
    #else
    public partial class CRCL_TransAccelRelativeDataTypeCollection : List<CRCL_TransAccelRelativeDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransAccelRelativeDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransAccelRelativeDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransAccelRelativeDataTypeCollection(IEnumerable<CRCL_TransAccelRelativeDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransAccelRelativeDataTypeCollection(CRCL_TransAccelRelativeDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransAccelRelativeDataTypeCollection(values);
            }

            return new CRCL_TransAccelRelativeDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransAccelRelativeDataType[](CRCL_TransAccelRelativeDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransAccelRelativeDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransAccelRelativeDataTypeCollection clone = new CRCL_TransAccelRelativeDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransAccelRelativeDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransSpeedDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransSpeedDataType)
    /// <summary>
    /// CRCL TransAccelAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransSpeedDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransSpeedDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransSpeedDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransSpeedDataType value = encodeable as CRCL_TransSpeedDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransSpeedDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedDataType clone = (CRCL_TransSpeedDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CRCL_TransSpeedDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransSpeedDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransSpeedDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransSpeedDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransSpeedDataTypeCollection : List<CRCL_TransSpeedDataType>, ICloneable
    #else
    public partial class CRCL_TransSpeedDataTypeCollection : List<CRCL_TransSpeedDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransSpeedDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransSpeedDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransSpeedDataTypeCollection(IEnumerable<CRCL_TransSpeedDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransSpeedDataTypeCollection(CRCL_TransSpeedDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransSpeedDataTypeCollection(values);
            }

            return new CRCL_TransSpeedDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransSpeedDataType[](CRCL_TransSpeedDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransSpeedDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedDataTypeCollection clone = new CRCL_TransSpeedDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransSpeedDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransSpeedAbsoluteDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransSpeedAbsoluteDataType)
    /// <summary>
    /// CRCL TransSpeedAbsolute DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransSpeedAbsoluteDataType : CRCL_TransSpeedDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransSpeedAbsoluteDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "setting", IsRequired = false, Order = 1)]
        public double setting
        {
            get { return m_setting;  }
            set { m_setting = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransSpeedAbsoluteDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedAbsoluteDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedAbsoluteDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("setting", setting);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            setting = decoder.ReadDouble("setting");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransSpeedAbsoluteDataType value = encodeable as CRCL_TransSpeedAbsoluteDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransSpeedAbsoluteDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedAbsoluteDataType clone = (CRCL_TransSpeedAbsoluteDataType)base.MemberwiseClone();

            clone.m_setting = (double)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_setting;
        #endregion
    }

    #region CRCL_TransSpeedAbsoluteDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransSpeedAbsoluteDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransSpeedAbsoluteDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransSpeedAbsoluteDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransSpeedAbsoluteDataTypeCollection : List<CRCL_TransSpeedAbsoluteDataType>, ICloneable
    #else
    public partial class CRCL_TransSpeedAbsoluteDataTypeCollection : List<CRCL_TransSpeedAbsoluteDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransSpeedAbsoluteDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransSpeedAbsoluteDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransSpeedAbsoluteDataTypeCollection(IEnumerable<CRCL_TransSpeedAbsoluteDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransSpeedAbsoluteDataTypeCollection(CRCL_TransSpeedAbsoluteDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransSpeedAbsoluteDataTypeCollection(values);
            }

            return new CRCL_TransSpeedAbsoluteDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransSpeedAbsoluteDataType[](CRCL_TransSpeedAbsoluteDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransSpeedAbsoluteDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedAbsoluteDataTypeCollection clone = new CRCL_TransSpeedAbsoluteDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransSpeedAbsoluteDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_TransSpeedRelativeDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_TransSpeedRelativeDataType)
    /// <summary>
    /// CRCL TransSpeedRelative DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_TransSpeedRelativeDataType : CRCL_TransSpeedDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_TransSpeedRelativeDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fraction = new CRCL_FractionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// fraction CRCL TransSpeedRelative DataType
        /// </summary>
        [DataMember(Name = "fraction", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType fraction
        {
            get
            {
                return m_fraction;
            }

            set
            {
                m_fraction = value;

                if (value == null)
                {
                    m_fraction = new CRCL_FractionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_TransSpeedRelativeDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedRelativeDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_TransSpeedRelativeDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("fraction", fraction, typeof(CRCL_FractionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fraction = (CRCL_FractionDataType)decoder.ReadEncodeable("fraction", typeof(CRCL_FractionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_TransSpeedRelativeDataType value = encodeable as CRCL_TransSpeedRelativeDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_fraction, value.m_fraction)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_TransSpeedRelativeDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedRelativeDataType clone = (CRCL_TransSpeedRelativeDataType)base.MemberwiseClone();

            clone.m_fraction = (CRCL_FractionDataType)Utils.Clone(this.m_fraction);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_fraction;
        #endregion
    }

    #region CRCL_TransSpeedRelativeDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_TransSpeedRelativeDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_TransSpeedRelativeDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_TransSpeedRelativeDataType")]
    #if !NET_STANDARD
    public partial class CRCL_TransSpeedRelativeDataTypeCollection : List<CRCL_TransSpeedRelativeDataType>, ICloneable
    #else
    public partial class CRCL_TransSpeedRelativeDataTypeCollection : List<CRCL_TransSpeedRelativeDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_TransSpeedRelativeDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_TransSpeedRelativeDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_TransSpeedRelativeDataTypeCollection(IEnumerable<CRCL_TransSpeedRelativeDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_TransSpeedRelativeDataTypeCollection(CRCL_TransSpeedRelativeDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_TransSpeedRelativeDataTypeCollection(values);
            }

            return new CRCL_TransSpeedRelativeDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_TransSpeedRelativeDataType[](CRCL_TransSpeedRelativeDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_TransSpeedRelativeDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_TransSpeedRelativeDataTypeCollection clone = new CRCL_TransSpeedRelativeDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_TransSpeedRelativeDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_GuardLimitEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_GuardLimitEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_GuardLimitEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "OVER_MAX_0")]
        OVER_MAX = 0,

        /// <remarks />
        [EnumMember(Value = "UNDER_MIN_1")]
        UNDER_MIN = 1,

        /// <remarks />
        [EnumMember(Value = "INCREASE_OVER_LIMIT_2")]
        INCREASE_OVER_LIMIT = 2,

        /// <remarks />
        [EnumMember(Value = "DECREASE_BEYOND_LIMIT_3")]
        DECREASE_BEYOND_LIMIT = 3,
    }

    #region CRCL_GuardLimitEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_GuardLimitEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_GuardLimitEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_GuardLimitEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_GuardLimitEnumDataTypeCollection : List<CRCL_GuardLimitEnumDataType>, ICloneable
    #else
    public partial class CRCL_GuardLimitEnumDataTypeCollection : List<CRCL_GuardLimitEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_GuardLimitEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_GuardLimitEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_GuardLimitEnumDataTypeCollection(IEnumerable<CRCL_GuardLimitEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_GuardLimitEnumDataTypeCollection(CRCL_GuardLimitEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_GuardLimitEnumDataTypeCollection(values);
            }

            return new CRCL_GuardLimitEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_GuardLimitEnumDataType[](CRCL_GuardLimitEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_GuardLimitEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_GuardLimitEnumDataTypeCollection clone = new CRCL_GuardLimitEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_GuardLimitEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_GuardDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_GuardDataType)
    /// <summary>
    /// CRCL GuardType DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_GuardDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_GuardDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_sensorID = null;
            m_subField = null;
            m_limitType = CRCL_GuardLimitEnumDataType.OVER_MAX;
            m_limitValue = (double)0;
            m_recheckTimeMicroSeconds = (uint)0;
            m_checkCount = (uint)0;
            m_lastCheckTime = (uint)0;
            m_lastCheckValue = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "sensorID", IsRequired = false, Order = 1)]
        public string sensorID
        {
            get { return m_sensorID;  }
            set { m_sensorID = value; }
        }

        /// <remarks />
        [DataMember(Name = "subField", IsRequired = false, Order = 2)]
        public string subField
        {
            get { return m_subField;  }
            set { m_subField = value; }
        }

        /// <remarks />
        [DataMember(Name = "limitType", IsRequired = false, Order = 3)]
        public CRCL_GuardLimitEnumDataType limitType
        {
            get { return m_limitType;  }
            set { m_limitType = value; }
        }

        /// <remarks />
        [DataMember(Name = "limitValue", IsRequired = false, Order = 4)]
        public double limitValue
        {
            get { return m_limitValue;  }
            set { m_limitValue = value; }
        }

        /// <remarks />
        [DataMember(Name = "recheckTimeMicroSeconds", IsRequired = false, Order = 5)]
        public uint recheckTimeMicroSeconds
        {
            get { return m_recheckTimeMicroSeconds;  }
            set { m_recheckTimeMicroSeconds = value; }
        }

        /// <remarks />
        [DataMember(Name = "checkCount", IsRequired = false, Order = 6)]
        public uint checkCount
        {
            get { return m_checkCount;  }
            set { m_checkCount = value; }
        }

        /// <remarks />
        [DataMember(Name = "lastCheckTime", IsRequired = false, Order = 7)]
        public uint lastCheckTime
        {
            get { return m_lastCheckTime;  }
            set { m_lastCheckTime = value; }
        }

        /// <remarks />
        [DataMember(Name = "lastCheckValue", IsRequired = false, Order = 8)]
        public double lastCheckValue
        {
            get { return m_lastCheckValue;  }
            set { m_lastCheckValue = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_GuardDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_GuardDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_GuardDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("sensorID", sensorID);
            encoder.WriteString("subField", subField);
            encoder.WriteEnumerated("limitType", limitType);
            encoder.WriteDouble("limitValue", limitValue);
            encoder.WriteUInt32("recheckTimeMicroSeconds", recheckTimeMicroSeconds);
            encoder.WriteUInt32("checkCount", checkCount);
            encoder.WriteUInt32("lastCheckTime", lastCheckTime);
            encoder.WriteDouble("lastCheckValue", lastCheckValue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            sensorID = decoder.ReadString("sensorID");
            subField = decoder.ReadString("subField");
            limitType = (CRCL_GuardLimitEnumDataType)decoder.ReadEnumerated("limitType", typeof(CRCL_GuardLimitEnumDataType));
            limitValue = decoder.ReadDouble("limitValue");
            recheckTimeMicroSeconds = decoder.ReadUInt32("recheckTimeMicroSeconds");
            checkCount = decoder.ReadUInt32("checkCount");
            lastCheckTime = decoder.ReadUInt32("lastCheckTime");
            lastCheckValue = decoder.ReadDouble("lastCheckValue");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_GuardDataType value = encodeable as CRCL_GuardDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sensorID, value.m_sensorID)) return false;
            if (!Utils.IsEqual(m_subField, value.m_subField)) return false;
            if (!Utils.IsEqual(m_limitType, value.m_limitType)) return false;
            if (!Utils.IsEqual(m_limitValue, value.m_limitValue)) return false;
            if (!Utils.IsEqual(m_recheckTimeMicroSeconds, value.m_recheckTimeMicroSeconds)) return false;
            if (!Utils.IsEqual(m_checkCount, value.m_checkCount)) return false;
            if (!Utils.IsEqual(m_lastCheckTime, value.m_lastCheckTime)) return false;
            if (!Utils.IsEqual(m_lastCheckValue, value.m_lastCheckValue)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_GuardDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_GuardDataType clone = (CRCL_GuardDataType)base.MemberwiseClone();

            clone.m_sensorID = (string)Utils.Clone(this.m_sensorID);
            clone.m_subField = (string)Utils.Clone(this.m_subField);
            clone.m_limitType = (CRCL_GuardLimitEnumDataType)Utils.Clone(this.m_limitType);
            clone.m_limitValue = (double)Utils.Clone(this.m_limitValue);
            clone.m_recheckTimeMicroSeconds = (uint)Utils.Clone(this.m_recheckTimeMicroSeconds);
            clone.m_checkCount = (uint)Utils.Clone(this.m_checkCount);
            clone.m_lastCheckTime = (uint)Utils.Clone(this.m_lastCheckTime);
            clone.m_lastCheckValue = (double)Utils.Clone(this.m_lastCheckValue);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_sensorID;
        private string m_subField;
        private CRCL_GuardLimitEnumDataType m_limitType;
        private double m_limitValue;
        private uint m_recheckTimeMicroSeconds;
        private uint m_checkCount;
        private uint m_lastCheckTime;
        private double m_lastCheckValue;
        #endregion
    }

    #region CRCL_GuardDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_GuardDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_GuardDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_GuardDataType")]
    #if !NET_STANDARD
    public partial class CRCL_GuardDataTypeCollection : List<CRCL_GuardDataType>, ICloneable
    #else
    public partial class CRCL_GuardDataTypeCollection : List<CRCL_GuardDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_GuardDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_GuardDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_GuardDataTypeCollection(IEnumerable<CRCL_GuardDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_GuardDataTypeCollection(CRCL_GuardDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_GuardDataTypeCollection(values);
            }

            return new CRCL_GuardDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_GuardDataType[](CRCL_GuardDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_GuardDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_GuardDataTypeCollection clone = new CRCL_GuardDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_GuardDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointPositionToleranceSettingDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointPositionToleranceSettingDataType)
    /// <summary>
    /// CRCL JointPositionToleranceSettingDataType DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointPositionToleranceSettingDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointPositionToleranceSettingDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointNumber = (int)0;
            m_jointPositionTolerance = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "JointNumber", IsRequired = false, Order = 1)]
        public int JointNumber
        {
            get { return m_jointNumber;  }
            set { m_jointNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "JointPositionTolerance", IsRequired = false, Order = 2)]
        public double JointPositionTolerance
        {
            get { return m_jointPositionTolerance;  }
            set { m_jointPositionTolerance = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointPositionToleranceSettingDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointPositionToleranceSettingDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointPositionToleranceSettingDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteInt32("JointNumber", JointNumber);
            encoder.WriteDouble("JointPositionTolerance", JointPositionTolerance);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            JointNumber = decoder.ReadInt32("JointNumber");
            JointPositionTolerance = decoder.ReadDouble("JointPositionTolerance");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointPositionToleranceSettingDataType value = encodeable as CRCL_JointPositionToleranceSettingDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointNumber, value.m_jointNumber)) return false;
            if (!Utils.IsEqual(m_jointPositionTolerance, value.m_jointPositionTolerance)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointPositionToleranceSettingDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointPositionToleranceSettingDataType clone = (CRCL_JointPositionToleranceSettingDataType)base.MemberwiseClone();

            clone.m_jointNumber = (int)Utils.Clone(this.m_jointNumber);
            clone.m_jointPositionTolerance = (double)Utils.Clone(this.m_jointPositionTolerance);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_jointNumber;
        private double m_jointPositionTolerance;
        #endregion
    }

    #region CRCL_JointPositionToleranceSettingDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointPositionToleranceSettingDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointPositionToleranceSettingDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointPositionToleranceSettingDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointPositionToleranceSettingDataTypeCollection : List<CRCL_JointPositionToleranceSettingDataType>, ICloneable
    #else
    public partial class CRCL_JointPositionToleranceSettingDataTypeCollection : List<CRCL_JointPositionToleranceSettingDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointPositionToleranceSettingDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointPositionToleranceSettingDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointPositionToleranceSettingDataTypeCollection(IEnumerable<CRCL_JointPositionToleranceSettingDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointPositionToleranceSettingDataTypeCollection(CRCL_JointPositionToleranceSettingDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointPositionToleranceSettingDataTypeCollection(values);
            }

            return new CRCL_JointPositionToleranceSettingDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointPositionToleranceSettingDataType[](CRCL_JointPositionToleranceSettingDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointPositionToleranceSettingDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointPositionToleranceSettingDataTypeCollection clone = new CRCL_JointPositionToleranceSettingDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointPositionToleranceSettingDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointPositionsTolerancesDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointPositionsTolerancesDataType)
    /// <summary>
    /// CRCL CRCL_JointPositionsTolerancesDataType DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointPositionsTolerancesDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointPositionsTolerancesDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = new CRCL_JointPositionToleranceSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Setting CRCL JointPositionsTolerancesDataType DataType
        /// </summary>
        [DataMember(Name = "Setting", IsRequired = false, Order = 1)]
        public CRCL_JointPositionToleranceSettingDataTypeCollection Setting
        {
            get
            {
                return m_setting;
            }

            set
            {
                m_setting = value;

                if (value == null)
                {
                    m_setting = new CRCL_JointPositionToleranceSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointPositionsTolerancesDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointPositionsTolerancesDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointPositionsTolerancesDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("Setting", Setting.ToArray(), typeof(CRCL_JointPositionToleranceSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Setting = (CRCL_JointPositionToleranceSettingDataTypeCollection)decoder.ReadEncodeableArray("Setting", typeof(CRCL_JointPositionToleranceSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointPositionsTolerancesDataType value = encodeable as CRCL_JointPositionsTolerancesDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointPositionsTolerancesDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointPositionsTolerancesDataType clone = (CRCL_JointPositionsTolerancesDataType)base.MemberwiseClone();

            clone.m_setting = (CRCL_JointPositionToleranceSettingDataTypeCollection)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_JointPositionToleranceSettingDataTypeCollection m_setting;
        #endregion
    }

    #region CRCL_JointPositionsTolerancesDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointPositionsTolerancesDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointPositionsTolerancesDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointPositionsTolerancesDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointPositionsTolerancesDataTypeCollection : List<CRCL_JointPositionsTolerancesDataType>, ICloneable
    #else
    public partial class CRCL_JointPositionsTolerancesDataTypeCollection : List<CRCL_JointPositionsTolerancesDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointPositionsTolerancesDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointPositionsTolerancesDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointPositionsTolerancesDataTypeCollection(IEnumerable<CRCL_JointPositionsTolerancesDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointPositionsTolerancesDataTypeCollection(CRCL_JointPositionsTolerancesDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointPositionsTolerancesDataTypeCollection(values);
            }

            return new CRCL_JointPositionsTolerancesDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointPositionsTolerancesDataType[](CRCL_JointPositionsTolerancesDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointPositionsTolerancesDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointPositionsTolerancesDataTypeCollection clone = new CRCL_JointPositionsTolerancesDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointPositionsTolerancesDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_PoseAndSetDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_PoseAndSetDataType)
    /// <summary>
    /// CRCL PoseAndSet DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_PoseAndSetDataType : CRCL_PoseDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_PoseAndSetDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_coordinated = true;
            m_transSpeed = new CRCL_TransSpeedDataType();
            m_rotSpeed = new CRCL_RotSpeedDataType();
            m_transAccel = new CRCL_TransAccelDataType();
            m_rotAccel = new CRCL_RotAccelDataType();
            m_poseTolerance = new CRCL_PoseToleranceDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Coordinated", IsRequired = false, Order = 1)]
        public bool Coordinated
        {
            get { return m_coordinated;  }
            set { m_coordinated = value; }
        }

        /// <summary>
        /// TransSpeed CRCL PoseAndSet DataType
        /// </summary>
        [DataMember(Name = "TransSpeed", IsRequired = false, Order = 2)]
        public CRCL_TransSpeedDataType TransSpeed
        {
            get
            {
                return m_transSpeed;
            }

            set
            {
                m_transSpeed = value;

                if (value == null)
                {
                    m_transSpeed = new CRCL_TransSpeedDataType();
                }
            }
        }

        /// <summary>
        /// RotSpeed CRCL PoseAndSet DataType
        /// </summary>
        [DataMember(Name = "RotSpeed", IsRequired = false, Order = 3)]
        public CRCL_RotSpeedDataType RotSpeed
        {
            get
            {
                return m_rotSpeed;
            }

            set
            {
                m_rotSpeed = value;

                if (value == null)
                {
                    m_rotSpeed = new CRCL_RotSpeedDataType();
                }
            }
        }

        /// <summary>
        /// TransAccel CRCL PoseAndSet DataType
        /// </summary>
        [DataMember(Name = "TransAccel", IsRequired = false, Order = 4)]
        public CRCL_TransAccelDataType TransAccel
        {
            get
            {
                return m_transAccel;
            }

            set
            {
                m_transAccel = value;

                if (value == null)
                {
                    m_transAccel = new CRCL_TransAccelDataType();
                }
            }
        }

        /// <summary>
        /// RotAccel CRCL PoseAndSet DataType
        /// </summary>
        [DataMember(Name = "RotAccel", IsRequired = false, Order = 5)]
        public CRCL_RotAccelDataType RotAccel
        {
            get
            {
                return m_rotAccel;
            }

            set
            {
                m_rotAccel = value;

                if (value == null)
                {
                    m_rotAccel = new CRCL_RotAccelDataType();
                }
            }
        }

        /// <summary>
        /// PoseTolerance CRCL PoseAndSet DataType
        /// </summary>
        [DataMember(Name = "PoseTolerance", IsRequired = false, Order = 6)]
        public CRCL_PoseToleranceDataType PoseTolerance
        {
            get
            {
                return m_poseTolerance;
            }

            set
            {
                m_poseTolerance = value;

                if (value == null)
                {
                    m_poseTolerance = new CRCL_PoseToleranceDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_PoseAndSetDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_PoseAndSetDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_PoseAndSetDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("Coordinated", Coordinated);
            encoder.WriteEncodeable("TransSpeed", TransSpeed, typeof(CRCL_TransSpeedDataType));
            encoder.WriteEncodeable("RotSpeed", RotSpeed, typeof(CRCL_RotSpeedDataType));
            encoder.WriteEncodeable("TransAccel", TransAccel, typeof(CRCL_TransAccelDataType));
            encoder.WriteEncodeable("RotAccel", RotAccel, typeof(CRCL_RotAccelDataType));
            encoder.WriteEncodeable("PoseTolerance", PoseTolerance, typeof(CRCL_PoseToleranceDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Coordinated = decoder.ReadBoolean("Coordinated");
            TransSpeed = (CRCL_TransSpeedDataType)decoder.ReadEncodeable("TransSpeed", typeof(CRCL_TransSpeedDataType));
            RotSpeed = (CRCL_RotSpeedDataType)decoder.ReadEncodeable("RotSpeed", typeof(CRCL_RotSpeedDataType));
            TransAccel = (CRCL_TransAccelDataType)decoder.ReadEncodeable("TransAccel", typeof(CRCL_TransAccelDataType));
            RotAccel = (CRCL_RotAccelDataType)decoder.ReadEncodeable("RotAccel", typeof(CRCL_RotAccelDataType));
            PoseTolerance = (CRCL_PoseToleranceDataType)decoder.ReadEncodeable("PoseTolerance", typeof(CRCL_PoseToleranceDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_PoseAndSetDataType value = encodeable as CRCL_PoseAndSetDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_coordinated, value.m_coordinated)) return false;
            if (!Utils.IsEqual(m_transSpeed, value.m_transSpeed)) return false;
            if (!Utils.IsEqual(m_rotSpeed, value.m_rotSpeed)) return false;
            if (!Utils.IsEqual(m_transAccel, value.m_transAccel)) return false;
            if (!Utils.IsEqual(m_rotAccel, value.m_rotAccel)) return false;
            if (!Utils.IsEqual(m_poseTolerance, value.m_poseTolerance)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_PoseAndSetDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseAndSetDataType clone = (CRCL_PoseAndSetDataType)base.MemberwiseClone();

            clone.m_coordinated = (bool)Utils.Clone(this.m_coordinated);
            clone.m_transSpeed = (CRCL_TransSpeedDataType)Utils.Clone(this.m_transSpeed);
            clone.m_rotSpeed = (CRCL_RotSpeedDataType)Utils.Clone(this.m_rotSpeed);
            clone.m_transAccel = (CRCL_TransAccelDataType)Utils.Clone(this.m_transAccel);
            clone.m_rotAccel = (CRCL_RotAccelDataType)Utils.Clone(this.m_rotAccel);
            clone.m_poseTolerance = (CRCL_PoseToleranceDataType)Utils.Clone(this.m_poseTolerance);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_coordinated;
        private CRCL_TransSpeedDataType m_transSpeed;
        private CRCL_RotSpeedDataType m_rotSpeed;
        private CRCL_TransAccelDataType m_transAccel;
        private CRCL_RotAccelDataType m_rotAccel;
        private CRCL_PoseToleranceDataType m_poseTolerance;
        #endregion
    }

    #region CRCL_PoseAndSetDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_PoseAndSetDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_PoseAndSetDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_PoseAndSetDataType")]
    #if !NET_STANDARD
    public partial class CRCL_PoseAndSetDataTypeCollection : List<CRCL_PoseAndSetDataType>, ICloneable
    #else
    public partial class CRCL_PoseAndSetDataTypeCollection : List<CRCL_PoseAndSetDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_PoseAndSetDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_PoseAndSetDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_PoseAndSetDataTypeCollection(IEnumerable<CRCL_PoseAndSetDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_PoseAndSetDataTypeCollection(CRCL_PoseAndSetDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_PoseAndSetDataTypeCollection(values);
            }

            return new CRCL_PoseAndSetDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_PoseAndSetDataType[](CRCL_PoseAndSetDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_PoseAndSetDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseAndSetDataTypeCollection clone = new CRCL_PoseAndSetDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_PoseAndSetDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCLCommandDataType Class
    #if (!OPCUA_EXCLUDE_CRCLCommandDataType)
    /// <summary>
    /// Base CRCLCommand
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCLCommandDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCLCommandDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_commandID = (uint)0;
            m_guard = new CRCL_GuardDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "commandID", IsRequired = false, Order = 1)]
        public uint commandID
        {
            get { return m_commandID;  }
            set { m_commandID = value; }
        }

        /// <summary>
        /// Guard of the CRCLCommand
        /// </summary>
        [DataMember(Name = "Guard", IsRequired = false, Order = 2)]
        public CRCL_GuardDataTypeCollection Guard
        {
            get
            {
                return m_guard;
            }

            set
            {
                m_guard = value;

                if (value == null)
                {
                    m_guard = new CRCL_GuardDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCLCommandDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCLCommandDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCLCommandDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("commandID", commandID);
            encoder.WriteEncodeableArray("Guard", Guard.ToArray(), typeof(CRCL_GuardDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            commandID = decoder.ReadUInt32("commandID");
            Guard = (CRCL_GuardDataTypeCollection)decoder.ReadEncodeableArray("Guard", typeof(CRCL_GuardDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCLCommandDataType value = encodeable as CRCLCommandDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_commandID, value.m_commandID)) return false;
            if (!Utils.IsEqual(m_guard, value.m_guard)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCLCommandDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLCommandDataType clone = (CRCLCommandDataType)base.MemberwiseClone();

            clone.m_commandID = (uint)Utils.Clone(this.m_commandID);
            clone.m_guard = (CRCL_GuardDataTypeCollection)Utils.Clone(this.m_guard);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_commandID;
        private CRCL_GuardDataTypeCollection m_guard;
        #endregion
    }

    #region CRCLCommandDataTypeCollection Class
    /// <summary>
    /// A collection of CRCLCommandDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCLCommandDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCLCommandDataType")]
    #if !NET_STANDARD
    public partial class CRCLCommandDataTypeCollection : List<CRCLCommandDataType>, ICloneable
    #else
    public partial class CRCLCommandDataTypeCollection : List<CRCLCommandDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCLCommandDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCLCommandDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCLCommandDataTypeCollection(IEnumerable<CRCLCommandDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCLCommandDataTypeCollection(CRCLCommandDataType[] values)
        {
            if (values != null)
            {
                return new CRCLCommandDataTypeCollection(values);
            }

            return new CRCLCommandDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCLCommandDataType[](CRCLCommandDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCLCommandDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLCommandDataTypeCollection clone = new CRCLCommandDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCLCommandDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MiddleCommandDataType Class
    #if (!OPCUA_EXCLUDE_MiddleCommandDataType)
    /// <summary>
    /// CRCL MiddleCommand
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class MiddleCommandDataType : CRCLCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MiddleCommandDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MiddleCommandDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MiddleCommandDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MiddleCommandDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MiddleCommandDataType value = encodeable as MiddleCommandDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (MiddleCommandDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MiddleCommandDataType clone = (MiddleCommandDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region MiddleCommandDataTypeCollection Class
    /// <summary>
    /// A collection of MiddleCommandDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMiddleCommandDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "MiddleCommandDataType")]
    #if !NET_STANDARD
    public partial class MiddleCommandDataTypeCollection : List<MiddleCommandDataType>, ICloneable
    #else
    public partial class MiddleCommandDataTypeCollection : List<MiddleCommandDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MiddleCommandDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MiddleCommandDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MiddleCommandDataTypeCollection(IEnumerable<MiddleCommandDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MiddleCommandDataTypeCollection(MiddleCommandDataType[] values)
        {
            if (values != null)
            {
                return new MiddleCommandDataTypeCollection(values);
            }

            return new MiddleCommandDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MiddleCommandDataType[](MiddleCommandDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MiddleCommandDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MiddleCommandDataTypeCollection clone = new MiddleCommandDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MiddleCommandDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EndCanonDataType Class
    #if (!OPCUA_EXCLUDE_EndCanonDataType)
    /// <summary>
    /// CRCL EndCanonType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class EndCanonDataType : CRCLCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public EndCanonDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.EndCanonDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.EndCanonDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.EndCanonDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            EndCanonDataType value = encodeable as EndCanonDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (EndCanonDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EndCanonDataType clone = (EndCanonDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region EndCanonDataTypeCollection Class
    /// <summary>
    /// A collection of EndCanonDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEndCanonDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "EndCanonDataType")]
    #if !NET_STANDARD
    public partial class EndCanonDataTypeCollection : List<EndCanonDataType>, ICloneable
    #else
    public partial class EndCanonDataTypeCollection : List<EndCanonDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public EndCanonDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public EndCanonDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public EndCanonDataTypeCollection(IEnumerable<EndCanonDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator EndCanonDataTypeCollection(EndCanonDataType[] values)
        {
            if (values != null)
            {
                return new EndCanonDataTypeCollection(values);
            }

            return new EndCanonDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator EndCanonDataType[](EndCanonDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (EndCanonDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EndCanonDataTypeCollection clone = new EndCanonDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EndCanonDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region InitCanonDataType Class
    #if (!OPCUA_EXCLUDE_InitCanonDataType)
    /// <summary>
    /// CRCL InitCanonType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class InitCanonDataType : CRCLCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public InitCanonDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.InitCanonDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.InitCanonDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.InitCanonDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            InitCanonDataType value = encodeable as InitCanonDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (InitCanonDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            InitCanonDataType clone = (InitCanonDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region InitCanonDataTypeCollection Class
    /// <summary>
    /// A collection of InitCanonDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfInitCanonDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "InitCanonDataType")]
    #if !NET_STANDARD
    public partial class InitCanonDataTypeCollection : List<InitCanonDataType>, ICloneable
    #else
    public partial class InitCanonDataTypeCollection : List<InitCanonDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public InitCanonDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public InitCanonDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public InitCanonDataTypeCollection(IEnumerable<InitCanonDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator InitCanonDataTypeCollection(InitCanonDataType[] values)
        {
            if (values != null)
            {
                return new InitCanonDataTypeCollection(values);
            }

            return new InitCanonDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator InitCanonDataType[](InitCanonDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (InitCanonDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            InitCanonDataTypeCollection clone = new InitCanonDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((InitCanonDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointDetailsDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointDetailsDataType)
    /// <summary>
    /// CRCL JointDetailsType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointDetailsDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointDetailsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointDetailsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointDetailsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointDetailsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointDetailsDataType value = encodeable as CRCL_JointDetailsDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointDetailsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointDetailsDataType clone = (CRCL_JointDetailsDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CRCL_JointDetailsDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointDetailsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointDetailsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointDetailsDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointDetailsDataTypeCollection : List<CRCL_JointDetailsDataType>, ICloneable
    #else
    public partial class CRCL_JointDetailsDataTypeCollection : List<CRCL_JointDetailsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointDetailsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointDetailsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointDetailsDataTypeCollection(IEnumerable<CRCL_JointDetailsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointDetailsDataTypeCollection(CRCL_JointDetailsDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointDetailsDataTypeCollection(values);
            }

            return new CRCL_JointDetailsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointDetailsDataType[](CRCL_JointDetailsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointDetailsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointDetailsDataTypeCollection clone = new CRCL_JointDetailsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointDetailsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ActuateJointDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ActuateJointDataType)
    /// <summary>
    /// CRCL ActuateJointType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ActuateJointDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ActuateJointDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointNumber = (int)0;
            m_cRCL:JointPosition = (double)0;
            m_cRCL:JointDetails = Variant.Null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "JointNumber", IsRequired = false, Order = 1)]
        public int JointNumber
        {
            get { return m_jointNumber;  }
            set { m_jointNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "CRCL:JointPosition", IsRequired = false, Order = 2)]
        public double CRCL:JointPosition
        {
            get { return m_cRCL:JointPosition;  }
            set { m_cRCL:JointPosition = value; }
        }

        /// <remarks />
        [DataMember(Name = "CRCL:JointDetails", IsRequired = false, Order = 3)]
        public Variant CRCL:JointDetails
        {
            get { return m_cRCL:JointDetails;  }
            set { m_cRCL:JointDetails = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ActuateJointDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ActuateJointDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ActuateJointDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteInt32("JointNumber", JointNumber);
            encoder.WriteDouble("CRCL:JointPosition", CRCL:JointPosition);
            encoder.WriteVariant("CRCL:JointDetails", CRCL:JointDetails);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            JointNumber = decoder.ReadInt32("JointNumber");
            CRCL:JointPosition = decoder.ReadDouble("CRCL:JointPosition");
            CRCL:JointDetails = decoder.ReadVariant("CRCL:JointDetails");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ActuateJointDataType value = encodeable as CRCL_ActuateJointDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointNumber, value.m_jointNumber)) return false;
            if (!Utils.IsEqual(m_cRCL:JointPosition, value.m_cRCL:JointPosition)) return false;
            if (!Utils.IsEqual(m_cRCL:JointDetails, value.m_cRCL:JointDetails)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ActuateJointDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ActuateJointDataType clone = (CRCL_ActuateJointDataType)base.MemberwiseClone();

            clone.m_jointNumber = (int)Utils.Clone(this.m_jointNumber);
            clone.m_cRCL:JointPosition = (double)Utils.Clone(this.m_cRCL:JointPosition);
            clone.m_cRCL:JointDetails = (Variant)Utils.Clone(this.m_cRCL:JointDetails);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_jointNumber;
        private double m_cRCL:JointPosition;
        private Variant m_cRCL:JointDetails;
        #endregion
    }

    #region CRCL_ActuateJointDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ActuateJointDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ActuateJointDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ActuateJointDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ActuateJointDataTypeCollection : List<CRCL_ActuateJointDataType>, ICloneable
    #else
    public partial class CRCL_ActuateJointDataTypeCollection : List<CRCL_ActuateJointDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ActuateJointDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ActuateJointDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ActuateJointDataTypeCollection(IEnumerable<CRCL_ActuateJointDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ActuateJointDataTypeCollection(CRCL_ActuateJointDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ActuateJointDataTypeCollection(values);
            }

            return new CRCL_ActuateJointDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ActuateJointDataType[](CRCL_ActuateJointDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ActuateJointDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ActuateJointDataTypeCollection clone = new CRCL_ActuateJointDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ActuateJointDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region JointForceTorqueDataType Class
    #if (!OPCUA_EXCLUDE_JointForceTorqueDataType)
    /// <summary>
    /// CRCL ActuateJointsType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class JointForceTorqueDataType : CRCL_JointDetailsDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public JointForceTorqueDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_cRCL:Setting = (double)0;
            m_cRCL:ChangeRate = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "CRCL:Setting", IsRequired = false, Order = 1)]
        public double CRCL:Setting
        {
            get { return m_cRCL:Setting;  }
            set { m_cRCL:Setting = value; }
        }

        /// <remarks />
        [DataMember(Name = "CRCL:ChangeRate", IsRequired = false, Order = 2)]
        public double CRCL:ChangeRate
        {
            get { return m_cRCL:ChangeRate;  }
            set { m_cRCL:ChangeRate = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.JointForceTorqueDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.JointForceTorqueDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.JointForceTorqueDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("CRCL:Setting", CRCL:Setting);
            encoder.WriteDouble("CRCL:ChangeRate", CRCL:ChangeRate);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            CRCL:Setting = decoder.ReadDouble("CRCL:Setting");
            CRCL:ChangeRate = decoder.ReadDouble("CRCL:ChangeRate");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            JointForceTorqueDataType value = encodeable as JointForceTorqueDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_cRCL:Setting, value.m_cRCL:Setting)) return false;
            if (!Utils.IsEqual(m_cRCL:ChangeRate, value.m_cRCL:ChangeRate)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (JointForceTorqueDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JointForceTorqueDataType clone = (JointForceTorqueDataType)base.MemberwiseClone();

            clone.m_cRCL:Setting = (double)Utils.Clone(this.m_cRCL:Setting);
            clone.m_cRCL:ChangeRate = (double)Utils.Clone(this.m_cRCL:ChangeRate);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_cRCL:Setting;
        private double m_cRCL:ChangeRate;
        #endregion
    }

    #region JointForceTorqueDataTypeCollection Class
    /// <summary>
    /// A collection of JointForceTorqueDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfJointForceTorqueDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "JointForceTorqueDataType")]
    #if !NET_STANDARD
    public partial class JointForceTorqueDataTypeCollection : List<JointForceTorqueDataType>, ICloneable
    #else
    public partial class JointForceTorqueDataTypeCollection : List<JointForceTorqueDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public JointForceTorqueDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public JointForceTorqueDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public JointForceTorqueDataTypeCollection(IEnumerable<JointForceTorqueDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator JointForceTorqueDataTypeCollection(JointForceTorqueDataType[] values)
        {
            if (values != null)
            {
                return new JointForceTorqueDataTypeCollection(values);
            }

            return new JointForceTorqueDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator JointForceTorqueDataType[](JointForceTorqueDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (JointForceTorqueDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JointForceTorqueDataTypeCollection clone = new JointForceTorqueDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((JointForceTorqueDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region JointSpeedAccelDataType Class
    #if (!OPCUA_EXCLUDE_JointSpeedAccelDataType)
    /// <summary>
    /// CRCL ActuateJointsType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class JointSpeedAccelDataType : CRCL_JointDetailsDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public JointSpeedAccelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_cRCL:JointSpeed = (double)0;
            m_cRCL:JointAccel = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "CRCL:JointSpeed", IsRequired = false, Order = 1)]
        public double CRCL:JointSpeed
        {
            get { return m_cRCL:JointSpeed;  }
            set { m_cRCL:JointSpeed = value; }
        }

        /// <remarks />
        [DataMember(Name = "CRCL:JointAccel", IsRequired = false, Order = 2)]
        public double CRCL:JointAccel
        {
            get { return m_cRCL:JointAccel;  }
            set { m_cRCL:JointAccel = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.JointSpeedAccelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.JointSpeedAccelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.JointSpeedAccelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("CRCL:JointSpeed", CRCL:JointSpeed);
            encoder.WriteDouble("CRCL:JointAccel", CRCL:JointAccel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            CRCL:JointSpeed = decoder.ReadDouble("CRCL:JointSpeed");
            CRCL:JointAccel = decoder.ReadDouble("CRCL:JointAccel");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            JointSpeedAccelDataType value = encodeable as JointSpeedAccelDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_cRCL:JointSpeed, value.m_cRCL:JointSpeed)) return false;
            if (!Utils.IsEqual(m_cRCL:JointAccel, value.m_cRCL:JointAccel)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (JointSpeedAccelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JointSpeedAccelDataType clone = (JointSpeedAccelDataType)base.MemberwiseClone();

            clone.m_cRCL:JointSpeed = (double)Utils.Clone(this.m_cRCL:JointSpeed);
            clone.m_cRCL:JointAccel = (double)Utils.Clone(this.m_cRCL:JointAccel);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_cRCL:JointSpeed;
        private double m_cRCL:JointAccel;
        #endregion
    }

    #region JointSpeedAccelDataTypeCollection Class
    /// <summary>
    /// A collection of JointSpeedAccelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfJointSpeedAccelDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "JointSpeedAccelDataType")]
    #if !NET_STANDARD
    public partial class JointSpeedAccelDataTypeCollection : List<JointSpeedAccelDataType>, ICloneable
    #else
    public partial class JointSpeedAccelDataTypeCollection : List<JointSpeedAccelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public JointSpeedAccelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public JointSpeedAccelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public JointSpeedAccelDataTypeCollection(IEnumerable<JointSpeedAccelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator JointSpeedAccelDataTypeCollection(JointSpeedAccelDataType[] values)
        {
            if (values != null)
            {
                return new JointSpeedAccelDataTypeCollection(values);
            }

            return new JointSpeedAccelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator JointSpeedAccelDataType[](JointSpeedAccelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (JointSpeedAccelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JointSpeedAccelDataTypeCollection clone = new JointSpeedAccelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((JointSpeedAccelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ActuateJointsDataType Class
    #if (!OPCUA_EXCLUDE_ActuateJointsDataType)
    /// <summary>
    /// CRCL ActuateJointsType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class ActuateJointsDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ActuateJointsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_cRCL:JointSpeed = (double)0;
            m_cRCL:JointAccel = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "CRCL:JointSpeed", IsRequired = false, Order = 1)]
        public double CRCL:JointSpeed
        {
            get { return m_cRCL:JointSpeed;  }
            set { m_cRCL:JointSpeed = value; }
        }

        /// <remarks />
        [DataMember(Name = "CRCL:JointAccel", IsRequired = false, Order = 2)]
        public double CRCL:JointAccel
        {
            get { return m_cRCL:JointAccel;  }
            set { m_cRCL:JointAccel = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ActuateJointsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ActuateJointsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ActuateJointsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("CRCL:JointSpeed", CRCL:JointSpeed);
            encoder.WriteDouble("CRCL:JointAccel", CRCL:JointAccel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            CRCL:JointSpeed = decoder.ReadDouble("CRCL:JointSpeed");
            CRCL:JointAccel = decoder.ReadDouble("CRCL:JointAccel");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ActuateJointsDataType value = encodeable as ActuateJointsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_cRCL:JointSpeed, value.m_cRCL:JointSpeed)) return false;
            if (!Utils.IsEqual(m_cRCL:JointAccel, value.m_cRCL:JointAccel)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (ActuateJointsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ActuateJointsDataType clone = (ActuateJointsDataType)base.MemberwiseClone();

            clone.m_cRCL:JointSpeed = (double)Utils.Clone(this.m_cRCL:JointSpeed);
            clone.m_cRCL:JointAccel = (double)Utils.Clone(this.m_cRCL:JointAccel);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_cRCL:JointSpeed;
        private double m_cRCL:JointAccel;
        #endregion
    }

    #region ActuateJointsDataTypeCollection Class
    /// <summary>
    /// A collection of ActuateJointsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfActuateJointsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "ActuateJointsDataType")]
    #if !NET_STANDARD
    public partial class ActuateJointsDataTypeCollection : List<ActuateJointsDataType>, ICloneable
    #else
    public partial class ActuateJointsDataTypeCollection : List<ActuateJointsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ActuateJointsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ActuateJointsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ActuateJointsDataTypeCollection(IEnumerable<ActuateJointsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ActuateJointsDataTypeCollection(ActuateJointsDataType[] values)
        {
            if (values != null)
            {
                return new ActuateJointsDataTypeCollection(values);
            }

            return new ActuateJointsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ActuateJointsDataType[](ActuateJointsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ActuateJointsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ActuateJointsDataTypeCollection clone = new ActuateJointsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ActuateJointsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MoveToDataType Class
    #if (!OPCUA_EXCLUDE_MoveToDataType)
    /// <summary>
    /// CRCL MoveTo
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class MoveToDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MoveToDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_moveStraight = true;
            m_endPosition = new CRCL_PoseDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "MoveStraight", IsRequired = false, Order = 1)]
        public bool MoveStraight
        {
            get { return m_moveStraight;  }
            set { m_moveStraight = value; }
        }

        /// <summary>
        /// Name of the CRCLCommand
        /// </summary>
        [DataMember(Name = "EndPosition", IsRequired = false, Order = 2)]
        public CRCL_PoseDataType EndPosition
        {
            get
            {
                return m_endPosition;
            }

            set
            {
                m_endPosition = value;

                if (value == null)
                {
                    m_endPosition = new CRCL_PoseDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MoveToDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MoveToDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MoveToDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("MoveStraight", MoveStraight);
            encoder.WriteEncodeable("EndPosition", EndPosition, typeof(CRCL_PoseDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            MoveStraight = decoder.ReadBoolean("MoveStraight");
            EndPosition = (CRCL_PoseDataType)decoder.ReadEncodeable("EndPosition", typeof(CRCL_PoseDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MoveToDataType value = encodeable as MoveToDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_moveStraight, value.m_moveStraight)) return false;
            if (!Utils.IsEqual(m_endPosition, value.m_endPosition)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (MoveToDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveToDataType clone = (MoveToDataType)base.MemberwiseClone();

            clone.m_moveStraight = (bool)Utils.Clone(this.m_moveStraight);
            clone.m_endPosition = (CRCL_PoseDataType)Utils.Clone(this.m_endPosition);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_moveStraight;
        private CRCL_PoseDataType m_endPosition;
        #endregion
    }

    #region MoveToDataTypeCollection Class
    /// <summary>
    /// A collection of MoveToDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMoveToDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "MoveToDataType")]
    #if !NET_STANDARD
    public partial class MoveToDataTypeCollection : List<MoveToDataType>, ICloneable
    #else
    public partial class MoveToDataTypeCollection : List<MoveToDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MoveToDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MoveToDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MoveToDataTypeCollection(IEnumerable<MoveToDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MoveToDataTypeCollection(MoveToDataType[] values)
        {
            if (values != null)
            {
                return new MoveToDataTypeCollection(values);
            }

            return new MoveToDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MoveToDataType[](MoveToDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MoveToDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveToDataTypeCollection clone = new MoveToDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MoveToDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CloseToolChangerDataType Class
    #if (!OPCUA_EXCLUDE_CloseToolChangerDataType)
    /// <summary>
    /// CRCL CloseToolChanger MiddleCommand
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CloseToolChangerDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CloseToolChangerDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CloseToolChangerDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CloseToolChangerDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CloseToolChangerDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CloseToolChangerDataType value = encodeable as CloseToolChangerDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CloseToolChangerDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CloseToolChangerDataType clone = (CloseToolChangerDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CloseToolChangerDataTypeCollection Class
    /// <summary>
    /// A collection of CloseToolChangerDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCloseToolChangerDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CloseToolChangerDataType")]
    #if !NET_STANDARD
    public partial class CloseToolChangerDataTypeCollection : List<CloseToolChangerDataType>, ICloneable
    #else
    public partial class CloseToolChangerDataTypeCollection : List<CloseToolChangerDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CloseToolChangerDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CloseToolChangerDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CloseToolChangerDataTypeCollection(IEnumerable<CloseToolChangerDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CloseToolChangerDataTypeCollection(CloseToolChangerDataType[] values)
        {
            if (values != null)
            {
                return new CloseToolChangerDataTypeCollection(values);
            }

            return new CloseToolChangerDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CloseToolChangerDataType[](CloseToolChangerDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CloseToolChangerDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CloseToolChangerDataTypeCollection clone = new CloseToolChangerDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CloseToolChangerDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DwellDataType Class
    #if (!OPCUA_EXCLUDE_DwellDataType)
    /// <summary>
    /// CRCL Dwell
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class DwellDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DwellDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_dwellTime = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "DwellTime", IsRequired = false, Order = 1)]
        public double DwellTime
        {
            get { return m_dwellTime;  }
            set { m_dwellTime = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DwellDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DwellDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DwellDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("DwellTime", DwellTime);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            DwellTime = decoder.ReadDouble("DwellTime");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DwellDataType value = encodeable as DwellDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_dwellTime, value.m_dwellTime)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (DwellDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DwellDataType clone = (DwellDataType)base.MemberwiseClone();

            clone.m_dwellTime = (double)Utils.Clone(this.m_dwellTime);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_dwellTime;
        #endregion
    }

    #region DwellDataTypeCollection Class
    /// <summary>
    /// A collection of DwellDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDwellDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "DwellDataType")]
    #if !NET_STANDARD
    public partial class DwellDataTypeCollection : List<DwellDataType>, ICloneable
    #else
    public partial class DwellDataTypeCollection : List<DwellDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DwellDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DwellDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DwellDataTypeCollection(IEnumerable<DwellDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DwellDataTypeCollection(DwellDataType[] values)
        {
            if (values != null)
            {
                return new DwellDataTypeCollection(values);
            }

            return new DwellDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DwellDataType[](DwellDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DwellDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DwellDataTypeCollection clone = new DwellDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DwellDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region GetStatusDataType Class
    #if (!OPCUA_EXCLUDE_GetStatusDataType)
    /// <summary>
    /// CRCL GetStatus
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class GetStatusDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public GetStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.GetStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.GetStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.GetStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            GetStatusDataType value = encodeable as GetStatusDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (GetStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            GetStatusDataType clone = (GetStatusDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region GetStatusDataTypeCollection Class
    /// <summary>
    /// A collection of GetStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfGetStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "GetStatusDataType")]
    #if !NET_STANDARD
    public partial class GetStatusDataTypeCollection : List<GetStatusDataType>, ICloneable
    #else
    public partial class GetStatusDataTypeCollection : List<GetStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public GetStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public GetStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public GetStatusDataTypeCollection(IEnumerable<GetStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator GetStatusDataTypeCollection(GetStatusDataType[] values)
        {
            if (values != null)
            {
                return new GetStatusDataTypeCollection(values);
            }

            return new GetStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator GetStatusDataType[](GetStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (GetStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            GetStatusDataTypeCollection clone = new GetStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((GetStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MessageDataType Class
    #if (!OPCUA_EXCLUDE_MessageDataType)
    /// <summary>
    /// CRCL Message
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class MessageDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MessageDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_message = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Message", IsRequired = false, Order = 1)]
        public string Message
        {
            get { return m_message;  }
            set { m_message = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MessageDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MessageDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MessageDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("Message", Message);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Message = decoder.ReadString("Message");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MessageDataType value = encodeable as MessageDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_message, value.m_message)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (MessageDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MessageDataType clone = (MessageDataType)base.MemberwiseClone();

            clone.m_message = (string)Utils.Clone(this.m_message);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_message;
        #endregion
    }

    #region MessageDataTypeCollection Class
    /// <summary>
    /// A collection of MessageDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMessageDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "MessageDataType")]
    #if !NET_STANDARD
    public partial class MessageDataTypeCollection : List<MessageDataType>, ICloneable
    #else
    public partial class MessageDataTypeCollection : List<MessageDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MessageDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MessageDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MessageDataTypeCollection(IEnumerable<MessageDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MessageDataTypeCollection(MessageDataType[] values)
        {
            if (values != null)
            {
                return new MessageDataTypeCollection(values);
            }

            return new MessageDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MessageDataType[](MessageDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MessageDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MessageDataTypeCollection clone = new MessageDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MessageDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MoveScrewDataType Class
    #if (!OPCUA_EXCLUDE_MoveScrewDataType)
    /// <summary>
    /// CRCL MoveScrew
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class MoveScrewDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MoveScrewDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_startPosition = new CRCL_PoseDataType();
            m_axisPoint = new CRCL_PointDataType();
            m_axialDistanceFree = (double)0;
            m_axialDistanceScrew = (double)0;
            m_turn = (double)0;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// StartPosition of MoveScrew
        /// </summary>
        [DataMember(Name = "StartPosition", IsRequired = false, Order = 1)]
        public CRCL_PoseDataType StartPosition
        {
            get
            {
                return m_startPosition;
            }

            set
            {
                m_startPosition = value;

                if (value == null)
                {
                    m_startPosition = new CRCL_PoseDataType();
                }
            }
        }

        /// <summary>
        /// AxisPoint of MoveScrew
        /// </summary>
        [DataMember(Name = "AxisPoint", IsRequired = false, Order = 2)]
        public CRCL_PointDataType AxisPoint
        {
            get
            {
                return m_axisPoint;
            }

            set
            {
                m_axisPoint = value;

                if (value == null)
                {
                    m_axisPoint = new CRCL_PointDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "AxialDistanceFree", IsRequired = false, Order = 3)]
        public double AxialDistanceFree
        {
            get { return m_axialDistanceFree;  }
            set { m_axialDistanceFree = value; }
        }

        /// <remarks />
        [DataMember(Name = "AxialDistanceScrew", IsRequired = false, Order = 4)]
        public double AxialDistanceScrew
        {
            get { return m_axialDistanceScrew;  }
            set { m_axialDistanceScrew = value; }
        }

        /// <remarks />
        [DataMember(Name = "Turn", IsRequired = false, Order = 5)]
        public double Turn
        {
            get { return m_turn;  }
            set { m_turn = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MoveScrewDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MoveScrewDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MoveScrewDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("StartPosition", StartPosition, typeof(CRCL_PoseDataType));
            encoder.WriteEncodeable("AxisPoint", AxisPoint, typeof(CRCL_PointDataType));
            encoder.WriteDouble("AxialDistanceFree", AxialDistanceFree);
            encoder.WriteDouble("AxialDistanceScrew", AxialDistanceScrew);
            encoder.WriteDouble("Turn", Turn);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            StartPosition = (CRCL_PoseDataType)decoder.ReadEncodeable("StartPosition", typeof(CRCL_PoseDataType));
            AxisPoint = (CRCL_PointDataType)decoder.ReadEncodeable("AxisPoint", typeof(CRCL_PointDataType));
            AxialDistanceFree = decoder.ReadDouble("AxialDistanceFree");
            AxialDistanceScrew = decoder.ReadDouble("AxialDistanceScrew");
            Turn = decoder.ReadDouble("Turn");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MoveScrewDataType value = encodeable as MoveScrewDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_startPosition, value.m_startPosition)) return false;
            if (!Utils.IsEqual(m_axisPoint, value.m_axisPoint)) return false;
            if (!Utils.IsEqual(m_axialDistanceFree, value.m_axialDistanceFree)) return false;
            if (!Utils.IsEqual(m_axialDistanceScrew, value.m_axialDistanceScrew)) return false;
            if (!Utils.IsEqual(m_turn, value.m_turn)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (MoveScrewDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveScrewDataType clone = (MoveScrewDataType)base.MemberwiseClone();

            clone.m_startPosition = (CRCL_PoseDataType)Utils.Clone(this.m_startPosition);
            clone.m_axisPoint = (CRCL_PointDataType)Utils.Clone(this.m_axisPoint);
            clone.m_axialDistanceFree = (double)Utils.Clone(this.m_axialDistanceFree);
            clone.m_axialDistanceScrew = (double)Utils.Clone(this.m_axialDistanceScrew);
            clone.m_turn = (double)Utils.Clone(this.m_turn);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_PoseDataType m_startPosition;
        private CRCL_PointDataType m_axisPoint;
        private double m_axialDistanceFree;
        private double m_axialDistanceScrew;
        private double m_turn;
        #endregion
    }

    #region MoveScrewDataTypeCollection Class
    /// <summary>
    /// A collection of MoveScrewDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMoveScrewDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "MoveScrewDataType")]
    #if !NET_STANDARD
    public partial class MoveScrewDataTypeCollection : List<MoveScrewDataType>, ICloneable
    #else
    public partial class MoveScrewDataTypeCollection : List<MoveScrewDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MoveScrewDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MoveScrewDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MoveScrewDataTypeCollection(IEnumerable<MoveScrewDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MoveScrewDataTypeCollection(MoveScrewDataType[] values)
        {
            if (values != null)
            {
                return new MoveScrewDataTypeCollection(values);
            }

            return new MoveScrewDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MoveScrewDataType[](MoveScrewDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MoveScrewDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveScrewDataTypeCollection clone = new MoveScrewDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MoveScrewDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MoveThroughToDataType Class
    #if (!OPCUA_EXCLUDE_MoveThroughToDataType)
    /// <summary>
    /// CRCL MoveThroughTo
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class MoveThroughToDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MoveThroughToDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_moveStraight = true;
            m_waypoint = new CRCL_PoseDataTypeCollection();
            m_numPositions = (uint)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "MoveStraight", IsRequired = false, Order = 1)]
        public bool MoveStraight
        {
            get { return m_moveStraight;  }
            set { m_moveStraight = value; }
        }

        /// <summary>
        /// Waypoint of MoveThroughTo
        /// </summary>
        [DataMember(Name = "Waypoint", IsRequired = false, Order = 2)]
        public CRCL_PoseDataTypeCollection Waypoint
        {
            get
            {
                return m_waypoint;
            }

            set
            {
                m_waypoint = value;

                if (value == null)
                {
                    m_waypoint = new CRCL_PoseDataTypeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "NumPositions", IsRequired = false, Order = 3)]
        public uint NumPositions
        {
            get { return m_numPositions;  }
            set { m_numPositions = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MoveThroughToDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MoveThroughToDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MoveThroughToDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("MoveStraight", MoveStraight);
            encoder.WriteEncodeableArray("Waypoint", Waypoint.ToArray(), typeof(CRCL_PoseDataType));
            encoder.WriteUInt32("NumPositions", NumPositions);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            MoveStraight = decoder.ReadBoolean("MoveStraight");
            Waypoint = (CRCL_PoseDataTypeCollection)decoder.ReadEncodeableArray("Waypoint", typeof(CRCL_PoseDataType));
            NumPositions = decoder.ReadUInt32("NumPositions");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MoveThroughToDataType value = encodeable as MoveThroughToDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_moveStraight, value.m_moveStraight)) return false;
            if (!Utils.IsEqual(m_waypoint, value.m_waypoint)) return false;
            if (!Utils.IsEqual(m_numPositions, value.m_numPositions)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (MoveThroughToDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveThroughToDataType clone = (MoveThroughToDataType)base.MemberwiseClone();

            clone.m_moveStraight = (bool)Utils.Clone(this.m_moveStraight);
            clone.m_waypoint = (CRCL_PoseDataTypeCollection)Utils.Clone(this.m_waypoint);
            clone.m_numPositions = (uint)Utils.Clone(this.m_numPositions);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_moveStraight;
        private CRCL_PoseDataTypeCollection m_waypoint;
        private uint m_numPositions;
        #endregion
    }

    #region MoveThroughToDataTypeCollection Class
    /// <summary>
    /// A collection of MoveThroughToDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMoveThroughToDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "MoveThroughToDataType")]
    #if !NET_STANDARD
    public partial class MoveThroughToDataTypeCollection : List<MoveThroughToDataType>, ICloneable
    #else
    public partial class MoveThroughToDataTypeCollection : List<MoveThroughToDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MoveThroughToDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MoveThroughToDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MoveThroughToDataTypeCollection(IEnumerable<MoveThroughToDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MoveThroughToDataTypeCollection(MoveThroughToDataType[] values)
        {
            if (values != null)
            {
                return new MoveThroughToDataTypeCollection(values);
            }

            return new MoveThroughToDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MoveThroughToDataType[](MoveThroughToDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MoveThroughToDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MoveThroughToDataTypeCollection clone = new MoveThroughToDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MoveThroughToDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OpenToolChangerDataType Class
    #if (!OPCUA_EXCLUDE_OpenToolChangerDataType)
    /// <summary>
    /// CRCL OpenToolChanger
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class OpenToolChangerDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OpenToolChangerDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OpenToolChangerDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OpenToolChangerDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OpenToolChangerDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OpenToolChangerDataType value = encodeable as OpenToolChangerDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OpenToolChangerDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpenToolChangerDataType clone = (OpenToolChangerDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region OpenToolChangerDataTypeCollection Class
    /// <summary>
    /// A collection of OpenToolChangerDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOpenToolChangerDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "OpenToolChangerDataType")]
    #if !NET_STANDARD
    public partial class OpenToolChangerDataTypeCollection : List<OpenToolChangerDataType>, ICloneable
    #else
    public partial class OpenToolChangerDataTypeCollection : List<OpenToolChangerDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OpenToolChangerDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OpenToolChangerDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OpenToolChangerDataTypeCollection(IEnumerable<OpenToolChangerDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OpenToolChangerDataTypeCollection(OpenToolChangerDataType[] values)
        {
            if (values != null)
            {
                return new OpenToolChangerDataTypeCollection(values);
            }

            return new OpenToolChangerDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OpenToolChangerDataType[](OpenToolChangerDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (OpenToolChangerDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OpenToolChangerDataTypeCollection clone = new OpenToolChangerDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OpenToolChangerDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RunProgramDataType Class
    #if (!OPCUA_EXCLUDE_RunProgramDataType)
    /// <summary>
    /// CRCL RunProgram
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class RunProgramDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public RunProgramDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_programText = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ProgramText", IsRequired = false, Order = 1)]
        public string ProgramText
        {
            get { return m_programText;  }
            set { m_programText = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RunProgramDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RunProgramDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RunProgramDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("ProgramText", ProgramText);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            ProgramText = decoder.ReadString("ProgramText");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RunProgramDataType value = encodeable as RunProgramDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_programText, value.m_programText)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (RunProgramDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RunProgramDataType clone = (RunProgramDataType)base.MemberwiseClone();

            clone.m_programText = (string)Utils.Clone(this.m_programText);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_programText;
        #endregion
    }

    #region RunProgramDataTypeCollection Class
    /// <summary>
    /// A collection of RunProgramDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRunProgramDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "RunProgramDataType")]
    #if !NET_STANDARD
    public partial class RunProgramDataTypeCollection : List<RunProgramDataType>, ICloneable
    #else
    public partial class RunProgramDataTypeCollection : List<RunProgramDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RunProgramDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RunProgramDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RunProgramDataTypeCollection(IEnumerable<RunProgramDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RunProgramDataTypeCollection(RunProgramDataType[] values)
        {
            if (values != null)
            {
                return new RunProgramDataTypeCollection(values);
            }

            return new RunProgramDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RunProgramDataType[](RunProgramDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (RunProgramDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RunProgramDataTypeCollection clone = new RunProgramDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RunProgramDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetAngleUnitsDataType Class
    #if (!OPCUA_EXCLUDE_SetAngleUnitsDataType)
    /// <summary>
    /// CRCL SetAngleUnits
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetAngleUnitsDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetAngleUnitsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_unitName = CRCL_AngleUnitEnumDataType.DEGREE;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "UnitName", IsRequired = false, Order = 1)]
        public CRCL_AngleUnitEnumDataType UnitName
        {
            get { return m_unitName;  }
            set { m_unitName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetAngleUnitsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetAngleUnitsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetAngleUnitsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("UnitName", UnitName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            UnitName = (CRCL_AngleUnitEnumDataType)decoder.ReadEnumerated("UnitName", typeof(CRCL_AngleUnitEnumDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetAngleUnitsDataType value = encodeable as SetAngleUnitsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_unitName, value.m_unitName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetAngleUnitsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetAngleUnitsDataType clone = (SetAngleUnitsDataType)base.MemberwiseClone();

            clone.m_unitName = (CRCL_AngleUnitEnumDataType)Utils.Clone(this.m_unitName);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_AngleUnitEnumDataType m_unitName;
        #endregion
    }

    #region SetAngleUnitsDataTypeCollection Class
    /// <summary>
    /// A collection of SetAngleUnitsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetAngleUnitsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetAngleUnitsDataType")]
    #if !NET_STANDARD
    public partial class SetAngleUnitsDataTypeCollection : List<SetAngleUnitsDataType>, ICloneable
    #else
    public partial class SetAngleUnitsDataTypeCollection : List<SetAngleUnitsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetAngleUnitsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetAngleUnitsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetAngleUnitsDataTypeCollection(IEnumerable<SetAngleUnitsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetAngleUnitsDataTypeCollection(SetAngleUnitsDataType[] values)
        {
            if (values != null)
            {
                return new SetAngleUnitsDataTypeCollection(values);
            }

            return new SetAngleUnitsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetAngleUnitsDataType[](SetAngleUnitsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetAngleUnitsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetAngleUnitsDataTypeCollection clone = new SetAngleUnitsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetAngleUnitsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetEndEffectorParametersDataType Class
    #if (!OPCUA_EXCLUDE_SetEndEffectorParametersDataType)
    /// <summary>
    /// CRCL SetEndEffectorParameters
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetEndEffectorParametersDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetEndEffectorParametersDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_parameterSetting = new CRCL_ParameterSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// ParameterSetting of SetEndEffectorParameters
        /// </summary>
        [DataMember(Name = "ParameterSetting", IsRequired = false, Order = 1)]
        public CRCL_ParameterSettingDataTypeCollection ParameterSetting
        {
            get
            {
                return m_parameterSetting;
            }

            set
            {
                m_parameterSetting = value;

                if (value == null)
                {
                    m_parameterSetting = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetEndEffectorParametersDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetEndEffectorParametersDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetEndEffectorParametersDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("ParameterSetting", ParameterSetting.ToArray(), typeof(CRCL_ParameterSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            ParameterSetting = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("ParameterSetting", typeof(CRCL_ParameterSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetEndEffectorParametersDataType value = encodeable as SetEndEffectorParametersDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_parameterSetting, value.m_parameterSetting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetEndEffectorParametersDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndEffectorParametersDataType clone = (SetEndEffectorParametersDataType)base.MemberwiseClone();

            clone.m_parameterSetting = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_parameterSetting);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_ParameterSettingDataTypeCollection m_parameterSetting;
        #endregion
    }

    #region SetEndEffectorParametersDataTypeCollection Class
    /// <summary>
    /// A collection of SetEndEffectorParametersDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetEndEffectorParametersDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetEndEffectorParametersDataType")]
    #if !NET_STANDARD
    public partial class SetEndEffectorParametersDataTypeCollection : List<SetEndEffectorParametersDataType>, ICloneable
    #else
    public partial class SetEndEffectorParametersDataTypeCollection : List<SetEndEffectorParametersDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetEndEffectorParametersDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetEndEffectorParametersDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetEndEffectorParametersDataTypeCollection(IEnumerable<SetEndEffectorParametersDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetEndEffectorParametersDataTypeCollection(SetEndEffectorParametersDataType[] values)
        {
            if (values != null)
            {
                return new SetEndEffectorParametersDataTypeCollection(values);
            }

            return new SetEndEffectorParametersDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetEndEffectorParametersDataType[](SetEndEffectorParametersDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetEndEffectorParametersDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndEffectorParametersDataTypeCollection clone = new SetEndEffectorParametersDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetEndEffectorParametersDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetEndEffectorDataType Class
    #if (!OPCUA_EXCLUDE_SetEndEffectorDataType)
    /// <summary>
    /// CRCL SetEndEffector
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetEndEffectorDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetEndEffectorDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_setting = new CRCL_FractionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Setting of SetEndEffector
        /// </summary>
        [DataMember(Name = "Setting", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType Setting
        {
            get
            {
                return m_setting;
            }

            set
            {
                m_setting = value;

                if (value == null)
                {
                    m_setting = new CRCL_FractionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetEndEffectorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetEndEffectorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetEndEffectorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("Setting", Setting, typeof(CRCL_FractionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Setting = (CRCL_FractionDataType)decoder.ReadEncodeable("Setting", typeof(CRCL_FractionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetEndEffectorDataType value = encodeable as SetEndEffectorDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_setting, value.m_setting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetEndEffectorDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndEffectorDataType clone = (SetEndEffectorDataType)base.MemberwiseClone();

            clone.m_setting = (CRCL_FractionDataType)Utils.Clone(this.m_setting);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_setting;
        #endregion
    }

    #region SetEndEffectorDataTypeCollection Class
    /// <summary>
    /// A collection of SetEndEffectorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetEndEffectorDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetEndEffectorDataType")]
    #if !NET_STANDARD
    public partial class SetEndEffectorDataTypeCollection : List<SetEndEffectorDataType>, ICloneable
    #else
    public partial class SetEndEffectorDataTypeCollection : List<SetEndEffectorDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetEndEffectorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetEndEffectorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetEndEffectorDataTypeCollection(IEnumerable<SetEndEffectorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetEndEffectorDataTypeCollection(SetEndEffectorDataType[] values)
        {
            if (values != null)
            {
                return new SetEndEffectorDataTypeCollection(values);
            }

            return new SetEndEffectorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetEndEffectorDataType[](SetEndEffectorDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetEndEffectorDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndEffectorDataTypeCollection clone = new SetEndEffectorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetEndEffectorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetEndPoseToleranceDataType Class
    #if (!OPCUA_EXCLUDE_SetEndPoseToleranceDataType)
    /// <summary>
    /// CRCL SetEndPoseTolerance
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetEndPoseToleranceDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetEndPoseToleranceDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_tolerance = new CRCL_PoseToleranceDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Tolerance of SetEndPoseTolerance
        /// </summary>
        [DataMember(Name = "Tolerance", IsRequired = false, Order = 1)]
        public CRCL_PoseToleranceDataType Tolerance
        {
            get
            {
                return m_tolerance;
            }

            set
            {
                m_tolerance = value;

                if (value == null)
                {
                    m_tolerance = new CRCL_PoseToleranceDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetEndPoseToleranceDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetEndPoseToleranceDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetEndPoseToleranceDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("Tolerance", Tolerance, typeof(CRCL_PoseToleranceDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Tolerance = (CRCL_PoseToleranceDataType)decoder.ReadEncodeable("Tolerance", typeof(CRCL_PoseToleranceDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetEndPoseToleranceDataType value = encodeable as SetEndPoseToleranceDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_tolerance, value.m_tolerance)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetEndPoseToleranceDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndPoseToleranceDataType clone = (SetEndPoseToleranceDataType)base.MemberwiseClone();

            clone.m_tolerance = (CRCL_PoseToleranceDataType)Utils.Clone(this.m_tolerance);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_PoseToleranceDataType m_tolerance;
        #endregion
    }

    #region SetEndPoseToleranceDataTypeCollection Class
    /// <summary>
    /// A collection of SetEndPoseToleranceDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetEndPoseToleranceDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetEndPoseToleranceDataType")]
    #if !NET_STANDARD
    public partial class SetEndPoseToleranceDataTypeCollection : List<SetEndPoseToleranceDataType>, ICloneable
    #else
    public partial class SetEndPoseToleranceDataTypeCollection : List<SetEndPoseToleranceDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetEndPoseToleranceDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetEndPoseToleranceDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetEndPoseToleranceDataTypeCollection(IEnumerable<SetEndPoseToleranceDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetEndPoseToleranceDataTypeCollection(SetEndPoseToleranceDataType[] values)
        {
            if (values != null)
            {
                return new SetEndPoseToleranceDataTypeCollection(values);
            }

            return new SetEndPoseToleranceDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetEndPoseToleranceDataType[](SetEndPoseToleranceDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetEndPoseToleranceDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetEndPoseToleranceDataTypeCollection clone = new SetEndPoseToleranceDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetEndPoseToleranceDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetForceUnitsDataType Class
    #if (!OPCUA_EXCLUDE_SetForceUnitsDataType)
    /// <summary>
    /// CRCL SetForceUnits
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetForceUnitsDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetForceUnitsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_unitName = CRCL_ForceUnitEnumDataType.NEWTON;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "UnitName", IsRequired = false, Order = 1)]
        public CRCL_ForceUnitEnumDataType UnitName
        {
            get { return m_unitName;  }
            set { m_unitName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetForceUnitsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetForceUnitsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetForceUnitsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("UnitName", UnitName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            UnitName = (CRCL_ForceUnitEnumDataType)decoder.ReadEnumerated("UnitName", typeof(CRCL_ForceUnitEnumDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetForceUnitsDataType value = encodeable as SetForceUnitsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_unitName, value.m_unitName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetForceUnitsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetForceUnitsDataType clone = (SetForceUnitsDataType)base.MemberwiseClone();

            clone.m_unitName = (CRCL_ForceUnitEnumDataType)Utils.Clone(this.m_unitName);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_ForceUnitEnumDataType m_unitName;
        #endregion
    }

    #region SetForceUnitsDataTypeCollection Class
    /// <summary>
    /// A collection of SetForceUnitsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetForceUnitsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetForceUnitsDataType")]
    #if !NET_STANDARD
    public partial class SetForceUnitsDataTypeCollection : List<SetForceUnitsDataType>, ICloneable
    #else
    public partial class SetForceUnitsDataTypeCollection : List<SetForceUnitsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetForceUnitsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetForceUnitsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetForceUnitsDataTypeCollection(IEnumerable<SetForceUnitsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetForceUnitsDataTypeCollection(SetForceUnitsDataType[] values)
        {
            if (values != null)
            {
                return new SetForceUnitsDataTypeCollection(values);
            }

            return new SetForceUnitsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetForceUnitsDataType[](SetForceUnitsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetForceUnitsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetForceUnitsDataTypeCollection clone = new SetForceUnitsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetForceUnitsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetIntermediatePoseToleranceDataType Class
    #if (!OPCUA_EXCLUDE_SetIntermediatePoseToleranceDataType)
    /// <summary>
    /// CRCL SetIntermediatePoseTolerance
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetIntermediatePoseToleranceDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetIntermediatePoseToleranceDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_tolerance = new CRCL_PoseToleranceDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Tolerance of SetIntermediatePoseTolerance
        /// </summary>
        [DataMember(Name = "Tolerance", IsRequired = false, Order = 1)]
        public CRCL_PoseToleranceDataType Tolerance
        {
            get
            {
                return m_tolerance;
            }

            set
            {
                m_tolerance = value;

                if (value == null)
                {
                    m_tolerance = new CRCL_PoseToleranceDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetIntermediatePoseToleranceDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetIntermediatePoseToleranceDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetIntermediatePoseToleranceDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("Tolerance", Tolerance, typeof(CRCL_PoseToleranceDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Tolerance = (CRCL_PoseToleranceDataType)decoder.ReadEncodeable("Tolerance", typeof(CRCL_PoseToleranceDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetIntermediatePoseToleranceDataType value = encodeable as SetIntermediatePoseToleranceDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_tolerance, value.m_tolerance)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetIntermediatePoseToleranceDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetIntermediatePoseToleranceDataType clone = (SetIntermediatePoseToleranceDataType)base.MemberwiseClone();

            clone.m_tolerance = (CRCL_PoseToleranceDataType)Utils.Clone(this.m_tolerance);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_PoseToleranceDataType m_tolerance;
        #endregion
    }

    #region SetIntermediatePoseToleranceDataTypeCollection Class
    /// <summary>
    /// A collection of SetIntermediatePoseToleranceDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetIntermediatePoseToleranceDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetIntermediatePoseToleranceDataType")]
    #if !NET_STANDARD
    public partial class SetIntermediatePoseToleranceDataTypeCollection : List<SetIntermediatePoseToleranceDataType>, ICloneable
    #else
    public partial class SetIntermediatePoseToleranceDataTypeCollection : List<SetIntermediatePoseToleranceDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetIntermediatePoseToleranceDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetIntermediatePoseToleranceDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetIntermediatePoseToleranceDataTypeCollection(IEnumerable<SetIntermediatePoseToleranceDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetIntermediatePoseToleranceDataTypeCollection(SetIntermediatePoseToleranceDataType[] values)
        {
            if (values != null)
            {
                return new SetIntermediatePoseToleranceDataTypeCollection(values);
            }

            return new SetIntermediatePoseToleranceDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetIntermediatePoseToleranceDataType[](SetIntermediatePoseToleranceDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetIntermediatePoseToleranceDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetIntermediatePoseToleranceDataTypeCollection clone = new SetIntermediatePoseToleranceDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetIntermediatePoseToleranceDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetLengthUnitsDataType Class
    #if (!OPCUA_EXCLUDE_SetLengthUnitsDataType)
    /// <summary>
    /// CRCL SetLengthUnits
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetLengthUnitsDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetLengthUnitsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_unitName = CRCL_LengthUnitEnumDataType.METER;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "UnitName", IsRequired = false, Order = 1)]
        public CRCL_LengthUnitEnumDataType UnitName
        {
            get { return m_unitName;  }
            set { m_unitName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetLengthUnitsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetLengthUnitsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetLengthUnitsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("UnitName", UnitName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            UnitName = (CRCL_LengthUnitEnumDataType)decoder.ReadEnumerated("UnitName", typeof(CRCL_LengthUnitEnumDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetLengthUnitsDataType value = encodeable as SetLengthUnitsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_unitName, value.m_unitName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetLengthUnitsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetLengthUnitsDataType clone = (SetLengthUnitsDataType)base.MemberwiseClone();

            clone.m_unitName = (CRCL_LengthUnitEnumDataType)Utils.Clone(this.m_unitName);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_LengthUnitEnumDataType m_unitName;
        #endregion
    }

    #region SetLengthUnitsDataTypeCollection Class
    /// <summary>
    /// A collection of SetLengthUnitsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetLengthUnitsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetLengthUnitsDataType")]
    #if !NET_STANDARD
    public partial class SetLengthUnitsDataTypeCollection : List<SetLengthUnitsDataType>, ICloneable
    #else
    public partial class SetLengthUnitsDataTypeCollection : List<SetLengthUnitsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetLengthUnitsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetLengthUnitsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetLengthUnitsDataTypeCollection(IEnumerable<SetLengthUnitsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetLengthUnitsDataTypeCollection(SetLengthUnitsDataType[] values)
        {
            if (values != null)
            {
                return new SetLengthUnitsDataTypeCollection(values);
            }

            return new SetLengthUnitsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetLengthUnitsDataType[](SetLengthUnitsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetLengthUnitsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetLengthUnitsDataTypeCollection clone = new SetLengthUnitsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetLengthUnitsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetMotionCoordinationDataType Class
    #if (!OPCUA_EXCLUDE_SetMotionCoordinationDataType)
    /// <summary>
    /// CRCL SetMotionCoordination
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetMotionCoordinationDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetMotionCoordinationDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_coordinated = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Coordinated", IsRequired = false, Order = 1)]
        public bool Coordinated
        {
            get { return m_coordinated;  }
            set { m_coordinated = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetMotionCoordinationDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetMotionCoordinationDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetMotionCoordinationDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("Coordinated", Coordinated);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            Coordinated = decoder.ReadBoolean("Coordinated");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetMotionCoordinationDataType value = encodeable as SetMotionCoordinationDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_coordinated, value.m_coordinated)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetMotionCoordinationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetMotionCoordinationDataType clone = (SetMotionCoordinationDataType)base.MemberwiseClone();

            clone.m_coordinated = (bool)Utils.Clone(this.m_coordinated);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_coordinated;
        #endregion
    }

    #region SetMotionCoordinationDataTypeCollection Class
    /// <summary>
    /// A collection of SetMotionCoordinationDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetMotionCoordinationDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetMotionCoordinationDataType")]
    #if !NET_STANDARD
    public partial class SetMotionCoordinationDataTypeCollection : List<SetMotionCoordinationDataType>, ICloneable
    #else
    public partial class SetMotionCoordinationDataTypeCollection : List<SetMotionCoordinationDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetMotionCoordinationDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetMotionCoordinationDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetMotionCoordinationDataTypeCollection(IEnumerable<SetMotionCoordinationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetMotionCoordinationDataTypeCollection(SetMotionCoordinationDataType[] values)
        {
            if (values != null)
            {
                return new SetMotionCoordinationDataTypeCollection(values);
            }

            return new SetMotionCoordinationDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetMotionCoordinationDataType[](SetMotionCoordinationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetMotionCoordinationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetMotionCoordinationDataTypeCollection clone = new SetMotionCoordinationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetMotionCoordinationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetRobotParametersDataType Class
    #if (!OPCUA_EXCLUDE_SetRobotParametersDataType)
    /// <summary>
    /// CRCL SetRobotParameters
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetRobotParametersDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetRobotParametersDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_parameterSetting = new CRCL_ParameterSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// ParameterSetting of SetRobotParameters
        /// </summary>
        [DataMember(Name = "ParameterSetting", IsRequired = false, Order = 1)]
        public CRCL_ParameterSettingDataTypeCollection ParameterSetting
        {
            get
            {
                return m_parameterSetting;
            }

            set
            {
                m_parameterSetting = value;

                if (value == null)
                {
                    m_parameterSetting = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetRobotParametersDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetRobotParametersDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetRobotParametersDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("ParameterSetting", ParameterSetting.ToArray(), typeof(CRCL_ParameterSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            ParameterSetting = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("ParameterSetting", typeof(CRCL_ParameterSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetRobotParametersDataType value = encodeable as SetRobotParametersDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_parameterSetting, value.m_parameterSetting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetRobotParametersDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRobotParametersDataType clone = (SetRobotParametersDataType)base.MemberwiseClone();

            clone.m_parameterSetting = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_parameterSetting);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_ParameterSettingDataTypeCollection m_parameterSetting;
        #endregion
    }

    #region SetRobotParametersDataTypeCollection Class
    /// <summary>
    /// A collection of SetRobotParametersDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetRobotParametersDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetRobotParametersDataType")]
    #if !NET_STANDARD
    public partial class SetRobotParametersDataTypeCollection : List<SetRobotParametersDataType>, ICloneable
    #else
    public partial class SetRobotParametersDataTypeCollection : List<SetRobotParametersDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetRobotParametersDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetRobotParametersDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetRobotParametersDataTypeCollection(IEnumerable<SetRobotParametersDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetRobotParametersDataTypeCollection(SetRobotParametersDataType[] values)
        {
            if (values != null)
            {
                return new SetRobotParametersDataTypeCollection(values);
            }

            return new SetRobotParametersDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetRobotParametersDataType[](SetRobotParametersDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetRobotParametersDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRobotParametersDataTypeCollection clone = new SetRobotParametersDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetRobotParametersDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetTorqueUnitsDataType Class
    #if (!OPCUA_EXCLUDE_SetTorqueUnitsDataType)
    /// <summary>
    /// CRCL SetLengthUnits
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetTorqueUnitsDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetTorqueUnitsDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_unitName = CRCL_TorqueUnitEnumDataType.NEWTONMETER;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "UnitName", IsRequired = false, Order = 1)]
        public CRCL_TorqueUnitEnumDataType UnitName
        {
            get { return m_unitName;  }
            set { m_unitName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetTorqueUnitsDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetTorqueUnitsDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetTorqueUnitsDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("UnitName", UnitName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            UnitName = (CRCL_TorqueUnitEnumDataType)decoder.ReadEnumerated("UnitName", typeof(CRCL_TorqueUnitEnumDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetTorqueUnitsDataType value = encodeable as SetTorqueUnitsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_unitName, value.m_unitName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetTorqueUnitsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTorqueUnitsDataType clone = (SetTorqueUnitsDataType)base.MemberwiseClone();

            clone.m_unitName = (CRCL_TorqueUnitEnumDataType)Utils.Clone(this.m_unitName);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_TorqueUnitEnumDataType m_unitName;
        #endregion
    }

    #region SetTorqueUnitsDataTypeCollection Class
    /// <summary>
    /// A collection of SetTorqueUnitsDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetTorqueUnitsDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetTorqueUnitsDataType")]
    #if !NET_STANDARD
    public partial class SetTorqueUnitsDataTypeCollection : List<SetTorqueUnitsDataType>, ICloneable
    #else
    public partial class SetTorqueUnitsDataTypeCollection : List<SetTorqueUnitsDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetTorqueUnitsDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetTorqueUnitsDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetTorqueUnitsDataTypeCollection(IEnumerable<SetTorqueUnitsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetTorqueUnitsDataTypeCollection(SetTorqueUnitsDataType[] values)
        {
            if (values != null)
            {
                return new SetTorqueUnitsDataTypeCollection(values);
            }

            return new SetTorqueUnitsDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetTorqueUnitsDataType[](SetTorqueUnitsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetTorqueUnitsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTorqueUnitsDataTypeCollection clone = new SetTorqueUnitsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetTorqueUnitsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region StopMotionDataType Class
    #if (!OPCUA_EXCLUDE_StopMotionDataType)
    /// <summary>
    /// CRCL StopMotion
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class StopMotionDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public StopMotionDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_stopCondition = CRCL_StopConditionEnumDataType.IMMEDIATE;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "StopCondition", IsRequired = false, Order = 1)]
        public CRCL_StopConditionEnumDataType StopCondition
        {
            get { return m_stopCondition;  }
            set { m_stopCondition = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.StopMotionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.StopMotionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.StopMotionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("StopCondition", StopCondition);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            StopCondition = (CRCL_StopConditionEnumDataType)decoder.ReadEnumerated("StopCondition", typeof(CRCL_StopConditionEnumDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            StopMotionDataType value = encodeable as StopMotionDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_stopCondition, value.m_stopCondition)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (StopMotionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StopMotionDataType clone = (StopMotionDataType)base.MemberwiseClone();

            clone.m_stopCondition = (CRCL_StopConditionEnumDataType)Utils.Clone(this.m_stopCondition);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_StopConditionEnumDataType m_stopCondition;
        #endregion
    }

    #region StopMotionDataTypeCollection Class
    /// <summary>
    /// A collection of StopMotionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfStopMotionDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "StopMotionDataType")]
    #if !NET_STANDARD
    public partial class StopMotionDataTypeCollection : List<StopMotionDataType>, ICloneable
    #else
    public partial class StopMotionDataTypeCollection : List<StopMotionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public StopMotionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public StopMotionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public StopMotionDataTypeCollection(IEnumerable<StopMotionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator StopMotionDataTypeCollection(StopMotionDataType[] values)
        {
            if (values != null)
            {
                return new StopMotionDataTypeCollection(values);
            }

            return new StopMotionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator StopMotionDataType[](StopMotionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (StopMotionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StopMotionDataTypeCollection clone = new StopMotionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((StopMotionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConfigureStatusReportDataType Class
    #if (!OPCUA_EXCLUDE_ConfigureStatusReportDataType)
    /// <summary>
    /// CRCL ConfigureStatusReport
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class ConfigureStatusReportDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ConfigureStatusReportDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_reportJointStatuses = true;
            m_reportPoseStatus = true;
            m_reportGripperStatus = true;
            m_reportSettingsStatus = true;
            m_reportSensorsStatus = true;
            m_reportGuardsStatus = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ReportJointStatuses", IsRequired = false, Order = 1)]
        public bool ReportJointStatuses
        {
            get { return m_reportJointStatuses;  }
            set { m_reportJointStatuses = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportPoseStatus", IsRequired = false, Order = 2)]
        public bool ReportPoseStatus
        {
            get { return m_reportPoseStatus;  }
            set { m_reportPoseStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportGripperStatus", IsRequired = false, Order = 3)]
        public bool ReportGripperStatus
        {
            get { return m_reportGripperStatus;  }
            set { m_reportGripperStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportSettingsStatus", IsRequired = false, Order = 4)]
        public bool ReportSettingsStatus
        {
            get { return m_reportSettingsStatus;  }
            set { m_reportSettingsStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportSensorsStatus", IsRequired = false, Order = 5)]
        public bool ReportSensorsStatus
        {
            get { return m_reportSensorsStatus;  }
            set { m_reportSensorsStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportGuardsStatus", IsRequired = false, Order = 6)]
        public bool ReportGuardsStatus
        {
            get { return m_reportGuardsStatus;  }
            set { m_reportGuardsStatus = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ConfigureStatusReportDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ConfigureStatusReportDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ConfigureStatusReportDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("ReportJointStatuses", ReportJointStatuses);
            encoder.WriteBoolean("ReportPoseStatus", ReportPoseStatus);
            encoder.WriteBoolean("ReportGripperStatus", ReportGripperStatus);
            encoder.WriteBoolean("ReportSettingsStatus", ReportSettingsStatus);
            encoder.WriteBoolean("ReportSensorsStatus", ReportSensorsStatus);
            encoder.WriteBoolean("ReportGuardsStatus", ReportGuardsStatus);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            ReportJointStatuses = decoder.ReadBoolean("ReportJointStatuses");
            ReportPoseStatus = decoder.ReadBoolean("ReportPoseStatus");
            ReportGripperStatus = decoder.ReadBoolean("ReportGripperStatus");
            ReportSettingsStatus = decoder.ReadBoolean("ReportSettingsStatus");
            ReportSensorsStatus = decoder.ReadBoolean("ReportSensorsStatus");
            ReportGuardsStatus = decoder.ReadBoolean("ReportGuardsStatus");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ConfigureStatusReportDataType value = encodeable as ConfigureStatusReportDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_reportJointStatuses, value.m_reportJointStatuses)) return false;
            if (!Utils.IsEqual(m_reportPoseStatus, value.m_reportPoseStatus)) return false;
            if (!Utils.IsEqual(m_reportGripperStatus, value.m_reportGripperStatus)) return false;
            if (!Utils.IsEqual(m_reportSettingsStatus, value.m_reportSettingsStatus)) return false;
            if (!Utils.IsEqual(m_reportSensorsStatus, value.m_reportSensorsStatus)) return false;
            if (!Utils.IsEqual(m_reportGuardsStatus, value.m_reportGuardsStatus)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (ConfigureStatusReportDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConfigureStatusReportDataType clone = (ConfigureStatusReportDataType)base.MemberwiseClone();

            clone.m_reportJointStatuses = (bool)Utils.Clone(this.m_reportJointStatuses);
            clone.m_reportPoseStatus = (bool)Utils.Clone(this.m_reportPoseStatus);
            clone.m_reportGripperStatus = (bool)Utils.Clone(this.m_reportGripperStatus);
            clone.m_reportSettingsStatus = (bool)Utils.Clone(this.m_reportSettingsStatus);
            clone.m_reportSensorsStatus = (bool)Utils.Clone(this.m_reportSensorsStatus);
            clone.m_reportGuardsStatus = (bool)Utils.Clone(this.m_reportGuardsStatus);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_reportJointStatuses;
        private bool m_reportPoseStatus;
        private bool m_reportGripperStatus;
        private bool m_reportSettingsStatus;
        private bool m_reportSensorsStatus;
        private bool m_reportGuardsStatus;
        #endregion
    }

    #region ConfigureStatusReportDataTypeCollection Class
    /// <summary>
    /// A collection of ConfigureStatusReportDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConfigureStatusReportDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "ConfigureStatusReportDataType")]
    #if !NET_STANDARD
    public partial class ConfigureStatusReportDataTypeCollection : List<ConfigureStatusReportDataType>, ICloneable
    #else
    public partial class ConfigureStatusReportDataTypeCollection : List<ConfigureStatusReportDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ConfigureStatusReportDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ConfigureStatusReportDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ConfigureStatusReportDataTypeCollection(IEnumerable<ConfigureStatusReportDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ConfigureStatusReportDataTypeCollection(ConfigureStatusReportDataType[] values)
        {
            if (values != null)
            {
                return new ConfigureStatusReportDataTypeCollection(values);
            }

            return new ConfigureStatusReportDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ConfigureStatusReportDataType[](ConfigureStatusReportDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ConfigureStatusReportDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConfigureStatusReportDataTypeCollection clone = new ConfigureStatusReportDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConfigureStatusReportDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EnableSensorDataType Class
    #if (!OPCUA_EXCLUDE_EnableSensorDataType)
    /// <summary>
    /// CRCL EnableSensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class EnableSensorDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public EnableSensorDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_sensorID = null;
            m_sensorOption = new CRCL_ParameterSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "SensorID", IsRequired = false, Order = 1)]
        public string SensorID
        {
            get { return m_sensorID;  }
            set { m_sensorID = value; }
        }

        /// <summary>
        /// SensorOption of EnableSensor
        /// </summary>
        [DataMember(Name = "SensorOption", IsRequired = false, Order = 2)]
        public CRCL_ParameterSettingDataTypeCollection SensorOption
        {
            get
            {
                return m_sensorOption;
            }

            set
            {
                m_sensorOption = value;

                if (value == null)
                {
                    m_sensorOption = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.EnableSensorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.EnableSensorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.EnableSensorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("SensorID", SensorID);
            encoder.WriteEncodeableArray("SensorOption", SensorOption.ToArray(), typeof(CRCL_ParameterSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            SensorID = decoder.ReadString("SensorID");
            SensorOption = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("SensorOption", typeof(CRCL_ParameterSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            EnableSensorDataType value = encodeable as EnableSensorDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sensorID, value.m_sensorID)) return false;
            if (!Utils.IsEqual(m_sensorOption, value.m_sensorOption)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (EnableSensorDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableSensorDataType clone = (EnableSensorDataType)base.MemberwiseClone();

            clone.m_sensorID = (string)Utils.Clone(this.m_sensorID);
            clone.m_sensorOption = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_sensorOption);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_sensorID;
        private CRCL_ParameterSettingDataTypeCollection m_sensorOption;
        #endregion
    }

    #region EnableSensorDataTypeCollection Class
    /// <summary>
    /// A collection of EnableSensorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEnableSensorDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "EnableSensorDataType")]
    #if !NET_STANDARD
    public partial class EnableSensorDataTypeCollection : List<EnableSensorDataType>, ICloneable
    #else
    public partial class EnableSensorDataTypeCollection : List<EnableSensorDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public EnableSensorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public EnableSensorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public EnableSensorDataTypeCollection(IEnumerable<EnableSensorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator EnableSensorDataTypeCollection(EnableSensorDataType[] values)
        {
            if (values != null)
            {
                return new EnableSensorDataTypeCollection(values);
            }

            return new EnableSensorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator EnableSensorDataType[](EnableSensorDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (EnableSensorDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableSensorDataTypeCollection clone = new EnableSensorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EnableSensorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DisableSensorDataType Class
    #if (!OPCUA_EXCLUDE_DisableSensorDataType)
    /// <summary>
    /// CRCL DisableSensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class DisableSensorDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DisableSensorDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_sensorID = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "SensorID", IsRequired = false, Order = 1)]
        public string SensorID
        {
            get { return m_sensorID;  }
            set { m_sensorID = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DisableSensorDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DisableSensorDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DisableSensorDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("SensorID", SensorID);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            SensorID = decoder.ReadString("SensorID");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DisableSensorDataType value = encodeable as DisableSensorDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sensorID, value.m_sensorID)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (DisableSensorDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableSensorDataType clone = (DisableSensorDataType)base.MemberwiseClone();

            clone.m_sensorID = (string)Utils.Clone(this.m_sensorID);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_sensorID;
        #endregion
    }

    #region DisableSensorDataTypeCollection Class
    /// <summary>
    /// A collection of DisableSensorDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDisableSensorDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "DisableSensorDataType")]
    #if !NET_STANDARD
    public partial class DisableSensorDataTypeCollection : List<DisableSensorDataType>, ICloneable
    #else
    public partial class DisableSensorDataTypeCollection : List<DisableSensorDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DisableSensorDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DisableSensorDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DisableSensorDataTypeCollection(IEnumerable<DisableSensorDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DisableSensorDataTypeCollection(DisableSensorDataType[] values)
        {
            if (values != null)
            {
                return new DisableSensorDataTypeCollection(values);
            }

            return new DisableSensorDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DisableSensorDataType[](DisableSensorDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DisableSensorDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableSensorDataTypeCollection clone = new DisableSensorDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DisableSensorDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EnableGripperDataType Class
    #if (!OPCUA_EXCLUDE_EnableGripperDataType)
    /// <summary>
    /// CRCL EnableGripper
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class EnableGripperDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public EnableGripperDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_gripperName = null;
            m_gripperOption = new CRCL_ParameterSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "GripperName", IsRequired = false, Order = 1)]
        public string GripperName
        {
            get { return m_gripperName;  }
            set { m_gripperName = value; }
        }

        /// <summary>
        /// GripperOption of EnableGripper
        /// </summary>
        [DataMember(Name = "GripperOption", IsRequired = false, Order = 2)]
        public CRCL_ParameterSettingDataTypeCollection GripperOption
        {
            get
            {
                return m_gripperOption;
            }

            set
            {
                m_gripperOption = value;

                if (value == null)
                {
                    m_gripperOption = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.EnableGripperDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.EnableGripperDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.EnableGripperDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("GripperName", GripperName);
            encoder.WriteEncodeableArray("GripperOption", GripperOption.ToArray(), typeof(CRCL_ParameterSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            GripperName = decoder.ReadString("GripperName");
            GripperOption = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("GripperOption", typeof(CRCL_ParameterSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            EnableGripperDataType value = encodeable as EnableGripperDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_gripperName, value.m_gripperName)) return false;
            if (!Utils.IsEqual(m_gripperOption, value.m_gripperOption)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (EnableGripperDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableGripperDataType clone = (EnableGripperDataType)base.MemberwiseClone();

            clone.m_gripperName = (string)Utils.Clone(this.m_gripperName);
            clone.m_gripperOption = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_gripperOption);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_gripperName;
        private CRCL_ParameterSettingDataTypeCollection m_gripperOption;
        #endregion
    }

    #region EnableGripperDataTypeCollection Class
    /// <summary>
    /// A collection of EnableGripperDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEnableGripperDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "EnableGripperDataType")]
    #if !NET_STANDARD
    public partial class EnableGripperDataTypeCollection : List<EnableGripperDataType>, ICloneable
    #else
    public partial class EnableGripperDataTypeCollection : List<EnableGripperDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public EnableGripperDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public EnableGripperDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public EnableGripperDataTypeCollection(IEnumerable<EnableGripperDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator EnableGripperDataTypeCollection(EnableGripperDataType[] values)
        {
            if (values != null)
            {
                return new EnableGripperDataTypeCollection(values);
            }

            return new EnableGripperDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator EnableGripperDataType[](EnableGripperDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (EnableGripperDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableGripperDataTypeCollection clone = new EnableGripperDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EnableGripperDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DisableGripperDataType Class
    #if (!OPCUA_EXCLUDE_DisableGripperDataType)
    /// <summary>
    /// CRCL DisableGripper
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class DisableGripperDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DisableGripperDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_gripperName = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "GripperName", IsRequired = false, Order = 1)]
        public string GripperName
        {
            get { return m_gripperName;  }
            set { m_gripperName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DisableGripperDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DisableGripperDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DisableGripperDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("GripperName", GripperName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            GripperName = decoder.ReadString("GripperName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DisableGripperDataType value = encodeable as DisableGripperDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_gripperName, value.m_gripperName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (DisableGripperDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableGripperDataType clone = (DisableGripperDataType)base.MemberwiseClone();

            clone.m_gripperName = (string)Utils.Clone(this.m_gripperName);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_gripperName;
        #endregion
    }

    #region DisableGripperDataTypeCollection Class
    /// <summary>
    /// A collection of DisableGripperDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDisableGripperDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "DisableGripperDataType")]
    #if !NET_STANDARD
    public partial class DisableGripperDataTypeCollection : List<DisableGripperDataType>, ICloneable
    #else
    public partial class DisableGripperDataTypeCollection : List<DisableGripperDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DisableGripperDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DisableGripperDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DisableGripperDataTypeCollection(IEnumerable<DisableGripperDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DisableGripperDataTypeCollection(DisableGripperDataType[] values)
        {
            if (values != null)
            {
                return new DisableGripperDataTypeCollection(values);
            }

            return new DisableGripperDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DisableGripperDataType[](DisableGripperDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DisableGripperDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableGripperDataTypeCollection clone = new DisableGripperDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DisableGripperDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCLSkillDataType Class
    #if (!OPCUA_EXCLUDE_CRCLSkillDataType)
    /// <summary>
    /// CRCLProgramm
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCLSkillDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCLSkillDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_cRCLCommands = new CRCLCommandsUnionDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// CRCLCommands of the CRCLProgramm
        /// </summary>
        [DataMember(Name = "CRCLCommands", IsRequired = false, Order = 1)]
        public CRCLCommandsUnionDataTypeCollection CRCLCommands
        {
            get
            {
                return m_cRCLCommands;
            }

            set
            {
                m_cRCLCommands = value;

                if (value == null)
                {
                    m_cRCLCommands = new CRCLCommandsUnionDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCLSkillDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCLSkillDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCLSkillDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("CRCLCommands", CRCLCommands.ToArray(), typeof(CRCLCommandsUnionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            CRCLCommands = (CRCLCommandsUnionDataTypeCollection)decoder.ReadEncodeableArray("CRCLCommands", typeof(CRCLCommandsUnionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCLSkillDataType value = encodeable as CRCLSkillDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_cRCLCommands, value.m_cRCLCommands)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCLSkillDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLSkillDataType clone = (CRCLSkillDataType)base.MemberwiseClone();

            clone.m_cRCLCommands = (CRCLCommandsUnionDataTypeCollection)Utils.Clone(this.m_cRCLCommands);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCLCommandsUnionDataTypeCollection m_cRCLCommands;
        #endregion
    }

    #region CRCLSkillDataTypeCollection Class
    /// <summary>
    /// A collection of CRCLSkillDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCLSkillDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCLSkillDataType")]
    #if !NET_STANDARD
    public partial class CRCLSkillDataTypeCollection : List<CRCLSkillDataType>, ICloneable
    #else
    public partial class CRCLSkillDataTypeCollection : List<CRCLSkillDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCLSkillDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCLSkillDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCLSkillDataTypeCollection(IEnumerable<CRCLSkillDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCLSkillDataTypeCollection(CRCLSkillDataType[] values)
        {
            if (values != null)
            {
                return new CRCLSkillDataTypeCollection(values);
            }

            return new CRCLSkillDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCLSkillDataType[](CRCLSkillDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCLSkillDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLSkillDataTypeCollection clone = new CRCLSkillDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCLSkillDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region EnableRobotParameterStatusDataType Class
    #if (!OPCUA_EXCLUDE_EnableRobotParameterStatusDataType)
    /// <summary>
    /// CRCL EnableRobotParameterStatus
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class EnableRobotParameterStatusDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public EnableRobotParameterStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_robotParameterName = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "RobotParameterName", IsRequired = false, Order = 1)]
        public string RobotParameterName
        {
            get { return m_robotParameterName;  }
            set { m_robotParameterName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.EnableRobotParameterStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.EnableRobotParameterStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.EnableRobotParameterStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("RobotParameterName", RobotParameterName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            RobotParameterName = decoder.ReadString("RobotParameterName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            EnableRobotParameterStatusDataType value = encodeable as EnableRobotParameterStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_robotParameterName, value.m_robotParameterName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (EnableRobotParameterStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableRobotParameterStatusDataType clone = (EnableRobotParameterStatusDataType)base.MemberwiseClone();

            clone.m_robotParameterName = (string)Utils.Clone(this.m_robotParameterName);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_robotParameterName;
        #endregion
    }

    #region EnableRobotParameterStatusDataTypeCollection Class
    /// <summary>
    /// A collection of EnableRobotParameterStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfEnableRobotParameterStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "EnableRobotParameterStatusDataType")]
    #if !NET_STANDARD
    public partial class EnableRobotParameterStatusDataTypeCollection : List<EnableRobotParameterStatusDataType>, ICloneable
    #else
    public partial class EnableRobotParameterStatusDataTypeCollection : List<EnableRobotParameterStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public EnableRobotParameterStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public EnableRobotParameterStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public EnableRobotParameterStatusDataTypeCollection(IEnumerable<EnableRobotParameterStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator EnableRobotParameterStatusDataTypeCollection(EnableRobotParameterStatusDataType[] values)
        {
            if (values != null)
            {
                return new EnableRobotParameterStatusDataTypeCollection(values);
            }

            return new EnableRobotParameterStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator EnableRobotParameterStatusDataType[](EnableRobotParameterStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (EnableRobotParameterStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            EnableRobotParameterStatusDataTypeCollection clone = new EnableRobotParameterStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((EnableRobotParameterStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DisableRobotParameterStatusDataType Class
    #if (!OPCUA_EXCLUDE_DisableRobotParameterStatusDataType)
    /// <summary>
    /// CRCL DisableRobotParameterStatus
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class DisableRobotParameterStatusDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public DisableRobotParameterStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_robotParameterName = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "RobotParameterName", IsRequired = false, Order = 1)]
        public string RobotParameterName
        {
            get { return m_robotParameterName;  }
            set { m_robotParameterName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DisableRobotParameterStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DisableRobotParameterStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DisableRobotParameterStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("RobotParameterName", RobotParameterName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            RobotParameterName = decoder.ReadString("RobotParameterName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DisableRobotParameterStatusDataType value = encodeable as DisableRobotParameterStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_robotParameterName, value.m_robotParameterName)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (DisableRobotParameterStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableRobotParameterStatusDataType clone = (DisableRobotParameterStatusDataType)base.MemberwiseClone();

            clone.m_robotParameterName = (string)Utils.Clone(this.m_robotParameterName);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_robotParameterName;
        #endregion
    }

    #region DisableRobotParameterStatusDataTypeCollection Class
    /// <summary>
    /// A collection of DisableRobotParameterStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDisableRobotParameterStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "DisableRobotParameterStatusDataType")]
    #if !NET_STANDARD
    public partial class DisableRobotParameterStatusDataTypeCollection : List<DisableRobotParameterStatusDataType>, ICloneable
    #else
    public partial class DisableRobotParameterStatusDataTypeCollection : List<DisableRobotParameterStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DisableRobotParameterStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DisableRobotParameterStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DisableRobotParameterStatusDataTypeCollection(IEnumerable<DisableRobotParameterStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DisableRobotParameterStatusDataTypeCollection(DisableRobotParameterStatusDataType[] values)
        {
            if (values != null)
            {
                return new DisableRobotParameterStatusDataTypeCollection(values);
            }

            return new DisableRobotParameterStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DisableRobotParameterStatusDataType[](DisableRobotParameterStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (DisableRobotParameterStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DisableRobotParameterStatusDataTypeCollection clone = new DisableRobotParameterStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DisableRobotParameterStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetDefaultJointPositonsTolerancesDataType Class
    #if (!OPCUA_EXCLUDE_SetDefaultJointPositonsTolerancesDataType)
    /// <summary>
    /// CRCL SetEndPoseTolerance
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetDefaultJointPositonsTolerancesDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetDefaultJointPositonsTolerancesDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointTolerances = new CRCL_JointPositionsTolerancesDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// JointTolerances of SetDefaultJointPositonsTolerances
        /// </summary>
        [DataMember(Name = "JointTolerances", IsRequired = false, Order = 1)]
        public CRCL_JointPositionsTolerancesDataType JointTolerances
        {
            get
            {
                return m_jointTolerances;
            }

            set
            {
                m_jointTolerances = value;

                if (value == null)
                {
                    m_jointTolerances = new CRCL_JointPositionsTolerancesDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetDefaultJointPositonsTolerancesDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetDefaultJointPositonsTolerancesDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetDefaultJointPositonsTolerancesDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("JointTolerances", JointTolerances, typeof(CRCL_JointPositionsTolerancesDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            JointTolerances = (CRCL_JointPositionsTolerancesDataType)decoder.ReadEncodeable("JointTolerances", typeof(CRCL_JointPositionsTolerancesDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetDefaultJointPositonsTolerancesDataType value = encodeable as SetDefaultJointPositonsTolerancesDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointTolerances, value.m_jointTolerances)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetDefaultJointPositonsTolerancesDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetDefaultJointPositonsTolerancesDataType clone = (SetDefaultJointPositonsTolerancesDataType)base.MemberwiseClone();

            clone.m_jointTolerances = (CRCL_JointPositionsTolerancesDataType)Utils.Clone(this.m_jointTolerances);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_JointPositionsTolerancesDataType m_jointTolerances;
        #endregion
    }

    #region SetDefaultJointPositonsTolerancesDataTypeCollection Class
    /// <summary>
    /// A collection of SetDefaultJointPositonsTolerancesDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetDefaultJointPositonsTolerancesDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetDefaultJointPositonsTolerancesDataType")]
    #if !NET_STANDARD
    public partial class SetDefaultJointPositonsTolerancesDataTypeCollection : List<SetDefaultJointPositonsTolerancesDataType>, ICloneable
    #else
    public partial class SetDefaultJointPositonsTolerancesDataTypeCollection : List<SetDefaultJointPositonsTolerancesDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetDefaultJointPositonsTolerancesDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetDefaultJointPositonsTolerancesDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetDefaultJointPositonsTolerancesDataTypeCollection(IEnumerable<SetDefaultJointPositonsTolerancesDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetDefaultJointPositonsTolerancesDataTypeCollection(SetDefaultJointPositonsTolerancesDataType[] values)
        {
            if (values != null)
            {
                return new SetDefaultJointPositonsTolerancesDataTypeCollection(values);
            }

            return new SetDefaultJointPositonsTolerancesDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetDefaultJointPositonsTolerancesDataType[](SetDefaultJointPositonsTolerancesDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetDefaultJointPositonsTolerancesDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetDefaultJointPositonsTolerancesDataTypeCollection clone = new SetDefaultJointPositonsTolerancesDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetDefaultJointPositonsTolerancesDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetRotAccelDataType Class
    #if (!OPCUA_EXCLUDE_SetRotAccelDataType)
    /// <summary>
    /// CRCL SetRotAccel
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetRotAccelDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetRotAccelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_rotAccel = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "RotAccel", IsRequired = false, Order = 1)]
        public ExtensionObject RotAccel
        {
            get { return m_rotAccel;  }
            set { m_rotAccel = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetRotAccelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetRotAccelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetRotAccelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteExtensionObject("RotAccel", RotAccel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            RotAccel = decoder.ReadExtensionObject("RotAccel");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetRotAccelDataType value = encodeable as SetRotAccelDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_rotAccel, value.m_rotAccel)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetRotAccelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRotAccelDataType clone = (SetRotAccelDataType)base.MemberwiseClone();

            clone.m_rotAccel = (ExtensionObject)Utils.Clone(this.m_rotAccel);

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_rotAccel;
        #endregion
    }

    #region SetRotAccelDataTypeCollection Class
    /// <summary>
    /// A collection of SetRotAccelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetRotAccelDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetRotAccelDataType")]
    #if !NET_STANDARD
    public partial class SetRotAccelDataTypeCollection : List<SetRotAccelDataType>, ICloneable
    #else
    public partial class SetRotAccelDataTypeCollection : List<SetRotAccelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetRotAccelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetRotAccelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetRotAccelDataTypeCollection(IEnumerable<SetRotAccelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetRotAccelDataTypeCollection(SetRotAccelDataType[] values)
        {
            if (values != null)
            {
                return new SetRotAccelDataTypeCollection(values);
            }

            return new SetRotAccelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetRotAccelDataType[](SetRotAccelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetRotAccelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRotAccelDataTypeCollection clone = new SetRotAccelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetRotAccelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetTransAccelDataType Class
    #if (!OPCUA_EXCLUDE_SetTransAccelDataType)
    /// <summary>
    /// CRCL SetTransAccel
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetTransAccelDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetTransAccelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_transAccel = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "TransAccel", IsRequired = false, Order = 1)]
        public ExtensionObject TransAccel
        {
            get { return m_transAccel;  }
            set { m_transAccel = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetTransAccelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetTransAccelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetTransAccelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteExtensionObject("TransAccel", TransAccel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            TransAccel = decoder.ReadExtensionObject("TransAccel");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetTransAccelDataType value = encodeable as SetTransAccelDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_transAccel, value.m_transAccel)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetTransAccelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTransAccelDataType clone = (SetTransAccelDataType)base.MemberwiseClone();

            clone.m_transAccel = (ExtensionObject)Utils.Clone(this.m_transAccel);

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_transAccel;
        #endregion
    }

    #region SetTransAccelDataTypeCollection Class
    /// <summary>
    /// A collection of SetTransAccelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetTransAccelDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetTransAccelDataType")]
    #if !NET_STANDARD
    public partial class SetTransAccelDataTypeCollection : List<SetTransAccelDataType>, ICloneable
    #else
    public partial class SetTransAccelDataTypeCollection : List<SetTransAccelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetTransAccelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetTransAccelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetTransAccelDataTypeCollection(IEnumerable<SetTransAccelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetTransAccelDataTypeCollection(SetTransAccelDataType[] values)
        {
            if (values != null)
            {
                return new SetTransAccelDataTypeCollection(values);
            }

            return new SetTransAccelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetTransAccelDataType[](SetTransAccelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetTransAccelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTransAccelDataTypeCollection clone = new SetTransAccelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetTransAccelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetRotSpeedDataType Class
    #if (!OPCUA_EXCLUDE_SetRotSpeedDataType)
    /// <summary>
    /// CRCL SetRotSpeed
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetRotSpeedDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetRotSpeedDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_rotSpeed = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "RotSpeed", IsRequired = false, Order = 1)]
        public ExtensionObject RotSpeed
        {
            get { return m_rotSpeed;  }
            set { m_rotSpeed = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetRotSpeedDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetRotSpeedDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetRotSpeedDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteExtensionObject("RotSpeed", RotSpeed);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            RotSpeed = decoder.ReadExtensionObject("RotSpeed");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetRotSpeedDataType value = encodeable as SetRotSpeedDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_rotSpeed, value.m_rotSpeed)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetRotSpeedDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRotSpeedDataType clone = (SetRotSpeedDataType)base.MemberwiseClone();

            clone.m_rotSpeed = (ExtensionObject)Utils.Clone(this.m_rotSpeed);

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_rotSpeed;
        #endregion
    }

    #region SetRotSpeedDataTypeCollection Class
    /// <summary>
    /// A collection of SetRotSpeedDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetRotSpeedDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetRotSpeedDataType")]
    #if !NET_STANDARD
    public partial class SetRotSpeedDataTypeCollection : List<SetRotSpeedDataType>, ICloneable
    #else
    public partial class SetRotSpeedDataTypeCollection : List<SetRotSpeedDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetRotSpeedDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetRotSpeedDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetRotSpeedDataTypeCollection(IEnumerable<SetRotSpeedDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetRotSpeedDataTypeCollection(SetRotSpeedDataType[] values)
        {
            if (values != null)
            {
                return new SetRotSpeedDataTypeCollection(values);
            }

            return new SetRotSpeedDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetRotSpeedDataType[](SetRotSpeedDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetRotSpeedDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetRotSpeedDataTypeCollection clone = new SetRotSpeedDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetRotSpeedDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SetTransSpeedDataType Class
    #if (!OPCUA_EXCLUDE_SetTransSpeedDataType)
    /// <summary>
    /// CRCL SetTransSpeed
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class SetTransSpeedDataType : MiddleCommandDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public SetTransSpeedDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_transSpeed = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "TransSpeed", IsRequired = false, Order = 1)]
        public ExtensionObject TransSpeed
        {
            get { return m_transSpeed;  }
            set { m_transSpeed = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.SetTransSpeedDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.SetTransSpeedDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.SetTransSpeedDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteExtensionObject("TransSpeed", TransSpeed);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            TransSpeed = decoder.ReadExtensionObject("TransSpeed");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SetTransSpeedDataType value = encodeable as SetTransSpeedDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_transSpeed, value.m_transSpeed)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (SetTransSpeedDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTransSpeedDataType clone = (SetTransSpeedDataType)base.MemberwiseClone();

            clone.m_transSpeed = (ExtensionObject)Utils.Clone(this.m_transSpeed);

            return clone;
        }
        #endregion

        #region Private Fields
        private ExtensionObject m_transSpeed;
        #endregion
    }

    #region SetTransSpeedDataTypeCollection Class
    /// <summary>
    /// A collection of SetTransSpeedDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSetTransSpeedDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "SetTransSpeedDataType")]
    #if !NET_STANDARD
    public partial class SetTransSpeedDataTypeCollection : List<SetTransSpeedDataType>, ICloneable
    #else
    public partial class SetTransSpeedDataTypeCollection : List<SetTransSpeedDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public SetTransSpeedDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public SetTransSpeedDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public SetTransSpeedDataTypeCollection(IEnumerable<SetTransSpeedDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator SetTransSpeedDataTypeCollection(SetTransSpeedDataType[] values)
        {
            if (values != null)
            {
                return new SetTransSpeedDataTypeCollection(values);
            }

            return new SetTransSpeedDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator SetTransSpeedDataType[](SetTransSpeedDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (SetTransSpeedDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SetTransSpeedDataTypeCollection clone = new SetTransSpeedDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SetTransSpeedDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region UnionTestDataType Class
    #if (!OPCUA_EXCLUDE_UnionTestDataType)
    /// <summary>
    /// CRCL SetTransSpeed
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class UnionTestDataType : Union
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public UnionTestDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_switchField = (uint)0;
            m_stringValue = null;
            m_booleanValue = true;
            m_uint32Value = (uint)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "switchField", IsRequired = false, Order = 1)]
        public uint switchField
        {
            get { return m_switchField;  }
            set { m_switchField = value; }
        }

        /// <remarks />
        [DataMember(Name = "stringValue", IsRequired = false, Order = 2)]
        public string stringValue
        {
            get { return m_stringValue;  }
            set { m_stringValue = value; }
        }

        /// <remarks />
        [DataMember(Name = "booleanValue", IsRequired = false, Order = 3)]
        public bool booleanValue
        {
            get { return m_booleanValue;  }
            set { m_booleanValue = value; }
        }

        /// <remarks />
        [DataMember(Name = "uint32Value", IsRequired = false, Order = 4)]
        public uint uint32Value
        {
            get { return m_uint32Value;  }
            set { m_uint32Value = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.UnionTestDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.UnionTestDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.UnionTestDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("switchField", switchField);
            encoder.WriteString("stringValue", stringValue);
            encoder.WriteBoolean("booleanValue", booleanValue);
            encoder.WriteUInt32("uint32Value", uint32Value);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            switchField = decoder.ReadUInt32("switchField");
            stringValue = decoder.ReadString("stringValue");
            booleanValue = decoder.ReadBoolean("booleanValue");
            uint32Value = decoder.ReadUInt32("uint32Value");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            UnionTestDataType value = encodeable as UnionTestDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_switchField, value.m_switchField)) return false;
            if (!Utils.IsEqual(m_stringValue, value.m_stringValue)) return false;
            if (!Utils.IsEqual(m_booleanValue, value.m_booleanValue)) return false;
            if (!Utils.IsEqual(m_uint32Value, value.m_uint32Value)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (UnionTestDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            UnionTestDataType clone = (UnionTestDataType)base.MemberwiseClone();

            clone.m_switchField = (uint)Utils.Clone(this.m_switchField);
            clone.m_stringValue = (string)Utils.Clone(this.m_stringValue);
            clone.m_booleanValue = (bool)Utils.Clone(this.m_booleanValue);
            clone.m_uint32Value = (uint)Utils.Clone(this.m_uint32Value);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_switchField;
        private string m_stringValue;
        private bool m_booleanValue;
        private uint m_uint32Value;
        #endregion
    }

    #region UnionTestDataTypeCollection Class
    /// <summary>
    /// A collection of UnionTestDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfUnionTestDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "UnionTestDataType")]
    #if !NET_STANDARD
    public partial class UnionTestDataTypeCollection : List<UnionTestDataType>, ICloneable
    #else
    public partial class UnionTestDataTypeCollection : List<UnionTestDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public UnionTestDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public UnionTestDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public UnionTestDataTypeCollection(IEnumerable<UnionTestDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator UnionTestDataTypeCollection(UnionTestDataType[] values)
        {
            if (values != null)
            {
                return new UnionTestDataTypeCollection(values);
            }

            return new UnionTestDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator UnionTestDataType[](UnionTestDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (UnionTestDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            UnionTestDataTypeCollection clone = new UnionTestDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((UnionTestDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_CommandStateEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_CommandStateEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_CommandStateEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "CRCL_DONE_0")]
        CRCL_DONE = 0,

        /// <remarks />
        [EnumMember(Value = "CRCL_ERROR_1")]
        CRCL_ERROR = 1,

        /// <remarks />
        [EnumMember(Value = "CRCL_WORKING_2")]
        CRCL_WORKING = 2,

        /// <remarks />
        [EnumMember(Value = "CRCL_READY_3")]
        CRCL_READY = 3,
    }

    #region CRCL_CommandStateEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_CommandStateEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_CommandStateEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_CommandStateEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_CommandStateEnumDataTypeCollection : List<CRCL_CommandStateEnumDataType>, ICloneable
    #else
    public partial class CRCL_CommandStateEnumDataTypeCollection : List<CRCL_CommandStateEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_CommandStateEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_CommandStateEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_CommandStateEnumDataTypeCollection(IEnumerable<CRCL_CommandStateEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_CommandStateEnumDataTypeCollection(CRCL_CommandStateEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_CommandStateEnumDataTypeCollection(values);
            }

            return new CRCL_CommandStateEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_CommandStateEnumDataType[](CRCL_CommandStateEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_CommandStateEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_CommandStateEnumDataTypeCollection clone = new CRCL_CommandStateEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_CommandStateEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_CommandStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_CommandStatusDataType)
    /// <summary>
    /// CRCL Status of a CRCL command
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_CommandStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_CommandStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_commandID = (uint)0;
            m_statusID = (uint)0;
            m_commandState = CRCL_CommandStateEnumDataType.CRCL_DONE;
            m_stateDescription = null;
            m_programmFile = null;
            m_programmIndex = (uint)0;
            m_programmLength = (uint)0;
            m_overridePercent = (uint)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "commandID", IsRequired = false, Order = 1)]
        public uint commandID
        {
            get { return m_commandID;  }
            set { m_commandID = value; }
        }

        /// <remarks />
        [DataMember(Name = "statusID", IsRequired = false, Order = 2)]
        public uint statusID
        {
            get { return m_statusID;  }
            set { m_statusID = value; }
        }

        /// <remarks />
        [DataMember(Name = "commandState", IsRequired = false, Order = 3)]
        public CRCL_CommandStateEnumDataType commandState
        {
            get { return m_commandState;  }
            set { m_commandState = value; }
        }

        /// <remarks />
        [DataMember(Name = "stateDescription", IsRequired = false, Order = 4)]
        public string stateDescription
        {
            get { return m_stateDescription;  }
            set { m_stateDescription = value; }
        }

        /// <remarks />
        [DataMember(Name = "programmFile", IsRequired = false, Order = 5)]
        public string programmFile
        {
            get { return m_programmFile;  }
            set { m_programmFile = value; }
        }

        /// <remarks />
        [DataMember(Name = "programmIndex", IsRequired = false, Order = 6)]
        public uint programmIndex
        {
            get { return m_programmIndex;  }
            set { m_programmIndex = value; }
        }

        /// <remarks />
        [DataMember(Name = "programmLength", IsRequired = false, Order = 7)]
        public uint programmLength
        {
            get { return m_programmLength;  }
            set { m_programmLength = value; }
        }

        /// <remarks />
        [DataMember(Name = "overridePercent", IsRequired = false, Order = 8)]
        public uint overridePercent
        {
            get { return m_overridePercent;  }
            set { m_overridePercent = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_CommandStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_CommandStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_CommandStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("commandID", commandID);
            encoder.WriteUInt32("statusID", statusID);
            encoder.WriteEnumerated("commandState", commandState);
            encoder.WriteString("stateDescription", stateDescription);
            encoder.WriteString("programmFile", programmFile);
            encoder.WriteUInt32("programmIndex", programmIndex);
            encoder.WriteUInt32("programmLength", programmLength);
            encoder.WriteUInt32("overridePercent", overridePercent);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            commandID = decoder.ReadUInt32("commandID");
            statusID = decoder.ReadUInt32("statusID");
            commandState = (CRCL_CommandStateEnumDataType)decoder.ReadEnumerated("commandState", typeof(CRCL_CommandStateEnumDataType));
            stateDescription = decoder.ReadString("stateDescription");
            programmFile = decoder.ReadString("programmFile");
            programmIndex = decoder.ReadUInt32("programmIndex");
            programmLength = decoder.ReadUInt32("programmLength");
            overridePercent = decoder.ReadUInt32("overridePercent");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_CommandStatusDataType value = encodeable as CRCL_CommandStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_commandID, value.m_commandID)) return false;
            if (!Utils.IsEqual(m_statusID, value.m_statusID)) return false;
            if (!Utils.IsEqual(m_commandState, value.m_commandState)) return false;
            if (!Utils.IsEqual(m_stateDescription, value.m_stateDescription)) return false;
            if (!Utils.IsEqual(m_programmFile, value.m_programmFile)) return false;
            if (!Utils.IsEqual(m_programmIndex, value.m_programmIndex)) return false;
            if (!Utils.IsEqual(m_programmLength, value.m_programmLength)) return false;
            if (!Utils.IsEqual(m_overridePercent, value.m_overridePercent)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_CommandStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_CommandStatusDataType clone = (CRCL_CommandStatusDataType)base.MemberwiseClone();

            clone.m_commandID = (uint)Utils.Clone(this.m_commandID);
            clone.m_statusID = (uint)Utils.Clone(this.m_statusID);
            clone.m_commandState = (CRCL_CommandStateEnumDataType)Utils.Clone(this.m_commandState);
            clone.m_stateDescription = (string)Utils.Clone(this.m_stateDescription);
            clone.m_programmFile = (string)Utils.Clone(this.m_programmFile);
            clone.m_programmIndex = (uint)Utils.Clone(this.m_programmIndex);
            clone.m_programmLength = (uint)Utils.Clone(this.m_programmLength);
            clone.m_overridePercent = (uint)Utils.Clone(this.m_overridePercent);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_commandID;
        private uint m_statusID;
        private CRCL_CommandStateEnumDataType m_commandState;
        private string m_stateDescription;
        private string m_programmFile;
        private uint m_programmIndex;
        private uint m_programmLength;
        private uint m_overridePercent;
        #endregion
    }

    #region CRCL_CommandStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_CommandStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_CommandStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_CommandStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_CommandStatusDataTypeCollection : List<CRCL_CommandStatusDataType>, ICloneable
    #else
    public partial class CRCL_CommandStatusDataTypeCollection : List<CRCL_CommandStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_CommandStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_CommandStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_CommandStatusDataTypeCollection(IEnumerable<CRCL_CommandStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_CommandStatusDataTypeCollection(CRCL_CommandStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_CommandStatusDataTypeCollection(values);
            }

            return new CRCL_CommandStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_CommandStatusDataType[](CRCL_CommandStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_CommandStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_CommandStatusDataTypeCollection clone = new CRCL_CommandStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_CommandStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_SensorStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_SensorStatusDataType)
    /// <summary>
    /// CRCL State of a sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_SensorStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_SensorStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_sensorID = null;
            m_readCount = (uint)0;
            m_lastReadTime = (uint)0;
            m_sensorParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "sensorID", IsRequired = false, Order = 1)]
        public string sensorID
        {
            get { return m_sensorID;  }
            set { m_sensorID = value; }
        }

        /// <remarks />
        [DataMember(Name = "readCount", IsRequired = false, Order = 2)]
        public uint readCount
        {
            get { return m_readCount;  }
            set { m_readCount = value; }
        }

        /// <remarks />
        [DataMember(Name = "lastReadTime", IsRequired = false, Order = 3)]
        public uint lastReadTime
        {
            get { return m_lastReadTime;  }
            set { m_lastReadTime = value; }
        }

        /// <summary>
        /// ParameterSetting of of sensor status
        /// </summary>
        [DataMember(Name = "sensorParameterSetting", IsRequired = false, Order = 4)]
        public CRCL_ParameterSettingDataTypeCollection sensorParameterSetting
        {
            get
            {
                return m_sensorParameterSetting;
            }

            set
            {
                m_sensorParameterSetting = value;

                if (value == null)
                {
                    m_sensorParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_SensorStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_SensorStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_SensorStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("sensorID", sensorID);
            encoder.WriteUInt32("readCount", readCount);
            encoder.WriteUInt32("lastReadTime", lastReadTime);
            encoder.WriteEncodeableArray("sensorParameterSetting", sensorParameterSetting.ToArray(), typeof(CRCL_ParameterSettingDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            sensorID = decoder.ReadString("sensorID");
            readCount = decoder.ReadUInt32("readCount");
            lastReadTime = decoder.ReadUInt32("lastReadTime");
            sensorParameterSetting = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("sensorParameterSetting", typeof(CRCL_ParameterSettingDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_SensorStatusDataType value = encodeable as CRCL_SensorStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_sensorID, value.m_sensorID)) return false;
            if (!Utils.IsEqual(m_readCount, value.m_readCount)) return false;
            if (!Utils.IsEqual(m_lastReadTime, value.m_lastReadTime)) return false;
            if (!Utils.IsEqual(m_sensorParameterSetting, value.m_sensorParameterSetting)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_SensorStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SensorStatusDataType clone = (CRCL_SensorStatusDataType)base.MemberwiseClone();

            clone.m_sensorID = (string)Utils.Clone(this.m_sensorID);
            clone.m_readCount = (uint)Utils.Clone(this.m_readCount);
            clone.m_lastReadTime = (uint)Utils.Clone(this.m_lastReadTime);
            clone.m_sensorParameterSetting = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_sensorParameterSetting);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_sensorID;
        private uint m_readCount;
        private uint m_lastReadTime;
        private CRCL_ParameterSettingDataTypeCollection m_sensorParameterSetting;
        #endregion
    }

    #region CRCL_SensorStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_SensorStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_SensorStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_SensorStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_SensorStatusDataTypeCollection : List<CRCL_SensorStatusDataType>, ICloneable
    #else
    public partial class CRCL_SensorStatusDataTypeCollection : List<CRCL_SensorStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_SensorStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_SensorStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_SensorStatusDataTypeCollection(IEnumerable<CRCL_SensorStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_SensorStatusDataTypeCollection(CRCL_SensorStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_SensorStatusDataTypeCollection(values);
            }

            return new CRCL_SensorStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_SensorStatusDataType[](CRCL_SensorStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_SensorStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SensorStatusDataTypeCollection clone = new CRCL_SensorStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_SensorStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_CountSensorStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_CountSensorStatusDataType)
    /// <summary>
    /// CRCL State of a count sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_CountSensorStatusDataType : CRCL_SensorStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_CountSensorStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_countValue = (uint)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "countValue", IsRequired = false, Order = 1)]
        public uint countValue
        {
            get { return m_countValue;  }
            set { m_countValue = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_CountSensorStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_CountSensorStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_CountSensorStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("countValue", countValue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            countValue = decoder.ReadUInt32("countValue");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_CountSensorStatusDataType value = encodeable as CRCL_CountSensorStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_countValue, value.m_countValue)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_CountSensorStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_CountSensorStatusDataType clone = (CRCL_CountSensorStatusDataType)base.MemberwiseClone();

            clone.m_countValue = (uint)Utils.Clone(this.m_countValue);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_countValue;
        #endregion
    }

    #region CRCL_CountSensorStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_CountSensorStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_CountSensorStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_CountSensorStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_CountSensorStatusDataTypeCollection : List<CRCL_CountSensorStatusDataType>, ICloneable
    #else
    public partial class CRCL_CountSensorStatusDataTypeCollection : List<CRCL_CountSensorStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_CountSensorStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_CountSensorStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_CountSensorStatusDataTypeCollection(IEnumerable<CRCL_CountSensorStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_CountSensorStatusDataTypeCollection(CRCL_CountSensorStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_CountSensorStatusDataTypeCollection(values);
            }

            return new CRCL_CountSensorStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_CountSensorStatusDataType[](CRCL_CountSensorStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_CountSensorStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_CountSensorStatusDataTypeCollection clone = new CRCL_CountSensorStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_CountSensorStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_OnOffSensorStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_OnOffSensorStatusDataType)
    /// <summary>
    /// CRCL State of a OnOff sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_OnOffSensorStatusDataType : CRCL_SensorStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_OnOffSensorStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_on = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "on", IsRequired = false, Order = 1)]
        public bool on
        {
            get { return m_on;  }
            set { m_on = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_OnOffSensorStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_OnOffSensorStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_OnOffSensorStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("on", on);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            on = decoder.ReadBoolean("on");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_OnOffSensorStatusDataType value = encodeable as CRCL_OnOffSensorStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_on, value.m_on)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_OnOffSensorStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_OnOffSensorStatusDataType clone = (CRCL_OnOffSensorStatusDataType)base.MemberwiseClone();

            clone.m_on = (bool)Utils.Clone(this.m_on);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_on;
        #endregion
    }

    #region CRCL_OnOffSensorStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_OnOffSensorStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_OnOffSensorStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_OnOffSensorStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_OnOffSensorStatusDataTypeCollection : List<CRCL_OnOffSensorStatusDataType>, ICloneable
    #else
    public partial class CRCL_OnOffSensorStatusDataTypeCollection : List<CRCL_OnOffSensorStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_OnOffSensorStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_OnOffSensorStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_OnOffSensorStatusDataTypeCollection(IEnumerable<CRCL_OnOffSensorStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_OnOffSensorStatusDataTypeCollection(CRCL_OnOffSensorStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_OnOffSensorStatusDataTypeCollection(values);
            }

            return new CRCL_OnOffSensorStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_OnOffSensorStatusDataType[](CRCL_OnOffSensorStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_OnOffSensorStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_OnOffSensorStatusDataTypeCollection clone = new CRCL_OnOffSensorStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_OnOffSensorStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ScalarSensorStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ScalarSensorStatusDataType)
    /// <summary>
    /// CRCL State of a scalar sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ScalarSensorStatusDataType : CRCL_SensorStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ScalarSensorStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_scalarValue = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "scalarValue", IsRequired = false, Order = 1)]
        public double scalarValue
        {
            get { return m_scalarValue;  }
            set { m_scalarValue = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ScalarSensorStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ScalarSensorStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ScalarSensorStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("scalarValue", scalarValue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            scalarValue = decoder.ReadDouble("scalarValue");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ScalarSensorStatusDataType value = encodeable as CRCL_ScalarSensorStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_scalarValue, value.m_scalarValue)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ScalarSensorStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ScalarSensorStatusDataType clone = (CRCL_ScalarSensorStatusDataType)base.MemberwiseClone();

            clone.m_scalarValue = (double)Utils.Clone(this.m_scalarValue);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_scalarValue;
        #endregion
    }

    #region CRCL_ScalarSensorStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ScalarSensorStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ScalarSensorStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ScalarSensorStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ScalarSensorStatusDataTypeCollection : List<CRCL_ScalarSensorStatusDataType>, ICloneable
    #else
    public partial class CRCL_ScalarSensorStatusDataTypeCollection : List<CRCL_ScalarSensorStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ScalarSensorStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ScalarSensorStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ScalarSensorStatusDataTypeCollection(IEnumerable<CRCL_ScalarSensorStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ScalarSensorStatusDataTypeCollection(CRCL_ScalarSensorStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ScalarSensorStatusDataTypeCollection(values);
            }

            return new CRCL_ScalarSensorStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ScalarSensorStatusDataType[](CRCL_ScalarSensorStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ScalarSensorStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ScalarSensorStatusDataTypeCollection clone = new CRCL_ScalarSensorStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ScalarSensorStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ForceTorqueSensorStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ForceTorqueSensorStatusDataType)
    /// <summary>
    /// CRCL State of a count sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ForceTorqueSensorStatusDataType : CRCL_SensorStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ForceTorqueSensorStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_fx = (double)0;
            m_fy = (double)0;
            m_fz = (double)0;
            m_tx = (double)0;
            m_ty = (double)0;
            m_tz = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "fx", IsRequired = false, Order = 1)]
        public double fx
        {
            get { return m_fx;  }
            set { m_fx = value; }
        }

        /// <remarks />
        [DataMember(Name = "fy", IsRequired = false, Order = 2)]
        public double fy
        {
            get { return m_fy;  }
            set { m_fy = value; }
        }

        /// <remarks />
        [DataMember(Name = "fz", IsRequired = false, Order = 3)]
        public double fz
        {
            get { return m_fz;  }
            set { m_fz = value; }
        }

        /// <remarks />
        [DataMember(Name = "tx", IsRequired = false, Order = 4)]
        public double tx
        {
            get { return m_tx;  }
            set { m_tx = value; }
        }

        /// <remarks />
        [DataMember(Name = "ty", IsRequired = false, Order = 5)]
        public double ty
        {
            get { return m_ty;  }
            set { m_ty = value; }
        }

        /// <remarks />
        [DataMember(Name = "tz", IsRequired = false, Order = 6)]
        public double tz
        {
            get { return m_tz;  }
            set { m_tz = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ForceTorqueSensorStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ForceTorqueSensorStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ForceTorqueSensorStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("fx", fx);
            encoder.WriteDouble("fy", fy);
            encoder.WriteDouble("fz", fz);
            encoder.WriteDouble("tx", tx);
            encoder.WriteDouble("ty", ty);
            encoder.WriteDouble("tz", tz);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            fx = decoder.ReadDouble("fx");
            fy = decoder.ReadDouble("fy");
            fz = decoder.ReadDouble("fz");
            tx = decoder.ReadDouble("tx");
            ty = decoder.ReadDouble("ty");
            tz = decoder.ReadDouble("tz");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ForceTorqueSensorStatusDataType value = encodeable as CRCL_ForceTorqueSensorStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_fx, value.m_fx)) return false;
            if (!Utils.IsEqual(m_fy, value.m_fy)) return false;
            if (!Utils.IsEqual(m_fz, value.m_fz)) return false;
            if (!Utils.IsEqual(m_tx, value.m_tx)) return false;
            if (!Utils.IsEqual(m_ty, value.m_ty)) return false;
            if (!Utils.IsEqual(m_tz, value.m_tz)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ForceTorqueSensorStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ForceTorqueSensorStatusDataType clone = (CRCL_ForceTorqueSensorStatusDataType)base.MemberwiseClone();

            clone.m_fx = (double)Utils.Clone(this.m_fx);
            clone.m_fy = (double)Utils.Clone(this.m_fy);
            clone.m_fz = (double)Utils.Clone(this.m_fz);
            clone.m_tx = (double)Utils.Clone(this.m_tx);
            clone.m_ty = (double)Utils.Clone(this.m_ty);
            clone.m_tz = (double)Utils.Clone(this.m_tz);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_fx;
        private double m_fy;
        private double m_fz;
        private double m_tx;
        private double m_ty;
        private double m_tz;
        #endregion
    }

    #region CRCL_ForceTorqueSensorStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ForceTorqueSensorStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ForceTorqueSensorStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ForceTorqueSensorStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ForceTorqueSensorStatusDataTypeCollection : List<CRCL_ForceTorqueSensorStatusDataType>, ICloneable
    #else
    public partial class CRCL_ForceTorqueSensorStatusDataTypeCollection : List<CRCL_ForceTorqueSensorStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ForceTorqueSensorStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ForceTorqueSensorStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ForceTorqueSensorStatusDataTypeCollection(IEnumerable<CRCL_ForceTorqueSensorStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ForceTorqueSensorStatusDataTypeCollection(CRCL_ForceTorqueSensorStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ForceTorqueSensorStatusDataTypeCollection(values);
            }

            return new CRCL_ForceTorqueSensorStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ForceTorqueSensorStatusDataType[](CRCL_ForceTorqueSensorStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ForceTorqueSensorStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ForceTorqueSensorStatusDataTypeCollection clone = new CRCL_ForceTorqueSensorStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ForceTorqueSensorStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_SensorStatusesDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_SensorStatusesDataType)
    /// <summary>
    /// CRCL State of a sensor
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_SensorStatusesDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_SensorStatusesDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_onOffSensorStatus = new CRCL_OnOffSensorStatusDataTypeCollection();
            m_scalarSensorStatus = new CRCL_ScalarSensorStatusDataTypeCollection();
            m_countSensorStatus = new CRCL_CountSensorStatusDataTypeCollection();
            m_forceTorqueSensorStatus = new CRCL_ForceTorqueSensorStatusDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// OnOff Sensor Status array
        /// </summary>
        [DataMember(Name = "onOffSensorStatus", IsRequired = false, Order = 1)]
        public CRCL_OnOffSensorStatusDataTypeCollection onOffSensorStatus
        {
            get
            {
                return m_onOffSensorStatus;
            }

            set
            {
                m_onOffSensorStatus = value;

                if (value == null)
                {
                    m_onOffSensorStatus = new CRCL_OnOffSensorStatusDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// Scalar Sensor Status array
        /// </summary>
        [DataMember(Name = "scalarSensorStatus", IsRequired = false, Order = 2)]
        public CRCL_ScalarSensorStatusDataTypeCollection scalarSensorStatus
        {
            get
            {
                return m_scalarSensorStatus;
            }

            set
            {
                m_scalarSensorStatus = value;

                if (value == null)
                {
                    m_scalarSensorStatus = new CRCL_ScalarSensorStatusDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// Count Sensor Status array
        /// </summary>
        [DataMember(Name = "countSensorStatus", IsRequired = false, Order = 3)]
        public CRCL_CountSensorStatusDataTypeCollection countSensorStatus
        {
            get
            {
                return m_countSensorStatus;
            }

            set
            {
                m_countSensorStatus = value;

                if (value == null)
                {
                    m_countSensorStatus = new CRCL_CountSensorStatusDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// FroceTorque Sensor Status array
        /// </summary>
        [DataMember(Name = "forceTorqueSensorStatus", IsRequired = false, Order = 4)]
        public CRCL_ForceTorqueSensorStatusDataTypeCollection forceTorqueSensorStatus
        {
            get
            {
                return m_forceTorqueSensorStatus;
            }

            set
            {
                m_forceTorqueSensorStatus = value;

                if (value == null)
                {
                    m_forceTorqueSensorStatus = new CRCL_ForceTorqueSensorStatusDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_SensorStatusesDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_SensorStatusesDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_SensorStatusesDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("onOffSensorStatus", onOffSensorStatus.ToArray(), typeof(CRCL_OnOffSensorStatusDataType));
            encoder.WriteEncodeableArray("scalarSensorStatus", scalarSensorStatus.ToArray(), typeof(CRCL_ScalarSensorStatusDataType));
            encoder.WriteEncodeableArray("countSensorStatus", countSensorStatus.ToArray(), typeof(CRCL_CountSensorStatusDataType));
            encoder.WriteEncodeableArray("forceTorqueSensorStatus", forceTorqueSensorStatus.ToArray(), typeof(CRCL_ForceTorqueSensorStatusDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            onOffSensorStatus = (CRCL_OnOffSensorStatusDataTypeCollection)decoder.ReadEncodeableArray("onOffSensorStatus", typeof(CRCL_OnOffSensorStatusDataType));
            scalarSensorStatus = (CRCL_ScalarSensorStatusDataTypeCollection)decoder.ReadEncodeableArray("scalarSensorStatus", typeof(CRCL_ScalarSensorStatusDataType));
            countSensorStatus = (CRCL_CountSensorStatusDataTypeCollection)decoder.ReadEncodeableArray("countSensorStatus", typeof(CRCL_CountSensorStatusDataType));
            forceTorqueSensorStatus = (CRCL_ForceTorqueSensorStatusDataTypeCollection)decoder.ReadEncodeableArray("forceTorqueSensorStatus", typeof(CRCL_ForceTorqueSensorStatusDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_SensorStatusesDataType value = encodeable as CRCL_SensorStatusesDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_onOffSensorStatus, value.m_onOffSensorStatus)) return false;
            if (!Utils.IsEqual(m_scalarSensorStatus, value.m_scalarSensorStatus)) return false;
            if (!Utils.IsEqual(m_countSensorStatus, value.m_countSensorStatus)) return false;
            if (!Utils.IsEqual(m_forceTorqueSensorStatus, value.m_forceTorqueSensorStatus)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_SensorStatusesDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SensorStatusesDataType clone = (CRCL_SensorStatusesDataType)base.MemberwiseClone();

            clone.m_onOffSensorStatus = (CRCL_OnOffSensorStatusDataTypeCollection)Utils.Clone(this.m_onOffSensorStatus);
            clone.m_scalarSensorStatus = (CRCL_ScalarSensorStatusDataTypeCollection)Utils.Clone(this.m_scalarSensorStatus);
            clone.m_countSensorStatus = (CRCL_CountSensorStatusDataTypeCollection)Utils.Clone(this.m_countSensorStatus);
            clone.m_forceTorqueSensorStatus = (CRCL_ForceTorqueSensorStatusDataTypeCollection)Utils.Clone(this.m_forceTorqueSensorStatus);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_OnOffSensorStatusDataTypeCollection m_onOffSensorStatus;
        private CRCL_ScalarSensorStatusDataTypeCollection m_scalarSensorStatus;
        private CRCL_CountSensorStatusDataTypeCollection m_countSensorStatus;
        private CRCL_ForceTorqueSensorStatusDataTypeCollection m_forceTorqueSensorStatus;
        #endregion
    }

    #region CRCL_SensorStatusesDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_SensorStatusesDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_SensorStatusesDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_SensorStatusesDataType")]
    #if !NET_STANDARD
    public partial class CRCL_SensorStatusesDataTypeCollection : List<CRCL_SensorStatusesDataType>, ICloneable
    #else
    public partial class CRCL_SensorStatusesDataTypeCollection : List<CRCL_SensorStatusesDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_SensorStatusesDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_SensorStatusesDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_SensorStatusesDataTypeCollection(IEnumerable<CRCL_SensorStatusesDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_SensorStatusesDataTypeCollection(CRCL_SensorStatusesDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_SensorStatusesDataTypeCollection(values);
            }

            return new CRCL_SensorStatusesDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_SensorStatusesDataType[](CRCL_SensorStatusesDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_SensorStatusesDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SensorStatusesDataTypeCollection clone = new CRCL_SensorStatusesDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_SensorStatusesDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_GripperStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_GripperStatusDataType)
    /// <summary>
    /// GripperStatus DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_GripperStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_GripperStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_gripperName = null;
            m_gripperOption = new CRCL_ParameterSettingDataTypeCollection();
            m_holdingObject = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "gripperName", IsRequired = false, Order = 1)]
        public string gripperName
        {
            get { return m_gripperName;  }
            set { m_gripperName = value; }
        }

        /// <summary>
        /// Options for a gripper
        /// </summary>
        [DataMember(Name = "gripperOption", IsRequired = false, Order = 2)]
        public CRCL_ParameterSettingDataTypeCollection gripperOption
        {
            get
            {
                return m_gripperOption;
            }

            set
            {
                m_gripperOption = value;

                if (value == null)
                {
                    m_gripperOption = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "holdingObject", IsRequired = false, Order = 3)]
        public bool holdingObject
        {
            get { return m_holdingObject;  }
            set { m_holdingObject = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_GripperStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_GripperStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_GripperStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteString("gripperName", gripperName);
            encoder.WriteEncodeableArray("gripperOption", gripperOption.ToArray(), typeof(CRCL_ParameterSettingDataType));
            encoder.WriteBoolean("holdingObject", holdingObject);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            gripperName = decoder.ReadString("gripperName");
            gripperOption = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("gripperOption", typeof(CRCL_ParameterSettingDataType));
            holdingObject = decoder.ReadBoolean("holdingObject");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_GripperStatusDataType value = encodeable as CRCL_GripperStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_gripperName, value.m_gripperName)) return false;
            if (!Utils.IsEqual(m_gripperOption, value.m_gripperOption)) return false;
            if (!Utils.IsEqual(m_holdingObject, value.m_holdingObject)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_GripperStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_GripperStatusDataType clone = (CRCL_GripperStatusDataType)base.MemberwiseClone();

            clone.m_gripperName = (string)Utils.Clone(this.m_gripperName);
            clone.m_gripperOption = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_gripperOption);
            clone.m_holdingObject = (bool)Utils.Clone(this.m_holdingObject);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_gripperName;
        private CRCL_ParameterSettingDataTypeCollection m_gripperOption;
        private bool m_holdingObject;
        #endregion
    }

    #region CRCL_GripperStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_GripperStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_GripperStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_GripperStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_GripperStatusDataTypeCollection : List<CRCL_GripperStatusDataType>, ICloneable
    #else
    public partial class CRCL_GripperStatusDataTypeCollection : List<CRCL_GripperStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_GripperStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_GripperStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_GripperStatusDataTypeCollection(IEnumerable<CRCL_GripperStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_GripperStatusDataTypeCollection(CRCL_GripperStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_GripperStatusDataTypeCollection(values);
            }

            return new CRCL_GripperStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_GripperStatusDataType[](CRCL_GripperStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_GripperStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_GripperStatusDataTypeCollection clone = new CRCL_GripperStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_GripperStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ParallelGripperStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ParallelGripperStatusDataType)
    /// <summary>
    /// GripperStatus DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ParallelGripperStatusDataType : CRCL_GripperStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ParallelGripperStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_seperation = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "seperation", IsRequired = false, Order = 1)]
        public double seperation
        {
            get { return m_seperation;  }
            set { m_seperation = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ParallelGripperStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ParallelGripperStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ParallelGripperStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteDouble("seperation", seperation);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            seperation = decoder.ReadDouble("seperation");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ParallelGripperStatusDataType value = encodeable as CRCL_ParallelGripperStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_seperation, value.m_seperation)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ParallelGripperStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ParallelGripperStatusDataType clone = (CRCL_ParallelGripperStatusDataType)base.MemberwiseClone();

            clone.m_seperation = (double)Utils.Clone(this.m_seperation);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_seperation;
        #endregion
    }

    #region CRCL_ParallelGripperStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ParallelGripperStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ParallelGripperStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ParallelGripperStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ParallelGripperStatusDataTypeCollection : List<CRCL_ParallelGripperStatusDataType>, ICloneable
    #else
    public partial class CRCL_ParallelGripperStatusDataTypeCollection : List<CRCL_ParallelGripperStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ParallelGripperStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ParallelGripperStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ParallelGripperStatusDataTypeCollection(IEnumerable<CRCL_ParallelGripperStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ParallelGripperStatusDataTypeCollection(CRCL_ParallelGripperStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ParallelGripperStatusDataTypeCollection(values);
            }

            return new CRCL_ParallelGripperStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ParallelGripperStatusDataType[](CRCL_ParallelGripperStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ParallelGripperStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ParallelGripperStatusDataTypeCollection clone = new CRCL_ParallelGripperStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ParallelGripperStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ThreeFingerGripperStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ThreeFingerGripperStatusDataType)
    /// <summary>
    /// GripperStatus DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ThreeFingerGripperStatusDataType : CRCL_GripperStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ThreeFingerGripperStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_finger1Position = new CRCL_FractionDataType();
            m_finger2Position = new CRCL_FractionDataType();
            m_finger3Position = new CRCL_FractionDataType();
            m_finger1Force = (double)0;
            m_finger2Force = (double)0;
            m_finger3Force = (double)0;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Position of finger 1.
        /// </summary>
        [DataMember(Name = "finger1Position", IsRequired = false, Order = 1)]
        public CRCL_FractionDataType finger1Position
        {
            get
            {
                return m_finger1Position;
            }

            set
            {
                m_finger1Position = value;

                if (value == null)
                {
                    m_finger1Position = new CRCL_FractionDataType();
                }
            }
        }

        /// <summary>
        /// Position of finger 2.
        /// </summary>
        [DataMember(Name = "finger2Position", IsRequired = false, Order = 2)]
        public CRCL_FractionDataType finger2Position
        {
            get
            {
                return m_finger2Position;
            }

            set
            {
                m_finger2Position = value;

                if (value == null)
                {
                    m_finger2Position = new CRCL_FractionDataType();
                }
            }
        }

        /// <summary>
        /// Position of finger 3.
        /// </summary>
        [DataMember(Name = "finger3Position", IsRequired = false, Order = 3)]
        public CRCL_FractionDataType finger3Position
        {
            get
            {
                return m_finger3Position;
            }

            set
            {
                m_finger3Position = value;

                if (value == null)
                {
                    m_finger3Position = new CRCL_FractionDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "finger1Force", IsRequired = false, Order = 4)]
        public double finger1Force
        {
            get { return m_finger1Force;  }
            set { m_finger1Force = value; }
        }

        /// <remarks />
        [DataMember(Name = "finger2Force", IsRequired = false, Order = 5)]
        public double finger2Force
        {
            get { return m_finger2Force;  }
            set { m_finger2Force = value; }
        }

        /// <remarks />
        [DataMember(Name = "finger3Force", IsRequired = false, Order = 6)]
        public double finger3Force
        {
            get { return m_finger3Force;  }
            set { m_finger3Force = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ThreeFingerGripperStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ThreeFingerGripperStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ThreeFingerGripperStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("finger1Position", finger1Position, typeof(CRCL_FractionDataType));
            encoder.WriteEncodeable("finger2Position", finger2Position, typeof(CRCL_FractionDataType));
            encoder.WriteEncodeable("finger3Position", finger3Position, typeof(CRCL_FractionDataType));
            encoder.WriteDouble("finger1Force", finger1Force);
            encoder.WriteDouble("finger2Force", finger2Force);
            encoder.WriteDouble("finger3Force", finger3Force);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            finger1Position = (CRCL_FractionDataType)decoder.ReadEncodeable("finger1Position", typeof(CRCL_FractionDataType));
            finger2Position = (CRCL_FractionDataType)decoder.ReadEncodeable("finger2Position", typeof(CRCL_FractionDataType));
            finger3Position = (CRCL_FractionDataType)decoder.ReadEncodeable("finger3Position", typeof(CRCL_FractionDataType));
            finger1Force = decoder.ReadDouble("finger1Force");
            finger2Force = decoder.ReadDouble("finger2Force");
            finger3Force = decoder.ReadDouble("finger3Force");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ThreeFingerGripperStatusDataType value = encodeable as CRCL_ThreeFingerGripperStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_finger1Position, value.m_finger1Position)) return false;
            if (!Utils.IsEqual(m_finger2Position, value.m_finger2Position)) return false;
            if (!Utils.IsEqual(m_finger3Position, value.m_finger3Position)) return false;
            if (!Utils.IsEqual(m_finger1Force, value.m_finger1Force)) return false;
            if (!Utils.IsEqual(m_finger2Force, value.m_finger2Force)) return false;
            if (!Utils.IsEqual(m_finger3Force, value.m_finger3Force)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ThreeFingerGripperStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ThreeFingerGripperStatusDataType clone = (CRCL_ThreeFingerGripperStatusDataType)base.MemberwiseClone();

            clone.m_finger1Position = (CRCL_FractionDataType)Utils.Clone(this.m_finger1Position);
            clone.m_finger2Position = (CRCL_FractionDataType)Utils.Clone(this.m_finger2Position);
            clone.m_finger3Position = (CRCL_FractionDataType)Utils.Clone(this.m_finger3Position);
            clone.m_finger1Force = (double)Utils.Clone(this.m_finger1Force);
            clone.m_finger2Force = (double)Utils.Clone(this.m_finger2Force);
            clone.m_finger3Force = (double)Utils.Clone(this.m_finger3Force);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_FractionDataType m_finger1Position;
        private CRCL_FractionDataType m_finger2Position;
        private CRCL_FractionDataType m_finger3Position;
        private double m_finger1Force;
        private double m_finger2Force;
        private double m_finger3Force;
        #endregion
    }

    #region CRCL_ThreeFingerGripperStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ThreeFingerGripperStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ThreeFingerGripperStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ThreeFingerGripperStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ThreeFingerGripperStatusDataTypeCollection : List<CRCL_ThreeFingerGripperStatusDataType>, ICloneable
    #else
    public partial class CRCL_ThreeFingerGripperStatusDataTypeCollection : List<CRCL_ThreeFingerGripperStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ThreeFingerGripperStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ThreeFingerGripperStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ThreeFingerGripperStatusDataTypeCollection(IEnumerable<CRCL_ThreeFingerGripperStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ThreeFingerGripperStatusDataTypeCollection(CRCL_ThreeFingerGripperStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ThreeFingerGripperStatusDataTypeCollection(values);
            }

            return new CRCL_ThreeFingerGripperStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ThreeFingerGripperStatusDataType[](CRCL_ThreeFingerGripperStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ThreeFingerGripperStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ThreeFingerGripperStatusDataTypeCollection clone = new CRCL_ThreeFingerGripperStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ThreeFingerGripperStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_VacuumGripperStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_VacuumGripperStatusDataType)
    /// <summary>
    /// GripperStatus DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_VacuumGripperStatusDataType : CRCL_GripperStatusDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_VacuumGripperStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_isPowered = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "isPowered", IsRequired = false, Order = 1)]
        public bool isPowered
        {
            get { return m_isPowered;  }
            set { m_isPowered = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_VacuumGripperStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_VacuumGripperStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_VacuumGripperStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteBoolean("isPowered", isPowered);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            isPowered = decoder.ReadBoolean("isPowered");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_VacuumGripperStatusDataType value = encodeable as CRCL_VacuumGripperStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_isPowered, value.m_isPowered)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_VacuumGripperStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_VacuumGripperStatusDataType clone = (CRCL_VacuumGripperStatusDataType)base.MemberwiseClone();

            clone.m_isPowered = (bool)Utils.Clone(this.m_isPowered);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_isPowered;
        #endregion
    }

    #region CRCL_VacuumGripperStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_VacuumGripperStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_VacuumGripperStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_VacuumGripperStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_VacuumGripperStatusDataTypeCollection : List<CRCL_VacuumGripperStatusDataType>, ICloneable
    #else
    public partial class CRCL_VacuumGripperStatusDataTypeCollection : List<CRCL_VacuumGripperStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_VacuumGripperStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_VacuumGripperStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_VacuumGripperStatusDataTypeCollection(IEnumerable<CRCL_VacuumGripperStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_VacuumGripperStatusDataTypeCollection(CRCL_VacuumGripperStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_VacuumGripperStatusDataTypeCollection(values);
            }

            return new CRCL_VacuumGripperStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_VacuumGripperStatusDataType[](CRCL_VacuumGripperStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_VacuumGripperStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_VacuumGripperStatusDataTypeCollection clone = new CRCL_VacuumGripperStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_VacuumGripperStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_SettingsStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_SettingsStatusDataType)
    /// <summary>
    /// GripperStatus DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_SettingsStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_SettingsStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_angleUnitName = CRCL_AngleUnitEnumDataType.DEGREE;
            m_endEffectorParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
            m_endEffectorSetting = new CRCL_FractionDataType();
            m_forceUnitName = CRCL_ForceUnitEnumDataType.NEWTON;
            m_jointLimits = new CRCL_JointLimitDataTypeCollection();
            m_intermediatePoseTolernace = new CRCL_PoseToleranceDataType();
            m_lengthUnitName = CRCL_LengthUnitEnumDataType.METER;
            m_maxCartesianLimit = new CRCL_PointDataType();
            m_minCartesianLimit = new CRCL_PointDataType();
            m_motionCoorinated = true;
            m_poseTolerance = new CRCL_PoseToleranceDataType();
            m_robotParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
            m_rotAccelAbsolute = new CRCL_RotAccelAbsoluteDataType();
            m_rotAccelRelative = new CRCL_RotAccelRelativeDataType();
            m_rotSpeedAbsolute = new CRCL_RotSpeedAbsoluteDataType();
            m_rotSpeedRelative = new CRCL_RotSpeedRelativeDataType();
            m_torqueUnitName = CRCL_TorqueUnitEnumDataType.NEWTONMETER;
            m_transAccelAbsolute = new CRCL_TransAccelAbsoluteDataType();
            m_transAccelRelative = new CRCL_TransAccelRelativeDataType();
            m_transSpeedAbsolute = new CRCL_TransSpeedAbsoluteDataType();
            m_transSpeedRelative = new CRCL_TransSpeedRelativeDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "angleUnitName", IsRequired = false, Order = 1)]
        public CRCL_AngleUnitEnumDataType angleUnitName
        {
            get { return m_angleUnitName;  }
            set { m_angleUnitName = value; }
        }

        /// <summary>
        /// Options for the endeffectors
        /// </summary>
        [DataMember(Name = "endEffectorParameterSetting", IsRequired = false, Order = 2)]
        public CRCL_ParameterSettingDataTypeCollection endEffectorParameterSetting
        {
            get
            {
                return m_endEffectorParameterSetting;
            }

            set
            {
                m_endEffectorParameterSetting = value;

                if (value == null)
                {
                    m_endEffectorParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// Endeffector Settings
        /// </summary>
        [DataMember(Name = "endEffectorSetting", IsRequired = false, Order = 3)]
        public CRCL_FractionDataType endEffectorSetting
        {
            get
            {
                return m_endEffectorSetting;
            }

            set
            {
                m_endEffectorSetting = value;

                if (value == null)
                {
                    m_endEffectorSetting = new CRCL_FractionDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "forceUnitName", IsRequired = false, Order = 4)]
        public CRCL_ForceUnitEnumDataType forceUnitName
        {
            get { return m_forceUnitName;  }
            set { m_forceUnitName = value; }
        }

        /// <summary>
        /// Joint limits
        /// </summary>
        [DataMember(Name = "jointLimits", IsRequired = false, Order = 5)]
        public CRCL_JointLimitDataTypeCollection jointLimits
        {
            get
            {
                return m_jointLimits;
            }

            set
            {
                m_jointLimits = value;

                if (value == null)
                {
                    m_jointLimits = new CRCL_JointLimitDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// Intermediate pose tolerance
        /// </summary>
        [DataMember(Name = "intermediatePoseTolernace", IsRequired = false, Order = 6)]
        public CRCL_PoseToleranceDataType intermediatePoseTolernace
        {
            get
            {
                return m_intermediatePoseTolernace;
            }

            set
            {
                m_intermediatePoseTolernace = value;

                if (value == null)
                {
                    m_intermediatePoseTolernace = new CRCL_PoseToleranceDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "lengthUnitName", IsRequired = false, Order = 7)]
        public CRCL_LengthUnitEnumDataType lengthUnitName
        {
            get { return m_lengthUnitName;  }
            set { m_lengthUnitName = value; }
        }

        /// <summary>
        /// Max cartesian limit
        /// </summary>
        [DataMember(Name = "maxCartesianLimit", IsRequired = false, Order = 8)]
        public CRCL_PointDataType maxCartesianLimit
        {
            get
            {
                return m_maxCartesianLimit;
            }

            set
            {
                m_maxCartesianLimit = value;

                if (value == null)
                {
                    m_maxCartesianLimit = new CRCL_PointDataType();
                }
            }
        }

        /// <summary>
        /// Min cartesian limit
        /// </summary>
        [DataMember(Name = "minCartesianLimit", IsRequired = false, Order = 9)]
        public CRCL_PointDataType minCartesianLimit
        {
            get
            {
                return m_minCartesianLimit;
            }

            set
            {
                m_minCartesianLimit = value;

                if (value == null)
                {
                    m_minCartesianLimit = new CRCL_PointDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "motionCoorinated", IsRequired = false, Order = 10)]
        public bool motionCoorinated
        {
            get { return m_motionCoorinated;  }
            set { m_motionCoorinated = value; }
        }

        /// <summary>
        /// pose tolerance
        /// </summary>
        [DataMember(Name = "poseTolerance", IsRequired = false, Order = 11)]
        public CRCL_PoseToleranceDataType poseTolerance
        {
            get
            {
                return m_poseTolerance;
            }

            set
            {
                m_poseTolerance = value;

                if (value == null)
                {
                    m_poseTolerance = new CRCL_PoseToleranceDataType();
                }
            }
        }

        /// <summary>
        /// Robot parameter settings
        /// </summary>
        [DataMember(Name = "robotParameterSetting", IsRequired = false, Order = 12)]
        public CRCL_ParameterSettingDataTypeCollection robotParameterSetting
        {
            get
            {
                return m_robotParameterSetting;
            }

            set
            {
                m_robotParameterSetting = value;

                if (value == null)
                {
                    m_robotParameterSetting = new CRCL_ParameterSettingDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// Rot accel absolute
        /// </summary>
        [DataMember(Name = "rotAccelAbsolute", IsRequired = false, Order = 13)]
        public CRCL_RotAccelAbsoluteDataType rotAccelAbsolute
        {
            get
            {
                return m_rotAccelAbsolute;
            }

            set
            {
                m_rotAccelAbsolute = value;

                if (value == null)
                {
                    m_rotAccelAbsolute = new CRCL_RotAccelAbsoluteDataType();
                }
            }
        }

        /// <summary>
        /// Rot accel relative
        /// </summary>
        [DataMember(Name = "rotAccelRelative", IsRequired = false, Order = 14)]
        public CRCL_RotAccelRelativeDataType rotAccelRelative
        {
            get
            {
                return m_rotAccelRelative;
            }

            set
            {
                m_rotAccelRelative = value;

                if (value == null)
                {
                    m_rotAccelRelative = new CRCL_RotAccelRelativeDataType();
                }
            }
        }

        /// <summary>
        /// Rot speed absolute
        /// </summary>
        [DataMember(Name = "rotSpeedAbsolute", IsRequired = false, Order = 15)]
        public CRCL_RotSpeedAbsoluteDataType rotSpeedAbsolute
        {
            get
            {
                return m_rotSpeedAbsolute;
            }

            set
            {
                m_rotSpeedAbsolute = value;

                if (value == null)
                {
                    m_rotSpeedAbsolute = new CRCL_RotSpeedAbsoluteDataType();
                }
            }
        }

        /// <summary>
        /// Rot speed relative
        /// </summary>
        [DataMember(Name = "rotSpeedRelative", IsRequired = false, Order = 16)]
        public CRCL_RotSpeedRelativeDataType rotSpeedRelative
        {
            get
            {
                return m_rotSpeedRelative;
            }

            set
            {
                m_rotSpeedRelative = value;

                if (value == null)
                {
                    m_rotSpeedRelative = new CRCL_RotSpeedRelativeDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "torqueUnitName", IsRequired = false, Order = 17)]
        public CRCL_TorqueUnitEnumDataType torqueUnitName
        {
            get { return m_torqueUnitName;  }
            set { m_torqueUnitName = value; }
        }

        /// <summary>
        /// translation accel absolute
        /// </summary>
        [DataMember(Name = "transAccelAbsolute", IsRequired = false, Order = 18)]
        public CRCL_TransAccelAbsoluteDataType transAccelAbsolute
        {
            get
            {
                return m_transAccelAbsolute;
            }

            set
            {
                m_transAccelAbsolute = value;

                if (value == null)
                {
                    m_transAccelAbsolute = new CRCL_TransAccelAbsoluteDataType();
                }
            }
        }

        /// <summary>
        /// translation accel relative
        /// </summary>
        [DataMember(Name = "transAccelRelative", IsRequired = false, Order = 19)]
        public CRCL_TransAccelRelativeDataType transAccelRelative
        {
            get
            {
                return m_transAccelRelative;
            }

            set
            {
                m_transAccelRelative = value;

                if (value == null)
                {
                    m_transAccelRelative = new CRCL_TransAccelRelativeDataType();
                }
            }
        }

        /// <summary>
        /// translation speed absolute
        /// </summary>
        [DataMember(Name = "transSpeedAbsolute", IsRequired = false, Order = 20)]
        public CRCL_TransSpeedAbsoluteDataType transSpeedAbsolute
        {
            get
            {
                return m_transSpeedAbsolute;
            }

            set
            {
                m_transSpeedAbsolute = value;

                if (value == null)
                {
                    m_transSpeedAbsolute = new CRCL_TransSpeedAbsoluteDataType();
                }
            }
        }

        /// <summary>
        /// translation speed relative
        /// </summary>
        [DataMember(Name = "transSpeedRelative", IsRequired = false, Order = 21)]
        public CRCL_TransSpeedRelativeDataType transSpeedRelative
        {
            get
            {
                return m_transSpeedRelative;
            }

            set
            {
                m_transSpeedRelative = value;

                if (value == null)
                {
                    m_transSpeedRelative = new CRCL_TransSpeedRelativeDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_SettingsStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_SettingsStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_SettingsStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEnumerated("angleUnitName", angleUnitName);
            encoder.WriteEncodeableArray("endEffectorParameterSetting", endEffectorParameterSetting.ToArray(), typeof(CRCL_ParameterSettingDataType));
            encoder.WriteEncodeable("endEffectorSetting", endEffectorSetting, typeof(CRCL_FractionDataType));
            encoder.WriteEnumerated("forceUnitName", forceUnitName);
            encoder.WriteEncodeableArray("jointLimits", jointLimits.ToArray(), typeof(CRCL_JointLimitDataType));
            encoder.WriteEncodeable("intermediatePoseTolernace", intermediatePoseTolernace, typeof(CRCL_PoseToleranceDataType));
            encoder.WriteEnumerated("lengthUnitName", lengthUnitName);
            encoder.WriteEncodeable("maxCartesianLimit", maxCartesianLimit, typeof(CRCL_PointDataType));
            encoder.WriteEncodeable("minCartesianLimit", minCartesianLimit, typeof(CRCL_PointDataType));
            encoder.WriteBoolean("motionCoorinated", motionCoorinated);
            encoder.WriteEncodeable("poseTolerance", poseTolerance, typeof(CRCL_PoseToleranceDataType));
            encoder.WriteEncodeableArray("robotParameterSetting", robotParameterSetting.ToArray(), typeof(CRCL_ParameterSettingDataType));
            encoder.WriteEncodeable("rotAccelAbsolute", rotAccelAbsolute, typeof(CRCL_RotAccelAbsoluteDataType));
            encoder.WriteEncodeable("rotAccelRelative", rotAccelRelative, typeof(CRCL_RotAccelRelativeDataType));
            encoder.WriteEncodeable("rotSpeedAbsolute", rotSpeedAbsolute, typeof(CRCL_RotSpeedAbsoluteDataType));
            encoder.WriteEncodeable("rotSpeedRelative", rotSpeedRelative, typeof(CRCL_RotSpeedRelativeDataType));
            encoder.WriteEnumerated("torqueUnitName", torqueUnitName);
            encoder.WriteEncodeable("transAccelAbsolute", transAccelAbsolute, typeof(CRCL_TransAccelAbsoluteDataType));
            encoder.WriteEncodeable("transAccelRelative", transAccelRelative, typeof(CRCL_TransAccelRelativeDataType));
            encoder.WriteEncodeable("transSpeedAbsolute", transSpeedAbsolute, typeof(CRCL_TransSpeedAbsoluteDataType));
            encoder.WriteEncodeable("transSpeedRelative", transSpeedRelative, typeof(CRCL_TransSpeedRelativeDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            angleUnitName = (CRCL_AngleUnitEnumDataType)decoder.ReadEnumerated("angleUnitName", typeof(CRCL_AngleUnitEnumDataType));
            endEffectorParameterSetting = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("endEffectorParameterSetting", typeof(CRCL_ParameterSettingDataType));
            endEffectorSetting = (CRCL_FractionDataType)decoder.ReadEncodeable("endEffectorSetting", typeof(CRCL_FractionDataType));
            forceUnitName = (CRCL_ForceUnitEnumDataType)decoder.ReadEnumerated("forceUnitName", typeof(CRCL_ForceUnitEnumDataType));
            jointLimits = (CRCL_JointLimitDataTypeCollection)decoder.ReadEncodeableArray("jointLimits", typeof(CRCL_JointLimitDataType));
            intermediatePoseTolernace = (CRCL_PoseToleranceDataType)decoder.ReadEncodeable("intermediatePoseTolernace", typeof(CRCL_PoseToleranceDataType));
            lengthUnitName = (CRCL_LengthUnitEnumDataType)decoder.ReadEnumerated("lengthUnitName", typeof(CRCL_LengthUnitEnumDataType));
            maxCartesianLimit = (CRCL_PointDataType)decoder.ReadEncodeable("maxCartesianLimit", typeof(CRCL_PointDataType));
            minCartesianLimit = (CRCL_PointDataType)decoder.ReadEncodeable("minCartesianLimit", typeof(CRCL_PointDataType));
            motionCoorinated = decoder.ReadBoolean("motionCoorinated");
            poseTolerance = (CRCL_PoseToleranceDataType)decoder.ReadEncodeable("poseTolerance", typeof(CRCL_PoseToleranceDataType));
            robotParameterSetting = (CRCL_ParameterSettingDataTypeCollection)decoder.ReadEncodeableArray("robotParameterSetting", typeof(CRCL_ParameterSettingDataType));
            rotAccelAbsolute = (CRCL_RotAccelAbsoluteDataType)decoder.ReadEncodeable("rotAccelAbsolute", typeof(CRCL_RotAccelAbsoluteDataType));
            rotAccelRelative = (CRCL_RotAccelRelativeDataType)decoder.ReadEncodeable("rotAccelRelative", typeof(CRCL_RotAccelRelativeDataType));
            rotSpeedAbsolute = (CRCL_RotSpeedAbsoluteDataType)decoder.ReadEncodeable("rotSpeedAbsolute", typeof(CRCL_RotSpeedAbsoluteDataType));
            rotSpeedRelative = (CRCL_RotSpeedRelativeDataType)decoder.ReadEncodeable("rotSpeedRelative", typeof(CRCL_RotSpeedRelativeDataType));
            torqueUnitName = (CRCL_TorqueUnitEnumDataType)decoder.ReadEnumerated("torqueUnitName", typeof(CRCL_TorqueUnitEnumDataType));
            transAccelAbsolute = (CRCL_TransAccelAbsoluteDataType)decoder.ReadEncodeable("transAccelAbsolute", typeof(CRCL_TransAccelAbsoluteDataType));
            transAccelRelative = (CRCL_TransAccelRelativeDataType)decoder.ReadEncodeable("transAccelRelative", typeof(CRCL_TransAccelRelativeDataType));
            transSpeedAbsolute = (CRCL_TransSpeedAbsoluteDataType)decoder.ReadEncodeable("transSpeedAbsolute", typeof(CRCL_TransSpeedAbsoluteDataType));
            transSpeedRelative = (CRCL_TransSpeedRelativeDataType)decoder.ReadEncodeable("transSpeedRelative", typeof(CRCL_TransSpeedRelativeDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_SettingsStatusDataType value = encodeable as CRCL_SettingsStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_angleUnitName, value.m_angleUnitName)) return false;
            if (!Utils.IsEqual(m_endEffectorParameterSetting, value.m_endEffectorParameterSetting)) return false;
            if (!Utils.IsEqual(m_endEffectorSetting, value.m_endEffectorSetting)) return false;
            if (!Utils.IsEqual(m_forceUnitName, value.m_forceUnitName)) return false;
            if (!Utils.IsEqual(m_jointLimits, value.m_jointLimits)) return false;
            if (!Utils.IsEqual(m_intermediatePoseTolernace, value.m_intermediatePoseTolernace)) return false;
            if (!Utils.IsEqual(m_lengthUnitName, value.m_lengthUnitName)) return false;
            if (!Utils.IsEqual(m_maxCartesianLimit, value.m_maxCartesianLimit)) return false;
            if (!Utils.IsEqual(m_minCartesianLimit, value.m_minCartesianLimit)) return false;
            if (!Utils.IsEqual(m_motionCoorinated, value.m_motionCoorinated)) return false;
            if (!Utils.IsEqual(m_poseTolerance, value.m_poseTolerance)) return false;
            if (!Utils.IsEqual(m_robotParameterSetting, value.m_robotParameterSetting)) return false;
            if (!Utils.IsEqual(m_rotAccelAbsolute, value.m_rotAccelAbsolute)) return false;
            if (!Utils.IsEqual(m_rotAccelRelative, value.m_rotAccelRelative)) return false;
            if (!Utils.IsEqual(m_rotSpeedAbsolute, value.m_rotSpeedAbsolute)) return false;
            if (!Utils.IsEqual(m_rotSpeedRelative, value.m_rotSpeedRelative)) return false;
            if (!Utils.IsEqual(m_torqueUnitName, value.m_torqueUnitName)) return false;
            if (!Utils.IsEqual(m_transAccelAbsolute, value.m_transAccelAbsolute)) return false;
            if (!Utils.IsEqual(m_transAccelRelative, value.m_transAccelRelative)) return false;
            if (!Utils.IsEqual(m_transSpeedAbsolute, value.m_transSpeedAbsolute)) return false;
            if (!Utils.IsEqual(m_transSpeedRelative, value.m_transSpeedRelative)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_SettingsStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SettingsStatusDataType clone = (CRCL_SettingsStatusDataType)base.MemberwiseClone();

            clone.m_angleUnitName = (CRCL_AngleUnitEnumDataType)Utils.Clone(this.m_angleUnitName);
            clone.m_endEffectorParameterSetting = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_endEffectorParameterSetting);
            clone.m_endEffectorSetting = (CRCL_FractionDataType)Utils.Clone(this.m_endEffectorSetting);
            clone.m_forceUnitName = (CRCL_ForceUnitEnumDataType)Utils.Clone(this.m_forceUnitName);
            clone.m_jointLimits = (CRCL_JointLimitDataTypeCollection)Utils.Clone(this.m_jointLimits);
            clone.m_intermediatePoseTolernace = (CRCL_PoseToleranceDataType)Utils.Clone(this.m_intermediatePoseTolernace);
            clone.m_lengthUnitName = (CRCL_LengthUnitEnumDataType)Utils.Clone(this.m_lengthUnitName);
            clone.m_maxCartesianLimit = (CRCL_PointDataType)Utils.Clone(this.m_maxCartesianLimit);
            clone.m_minCartesianLimit = (CRCL_PointDataType)Utils.Clone(this.m_minCartesianLimit);
            clone.m_motionCoorinated = (bool)Utils.Clone(this.m_motionCoorinated);
            clone.m_poseTolerance = (CRCL_PoseToleranceDataType)Utils.Clone(this.m_poseTolerance);
            clone.m_robotParameterSetting = (CRCL_ParameterSettingDataTypeCollection)Utils.Clone(this.m_robotParameterSetting);
            clone.m_rotAccelAbsolute = (CRCL_RotAccelAbsoluteDataType)Utils.Clone(this.m_rotAccelAbsolute);
            clone.m_rotAccelRelative = (CRCL_RotAccelRelativeDataType)Utils.Clone(this.m_rotAccelRelative);
            clone.m_rotSpeedAbsolute = (CRCL_RotSpeedAbsoluteDataType)Utils.Clone(this.m_rotSpeedAbsolute);
            clone.m_rotSpeedRelative = (CRCL_RotSpeedRelativeDataType)Utils.Clone(this.m_rotSpeedRelative);
            clone.m_torqueUnitName = (CRCL_TorqueUnitEnumDataType)Utils.Clone(this.m_torqueUnitName);
            clone.m_transAccelAbsolute = (CRCL_TransAccelAbsoluteDataType)Utils.Clone(this.m_transAccelAbsolute);
            clone.m_transAccelRelative = (CRCL_TransAccelRelativeDataType)Utils.Clone(this.m_transAccelRelative);
            clone.m_transSpeedAbsolute = (CRCL_TransSpeedAbsoluteDataType)Utils.Clone(this.m_transSpeedAbsolute);
            clone.m_transSpeedRelative = (CRCL_TransSpeedRelativeDataType)Utils.Clone(this.m_transSpeedRelative);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_AngleUnitEnumDataType m_angleUnitName;
        private CRCL_ParameterSettingDataTypeCollection m_endEffectorParameterSetting;
        private CRCL_FractionDataType m_endEffectorSetting;
        private CRCL_ForceUnitEnumDataType m_forceUnitName;
        private CRCL_JointLimitDataTypeCollection m_jointLimits;
        private CRCL_PoseToleranceDataType m_intermediatePoseTolernace;
        private CRCL_LengthUnitEnumDataType m_lengthUnitName;
        private CRCL_PointDataType m_maxCartesianLimit;
        private CRCL_PointDataType m_minCartesianLimit;
        private bool m_motionCoorinated;
        private CRCL_PoseToleranceDataType m_poseTolerance;
        private CRCL_ParameterSettingDataTypeCollection m_robotParameterSetting;
        private CRCL_RotAccelAbsoluteDataType m_rotAccelAbsolute;
        private CRCL_RotAccelRelativeDataType m_rotAccelRelative;
        private CRCL_RotSpeedAbsoluteDataType m_rotSpeedAbsolute;
        private CRCL_RotSpeedRelativeDataType m_rotSpeedRelative;
        private CRCL_TorqueUnitEnumDataType m_torqueUnitName;
        private CRCL_TransAccelAbsoluteDataType m_transAccelAbsolute;
        private CRCL_TransAccelRelativeDataType m_transAccelRelative;
        private CRCL_TransSpeedAbsoluteDataType m_transSpeedAbsolute;
        private CRCL_TransSpeedRelativeDataType m_transSpeedRelative;
        #endregion
    }

    #region CRCL_SettingsStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_SettingsStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_SettingsStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_SettingsStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_SettingsStatusDataTypeCollection : List<CRCL_SettingsStatusDataType>, ICloneable
    #else
    public partial class CRCL_SettingsStatusDataTypeCollection : List<CRCL_SettingsStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_SettingsStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_SettingsStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_SettingsStatusDataTypeCollection(IEnumerable<CRCL_SettingsStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_SettingsStatusDataTypeCollection(CRCL_SettingsStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_SettingsStatusDataTypeCollection(values);
            }

            return new CRCL_SettingsStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_SettingsStatusDataType[](CRCL_SettingsStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_SettingsStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_SettingsStatusDataTypeCollection clone = new CRCL_SettingsStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_SettingsStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_PoseStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_PoseStatusDataType)
    /// <summary>
    /// Pose Status DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_PoseStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_PoseStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_pose = new CRCL_PoseDataType();
            m_twist = new CRCL_TwistDataType();
            m_wrench = new CRCL_WrenchDataType();
            m_configuration = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// pose of robot tcp
        /// </summary>
        [DataMember(Name = "pose", IsRequired = false, Order = 1)]
        public CRCL_PoseDataType pose
        {
            get
            {
                return m_pose;
            }

            set
            {
                m_pose = value;

                if (value == null)
                {
                    m_pose = new CRCL_PoseDataType();
                }
            }
        }

        /// <summary>
        /// twist of robot tcp
        /// </summary>
        [DataMember(Name = "twist", IsRequired = false, Order = 2)]
        public CRCL_TwistDataType twist
        {
            get
            {
                return m_twist;
            }

            set
            {
                m_twist = value;

                if (value == null)
                {
                    m_twist = new CRCL_TwistDataType();
                }
            }
        }

        /// <summary>
        /// wrench of robot tcp
        /// </summary>
        [DataMember(Name = "wrench", IsRequired = false, Order = 3)]
        public CRCL_WrenchDataType wrench
        {
            get
            {
                return m_wrench;
            }

            set
            {
                m_wrench = value;

                if (value == null)
                {
                    m_wrench = new CRCL_WrenchDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "configuration", IsRequired = false, Order = 4)]
        public string configuration
        {
            get { return m_configuration;  }
            set { m_configuration = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_PoseStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_PoseStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_PoseStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("pose", pose, typeof(CRCL_PoseDataType));
            encoder.WriteEncodeable("twist", twist, typeof(CRCL_TwistDataType));
            encoder.WriteEncodeable("wrench", wrench, typeof(CRCL_WrenchDataType));
            encoder.WriteString("configuration", configuration);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            pose = (CRCL_PoseDataType)decoder.ReadEncodeable("pose", typeof(CRCL_PoseDataType));
            twist = (CRCL_TwistDataType)decoder.ReadEncodeable("twist", typeof(CRCL_TwistDataType));
            wrench = (CRCL_WrenchDataType)decoder.ReadEncodeable("wrench", typeof(CRCL_WrenchDataType));
            configuration = decoder.ReadString("configuration");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_PoseStatusDataType value = encodeable as CRCL_PoseStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_pose, value.m_pose)) return false;
            if (!Utils.IsEqual(m_twist, value.m_twist)) return false;
            if (!Utils.IsEqual(m_wrench, value.m_wrench)) return false;
            if (!Utils.IsEqual(m_configuration, value.m_configuration)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_PoseStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseStatusDataType clone = (CRCL_PoseStatusDataType)base.MemberwiseClone();

            clone.m_pose = (CRCL_PoseDataType)Utils.Clone(this.m_pose);
            clone.m_twist = (CRCL_TwistDataType)Utils.Clone(this.m_twist);
            clone.m_wrench = (CRCL_WrenchDataType)Utils.Clone(this.m_wrench);
            clone.m_configuration = (string)Utils.Clone(this.m_configuration);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_PoseDataType m_pose;
        private CRCL_TwistDataType m_twist;
        private CRCL_WrenchDataType m_wrench;
        private string m_configuration;
        #endregion
    }

    #region CRCL_PoseStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_PoseStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_PoseStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_PoseStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_PoseStatusDataTypeCollection : List<CRCL_PoseStatusDataType>, ICloneable
    #else
    public partial class CRCL_PoseStatusDataTypeCollection : List<CRCL_PoseStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_PoseStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_PoseStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_PoseStatusDataTypeCollection(IEnumerable<CRCL_PoseStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_PoseStatusDataTypeCollection(CRCL_PoseStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_PoseStatusDataTypeCollection(values);
            }

            return new CRCL_PoseStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_PoseStatusDataType[](CRCL_PoseStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_PoseStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_PoseStatusDataTypeCollection clone = new CRCL_PoseStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_PoseStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointLimitDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointLimitDataType)
    /// <summary>
    /// Pose Status DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointLimitDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointLimitDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointNumber = (uint)0;
            m_jointMinPosition = (double)0;
            m_jointMaxPosition = (double)0;
            m_jointMaxTorqueOrForce = (double)0;
            m_jointMaxVelocity = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "jointNumber", IsRequired = false, Order = 1)]
        public uint jointNumber
        {
            get { return m_jointNumber;  }
            set { m_jointNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointMinPosition", IsRequired = false, Order = 2)]
        public double jointMinPosition
        {
            get { return m_jointMinPosition;  }
            set { m_jointMinPosition = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointMaxPosition", IsRequired = false, Order = 3)]
        public double jointMaxPosition
        {
            get { return m_jointMaxPosition;  }
            set { m_jointMaxPosition = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointMaxTorqueOrForce", IsRequired = false, Order = 4)]
        public double jointMaxTorqueOrForce
        {
            get { return m_jointMaxTorqueOrForce;  }
            set { m_jointMaxTorqueOrForce = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointMaxVelocity", IsRequired = false, Order = 5)]
        public double jointMaxVelocity
        {
            get { return m_jointMaxVelocity;  }
            set { m_jointMaxVelocity = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointLimitDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointLimitDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointLimitDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("jointNumber", jointNumber);
            encoder.WriteDouble("jointMinPosition", jointMinPosition);
            encoder.WriteDouble("jointMaxPosition", jointMaxPosition);
            encoder.WriteDouble("jointMaxTorqueOrForce", jointMaxTorqueOrForce);
            encoder.WriteDouble("jointMaxVelocity", jointMaxVelocity);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            jointNumber = decoder.ReadUInt32("jointNumber");
            jointMinPosition = decoder.ReadDouble("jointMinPosition");
            jointMaxPosition = decoder.ReadDouble("jointMaxPosition");
            jointMaxTorqueOrForce = decoder.ReadDouble("jointMaxTorqueOrForce");
            jointMaxVelocity = decoder.ReadDouble("jointMaxVelocity");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointLimitDataType value = encodeable as CRCL_JointLimitDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointNumber, value.m_jointNumber)) return false;
            if (!Utils.IsEqual(m_jointMinPosition, value.m_jointMinPosition)) return false;
            if (!Utils.IsEqual(m_jointMaxPosition, value.m_jointMaxPosition)) return false;
            if (!Utils.IsEqual(m_jointMaxTorqueOrForce, value.m_jointMaxTorqueOrForce)) return false;
            if (!Utils.IsEqual(m_jointMaxVelocity, value.m_jointMaxVelocity)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointLimitDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointLimitDataType clone = (CRCL_JointLimitDataType)base.MemberwiseClone();

            clone.m_jointNumber = (uint)Utils.Clone(this.m_jointNumber);
            clone.m_jointMinPosition = (double)Utils.Clone(this.m_jointMinPosition);
            clone.m_jointMaxPosition = (double)Utils.Clone(this.m_jointMaxPosition);
            clone.m_jointMaxTorqueOrForce = (double)Utils.Clone(this.m_jointMaxTorqueOrForce);
            clone.m_jointMaxVelocity = (double)Utils.Clone(this.m_jointMaxVelocity);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_jointNumber;
        private double m_jointMinPosition;
        private double m_jointMaxPosition;
        private double m_jointMaxTorqueOrForce;
        private double m_jointMaxVelocity;
        #endregion
    }

    #region CRCL_JointLimitDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointLimitDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointLimitDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointLimitDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointLimitDataTypeCollection : List<CRCL_JointLimitDataType>, ICloneable
    #else
    public partial class CRCL_JointLimitDataTypeCollection : List<CRCL_JointLimitDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointLimitDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointLimitDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointLimitDataTypeCollection(IEnumerable<CRCL_JointLimitDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointLimitDataTypeCollection(CRCL_JointLimitDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointLimitDataTypeCollection(values);
            }

            return new CRCL_JointLimitDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointLimitDataType[](CRCL_JointLimitDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointLimitDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointLimitDataTypeCollection clone = new CRCL_JointLimitDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointLimitDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointStatusDataType)
    /// <summary>
    /// Pose Status DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointNumber = (uint)0;
            m_jointPosition = (double)0;
            m_jointTorqueOrForce = (double)0;
            m_jointVelocity = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "jointNumber", IsRequired = false, Order = 1)]
        public uint jointNumber
        {
            get { return m_jointNumber;  }
            set { m_jointNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointPosition", IsRequired = false, Order = 2)]
        public double jointPosition
        {
            get { return m_jointPosition;  }
            set { m_jointPosition = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointTorqueOrForce", IsRequired = false, Order = 3)]
        public double jointTorqueOrForce
        {
            get { return m_jointTorqueOrForce;  }
            set { m_jointTorqueOrForce = value; }
        }

        /// <remarks />
        [DataMember(Name = "jointVelocity", IsRequired = false, Order = 4)]
        public double jointVelocity
        {
            get { return m_jointVelocity;  }
            set { m_jointVelocity = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("jointNumber", jointNumber);
            encoder.WriteDouble("jointPosition", jointPosition);
            encoder.WriteDouble("jointTorqueOrForce", jointTorqueOrForce);
            encoder.WriteDouble("jointVelocity", jointVelocity);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            jointNumber = decoder.ReadUInt32("jointNumber");
            jointPosition = decoder.ReadDouble("jointPosition");
            jointTorqueOrForce = decoder.ReadDouble("jointTorqueOrForce");
            jointVelocity = decoder.ReadDouble("jointVelocity");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointStatusDataType value = encodeable as CRCL_JointStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointNumber, value.m_jointNumber)) return false;
            if (!Utils.IsEqual(m_jointPosition, value.m_jointPosition)) return false;
            if (!Utils.IsEqual(m_jointTorqueOrForce, value.m_jointTorqueOrForce)) return false;
            if (!Utils.IsEqual(m_jointVelocity, value.m_jointVelocity)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointStatusDataType clone = (CRCL_JointStatusDataType)base.MemberwiseClone();

            clone.m_jointNumber = (uint)Utils.Clone(this.m_jointNumber);
            clone.m_jointPosition = (double)Utils.Clone(this.m_jointPosition);
            clone.m_jointTorqueOrForce = (double)Utils.Clone(this.m_jointTorqueOrForce);
            clone.m_jointVelocity = (double)Utils.Clone(this.m_jointVelocity);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_jointNumber;
        private double m_jointPosition;
        private double m_jointTorqueOrForce;
        private double m_jointVelocity;
        #endregion
    }

    #region CRCL_JointStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointStatusDataTypeCollection : List<CRCL_JointStatusDataType>, ICloneable
    #else
    public partial class CRCL_JointStatusDataTypeCollection : List<CRCL_JointStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointStatusDataTypeCollection(IEnumerable<CRCL_JointStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointStatusDataTypeCollection(CRCL_JointStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointStatusDataTypeCollection(values);
            }

            return new CRCL_JointStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointStatusDataType[](CRCL_JointStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointStatusDataTypeCollection clone = new CRCL_JointStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_JointStatusesDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_JointStatusesDataType)
    /// <summary>
    /// Pose Status DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_JointStatusesDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_JointStatusesDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointStatus = new CRCL_JointStatusDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// status of joints
        /// </summary>
        [DataMember(Name = "jointStatus", IsRequired = false, Order = 1)]
        public CRCL_JointStatusDataTypeCollection jointStatus
        {
            get
            {
                return m_jointStatus;
            }

            set
            {
                m_jointStatus = value;

                if (value == null)
                {
                    m_jointStatus = new CRCL_JointStatusDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_JointStatusesDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_JointStatusesDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_JointStatusesDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeableArray("jointStatus", jointStatus.ToArray(), typeof(CRCL_JointStatusDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            jointStatus = (CRCL_JointStatusDataTypeCollection)decoder.ReadEncodeableArray("jointStatus", typeof(CRCL_JointStatusDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_JointStatusesDataType value = encodeable as CRCL_JointStatusesDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointStatus, value.m_jointStatus)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_JointStatusesDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointStatusesDataType clone = (CRCL_JointStatusesDataType)base.MemberwiseClone();

            clone.m_jointStatus = (CRCL_JointStatusDataTypeCollection)Utils.Clone(this.m_jointStatus);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_JointStatusDataTypeCollection m_jointStatus;
        #endregion
    }

    #region CRCL_JointStatusesDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_JointStatusesDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_JointStatusesDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_JointStatusesDataType")]
    #if !NET_STANDARD
    public partial class CRCL_JointStatusesDataTypeCollection : List<CRCL_JointStatusesDataType>, ICloneable
    #else
    public partial class CRCL_JointStatusesDataTypeCollection : List<CRCL_JointStatusesDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_JointStatusesDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_JointStatusesDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_JointStatusesDataTypeCollection(IEnumerable<CRCL_JointStatusesDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_JointStatusesDataTypeCollection(CRCL_JointStatusesDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_JointStatusesDataTypeCollection(values);
            }

            return new CRCL_JointStatusesDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_JointStatusesDataType[](CRCL_JointStatusesDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_JointStatusesDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_JointStatusesDataTypeCollection clone = new CRCL_JointStatusesDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_JointStatusesDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCLStatusDataType Class
    #if (!OPCUA_EXCLUDE_CRCLStatusDataType)
    /// <summary>
    /// Pose Status DataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCLStatusDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCLStatusDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_commandStatus = new CRCL_CommandStatusDataType();
            m_jointStatus = new CRCL_JointStatusesDataType();
            m_poseStatus = new CRCL_PoseStatusDataType();
            m_gripperStatus = new CRCL_GripperStatusDataType();
            m_settingsStatus = new CRCL_SettingsStatusDataType();
            m_sensorStatuses = new CRCL_SensorStatusesDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// status of crcl command
        /// </summary>
        [DataMember(Name = "commandStatus", IsRequired = false, Order = 1)]
        public CRCL_CommandStatusDataType commandStatus
        {
            get
            {
                return m_commandStatus;
            }

            set
            {
                m_commandStatus = value;

                if (value == null)
                {
                    m_commandStatus = new CRCL_CommandStatusDataType();
                }
            }
        }

        /// <summary>
        /// status of robot joints
        /// </summary>
        [DataMember(Name = "jointStatus", IsRequired = false, Order = 2)]
        public CRCL_JointStatusesDataType jointStatus
        {
            get
            {
                return m_jointStatus;
            }

            set
            {
                m_jointStatus = value;

                if (value == null)
                {
                    m_jointStatus = new CRCL_JointStatusesDataType();
                }
            }
        }

        /// <summary>
        /// status of tcp pose
        /// </summary>
        [DataMember(Name = "poseStatus", IsRequired = false, Order = 3)]
        public CRCL_PoseStatusDataType poseStatus
        {
            get
            {
                return m_poseStatus;
            }

            set
            {
                m_poseStatus = value;

                if (value == null)
                {
                    m_poseStatus = new CRCL_PoseStatusDataType();
                }
            }
        }

        /// <summary>
        /// status of gripper
        /// </summary>
        [DataMember(Name = "gripperStatus", IsRequired = false, Order = 4)]
        public CRCL_GripperStatusDataType gripperStatus
        {
            get
            {
                return m_gripperStatus;
            }

            set
            {
                m_gripperStatus = value;

                if (value == null)
                {
                    m_gripperStatus = new CRCL_GripperStatusDataType();
                }
            }
        }

        /// <summary>
        /// status of robot settings
        /// </summary>
        [DataMember(Name = "settingsStatus", IsRequired = false, Order = 5)]
        public CRCL_SettingsStatusDataType settingsStatus
        {
            get
            {
                return m_settingsStatus;
            }

            set
            {
                m_settingsStatus = value;

                if (value == null)
                {
                    m_settingsStatus = new CRCL_SettingsStatusDataType();
                }
            }
        }

        /// <summary>
        /// status of gripper
        /// </summary>
        [DataMember(Name = "sensorStatuses", IsRequired = false, Order = 6)]
        public CRCL_SensorStatusesDataType sensorStatuses
        {
            get
            {
                return m_sensorStatuses;
            }

            set
            {
                m_sensorStatuses = value;

                if (value == null)
                {
                    m_sensorStatuses = new CRCL_SensorStatusesDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCLStatusDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCLStatusDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCLStatusDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteEncodeable("commandStatus", commandStatus, typeof(CRCL_CommandStatusDataType));
            encoder.WriteEncodeable("jointStatus", jointStatus, typeof(CRCL_JointStatusesDataType));
            encoder.WriteEncodeable("poseStatus", poseStatus, typeof(CRCL_PoseStatusDataType));
            encoder.WriteEncodeable("gripperStatus", gripperStatus, typeof(CRCL_GripperStatusDataType));
            encoder.WriteEncodeable("settingsStatus", settingsStatus, typeof(CRCL_SettingsStatusDataType));
            encoder.WriteEncodeable("sensorStatuses", sensorStatuses, typeof(CRCL_SensorStatusesDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            commandStatus = (CRCL_CommandStatusDataType)decoder.ReadEncodeable("commandStatus", typeof(CRCL_CommandStatusDataType));
            jointStatus = (CRCL_JointStatusesDataType)decoder.ReadEncodeable("jointStatus", typeof(CRCL_JointStatusesDataType));
            poseStatus = (CRCL_PoseStatusDataType)decoder.ReadEncodeable("poseStatus", typeof(CRCL_PoseStatusDataType));
            gripperStatus = (CRCL_GripperStatusDataType)decoder.ReadEncodeable("gripperStatus", typeof(CRCL_GripperStatusDataType));
            settingsStatus = (CRCL_SettingsStatusDataType)decoder.ReadEncodeable("settingsStatus", typeof(CRCL_SettingsStatusDataType));
            sensorStatuses = (CRCL_SensorStatusesDataType)decoder.ReadEncodeable("sensorStatuses", typeof(CRCL_SensorStatusesDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCLStatusDataType value = encodeable as CRCLStatusDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_commandStatus, value.m_commandStatus)) return false;
            if (!Utils.IsEqual(m_jointStatus, value.m_jointStatus)) return false;
            if (!Utils.IsEqual(m_poseStatus, value.m_poseStatus)) return false;
            if (!Utils.IsEqual(m_gripperStatus, value.m_gripperStatus)) return false;
            if (!Utils.IsEqual(m_settingsStatus, value.m_settingsStatus)) return false;
            if (!Utils.IsEqual(m_sensorStatuses, value.m_sensorStatuses)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCLStatusDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLStatusDataType clone = (CRCLStatusDataType)base.MemberwiseClone();

            clone.m_commandStatus = (CRCL_CommandStatusDataType)Utils.Clone(this.m_commandStatus);
            clone.m_jointStatus = (CRCL_JointStatusesDataType)Utils.Clone(this.m_jointStatus);
            clone.m_poseStatus = (CRCL_PoseStatusDataType)Utils.Clone(this.m_poseStatus);
            clone.m_gripperStatus = (CRCL_GripperStatusDataType)Utils.Clone(this.m_gripperStatus);
            clone.m_settingsStatus = (CRCL_SettingsStatusDataType)Utils.Clone(this.m_settingsStatus);
            clone.m_sensorStatuses = (CRCL_SensorStatusesDataType)Utils.Clone(this.m_sensorStatuses);

            return clone;
        }
        #endregion

        #region Private Fields
        private CRCL_CommandStatusDataType m_commandStatus;
        private CRCL_JointStatusesDataType m_jointStatus;
        private CRCL_PoseStatusDataType m_poseStatus;
        private CRCL_GripperStatusDataType m_gripperStatus;
        private CRCL_SettingsStatusDataType m_settingsStatus;
        private CRCL_SensorStatusesDataType m_sensorStatuses;
        #endregion
    }

    #region CRCLStatusDataTypeCollection Class
    /// <summary>
    /// A collection of CRCLStatusDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCLStatusDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCLStatusDataType")]
    #if !NET_STANDARD
    public partial class CRCLStatusDataTypeCollection : List<CRCLStatusDataType>, ICloneable
    #else
    public partial class CRCLStatusDataTypeCollection : List<CRCLStatusDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCLStatusDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCLStatusDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCLStatusDataTypeCollection(IEnumerable<CRCLStatusDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCLStatusDataTypeCollection(CRCLStatusDataType[] values)
        {
            if (values != null)
            {
                return new CRCLStatusDataTypeCollection(values);
            }

            return new CRCLStatusDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCLStatusDataType[](CRCLStatusDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCLStatusDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLStatusDataTypeCollection clone = new CRCLStatusDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCLStatusDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCLCommandsUnionDataType Class
    #if (!OPCUA_EXCLUDE_CRCLCommandsUnionDataType)
    /// <summary>
    /// CRCLCommandsUnionDataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCLCommandsUnionDataType : Union
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCLCommandsUnionDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_switchField = (uint)0;
            m_initCanonCommand = new InitCanonDataType();
            m_moveToCommand = new MoveToDataType();
            m_closeToolChangerCommand = new CloseToolChangerDataType();
            m_dwellCommand = new DwellDataType();
            m_getStatusCommand = new GetStatusDataType();
            m_messageCommand = new MessageDataType();
            m_endCanonCommand = new EndCanonDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "SwitchField", IsRequired = false, Order = 1)]
        public uint SwitchField
        {
            get { return m_switchField;  }
            set { m_switchField = value; }
        }

        /// <summary>
        /// InitCanonCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "InitCanonCommand", IsRequired = false, Order = 2)]
        public InitCanonDataType InitCanonCommand
        {
            get
            {
                return m_initCanonCommand;
            }

            set
            {
                m_initCanonCommand = value;

                if (value == null)
                {
                    m_initCanonCommand = new InitCanonDataType();
                }
            }
        }

        /// <summary>
        /// MoveToCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "MoveToCommand", IsRequired = false, Order = 3)]
        public MoveToDataType MoveToCommand
        {
            get
            {
                return m_moveToCommand;
            }

            set
            {
                m_moveToCommand = value;

                if (value == null)
                {
                    m_moveToCommand = new MoveToDataType();
                }
            }
        }

        /// <summary>
        /// CloseToolChangerCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "CloseToolChangerCommand", IsRequired = false, Order = 4)]
        public CloseToolChangerDataType CloseToolChangerCommand
        {
            get
            {
                return m_closeToolChangerCommand;
            }

            set
            {
                m_closeToolChangerCommand = value;

                if (value == null)
                {
                    m_closeToolChangerCommand = new CloseToolChangerDataType();
                }
            }
        }

        /// <summary>
        /// DwellCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "DwellCommand", IsRequired = false, Order = 5)]
        public DwellDataType DwellCommand
        {
            get
            {
                return m_dwellCommand;
            }

            set
            {
                m_dwellCommand = value;

                if (value == null)
                {
                    m_dwellCommand = new DwellDataType();
                }
            }
        }

        /// <summary>
        /// GetStatusCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "GetStatusCommand", IsRequired = false, Order = 6)]
        public GetStatusDataType GetStatusCommand
        {
            get
            {
                return m_getStatusCommand;
            }

            set
            {
                m_getStatusCommand = value;

                if (value == null)
                {
                    m_getStatusCommand = new GetStatusDataType();
                }
            }
        }

        /// <summary>
        /// MessageCommand in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "MessageCommand", IsRequired = false, Order = 7)]
        public MessageDataType MessageCommand
        {
            get
            {
                return m_messageCommand;
            }

            set
            {
                m_messageCommand = value;

                if (value == null)
                {
                    m_messageCommand = new MessageDataType();
                }
            }
        }

        /// <summary>
        /// EndCanonDataType in the CRCLCommandsUnionDataType
        /// </summary>
        [DataMember(Name = "EndCanonCommand", IsRequired = false, Order = 8)]
        public EndCanonDataType EndCanonCommand
        {
            get
            {
                return m_endCanonCommand;
            }

            set
            {
                m_endCanonCommand = value;

                if (value == null)
                {
                    m_endCanonCommand = new EndCanonDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCLCommandsUnionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCLCommandsUnionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCLCommandsUnionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteUInt32("SwitchField", SwitchField);
            encoder.WriteEncodeable("InitCanonCommand", InitCanonCommand, typeof(InitCanonDataType));
            encoder.WriteEncodeable("MoveToCommand", MoveToCommand, typeof(MoveToDataType));
            encoder.WriteEncodeable("CloseToolChangerCommand", CloseToolChangerCommand, typeof(CloseToolChangerDataType));
            encoder.WriteEncodeable("DwellCommand", DwellCommand, typeof(DwellDataType));
            encoder.WriteEncodeable("GetStatusCommand", GetStatusCommand, typeof(GetStatusDataType));
            encoder.WriteEncodeable("MessageCommand", MessageCommand, typeof(MessageDataType));
            encoder.WriteEncodeable("EndCanonCommand", EndCanonCommand, typeof(EndCanonDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            SwitchField = decoder.ReadUInt32("SwitchField");
            InitCanonCommand = (InitCanonDataType)decoder.ReadEncodeable("InitCanonCommand", typeof(InitCanonDataType));
            MoveToCommand = (MoveToDataType)decoder.ReadEncodeable("MoveToCommand", typeof(MoveToDataType));
            CloseToolChangerCommand = (CloseToolChangerDataType)decoder.ReadEncodeable("CloseToolChangerCommand", typeof(CloseToolChangerDataType));
            DwellCommand = (DwellDataType)decoder.ReadEncodeable("DwellCommand", typeof(DwellDataType));
            GetStatusCommand = (GetStatusDataType)decoder.ReadEncodeable("GetStatusCommand", typeof(GetStatusDataType));
            MessageCommand = (MessageDataType)decoder.ReadEncodeable("MessageCommand", typeof(MessageDataType));
            EndCanonCommand = (EndCanonDataType)decoder.ReadEncodeable("EndCanonCommand", typeof(EndCanonDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCLCommandsUnionDataType value = encodeable as CRCLCommandsUnionDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_switchField, value.m_switchField)) return false;
            if (!Utils.IsEqual(m_initCanonCommand, value.m_initCanonCommand)) return false;
            if (!Utils.IsEqual(m_moveToCommand, value.m_moveToCommand)) return false;
            if (!Utils.IsEqual(m_closeToolChangerCommand, value.m_closeToolChangerCommand)) return false;
            if (!Utils.IsEqual(m_dwellCommand, value.m_dwellCommand)) return false;
            if (!Utils.IsEqual(m_getStatusCommand, value.m_getStatusCommand)) return false;
            if (!Utils.IsEqual(m_messageCommand, value.m_messageCommand)) return false;
            if (!Utils.IsEqual(m_endCanonCommand, value.m_endCanonCommand)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCLCommandsUnionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLCommandsUnionDataType clone = (CRCLCommandsUnionDataType)base.MemberwiseClone();

            clone.m_switchField = (uint)Utils.Clone(this.m_switchField);
            clone.m_initCanonCommand = (InitCanonDataType)Utils.Clone(this.m_initCanonCommand);
            clone.m_moveToCommand = (MoveToDataType)Utils.Clone(this.m_moveToCommand);
            clone.m_closeToolChangerCommand = (CloseToolChangerDataType)Utils.Clone(this.m_closeToolChangerCommand);
            clone.m_dwellCommand = (DwellDataType)Utils.Clone(this.m_dwellCommand);
            clone.m_getStatusCommand = (GetStatusDataType)Utils.Clone(this.m_getStatusCommand);
            clone.m_messageCommand = (MessageDataType)Utils.Clone(this.m_messageCommand);
            clone.m_endCanonCommand = (EndCanonDataType)Utils.Clone(this.m_endCanonCommand);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_switchField;
        private InitCanonDataType m_initCanonCommand;
        private MoveToDataType m_moveToCommand;
        private CloseToolChangerDataType m_closeToolChangerCommand;
        private DwellDataType m_dwellCommand;
        private GetStatusDataType m_getStatusCommand;
        private MessageDataType m_messageCommand;
        private EndCanonDataType m_endCanonCommand;
        #endregion
    }

    #region CRCLCommandsUnionDataTypeCollection Class
    /// <summary>
    /// A collection of CRCLCommandsUnionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCLCommandsUnionDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCLCommandsUnionDataType")]
    #if !NET_STANDARD
    public partial class CRCLCommandsUnionDataTypeCollection : List<CRCLCommandsUnionDataType>, ICloneable
    #else
    public partial class CRCLCommandsUnionDataTypeCollection : List<CRCLCommandsUnionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCLCommandsUnionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCLCommandsUnionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCLCommandsUnionDataTypeCollection(IEnumerable<CRCLCommandsUnionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCLCommandsUnionDataTypeCollection(CRCLCommandsUnionDataType[] values)
        {
            if (values != null)
            {
                return new CRCLCommandsUnionDataTypeCollection(values);
            }

            return new CRCLCommandsUnionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCLCommandsUnionDataType[](CRCLCommandsUnionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCLCommandsUnionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCLCommandsUnionDataTypeCollection clone = new CRCLCommandsUnionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCLCommandsUnionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_StopConditionEnumDataType Enumeration
    #if (!OPCUA_EXCLUDE_CRCL_StopConditionEnumDataType)
    /// <summary>
    /// 
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public enum CRCL_StopConditionEnumDataType
    {
        /// <remarks />
        [EnumMember(Value = "IMMEDIATE_0")]
        IMMEDIATE = 0,

        /// <remarks />
        [EnumMember(Value = "FAST_1")]
        FAST = 1,

        /// <remarks />
        [EnumMember(Value = "NORMAL_2")]
        NORMAL = 2,
    }

    #region CRCL_StopConditionEnumDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_StopConditionEnumDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_StopConditionEnumDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_StopConditionEnumDataType")]
    #if !NET_STANDARD
    public partial class CRCL_StopConditionEnumDataTypeCollection : List<CRCL_StopConditionEnumDataType>, ICloneable
    #else
    public partial class CRCL_StopConditionEnumDataTypeCollection : List<CRCL_StopConditionEnumDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_StopConditionEnumDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_StopConditionEnumDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_StopConditionEnumDataTypeCollection(IEnumerable<CRCL_StopConditionEnumDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_StopConditionEnumDataTypeCollection(CRCL_StopConditionEnumDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_StopConditionEnumDataTypeCollection(values);
            }

            return new CRCL_StopConditionEnumDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_StopConditionEnumDataType[](CRCL_StopConditionEnumDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_StopConditionEnumDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_StopConditionEnumDataTypeCollection clone = new CRCL_StopConditionEnumDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_StopConditionEnumDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CRCL_ConfigureJointReportDataType Class
    #if (!OPCUA_EXCLUDE_CRCL_ConfigureJointReportDataType)
    /// <summary>
    /// CRCL ConfigureJointReportDataType
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = CRCL.Namespaces.CRCL)]
    public partial class CRCL_ConfigureJointReportDataType : CRCL_DataThingDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CRCL_ConfigureJointReportDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_jointNumber = (int)0;
            m_reportPosition = true;
            m_reportTorqueOrForce = true;
            m_reportVelocity = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "JointNumber", IsRequired = false, Order = 1)]
        public int JointNumber
        {
            get { return m_jointNumber;  }
            set { m_jointNumber = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportPosition", IsRequired = false, Order = 2)]
        public bool ReportPosition
        {
            get { return m_reportPosition;  }
            set { m_reportPosition = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportTorqueOrForce", IsRequired = false, Order = 3)]
        public bool ReportTorqueOrForce
        {
            get { return m_reportTorqueOrForce;  }
            set { m_reportTorqueOrForce = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReportVelocity", IsRequired = false, Order = 4)]
        public bool ReportVelocity
        {
            get { return m_reportVelocity;  }
            set { m_reportVelocity = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CRCL_ConfigureJointReportDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CRCL_ConfigureJointReportDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CRCL_ConfigureJointReportDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(CRCL.Namespaces.CRCL);

            encoder.WriteInt32("JointNumber", JointNumber);
            encoder.WriteBoolean("ReportPosition", ReportPosition);
            encoder.WriteBoolean("ReportTorqueOrForce", ReportTorqueOrForce);
            encoder.WriteBoolean("ReportVelocity", ReportVelocity);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(CRCL.Namespaces.CRCL);

            JointNumber = decoder.ReadInt32("JointNumber");
            ReportPosition = decoder.ReadBoolean("ReportPosition");
            ReportTorqueOrForce = decoder.ReadBoolean("ReportTorqueOrForce");
            ReportVelocity = decoder.ReadBoolean("ReportVelocity");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CRCL_ConfigureJointReportDataType value = encodeable as CRCL_ConfigureJointReportDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_jointNumber, value.m_jointNumber)) return false;
            if (!Utils.IsEqual(m_reportPosition, value.m_reportPosition)) return false;
            if (!Utils.IsEqual(m_reportTorqueOrForce, value.m_reportTorqueOrForce)) return false;
            if (!Utils.IsEqual(m_reportVelocity, value.m_reportVelocity)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (CRCL_ConfigureJointReportDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ConfigureJointReportDataType clone = (CRCL_ConfigureJointReportDataType)base.MemberwiseClone();

            clone.m_jointNumber = (int)Utils.Clone(this.m_jointNumber);
            clone.m_reportPosition = (bool)Utils.Clone(this.m_reportPosition);
            clone.m_reportTorqueOrForce = (bool)Utils.Clone(this.m_reportTorqueOrForce);
            clone.m_reportVelocity = (bool)Utils.Clone(this.m_reportVelocity);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_jointNumber;
        private bool m_reportPosition;
        private bool m_reportTorqueOrForce;
        private bool m_reportVelocity;
        #endregion
    }

    #region CRCL_ConfigureJointReportDataTypeCollection Class
    /// <summary>
    /// A collection of CRCL_ConfigureJointReportDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCRCL_ConfigureJointReportDataType", Namespace = CRCL.Namespaces.CRCL, ItemName = "CRCL_ConfigureJointReportDataType")]
    #if !NET_STANDARD
    public partial class CRCL_ConfigureJointReportDataTypeCollection : List<CRCL_ConfigureJointReportDataType>, ICloneable
    #else
    public partial class CRCL_ConfigureJointReportDataTypeCollection : List<CRCL_ConfigureJointReportDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CRCL_ConfigureJointReportDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CRCL_ConfigureJointReportDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CRCL_ConfigureJointReportDataTypeCollection(IEnumerable<CRCL_ConfigureJointReportDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CRCL_ConfigureJointReportDataTypeCollection(CRCL_ConfigureJointReportDataType[] values)
        {
            if (values != null)
            {
                return new CRCL_ConfigureJointReportDataTypeCollection(values);
            }

            return new CRCL_ConfigureJointReportDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CRCL_ConfigureJointReportDataType[](CRCL_ConfigureJointReportDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CRCL_ConfigureJointReportDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CRCL_ConfigureJointReportDataTypeCollection clone = new CRCL_ConfigureJointReportDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CRCL_ConfigureJointReportDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}