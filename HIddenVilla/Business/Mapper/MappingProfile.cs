using AutoMapper;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    //inherit Profile from Automapper
    class MappingProfile : Profile
    {
        //constructor
        public MappingProfile()
        {
            //will match property names
            //if prop names are different, can indicate assignments
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();

        }


    }
}
