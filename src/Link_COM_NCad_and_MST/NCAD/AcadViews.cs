using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViews 
	{
		public OdaX.AcadViews _i;
		internal AcadViews(object AcadViews_object) 
		{
			this._i = AcadViews_object as OdaX.AcadViews;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

        /// <summary>
        /// Get all AcadViews
        /// </summary>
        /// <returns></returns>
        public List<AcadView> GetViews()
		{
            List<AcadView> ents = new List<AcadView>();
            for (int i = 0; i < this._i.Count; i++)
            {
                ents.Add(new AcadView(this._i.Item(i)));
            }
            return ents;
        }
	}
}
