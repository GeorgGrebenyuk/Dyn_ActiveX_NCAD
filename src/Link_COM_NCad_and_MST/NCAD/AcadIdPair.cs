namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadIdPair 
	{
		public OdaX.AcadIdPair _i;
		internal AcadIdPair(object AcadIdPair_object) 
		{
			this._i = AcadIdPair_object as OdaX.AcadIdPair;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool IsCloned => this._i.IsCloned;

		///<summary>
		///
		///</summary>
		public bool IsOwnerXlated => this._i.IsOwnerXlated;

		///<summary>
		///
		///</summary>
		public bool IsPrimary => this._i.IsPrimary;

		///<summary>
		///
		///</summary>
		public long key => this._i.key;

		///<summary>
		///
		///</summary>
		public long Value => this._i.Value;
	}
}
