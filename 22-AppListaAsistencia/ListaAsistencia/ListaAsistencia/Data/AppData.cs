using LiteDB;
using System;
using System.IO;

namespace ListaAsistencia.Data
{
    public static class AppData
    {
        public static string DatabasePath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Database");

        public static readonly LiteDatabase Database = new LiteDatabase(DatabasePath);

        public static void Save<T>(T value)
        {
            Database.GetCollection<T>().Upsert(value);
        }

        public static void Delete<T>(int id)
        {
            Database.GetCollection<T>().Delete(id);
        }

        public static T[] GetAll<T>()
        {
            return Database.GetCollection<T>().Query().ToArray();
        }
    }
}
