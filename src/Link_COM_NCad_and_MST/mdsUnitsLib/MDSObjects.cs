using DynNCXLib;
using System.Collections.Generic;

namespace DynmdsUnitsLib 
{

	///<summary>
	///IMDSObjects Interface
	///</summary>
	public class MDSObjects 
	{
		public mdsUnitsLib.IMDSObjects _i;
		internal MDSObjects(object MDSObjects_object) 
		{
			this._i = MDSObjects_object as mdsUnitsLib.IMDSObjects;
			if (this._i == null) throw new System.Exception("Invalid casting to IMDSObjects");
		}

        /// <summary>
        /// Возвращает набор объектов
        /// </summary>
        /// <returns></returns>
        public List<AcadEntity> GetAcadEntities()
        {
            List<AcadEntity> pars = new List<AcadEntity>();
            for (int i = 0; i < this.Count; i++)
            {
                pars.Add(new AcadEntity(this._i.Item(i)));
            }
            return pars;
        }

        ///<summary>
        ///property Count
        ///</summary>
        public long Count => this._i.Count;
	}
}
