using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTableStyle 
	{
		public OdaX.AcadTableStyle _i;
		internal AcadTableStyle(object AcadTableStyle_object) 
		{
			this._i = AcadTableStyle_object as OdaX.AcadTableStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrValue) 
		{
			this._i.Name = bstrValue;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string bstr) 
		{
			this._i.Description = bstr;
		}

		///<summary>
		///
		///</summary>
		public int BitFlags => this._i.BitFlags;

		///<summary>
		///
		///</summary>
		public void Set_BitFlags(dynamic bitFlag) 
		{
			this._i.BitFlags = bitFlag;
		}

		///<summary>
		///
		///</summary>
		public object FlowDirection => this._i.FlowDirection;

		///<summary>
		///
		///</summary>
		public void Set_FlowDirection(OdaX.AcTableDirection pFlow) 
		{
			this._i.FlowDirection = pFlow;
		}

		///<summary>
		///
		///</summary>
		public double HorzCellMargin => this._i.HorzCellMargin;

		///<summary>
		///
		///</summary>
		public void Set_HorzCellMargin(double dHorzCellMargin) 
		{
			this._i.HorzCellMargin = dHorzCellMargin;
		}

		///<summary>
		///
		///</summary>
		public double VertCellMargin => this._i.VertCellMargin;

		///<summary>
		///
		///</summary>
		public void Set_VertCellMargin(double dVertCellMargin) 
		{
			this._i.VertCellMargin = dVertCellMargin;
		}

		///<summary>
		///
		///</summary>
		public bool TitleSuppressed => this._i.TitleSuppressed;

		///<summary>
		///
		///</summary>
		public void Set_TitleSuppressed(bool bValue) 
		{
			this._i.TitleSuppressed = bValue;
		}

		///<summary>
		///
		///</summary>
		public bool HeaderSuppressed => this._i.HeaderSuppressed;

		///<summary>
		///
		///</summary>
		public void Set_HeaderSuppressed(bool bValue) 
		{
			this._i.HeaderSuppressed = bValue;
		}

		///<summary>
		///
		///</summary>
		public string GetTextStyle(OdaX.AcRowType rowType) 
		{
			return this._i.GetTextStyle(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetTextStyle(int rowTypes,string bstrName) 
		{
			this._i.SetTextStyle(rowTypes,bstrName);
		}

		///<summary>
		///
		///</summary>
		public double GetTextHeight(OdaX.AcRowType rowType) 
		{
			return this._i.GetTextHeight(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetTextHeight(int rowTypes,double TextHeight) 
		{
			this._i.SetTextHeight(rowTypes,TextHeight);
		}

		///<summary>
		///
		///</summary>
		public object GetAlignment(OdaX.AcRowType rowType) 
		{
			return this._i.GetAlignment(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetAlignment(int rowTypes,OdaX.AcCellAlignment cellAlignment) 
		{
			this._i.SetAlignment(rowTypes,cellAlignment);
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor GetColor(OdaX.AcRowType rowType) 
		{
			return new AcadAcCmColor(this._i.GetColor(rowType));
		}

		///<summary>
		///
		///</summary>
		public void SetColor(int rowTypes,dynamic pColor) 
		{
			this._i.SetColor(rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor GetBackgroundColor(OdaX.AcRowType rowType) 
		{
			return new AcadAcCmColor(this._i.GetBackgroundColor(rowType));
		}

		///<summary>
		///
		///</summary>
		public void SetBackgroundColor(int rowTypes,dynamic pColor) 
		{
			this._i.SetBackgroundColor(rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public bool GetBackgroundColorNone(OdaX.AcRowType rowType) 
		{
			return this._i.GetBackgroundColorNone(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetBackgroundColorNone(int rowTypes,bool bValue) 
		{
			this._i.SetBackgroundColorNone(rowTypes,bValue);
		}

		///<summary>
		///
		///</summary>
		public object GetGridLineWeight(OdaX.AcGridLineType gridLineType,
			OdaX.AcRowType rowType) 
		{
			return this._i.GetGridLineWeight(gridLineType,rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridLineWeight(int gridLineTypes,int rowTypes,dynamic Lineweight) 
		{
			this._i.SetGridLineWeight(gridLineTypes,rowTypes,Lineweight);
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor GetGridColor(OdaX.AcGridLineType gridLineType,OdaX.AcRowType rowType) 
		{
			return new AcadAcCmColor(this._i.GetGridColor(gridLineType,rowType));
		}

		///<summary>
		///
		///</summary>
		public void SetGridColor(int gridLineTypes,int rowTypes,dynamic pColor) 
		{
			this._i.SetGridColor(gridLineTypes,rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public bool GetGridVisibility(OdaX.AcGridLineType gridLineType,OdaX.AcRowType rowType) 
		{
			return this._i.GetGridVisibility(gridLineType,rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridVisibility(int gridLineTypes,int rowTypes,bool bValue) 
		{
			this._i.SetGridVisibility(gridLineTypes,rowTypes,bValue);
		}

		///<summary>
		///
		///</summary>
		public List<object> GetDataType(OdaX.AcRowType rowType) 
		{
			OdaX.AcValueDataType pDataType;
			OdaX.AcValueUnitType pUnitType;

            this._i.GetDataType(rowType,out pDataType,out pUnitType);
			return new List<object> { pDataType,pUnitType};
		}

		///<summary>
		///
		///</summary>
		public void SetDataType(int rowTypes,OdaX.AcValueDataType nDataType,OdaX.AcValueUnitType nUnitType) 
		{
			this._i.SetDataType(rowTypes,nDataType,nUnitType);
		}

		///<summary>
		///
		///</summary>
		public string GetFormat(OdaX.AcRowType rowType) 
		{
			return this._i.GetFormat(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetFormat(int rowTypes,string val) 
		{
			this._i.SetFormat(rowTypes,val);
		}

		///<summary>
		///
		///</summary>
		public void CreateCellStyle(string bstrCellStyle) 
		{
			this._i.CreateCellStyle(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void CreateCellStyleFromStyle(string bstrCellStyle,string bstrSourceCellStyle) 
		{
			this._i.CreateCellStyleFromStyle(bstrCellStyle,bstrSourceCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void RenameCellStyle(string bstrOldName,string bstrNewName) 
		{
			this._i.RenameCellStyle(bstrOldName,bstrNewName);
		}

		///<summary>
		///
		///</summary>
		public void DeleteCellStyle(string bstrCellStyle) 
		{
			this._i.DeleteCellStyle(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public string GetUniqueCellStyleName(string pszBaseName) 
		{
			return this._i.GetUniqueCellStyleName(pszBaseName);
		}

		///<summary>
		///
		///</summary>
		public bool GetIsCellStyleInUse(string pszCellStyle) 
		{
			return this._i.GetIsCellStyleInUse(pszCellStyle);
		}

		///<summary>
		///
		///</summary>
		public int NumCellStyles => this._i.NumCellStyles;

		/////<summary>
		/////
		/////</summary>
		//public void GetCellStyles(object cellStylesArray) 
		//{
		//	this._i.GetCellStyles(cellStylesArray);
		//}

		///<summary>
		///
		///</summary>
		public long GetTextStyleId(string bstrCellStyle) 
		{
			return this._i.GetTextStyleId(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void SetTextStyleId(string bstrCellStyle, long val) 
		{
			this._i.SetTextStyleId(bstrCellStyle,val);
		}

	

		///<summary>
		///
		///</summary>
		public int GetCellClass(string bstrCellStyle) 
		{
			return this._i.GetCellClass(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void SetCellClass(string bstrCellStyle,int cellClass) 
		{
			this._i.SetCellClass(bstrCellStyle,cellClass);
		}

		///<summary>
		///
		///</summary>
		public double GetRotation(string bstrCellStyle) 
		{
			return this._i.GetRotation(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void SetRotation(string bstrCellStyle,double Rotation) 
		{
			this._i.SetRotation(bstrCellStyle,Rotation);
		}

		///<summary>
		///
		///</summary>
		public bool GetIsMergeAllEnabled(string bstrCellStyle) 
		{
			return this._i.GetIsMergeAllEnabled(bstrCellStyle);
		}

		///<summary>
		///
		///</summary>
		public void EnableMergeAll(string bstrCellStyle,bool bEnable) 
		{
			this._i.EnableMergeAll(bstrCellStyle,bEnable);
		}

		///<summary>
		///
		///</summary>
		public object GetGridLineWeight2(string bstrCellStyle,OdaX.AcGridLineType gridLineType) 
		{
			return this._i.GetGridLineWeight2(bstrCellStyle,gridLineType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridLineWeight2(string bstrCellStyle,OdaX.AcGridLineType gridLineTypes,dynamic Lineweight) 
		{
			this._i.SetGridLineWeight2(bstrCellStyle,gridLineTypes,Lineweight);
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor GetGridColor2(string bstrCellStyle,OdaX.AcGridLineType gridLineType) 
		{
			return new AcadAcCmColor(this._i.GetGridColor2(bstrCellStyle,gridLineType));
		}

		///<summary>
		///
		///</summary>
		public void SetGridColor2(string bstrCellStyle,OdaX.AcGridLineType gridLineTypes,dynamic pColor) 
		{
			this._i.SetGridColor2(bstrCellStyle,gridLineTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public bool GetGridVisibility2(string bstrCellStyle,OdaX.AcGridLineType gridLineType) 
		{
			return this._i.GetGridVisibility2(bstrCellStyle,gridLineType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridVisibility2(string bstrCellStyle,OdaX.AcGridLineType gridLineTypes,bool bValue) 
		{
			this._i.SetGridVisibility2(bstrCellStyle,gridLineTypes,bValue);
		}

		///<summary>
		///
		///</summary>
		public long TemplateId => this._i.TemplateId;

		///<summary>
		///
		///</summary>
		public void Set_TemplateId(long pVal) 
		{
			this._i.TemplateId = pVal;
		}

		///<summary>
		///
		///</summary>
		public void SetTemplateId(long val, OdaX.AcMergeCellStyleOption AcMergeCellStyleOption) 
		{
			this._i.SetTemplateId(val, AcMergeCellStyleOption);
		}
	}
}
