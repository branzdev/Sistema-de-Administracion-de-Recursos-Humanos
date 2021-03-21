﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SARH___JMéndez_Constructora.Models2
{
    [Table("aguinaldos")]
    public partial class Aguinaldos
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idEmpleado")]
        public int IdEmpleado { get; set; }
        [Column("idContrato")]
        public int IdContrato { get; set; }
        [Column("fechaInicio", TypeName = "date")]
        public DateTime FechaInicio { get; set; }
        [Column("fechaFin", TypeName = "date")]
        public DateTime FechaFin { get; set; }
        [Column("sumatoriaSalarioBrutos", TypeName = "decimal(10,3)")]
        public decimal SumatoriaSalarioBrutos { get; set; }
        [Column("montoAguinaldo", TypeName = "decimal(10,3)")]
        public decimal MontoAguinaldo { get; set; }

        [ForeignKey(nameof(IdContrato))]
        [InverseProperty(nameof(Ingresocontrato.Aguinaldos))]
        public virtual Ingresocontrato IdContratoNavigation { get; set; }
        [ForeignKey(nameof(IdEmpleado))]
        [InverseProperty(nameof(Empleados.Aguinaldos))]
        public virtual Empleados IdEmpleadoNavigation { get; set; }
    }
}
