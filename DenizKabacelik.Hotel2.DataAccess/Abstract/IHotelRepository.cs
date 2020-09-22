using DenizKabacelik.Hotel2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.Hotel2.DataAccess.Abstract
{
    public interface IHotelRepository
    {

        List<Hotel> GetAllHotels();
        Hotel GetHotelBYId(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
