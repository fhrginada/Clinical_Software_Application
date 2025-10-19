namespace Clinical_project.API.Models
{
    public class SchedulesModel
    {
        public int ScheduleId { get; set; }
        public int DoctorID { get; set; }
        public DateTime AvalibleDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public String? SlotDuration { get; set; }

    }
}
