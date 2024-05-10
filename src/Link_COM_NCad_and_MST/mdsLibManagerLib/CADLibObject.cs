using DynmdsUnitsLib;

namespace DynmdsLibManagerLib 
{

	///<summary>
	///ICADLibObject Interface
	///</summary>
	public class CADLibObject 
	{
		public mdsLibManagerLib.ICADLibObject _i;
		internal CADLibObject(object CADLibObject_object) 
		{
			this._i = CADLibObject_object as mdsLibManagerLib.ICADLibObject;
			if (this._i == null) throw new System.Exception("Invalid casting to ICADLibObject");
		}

		///<summary>
		///Имя объекта
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///Системное имя категории
		///</summary>
		public string Category => this._i.Category;

		///<summary>
		///Идентификатор категории
		///</summary>
		public long CategoryId => this._i.CategoryId;

		///<summary>
		///Параметры объекта
		///</summary>
		public Element RootElement => new Element(this._i.RootElement);

		///<summary>
		///GUID объекта
		///</summary>
		public string GUID => this._i.GUID;

		///<summary>
		///Идентификатор объекта
		///</summary>
		public long ObjectId => this._i.ObjectId;

		///<summary>
		///Подчиненные элементы
		///</summary>
		public CADLibObjects Children => new CADLibObjects(this._i.Children);

		///<summary>
		///Путь к файлу указанной категории
		///</summary>
		public string GetGraphicsPath(string FileCategory) 
		{
			return this._i.GetGraphicsPath(FileCategory);
		}

		///<summary>
		///Наличие графики
		///</summary>
		public bool HasGraphics => this._i.HasGraphics;

		///<summary>
		///Наличие файла заданной категории
		///</summary>
		public bool HasFileOfCategory(string Category) 
		{
			return this._i.HasFileOfCategory(Category);
		}

		///<summary>
		///Идентификатор элемента
		///</summary>
		public long ElementId => this._i.ElementId;

		///<summary>
		///Идентификатор родителя
		///</summary>
		public long ParentId => this._i.ParentId;
	}
}
