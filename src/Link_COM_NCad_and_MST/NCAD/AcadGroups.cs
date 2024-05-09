using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGroups 
	{
		public OdaX.AcadGroups _i;
		internal AcadGroups(object AcadGroups_object) 
		{
			this._i = AcadGroups_object as OdaX.AcadGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Get all groups
		/// </summary>
		/// <returns></returns>
		public List<AcadGroup> GetGroups()
		{
			List<AcadGroup> gr = new List<AcadGroup>();
			foreach (var g in this._i)
			{
				gr.Add(new AcadGroup(g));
			}
			return gr;
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

	}
}
