namespace efCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarsModel : DbContext
    {
        // Контекст настроен для использования строки подключения "CarsModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "efCodeFirst.CarsModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CarsModel" 
        // в файле конфигурации приложения.
        public CarsModel()
            : base("name=CarsModel")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }


        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}