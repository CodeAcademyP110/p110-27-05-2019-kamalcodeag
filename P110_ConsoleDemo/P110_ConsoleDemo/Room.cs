using System;

namespace P110_ConsoleDemo
{
    public class Room
    {
        private static int id = 1;
        public string Name { get; set; }
        public string ID { get; set; }

        private int ResIndex = 0;
        private readonly DateTime[] reservations;

        public Room(string name, int reservationsCount)
        {
            Name = name;
            reservations = new DateTime[reservationsCount];
            ID = IDGenerator(3);
            id++;
        }

        string IDGenerator(int len)
        {
            return new string('0', len - id.ToString().Length) + id;

            #region anqut style
            //if(id < 10)
            //{
            //    return "00" + id;
            //}
            //if(id < 100)
            //{
            //    return "0" + id;
            //}
            //return id.ToString();
            #endregion
        }

        public string Reserve(DateTime date)
        {
            foreach (var reservation in reservations)
            {
                if(reservation.Date == date.Date)
                {
                    return "Room is not available for this day.";
                }
            }

            if (ResIndex == reservations.Length)
                throw new IndexOutOfRangeException("Reservations is not possible for now. Please, contact administrator: Medine xanim.");

            reservations[ResIndex++] = date;
            return "Room is not available for this day.";
        }
    }
}
