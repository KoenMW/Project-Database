using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SomerenModel;
using System.Data;

namespace SomerenDAL
{
    public class RoomDAO : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT * FROM rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["room_number"],
                    Capacity = (int)(dr["capacity"]),
                    Type = (bool)(dr["type"])
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
