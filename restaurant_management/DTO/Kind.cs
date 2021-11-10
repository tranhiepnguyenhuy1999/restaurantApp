using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class Kind
    {
        private int iD;
        private string kind_name;
        private int from_age;
        private int to_age;
        private DateTime create_date;
        public Kind(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Kind_name = row["kind_name"].ToString();
            this.From_age = (int)row["from_age"];
            this.To_age = (int)row["to_age"];
            this.Create_date = DateTime.Parse(row["create_date"].ToString());
        }

        public Kind(int id, string kind_name, int from_age, int to_age, DateTime create_date)
        {
            this.iD = id;
            this.kind_name = kind_name;
            this.from_age = from_age;
            this.to_age = to_age;
            this.create_date = create_date;
        }

        public Kind() { }
        public int ID { get => iD; set => iD = value; }
        public string Kind_name { get => kind_name; set => kind_name = value; }
        public int From_age { get => from_age; set => from_age = value; }
        public int To_age { get => to_age; set => to_age = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
    }
}
