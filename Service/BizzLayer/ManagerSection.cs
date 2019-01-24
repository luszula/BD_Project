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

        /// SEBASTIAN OTAWSKI

        public static IQueryable<Client> Find_user(string idszukaj, string companyszukaj, string nameszukaj, string lnameszukaj)
        {
            {
                DataClasses1DataContext ctx = new DataClasses1DataContext();
                IQueryable<Client> zap1;
                IQueryable<Client> zap2;
                IQueryable<Client> zap3;
                IQueryable<Client> zap4;
                int idint = 0;

                if (idszukaj != "")
                {
                    idint = Int32.Parse(idszukaj);
                }


                if (idszukaj == "" && companyszukaj == "" && nameszukaj == "" && lnameszukaj == "")
                {
                    return (from p in ctx.Client
                            select p);
                }

                if (idszukaj != "")
                {
                    zap1 = (from p in ctx.Client
                            where (p.id_cli == idint)
                            select p);
                }
                else
                    zap1 = (from p in ctx.Client select p);

                if (companyszukaj != "")
                {
                    zap2 = (from p in zap1
                            where (p.name.StartsWith(companyszukaj))
                            select p);
                }
                else
                    zap2 = zap1;

                if (nameszukaj != "")
                {
                    zap3 = (from p in zap2
                            where (p.fname.StartsWith(nameszukaj))
                            select p);
                }
                else
                    zap3 = zap2;

                if (lnameszukaj != "")
                {
                    return zap4 = (from p in zap1
                                   where (p.lname.StartsWith(lnameszukaj))
                                   select p);
                }
                else
                    return zap4 = zap3;

            }
        }

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

        public static object ActivityData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from a in connection.Activity
                            select new { ID_Aktywności = a.id_act, Kolejność = a.seq_name, Opis = a.description, Rezultat = a.result, Status = a.status, Data_Zgłoszenia = a.dt_reg, Data_Zakończenia = a.dt_fin_cancel, ID_Zgłoszenia = a.id_req, ID_Pracownika = a.id_pers, Nazwa_Aktywności = a.Activity_Type.act_name }).OrderBy(a => a.Kolejność).ToList();
                return data;
            }
        }

        public static object GetWorkerData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from a in connection.Personel
                            where (a.role == "wor")
                            select new { ID_Pracownika = a.id_pers, Imię = a.fname, Nazwisko = a.lname, Rola = a.role, Nazwa_użytkownika = a.uname }).ToList();
                return data;
            }
        }

        public static object GetRequestData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from a in connection.Request
                            select new { ID_Zgłoszenia = a.id_req, Opis = a.description, Rezultat = a.result, Status = a.status, Data_Zgłoszenia = a.dt_reg, Data_Zakończenia = a.dt_fin_cancel }).ToList();
                return data;
            }
        }

        public static object GetClientAllData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from a in connection.Client
                            select new { ID_Klienta = a.id_cli, Nazwa_firmy = a.name, Imię = a.fname, Nazwisko = a.lname, Telefon = a.tel, Ulica = a.street_name, Kod_pocztowy = a.post_code, Numer_domu = a.number }).ToList();

                return data;
            }
        }


        ///KAROL SZUSTER

        public static string AddNewObject(string nameNew, string name_typeNew, int clientIdNew)
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                string code = (from obj in connection.Obj_Type
                               where obj.name_type == name_typeNew
                               select obj.code_type).SingleOrDefault();

                DataLayer.Object addNew = new DataLayer.Object
                {
                    name = nameNew,
                    code_type = code,
                    id_cli = clientIdNew
                };
                if (code == null)
                {
                    return "Wybrano niepoprawny obiekt";
                }
                else {

                   // try
                    {
                        connection.Object.InsertOnSubmit(addNew);
                        connection.SubmitChanges();
                        return "zakonczono powodzeniem";
                    }
                    //catch
                    {
                        return "zakonczono niepowodzeniem";
                    }
                }
            }
            
            
        }

        public static void EditObject(int currentId, string selected, string name, string clientId)
        {

            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                DataLayer.Object updtObj = connection.Object.SingleOrDefault(x => x.id_obj == currentId);
                updtObj.name = name;
                updtObj.code_type = (from obj in connection.Obj_Type
                                     where obj.name_type == selected
                                     select obj.code_type).SingleOrDefault();
                int cid = 0;
                if (Int32.TryParse(clientId, out cid))
                {
                    updtObj.id_cli = cid;
                }
                connection.SubmitChanges();
            }
        }

        public static object GetObjData()
        {

            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from obj in connection.Object
                            select new { Id_Obiektu = obj.id_obj, Nazwa = obj.name, Typ = obj.Obj_Type.name_type, Id_Klienta = obj.id_cli }).ToList();

                return data;
            }
        }

        public static List<string> GetDataToCombo()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                List<string> list = (from obj in connection.Obj_Type
                                     select obj.name_type).ToList();
                return list;
            }
        }

        public static List<string> SetBoxes(int currentId)
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                string eName, eNameType;
                string eClientId;

                eName = (from nm in connection.Object
                         where nm.id_obj == currentId
                         select nm.name).SingleOrDefault();
                eNameType = (from nm in connection.Object
                             where nm.id_obj == currentId
                             select nm.Obj_Type.name_type).SingleOrDefault();
                eClientId = (from nm in connection.Object
                             where nm.id_obj == currentId
                             select nm.id_cli).SingleOrDefault().ToString();

                var dataList = new List<string>() { eName, eNameType, eClientId };
                return dataList;
            }
        }

        public static object searchingOptions(string id, string name, string type, string client)
        {
            string sId = id;
            string sName = name;
            string sType = type;
            string sClient = client;

            if (id != "")
            {
                int wid;
                Int32.TryParse(sId, out wid);
                using (DataClasses1DataContext connection = new DataClasses1DataContext())
                {
                    var data = (from obj in connection.Object
                                where obj.id_obj == wid
                                select new { obj.id_obj, obj.name, obj.Obj_Type.name_type, obj.id_cli }).ToList();
                    return data;
                }
            }
            else if (client != "")
            {
                int wid;
                Int32.TryParse(sClient, out wid);
                using (DataClasses1DataContext connection = new DataClasses1DataContext())
                {
                    var data = (from obj in connection.Object
                                where obj.id_cli == wid
                                select new { obj.id_obj, obj.name, obj.Obj_Type.name_type, obj.id_cli }).ToList();
                    return data;
                }
            }
            else if (name != "")
            {
                using (DataClasses1DataContext connection = new DataClasses1DataContext())
                {
                    var data = (from obj in connection.Object
                                where obj.name.StartsWith(sName)
                                select new { obj.id_obj, obj.name, obj.Obj_Type.name_type, obj.id_cli }).ToList();
                    return data;
                }
            }
            else if (type != "")
            {
                using (DataClasses1DataContext connection = new DataClasses1DataContext())
                {
                    var data = (from obj in connection.Object
                                where obj.Obj_Type.name_type.StartsWith(sType)
                                select new { obj.id_obj, obj.name, obj.Obj_Type.name_type, obj.id_cli }).ToList();
                    return data;
                }
            }
            else
            {
                return 0;
            }
        }

        public static object GetClientData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from cli in connection.Client
                            select new { Id_Klienta = cli.id_cli, Nazwa = cli.name, Imię = cli.fname, Nazwisko = cli.lname, Telefon = cli.tel, Ulica = cli.street_name, Numer = cli.number, Kod_pocztowy = cli.post_code }).ToList();
                return data;
            }
        }

        public static void EditStatus(int currentId, string selectedItem)
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                DataLayer.Activity updtStatus = connection.Activity.SingleOrDefault(x => x.id_act == currentId);
                updtStatus.status = selectedItem;
                connection.SubmitChanges();
            }
        }

        public static object GetActivityData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from act in connection.Activity
                            select new { Id_Aktywności = act.id_act, Kolejność = act.seq_name, Opis = act.description, Rezultat = act.result, Status = act.status, Data_Zgłoszenia = act.dt_reg, Data_Zakończenia = act.dt_fin_cancel, Id_Pracownika = act.id_pers, Id_Zgłoszenia = act.id_req, Nazwa_Aktywności = act.Activity_Type.act_name }).ToList();
                return data;
            }
        }

        public static object GetPersonelData()
        {
            using (DataClasses1DataContext connection = new DataClasses1DataContext())
            {
                var data = (from per in connection.Personel
                            select new { Id_Pracownika = per.id_pers, Imię = per.fname, Nazwisko = per.lname, Rola = per.role }).ToList();
                return data;
            }
        }

        ///MAREK SZAFRON

        public static DataClasses1DataContext Bsd_ADD()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            return data;

        }

        public static object Get_Data()
        {
            var data = (from a in Bsd_ADD().Request select new { a.id_req, a.id_pers, a.id_obj, a.description, a.status, a.result, a.dt_reg, a.dt_fin_cancel });
            return data;
        }

        public static object Get_Data2(int pozdro)
        {
            var data = (from a in Bsd_ADD().Request where a.id_req == pozdro select new { a.id_req, a.id_pers, a.id_obj, a.description, a.status, a.result, a.dt_reg, a.dt_fin_cancel });
            return data;
        }

        public static object Get_Data3()
        {
            var data = (from a in Bsd_ADD().Object select new { a.id_obj, a.name });
            return data;
        }

        public static object Get_Data4()
        {
            var data = (from a in Bsd_ADD().Personel select new { a.id_pers, a.fname, a.lname });
            return data;
        }

        public static object Szukaj_1(int numer_wiersza)
        {
            var data = (from a in Bsd_ADD().Request where a.id_req == numer_wiersza select new { a.id_req, a.id_pers, a.id_obj, a.description, a.status, a.result, a.dt_reg, a.dt_fin_cancel });
            return data;
        }

        public static object Szukaj_2(string imie)
        {
            var data = (from a in ManagerSection.Bsd_ADD().Object where a.name.StartsWith(imie) select new { a.id_obj, a.name });
            return data;
        }

        public static object Szukaj_3(string imie)
        {
            var data = (from a in ManagerSection.Bsd_ADD().Personel where a.lname.StartsWith(imie) || a.fname.StartsWith(imie) select new { a.id_pers, a.fname, a.lname });
            return data;
        }



        public static void RequestADD(int Id_req, string Description, string Result, string Status, DateTime Dt_req, int Id_obj, int Id_pers)
        {
            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                Request newRequest = new Request
                {
                    id_req = Id_req,
                    description = Description,
                    result = Result,
                    status = Status,
                    dt_reg = Dt_req,
                    id_pers = Id_pers,
                    id_obj = Id_obj
                    //dt_fin_cancel = Dt_fin_cancel,
                };


                ctx.Request.InsertOnSubmit(newRequest);
                ctx.SubmitChanges();

            };
        }



        public static void RequestEDIT(int Id_req, string Description, string Result, string Status, int Id_obj, int Id_pers, DateTime koniec)
        {
            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {

                Request edit = ctx.Request.SingleOrDefault(x => x.id_req == Id_req);
                //id_req = Id_req,
                edit.description = Description;
                edit.result = Result;
                edit.status = Status;
                edit.id_pers = Id_pers;
                edit.id_obj = Id_obj;
                edit.dt_fin_cancel = koniec;
                ctx.SubmitChanges();


            }


        }
    }
}
