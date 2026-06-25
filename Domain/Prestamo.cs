namespace biblioteca_API.Domain;


    public class Prestamo
    {
        public int Id { get; set; }

        // Relación con el Libro
        public int LibroId { get; set; }
        public Libro? Libro { get; set; }

        // Relación con el Usuario
        public int UsuarioId { get; set; }
        public Usuarios? Usuario { get; set; }

        // Fechas del préstamo
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;
        public DateTime? FechaDevolucion { get; set; } // Puede ser nula hasta que se devuelva
    }


