using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vaagdevi.Models
{
    public class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Applied_Physics { get; set; }
        public Nullable<int> Oop { get; set; }
        public Nullable<int> M1 { get; set; }
        public Nullable<int> PS1 { get; set; }
        public Nullable<int> EM1 { get; set; }
        public Nullable<int> AED { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> percentag { get; set; }
    }
    public class AdminModel
    {

        public Nullable<int> sno { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
    }
    public class UserModel
    {

        public Nullable<int> sno { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class FeeModel
    {
        public int ID { get; set; }
        public Nullable<int> Total_fee { get; set; }
        public Nullable<int> Amount_paid { get; set; }
        public Nullable<int> Pending_fee { get; set; }
        public string fee_status { get; set; }
    }
}