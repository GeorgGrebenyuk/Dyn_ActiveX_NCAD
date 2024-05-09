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
		private AcadPlotConfiguration Item(object Index) 
		{
			return new AcadPlotConfiguration(this._i.Item(Index));
		}
		public List<AcadPlotConfiguration> GetAcadPlotConfigurations()
		{
			List<AcadPlotConfiguration> cs = new List<AcadPlotConfiguration>();
			for(int c = 0; c < Count; c++)
			{
				cs.Add(this.Item(c));
			}
			return cs;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		
	}
}
