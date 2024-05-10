using System.Collections.Generic;

namespace DynmdsUnitsLib 
{

	///<summary>
	///IParameters Interface
	///</summary>
	public class Parameters 
	{
		public mdsUnitsLib.IParameters _i;
		internal Parameters(object Parameters_object) 
		{
			this._i = Parameters_object as mdsUnitsLib.IParameters;
			if (this._i == null) throw new System.Exception("Invalid casting to IParameters");
		}

		///<summary>
		///Возвращает набор параметров
		///</summary>

		public List<Parameter> GetParameters()
		{
			List<Parameter> pars = new List<Parameter>();
			for (int i = 0; i < this.Count; i++)
			{
				pars.Add(new Parameter(this._i.Item(i)));
			}
			return pars;
		}

		///<summary>
		///property Count
		///</summary>
		public long Count => this._i.Count;

		///<summary>
		///method SetParameter
		///</summary>
		public void SetParameter(string Name, string Value, string Comment = "", string ValueComment = "")
		{
			((dynamic)this._i).SetParameter(Name, Value, Comment, ValueComment);
		}

		///<summary>
		///method DeleteParameter
		///</summary>
		public void DeleteParameter(string Name)
		{
			this._i.DeleteParameter(Name);
		}

		///<summary>
		///method DeleteAll
		///</summary>
		public void DeleteAll()
		{
			this._i.DeleteAll();
		}

		///<summary>
		///method Has
		///</summary>
		public bool Has(int Index)
		{
			return this._i.Has(Index);
		}
	}
}
