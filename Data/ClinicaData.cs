using ClinicaApi.Models;

namespace ClinicaApi.Data;

public static class ClinicaData
{
    public static List<Categoria> Categorias { get; } = new()
    {
        new Categoria
        {
            Id = 1,
            Nombre = "Farmacia y Medicamentos",
            Descripcion = "Medicamentos de patente, analgésicos, antibióticos y tratamientos especializados.",
            Icono = "Pill",
            AreaClinica = "Farmacia Central"
        },
        new Categoria
        {
            Id = 2,
            Nombre = "Vitaminas y Suplementos",
            Descripcion = "Complejos vitamínicos, refuerzo inmunológico y nutrición clínica.",
            Icono = "HeartPulse",
            AreaClinica = "Nutrición y Bienestar"
        },
        new Categoria
        {
            Id = 3,
            Nombre = "Equipos de Monitoreo",
            Descripcion = "Tensiómetros digitales, oxímetros de pulso, glucómetros y termómetros clínicos.",
            Icono = "Activity",
            AreaClinica = "Equipamiento Médico"
        },
        new Categoria
        {
            Id = 4,
            Nombre = "Dermatología Clínica",
            Descripcion = "Fotoprotectores médicos, dermolimpiadores y cuidado de piel sensible.",
            Icono = "Sparkles",
            AreaClinica = "Dermoestética"
        },
        new Categoria
        {
            Id = 5,
            Nombre = "Paquetes Preventivos",
            Descripcion = "Chequeos médicos integrales, perfiles de laboratorio y evaluaciones cardiológicas.",
            Icono = "ShieldCheck",
            AreaClinica = "Medicina Preventiva"
        }
    };

