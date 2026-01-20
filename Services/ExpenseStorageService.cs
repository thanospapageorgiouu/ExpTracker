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

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Expense>>(json)
                   ?? new List<Expense>();
        }
    }
}
