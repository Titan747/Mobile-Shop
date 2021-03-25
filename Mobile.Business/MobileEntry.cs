using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mobile.Data;

namespace Mobile.Business
{
    public class MobileEntry
    {
        public DataTable InsertMobile(int Id, string Mobile, string Model, int Price, string Description)
		{
			MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.InsertMobile(Id, Mobile, Model, Price, Description);
            return dtresult;
		}
        public DataTable UpdateMobile(int Id,string Mobile, string Model, int Price, string Description)
        {
            MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.UpdateMobile(Id, Mobile, Model, Price, Description);
            return dtresult;
        }
        public DataTable DeleteMobileById(int Id)
        {
            MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.DeleteMobileById(Id);
            return dtresult;
        }
		public DataTable DeleteAllMobiles()
        {
            MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.DeleteAllMobiles();
            return dtresult;
        }
        public DataTable SelectAllMobiles()
        {
            MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.SelectAllMobiles();
            return dtresult;
        }
        public DataTable SelectMobileById(int Id)
        {
            MobileAccess mobileAccess = new MobileAccess();
            DataTable dtresult = mobileAccess.SelectMobileById(Id);
            return dtresult;
        }
    }
}