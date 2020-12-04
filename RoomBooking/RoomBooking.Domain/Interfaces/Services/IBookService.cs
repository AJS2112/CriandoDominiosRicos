using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Interfaces.Services
{
    public interface IBookService : IDisposable
    {
        //Orquestra a reserva de uma sala
        //Recupera o usuario
        //Recupera a sala
        //Tenta efetuar a reserva
        //Notifica o usuario
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
