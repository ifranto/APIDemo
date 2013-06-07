using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Data
{
    public static class SessionRepository
    {
        private static List<Session> _sessions = new List<Session>()
        {
            new Session() {SessionID = 1, Name = "5yrs6digits", Speaker = "Dustin Thostenson", Room = "'Duke' Slater"},
            new Session() {SessionID = 2, Name = "Windows Azure Mobile Services", Speaker = "Matt Milner", Room = "Oakdale 4"},
            new Session() {SessionID = 3, Name = "CoffeeScript.", Speaker = "Brandon Williams", Room = "Oakdale 5"},
            new Session() {SessionID = 4, Name = "iOS for the .Net Web Guy", Speaker = "Lee Brandt", Room = "Oakdale 1"},
            new Session() {SessionID = 5, Name = "So you want an API?", Speaker = "Joel Kauffman", Room = "Oakdale 4"},
            new Session() {SessionID = 6, Name = "WinRT", Speaker = "Adam Barney", Room = "Oakdale 4"}
        };


        public static IQueryable<Session> All()
        {
            return _sessions.AsQueryable();
        }

        public static Session Single(int id)
        {
            return _sessions.Single(s => s.SessionID == id);
        }

        public static Session Add(Session item)
        {
            item.SessionID = _sessions.Max(s => s.SessionID) + 1;
            _sessions.Add(item);

            return item;
        }

        public static Session Update(Session item)
        {
            Session data = _sessions.Single(s => s.SessionID == item.SessionID);
            data.Name = item.Name;
            data.Room = item.Room;
            data.Speaker = item.Speaker;

            return item;
        }

        public static void Delete(int id)
        {
            _sessions.RemoveAll(s => s.SessionID == id);
        }
    }
}
