namespace Fly.Dal.EF
{
    public class Ticket
    {
        public int Id { get; set; }
        public int? PlanId { get; set; }
        public int? UserId { get; set; }
        public decimal Cost { get; set; }
        public bool Paid { get; set; }
        public Plan Plan { get; set; }
        public User User { get; set; }
    }
}
