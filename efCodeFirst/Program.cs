using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать любую базу данных с 2-мя сущностями через EF Code First.
//Изменить сущности. Сделать миграцию. Скинуть проект, который получился, через github.

namespace efCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbMigrationsConfiguration.AutomaticMigrationsEnabled = true;

            using (var context = new CarsModel())
            {
                var cars = context.Cars.ToList();
            }
        }
    }
}
