namespace DynNCXLib 
{

    ///<summary>
    ///A container for section geometry settings. Settings that control the type and settings used to display a section
    ///</summary>
    public class AcadSectionSettings 
	{
		public OdaX.AcadSectionSettings _i;
		internal AcadSectionSettings(object AcadSectionSettings_object) 
		{
			this._i = AcadSectionSettings_object as OdaX.AcadSectionSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object CurrentSectionType => this._i.CurrentSectionType;

		///<summary>
		///
		///</summary>
		public void Set_CurrentSectionType(OdaX.AcSectionType pVal) 
		{
			this._i.CurrentSectionType = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadSectionTypeSettings GetSectionTypeSettings(OdaX.AcSectionType secType) 
		{
			return new AcadSectionTypeSettings(this._i.GetSectionTypeSettings(secType));
		}
	}
}
