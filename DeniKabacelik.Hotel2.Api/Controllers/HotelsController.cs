using DenizKabacelik.Hotel2.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DeniKabacelik.Hotel2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
          {
        private IHotelService hotelservice;

    }
}
