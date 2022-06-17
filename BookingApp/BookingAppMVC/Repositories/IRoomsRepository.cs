using BookingAppMVC.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppMVC.Repositories
{
    public interface IRoomsRepository
    {
        List<Room> GetRooms();
        Room GetRoom(int id);
        void CreateRoom(Room r);
        void DeleteRoom(int id);
        void UpdateRoom(Room r);
    }
}
