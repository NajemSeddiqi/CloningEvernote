﻿using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace EvernoteClone.ViewModel.Helpers
{
    public class DataBaseHelper
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "notesDb.db3");

        public static bool Insert<T>(T item)
        {
            var result = false;
            using (var conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                var rows = conn.Insert(item);
                if (rows > 0)
                    result = true;
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            var result = false;
            using (var conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                var rows = conn.Update(item);
                if (rows > 0)
                    result = true;
            }

            return result;
        }

        public static bool Delete<T>(T item)
        {
            var result = false;
            using (var conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                var rows = conn.Delete(item);
                if (rows > 0)
                    result = true;
            }

            return result;
        }

        public static IList<T> Read<T>() where T : new()
        {
            List<T> items;
            using (var conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                items = conn.Table<T>().ToList();
            }

            return items;
        }
    }
}
