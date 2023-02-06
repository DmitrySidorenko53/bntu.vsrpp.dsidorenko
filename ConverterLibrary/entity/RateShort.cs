using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_lab2.entity
{
    public class RateShort
    {
        public int Cur_ID { get; set; }
        [Key]
        public System.DateTime Date { get; set; }
        public decimal? Cur_OfficialRate { get; set; }

        public override string ToString()
        {
            return Cur_ID.ToString();
        }
    }
}
