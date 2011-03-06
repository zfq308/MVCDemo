﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MvcDemoApp.DataService
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeeEntities object using the connection string found in the 'EmployeeEntities' section of the application configuration file.
        /// </summary>
        public EmployeeEntities() : base("name=EmployeeEntities", "EmployeeEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeEntities object.
        /// </summary>
        public EmployeeEntities(string connectionString) : base(connectionString, "EmployeeEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeEntities object.
        /// </summary>
        public EmployeeEntities(EntityConnection connection) : base(connection, "EmployeeEntities")
        {
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
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Dependent> Dependents
        {
            get
            {
                if ((_Dependents == null))
                {
                    _Dependents = base.CreateObjectSet<Dependent>("Dependents");
                }
                return _Dependents;
            }
        }
        private ObjectSet<Dependent> _Dependents;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Dept_Locations> Dept_Locations
        {
            get
            {
                if ((_Dept_Locations == null))
                {
                    _Dept_Locations = base.CreateObjectSet<Dept_Locations>("Dept_Locations");
                }
                return _Dept_Locations;
            }
        }
        private ObjectSet<Dept_Locations> _Dept_Locations;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Project> Projects
        {
            get
            {
                if ((_Projects == null))
                {
                    _Projects = base.CreateObjectSet<Project>("Projects");
                }
                return _Projects;
            }
        }
        private ObjectSet<Project> _Projects;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Works_On> Works_On
        {
            get
            {
                if ((_Works_On == null))
                {
                    _Works_On = base.CreateObjectSet<Works_On>("Works_On");
                }
                return _Works_On;
            }
        }
        private ObjectSet<Works_On> _Works_On;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Dependents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDependents(Dependent dependent)
        {
            base.AddObject("Dependents", dependent);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Dept_Locations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDept_Locations(Dept_Locations dept_Locations)
        {
            base.AddObject("Dept_Locations", dept_Locations);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Projects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProjects(Project project)
        {
            base.AddObject("Projects", project);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Works_On EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWorks_On(Works_On works_On)
        {
            base.AddObject("Works_On", works_On);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="dname">Initial value of the Dname property.</param>
        /// <param name="dNumber">Initial value of the DNumber property.</param>
        /// <param name="mgrSsn">Initial value of the MgrSsn property.</param>
        public static Department CreateDepartment(global::System.String dname, global::System.Int32 dNumber, global::System.String mgrSsn)
        {
            Department department = new Department();
            department.Dname = dname;
            department.DNumber = dNumber;
            department.MgrSsn = mgrSsn;
            return department;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Dname
        {
            get
            {
                return _Dname;
            }
            set
            {
                OnDnameChanging(value);
                ReportPropertyChanging("Dname");
                _Dname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Dname");
                OnDnameChanged();
            }
        }
        private global::System.String _Dname;
        partial void OnDnameChanging(global::System.String value);
        partial void OnDnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DNumber
        {
            get
            {
                return _DNumber;
            }
            set
            {
                if (_DNumber != value)
                {
                    OnDNumberChanging(value);
                    ReportPropertyChanging("DNumber");
                    _DNumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DNumber");
                    OnDNumberChanged();
                }
            }
        }
        private global::System.Int32 _DNumber;
        partial void OnDNumberChanging(global::System.Int32 value);
        partial void OnDNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MgrSsn
        {
            get
            {
                return _MgrSsn;
            }
            set
            {
                OnMgrSsnChanging(value);
                ReportPropertyChanging("MgrSsn");
                _MgrSsn = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MgrSsn");
                OnMgrSsnChanged();
            }
        }
        private global::System.String _MgrSsn;
        partial void OnMgrSsnChanging(global::System.String value);
        partial void OnMgrSsnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> MgrStartDate
        {
            get
            {
                return _MgrStartDate;
            }
            set
            {
                OnMgrStartDateChanging(value);
                ReportPropertyChanging("MgrStartDate");
                _MgrStartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MgrStartDate");
                OnMgrStartDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _MgrStartDate;
        partial void OnMgrStartDateChanging(Nullable<global::System.DateTime> value);
        partial void OnMgrStartDateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Dependent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dependent : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Dependent object.
        /// </summary>
        /// <param name="essn">Initial value of the Essn property.</param>
        /// <param name="dependent_name">Initial value of the Dependent_name property.</param>
        public static Dependent CreateDependent(global::System.String essn, global::System.String dependent_name)
        {
            Dependent dependent = new Dependent();
            dependent.Essn = essn;
            dependent.Dependent_name = dependent_name;
            return dependent;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Essn
        {
            get
            {
                return _Essn;
            }
            set
            {
                if (_Essn != value)
                {
                    OnEssnChanging(value);
                    ReportPropertyChanging("Essn");
                    _Essn = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Essn");
                    OnEssnChanged();
                }
            }
        }
        private global::System.String _Essn;
        partial void OnEssnChanging(global::System.String value);
        partial void OnEssnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Dependent_name
        {
            get
            {
                return _Dependent_name;
            }
            set
            {
                if (_Dependent_name != value)
                {
                    OnDependent_nameChanging(value);
                    ReportPropertyChanging("Dependent_name");
                    _Dependent_name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Dependent_name");
                    OnDependent_nameChanged();
                }
            }
        }
        private global::System.String _Dependent_name;
        partial void OnDependent_nameChanging(global::System.String value);
        partial void OnDependent_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                OnSexChanging(value);
                ReportPropertyChanging("Sex");
                _Sex = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Sex");
                OnSexChanged();
            }
        }
        private global::System.String _Sex;
        partial void OnSexChanging(global::System.String value);
        partial void OnSexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Bdate
        {
            get
            {
                return _Bdate;
            }
            set
            {
                OnBdateChanging(value);
                ReportPropertyChanging("Bdate");
                _Bdate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Bdate");
                OnBdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _Bdate;
        partial void OnBdateChanging(Nullable<global::System.DateTime> value);
        partial void OnBdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Relationship
        {
            get
            {
                return _Relationship;
            }
            set
            {
                OnRelationshipChanging(value);
                ReportPropertyChanging("Relationship");
                _Relationship = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Relationship");
                OnRelationshipChanged();
            }
        }
        private global::System.String _Relationship;
        partial void OnRelationshipChanging(global::System.String value);
        partial void OnRelationshipChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Dept_Locations")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dept_Locations : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Dept_Locations object.
        /// </summary>
        /// <param name="dnumber">Initial value of the Dnumber property.</param>
        /// <param name="dlocation">Initial value of the Dlocation property.</param>
        public static Dept_Locations CreateDept_Locations(global::System.Int32 dnumber, global::System.String dlocation)
        {
            Dept_Locations dept_Locations = new Dept_Locations();
            dept_Locations.Dnumber = dnumber;
            dept_Locations.Dlocation = dlocation;
            return dept_Locations;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Dnumber
        {
            get
            {
                return _Dnumber;
            }
            set
            {
                if (_Dnumber != value)
                {
                    OnDnumberChanging(value);
                    ReportPropertyChanging("Dnumber");
                    _Dnumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Dnumber");
                    OnDnumberChanged();
                }
            }
        }
        private global::System.Int32 _Dnumber;
        partial void OnDnumberChanging(global::System.Int32 value);
        partial void OnDnumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Dlocation
        {
            get
            {
                return _Dlocation;
            }
            set
            {
                if (_Dlocation != value)
                {
                    OnDlocationChanging(value);
                    ReportPropertyChanging("Dlocation");
                    _Dlocation = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Dlocation");
                    OnDlocationChanged();
                }
            }
        }
        private global::System.String _Dlocation;
        partial void OnDlocationChanging(global::System.String value);
        partial void OnDlocationChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="fname">Initial value of the Fname property.</param>
        /// <param name="lname">Initial value of the Lname property.</param>
        /// <param name="ssn">Initial value of the Ssn property.</param>
        /// <param name="dno">Initial value of the Dno property.</param>
        public static Employee CreateEmployee(global::System.String fname, global::System.String lname, global::System.String ssn, global::System.Int32 dno)
        {
            Employee employee = new Employee();
            employee.Fname = fname;
            employee.Lname = lname;
            employee.Ssn = ssn;
            employee.Dno = dno;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                OnFnameChanging(value);
                ReportPropertyChanging("Fname");
                _Fname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Fname");
                OnFnameChanged();
            }
        }
        private global::System.String _Fname;
        partial void OnFnameChanging(global::System.String value);
        partial void OnFnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Minit
        {
            get
            {
                return _Minit;
            }
            set
            {
                OnMinitChanging(value);
                ReportPropertyChanging("Minit");
                _Minit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Minit");
                OnMinitChanged();
            }
        }
        private global::System.String _Minit;
        partial void OnMinitChanging(global::System.String value);
        partial void OnMinitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Lname
        {
            get
            {
                return _Lname;
            }
            set
            {
                OnLnameChanging(value);
                ReportPropertyChanging("Lname");
                _Lname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Lname");
                OnLnameChanged();
            }
        }
        private global::System.String _Lname;
        partial void OnLnameChanging(global::System.String value);
        partial void OnLnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ssn
        {
            get
            {
                return _Ssn;
            }
            set
            {
                if (_Ssn != value)
                {
                    OnSsnChanging(value);
                    ReportPropertyChanging("Ssn");
                    _Ssn = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Ssn");
                    OnSsnChanged();
                }
            }
        }
        private global::System.String _Ssn;
        partial void OnSsnChanging(global::System.String value);
        partial void OnSsnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Bdate
        {
            get
            {
                return _Bdate;
            }
            set
            {
                OnBdateChanging(value);
                ReportPropertyChanging("Bdate");
                _Bdate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Bdate");
                OnBdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _Bdate;
        partial void OnBdateChanging(Nullable<global::System.DateTime> value);
        partial void OnBdateChanged();
    
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
        public global::System.String Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                OnSexChanging(value);
                ReportPropertyChanging("Sex");
                _Sex = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Sex");
                OnSexChanged();
            }
        }
        private global::System.String _Sex;
        partial void OnSexChanging(global::System.String value);
        partial void OnSexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private Nullable<global::System.Int32> _Salary;
        partial void OnSalaryChanging(Nullable<global::System.Int32> value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Super_ssn
        {
            get
            {
                return _Super_ssn;
            }
            set
            {
                OnSuper_ssnChanging(value);
                ReportPropertyChanging("Super_ssn");
                _Super_ssn = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Super_ssn");
                OnSuper_ssnChanged();
            }
        }
        private global::System.String _Super_ssn;
        partial void OnSuper_ssnChanging(global::System.String value);
        partial void OnSuper_ssnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Dno
        {
            get
            {
                return _Dno;
            }
            set
            {
                OnDnoChanging(value);
                ReportPropertyChanging("Dno");
                _Dno = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Dno");
                OnDnoChanged();
            }
        }
        private global::System.Int32 _Dno;
        partial void OnDnoChanging(global::System.Int32 value);
        partial void OnDnoChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Project")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Project : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Project object.
        /// </summary>
        /// <param name="pname">Initial value of the Pname property.</param>
        /// <param name="pnumber">Initial value of the Pnumber property.</param>
        /// <param name="dnum">Initial value of the Dnum property.</param>
        public static Project CreateProject(global::System.String pname, global::System.Int32 pnumber, global::System.Int32 dnum)
        {
            Project project = new Project();
            project.Pname = pname;
            project.Pnumber = pnumber;
            project.Dnum = dnum;
            return project;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Pname
        {
            get
            {
                return _Pname;
            }
            set
            {
                OnPnameChanging(value);
                ReportPropertyChanging("Pname");
                _Pname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Pname");
                OnPnameChanged();
            }
        }
        private global::System.String _Pname;
        partial void OnPnameChanging(global::System.String value);
        partial void OnPnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Pnumber
        {
            get
            {
                return _Pnumber;
            }
            set
            {
                if (_Pnumber != value)
                {
                    OnPnumberChanging(value);
                    ReportPropertyChanging("Pnumber");
                    _Pnumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Pnumber");
                    OnPnumberChanged();
                }
            }
        }
        private global::System.Int32 _Pnumber;
        partial void OnPnumberChanging(global::System.Int32 value);
        partial void OnPnumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Plocation
        {
            get
            {
                return _Plocation;
            }
            set
            {
                OnPlocationChanging(value);
                ReportPropertyChanging("Plocation");
                _Plocation = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Plocation");
                OnPlocationChanged();
            }
        }
        private global::System.String _Plocation;
        partial void OnPlocationChanging(global::System.String value);
        partial void OnPlocationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Dnum
        {
            get
            {
                return _Dnum;
            }
            set
            {
                OnDnumChanging(value);
                ReportPropertyChanging("Dnum");
                _Dnum = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Dnum");
                OnDnumChanged();
            }
        }
        private global::System.Int32 _Dnum;
        partial void OnDnumChanging(global::System.Int32 value);
        partial void OnDnumChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Works_On")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Works_On : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Works_On object.
        /// </summary>
        /// <param name="essn">Initial value of the Essn property.</param>
        /// <param name="pno">Initial value of the Pno property.</param>
        public static Works_On CreateWorks_On(global::System.String essn, global::System.Int32 pno)
        {
            Works_On works_On = new Works_On();
            works_On.Essn = essn;
            works_On.Pno = pno;
            return works_On;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Essn
        {
            get
            {
                return _Essn;
            }
            set
            {
                if (_Essn != value)
                {
                    OnEssnChanging(value);
                    ReportPropertyChanging("Essn");
                    _Essn = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Essn");
                    OnEssnChanged();
                }
            }
        }
        private global::System.String _Essn;
        partial void OnEssnChanging(global::System.String value);
        partial void OnEssnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Pno
        {
            get
            {
                return _Pno;
            }
            set
            {
                if (_Pno != value)
                {
                    OnPnoChanging(value);
                    ReportPropertyChanging("Pno");
                    _Pno = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Pno");
                    OnPnoChanged();
                }
            }
        }
        private global::System.Int32 _Pno;
        partial void OnPnoChanging(global::System.Int32 value);
        partial void OnPnoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Hours
        {
            get
            {
                return _Hours;
            }
            set
            {
                OnHoursChanging(value);
                ReportPropertyChanging("Hours");
                _Hours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Hours");
                OnHoursChanged();
            }
        }
        private Nullable<global::System.Int32> _Hours;
        partial void OnHoursChanging(Nullable<global::System.Int32> value);
        partial void OnHoursChanged();

        #endregion
    
    }

    #endregion
    
}
