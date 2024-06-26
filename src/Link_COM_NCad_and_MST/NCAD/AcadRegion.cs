﻿using DynNCXLib.GeometryWrapper;
using System.Collections.Generic;
using System.Linq;

namespace DynNCXLib 
{

    ///<summary>
    /// A bounded planar face consisting of lines, circles, arcs, elliptical arcs, and spline curves
    ///</summary>
    public class AcadRegion 
	{
		public OdaX.AcadRegion _i;
		internal AcadRegion(object AcadRegion_object) 
		{
			this._i = AcadRegion_object as OdaX.AcadRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadRegion(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as OdaX.AcadRegion;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
        /// Creates a region from a set of entities. The given entities must form a closed coplanar region
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="ObjectList">The array of objects forming the closed coplanar face to be made into a region</param>
        public AcadRegion(AcadBlock AcadBlock, List<dynamic> ObjectList)
        {
            OdaX.AcadEntity[] ents = ObjectList.Select(a => (OdaX.AcadEntity)a._i).ToArray();
            var created_object = AcadBlock._i.AddRegion(ents);

            this._i = created_object[0] as OdaX.AcadRegion;
        }

        ///<summary>
        ///
        ///</summary>
        public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public Point Centroid => Technical.PointByDynPoint((dynamic)this._i.Centroid);

		///<summary>
		///
		///</summary>
		public object MomentOfInertia => this._i.MomentOfInertia;

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        ///
        ///</summary>
        public double Perimeter => this._i.Perimeter;

		///<summary>
		///
		///</summary>
		public object PrincipalDirections => this._i.PrincipalDirections;

		///<summary>
		///
		///</summary>
		public object PrincipalMoments => this._i.PrincipalMoments;

		///<summary>
		///
		///</summary>
		public double ProductOfInertia => this._i.ProductOfInertia;

		///<summary>
		///
		///</summary>
		public object RadiiOfGyration => this._i.RadiiOfGyration;

		///<summary>
		///
		///</summary>
		public void Boolean(OdaX.AcBooleanType Operation,dynamic Object) 
		{
			this._i.Boolean(Operation, Object);
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetParts(this._i.Explode());
    }
}
