namespace DynmdsUnitsLib 
{

	///<summary>
	///IMDSNode Interface
	///</summary>
	public class MDSNode 
	{
		public mdsUnitsLib.IMDSNode _i;
		internal MDSNode(object MDSNode_object) 
		{
			this._i = MDSNode_object as mdsUnitsLib.IMDSNode;
			if (this._i == null) throw new System.Exception("Invalid casting to IMDSNode");
		}

		///<summary>
		///Наименование стыка
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///Наименование стыка
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///Точка вставки
		///</summary>
		//public object Position => this._i.Position;

		///<summary>
		///Точка вставки
		///</summary>
		public void Set_Position(object pVal) 
		{
			this._i.Position = pVal;
		}

		///<summary>
		///Направление
		///</summary>
		//public object Direction => this._i.Direction;

		///<summary>
		///Направление
		///</summary>
		public void Set_Direction(object pVal) 
		{
			this._i.Direction = pVal;
		}

		///<summary>
		///Радиус
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///Радиус
		///</summary>
		public void Set_Radius(double pVal) 
		{
			this._i.Radius = pVal;
		}

		///<summary>
		///Длина вектора направления
		///</summary>
		public double DirectionLength => this._i.DirectionLength;

		///<summary>
		///Длина вектора направления
		///</summary>
		public void Set_DirectionLength(double pVal) 
		{
			this._i.DirectionLength = pVal;
		}

        ///<summary>
        ///property Element
        ///</summary>
        public Element Element => new Element(this._i.Element);

        ///<summary>
        ///property Element
        ///</summary>
        public void Set_Element(Element pVal)
        {
            this._i.Element = (mdsUnitsLib.Element)pVal._i;
        }

        ///<summary>
        ///Тип стыка
        ///</summary>
        public long NodeType => this._i.NodeType;

		///<summary>
		///Тип стыка
		///</summary>
		public void Set_NodeType(int pVal) 
		{
			this._i.NodeType = pVal;
		}

		///<summary>
		///Объект-владелец
		///</summary>
		//public object OwnerObject => this._i.OwnerObject;

		///<summary>
		///Существует ли объект-владелец
		///</summary>
		public bool HasOwner => this._i.HasOwner;

		///<summary>
		///Связь-владелец
		///</summary>
		//public object OwnerLink => this._i.OwnerLink;

		///<summary>
		///Существует ли связь-владелец
		///</summary>
		public bool HasOwnerLink => this._i.HasOwnerLink;

		///<summary>
		///Подключенные связи
		///</summary>
		public MDSObjects Links => new MDSObjects(this._i.Links);

		///<summary>
		///Коллекция связанных объектов, удовлетворяющих условию
		///</summary>
		public MDSObjects GetConnections(string Condition) => new MDSObjects(this._i.GetConnections(Condition));
	}
}
