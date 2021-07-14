using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSE_FINAL_BOTTOVIRGINIA_PROG1_JULIO_2021
{
    public  class Envios
    {
        public int numEnvio { get; set; }
        public int dniDestinatario { get; set; }
        public int dniRepartidor { get; set; }
        public eventosEnvios estadoEnvio { get; set; }
        public DateTime fechaEstEntrega { get; set; }
        public DateTime fechaEntrega { get; set; }
        public eventosEnvios historialEventos { get; set; }
        public int codigoSeguimiento{get;set;}
        public string descPaquete { get; set; }
    

        public enum eventosEnvios
        {
           PENDIENTE_ENVIO = 0, LLEGADA_AL_CENTRO_DE_DISTRIBUCION = 1, EN_VIAJE = 2, EN_MANOS_DEL_REPARTIDOR = 3, ENTREGADO=4
        }

        public  Envios (int codSeguieminto, int dniCliente,  DateTime fechaEstEnt, string desc, eventosEnvios estadoInicial)
        {
            codSeguieminto = numEnvio;
            dniCliente = dniDestinatario;
            fechaEstEnt = fechaEstEntrega;
            desc = descPaquete;
            estadoInicial = eventosEnvios.PENDIENTE_ENVIO;

        }


    }

}
