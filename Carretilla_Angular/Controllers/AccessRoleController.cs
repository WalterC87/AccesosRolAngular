using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using Carretilla_Angular.Models;

namespace Carretilla_Angular.Controllers
{
    public class AccessRoleController : ApiController
    {
        [HttpGet]
        [ActionName("GetAccesosRol")]
        public List<AccesoRol> GetAccesosRol()
        {
            List<AccesoRol> ListAccesos = new List<AccesoRol>();

            for (var i = 0; i < 10; i++)
            {
                AccesoRol rol = new AccesoRol();
                rol.RolId = i + 1;
                rol.Name = "Rol " + (i + 1);
                rol.Modulos = new List<AccesoModulo>()
                {
                    new AccesoModulo(){
                        ModuloId = i + 1,
                        Nombre = "Modulo " + i,
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    },
                    new AccesoModulo(){
                        ModuloId = i + 2,
                        Nombre = "Modulo " + (i+2),
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    },
                    new AccesoModulo(){
                        ModuloId = i + 3,
                        Nombre = "Modulo " + (i+3),
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    },
                    new AccesoModulo(){
                        ModuloId = i + 4,
                        Nombre = "Modulo " + (i+4),
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    },
                    new AccesoModulo(){
                        ModuloId = i + 5,
                        Nombre = "Modulo " + (i+5),
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    },
                    new AccesoModulo(){
                        ModuloId = i + 6,
                        Nombre = "Modulo " + (i+6),
                        Caracteristicas = new List<AccesoCaracteristica>()
                        {
                            new AccesoCaracteristica(){
                               CaracteristicaId = i + 1,
                               Nombre = "Caracteristica " + (i+1),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 2,
                               Nombre = "Caracteristica " + (i+2),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 3,
                               Nombre = "Caracteristica " + (i+3),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 4,
                               Nombre = "Caracteristica " + (i+4),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           },
                           new AccesoCaracteristica(){
                               CaracteristicaId = i + 5,
                               Nombre = "Caracteristica " + (i+5),
                               Derechos = new List<AccesoDerecho>(){
                                   new AccesoDerecho(){
                                       DerechoId = i + 1, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 2, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 3, 
                                       Status = false
                                   },
                                   new AccesoDerecho(){
                                       DerechoId = i + 4, 
                                       Status = false
                                   },new AccesoDerecho(){
                                       DerechoId = i + 5, 
                                       Status = false
                                   }
                               }
                           }
                        }
                    }
                };
                rol.Derechos = new List<Data>()
                {
                    new Data(){ Id = i, Nombre = "Data " + (i+1) },
                    new Data(){ Id = i, Nombre = "Data " + (i+2) },
                    new Data(){ Id = i, Nombre = "Data " + (i+3) }
                };

                ListAccesos.Add(rol);
            };

            return ListAccesos;
        }
    
    
        [ResponseType(typeof(AccesoRol))]
        public IHttpActionResult PostAccesosRol(AccesoRol AccesosRol)
        {
            return null;
        }
    }
}
