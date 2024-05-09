using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynNCXLib
{
    /// <summary>
    /// The collection of all selection sets in the drawing
    /// </summary>
    public class SelectionSets
    {
        public nanoCAD.SelectionSets _i;
        internal SelectionSets(object AcadSelectionSets_object)
        {
            this._i = AcadSelectionSets_object as nanoCAD.SelectionSets;
        }
        /// <summary>
        /// Get AcadSelectionSets from Document
        /// </summary>
        /// <param name="acadDocument"></param>
        public SelectionSets(AcadDocument acadDocument)
        {
            this._i = acadDocument._i.SelectionSets;
        }
        public int Count => this._i.Count;
        /// <summary>
        /// Get all AcadSelectionSets
        /// </summary>
        /// <returns></returns>
        public List<SelectionSet> GetSelectionSets()
        {
            List<SelectionSet> es = new List<SelectionSet>();
            foreach (var ent in this._i)
            {
                es.Add(new SelectionSet(ent));
            }
            return es;
        }
    }
}
