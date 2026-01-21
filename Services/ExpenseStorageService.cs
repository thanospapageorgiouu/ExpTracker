using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using ExpTracker.Models;

namespace ExpTracker.Services
{
    public class ExpenseStorageService
    {
        private readonly string _filePath = "expenses.json";

        public List<Expense> LoadExpenses()
        {
            if (!File.Exists(_filePath))
                return new List<Expense>();
            else
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>(); //if json == empty, Return empty list instead of crashing
            }
        }

        public void SaveExpenses(List<Expense> expenses)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true    //Makes json better view
            };

            string json = JsonSerializer.Serialize(expenses, options);
            File.WriteAllText(_filePath, json);
        }

    }
}
