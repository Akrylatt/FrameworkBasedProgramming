using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQLite.TableMapping;
using System.Xml.Linq;
using SQLite;

/* TODO Complete the Model\BMIResult.cs class.
        This class should represent the columns on the table(id, name, heigh, weight, BMI Score, and
        Result). 
        */

namespace IUP_BMI_Calculator.Model {
    [Table("BMIResult")]
    public class BMIResult {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public double Height { get; set; }

        [NotNull]
        public double Weight { get; set; }

        [Ignore]
        public double BMIScore { get; set; }

        [Ignore]
        public string Result { get; set; }
          
    }
}

