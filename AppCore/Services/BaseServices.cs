using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class BaseServices<T> : IServices<T>
    {
        IModel<T> model;

        public BaseServices(IModel<T> model)
        {
            this.model = model;
        }

        public void Add(T t)
        {
            model.Add(t);
        }

        public void Delete(T t)
        {
            model.Delete(t);
        }

        public List<T> Read()
        {
            return model.Read();
        }
    }
}
