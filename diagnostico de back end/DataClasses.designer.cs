﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diagnostico_de_back_end
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="cafecito")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertbebidas(bebidas instance);
    partial void Updatebebidas(bebidas instance);
    partial void Deletebebidas(bebidas instance);
    partial void Inserttipos_de_cafe(tipos_de_cafe instance);
    partial void Updatetipos_de_cafe(tipos_de_cafe instance);
    partial void Deletetipos_de_cafe(tipos_de_cafe instance);
    partial void Insertusuarios(usuarios instance);
    partial void Updateusuarios(usuarios instance);
    partial void Deleteusuarios(usuarios instance);
    partial void Insertventas(ventas instance);
    partial void Updateventas(ventas instance);
    partial void Deleteventas(ventas instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["cafecitoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bebidas> bebidas
		{
			get
			{
				return this.GetTable<bebidas>();
			}
		}
		
		public System.Data.Linq.Table<tipos_de_cafe> tipos_de_cafe
		{
			get
			{
				return this.GetTable<tipos_de_cafe>();
			}
		}
		
		public System.Data.Linq.Table<usuarios> usuarios
		{
			get
			{
				return this.GetTable<usuarios>();
			}
		}
		
		public System.Data.Linq.Table<ventas> ventas
		{
			get
			{
				return this.GetTable<ventas>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VerificarCredenciales")]
		public ISingleResult<VerificarCredencialesResult> VerificarCredenciales([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(50)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="Decimal(4,0)")] System.Nullable<decimal> contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Rol", DbType="VarChar(50)")] ref string rol)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreUsuario, contraseña, rol);
			rol = ((string)(result.GetParameterValue(2)));
			return ((ISingleResult<VerificarCredencialesResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bebidas")]
	public partial class bebidas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nombre;
		
		private decimal _Precio;
		
		private int _ID_Cafes;
		
		private EntitySet<ventas> _ventas;
		
		private EntityRef<tipos_de_cafe> _tipos_de_cafe;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnPrecioChanging(decimal value);
    partial void OnPrecioChanged();
    partial void OnID_CafesChanging(int value);
    partial void OnID_CafesChanged();
    #endregion
		
		public bebidas()
		{
			this._ventas = new EntitySet<ventas>(new Action<ventas>(this.attach_ventas), new Action<ventas>(this.detach_ventas));
			this._tipos_de_cafe = default(EntityRef<tipos_de_cafe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Cafes", DbType="Int NOT NULL")]
		public int ID_Cafes
		{
			get
			{
				return this._ID_Cafes;
			}
			set
			{
				if ((this._ID_Cafes != value))
				{
					if (this._tipos_de_cafe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_CafesChanging(value);
					this.SendPropertyChanging();
					this._ID_Cafes = value;
					this.SendPropertyChanged("ID_Cafes");
					this.OnID_CafesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bebidas_ventas", Storage="_ventas", ThisKey="ID", OtherKey="ID_Bebida")]
		public EntitySet<ventas> ventas
		{
			get
			{
				return this._ventas;
			}
			set
			{
				this._ventas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tipos_de_cafe_bebidas", Storage="_tipos_de_cafe", ThisKey="ID_Cafes", OtherKey="ID_Cafe", IsForeignKey=true)]
		public tipos_de_cafe tipos_de_cafe
		{
			get
			{
				return this._tipos_de_cafe.Entity;
			}
			set
			{
				tipos_de_cafe previousValue = this._tipos_de_cafe.Entity;
				if (((previousValue != value) 
							|| (this._tipos_de_cafe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tipos_de_cafe.Entity = null;
						previousValue.bebidas.Remove(this);
					}
					this._tipos_de_cafe.Entity = value;
					if ((value != null))
					{
						value.bebidas.Add(this);
						this._ID_Cafes = value.ID_Cafe;
					}
					else
					{
						this._ID_Cafes = default(int);
					}
					this.SendPropertyChanged("tipos_de_cafe");
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
		
		private void attach_ventas(ventas entity)
		{
			this.SendPropertyChanging();
			entity.bebidas = this;
		}
		
		private void detach_ventas(ventas entity)
		{
			this.SendPropertyChanging();
			entity.bebidas = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tipos_de_cafe")]
	public partial class tipos_de_cafe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Cafe;
		
		private string _Cuerpo;
		
		private string _Aroma;
		
		private string _Acidez;
		
		private EntitySet<bebidas> _bebidas;
		
		private EntitySet<ventas> _ventas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_CafeChanging(int value);
    partial void OnID_CafeChanged();
    partial void OnCuerpoChanging(string value);
    partial void OnCuerpoChanged();
    partial void OnAromaChanging(string value);
    partial void OnAromaChanged();
    partial void OnAcidezChanging(string value);
    partial void OnAcidezChanged();
    #endregion
		
		public tipos_de_cafe()
		{
			this._bebidas = new EntitySet<bebidas>(new Action<bebidas>(this.attach_bebidas), new Action<bebidas>(this.detach_bebidas));
			this._ventas = new EntitySet<ventas>(new Action<ventas>(this.attach_ventas), new Action<ventas>(this.detach_ventas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Cafe", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Cafe
		{
			get
			{
				return this._ID_Cafe;
			}
			set
			{
				if ((this._ID_Cafe != value))
				{
					this.OnID_CafeChanging(value);
					this.SendPropertyChanging();
					this._ID_Cafe = value;
					this.SendPropertyChanged("ID_Cafe");
					this.OnID_CafeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuerpo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cuerpo
		{
			get
			{
				return this._Cuerpo;
			}
			set
			{
				if ((this._Cuerpo != value))
				{
					this.OnCuerpoChanging(value);
					this.SendPropertyChanging();
					this._Cuerpo = value;
					this.SendPropertyChanged("Cuerpo");
					this.OnCuerpoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Aroma", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Aroma
		{
			get
			{
				return this._Aroma;
			}
			set
			{
				if ((this._Aroma != value))
				{
					this.OnAromaChanging(value);
					this.SendPropertyChanging();
					this._Aroma = value;
					this.SendPropertyChanged("Aroma");
					this.OnAromaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acidez", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Acidez
		{
			get
			{
				return this._Acidez;
			}
			set
			{
				if ((this._Acidez != value))
				{
					this.OnAcidezChanging(value);
					this.SendPropertyChanging();
					this._Acidez = value;
					this.SendPropertyChanged("Acidez");
					this.OnAcidezChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tipos_de_cafe_bebidas", Storage="_bebidas", ThisKey="ID_Cafe", OtherKey="ID_Cafes")]
		public EntitySet<bebidas> bebidas
		{
			get
			{
				return this._bebidas;
			}
			set
			{
				this._bebidas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tipos_de_cafe_ventas", Storage="_ventas", ThisKey="ID_Cafe", OtherKey="ID_TipoCafe")]
		public EntitySet<ventas> ventas
		{
			get
			{
				return this._ventas;
			}
			set
			{
				this._ventas.Assign(value);
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
		
		private void attach_bebidas(bebidas entity)
		{
			this.SendPropertyChanging();
			entity.tipos_de_cafe = this;
		}
		
		private void detach_bebidas(bebidas entity)
		{
			this.SendPropertyChanging();
			entity.tipos_de_cafe = null;
		}
		
		private void attach_ventas(ventas entity)
		{
			this.SendPropertyChanging();
			entity.tipos_de_cafe = this;
		}
		
		private void detach_ventas(ventas entity)
		{
			this.SendPropertyChanging();
			entity.tipos_de_cafe = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _usuario;
		
		private decimal _password;
		
		private string _rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OnpasswordChanging(decimal value);
    partial void OnpasswordChanged();
    partial void OnrolChanging(string value);
    partial void OnrolChanged();
    #endregion
		
		public usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="Decimal(4,0) NOT NULL")]
		public decimal password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string rol
		{
			get
			{
				return this._rol;
			}
			set
			{
				if ((this._rol != value))
				{
					this.OnrolChanging(value);
					this.SendPropertyChanging();
					this._rol = value;
					this.SendPropertyChanged("rol");
					this.OnrolChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ventas")]
	public partial class ventas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ID_Bebida;
		
		private int _ID_TipoCafe;
		
		private System.DateTime _FechaVenta;
		
		private decimal _PrecioTotal;
		
		private EntityRef<bebidas> _bebidas;
		
		private EntityRef<tipos_de_cafe> _tipos_de_cafe;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnID_BebidaChanging(int value);
    partial void OnID_BebidaChanged();
    partial void OnID_TipoCafeChanging(int value);
    partial void OnID_TipoCafeChanged();
    partial void OnFechaVentaChanging(System.DateTime value);
    partial void OnFechaVentaChanged();
    partial void OnPrecioTotalChanging(decimal value);
    partial void OnPrecioTotalChanged();
    #endregion
		
		public ventas()
		{
			this._bebidas = default(EntityRef<bebidas>);
			this._tipos_de_cafe = default(EntityRef<tipos_de_cafe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Bebida", DbType="Int NOT NULL")]
		public int ID_Bebida
		{
			get
			{
				return this._ID_Bebida;
			}
			set
			{
				if ((this._ID_Bebida != value))
				{
					if (this._bebidas.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_BebidaChanging(value);
					this.SendPropertyChanging();
					this._ID_Bebida = value;
					this.SendPropertyChanged("ID_Bebida");
					this.OnID_BebidaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TipoCafe", DbType="Int NOT NULL")]
		public int ID_TipoCafe
		{
			get
			{
				return this._ID_TipoCafe;
			}
			set
			{
				if ((this._ID_TipoCafe != value))
				{
					if (this._tipos_de_cafe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_TipoCafeChanging(value);
					this.SendPropertyChanging();
					this._ID_TipoCafe = value;
					this.SendPropertyChanged("ID_TipoCafe");
					this.OnID_TipoCafeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaVenta", DbType="DateTime NOT NULL")]
		public System.DateTime FechaVenta
		{
			get
			{
				return this._FechaVenta;
			}
			set
			{
				if ((this._FechaVenta != value))
				{
					this.OnFechaVentaChanging(value);
					this.SendPropertyChanging();
					this._FechaVenta = value;
					this.SendPropertyChanged("FechaVenta");
					this.OnFechaVentaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioTotal", DbType="Decimal(10,2) NOT NULL")]
		public decimal PrecioTotal
		{
			get
			{
				return this._PrecioTotal;
			}
			set
			{
				if ((this._PrecioTotal != value))
				{
					this.OnPrecioTotalChanging(value);
					this.SendPropertyChanging();
					this._PrecioTotal = value;
					this.SendPropertyChanged("PrecioTotal");
					this.OnPrecioTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bebidas_ventas", Storage="_bebidas", ThisKey="ID_Bebida", OtherKey="ID", IsForeignKey=true)]
		public bebidas bebidas
		{
			get
			{
				return this._bebidas.Entity;
			}
			set
			{
				bebidas previousValue = this._bebidas.Entity;
				if (((previousValue != value) 
							|| (this._bebidas.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._bebidas.Entity = null;
						previousValue.ventas.Remove(this);
					}
					this._bebidas.Entity = value;
					if ((value != null))
					{
						value.ventas.Add(this);
						this._ID_Bebida = value.ID;
					}
					else
					{
						this._ID_Bebida = default(int);
					}
					this.SendPropertyChanged("bebidas");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tipos_de_cafe_ventas", Storage="_tipos_de_cafe", ThisKey="ID_TipoCafe", OtherKey="ID_Cafe", IsForeignKey=true)]
		public tipos_de_cafe tipos_de_cafe
		{
			get
			{
				return this._tipos_de_cafe.Entity;
			}
			set
			{
				tipos_de_cafe previousValue = this._tipos_de_cafe.Entity;
				if (((previousValue != value) 
							|| (this._tipos_de_cafe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tipos_de_cafe.Entity = null;
						previousValue.ventas.Remove(this);
					}
					this._tipos_de_cafe.Entity = value;
					if ((value != null))
					{
						value.ventas.Add(this);
						this._ID_TipoCafe = value.ID_Cafe;
					}
					else
					{
						this._ID_TipoCafe = default(int);
					}
					this.SendPropertyChanged("tipos_de_cafe");
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
	
	public partial class VerificarCredencialesResult
	{
		
		private string _Mensaje;
		
		public VerificarCredencialesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mensaje", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string Mensaje
		{
			get
			{
				return this._Mensaje;
			}
			set
			{
				if ((this._Mensaje != value))
				{
					this._Mensaje = value;
				}
			}
		}
	}
}
#pragma warning restore 1591