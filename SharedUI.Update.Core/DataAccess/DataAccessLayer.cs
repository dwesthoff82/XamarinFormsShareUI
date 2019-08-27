using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedUI.Update.Core.DataAccess
{
    public class DataAccessLayer
    {

        SQLiteConnection SQLiteConnection { get; set; }



        public Resources GetResource(int id)
        {

            return SQLiteConnection.Get<Resources>(id);


        }
    }
}
