using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceTrackerService
    {
        private readonly List<RegistrationModel> _registrations = new();

        public IEnumerable<RegistrationModel> GetRegistrationsForEvent(int eventId)
        {
            return _registrations.Where(r => r.EventId == eventId);
        }

        public IEnumerable<RegistrationModel> GetRegistrationsForUser(string email)
        {
            return _registrations.Where(r => r.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void RegisterForEvent(RegistrationModel registration)
        {
            if (!_registrations.Any(r => r.EventId == registration.EventId && r.Email == registration.Email))
            {
                _registrations.Add(registration);
            }
        }

        public bool IsUserRegistered(int eventId, string email)
        {
            return _registrations.Any(r => r.EventId == eventId && r.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
