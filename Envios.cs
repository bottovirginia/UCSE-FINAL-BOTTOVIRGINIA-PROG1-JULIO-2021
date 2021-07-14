using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSE_FINAL_BOTTOVIRGINIA_PROG1_JULIO_2021
{
    public class Envios
    {
        public int numEnvio { get; set; }
        public int dniDestinatario { get; set; }
        public int dniRepartidor { get; set; }
        public enumEnvios estadoEnvio { get; set; }
        public DateTime fechaEstEntrega { get; set; }
        public enumEventos historialEventos { get; set; }
        public int codigoSeguimiento { get; set; }
        public string descPaquete { get; set; }



        public enum enumEnvios
        {
            PENDIENTE_ENVIO = 1, ENVIADO = 2, ULTIMO_TRAMO_DEL_RECORRIDO = 3, ENTREGADO = 4
        }

        public enum enumEventos
        {
            LLEGADA_AL_CENTRO_DE_DISTRIBUCION = 1, EN_VIAJE = 2, EN_MANOS_DEL_REPARTIDOR = 3, ENTREGADO = 4
        }


        public Envios(int codSeguieminto, int dniCliente, DateTime fechaEstEnt, string desc, enumEnvios estadoInicial, enumEventos eventoInicial, DateTime fechaEvento,
            int dniRepartidor)
        {
            codSeguieminto = numEnvio;
            dniCliente = dniDestinatario;
            fechaEstEnt = fechaEstEntrega;
            desc = descPaquete;
            estadoInicial = enumEnvios.PENDIENTE_ENVIO;
            eventoInicial = enumEventos.LLEGADA_AL_CENTRO_DE_DISTRIBUCION;
            fechaEvento = DateTime.Today;
            dniRepartidor = 0;





        }

    }
}
