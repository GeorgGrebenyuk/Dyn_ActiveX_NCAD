using System.Collections.Generic;

namespace DynmdsUnitsLib 
{

	///<summary>
	///IElements Interface
	///</summary>
	public class Elements 
	{
		public mdsUnitsLib.IElements _i;
		internal Elements(object Elements_object) 
		{
			this._i = Elements_object as mdsUnitsLib.IElements;
			if (this._i == null) throw new System.Exception("Invalid casting to IElements");
		}


        /// <summary>
        /// Возвращает Element от объекта, если это параметрический объект
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static Elements FromEntiy(dynamic AcadEntity)
        {
            Elements el = null;
            try
            {
                el = new Elements(AcadEntity._i.Elements);
            }
            catch { throw new System.Exception("Invalid casting to IElements"); }
            return el;

        }

		public List<Element> GetElements()
		{
            List<Element>els = new List<Element> ();
			for(int i = 0; i < this._i.Count; i++)
			{
                els.Add(new Element(this._i.Item(i)));
            }
			return els;	

        }

		///<summary>
		///property Count
		///</summary>
		public int Count => this._i.Count;

		///<summary>
		///method Add
		///</summary>
		public void Add(object Item) 
		{
			this._i.Add(Item);
		}

		///<summary>
		///method Remove
		///</summary>
		public void Remove(int Index) 
		{
			this._i.Remove(Index);
		}
	}
}
