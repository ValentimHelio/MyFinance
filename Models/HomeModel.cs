using MyFinance.Util;
using System.Data;

namespace MyFinance.Models
{
    public class HomeModel
    {
        public string LerNomeUsuario()
        {
            DAL objDal = new DAL();
            DataTable dt = objDal.RetDataTable("select * from usuario");
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["nome"].ToString();
                }
            }

            return "";


        }
    }
}
