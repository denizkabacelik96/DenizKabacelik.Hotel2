using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabacelik.Hotel2.Business.Abstract;
using DenizKabacelik.Hotel2.Business.Concrete;
using DenizKabacelik.Hotel2.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHotelService _hotelService;
        public ValuesController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        /// <summary>
        /// Get All Hotels 
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public List<Hotel> Get() {

            return _hotelService.GetAllHotels();

        }
        
        
        [HttpGet("{id}")]

        public   Hotel Get(int id)
        {

            return _hotelService.GetHotelBYId(id);

        }

        [HttpPost]
        public Hotel Post([FromBody] Hotel hotel) {

            return _hotelService.CreateHotel(hotel);
        
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {

            return _hotelService.UpdateHotel(hotel);

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _hotelService.DeleteHotel(id);

        }
    }
}
