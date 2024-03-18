using Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ItaliaPizzaService : IProductManager
    {
        public bool RegistrarProducto()
        {
            var status = false;
            return status;
        }
    }

    public partial class ItaliaPizzaService : IUserManager
    {
        public Logic.Usuarios IniciarSesion(String correo, String contraseña)
        {
            var usuario = new Logic.Usuarios()
            {
                Status = false
            };
            try
            {
                var client = new Autentificacion();
                usuario = client.IniciarSesion(correo, contraseña);
            }
            catch (EntityException e)
            {

            }
            return usuario;
        }
    }
}
