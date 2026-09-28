namespace TP.Api.Models;

public class ObjetoPerdido
{
    private int id;
    private string descripcion = string.Empty;
    private string categoria = string.Empty;
    private string lugarEncontrado = string.Empty;
    private DateTime fechaEncontrado;
    private bool reclamado;
    private string? nombrePersonaQueRetiro;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Descripcion
    {
        get { return this.descripcion; }
        set { this.descripcion = value; }
    }
    public string Categoria
    {
        get { return this.categoria; }
        set { this.categoria = value; }
    }
    public string LugarEncontrado
    {
        get { return this.lugarEncontrado; }
        set { this.lugarEncontrado = value; }
    }
    public DateTime FechaEncontrado
    {
        get { return this.fechaEncontrado; }
        set { this.fechaEncontrado = value; }
    }
    public bool Reclamado
    {
        get { return this.reclamado; }
        set { this.reclamado = value; }
    }
    public string? NombrePersonaQueRetiro
    {
        get { return this.nombrePersonaQueRetiro; }
        set { this.nombrePersonaQueRetiro = value; }
    }
}

public class Estacion
{
    private int id;
    private string nombre = string.Empty;
    private string localidad = string.Empty;
    private bool activa = true;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Localidad
    {
        get { return this.localidad; }
        set { this.localidad = value; }
    }
    public bool Activa
    {
        get { return this.activa; }
        set { this.activa = value; }
    }
}

public class Medicion
{
    private int id;
    private int estacionId;
    private double temperatura;
    private double humedad;
    private double velocidadViento;
    private DateTime fechaHora;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int EstacionId
    {
        get { return this.estacionId; }
        set { this.estacionId = value; }
    }
    public double Temperatura
    {
        get { return this.temperatura; }
        set { this.temperatura = value; }
    }
    public double Humedad
    {
        get { return this.humedad; }
        set { this.humedad = value; }
    }
    public double VelocidadViento
    {
        get { return this.velocidadViento; }
        set { this.velocidadViento = value; }
    }
    public DateTime FechaHora
    {
        get { return this.fechaHora; }
        set { this.fechaHora = value; }
    }
}

public class ParticipanteDesafio
{
    private int id;
    private string nombre = string.Empty;
    private string email = string.Empty;
    private string nivel = string.Empty;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    public string Nivel
    {
        get { return this.nivel; }
        set { this.nivel = value; }
    }
}

public class Desafio
{
    private int id;
    private string titulo = string.Empty;
    private string dificultad = string.Empty;
    private int puntajeMaximo;
    private bool activo = true;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Titulo
    {
        get { return this.titulo; }
        set { this.titulo = value; }
    }
    public string Dificultad
    {
        get { return this.dificultad; }
        set { this.dificultad = value; }
    }
    public int PuntajeMaximo
    {
        get { return this.puntajeMaximo; }
        set { this.puntajeMaximo = value; }
    }
    public bool Activo
    {
        get { return this.activo; }
        set { this.activo = value; }
    }
}

public class Resolucion
{
    private int id;
    private int participanteId;
    private int desafioId;
    private int puntajeObtenido;
    private DateTime fechaEntrega;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int ParticipanteId
    {
        get { return this.participanteId; }
        set { this.participanteId = value; }
    }
    public int DesafioId
    {
        get { return this.desafioId; }
        set { this.desafioId = value; }
    }
    public int PuntajeObtenido
    {
        get { return this.puntajeObtenido; }
        set { this.puntajeObtenido = value; }
    }
    public DateTime FechaEntrega
    {
        get { return this.fechaEntrega; }
        set { this.fechaEntrega = value; }
    }
}

public class Drone
{
    private int id;
    private string codigo = string.Empty;
    private string modelo = string.Empty;
    private int bateria;
    private string estado = "Disponible";
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Codigo
    {
        get { return this.codigo; }
        set { this.codigo = value; }
    }
    public string Modelo
    {
        get { return this.modelo; }
        set { this.modelo = value; }
    }
    public int Bateria
    {
        get { return this.bateria; }
        set { this.bateria = value; }
    }
    public string Estado
    {
        get { return this.estado; }
        set { this.estado = value; }
    }
}

public class Mision
{
    private int id;
    private int droneId;
    private string descripcion = string.Empty;
    private double distanciaKm;
    private DateTime fecha;
    private bool completada;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int DroneId
    {
        get { return this.droneId; }
        set { this.droneId = value; }
    }
    public string Descripcion
    {
        get { return this.descripcion; }
        set { this.descripcion = value; }
    }
    public double DistanciaKm
    {
        get { return this.distanciaKm; }
        set { this.distanciaKm = value; }
    }
    public DateTime Fecha
    {
        get { return this.fecha; }
        set { this.fecha = value; }
    }
    public bool Completada
    {
        get { return this.completada; }
        set { this.completada = value; }
    }
}

public class Actividad
{
    private int id;
    private string nombre = string.Empty;
    private string tipo = string.Empty;
    private DateTime horario;
    private int duracionMinutos;
    private int capacidad;
    private bool activa = true;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Tipo
    {
        get { return this.tipo; }
        set { this.tipo = value; }
    }
    public DateTime Horario
    {
        get { return this.horario; }
        set { this.horario = value; }
    }
    public int DuracionMinutos
    {
        get { return this.duracionMinutos; }
        set { this.duracionMinutos = value; }
    }
    public int Capacidad
    {
        get { return this.capacidad; }
        set { this.capacidad = value; }
    }
    public bool Activa
    {
        get { return this.activa; }
        set { this.activa = value; }
    }
}

