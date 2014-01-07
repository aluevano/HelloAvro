// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace HelloAvro.DTO
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class EmployeeDTO : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""EmployeeDTO"",""namespace"":""HelloAvro.DTO"",""fields"":[{""name"":""Name"",""type"":""string""},{""name"":""EmployeeId"",""type"":""int""},{""name"":""Reportees"",""type"":{""type"":""array"",""items"":""int""}},{""name"":""Notes"",""type"":[""null"",""string""]},{""name"":""ActiveProjects"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""ProjectDTO"",""namespace"":""HelloAvro.DTO"",""fields"":[{""name"":""ProjectId"",""type"":""int""},{""name"":""ProjectName"",""type"":""string""}]}}},{""name"":""RawBytes"",""type"":""bytes""},{""name"":""StillWorksHere"",""type"":""boolean""}]}");
		private string _Name;
		private int _EmployeeId;
		private IList<System.Int32> _Reportees;
		private string _Notes;
		private IList<HelloAvro.DTO.ProjectDTO> _ActiveProjects;
		private byte[] _RawBytes;
		private bool _StillWorksHere;
		public virtual Schema Schema
		{
			get
			{
				return EmployeeDTO._SCHEMA;
			}
		}
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				this._EmployeeId = value;
			}
		}
		public IList<System.Int32> Reportees
		{
			get
			{
				return this._Reportees;
			}
			set
			{
				this._Reportees = value;
			}
		}
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				this._Notes = value;
			}
		}
		public IList<HelloAvro.DTO.ProjectDTO> ActiveProjects
		{
			get
			{
				return this._ActiveProjects;
			}
			set
			{
				this._ActiveProjects = value;
			}
		}
		public byte[] RawBytes
		{
			get
			{
				return this._RawBytes;
			}
			set
			{
				this._RawBytes = value;
			}
		}
		public bool StillWorksHere
		{
			get
			{
				return this._StillWorksHere;
			}
			set
			{
				this._StillWorksHere = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Name;
			case 1: return this.EmployeeId;
			case 2: return this.Reportees;
			case 3: return this.Notes;
			case 4: return this.ActiveProjects;
			case 5: return this.RawBytes;
			case 6: return this.StillWorksHere;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Name = (System.String)fieldValue; break;
			case 1: this.EmployeeId = (System.Int32)fieldValue; break;
			case 2: this.Reportees = (IList<System.Int32>)fieldValue; break;
			case 3: this.Notes = (System.String)fieldValue; break;
			case 4: this.ActiveProjects = (IList<HelloAvro.DTO.ProjectDTO>)fieldValue; break;
			case 5: this.RawBytes = (System.Byte[])fieldValue; break;
			case 6: this.StillWorksHere = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
