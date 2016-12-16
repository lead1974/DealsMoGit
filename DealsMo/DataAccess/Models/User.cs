using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;
using System.Configuration;

namespace DealsMo.DataAccess.Models
{
    public class User
    {
        public virtual int USER_ID { get; set; }
        public virtual string USER_CD { get; set; }
        public virtual string EMAIL_TX { get; set; }
    }

    public class UserMap : ClassMapping<User>
    {

        public UserMap()
        {
            var schema = ConfigurationManager.AppSettings["mySchema"];
            Schema(schema);
            Table("LDAPUSER");

            Id(x => x.USER_ID);
            //Property(x => x.USER_ID, x => x.NotNullable(true));
            Property(x => x.USER_CD, x => x.NotNullable(true));
            Property(x => x.EMAIL_TX, x => x.NotNullable(true));

        }

    }
}
