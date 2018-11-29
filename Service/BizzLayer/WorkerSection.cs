using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class WorkerSection
    {
        public static IQueryable Appoitments()
        {
            var conn = new DataLayer.DataClasses1DataContext();
            var activity = (from a in conn.Activity
                            select new { ID = a.id_act, Kolejność = a.seq_name, Opis = a.description, Status = a.status, Czynność = a.Activity_Type.act_name }).ToList();
            return activity;
        }
            
    }
}
