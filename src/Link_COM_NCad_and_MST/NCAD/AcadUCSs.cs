﻿using System.Collections.Generic;


namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUCSs 
	{
		public OdaX.AcadUCSs _i;
		internal AcadUCSs(object AcadUCSs_object) 
		{
			this._i = AcadUCSs_object as OdaX.AcadUCSs;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadUCS Item(object Index) 
		{
			return new AcadUCS(this._i.Item(Index));
		}
		/// <summary>
		/// Get all ucs
		/// </summary>
		/// <returns></returns>
		public List<AcadUCS> GetAcadUCS()
		{
			List<AcadUCS> us = new List<AcadUCS>(0);
			foreach (var u in this._i)
			{
				 us.Add(new AcadUCS(u));
			}
			return us;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
