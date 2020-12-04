using RoomBooking.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Entities
{
    public class Room
    {
        public Room(DateTime startDate, DateTime endDate,string title)
        {

            AssertionConcern.AssertArgumentNotNull(startDate.ToString(), "Horário de início inválido");
            AssertionConcern.AssertArgumentNotNull(endDate.ToString(), "Horário de início inválido");
            AssertionConcern.AssertArgumentNotNull(title, "O nome da sala é requerido");

            this.Id = Guid.NewGuid();
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Title = title;
        }

        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Title { get; private set; }

    }
}
