namespace DynNCXLib 
{

    ///<summary>
    /// A surface entity. This object provides access to surfaces in AutoCAD. It lets you manipulate properties of the surface. You cannot create a surface entity via ActiveX
    ///</summary>
    public class AcadSurface 
	{
		public OdaX.AcadSurface _i;
		internal AcadSurface(object AcadSurface_object) 
		{
			this._i = AcadSurface_object as OdaX.AcadSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadSurface(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadSurface;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Indicates the type of surface
        ///</summary>
        public string SurfaceType => this._i.SurfaceType;

        ///<summary>
        /// Specifies the number of U isolines that are displayed
        ///</summary>
        public int UIsolineDensity => this._i.UIsolineDensity;

        ///<summary>
        /// Specifies the number of U isolines that are displayed
        ///</summary>
        public void Set_UIsolineDensity(int density) 
		{
			this._i.UIsolineDensity = density;
		}

        ///<summary>
        /// Specifies the number of V isolines that are displayed
        ///</summary>
        public int VIsolineDensity => this._i.VIsolineDensity;

        ///<summary>
        /// Specifies the number of V isolines that are displayed
        ///</summary>
        public void Set_VIsolineDensity(int density) 
		{
			this._i.VIsolineDensity = density;
		}

        
	}
}
