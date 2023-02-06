using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vaagdevi.Models;

namespace vaagdevi.IRespo
{
    public interface MarksI
    {
        Mark ID(int id);
        int log(string username, int id);
        List<UserModel> get();
        List<Model> getStudenets();
        string Add(UserModel p);
        string AddMarks(Model f);
    }
    class MarksIC:MarksI
    {
        VaagdeviEntities V = new VaagdeviEntities();

        List<Model> MarksI.getStudenets()
        {
            List<Model> Marlist = V.Marks.Select(s => new Model
            {

                ID=s.ID,
                Name=s.Name,
                Applied_Physics=s.Applied_Physics,
                Oop=s.Oop,
                M1=s.M1,
                PS1=s.PS1,
                EM1=s.EM1,
                AED=s.AED,
                Total=s.Total,
                percentag=s.percentag,
            }).ToList<Model>();
            return Marlist;
        }

        string MarksI.AddMarks(Model f)
        {
            var addmarks = V.Marks.Where(S => S.ID == f.ID ).FirstOrDefault();
            if(addmarks==null)
            {
                V.Marks.Add(new Mark
                {
                    ID = f.ID,
                    Name = f.Name,
                    Applied_Physics = f.Applied_Physics,
                    Oop = f.Oop,
                    M1 = f.M1,
                    PS1 = f.PS1,
                    EM1 = f.EM1,
                    AED = f.AED,
                    Total=f.Total,
                    percentag=f.percentag
                });
                V.SaveChanges();
                V.Dispose();
                return "inserted";

            }
            else
            {
                addmarks.ID = f.ID;
                addmarks.Name = f.Name;
                addmarks.Applied_Physics = f.Applied_Physics;
                addmarks.Oop = f.Oop;
                addmarks.M1 = f.M1;
                addmarks.PS1 = f.PS1;
                addmarks.EM1 = f.EM1;
                addmarks.AED = f.AED;
                addmarks.Total = f.Total;
                addmarks.percentag = f.percentag;

            }
            V.SaveChanges();
            V.Dispose();
            return "updated";
        }

        string MarksI.Add(UserModel p)
        {
           
                var add = V.users.Where(S => S.ID == p.ID).FirstOrDefault();
                if(add==null)
                {
                V.users.Add(new user
                {
                    sno = p.sno,
                    ID = p.ID,
                    Name = p.Name

                });
                    V.SaveChanges();
                    V.Dispose();
                    return "inserted";
                }
                else
                {
                add.sno = p.sno;
                add.ID = p.ID;
                add.Name = p.Name;
                }

                  V.SaveChanges();
                   V.Dispose();
                   return "updated";
        }

        List<UserModel> MarksI.get()
        {
            List<UserModel> userlist = V.users.Select(s => new UserModel
            {
                sno=s.sno,
                Name=s.Name,
                ID=s.ID
            }).ToList<UserModel>();
            return userlist;
        }

        Mark MarksI.ID(int id)
        {
            var GI = V.Marks.FirstOrDefault(a => a.ID == id);
            V.Dispose();
            return GI;
        }

        int MarksI.log(string username, int id)
        {
            int user = 0;
            var MS = V.Marks.Where(S => S.Name == username && S.ID == id).FirstOrDefault();
            if(MS!=null)
            {
                user = id;
                return user;
            }
            return user;
        }


       
        

    }
}
