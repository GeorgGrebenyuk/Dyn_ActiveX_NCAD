using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDictionaries 
	{
		public OdaX.AcadDictionaries _i;
		internal AcadDictionaries(object AcadDictionaries_object) 
		{
			this._i = AcadDictionaries_object as OdaX.AcadDictionaries;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///
        ///</summary>
        private AcadDictionary Item(object Index) 
		{
			return new AcadDictionary(this._i.Item(Index));
		}
		public List<AcadDictionary> GetAll()
		{
            List<AcadDictionary>ds = new List<AcadDictionary>();
			foreach (var d in this._i)
			{
				ds.Add(new AcadDictionary(d));
			}
			return ds;
        }

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
