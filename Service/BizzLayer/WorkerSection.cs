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
        int id;
        string seq;
        string des;
        int idOb;
        string ob;
        string stat;
        string actName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Kolejność
        {
            get { return seq; }
            set { seq = value; }
        }
        public string Opis
        {
            get { return des; }
            set { des = value; }
        }
        public int Id_Obiektu
        {
            get { return idOb; }
            set { idOb = value; }
        }
        public string Obiekt
        {
            get { return ob; }
            set { ob = value; }
        }
        public string Status
        {
            get { return stat; }
            set { stat = value; }
        }
        public string Czynność
        {
            get { return actName; }
            set { actName = value; }
        }

        public WorkerSection(int a, string b, string c, int d, string e, string f, string g)
        {
            this.id = a;
            this.seq = b;
            this.des = c;
            this.idOb = d;
            this.ob = e;
            this.stat = f;
            this.actName = g;
        }

        public static List<WorkerSection> Appoitments(int worker)
        {
            var conn = new DataLayer.DataClasses1DataContext();
            List<WorkerSection> activity = (from a in conn.Activity
                                            where a.id_pers == worker && (a.status == "opn" || a.status == "pro")
                                            select new WorkerSection(a.id_act, a.seq_name, a.description, a.Request.Object.id_obj, a.Request.Object.name, a.status, a.Activity_Type.act_name)).ToList();
            return activity;
        }

        public static List<int> AppoitmentsIds(int worker)
        {
            var conn = new DataLayer.DataClasses1DataContext();
            List<int> ids = (from a in conn.Activity
                             where a.id_pers == worker && (a.status == "opn" || a.status == "pro")
                             select a.id_act).ToList();
            return ids; 
        }
            
        public static bool UpdateApoitment(int id, string update)
        {
            var conn = new DataLayer.DataClasses1DataContext();
            Activity activity = (from a in conn.Activity
                                 where a.id_act == id
                                 select a).SingleOrDefault();

            if(activity != null)
            {
                activity.status = update;
                try
                {
                    conn.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
    }
}