    public static List<Producto> Productos { get; } = new()
    {
        new Producto
        {
            Id = 1,
            Codigo = "CLI-PRD-001",
            Nombre = "Tensiómetro Digital de Brazo Omron HEM-7120",
            CategoriaId = 3,
            Categoria = "Equipos de Monitoreo",
            Laboratorio = "Omron Healthcare",
            Presentacion = "Unidad Digital + Brazalete Universal",
            Precio = 189.90m,
            Descuento = 15,
            Stock = 25,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1631549916768-4119b2e5f926?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Monitor electrónico de presión arterial con detector de latidos irregulares y guía de ajuste de brazalete."
        },
        new Producto
        {
            Id = 2,
            Codigo = "CLI-PRD-002",
            Nombre = "Oxímetro de Pulso Clínico Fingertip Pro",
            CategoriaId = 3,
            Categoria = "Equipos de Monitoreo",
            Laboratorio = "MedTech Diagnostics",
            Presentacion = "Caja x 1 Unidad OLED",
            Precio = 75.00m,
            Descuento = 10,
            Stock = 40,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1584308666744-24d5c474f2ae?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Medición precisa e instantánea de saturación de oxígeno (SpO2) y frecuencia cardíaca con pantalla OLED."
        },
        new Producto
        {
            Id = 3,
            Codigo = "CLI-PRD-003",
            Nombre = "Complejo Inmuno-Vitamínico C + Zinc + D3",
            CategoriaId = 2,
            Categoria = "Vitaminas y Suplementos",
            Laboratorio = "Bayer HealthCare",
            Presentacion = "Frasco x 60 Cápsulas Blandas",
            Precio = 64.50m,
            Descuento = 5,
            Stock = 60,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1550572017-edd951b55104?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Fórmula clínica de triple acción para fortalecer el sistema inmunológico y proteger contra el estrés oxidativo."
        },
        new Producto
        {
            Id = 4,
            Codigo = "CLI-PRD-004",
            Nombre = "Fotoprotector ISDIN Fusion Water SPF 50+",
            CategoriaId = 4,
            Categoria = "Dermatología Clínica",
            Laboratorio = "ISDIN",
            Presentacion = "Envase 50 ml Ultra Ligero",
            Precio = 112.00m,
            Descuento = 10,
            Stock = 32,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1556228720-195a672e8a03?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Protector solar facial de fase acuosa y absorción inmediata, dermatológicamente probado para todo tipo de piel."
        },
        new Producto
        {
            Id = 5,
            Codigo = "CLI-PRD-005",
            Nombre = "Paracetamol 1g Analgésico y Antipirético",
            CategoriaId = 1,
            Categoria = "Farmacia y Medicamentos",
            Laboratorio = "Genfar / Sanofi",
            Presentacion = "Caja x 30 Tabletas Recubiertas",
            Precio = 24.90m,
            Descuento = 0,
            Stock = 95,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1587854692152-cbe660dbde88?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Alivio rápido y eficaz del dolor leve a moderado y reducción de estados febriles."
        },
        new Producto
        {
            Id = 6,
            Codigo = "CLI-PRD-006",
            Nombre = "Glucómetro Accu-Chek Guide Kit Completo",
            CategoriaId = 3,
            Categoria = "Equipos de Monitoreo",
            Laboratorio = "Roche Diabetes Care",
            Presentacion = "Medidor + 25 Tiras Reactivas + Lancetero",
            Precio = 145.00m,
            Descuento = 20,
            Stock = 18,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1579154204601-01588f351e67?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Sistema de monitoreo de glucosa en sangre con conectividad inalámbrica y resultados en menos de 4 segundos."
        },
        new Producto
        {
            Id = 7,
            Codigo = "CLI-PRD-007",
            Nombre = "Paquete Chequeo Preventivo Ejecutivo Anual",
            CategoriaId = 5,
            Categoria = "Paquetes Preventivos",
            Laboratorio = "Clínica San Gabriel",
            Presentacion = "Voucher Digital Completo (6 Exámenes + 2 Consultas)",
            Precio = 290.00m,
            Descuento = 25,
            Stock = 50,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1576091160399-112ba8d25d1d?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Incluye hemograma completo, perfil lipídico, glucosa basal, electrocardiograma, rayos X de tórax y consulta médica."
        },
        new Producto
        {
            Id = 8,
            Codigo = "CLI-PRD-008",
            Nombre = "Omega 3 Ultra Pure EPA/DHA 1000 mg",
            CategoriaId = 2,
            Categoria = "Vitaminas y Suplementos",
            Laboratorio = "Solgar",
            Presentacion = "Frasco x 90 Softgels",
            Precio = 98.00m,
            Descuento = 15,
            Stock = 44,
            RequiereReceta = false,
            Imagen = "https://images.unsplash.com/photo-1512069772995-ec65ed45afd6?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Ácidos grasos esenciales de alta pureza para el cuidado cardiovascular y la función cerebral."
        }
    };

