using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel
    {
        private int idusuario;
        private string nombre;
        private string login;
        private string password;
        private string icono;
        private string nombreicono;
        private string correo;
        private string rol;
        private string apellido;

        private IUserRepository userRepository;
        public EntityState state { private get; set; }

        private List<UserModel> listUser;

        //PROPIEDADES / MODELOS DE VISTA/ MODELOS DE DATOS
        public int Idusuario { get => idusuario; set => idusuario = value; }

        [Required(ErrorMessage = "El nomnbre es requerido")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo solo acepta letras")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El campo debe contener como minimo 3 letras")]
        public string Nombre { get => nombre; set => nombre = value; }

        [Required(ErrorMessage = "El Usuario es requerido")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo solo acepta letras")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El campo debe contener como minimo 3 letras")]
        public string Login { get => login; set => login = value; }

        [Required(ErrorMessage = "La password es requerida")]
        [StringLength(255, ErrorMessage = "Debe tener entre 5 y 255 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        public string Icono { get => icono; set => icono = value; }
        public string Nombreicono { get => nombreicono; set => nombreicono = value; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        [RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")]
        public string Correo { get => correo; set => correo = value; }
        public string Rol { get => rol; set => rol = value; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo solo acepta letras")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El campo debe contener como minimo 3 letras")]
        public string Apellido { get => apellido; set => apellido = value; }

        public UserModel()
        {
            userRepository = new UserRepository();
        }
        public string saveChanges()
        {
            string message = null;

            try
            {
                var userDataModel = new Users();
                userDataModel.idusuario = idusuario;
                userDataModel.nombre = nombre;
                userDataModel.idusuario = idusuario;
                userDataModel.nombre = nombre;
                userDataModel.login = login;
                userDataModel.password = password;
                userDataModel.icono = icono;
                userDataModel.nombreicono = nombreicono;
                userDataModel.correo = correo;
                userDataModel.rol = rol;
                userDataModel.apellido = apellido;

                switch (state)
                {
                    case EntityState.Added:
                        userRepository.Add(userDataModel);
                        message = "El registro se agregó correctamente";
                        break;
                    case EntityState.Modified:
                        userRepository.Edit(userDataModel);
                        message = "El registro se modificó correctamente";
                        break;
                    case EntityState.Deleted:
                        userRepository.Delete(idusuario);
                        message = "El registro se eliminó correctamente";
                        break;
                }
            }

            catch (Exception ex)
            {

                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "Numero de empleado repetido";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<UserModel> GetAll()
        {
            var userDataModel = userRepository.GetAll();
            listUser = new List<UserModel>();
            foreach (Users item in userDataModel)
            {
                listUser.Add(new UserModel
                {
                    idusuario = item.idusuario,
                    nombre = item.nombre,
                    login = item.login,
                    password = item.password,
                    icono = item.icono,
                    nombreicono = item.nombreicono,
                    correo = item.correo,
                    rol = item.rol,
                    apellido = item.apellido,
                });
            }
            return listUser;
        }

    }
}
