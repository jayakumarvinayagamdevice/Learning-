using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Filtering
{
    public class OffTypeExcercise
    {
        public void Start()
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };

            var numeric = dataSource.OfType<int>().ToList();
            var stringValue = dataSource.OfType<string>().ToList();
        }
    }
}
