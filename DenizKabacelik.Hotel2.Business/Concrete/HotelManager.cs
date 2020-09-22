using DenizKabacelik.Hotel2.Business.Abstract;
using DenizKabacelik.Hotel2.DataAccess.Abstract;
using DenizKabacelik.Hotel2.DataAccess.Concrete;
using DenizKabacelik.Hotel2.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DenizKabacelik.Hotel2.Business.Concrete
{

   
    
    public class HotelManager : IHotelService
    {
        private IHotelRepository __hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            __hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return __hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            __hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return __hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelBYId(int id)
        {

            if (id>0) {
                return __hotelRepository.GetHotelBYId(id);
            }
            throw new Exception("Id 1'den küçük  olamaz");
        }
            

        public Hotel UpdateHotel(Hotel hotel)
        {
            return __hotelRepository.UpdateHotel(hotel);
        }
    }
}
