﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("WIADBModel", "FK_Students_Schools", "Schools", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WIASchool.School), "Students", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WIASchool.Student), true)]
[assembly: EdmRelationshipAttribute("WIADBModel", "School_has_Courses", "Courses", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WIASchool.Cours), "Schools", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WIASchool.School))]

#endregion

namespace WIASchool
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WIADBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WIADBEntities object using the connection string found in the 'WIADBEntities' section of the application configuration file.
        /// </summary>
        public WIADBEntities() : base("name=WIADBEntities", "WIADBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WIADBEntities object.
        /// </summary>
        public WIADBEntities(string connectionString) : base(connectionString, "WIADBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WIADBEntities object.
        /// </summary>
        public WIADBEntities(EntityConnection connection) : base(connection, "WIADBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cours> Courses
        {
            get
            {
                if ((_Courses == null))
                {
                    _Courses = base.CreateObjectSet<Cours>("Courses");
                }
                return _Courses;
            }
        }
        private ObjectSet<Cours> _Courses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<School> Schools
        {
            get
            {
                if ((_Schools == null))
                {
                    _Schools = base.CreateObjectSet<School>("Schools");
                }
                return _Schools;
            }
        }
        private ObjectSet<School> _Schools;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Cours cours)
        {
            base.AddObject("Courses", cours);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Schools EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSchools(School school)
        {
            base.AddObject("Schools", school);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WIADBModel", Name="Cours")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cours : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cours object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Cours CreateCours(global::System.Int32 id)
        {
            Cours cours = new Cours();
            cours.Id = id;
            return cours;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Created
        {
            get
            {
                return _Created;
            }
            set
            {
                OnCreatedChanging(value);
                ReportPropertyChanging("Created");
                _Created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Created");
                OnCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Updated
        {
            get
            {
                return _Updated;
            }
            set
            {
                OnUpdatedChanging(value);
                ReportPropertyChanging("Updated");
                _Updated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Updated");
                OnUpdatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Updated;
        partial void OnUpdatedChanging(Nullable<global::System.DateTime> value);
        partial void OnUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Allowed
        {
            get
            {
                return _Allowed;
            }
            set
            {
                OnAllowedChanging(value);
                ReportPropertyChanging("Allowed");
                _Allowed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Allowed");
                OnAllowedChanged();
            }
        }
        private Nullable<global::System.Boolean> _Allowed;
        partial void OnAllowedChanging(Nullable<global::System.Boolean> value);
        partial void OnAllowedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WIADBModel", "School_has_Courses", "Schools")]
        public EntityCollection<School> Schools
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<School>("WIADBModel.School_has_Courses", "Schools");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<School>("WIADBModel.School_has_Courses", "Schools", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WIADBModel", Name="School")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class School : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new School object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static School CreateSchool(global::System.Int32 id)
        {
            School school = new School();
            school.Id = id;
            return school;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                OnAddress2Changing(value);
                ReportPropertyChanging("Address2");
                _Address2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address2");
                OnAddress2Changed();
            }
        }
        private global::System.String _Address2;
        partial void OnAddress2Changing(global::System.String value);
        partial void OnAddress2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Created
        {
            get
            {
                return _Created;
            }
            set
            {
                OnCreatedChanging(value);
                ReportPropertyChanging("Created");
                _Created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Created");
                OnCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Updated
        {
            get
            {
                return _Updated;
            }
            set
            {
                OnUpdatedChanging(value);
                ReportPropertyChanging("Updated");
                _Updated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Updated");
                OnUpdatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Updated;
        partial void OnUpdatedChanging(Nullable<global::System.DateTime> value);
        partial void OnUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Allowed
        {
            get
            {
                return _Allowed;
            }
            set
            {
                OnAllowedChanging(value);
                ReportPropertyChanging("Allowed");
                _Allowed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Allowed");
                OnAllowedChanged();
            }
        }
        private Nullable<global::System.Boolean> _Allowed;
        partial void OnAllowedChanging(Nullable<global::System.Boolean> value);
        partial void OnAllowedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WIADBModel", "FK_Students_Schools", "Students")]
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("WIADBModel.FK_Students_Schools", "Students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("WIADBModel.FK_Students_Schools", "Students", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WIADBModel", "School_has_Courses", "Courses")]
        public EntityCollection<Cours> Courses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Cours>("WIADBModel.School_has_Courses", "Courses");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Cours>("WIADBModel.School_has_Courses", "Courses", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WIADBModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Student CreateStudent(global::System.Int32 id)
        {
            Student student = new Student();
            student.Id = id;
            return student;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Created
        {
            get
            {
                return _Created;
            }
            set
            {
                OnCreatedChanging(value);
                ReportPropertyChanging("Created");
                _Created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Created");
                OnCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Created;
        partial void OnCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Updated
        {
            get
            {
                return _Updated;
            }
            set
            {
                OnUpdatedChanging(value);
                ReportPropertyChanging("Updated");
                _Updated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Updated");
                OnUpdatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Updated;
        partial void OnUpdatedChanging(Nullable<global::System.DateTime> value);
        partial void OnUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SchoolId
        {
            get
            {
                return _SchoolId;
            }
            set
            {
                OnSchoolIdChanging(value);
                ReportPropertyChanging("SchoolId");
                _SchoolId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SchoolId");
                OnSchoolIdChanged();
            }
        }
        private Nullable<global::System.Int32> _SchoolId;
        partial void OnSchoolIdChanging(Nullable<global::System.Int32> value);
        partial void OnSchoolIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Allowed
        {
            get
            {
                return _Allowed;
            }
            set
            {
                OnAllowedChanging(value);
                ReportPropertyChanging("Allowed");
                _Allowed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Allowed");
                OnAllowedChanged();
            }
        }
        private Nullable<global::System.Boolean> _Allowed;
        partial void OnAllowedChanging(Nullable<global::System.Boolean> value);
        partial void OnAllowedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WIADBModel", "FK_Students_Schools", "Schools")]
        public School School
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<School>("WIADBModel.FK_Students_Schools", "Schools").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<School>("WIADBModel.FK_Students_Schools", "Schools").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<School> SchoolReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<School>("WIADBModel.FK_Students_Schools", "Schools");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<School>("WIADBModel.FK_Students_Schools", "Schools", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
