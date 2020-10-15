using Interfaces;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Model
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassName1 : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _displayName;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(255)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(255)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassName2 : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _displayName;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(255)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(255)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassName3 : INotifyPropertyChanged, IInterfaceA, IInterfaceB
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _name;

        private ReplacedClassName1 _documentType;

        private DateTime? _validUntil;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(512)]
        public string Name
        {
            get => _name;
            set 
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        public ReplacedClassName1 DocumentType
        {
            get => _documentType;
            set 
            {
                if (_documentType != value)
                {
                    var ioid = _documentType as IInterfaceA;
                    if (ioid == null || ioid.InterfaceAPropertyA != (value as IInterfaceA)?.InterfaceAPropertyA) 
                    {
                        _documentType = value;
                        OnPropertyChanged();
                    }
                    else 
                    {
                        _documentType = value;
                    }
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        public DateTime? ValidUntil
        {
            get => _validUntil;
            set 
            {
                if (_validUntil != value)
                {
                    _validUntil = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameA : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _displayName;

        private int? _rating;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(20)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(40)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public int? Rating
        {
            get => _rating;
            set 
            {
                if (_rating != value)
                {
                    _rating = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameB : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _parentDisplayName;

        private string _childDisplayName;

        private bool? _isParentOwner;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(20)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string ParentDisplayName
        {
            get => _parentDisplayName;
            set 
            {
                if (_parentDisplayName != value)
                {
                    _parentDisplayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string ChildDisplayName
        {
            get => _childDisplayName;
            set 
            {
                if (_childDisplayName != value)
                {
                    _childDisplayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        public bool? IsParentOwner
        {
            get => _isParentOwner;
            set 
            {
                if (_isParentOwner != value)
                {
                    _isParentOwner = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameC : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _displayName;

        private bool? _isPerson;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        public bool? IsPerson
        {
            get => _isPerson;
            set 
            {
                if (_isPerson != value)
                {
                    _isPerson = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameE : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private string _iSOCode;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [MaxLength(2)]
        public string ISOCode
        {
            get => _iSOCode;
            set 
            {
                if (_iSOCode != value)
                {
                    _iSOCode = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameF : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _approved;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public bool? Approved
        {
            get => _approved;
            set 
            {
                if (_approved != value)
                {
                    _approved = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameG : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _approved;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public bool? Approved
        {
            get => _approved;
            set 
            {
                if (_approved != value)
                {
                    _approved = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameH : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private int? _riskScore;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        public int? RiskScore
        {
            get => _riskScore;
            set 
            {
                if (_riskScore != value)
                {
                    _riskScore = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameI : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private string _iSOCode;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [MaxLength(3)]
        public string ISOCode
        {
            get => _iSOCode;
            set 
            {
                if (_iSOCode != value)
                {
                    _iSOCode = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameJ : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameK : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameL : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameM : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameN : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameO : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameP : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameQ : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameR : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameS : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _code;

        private string _displayName;

        private string _section;

        private decimal? _division;

        private decimal? _group;

        private decimal? _class;

        private decimal? _subClass;

        private ReplacedClassNameS _parent;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [MaxLength(5)]
        public string Code
        {
            get => _code;
            set 
            {
                if (_code != value)
                {
                    _code = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(200)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [MaxLength(1)]
        public string Section
        {
            get => _section;
            set 
            {
                if (_section != value)
                {
                    _section = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public decimal? Division
        {
            get => _division;
            set 
            {
                if (_division != value)
                {
                    _division = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public decimal? Group
        {
            get => _group;
            set 
            {
                if (_group != value)
                {
                    _group = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public decimal? Class
        {
            get => _class;
            set 
            {
                if (_class != value)
                {
                    _class = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public decimal? SubClass
        {
            get => _subClass;
            set 
            {
                if (_subClass != value)
                {
                    _subClass = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public ReplacedClassNameS Parent
        {
            get => _parent;
            set 
            {
                if (_parent != value)
                {
                    var ioid = _parent as IInterfaceA;
                    if (ioid == null || ioid.InterfaceAPropertyA != (value as IInterfaceA)?.InterfaceAPropertyA) 
                    {
                        _parent = value;
                        OnPropertyChanged();
                    }
                    else 
                    {
                        _parent = value;
                    }
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameT : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private int? _riskScore;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(300)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        public int? RiskScore
        {
            get => _riskScore;
            set 
            {
                if (_riskScore != value)
                {
                    _riskScore = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameU : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameV : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameW : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private ReplacedClassNameC _legalForm;

        private ObservableCollection<ReplacedClassNameX> _entityTypes;

        public ReplacedClassNameW()
        {
            _entityTypes = new ObservableCollection<ReplacedClassNameX>();
        }


        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        public ReplacedClassNameC LegalForm
        {
            get => _legalForm;
            set 
            {
                if (_legalForm != value)
                {
                    var ioid = _legalForm as IInterfaceA;
                    if (ioid == null || ioid.InterfaceAPropertyA != (value as IInterfaceA)?.InterfaceAPropertyA) 
                    {
                        _legalForm = value;
                        OnPropertyChanged();
                    }
                    else 
                    {
                        _legalForm = value;
                    }
                }
            }
        }

        [XmlElement("EntityTypes")]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        public ObservableCollection<ReplacedClassNameX> EntityTypes
        {
            get => _entityTypes;
            set 
            {
                if (_entityTypes != value)
                {
                    _entityTypes = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameX : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameY : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameZ : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAA : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAB : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAC : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAF : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAG : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAH : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private ReplacedClassNameE _country;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        public ReplacedClassNameE Country
        {
            get => _country;
            set 
            {
                if (_country != value)
                {
                    var ioid = _country as IInterfaceA;
                    if (ioid == null || ioid.InterfaceAPropertyA != (value as IInterfaceA)?.InterfaceAPropertyA) 
                    {
                        _country = value;
                        OnPropertyChanged();
                    }
                    else 
                    {
                        _country = value;
                    }
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAI : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(200)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAJ : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAK : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAL : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(200)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAM : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAN : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAO : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private ReplacedClassNameAN _fSCSEligibleType;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        public ReplacedClassNameAN FSCSEligibleType
        {
            get => _fSCSEligibleType;
            set 
            {
                if (_fSCSEligibleType != value)
                {
                    var ioid = _fSCSEligibleType as IInterfaceA;
                    if (ioid == null || ioid.InterfaceAPropertyA != (value as IInterfaceA)?.InterfaceAPropertyA) 
                    {
                        _fSCSEligibleType = value;
                        OnPropertyChanged();
                    }
                    else 
                    {
                        _fSCSEligibleType = value;
                    }
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAP : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(100)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAQ : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAR : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAS : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAT : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAU : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _id;

        private string _displayName;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string Id
        {
            get => _id;
            set 
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAV : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _iD;

        private string _displayName;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(10)]
        public string ID
        {
            get => _iD;
            set 
            {
                if (_iD != value)
                {
                    _iD = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(50)]
        public string DisplayName
        {
            get => _displayName;
            set 
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "Model")]
    [XmlRoot(Namespace = "Model", IsNullable = false)]
    [DataContract]
        [Description("____replaced                                                                                                ____")]
        [DisplayName("____replaced____")]
    [DisplayProperty("____replaced____", "", null)]
    public partial class ReplacedClassNameAW : INotifyPropertyChanged, IInterfaceA, IInterfaceC
    {

        [XmlAttribute] [DataMember(EmitDefaultValue=false)] public Guid InterfaceAPropertyA { get; set; }

        private string _ruleId;

        private bool? _active;

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [DisplayName("____replaced____")]
        [Description("____replaced                                                                                                ____")]
        [MaxLength(128)]
        public string RuleId
        {
            get => _ruleId;
            set 
            {
                if (_ruleId != value)
                {
                    _ruleId = value;
                    OnPropertyChanged();
                }
            }
        }

        [XmlElement(IsNullable=true)]
        [DataMember(EmitDefaultValue=false)]
        [Description("____replaced                                                                                                ____")]
        public bool? Active
        {
            get => _active;
            set 
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
