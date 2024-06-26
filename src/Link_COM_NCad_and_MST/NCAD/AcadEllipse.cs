﻿using DynNCXLib.GeometryWrapper;
using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadEllipse 
	{
		public OdaX.AcadEllipse _i;
		internal AcadEllipse(object AcadEllipse_object) 
		{
			this._i = AcadEllipse_object as OdaX.AcadEllipse;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadEllipse(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadEllipse;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///Create new Ellipse
        ///</summary>
        public AcadEllipse (AcadBlock AcadBlock, Point Center, Point MajorAxis, double RadiusRatio)
        {
            this._i = AcadBlock._i.AddEllipse(Technical.PointByDynPoint(Center, false), 
				Technical.PointByDynPoint(MajorAxis, false), RadiusRatio);
        }

        ///<summary>
        ///
        ///</summary>
        public Point StartPoint => Technical.PointByDoubleArray(this._i.StartPoint);

		///<summary>
		///
		///</summary>
		public Point Center => Technical.PointByDoubleArray(this._i.Center);

		///<summary>
		///
		///</summary>
		public void Set_Center(Point Center) 
		{
			this._i.Center = Technical.PointByDynPoint(Center);
		}

		///<summary>
		///
		///</summary>
		public Point EndPoint => Technical.PointByDoubleArray(this._i.EndPoint);

		///<summary>
		///
		///</summary>
		public double MajorRadius => this._i.MajorRadius;

		///<summary>
		///
		///</summary>
		public void Set_MajorRadius(double MajorRadius) 
		{
			this._i.MajorRadius = MajorRadius;
		}

		///<summary>
		///
		///</summary>
		public double MinorRadius => this._i.MinorRadius;

		///<summary>
		///
		///</summary>
		public void Set_MinorRadius(double MinorRadius) 
		{
			this._i.MinorRadius = MinorRadius;
		}

		///<summary>
		///
		///</summary>
		public double RadiusRatio => this._i.RadiusRatio;

		///<summary>
		///
		///</summary>
		public void Set_RadiusRatio(double RadiusRatio) 
		{
			this._i.RadiusRatio = RadiusRatio;
		}

		///<summary>
		///
		///</summary>
		public dynamic StartAngle => this._i.StartAngle;

		///<summary>
		///
		///</summary>
		public void Set_StartAngle(dynamic StartAngle) 
		{
			this._i.StartAngle = StartAngle;
		}

		///<summary>
		///
		///</summary>
		public dynamic EndAngle => this._i.EndAngle;

		///<summary>
		///
		///</summary>
		public void Set_EndAngle(dynamic EndAngle) 
		{
			this._i.EndAngle = EndAngle;
		}

		///<summary>
		///
		///</summary>
		public double StartParameter => this._i.StartParameter;

		///<summary>
		///
		///</summary>
		public void Set_StartParameter(double StartParameter) 
		{
			this._i.StartParameter = StartParameter;
		}

		///<summary>
		///
		///</summary>
		public double EndParameter => this._i.EndParameter;

		///<summary>
		///
		///</summary>
		public void Set_EndParameter(double EndParameter) 
		{
			this._i.EndParameter = EndParameter;
		}

		///<summary>
		///
		///</summary>
		public object MajorAxis => this._i.MajorAxis;

		///<summary>
		///
		///</summary>
		public void Set_MajorAxis(object MajorAxis) 
		{
			this._i.MajorAxis = MajorAxis;
		}

		///<summary>
		///
		///</summary>
		public object MinorAxis => this._i.MinorAxis;

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
        public double Area => this._i.Area;

        /// <summary>
        /// Creates a new object at a specified offset distance from an existing object
        /// </summary>
        /// <param name="Distance">The distance to offset the object. The offset can be a positive or negative number, but it cannot equal zero. If the offset is negative, this is interpreted as being an offset to make a "smaller" curve (that is, for an arc it would offset to a radius that is "Distance less" than the starting curve's radius). If "smaller" has no meaning, then it would offset in the direction of smaller X, Y, and Z WCS coordinates</param>
        /// <returns></returns>
        public List<AcadEntity> Offset(double Distance)
        {
            return Technical.GetParts(this._i.Offset(Distance));
        }
    }
}
