using MyFinance.Util;
using System.Data;

namespace MyFinance.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Nascimento{ get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, NOME, DATA_NASCIMENTO FROM USUARIO WHERE EMAIL = '{Email}' AND SENHA = '{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if(dt != null)
            {
                if(dt.Rows.Count == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

