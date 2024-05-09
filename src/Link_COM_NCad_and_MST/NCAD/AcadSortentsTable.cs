namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSortentsTable 
	{
		public OdaX.AcadSortentsTable _i;
		internal AcadSortentsTable(object AcadSortentsTable_object) 
		{
			this._i = AcadSortentsTable_object as OdaX.AcadSortentsTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void MoveToBottom(object Objects) 
		{
			this._i.MoveToBottom(Objects);
		}

		///<summary>
		///
		///</summary>
		public void MoveToTop(object Objects) 
		{
			this._i.MoveToTop(Objects);
		}

		///<summary>
		///
		///</summary>
		public void MoveBelow(object Objects, AcadEntity Target) 
		{
			this._i.MoveBelow(Objects,Target._i);
		}

		///<summary>
		///
		///</summary>
		public void MoveAbove(object Objects, AcadEntity Target) 
		{
			this._i.MoveAbove(Objects,Target._i);
		}

		///<summary>
		///
		///</summary>
		public void SwapOrder(AcadEntity Object1, AcadEntity Object2) 
		{
			this._i.SwapOrder(Object1._i,Object2._i);
		}

		///<summary>
		///
		///</summary>
		public AcadBlock Block => new AcadBlock(this._i.Block());

		///<summary>
		///
		///</summary>
		public object GetFullDrawOrder(bool honorSortentsSysvar) 
		{
			object objects = null;
			this._i.GetFullDrawOrder(out objects, honorSortentsSysvar);
			return objects;
		}

	

		///<summary>
		///
		///</summary>
		public void SetRelativeDrawOrder(object Objects) 
		{
			this._i.SetRelativeDrawOrder(Objects);
		}
	}
}
