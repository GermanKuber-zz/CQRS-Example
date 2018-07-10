using System;
using Autofac;
using Cqrs.Hotel.Command.Commands.LeaveRoom;
using Cqrs.Hotel.Infraestructure;
using MediatR;
using Xunit;

namespace Cqrs.Hotel.Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            try
            {


                var hotel = new Hotel();
                var scope = hotel.Initilize();

                scope.Resolve<IBus>().Send<LeaveRoomCommand, bool>(new LeaveRoomCommand(Guid.NewGuid()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
