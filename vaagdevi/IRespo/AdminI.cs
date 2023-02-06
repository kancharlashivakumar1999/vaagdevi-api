using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vaagdevi.Models;

namespace vaagdevi.IRespo
{
    public interface AdminI
    {
        int Alog(string username, int id);
        List<AdminModel> get();
        List<FeeModel> fee();
        fee Details(int id);
    }
    class AdminIC : AdminI
    {
        VaagdeviEntities sk = new VaagdeviEntities();

        fee AdminI.Details(int id)
        {
            var Gill = sk.fees.FirstOrDefault(f => f.ID == id);
            sk.Dispose();
            return Gill;
        }


        List<FeeModel> AdminI.fee()
        {
            List<FeeModel> feeList = sk.fees.Select(f => new FeeModel
            {
                ID=f.ID,
                Total_fee=f.Total_fee,
                Amount_paid=f.Amount_paid,
                Pending_fee=f.Pending_fee,
                fee_status=f.fee_status
            }).ToList<FeeModel>();
            return feeList;
        }
        List<AdminModel> AdminI.get()
        {
            List<AdminModel> Listt = sk.Admins.Select(S => new AdminModel()
            {
                sno=S.sno,
                Name=S.username,
                ID=S.ID

            }).ToList<AdminModel>();
            return Listt;
        }
        int AdminI.Alog(string username, int id)
        {
            int user = 0;
            var hit = sk.Admins.Where(A => A.username == username && A.ID == id).FirstOrDefault();
            if(hit!=null)
            {
                user = id;
                return user;
            }
            return user;
        }
    }
}
