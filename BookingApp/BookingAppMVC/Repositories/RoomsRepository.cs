using BookingAppMVC.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookingAppMVC.Repositories
{
    public class RoomsRepository : IRoomsRepository
    {
        private HotelBookingEntities db = new HotelBookingEntities();

        public void CreateRoom(Room r)
        {
            db.Rooms.Add(r);
            db.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            var r = (from room in db.Rooms
                     where room.Id == id
                     select room).FirstOrDefault();
            if (r == null)
            {
                throw new Exception ("Room not found!");
            };
            db.Rooms.Remove(r);
        }

        public Room GetRoom(int id)
        {
            var r = (from room in db.Rooms
                     where room.Id == id
                     select room).FirstOrDefault();
            return r;
        }

        public List<Room> GetRooms()
        {
            var allRooms = db.Rooms.ToList();
            return allRooms;
        }

        public void UpdateRoom(Room r)
        {
            var roomToUpdate = (from room in db.Rooms
                     where room.Id == r.Id
                     select room).FirstOrDefault();

            if (roomToUpdate == null)
            {
                throw new Exception("Room not found!");
            };

            roomToUpdate.RoomNumber = r.RoomNumber;
            db.Entry(roomToUpdate).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}