public class ParticipanteFestival
{
    private int id;
    private string nombre = string.Empty;
    private string email = string.Empty;
    private int edad;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    public int Edad
    {
        get { return this.edad; }
        set { this.edad = value; }
    }
}

public class ReservaActividad
{
    private int id;
    private int actividadId;
    private int participanteId;
    private DateTime fechaReserva;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int ActividadId
    {
        get { return this.actividadId; }
        set { this.actividadId = value; }
    }
    public int ParticipanteId
    {
        get { return this.participanteId; }
        set { this.participanteId = value; }
    }
    public DateTime FechaReserva
    {
        get { return this.fechaReserva; }
        set { this.fechaReserva = value; }
    }
}

public class ObjetoEspacial
{
    private int id;
    private string nombre = string.Empty;
    private string tipo = string.Empty;
    private double distancia;
    private int nivelRiesgo;
    private DateTime fechaDescubrimiento;
    private bool activo = true;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Tipo
    {
        get { return this.tipo; }
        set { this.tipo = value; }
    }
    public double Distancia
    {
        get { return this.distancia; }
        set { this.distancia = value; }
    }
    public int NivelRiesgo
    {
        get { return this.nivelRiesgo; }
        set { this.nivelRiesgo = value; }
    }
    public DateTime FechaDescubrimiento
    {
        get { return this.fechaDescubrimiento; }
        set { this.fechaDescubrimiento = value; }
    }
    public bool Activo
    {
        get { return this.activo; }
        set { this.activo = value; }
    }
}

public class Observacion
{
    private int id;
    private int objetoEspacialId;
    private DateTime fecha;
    private double distanciaMedida;
    private double velocidad;
    private string comentario = string.Empty;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int ObjetoEspacialId
    {
        get { return this.objetoEspacialId; }
        set { this.objetoEspacialId = value; }
    }
    public DateTime Fecha
    {
        get { return this.fecha; }
        set { this.fecha = value; }
    }
    public double DistanciaMedida
    {
        get { return this.distanciaMedida; }
        set { this.distanciaMedida = value; }
    }
    public double Velocidad
    {
        get { return this.velocidad; }
        set { this.velocidad = value; }
    }
    public string Comentario
    {
        get { return this.comentario; }
        set { this.comentario = value; }
    }
}

public class Expedicion
{
    private int id;
    private string nombre = string.Empty;
    private string destino = string.Empty;
    private DateTime fechaInicio;
    private DateTime fechaFin;
    private int capacidad;
    private string estado = "Futura";
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Destino
    {
        get { return this.destino; }
        set { this.destino = value; }
    }
    public DateTime FechaInicio
    {
        get { return this.fechaInicio; }
        set { this.fechaInicio = value; }
    }
    public DateTime FechaFin
    {
        get { return this.fechaFin; }
        set { this.fechaFin = value; }
    }
    public int Capacidad
    {
        get { return this.capacidad; }
        set { this.capacidad = value; }
    }
    public string Estado
    {
        get { return this.estado; }
        set { this.estado = value; }
    }
}

public class Explorador
{
    private int id;
    private string nombre = string.Empty;
    private string especialidad = string.Empty;
    private int experienciaAnios;
    private bool disponible = true;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    public string Especialidad
    {
        get { return this.especialidad; }
        set { this.especialidad = value; }
    }
    public int ExperienciaAnios
    {
        get { return this.experienciaAnios; }
        set { this.experienciaAnios = value; }
    }
    public bool Disponible
    {
        get { return this.disponible; }
        set { this.disponible = value; }
    }
}

public class Participacion
{
    private int id;
    private int expedicionId;
    private int exploradorId;
    private string rol = string.Empty;
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public int ExpedicionId
    {
        get { return this.expedicionId; }
        set { this.expedicionId = value; }
    }
    public int ExploradorId
    {
        get { return this.exploradorId; }
        set { this.exploradorId = value; }
    }
    public string Rol
    {
        get { return this.rol; }
        set { this.rol = value; }
    }
}

public static class Datos
{
    public static List<ObjetoPerdido> Objetos { get; } = new List<ObjetoPerdido>();
    public static List<Estacion> Estaciones { get; } = new List<Estacion>();
    public static List<Medicion> Mediciones { get; } = new List<Medicion>();
    public static List<ParticipanteDesafio> ParticipantesDesafio { get; } = new List<ParticipanteDesafio>();
    public static List<Desafio> Desafios { get; } = new List<Desafio>();
    public static List<Resolucion> Resoluciones { get; } = new List<Resolucion>();
    public static List<Drone> Drones { get; } = new List<Drone>();
    public static List<Mision> Misiones { get; } = new List<Mision>();
    public static List<Actividad> Actividades { get; } = new List<Actividad>();
    public static List<ParticipanteFestival> ParticipantesFestival { get; } = new List<ParticipanteFestival>();
    public static List<ReservaActividad> Reservas { get; } = new List<ReservaActividad>();
    public static List<ObjetoEspacial> ObjetosEspaciales { get; } = new List<ObjetoEspacial>();
    public static List<Observacion> Observaciones { get; } = new List<Observacion>();
    public static List<Expedicion> Expediciones { get; } = new List<Expedicion>();
    public static List<Explorador> Exploradores { get; } = new List<Explorador>();
    public static List<Participacion> Participaciones { get; } = new List<Participacion>();
}
