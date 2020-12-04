using System;
using System.Collections.Generic;

namespace UnitTestSample.Domain
{
    public class Room
    {
        public Room(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Nome inválido");

            this.Name=name;
        }
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime Book(DateTime starteDate, DateTime endDate,List<DateTime> books)
        {
            if (books.Contains(starteDate))
                throw new Exception("Sala já reservada neste horário");

            return starteDate;
        }
    }
}
