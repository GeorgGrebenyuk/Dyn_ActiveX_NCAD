namespace DynmdsUnitsLib 
{

	///<summary>
	///IMDSDataObject Interface
	///</summary>
	public class MDSDataObject 
	{
		public mdsUnitsLib.IMDSDataObject _i;
		internal MDSDataObject(object MDSDataObject_object) 
		{
			this._i = MDSDataObject_object as mdsUnitsLib.IMDSDataObject;
			if (this._i == null) throw new System.Exception("Invalid casting to IMDSDataObject");
		}

        /// <summary>
        /// Возвращает MDSDataObject от объекта, если это параметрический объект
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static MDSDataObject FromEntiy(dynamic AcadEntity)
        {
            MDSDataObject el = null;
            try
            {
                el = new MDSDataObject(AcadEntity._i);
            }
            catch { throw new System.Exception("Invalid casting to IMDSDataObject"); }
            return el;

        }

        ///<summary>
        ///property Element
        ///</summary>
        public Element Element => new Element(this._i.Element);

		///<summary>
		///property Element
		///</summary>
		public void Set_Element(Element pVal) 
		{
			this._i.Element = (mdsUnitsLib.Element)pVal._i;
		}
	}
}
