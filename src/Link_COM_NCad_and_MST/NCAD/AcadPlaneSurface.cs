namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlaneSurface 
	{
		public OdaX.AcadPlaneSurface _i;
		internal AcadPlaneSurface(object AcadPlaneSurface_object) 
		{
			this._i = AcadPlaneSurface_object as OdaX.AcadPlaneSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
