using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WEB_API10.ServiceModelscs;

namespace WEB_API10
{
    public class Service1 : IService1
    {
        db_restaurant2DataContext db;

        public User[] GetUsers()
        {
            db = new db_restaurant2DataContext();

            List<User> lmvh = new List<User>();

            try
            {
                var AllData = db.GetUser1();

                foreach (var m in AllData)
                {
                    User ma = new User();
                    ma.ID_user = m.ID_user;
                    ma.username = m.username;
                    ma.password = m.password;
                    lmvh.Add(ma);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return lmvh.ToArray();
        }
    }
}
