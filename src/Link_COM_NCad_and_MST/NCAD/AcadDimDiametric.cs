﻿using DynNCXLib.GeometryWrapper;

namespace DynNCXLib 
{

    ///<summary>
    ///A dimension measuring the diameter of a circle or arc
    ///</summary>
    public class AcadDimDiametric 
	{
		public OdaX.AcadDimDiametric _i;
		internal AcadDimDiametric(object AcadDimDiametric_object) 
		{
			this._i = AcadDimDiametric_object as OdaX.AcadDimDiametric;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDimDiametric(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadDimDiametric;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
		/// Creates a diametric dimension for a circle or arc given the two points on the diameter and the length of the leader line
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="ChordPoint">The 3D WCS coordinates specifying the first diameter point on the circle or arc</param>
		/// <param name="FarChordPoint">The 3D WCS coordinates specifying the second diameter point on the circle or arc</param>
		/// <param name="LeaderLength">The positive value representing the length from the ChordPoint to the annotation text or dogleg</param>
        public AcadDimDiametric(AcadBlock AcadBlock, Point ChordPoint, Point FarChordPoint, double LeaderLength)
        {
            this._i =  AcadBlock._i.AddDimDiametric(Technical.PointByDynPoint(ChordPoint),
                Technical.PointByDynPoint(FarChordPoint), LeaderLength);
        }

  //      ///<summary>
  //      ///
  //      ///</summary>
  //      public void Set_LeaderLength(double rhs) 
		//{
		//	this._i.LeaderLength = rhs;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltUnits => this._i.AltUnits;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltUnits(bool bAlternate) 
		//{
		//	this._i.AltUnits = bAlternate;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object AltUnitsPrecision => this._i.AltUnitsPrecision;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltUnitsPrecision(OdaX.AcDimPrecision precision) 
		//{
		//	this._i.AltUnitsPrecision = precision;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double AltUnitsScale => this._i.AltUnitsScale;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltUnitsScale(double scale) 
		//{
		//	this._i.AltUnitsScale = scale;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double AltRoundDistance => this._i.AltRoundDistance;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltRoundDistance(double Distance) 
		//{
		//	this._i.AltRoundDistance = Distance;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object AltTolerancePrecision => this._i.AltTolerancePrecision;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltTolerancePrecision(OdaX.AcDimPrecision Distance) 
		//{
		//	this._i.AltTolerancePrecision = Distance;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object AltUnitsFormat => this._i.AltUnitsFormat;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltUnitsFormat(OdaX.AcDimUnits Units) 
		//{
		//	this._i.AltUnitsFormat = Units;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string AltTextPrefix => this._i.AltTextPrefix;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltTextPrefix(string prefix) 
		//{
		//	this._i.AltTextPrefix = prefix;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string AltTextSuffix => this._i.AltTextSuffix;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltTextSuffix(string prefix) 
		//{
		//	this._i.AltTextSuffix = prefix;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object DimensionLineColor => this._i.DimensionLineColor;

		///////<summary>
		///////
		///////</summary>
		////public void Set_DimensionLineColor(dynamic Type) 
		////{
		////	this._i.DimensionLineColor = Type;
		////}

		/////<summary>
		/////
		/////</summary>
		//public object PrimaryUnitsPrecision => this._i.PrimaryUnitsPrecision;

		/////<summary>
		/////
		/////</summary>
		//public void Set_PrimaryUnitsPrecision(OdaX.AcDimPrecision Prec) 
		//{
		//	this._i.PrimaryUnitsPrecision = Prec;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object FractionFormat => this._i.FractionFormat;

		/////<summary>
		/////
		/////</summary>
		//public void Set_FractionFormat(OdaX.AcDimFractionType Type) 
		//{
		//	this._i.FractionFormat = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object Fit => this._i.Fit;

		/////<summary>
		/////
		/////</summary>
		//public void Set_Fit(OdaX.AcDimFit fittype) 
		//{
		//	this._i.Fit = fittype;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double LinearScaleFactor => this._i.LinearScaleFactor;

		/////<summary>
		/////
		/////</summary>
		//public void Set_LinearScaleFactor(dynamic Type) 
		//{
		//	this._i.LinearScaleFactor = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object UnitsFormat => this._i.UnitsFormat;

		/////<summary>
		/////
		/////</summary>
		//public void Set_UnitsFormat(OdaX.AcDimLUnits format) 
		//{
		//	this._i.UnitsFormat = format;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double RoundDistance => this._i.RoundDistance;

		/////<summary>
		/////
		/////</summary>
		//public void Set_RoundDistance(double Distance) 
		//{
		//	this._i.RoundDistance = Distance;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool DimLine1Suppress => this._i.DimLine1Suppress;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimLine1Suppress(bool bSuppress) 
		//{
		//	this._i.DimLine1Suppress = bSuppress;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool DimLine2Suppress => this._i.DimLine2Suppress;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimLine2Suppress(bool bSuppress) 
		//{
		//	this._i.DimLine2Suppress = bSuppress;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool TextInsideAlign => this._i.TextInsideAlign;

		/////<summary>
		/////
		/////</summary>
		//public void Set_TextInsideAlign(bool bInside) 
		//{
		//	this._i.TextInsideAlign = bInside;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool TextInside => this._i.TextInside;

		/////<summary>
		/////
		/////</summary>
		//public void Set_TextInside(bool bInside) 
		//{
		//	this._i.TextInside = bInside;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool ForceLineInside => this._i.ForceLineInside;

		/////<summary>
		/////
		/////</summary>
		//public void Set_ForceLineInside(bool bInside) 
		//{
		//	this._i.ForceLineInside = bInside;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool TextOutsideAlign => this._i.TextOutsideAlign;

		/////<summary>
		/////
		/////</summary>
		//public void Set_TextOutsideAlign(bool bInside) 
		//{
		//	this._i.TextOutsideAlign = bInside;
		//}

		/////<summary>
		/////
		/////</summary>
		//public dynamic CenterType => this._i.CenterType;

		/////<summary>
		/////
		/////</summary>
		//public void Set_CenterType(OdaX.AcDimCenterType Type) 
		//{
		//	this._i.CenterType = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double CenterMarkSize => this._i.CenterMarkSize;

		/////<summary>
		/////
		/////</summary>
		//public void Set_CenterMarkSize(double Type) 
		//{
		//	this._i.CenterMarkSize = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltSuppressLeadingZeros => this._i.AltSuppressLeadingZeros;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltSuppressLeadingZeros(bool bVal) 
		//{
		//	this._i.AltSuppressLeadingZeros = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltSuppressTrailingZeros => this._i.AltSuppressTrailingZeros;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltSuppressTrailingZeros(bool bVal) 
		//{
		//	this._i.AltSuppressTrailingZeros = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltSuppressZeroFeet => this._i.AltSuppressZeroFeet;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltSuppressZeroFeet(bool bVal) 
		//{
		//	this._i.AltSuppressZeroFeet = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltSuppressZeroInches => this._i.AltSuppressZeroInches;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltSuppressZeroInches(bool bVal) 
		//{
		//	this._i.AltSuppressZeroInches = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltToleranceSuppressLeadingZeros => this._i.AltToleranceSuppressLeadingZeros;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltToleranceSuppressLeadingZeros(bool bVal) 
		//{
		//	this._i.AltToleranceSuppressLeadingZeros = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltToleranceSuppressTrailingZeros => this._i.AltToleranceSuppressTrailingZeros;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltToleranceSuppressTrailingZeros(bool bVal) 
		//{
		//	this._i.AltToleranceSuppressTrailingZeros = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltToleranceSuppressZeroFeet => this._i.AltToleranceSuppressZeroFeet;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltToleranceSuppressZeroFeet(bool bVal) 
		//{
		//	this._i.AltToleranceSuppressZeroFeet = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool AltToleranceSuppressZeroInches => this._i.AltToleranceSuppressZeroInches;

		/////<summary>
		/////
		/////</summary>
		//public void Set_AltToleranceSuppressZeroInches(bool bVal) 
		//{
		//	this._i.AltToleranceSuppressZeroInches = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool SuppressZeroFeet => this._i.SuppressZeroFeet;

		/////<summary>
		/////
		/////</summary>
		//public void Set_SuppressZeroFeet(bool bVal) 
		//{
		//	this._i.SuppressZeroFeet = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool SuppressZeroInches => this._i.SuppressZeroInches;

		/////<summary>
		/////
		/////</summary>
		//public void Set_SuppressZeroInches(bool bVal) 
		//{
		//	this._i.SuppressZeroInches = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool ToleranceSuppressZeroFeet => this._i.ToleranceSuppressZeroFeet;

		/////<summary>
		/////
		/////</summary>
		//public void Set_ToleranceSuppressZeroFeet(bool bVal) 
		//{
		//	this._i.ToleranceSuppressZeroFeet = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool ToleranceSuppressZeroInches => this._i.ToleranceSuppressZeroInches;

		/////<summary>
		/////
		/////</summary>
		//public void Set_ToleranceSuppressZeroInches(bool bVal) 
		//{
		//	this._i.ToleranceSuppressZeroInches = bVal;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object DimensionLineWeight => this._i.DimensionLineWeight;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimensionLineWeight(dynamic weight) 
		//{
		//	this._i.DimensionLineWeight = weight;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double ArrowheadSize => this._i.ArrowheadSize;

		/////<summary>
		/////
		/////</summary>
		//public void Set_ArrowheadSize(double size) 
		//{
		//	this._i.ArrowheadSize = size;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object Arrowhead1Type => this._i.Arrowhead1Type;

		/////<summary>
		/////
		/////</summary>
		//public void Set_Arrowhead1Type(OdaX.AcDimArrowheadType Type) 
		//{
		//	this._i.Arrowhead1Type = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public object Arrowhead2Type => this._i.Arrowhead2Type;

		/////<summary>
		/////
		/////</summary>
		//public void Set_Arrowhead2Type(OdaX.AcDimArrowheadType Type) 
		//{
		//	this._i.Arrowhead2Type = Type;
		//}

		/////<summary>
		/////
		/////</summary>
		//public double Measurement => this._i.Measurement;

		/////<summary>
		/////
		/////</summary>
		//public string Arrowhead1Block => this._i.Arrowhead1Block;

		/////<summary>
		/////
		/////</summary>
		//public void Set_Arrowhead1Block(string BlockName) 
		//{
		//	this._i.Arrowhead1Block = BlockName;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string Arrowhead2Block => this._i.Arrowhead2Block;

		/////<summary>
		/////
		/////</summary>
		//public void Set_Arrowhead2Block(string BlockName) 
		//{
		//	this._i.Arrowhead2Block = BlockName;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string DimensionLinetype => this._i.DimensionLinetype;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimensionLinetype(string Linetype) 
		//{
		//	this._i.DimensionLinetype = Linetype;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool DimConstrForm => this._i.DimConstrForm;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrForm(bool bIsDynamic) 
		//{
		//	this._i.DimConstrForm = bIsDynamic;
		//}

		/////<summary>
		/////
		/////</summary>
		//public bool DimConstrReference => this._i.DimConstrReference;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrReference(bool bIsReference) 
		//{
		//	this._i.DimConstrReference = bIsReference;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string DimConstrName => this._i.DimConstrName;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrName(string bstrName) 
		//{
		//	this._i.DimConstrName = bstrName;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string DimConstrExpression => this._i.DimConstrExpression;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrExpression(string bstrExpression) 
		//{
		//	this._i.DimConstrExpression = bstrExpression;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string DimConstrValue => this._i.DimConstrValue;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrValue(string Value) 
		//{
		//	this._i.DimConstrValue = Value;
		//}

		/////<summary>
		/////
		/////</summary>
		//public string DimConstrDesc => this._i.DimConstrDesc;

		/////<summary>
		/////
		/////</summary>
		//public void Set_DimConstrDesc(string bstrDescription) 
		//{
		//	this._i.DimConstrDesc = bstrDescription;
		//}
	}
}
