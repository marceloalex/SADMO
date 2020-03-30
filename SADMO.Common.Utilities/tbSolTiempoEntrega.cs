namespace SADMO.Common.Utilities
{
    using System;

    public class tbSolTiempoEntrega
    {
        public int CodigoSolTiempoEntrega { get; set; }
        public string CodigoTipoVenta { get; set; }
        public string NumeroDocVenta { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime FechaEmisionSolTiempoEntrega { get; set; }
        public string DirDestinoSolTiempoEntrega { get; set; }
        public string CodigoUbigeo { get; set; }
        public int CodigoFormaEntrega { get; set; }
        public int tbEstado_CodigoEstado { get; set; }
        public DateTime TiempoEntregaSolTiempoEntrega { get; set; }
        public string ObservacionSolTiempoEntrega { get; set; }
    }
}
