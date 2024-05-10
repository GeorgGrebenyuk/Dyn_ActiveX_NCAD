namespace DynmdsUnitsLib 
{

	///<summary>
	///IElement Interface
	///</summary>
	public class Element 
	{
		public mdsUnitsLib.IElement _i;
		internal Element(object Element_object) 
		{
			this._i = Element_object as mdsUnitsLib.IElement;
			if (this._i == null) throw new System.Exception("Invalid casting to IElement");
		}

        /// <summary>
        /// Возвращает Element от объекта, если это параметрический объект
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static Element FromEntiy (dynamic AcadEntity)
		{
			Element el = null;
			try
			{
				el = new Element(AcadEntity._i.Element);
			}
			catch { throw new System.Exception("Invalid casting to IElement"); }
			return el;

        }

        ///<summary>
        ///Имя элемента
        ///</summary>
        public string Name => this._i.Name;

		///<summary>
		///Имя элемента
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///Параметры
		///</summary>
		public Parameters Parameters => new Parameters(this._i.Parameters);

		///<summary>
		///Родительский элемент
		///</summary>
		public Element Parent => new Element(this._i.Parent);

		///<summary>
		///Родительский элемент
		///</summary>
		public void Set_Parent(Element pVal) 
		{
			this._i.Parent = (mdsUnitsLib.Element)pVal._i;
		}

		///<summary>
		///Подчиненные элементы
		///</summary>
		public Elements SubElements => new Elements(this._i.SubElements);

		///<summary>
		///Описание
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///Действительный ли элемент
		///</summary>
		public bool IsValid => this._i.IsValid;

		///<summary>
		///Уникальный номер
		///</summary>
		public long ElementId => this._i.ElementId;

		///<summary>
		///Идентификатор объекта
		///</summary>
		public long ObjectId => this._i.ObjectId;

		///<summary>
		///property Implementation
		///</summary>
		//public object Implementation => this._i.Implementation;

		///<summary>
		///Копировать данные
		///</summary>
		public void CopyFrom(Element pSrc) 
		{
			this._i.CopyFrom((mdsUnitsLib.Element)pSrc._i);
		}

		///<summary>
		///Путь до текущего элемента
		///</summary>
		public string GetPath(string divider) 
		{
			return this._i.GetPath(divider);
		}

		///<summary>
		///Получение родителя заданного уровня
		///</summary>
		public Element GetParentByLevel(int level) 
		{
			return new Element(this._i.GetParentByLevel(level));
		}

		///<summary>
		///Значение параметра
		///</summary>
		public string GetValue(string parameter) 
		{
			return this._i.GetValue(parameter);
		}

		///<summary>
		///Комментарий к значению параметра
		///</summary>
		public string GetValueComment(string parameter) 
		{
			return this._i.GetValueComment(parameter);
		}

		///<summary>
		///Добавить подчиненный элемент
		///</summary>
		public Element AddChild(string Name) 
		{
			return new Element(this._i.AddChild(Name));
		}

		///<summary>
		///Имеется ли валидный родитель
		///</summary>
		public bool HasParent => this._i.HasParent;

		///<summary>
		///Получение подобъекта по идентификатору
		///</summary>
		public Element GetById(int nElementId) 
		{
			return new Element(this._i.GetById(nElementId));
		}
	}
}
