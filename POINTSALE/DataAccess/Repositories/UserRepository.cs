using DataAccess.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        private string getAllUser;
        //private string getUser;
        //private string selectAll;
        private string insert;
        private string update;
        //private string delete;

        public UserRepository()
        {
            getAllUser = "mostrar_usuarios";
            //getUser = "buscar_usuario";
            //selectAll = "mostrar_usuario";
            insert = "insertar_usuario";
            update = "editar_usuario";
            //delete = "eliminar_usuario";


        }
        public int Add(Users entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombres", entity.nombre));
            parameters.Add(new SqlParameter("@Login", entity.login));
            parameters.Add(new SqlParameter("@Password", entity.password));
            parameters.Add(new SqlParameter("@Icono", entity.icono));
            parameters.Add(new SqlParameter("@Nombre_de_icono", entity.nombreicono));
            parameters.Add(new SqlParameter("@Correo", entity.correo));
            parameters.Add(new SqlParameter("@Rol", entity.rol));
            parameters.Add(new SqlParameter("@Apellido", entity.apellido));
            return ExecuteNonQuery(insert);
        }
        public int Edit(Users entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idUsuario", entity.idusuario));
            parameters.Add(new SqlParameter("@nombres", entity.nombre));
            parameters.Add(new SqlParameter("@Login", entity.login));
            parameters.Add(new SqlParameter("@Password", entity.password));
            parameters.Add(new SqlParameter("@Icono", entity.icono));
            parameters.Add(new SqlParameter("@Nombre_de_icono", entity.nombreicono));
            parameters.Add(new SqlParameter("@Correo", entity.correo));
            parameters.Add(new SqlParameter("@Rol", entity.rol));
            parameters.Add(new SqlParameter("@Apellido", entity.apellido));

            return ExecuteNonQuery(update);
        }
        public int Delete(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idUsuario", id));
            return ExecuteNonQuery(insert);
        }


        public IEnumerable<Users> GetAll()
        {
            var tableResult = ExecuteReader(getAllUser);
            var listUser = new List<Users>();

            foreach (DataRow item in tableResult.Rows)
            {
                listUser.Add(new Users
                {
                    idusuario = Convert.ToInt32(item[0]),
                    nombre = item[1].ToString(),
                    login = item[2].ToString(),
                    password = item[3].ToString(),
                    icono = item[4].ToString(),
                    nombreicono = item[5].ToString(),
                    correo = item[6].ToString(),
                    rol = item[7].ToString(),
                    apellido= item[8].ToString(),
                });
            }
            return listUser;
        }
    }
}
