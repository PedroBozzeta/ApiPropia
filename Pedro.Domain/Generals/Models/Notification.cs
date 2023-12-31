﻿namespace Pedro.Domain.Generals.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int NotificationActionId {  get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State {  get; set; }
        public virtual NotificationAction NotificationAction { get; set; }
    }
}
