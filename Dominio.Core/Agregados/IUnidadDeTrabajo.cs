﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core
{
    public interface IUnidadDeTrabajo:IDisposable
    {
        int Completar(); //Confirmar, guardar cambios.
    }
}
