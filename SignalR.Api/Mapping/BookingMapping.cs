﻿using AutoMapper;
using SignalR.DTOLayer.BookingDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class BookingMapping :Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking,CreateBookingDTO>().ReverseMap();
            CreateMap<Booking,GetBookingDTO>().ReverseMap();
            CreateMap<Booking,UpdateBookingDTO>().ReverseMap();
            CreateMap<Booking,ResultBookingDTO>().ReverseMap();

        }
    }
}
