using RoomBooking.Console.Repositories;
using RoomBooking.Console.Services;
using RoomBooking.Domain.Entities;
using RoomBooking.Domain.Interfaces.Repositories;
using RoomBooking.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IBookRepository, BookRepository>();
            container.RegisterType<IBookService, BookService>();

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            //var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            ////var book = new Book(room, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2));

            //bookService.PlaceBook(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), room.Id);


            // Criar uma sala
            var room = new Room(DateTime.Now.AddHours(1), DateTime.Now.AddHours(8), "Sala 1");
            System.Console.WriteLine("Criando uma sala");

            // Iniciar uma reserva
            var book = new Book(room, DateTime.Now.AddHours(4), DateTime.Now.AddHours(4));
            System.Console.WriteLine("Iniciando uma reserva");

            // Confirmar a reserva
            book.Confirm(new List<DateTime>(), new List<DateTime>());

            System.Console.WriteLine("Status da reserva: " + book.Status);

            // Marcar como em progresso
            book.MarkAsInProgress();
            System.Console.WriteLine("Status da reserva: " + book.Status);

            // Marcar como completado
            book.MarkAsCompleted();
            System.Console.WriteLine("Status da reserva: " + book.Status);

            System.Console.ReadKey();
        }
    }
}
