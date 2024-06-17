﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PaseoExpress.Shared.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace PaseoExpress.Shared.Context
{
    public partial interface IDB_UberContextProcedures
    {
        Task<List<ConfirmarTransaccionResult>> ConfirmarTransaccionAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertarDatosTransaccionAsync(string Imagen, int? TarifaDiaria, int? TarifaAhorro, int? IdVehiculo, int? IdUsuario, int? UltimaSuma, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ObtenerServiciosProximoCambioResult>> ObtenerServiciosProximoCambioAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ObtenerVehiculosResult>> ObtenerVehiculosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ObtenerVehiculosSinExistenciaHoyResult>> ObtenerVehiculosSinExistenciaHoyAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<roResult>> roAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> TransaccionTarifaNoPagadaAsync(int? IdVehiculo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
