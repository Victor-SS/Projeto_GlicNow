using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_GlicNow
{
    public class Usuario
    {
        public int id {  get; set; }
        public string login { get; set; }
        public string nomeCompleto { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public byte[] foto { get; set; }
        public int sexoId { get; set; }
        public int tipoDiabetesId {  get; set; }

        public Usuario()
        {
            id = 0;
            login = string.Empty;
            nomeCompleto = string.Empty;
            password = string.Empty;
            email = string.Empty;
            cpf = string.Empty;
            dataNascimento = DateTime.MinValue;
            sexoId = 0;
            tipoDiabetesId = 0;
        }
        AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                parameters.Clear();
                sql = "select id, login, nomeCompleto, \n";
                sql += "password, email, cpf, dataNascimento, \n";
                sql += "foto, sexoId, tipoDiabetesId \n";
                sql += "from tblUsuario \n";

                if(id != 0)
                {
                    sql += "where id = @id \n";
                    parameters.Add(new SqlParameter("@id", id));
                }
                else if (login != string.Empty)
                {
                    sql += "where login = @login \n";
                    parameters.Add(new SqlParameter("@login", login));
                }
                else if (nomeCompleto != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    parameters.Add(new SqlParameter("@nome", '%' + nomeCompleto + '%'));
                }
                dt = acesso.Consultar(sql, parameters);
                if (id != 0 || login != string.Empty && dt.Rows.Count == 1)
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    login = dt.Rows[0]["login"].ToString();
                    nomeCompleto = dt.Rows[0]["nomeCompleto"].ToString();
                    password = dt.Rows[0]["password"].ToString();
                    email = dt.Rows[0]["email"].ToString();
                    cpf = dt.Rows[0]["cpf"].ToString();
                    dataNascimento = Convert.ToDateTime(dt.Rows[0]["dataNascimento"]);
                    sexoId = Convert.ToInt32(dt.Rows[0]["sexoId"]);
                    tipoDiabetesId = Convert.ToInt32(dt.Rows[0]["tipoDiabetesId"]);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Autenticar(string senha)
        {
            return senha == password;
        }
    }
}
