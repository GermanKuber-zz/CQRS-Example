using System;
using Autofac;
using Cqrs.Hotel.Command.Commands.LeaveRoom;
using Cqrs.Hotel.Infraestructure;
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

                scope.Resolve<IBus>().Send(new LeaveRoomCommand(Guid.NewGuid()));
                var algo = "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
