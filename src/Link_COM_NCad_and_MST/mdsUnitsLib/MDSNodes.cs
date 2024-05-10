using System.Collections.Generic;

namespace DynmdsUnitsLib 
{

	///<summary>
	///IMDSNodes Interface
	///</summary>
	public class MDSNodes 
	{
		public mdsUnitsLib.IMDSNodes _i;
		internal MDSNodes(object MDSNodes_object) 
		{
			this._i = MDSNodes_object as mdsUnitsLib.IMDSNodes;
			if (this._i == null) throw new System.Exception("Invalid casting to IMDSNodes");
		}

        ///<summary>
        ///Возвращает набор узлов
        ///</summary>

        public List<MDSNode> GetMDSNodes()
        {
            List<MDSNode> pars = new List<MDSNode>();
            for (int i = 0; i < this.Count; i++)
            {
                pars.Add(new MDSNode(this._i.Item(i)));
            }
            return pars;
        }

        ///<summary>
        ///property Count
        ///</summary>
        public long Count => this._i.Count;
	}
}
