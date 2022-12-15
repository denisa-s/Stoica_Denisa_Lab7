namespace Stoica_Denisa_Lab7
{
    internal class NotificationRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public NotificationRequestSchedule Schedule { get; set; }
    }
}