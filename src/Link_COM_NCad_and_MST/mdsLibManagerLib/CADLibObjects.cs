using System.Collections.Generic;

namespace DynmdsLibManagerLib 
{

	///<summary>
	///ICADLibObjects Interface
	///</summary>
	public class CADLibObjects 
	{
		public mdsLibManagerLib.ICADLibObjects _i;
		internal CADLibObjects(object CADLibObjects_object) 
		{
			this._i = CADLibObjects_object as mdsLibManagerLib.ICADLibObjects;
			if (this._i == null) throw new System.Exception("Invalid casting to ICADLibObjects");
		}

        ///<summary>
        ///Возвращает набор объектов
        ///</summary>

        public List<CADLibObject> GetCADLibObjects()
        {
            List<CADLibObject> objects = new List<CADLibObject>();
            for (int i = 0; i < this.Count; i++)
            {
                objects.Add(new CADLibObject(this._i.Item(i)));
            }
            return objects;
        }

        ///<summary>
        ///property Count
        ///</summary>
        public long Count => this._i.Count;
	}
}
