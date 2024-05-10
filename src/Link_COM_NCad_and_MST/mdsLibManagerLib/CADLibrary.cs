using System.Runtime.InteropServices;

namespace DynmdsLibManagerLib 
{

	///<summary>
	///ICADLibrary Interface
	///</summary>
	public class CADLibrary 
	{
		public mdsLibManagerLib.ICADLibrary _i;
		internal CADLibrary(object CADLibrary_object) 
		{
			this._i = CADLibrary_object as mdsLibManagerLib.ICADLibrary;
			if (this._i == null) throw new System.Exception("Invalid casting to ICADLibrary");
		}

        /// <summary>
        /// Получение экземпляра LibManager.CADLibrary.1 для работы
        /// </summary>
        public CADLibrary()
		{
            var check_app = Marshal.GetActiveObject("LibManager.CADLibrary.1") as mdsLibManagerLib.ICADLibrary;
            if (check_app != null) this._i = check_app;
        }

        ///<summary>
        ///Проверка соединения
        ///</summary>
        public bool IsConnected => this._i.IsConnected;

		///<summary>
		///Получение объекта по идентификатору
		///</summary>
		public CADLibObject GetLibObject(object Identifier) 
		{
			return new CADLibObject(this._i.GetLibObject(Identifier));
		}

		///<summary>
		///Создание запроса к базе
		///</summary>
		public CADLibQuery GetLibQuery => new CADLibQuery(this._i.GetLibQuery());

		///<summary>
		///Вставка объекта из базы
		///</summary>
		public dynamic Insert(object Identifier,object Constraints,object TaskData) 
		{
			return ((dynamic)this._i).Insert(Identifier,Constraints,TaskData); //((dynamic)this._i)
        }
	}
}