    public static List<Servicio> Servicios { get; } = new()
    {
        new Servicio
        {
            Id = 1,
            Codigo = "SRV-001",
            Nombre = "Consulta de Cardiología + Electrocardiograma",
            Especialidad = "Cardiología",
            Precio = 150.00m,
            DuracionMinutos = 45,
            Modalidad = "Presencial",
            Imagen = "https://images.unsplash.com/photo-1628348068343-c6a848d2b6dd?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Evaluación integral del sistema cardiovascular con lectura inmediata de electrocardiograma de 12 derivaciones."
        },
        new Servicio
        {
            Id = 2,
            Codigo = "SRV-002",
            Nombre = "Evaluación Dermatológica con Dermatoscopía Digital",
            Especialidad = "Dermatología",
            Precio = 130.00m,
            DuracionMinutos = 30,
            Modalidad = "Presencial / Teleconsulta",
            Imagen = "https://images.unsplash.com/photo-1612349317150-e413f6a5b16d?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Diagnóstico especializado de afecciones cutáneas, mapeo de lunares y tratamiento dermatológico personalizado."
        },
        new Servicio
        {
            Id = 3,
            Codigo = "SRV-003",
            Nombre = "Perfil Bioquímico y Hemograma Automatizado",
            Especialidad = "Laboratorio Clínico",
            Precio = 85.00m,
            DuracionMinutos = 20,
            Modalidad = "Presencial / Toma a Domicilio",
            Imagen = "https://images.unsplash.com/photo-1579154204601-01588f351e67?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Análisis completo de sangre con entrega de resultados digitales en menos de 6 horas."
        },
        new Servicio
        {
            Id = 4,
            Codigo = "SRV-004",
            Nombre = "Consulta de Medicina General e Integral",
            Especialidad = "Medicina General",
            Precio = 70.00m,
            DuracionMinutos = 30,
            Modalidad = "Presencial / Teleconsulta",
            Imagen = "https://images.unsplash.com/photo-1505751172876-fa1923c5c528?auto=format&fit=crop&w=800&q=80",
            Descripcion = "Atención primaria, diagnóstico oportuno, emisión de recetas médicas y seguimiento clínico."
        }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico
        {
            Id = 1,
            Cmp = "CMP-45892",
            NombreCompleto = "Dr. Alejandro Mendoza Ríos",
            Especialidad = "Cardiología",
            AniosExperiencia = 14,
            HorarioAtencion = "Lun - Vie: 08:00 - 14:00",
            TarifaConsulta = 150.00m,
            Calificacion = 4.9,
            Foto = "https://images.unsplash.com/photo-1612349317150-e413f6a5b16d?auto=format&fit=crop&w=600&q=80"
        },
        new Medico
        {
            Id = 2,
            Cmp = "CMP-51204",
            NombreCompleto = "Dra. Valeria Salazar Paredes",
            Especialidad = "Dermatología",
            AniosExperiencia = 10,
            HorarioAtencion = "Lun - Sáb: 09:00 - 17:00",
            TarifaConsulta = 130.00m,
            Calificacion = 4.8,
            Foto = "https://images.unsplash.com/photo-1594824476967-48c8b964273f?auto=format&fit=crop&w=600&q=80"
        },
        new Medico
        {
            Id = 3,
            Cmp = "CMP-39811",
            NombreCompleto = "Dr. Ricardo Vargas Cáceres",
            Especialidad = "Medicina General",
            AniosExperiencia = 12,
            HorarioAtencion = "Lun - Sáb: 07:00 - 19:00",
            TarifaConsulta = 70.00m,
            Calificacion = 4.7,
            Foto = "https://images.unsplash.com/photo-1537368910025-700350fe46c7?auto=format&fit=crop&w=600&q=80"
        },
        new Medico
        {
            Id = 4,
            Cmp = "CMP-60432",
            NombreCompleto = "Dra. Camila Torres Gutiérrez",
            Especialidad = "Nutrición y Bienestar",
            AniosExperiencia = 8,
            HorarioAtencion = "Mar - Sáb: 10:00 - 18:00",
            TarifaConsulta = 100.00m,
            Calificacion = 4.9,
            Foto = "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?auto=format&fit=crop&w=600&q=80"
        }
    };

    public static List<Promocion> Promociones { get; } = new()
    {
        new Promocion
        {
            Id = 1,
            CodigoCupon = "SALUD20",
            Titulo = "20% DCTO en Chequeos Preventivos",
            Descripcion = "Descuento especial en todos los paquetes preventivos y perfiles de laboratorio durante octubre.",
            PorcentajeDescuento = 20,
            CategoriaAplicable = "Paquetes Preventivos",
            Vigencia = "Hasta el 31 de Octubre 2026",
            Activa = true
        },
        new Promocion
        {
            Id = 2,
            CodigoCupon = "CARDIO15",
            Titulo = "15% DCTO en Equipos de Monitoreo",
            Descripcion = "Promoción en tensiómetros digitales, oxímetros y glucómetros seleccionados.",
            PorcentajeDescuento = 15,
            CategoriaAplicable = "Equipos de Monitoreo",
            Vigencia = "Hasta el 30 de Noviembre 2026",
            Activa = true
        },
        new Promocion
        {
            Id = 3,
            CodigoCupon = "DERMO10",
            Titulo = "10% DCTO en Dermatología Clínica",
            Descripcion = "Cuida tu piel con fotoprotectores y dermoestética médica certificada.",
            PorcentajeDescuento = 10,
            CategoriaAplicable = "Dermatología Clínica",
            Vigencia = "Todo el año 2026",
            Activa = true
        }
    };
}
