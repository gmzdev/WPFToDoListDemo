using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfDemoMvvm.Models;

namespace WpfToDoListDemo.Services
{
    public class ToDoListFileService
    {
        private static string jsonFileName =
           Path.Combine(
               Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
               "ToDoListDemo",
               "ToDoList.json");

        public static async Task SaveToFileAsync(IEnumerable<ToDoItem> items)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFileName)!);

            using (var fs = File.Create(jsonFileName))
            {
                await JsonSerializer.SerializeAsync(fs, items);
            }
        }

        public static async Task<IEnumerable<ToDoItem>?> LoadFromFileAsync()
        {
            try
            {
                using (var fs = File.OpenRead(jsonFileName))
                {
                    return await JsonSerializer.DeserializeAsync<IEnumerable<ToDoItem>>(fs);
                }
            }
            catch (Exception e) when (e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                return null;
            }
        }
    }
}
