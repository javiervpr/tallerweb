using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte.Rules
{
    public class ChangeCitaStatusRule: IBusinessRule
    {
        private readonly CitaEstado oldStatus;
        private readonly CitaEstado newStatus;

        public ChangeCitaStatusRule(CitaEstado oldStatus, CitaEstado newStatus)
        {
            this.oldStatus = oldStatus;
            this.newStatus = newStatus;
        }

        public string Message => "No se puede cambiar del estado " + oldStatus.ToString() +
            " al estado " + newStatus.ToString();

        public bool IsBroken()
        {
            if (newStatus == CitaEstado.Confirmada && oldStatus != CitaEstado.Creada)
                return false;

            if (newStatus == CitaEstado.Finalizada &&
                (oldStatus != CitaEstado.Confirmada))
                return false;

            if (newStatus == CitaEstado.Anulada &&
                (oldStatus != CitaEstado.Confirmada || oldStatus != CitaEstado.Creada))
                return false;

            return true;
        }
    }
}
