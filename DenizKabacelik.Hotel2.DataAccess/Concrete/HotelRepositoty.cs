using DenizKabacelik.Hotel2.DataAccess.Abstract;
using DenizKabacelik.Hotel2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DenizKabacelik.Hotel2.DataAccess.Concrete
{
    public class HotelRepositoty : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using var hotelDbContext = new HotelDbContext();
            hotelDbContext.Hotels.Add(hotel);
            hotelDbContext.SaveChanges();
            return hotel;
        }

            public void DeleteHotel(int id)
        {
            using var hotelDbContext = new HotelDbContext();
            var deleteHotel = GetHotelBYId(id);
            hotelDbContext.Hotels.Remove(deleteHotel);
            hotelDbContext.SaveChanges();
        }

        public List<Hotel> GetAllHotels()
        {
            using var hotelDbContext = new HotelDbContext();
            return hotelDbContext.Hotels.ToList();
        }

        public Hotel GetHotelBYId(int id)
        {
            using var hotelDbContext = new HotelDbContext();
            return hotelDbContext.Hotels.Find(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using var hotelDbContext = new HotelDbContext();
            hotelDbContext.Hotels.Update(hotel);
            hotelDbContext.SaveChanges();
            return hotel;
        }
    }
}
