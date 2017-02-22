﻿using System;
using System.Data.Entity;

namespace GameOn.DataLayer.Managers
{
    public class DbManager<TContext> where TContext : DbContext, IDisposable, new ()
    {
        public DbManager()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TContext>());
        }

        public void Connect(Action<TContext> work)
        {
            using (var database = new TContext())
            {
                OpenConnection(database);
                work(database);
                database.SaveChanges();
            }
        }

        private static void OpenConnection(TContext database)
        {
            database.Database.Connection.Open();
        }

        public TReturn Connect<TReturn>(Func<TContext, TReturn> work)
        {
            using (var database = new TContext())
            {
                var result = work(database);
                database.SaveChanges();

                return result;
            }
        }
    }
}
