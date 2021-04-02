//using EasterRaces.Repositories.Contracts;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace EasterRaces.Repositories.Entities
//{
//    public abstract class Repository<T> : IRepository<T>
//    {
//        private ICollection<T> models;

//        protected Repository()
//        {
//            this.models = new List<T>();
//        }


//        protected List<T>Models { get; private set; }

//        public void Add(T model)
//        {
//            this.models.Add(model);
//        }

//        public IReadOnlyCollection<T> GetAll()
//        {
//            return this.models.ToList().AsReadOnly();
//        }

//        public abstract T GetByName(string name);


//        public bool Remove(T model)
//        {
//            if (this.models.Contains(model))
//            {
//                this.models.Remove(model);
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}


using EasterRaces.Models.Cars.Entities;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T>
    {

        public void Add(T model)
        {
            throw new NotImplementedException();
        }


        public IReadOnlyCollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T model)
        {
            throw new NotImplementedException();
        }


    }
}