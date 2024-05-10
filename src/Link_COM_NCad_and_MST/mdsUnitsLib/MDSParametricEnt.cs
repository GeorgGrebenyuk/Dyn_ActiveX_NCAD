namespace DynmdsUnitsLib 
{

	///<summary>
	///IMDSParametricEnt Interface
	///</summary>
	public class MDSParametricEnt 
	{
		public mdsUnitsLib.IMDSParametricEnt _i;
		internal MDSParametricEnt(object MDSParametricEnt_object) 
		{
			this._i = MDSParametricEnt_object as mdsUnitsLib.IMDSParametricEnt;
			if (this._i == null) throw new System.Exception("Invalid casting to IMDSParametricEnt");
		}

        /// <summary>
        /// Возвращает MDSParametricEnt от объекта, если это параметрический объект
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static MDSParametricEnt FromEntiy(dynamic AcadEntity)
        {
            MDSParametricEnt el = null;
            try
            {
                el = new MDSParametricEnt(AcadEntity._i);
            }
            catch { throw new System.Exception("Invalid casting to MDSParametricEnt"); }
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

		///<summary>
		///property ParametricData
		///</summary>
		public Element ParametricData => new Element(this._i.ParametricData);

		///<summary>
		///property ParametricData
		///</summary>
		public void Set_ParametricData(Element pVal)
		{
			this._i.ParametricData = (mdsUnitsLib.Element)pVal._i;
		}

		///<summary>
		///property UnitPosition
		///</summary>
		//public object UnitPosition => this._i.UnitPosition;

		///<summary>
		///property UnitPosition
		///</summary>
		public void Set_UnitPosition(object pVal)
		{
			this._i.UnitPosition = pVal;
		}

		///<summary>
		///property UnitName
		///</summary>
		public string UnitName => this._i.UnitName;

		///<summary>
		///property UnitName
		///</summary>
		public void Set_UnitName(string pVal)
		{
			this._i.UnitName = pVal;
		}

		///<summary>
		///property NameWS
		///</summary>
		public string NameWS => this._i.NameWS;

		///<summary>
		///property NameWS
		///</summary>
		public void Set_NameWS(string pVal)
		{
			this._i.NameWS = pVal;
		}

		///<summary>
		///property AxisZLockWS
		///</summary>
		public bool AxisZLockWS => this._i.AxisZLockWS;

		///<summary>
		///property AxisZLockWS
		///</summary>
		public void Set_AxisZLockWS(bool pVal)
		{
			this._i.AxisZLockWS = pVal;
		}

		///<summary>
		///property ProjectionOnXYLockWS
		///</summary>
		public bool ProjectionOnXYLockWS => this._i.ProjectionOnXYLockWS;

		///<summary>
		///property ProjectionOnXYLockWS
		///</summary>
		public void Set_ProjectionOnXYLockWS(bool pVal)
		{
			this._i.ProjectionOnXYLockWS = pVal;
		}

		///<summary>
		///property Nodes
		///</summary>
		public MDSNodes Nodes => new MDSNodes(this._i.Nodes);

		///<summary>
		///property Part_Name
		///</summary>
		public string Part_Name => this._i.Part_Name;

		///<summary>
		///property Part_Name
		///</summary>
		public void Set_Part_Name(string pVal)
		{
			this._i.Part_Name = pVal;
		}

		///<summary>
		///property Part_Tag
		///</summary>
		public string Part_Tag => this._i.Part_Tag;

		///<summary>
		///property Part_Tag
		///</summary>
		public void Set_Part_Tag(string pVal)
		{
			this._i.Part_Tag = pVal;
		}

		///<summary>
		///property Part_Manufacturer
		///</summary>
		public string Part_Manufacturer => this._i.Part_Manufacturer;

		///<summary>
		///property Part_Manufacturer
		///</summary>
		public void Set_Part_Manufacturer(string pVal)
		{
			this._i.Part_Manufacturer = pVal;
		}

		///<summary>
		///property Part_Standard
		///</summary>
		public string Part_Standard => this._i.Part_Standard;

		///<summary>
		///property Part_Standard
		///</summary>
		public void Set_Part_Standard(string pVal)
		{
			this._i.Part_Standard = pVal;
		}

		///<summary>
		///property Part_Refdrawing
		///</summary>
		public string Part_Refdrawing => this._i.Part_Refdrawing;

		///<summary>
		///property Part_Refdrawing
		///</summary>
		public void Set_Part_Refdrawing(string pVal)
		{
			this._i.Part_Refdrawing = pVal;
		}

		///<summary>
		///property Part_Material
		///</summary>
		public string Part_Material => this._i.Part_Material;

		///<summary>
		///property Part_Material
		///</summary>
		public void Set_Part_Material(string pVal)
		{
			this._i.Part_Material = pVal;
		}

		///<summary>
		///property Part_Material_Standard
		///</summary>
		public string Part_Material_Standard => this._i.Part_Material_Standard;

		///<summary>
		///property Part_Material_Standard
		///</summary>
		public void Set_Part_Material_Standard(string pVal)
		{
			this._i.Part_Material_Standard = pVal;
		}

		///<summary>
		///property Part_Weight
		///</summary>
		public string Part_Weight => this._i.Part_Weight;

		///<summary>
		///property Part_Weight
		///</summary>
		public void Set_Part_Weight(string pVal)
		{
			this._i.Part_Weight = pVal;
		}

		///<summary>
		///property Part_Comment
		///</summary>
		public string Part_Comment => this._i.Part_Comment;

		///<summary>
		///property Part_Comment
		///</summary>
		public void Set_Part_Comment(string pVal)
		{
			this._i.Part_Comment = pVal;
		}

		///<summary>
		///property Part_Group
		///</summary>
		public string Part_Group => this._i.Part_Group;

		///<summary>
		///property Part_Group
		///</summary>
		public void Set_Part_Group(string pVal)
		{
			this._i.Part_Group = pVal;
		}

		///<summary>
		///property Part_Type
		///</summary>
		public string Part_Type => this._i.Part_Type;

		///<summary>
		///property Part_Type
		///</summary>
		public void Set_Part_Type(string pVal)
		{
			this._i.Part_Type = pVal;
		}

		///<summary>
		///property Part_Reference
		///</summary>
		public string Part_Reference => this._i.Part_Reference;

		///<summary>
		///property Part_Reference
		///</summary>
		public void Set_Part_Reference(string pVal)
		{
			this._i.Part_Reference = pVal;
		}

		///<summary>
		///property Part_Weight_Netto
		///</summary>
		public string Part_Weight_Netto => this._i.Part_Weight_Netto;

		///<summary>
		///property Part_Weight_Netto
		///</summary>
		public void Set_Part_Weight_Netto(string pVal)
		{
			this._i.Part_Weight_Netto = pVal;
		}

		///<summary>
		///property Part_Weight_Bruto
		///</summary>
		public string Part_Weight_Bruto => this._i.Part_Weight_Bruto;

		///<summary>
		///property Part_Weight_Bruto
		///</summary>
		public void Set_Part_Weight_Bruto(string pVal)
		{
			this._i.Part_Weight_Bruto = pVal;
		}

		///<summary>
		///property Explication_Include
		///</summary>
		public long Explication_Include => this._i.Explication_Include;

		///<summary>
		///property Explication_Include
		///</summary>
		public void Set_Explication_Include(int pVal)
		{
			this._i.Explication_Include = pVal;
		}

		///<summary>
		///property Explication_Number
		///</summary>
		public string Explication_Number => this._i.Explication_Number;

		///<summary>
		///property Explication_Number
		///</summary>
		public void Set_Explication_Number(string pVal)
		{
			this._i.Explication_Number = pVal;
		}

		///<summary>
		///property Explication_Group
		///</summary>
		public string Explication_Group => this._i.Explication_Group;

		///<summary>
		///property Explication_Group
		///</summary>
		public void Set_Explication_Group(string pVal)
		{
			this._i.Explication_Group = pVal;
		}

		///<summary>
		///property Explication_Comment
		///</summary>
		public string Explication_Comment => this._i.Explication_Comment;

		///<summary>
		///property Explication_Comment
		///</summary>
		public void Set_Explication_Comment(string pVal)
		{
			this._i.Explication_Comment = pVal;
		}

		///<summary>
		///property Bom_Include
		///</summary>
		public long Bom_Include => this._i.Bom_Include;

		///<summary>
		///property Bom_Include
		///</summary>
		public void Set_Bom_Include(int pVal)
		{
			this._i.Bom_Include = pVal;
		}

		///<summary>
		///property Bom_Number
		///</summary>
		public string Bom_Number => this._i.Bom_Number;

		///<summary>
		///property Bom_Number
		///</summary>
		public void Set_Bom_Number(string pVal)
		{
			this._i.Bom_Number = pVal;
		}

		///<summary>
		///property Bom_Group
		///</summary>
		public string Bom_Group => this._i.Bom_Group;

		///<summary>
		///property Bom_Group
		///</summary>
		public void Set_Bom_Group(string pVal)
		{
			this._i.Bom_Group = pVal;
		}

		///<summary>
		///property Bom_Qty
		///</summary>
		public string Bom_Qty => this._i.Bom_Qty;

		///<summary>
		///property Bom_Qty
		///</summary>
		public void Set_Bom_Qty(string pVal)
		{
			this._i.Bom_Qty = pVal;
		}

		///<summary>
		///property Bom_Comment
		///</summary>
		public string Bom_Comment => this._i.Bom_Comment;

		///<summary>
		///property Bom_Comment
		///</summary>
		public void Set_Bom_Comment(string pVal)
		{
			this._i.Bom_Comment = pVal;
		}

		///<summary>
		///method UpdateGraphics
		///</summary>
		public void UpdateGraphics()
		{
			this._i.UpdateGraphics();
		}

		///<summary>
		///Angle in X0Y
		///</summary>
		public double XYAngle => this._i.XYAngle;

		///<summary>
		///Angle in X0Y
		///</summary>
		public void Set_XYAngle(double pfVal)
		{
			this._i.XYAngle = pfVal;
		}

		///<summary>
		///method GetArea
		///</summary>
		public double GetArea(object Element, object bodyOptions)
		{
			return ((dynamic)this._i).GetArea(Element, bodyOptions);
		}

		///<summary>
		///method GetVolume
		///</summary>
		public double GetVolume(object Element, object bodyOptions)
		{
			return ((dynamic)this._i).GetVolume(Element, bodyOptions);
		}
	}
}
