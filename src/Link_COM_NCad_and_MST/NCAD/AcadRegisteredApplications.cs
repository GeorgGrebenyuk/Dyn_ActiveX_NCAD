﻿using System.Collections.Generic;

namespace DynNCXLib 
{

    ///<summary>
    ///The collection of all registered applications in the drawing
    ///</summary>
    public class AcadRegisteredApplications 
	{
		public OdaX.AcadRegisteredApplications _i;
		internal AcadRegisteredApplications(object AcadRegisteredApplications_object) 
		{
			this._i = AcadRegisteredApplications_object as OdaX.AcadRegisteredApplications;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
        /// <summary>
        /// Get All RegisteredApplications
        /// </summary>
        /// <returns></returns>
        public List<AcadRegisteredApplication> GetRegisteredApplications()
        {
            List<AcadRegisteredApplication> objects = new List<AcadRegisteredApplication>();
            foreach (var obj in this._i)
            {
                objects.Add(new AcadRegisteredApplication(obj));
            }
            return objects;
        }
        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;

		
	}
}
