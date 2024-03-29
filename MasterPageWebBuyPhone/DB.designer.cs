﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPageWebBuyPhone
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebBuyPhone")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccountEmp(AccountEmp instance);
    partial void UpdateAccountEmp(AccountEmp instance);
    partial void DeleteAccountEmp(AccountEmp instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertManufacturer(Manufacturer instance);
    partial void UpdateManufacturer(Manufacturer instance);
    partial void DeleteManufacturer(Manufacturer instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    #endregion
		
		public DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebBuyPhoneConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AccountEmp> AccountEmps
		{
			get
			{
				return this.GetTable<AccountEmp>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Manufacturer> Manufacturers
		{
			get
			{
				return this.GetTable<Manufacturer>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountEmp")]
	public partial class AccountEmp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Account;
		
		private string _ID_Emp;
		
		private string _Username;
		
		private string _Password;
		
		private string _Secret_Question;
		
		private string _Secret_Answer;
		
		private System.Nullable<bool> _Active;
		
		private EntitySet<Role> _Roles;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_AccountChanging(string value);
    partial void OnID_AccountChanged();
    partial void OnID_EmpChanging(string value);
    partial void OnID_EmpChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnSecret_QuestionChanging(string value);
    partial void OnSecret_QuestionChanged();
    partial void OnSecret_AnswerChanging(string value);
    partial void OnSecret_AnswerChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    #endregion
		
		public AccountEmp()
		{
			this._Roles = new EntitySet<Role>(new Action<Role>(this.attach_Roles), new Action<Role>(this.detach_Roles));
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Account", DbType="NVarChar(200) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Account
		{
			get
			{
				return this._ID_Account;
			}
			set
			{
				if ((this._ID_Account != value))
				{
					this.OnID_AccountChanging(value);
					this.SendPropertyChanging();
					this._ID_Account = value;
					this.SendPropertyChanged("ID_Account");
					this.OnID_AccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Emp", DbType="NVarChar(200)")]
		public string ID_Emp
		{
			get
			{
				return this._ID_Emp;
			}
			set
			{
				if ((this._ID_Emp != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_EmpChanging(value);
					this.SendPropertyChanging();
					this._ID_Emp = value;
					this.SendPropertyChanged("ID_Emp");
					this.OnID_EmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(100)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(100)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Secret_Question", DbType="NVarChar(100)")]
		public string Secret_Question
		{
			get
			{
				return this._Secret_Question;
			}
			set
			{
				if ((this._Secret_Question != value))
				{
					this.OnSecret_QuestionChanging(value);
					this.SendPropertyChanging();
					this._Secret_Question = value;
					this.SendPropertyChanged("Secret_Question");
					this.OnSecret_QuestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Secret_Answer", DbType="NVarChar(100)")]
		public string Secret_Answer
		{
			get
			{
				return this._Secret_Answer;
			}
			set
			{
				if ((this._Secret_Answer != value))
				{
					this.OnSecret_AnswerChanging(value);
					this.SendPropertyChanging();
					this._Secret_Answer = value;
					this.SendPropertyChanged("Secret_Answer");
					this.OnSecret_AnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountEmp_Role", Storage="_Roles", ThisKey="ID_Account", OtherKey="ID_Account")]
		public EntitySet<Role> Roles
		{
			get
			{
				return this._Roles;
			}
			set
			{
				this._Roles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_AccountEmp", Storage="_Employee", ThisKey="ID_Emp", OtherKey="ID_Emp", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.AccountEmps.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.AccountEmps.Add(this);
						this._ID_Emp = value.ID_Emp;
					}
					else
					{
						this._ID_Emp = default(string);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Roles(Role entity)
		{
			this.SendPropertyChanging();
			entity.AccountEmp = this;
		}
		
		private void detach_Roles(Role entity)
		{
			this.SendPropertyChanging();
			entity.AccountEmp = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Emp;
		
		private string _FullName;
		
		private string _Address;
		
		private string _Email;
		
		private string _Phone;
		
		private string _Passport;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private System.Nullable<bool> _Sex;
		
		private EntitySet<AccountEmp> _AccountEmps;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_EmpChanging(string value);
    partial void OnID_EmpChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPassportChanging(string value);
    partial void OnPassportChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnSexChanging(System.Nullable<bool> value);
    partial void OnSexChanged();
    #endregion
		
		public Employee()
		{
			this._AccountEmps = new EntitySet<AccountEmp>(new Action<AccountEmp>(this.attach_AccountEmps), new Action<AccountEmp>(this.detach_AccountEmps));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Emp", DbType="NVarChar(200) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Emp
		{
			get
			{
				return this._ID_Emp;
			}
			set
			{
				if ((this._ID_Emp != value))
				{
					this.OnID_EmpChanging(value);
					this.SendPropertyChanging();
					this._ID_Emp = value;
					this.SendPropertyChanged("ID_Emp");
					this.OnID_EmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(100)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passport", DbType="NVarChar(30)")]
		public string Passport
		{
			get
			{
				return this._Passport;
			}
			set
			{
				if ((this._Passport != value))
				{
					this.OnPassportChanging(value);
					this.SendPropertyChanging();
					this._Passport = value;
					this.SendPropertyChanged("Passport");
					this.OnPassportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="Date")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="Bit")]
		public System.Nullable<bool> Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_AccountEmp", Storage="_AccountEmps", ThisKey="ID_Emp", OtherKey="ID_Emp")]
		public EntitySet<AccountEmp> AccountEmps
		{
			get
			{
				return this._AccountEmps;
			}
			set
			{
				this._AccountEmps.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AccountEmps(AccountEmp entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_AccountEmps(AccountEmp entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manufacturer")]
	public partial class Manufacturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id_Manufacturer;
		
		private string _Name_Manufacturer;
		
		private System.Nullable<bool> _Active;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ManufacturerChanging(string value);
    partial void OnId_ManufacturerChanged();
    partial void OnName_ManufacturerChanging(string value);
    partial void OnName_ManufacturerChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    #endregion
		
		public Manufacturer()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Manufacturer", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id_Manufacturer
		{
			get
			{
				return this._Id_Manufacturer;
			}
			set
			{
				if ((this._Id_Manufacturer != value))
				{
					this.OnId_ManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Id_Manufacturer = value;
					this.SendPropertyChanged("Id_Manufacturer");
					this.OnId_ManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_Manufacturer", DbType="NVarChar(100)")]
		public string Name_Manufacturer
		{
			get
			{
				return this._Name_Manufacturer;
			}
			set
			{
				if ((this._Name_Manufacturer != value))
				{
					this.OnName_ManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Name_Manufacturer = value;
					this.SendPropertyChanged("Name_Manufacturer");
					this.OnName_ManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manufacturer_Product", Storage="_Products", ThisKey="Id_Manufacturer", OtherKey="ID_Manufacturer")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Manufacturer = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Manufacturer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID_Product;
		
		private string _Name_Product;
		
		private string _ID_Manufacturer;
		
		private System.Nullable<double> _Price_Product;
		
		private string _Img_Product;
		
		private System.Nullable<bool> _Active;
		
		private string _Newfeature;
		
		private string _Screen;
		
		private string _Operating;
		
		private string _FrontCamera;
		
		private string _RearCamera;
		
		private string _CPU;
		
		private string _RAM;
		
		private string _InternalMemory;
		
		private string _MemoryStick;
		
		private string _SIM;
		
		private string _Battery;
		
		private string _Details;
		
		private EntityRef<Manufacturer> _Manufacturer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_ProductChanging(string value);
    partial void OnID_ProductChanged();
    partial void OnName_ProductChanging(string value);
    partial void OnName_ProductChanged();
    partial void OnID_ManufacturerChanging(string value);
    partial void OnID_ManufacturerChanged();
    partial void OnPrice_ProductChanging(System.Nullable<double> value);
    partial void OnPrice_ProductChanged();
    partial void OnImg_ProductChanging(string value);
    partial void OnImg_ProductChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnNewfeatureChanging(string value);
    partial void OnNewfeatureChanged();
    partial void OnScreenChanging(string value);
    partial void OnScreenChanged();
    partial void OnOperatingChanging(string value);
    partial void OnOperatingChanged();
    partial void OnFrontCameraChanging(string value);
    partial void OnFrontCameraChanged();
    partial void OnRearCameraChanging(string value);
    partial void OnRearCameraChanged();
    partial void OnCPUChanging(string value);
    partial void OnCPUChanged();
    partial void OnRAMChanging(string value);
    partial void OnRAMChanged();
    partial void OnInternalMemoryChanging(string value);
    partial void OnInternalMemoryChanged();
    partial void OnMemoryStickChanging(string value);
    partial void OnMemoryStickChanged();
    partial void OnSIMChanging(string value);
    partial void OnSIMChanged();
    partial void OnBatteryChanging(string value);
    partial void OnBatteryChanged();
    partial void OnDetailsChanging(string value);
    partial void OnDetailsChanged();
    #endregion
		
		public Product()
		{
			this._Manufacturer = default(EntityRef<Manufacturer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Product", DbType="NVarChar(200) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID_Product
		{
			get
			{
				return this._ID_Product;
			}
			set
			{
				if ((this._ID_Product != value))
				{
					this.OnID_ProductChanging(value);
					this.SendPropertyChanging();
					this._ID_Product = value;
					this.SendPropertyChanged("ID_Product");
					this.OnID_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_Product", DbType="NVarChar(50)")]
		public string Name_Product
		{
			get
			{
				return this._Name_Product;
			}
			set
			{
				if ((this._Name_Product != value))
				{
					this.OnName_ProductChanging(value);
					this.SendPropertyChanging();
					this._Name_Product = value;
					this.SendPropertyChanged("Name_Product");
					this.OnName_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Manufacturer", DbType="NVarChar(100)")]
		public string ID_Manufacturer
		{
			get
			{
				return this._ID_Manufacturer;
			}
			set
			{
				if ((this._ID_Manufacturer != value))
				{
					if (this._Manufacturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_ManufacturerChanging(value);
					this.SendPropertyChanging();
					this._ID_Manufacturer = value;
					this.SendPropertyChanged("ID_Manufacturer");
					this.OnID_ManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price_Product", DbType="Float")]
		public System.Nullable<double> Price_Product
		{
			get
			{
				return this._Price_Product;
			}
			set
			{
				if ((this._Price_Product != value))
				{
					this.OnPrice_ProductChanging(value);
					this.SendPropertyChanging();
					this._Price_Product = value;
					this.SendPropertyChanged("Price_Product");
					this.OnPrice_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img_Product", DbType="NVarChar(200)")]
		public string Img_Product
		{
			get
			{
				return this._Img_Product;
			}
			set
			{
				if ((this._Img_Product != value))
				{
					this.OnImg_ProductChanging(value);
					this.SendPropertyChanging();
					this._Img_Product = value;
					this.SendPropertyChanged("Img_Product");
					this.OnImg_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Newfeature", DbType="NVarChar(1000)")]
		public string Newfeature
		{
			get
			{
				return this._Newfeature;
			}
			set
			{
				if ((this._Newfeature != value))
				{
					this.OnNewfeatureChanging(value);
					this.SendPropertyChanging();
					this._Newfeature = value;
					this.SendPropertyChanged("Newfeature");
					this.OnNewfeatureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Screen", DbType="NVarChar(50)")]
		public string Screen
		{
			get
			{
				return this._Screen;
			}
			set
			{
				if ((this._Screen != value))
				{
					this.OnScreenChanging(value);
					this.SendPropertyChanging();
					this._Screen = value;
					this.SendPropertyChanged("Screen");
					this.OnScreenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operating", DbType="NVarChar(50)")]
		public string Operating
		{
			get
			{
				return this._Operating;
			}
			set
			{
				if ((this._Operating != value))
				{
					this.OnOperatingChanging(value);
					this.SendPropertyChanging();
					this._Operating = value;
					this.SendPropertyChanged("Operating");
					this.OnOperatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FrontCamera", DbType="NVarChar(50)")]
		public string FrontCamera
		{
			get
			{
				return this._FrontCamera;
			}
			set
			{
				if ((this._FrontCamera != value))
				{
					this.OnFrontCameraChanging(value);
					this.SendPropertyChanging();
					this._FrontCamera = value;
					this.SendPropertyChanged("FrontCamera");
					this.OnFrontCameraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RearCamera", DbType="NVarChar(50)")]
		public string RearCamera
		{
			get
			{
				return this._RearCamera;
			}
			set
			{
				if ((this._RearCamera != value))
				{
					this.OnRearCameraChanging(value);
					this.SendPropertyChanging();
					this._RearCamera = value;
					this.SendPropertyChanged("RearCamera");
					this.OnRearCameraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU", DbType="NVarChar(50)")]
		public string CPU
		{
			get
			{
				return this._CPU;
			}
			set
			{
				if ((this._CPU != value))
				{
					this.OnCPUChanging(value);
					this.SendPropertyChanging();
					this._CPU = value;
					this.SendPropertyChanged("CPU");
					this.OnCPUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM", DbType="NVarChar(50)")]
		public string RAM
		{
			get
			{
				return this._RAM;
			}
			set
			{
				if ((this._RAM != value))
				{
					this.OnRAMChanging(value);
					this.SendPropertyChanging();
					this._RAM = value;
					this.SendPropertyChanged("RAM");
					this.OnRAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InternalMemory", DbType="NVarChar(50)")]
		public string InternalMemory
		{
			get
			{
				return this._InternalMemory;
			}
			set
			{
				if ((this._InternalMemory != value))
				{
					this.OnInternalMemoryChanging(value);
					this.SendPropertyChanging();
					this._InternalMemory = value;
					this.SendPropertyChanged("InternalMemory");
					this.OnInternalMemoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemoryStick", DbType="NVarChar(50)")]
		public string MemoryStick
		{
			get
			{
				return this._MemoryStick;
			}
			set
			{
				if ((this._MemoryStick != value))
				{
					this.OnMemoryStickChanging(value);
					this.SendPropertyChanging();
					this._MemoryStick = value;
					this.SendPropertyChanged("MemoryStick");
					this.OnMemoryStickChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIM", DbType="NVarChar(50)")]
		public string SIM
		{
			get
			{
				return this._SIM;
			}
			set
			{
				if ((this._SIM != value))
				{
					this.OnSIMChanging(value);
					this.SendPropertyChanging();
					this._SIM = value;
					this.SendPropertyChanged("SIM");
					this.OnSIMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Battery", DbType="NVarChar(50)")]
		public string Battery
		{
			get
			{
				return this._Battery;
			}
			set
			{
				if ((this._Battery != value))
				{
					this.OnBatteryChanging(value);
					this.SendPropertyChanging();
					this._Battery = value;
					this.SendPropertyChanged("Battery");
					this.OnBatteryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Details", DbType="NVarChar(2000)")]
		public string Details
		{
			get
			{
				return this._Details;
			}
			set
			{
				if ((this._Details != value))
				{
					this.OnDetailsChanging(value);
					this.SendPropertyChanging();
					this._Details = value;
					this.SendPropertyChanged("Details");
					this.OnDetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manufacturer_Product", Storage="_Manufacturer", ThisKey="ID_Manufacturer", OtherKey="Id_Manufacturer", IsForeignKey=true)]
		public Manufacturer Manufacturer
		{
			get
			{
				return this._Manufacturer.Entity;
			}
			set
			{
				Manufacturer previousValue = this._Manufacturer.Entity;
				if (((previousValue != value) 
							|| (this._Manufacturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Manufacturer.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Manufacturer.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._ID_Manufacturer = value.Id_Manufacturer;
					}
					else
					{
						this._ID_Manufacturer = default(string);
					}
					this.SendPropertyChanged("Manufacturer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Role;
		
		private string _ID_Account;
		
		private string _Username;
		
		private System.Nullable<int> _Role_Register;
		
		private System.Nullable<int> _Role_Product;
		
		private System.Nullable<bool> _Role_Roles;
		
		private System.Nullable<int> _Roles_Manufacturer;
		
		private EntityRef<AccountEmp> _AccountEmp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_RoleChanging(int value);
    partial void OnId_RoleChanged();
    partial void OnID_AccountChanging(string value);
    partial void OnID_AccountChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnRole_RegisterChanging(System.Nullable<int> value);
    partial void OnRole_RegisterChanged();
    partial void OnRole_ProductChanging(System.Nullable<int> value);
    partial void OnRole_ProductChanged();
    partial void OnRole_RolesChanging(System.Nullable<bool> value);
    partial void OnRole_RolesChanged();
    partial void OnRoles_ManufacturerChanging(System.Nullable<int> value);
    partial void OnRoles_ManufacturerChanged();
    #endregion
		
		public Role()
		{
			this._AccountEmp = default(EntityRef<AccountEmp>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Role", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Role
		{
			get
			{
				return this._Id_Role;
			}
			set
			{
				if ((this._Id_Role != value))
				{
					this.OnId_RoleChanging(value);
					this.SendPropertyChanging();
					this._Id_Role = value;
					this.SendPropertyChanged("Id_Role");
					this.OnId_RoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Account", DbType="NVarChar(200)")]
		public string ID_Account
		{
			get
			{
				return this._ID_Account;
			}
			set
			{
				if ((this._ID_Account != value))
				{
					if (this._AccountEmp.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_AccountChanging(value);
					this.SendPropertyChanging();
					this._ID_Account = value;
					this.SendPropertyChanged("ID_Account");
					this.OnID_AccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(100)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Register", DbType="Int")]
		public System.Nullable<int> Role_Register
		{
			get
			{
				return this._Role_Register;
			}
			set
			{
				if ((this._Role_Register != value))
				{
					this.OnRole_RegisterChanging(value);
					this.SendPropertyChanging();
					this._Role_Register = value;
					this.SendPropertyChanged("Role_Register");
					this.OnRole_RegisterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Product", DbType="Int")]
		public System.Nullable<int> Role_Product
		{
			get
			{
				return this._Role_Product;
			}
			set
			{
				if ((this._Role_Product != value))
				{
					this.OnRole_ProductChanging(value);
					this.SendPropertyChanging();
					this._Role_Product = value;
					this.SendPropertyChanged("Role_Product");
					this.OnRole_ProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Roles", DbType="Bit")]
		public System.Nullable<bool> Role_Roles
		{
			get
			{
				return this._Role_Roles;
			}
			set
			{
				if ((this._Role_Roles != value))
				{
					this.OnRole_RolesChanging(value);
					this.SendPropertyChanging();
					this._Role_Roles = value;
					this.SendPropertyChanged("Role_Roles");
					this.OnRole_RolesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Roles_Manufacturer", DbType="Int")]
		public System.Nullable<int> Roles_Manufacturer
		{
			get
			{
				return this._Roles_Manufacturer;
			}
			set
			{
				if ((this._Roles_Manufacturer != value))
				{
					this.OnRoles_ManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Roles_Manufacturer = value;
					this.SendPropertyChanged("Roles_Manufacturer");
					this.OnRoles_ManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountEmp_Role", Storage="_AccountEmp", ThisKey="ID_Account", OtherKey="ID_Account", IsForeignKey=true)]
		public AccountEmp AccountEmp
		{
			get
			{
				return this._AccountEmp.Entity;
			}
			set
			{
				AccountEmp previousValue = this._AccountEmp.Entity;
				if (((previousValue != value) 
							|| (this._AccountEmp.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AccountEmp.Entity = null;
						previousValue.Roles.Remove(this);
					}
					this._AccountEmp.Entity = value;
					if ((value != null))
					{
						value.Roles.Add(this);
						this._ID_Account = value.ID_Account;
					}
					else
					{
						this._ID_Account = default(string);
					}
					this.SendPropertyChanged("AccountEmp");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
