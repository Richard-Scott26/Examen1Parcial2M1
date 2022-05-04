using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class OpenWeatherServices : BaseServices<OpenWeather>, IOpenWeatherServices
    {

        IOpenWeatherModel model;

        public OpenWeatherServices(IOpenWeatherModel model) : base(model)
        {
            this.model = model;
        }

        public OpenWeather GetById(int id)
        {
            return model.GetById(id);
        }
    }
}
