using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionManager 
	{
		public OdaX.AcadSectionManager _i;
		internal AcadSectionManager(object AcadSectionManager_object) 
		{
			this._i = AcadSectionManager_object as OdaX.AcadSectionManager;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

        /// <summary>
        /// Get all sections
        /// </summary>
        /// <returns></returns>
        public List<AcadSection> GetSections()
        {
            List<AcadSection> objects = new List<AcadSection>();
            foreach (var obj in this._i)
            {
                objects.Add(new AcadSection(obj));
            }
            return objects;
        }

        ///<summary>
        ///
        ///</summary>
        public AcadSection GetLiveSection => new AcadSection(this._i.GetLiveSection());

		///<summary>
		///
		///</summary>
		public string GetUniqueSectionName(string pBaseName) 
		{
			return this._i.GetUniqueSectionName(pBaseName);
		}
	}
}
