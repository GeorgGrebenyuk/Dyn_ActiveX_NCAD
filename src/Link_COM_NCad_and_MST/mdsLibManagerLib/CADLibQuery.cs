namespace DynmdsLibManagerLib 
{

	///<summary>
	///ICADLibQuery Interface
	///</summary>
	public class CADLibQuery 
	{
		public mdsLibManagerLib.ICADLibQuery _i;
		internal CADLibQuery(object CADLibQuery_object) 
		{
			this._i = CADLibQuery_object as mdsLibManagerLib.ICADLibQuery;
			if (this._i == null) throw new System.Exception("Invalid casting to ICADLibQuery");
		}

		///<summary>
		///method AddCondition
		///</summary>
		public void AddCondition(string ParamName, mdsLibManagerLib.CADLibRelationType Relation, string Value) 
		{
			this._i.AddCondition(ParamName,Relation,Value);
		}

		///<summary>
		///method Execute
		///</summary>
		public CADLibObjects Execute => new CADLibObjects(this._i.Execute());

		///<summary>
		///method Search
		///</summary>
		public CADLibObjects Search(int hWndParent, string bsCaption) 
		{
			return new CADLibObjects(this._i.Search(hWndParent, bsCaption));
		}

		///<summary>
		///method SelectObjects
		///</summary>
		public CADLibObjects SelectObjects(int hWndParent, string Caption, int Options) 
		{
			return new CADLibObjects(this._i.SelectObjects(hWndParent,Caption,Options));
		}
	}
}
