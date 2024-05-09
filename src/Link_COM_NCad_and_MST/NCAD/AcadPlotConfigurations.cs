using System.Collections.Generic;

namespace DynNCXLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlotConfigurations 
	{
		public OdaX.AcadPlotConfigurations _i;
		internal AcadPlotConfigurations(object AcadPlotConfigurations_object) 
		{
			this._i = AcadPlotConfigurations_object as OdaX.AcadPlotConfigurations;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		private AcadPlotConfigurations Item(object Index) 
		{
			return new AcadPlotConfigurations(this._i.Item(Index));
		}
		public List<AcadPlotConfigurations> GetAcadPlotConfigurations()
		{
			List<AcadPlotConfigurations> cs = new List<AcadPlotConfigurations>();
			foreach (var c in this._i)
			{
				cs.Add(new AcadPlotConfigurations(c));
			}
			return cs;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
