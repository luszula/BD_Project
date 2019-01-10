using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class ManagerSection
    {
        public static void Create_Activity(string seq, string description, string status, DateTime startdate, int reqID, string type)
        {

            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                Activity newActivities = new Activity
                {
                    seq_name = seq,
                    description = description,
                    status = status,
                    dt_reg = startdate,
                    id_req = reqID,
                    act_type = type
                };
                ctx.Activity.InsertOnSubmit(newActivities);
                ctx.SubmitChanges();

            };

        }

        public static void Create_ActivityType(string code, string describe)
        {

            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                Activity_Type newType = new Activity_Type
                {
                    act_type = code,
                    act_name = describe,
                };

                ctx.Activity_Type.InsertOnSubmit(newType);
                ctx.SubmitChanges();
            };

        }

        public static void Create_Client(string Fname, string Lname, string Tel, string StreetName, string Post, string Number, string CName)
        {


            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                Client newClients = new Client
                {
                    name = CName,
                    fname = Fname,
                    lname = Lname,
                    tel = Tel,
                    street_name = StreetName,
                    post_code = Post,
                    number = Number,

                };

                ctx.Client.InsertOnSubmit(newClients);
                ctx.SubmitChanges();

            };
        }

        public static void Edit_Activity(string activity, string worker)
        {
                using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
                {
                    int convert = Int32.Parse(activity);
                    int convert2 = Int32.Parse(worker);

                    Activity ctx = dbContext.Activity.SingleOrDefault(x => x.id_act == convert);

                    ctx.id_pers = convert2;

                    dbContext.SubmitChanges();
                }

        }


        public static void Edit_Client(string name, string fname, string lname, string tel, string street, string postcode, string number, string edit)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {

                int convert = Int32.Parse(edit);
                Client ctx = dbContext.Client.SingleOrDefault(x => x.id_cli == convert);

                ctx.name = name;
                ctx.fname = fname;
                ctx.lname = lname;
                ctx.tel = tel;
                ctx.street_name = street;
                ctx.post_code = postcode;
                ctx.number = number;

                dbContext.SubmitChanges();
            }
        }
        
    }
}
