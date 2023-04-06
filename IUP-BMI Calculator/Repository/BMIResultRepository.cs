using IUP_BMI_Calculator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Repository
{
    public class BMIResultRepository
    {
        string _dbPath;

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BMIResult>();
        }

        public BMIResultRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewBMIResult(string name, double height, double weight, double BMIScore, string BMIResult) {
            // TODO Complete the Repository\BMIResultRepository.cs class so it can be used to save the data to database.

            Init();
            var result = new BMIResult {
                Name = name,
                Height = height,
                Weight = weight,
                BMIScore = BMIScore,
                Result = BMIResult
            };

            conn.Insert(result);
        }
    }
}
