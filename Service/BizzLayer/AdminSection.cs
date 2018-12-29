using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class AdminSection
    {

        public static IQueryable<Personel> Find_user(string last_name, string first_name, string user_name)
        {
            {
                DataClasses1DataContext ctx = new DataClasses1DataContext();
                IQueryable<Personel> zap1;
                IQueryable<Personel> zap2;
                IQueryable<Personel> zap3;

                if (last_name == "" && first_name == "" && user_name == "")
                {
                    return (from p in ctx.Personel
                            select p);
                }

                if (last_name != "")
                {
                    zap1 = (from p in ctx.Personel
                            where (p.lname == last_name)
                            select p);
                }
                else
                    zap1 = (from p in ctx.Personel select p);

                if (first_name != "")
                {
                    zap2 = (from p in zap1
                            where (p.fname == first_name)
                            select p);
                }
                else
                    zap2 = zap1;

                if (user_name != "")
                {
                    return zap3 = (from p in zap2
                                   where (p.uname == user_name)
                                   select p);
                }
                else
                    return zap3 = zap2;

            }
        }

        public static string Create_Personel(string last_name, string first_name, string role, string pass, DateTime dt_exp)
        {

            using (DataClasses1DataContext conn = new DataClasses1DataContext())
            {
                string user_name = Generate_User_Name(last_name, first_name);
                while (true)
                {
                    var zap = (from p in conn.Personel where p.uname == user_name select p);
                    if (role != "man" & role != "wor" & role != "adm")//poprawnosc roli
                        return "Coś poszło nie tak, popraw role";
                    else if (zap.Any())//unikatowy login bedzie sprawdzac aż wygeneruje unikatowy login
                        user_name = Generate_User_Name(last_name, first_name);
                    else
                        break;
                }
                {
                    Personel new_per = new Personel
                    {
                        lname = last_name,
                        fname = first_name,
                        uname = user_name,
                        password = LoginSection.MD5Hash(pass),
                        role = role
                    };
                    if (dt_exp != DateTime.ParseExact("01.01.2000", "dd.MM.yyyy", null)&& dt_exp<DateTime.MaxValue&& dt_exp > DateTime.MinValue)
                        new_per.dt_exp = dt_exp;
                         
                    conn.Personel.InsertOnSubmit(new_per);
                    conn.SubmitChanges();
                    return "Pomyslnie dodano do BD: " + user_name;
                }


            }
        }

        private static string Generate_User_Name(string last_name, string first_name)
        {
           System.Random x = new Random(System.DateTime.Now.Millisecond);
           int pom= x.Next(100, 999);
           return (last_name.Substring(0, 3) + first_name.Substring(0, 3) + pom).ToLower();
        }


        public static void Modify_Personel(string user_name,string last_name, string first_name, string role, string pass, DateTime dt_exp)
        {
            using (DataClasses1DataContext conn = new DataClasses1DataContext())
            {
                Personel up_per = conn.Personel.SingleOrDefault(x => x.uname == user_name);
                
                    up_per.lname = last_name;
                    up_per.fname = first_name;
                  //  up_per.uname = user_name_up;
                    up_per.role = role;

                if (pass != "nowe haslo")
                    up_per.password = LoginSection.MD5Hash(pass);

                if (dt_exp != DateTime.ParseExact("01.01.2000", "dd.MM.yyyy", null) && dt_exp < DateTime.MaxValue && dt_exp > DateTime.MinValue)
                    up_per.dt_exp = dt_exp;

                conn.SubmitChanges();
            }
        }
    }
}