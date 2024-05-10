namespace DynmdsUnitsLib 
{

	///<summary>
	///IParameter Interface
	///</summary>
	public class Parameter 
	{
		public mdsUnitsLib.IParameter _i;
		internal Parameter(object Parameter_object) 
		{
			this._i = Parameter_object as mdsUnitsLib.IParameter;
			if (this._i == null) throw new System.Exception("Invalid casting to IParameter");
		}

		///<summary>
		///property Name
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///property Value
		///</summary>
		public string Value => this._i.Value;

		///<summary>
		///property Value
		///</summary>
		public void Set_Value(string pVal)
		{
			this._i.Value = pVal;
		}

		///<summary>
		///property Comment
		///</summary>
		public string Comment => this._i.Comment;

		///<summary>
		///property Comment
		///</summary>
		public void Set_Comment(string pVal)
		{
			this._i.Comment = pVal;
		}

		///<summary>
		///property ValueComment
		///</summary>
		public string ValueComment => this._i.ValueComment;

		///<summary>
		///property ValueComment
		///</summary>
		public void Set_ValueComment(string pVal)
		{
			this._i.ValueComment = pVal;
		}
	}
}
