﻿using DynNCXLib.GeometryWrapper;
using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMLine 
	{
		public OdaX.AcadMLine _i;
		internal AcadMLine(object AcadMLine_object) 
		{
			this._i = AcadMLine_object as OdaX.AcadMLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadMLine(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadMLine;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///
        ///</summary>
        public AcadMLine(AcadBlock AcadBlock, List<Point> VertexList)
        {
            this._i =  AcadBlock._i.AddMLine(Technical.PointsByDynPoints(VertexList, true));
        }
        ///<summary>
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public List<Point> Coordinates => Technical.PointsByArrayOfDoubleArray((double[])this._i.Coordinates, true);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(List<Point> Coordinates)
        {
            this._i.Coordinates = Technical.PointsByDynPoints(Coordinates, true);
        }

        ///<summary>
        ///
        ///</summary>
        public void Set_Coordinates(object Vertices) 
		{
			this._i.Coordinates = Vertices;
		}

		///<summary>
		///
		///</summary>
		public dynamic Justification => this._i.Justification;

		///<summary>
		///
		///</summary>
		public void Set_Justification(OdaX.AcMLineJustification Justification) 
		{
			this._i.Justification = Justification;
		}

		///<summary>
		///
		///</summary>
		public double MLineScale => this._i.MLineScale;

		///<summary>
		///
		///</summary>
		public void Set_MLineScale(double scale) 
		{
			this._i.MLineScale = scale;
		}
	}
}
