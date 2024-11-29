using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorASG.Data { 

    public class TimeSeriesGenerator
    {
        public List<TimeSeries> TimeSeries { get; set; } = new();
        public static string Start = "12/12/2022";
        public  static string End
        {
            get
            {
               DateTimeOffset data = DateTimeOffset.Now;
               return (data.Day+1) + "/" + data.Month + "/" + data.Year;
            }

        }
        public long Range { get; private set; }
        

        public TimeSeriesGenerator(IDictionary<string, ICollection<int>> dataAlaysis,int IndexData=1)
        {

            DateTimeOffset startdata = DateTimeOffset.Parse(Start);

            DateTimeOffset date = DateTimeOffset.Now;
            date.AddDays(1);
            var d = date.Subtract(startdata);

            SetRange(d.Days);
            DateTimeOffset temp = startdata;
            int value = 0;
            
             
            for (int i = 0; i <=d.Days; i++)
            {
                var td = temp.ToString("dd/MM/yy");
                if (dataAlaysis.Keys.Contains(td))
                {
                    value= dataAlaysis[td].ToList()[IndexData];
                }
                else
                {
                    value = 0;
                }

                AddRandom(temp, value);
                temp = temp.AddDays(1);
               
            }
          
            

        }

        private void SetRange(int points)
        {
            Range = DateTimeOffset.Now.ToUnixTimeMilliseconds() - DateTimeOffset.Now.AddDays(-points).ToUnixTimeMilliseconds();
        }

        public void Update()
        {
            var first = TimeSeries.First();
            TimeSeries.Remove(first);

            var maxDate = TimeSeries.Max(e => e.Date);
            maxDate = maxDate.AddDays(1);
            AddRandom(maxDate);

        }

        private void AddRandom(DateTimeOffset date,int value=0)
        {
          //  var rnd = new Random();
           // var value = rnd.Next(1, 100);
            TimeSeries.Add(new TimeSeries { Date = date, Value = value, Quantity=20 });
        }

    }

    public class TimeSeries
    {
        public long DateMilliseconds => Date.ToUnixTimeMilliseconds();
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
