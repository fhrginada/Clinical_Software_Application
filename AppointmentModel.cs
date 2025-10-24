using System;
namespace Clinical_project.API.Models
{

	public class AppointmentModel
	{
		public AppointmentModel()
		{

        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
    }
	}
}
