﻿namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadExtrudedSurface 
	{
		public OdaX.AcadExtrudedSurface _i;
		internal AcadExtrudedSurface(object AcadExtrudedSurface_object) 
		{
			this._i = AcadExtrudedSurface_object as OdaX.AcadExtrudedSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public double TaperAngle => this._i.TaperAngle;

		///<summary>
		///
		///</summary>
		public void Set_TaperAngle(double TaperAngle) 
		{
			this._i.TaperAngle = TaperAngle;
		}

		///<summary>
		///
		///</summary>
		public object Direction => this._i.Direction;
	}
}
