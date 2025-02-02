﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {      
        public List<Room> GetAllRooms()
        {
            string query = "SELECT room_number, capacity, type FROM rooms";
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
                    Number = (int)Convert.ToInt32(dr["room_number"]),
                    Capacity = (int)Convert.ToInt32(dr["capacity"]),
                    Type = (bool)dr["type"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}