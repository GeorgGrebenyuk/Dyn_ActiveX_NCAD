﻿using DynNCXLib.GeometryWrapper;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDimension 
	{
		public OdaX.AcadDimension _i;
		internal AcadDimension(object AcadDimension_object) 
		{
			this._i = AcadDimension_object as OdaX.AcadDimension;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDimension(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadDimension;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///
        ///</summary>
        public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public Point TextPosition => Technical.PointByDoubleArray(this._i.TextPosition);

		///<summary>
		///
		///</summary>
		public void Set_TextPosition(Point textPos) 
		{
			this._i.TextPosition = Technical.PointByDynPoint(textPos);
		}

		///<summary>
		///
		///</summary>
		public double TextRotation => this._i.TextRotation;

		///<summary>
		///
		///</summary>
		public void Set_TextRotation(double rotAngle) 
		{
			this._i.TextRotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public string TextOverride => this._i.TextOverride;

		///<summary>
		///
		///</summary>
		public void Set_TextOverride(string bstrText) 
		{
			this._i.TextOverride = bstrText;
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_StyleName(string bstrName) 
		{
			this._i.StyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public object TextColor => this._i.TextColor;

		/////<summary>
		/////
		/////</summary>
		//public void Set_TextColor(object color) 
		//{
		//	this._i.TextColor = color;
		//}

		///<summary>
		///
		///</summary>
		public string DecimalSeparator => this._i.DecimalSeparator;

		///<summary>
		///
		///</summary>
		public void Set_DecimalSeparator(string character) 
		{
			this._i.DecimalSeparator = character;
		}

		///<summary>
		///
		///</summary>
		public double TextGap => this._i.TextGap;

		///<summary>
		///
		///</summary>
		public void Set_TextGap(double Offset) 
		{
			this._i.TextGap = Offset;
		}

		///<summary>
		///
		///</summary>
		public string TextPrefix => this._i.TextPrefix;

		///<summary>
		///
		///</summary>
		public void Set_TextPrefix(string prefix) 
		{
			this._i.TextPrefix = prefix;
		}

		///<summary>
		///
		///</summary>
		public string TextSuffix => this._i.TextSuffix;

		///<summary>
		///
		///</summary>
		public void Set_TextSuffix(string suffix) 
		{
			this._i.TextSuffix = suffix;
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double factor) 
		{
			this._i.ScaleFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public object VerticalTextPosition => this._i.VerticalTextPosition;

		///<summary>
		///
		///</summary>
		public void Set_VerticalTextPosition(OdaX.AcDimVerticalJustification Type) 
		{
			this._i.VerticalTextPosition = Type;
		}

		///<summary>
		///
		///</summary>
		public object TolerancePrecision => this._i.TolerancePrecision;

		///<summary>
		///
		///</summary>
		public void Set_TolerancePrecision(OdaX.AcDimPrecision precision) 
		{
			this._i.TolerancePrecision = precision;
		}

		///<summary>
		///
		///</summary>
		public double ToleranceHeightScale => this._i.ToleranceHeightScale;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceHeightScale(double scale) 
		{
			this._i.ToleranceHeightScale = scale;
		}

		///<summary>
		///
		///</summary>
		public double ToleranceLowerLimit => this._i.ToleranceLowerLimit;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceLowerLimit(double lower) 
		{
			this._i.ToleranceLowerLimit = lower;
		}

		///<summary>
		///
		///</summary>
		public object TextMovement => this._i.TextMovement;

		///<summary>
		///
		///</summary>
		public void Set_TextMovement(OdaX.AcDimTextMovement Move) 
		{
			this._i.TextMovement = Move;
		}

		///<summary>
		///
		///</summary>
		public object ToleranceDisplay => this._i.ToleranceDisplay;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceDisplay(OdaX.AcDimToleranceMethod method) 
		{
			this._i.ToleranceDisplay = method;
		}

		///<summary>
		///
		///</summary>
		public object ToleranceJustification => this._i.ToleranceJustification;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceJustification(OdaX.AcDimToleranceJustify method) 
		{
			this._i.ToleranceJustification = method;
		}

		///<summary>
		///
		///</summary>
		public double ToleranceUpperLimit => this._i.ToleranceUpperLimit;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceUpperLimit(double upper) 
		{
			this._i.ToleranceUpperLimit = upper;
		}

		///<summary>
		///
		///</summary>
		public string TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public void Set_TextStyle(string style) 
		{
			this._i.TextStyle = style;
		}

		///<summary>
		///
		///</summary>
		public double TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public void Set_TextHeight(double Height) 
		{
			this._i.TextHeight = Height;
		}

		///<summary>
		///
		///</summary>
		public bool SuppressLeadingZeros => this._i.SuppressLeadingZeros;

		///<summary>
		///
		///</summary>
		public void Set_SuppressLeadingZeros(bool bVal) 
		{
			this._i.SuppressLeadingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool SuppressTrailingZeros => this._i.SuppressTrailingZeros;

		///<summary>
		///
		///</summary>
		public void Set_SuppressTrailingZeros(bool bVal) 
		{
			this._i.SuppressTrailingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool ToleranceSuppressLeadingZeros => this._i.ToleranceSuppressLeadingZeros;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceSuppressLeadingZeros(bool bVal) 
		{
			this._i.ToleranceSuppressLeadingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool ToleranceSuppressTrailingZeros => this._i.ToleranceSuppressTrailingZeros;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceSuppressTrailingZeros(bool bVal) 
		{
			this._i.ToleranceSuppressTrailingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool TextFill => this._i.TextFill;

		///<summary>
		///
		///</summary>
		public void Set_TextFill(bool bVal) 
		{
			this._i.TextFill = bVal;
		}

		///<summary>
		///
		///</summary>
		public object TextFillColor => this._i.TextFillColor;

		/////<summary>
		/////
		/////</summary>
		//public void Set_TextFillColor(dynamic color) 
		//{
		//	this._i.TextFillColor = color;
		//}
	}
}
