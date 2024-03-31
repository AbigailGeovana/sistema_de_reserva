namespace sistemaReservas
{
    public class Reservation
    {
        public int Id { get; set; }
        public int EstablishmentTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
    }
}