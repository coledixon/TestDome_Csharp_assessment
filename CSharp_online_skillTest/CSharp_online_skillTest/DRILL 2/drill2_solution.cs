// SOLUTION // CD 2020
// PASSED 3 of 3 test cases
using System.Collections.Generic;
using System;

namespace CSharp_online_skillTest.DRILL_2
{
    public class AlertService
    {
        private readonly AlertDAO storage = new AlertDAO();
        public IAlertDAO _iad;

        public AlertService(IAlertDAO iad)
        {
            _iad = iad;
        }

        public Guid RaiseAlert()
        {
            return _iad.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _iad.GetAlert(id);
        }
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }

    public interface IAlertDAO
    {
        Guid AddAlert(DateTime time);
        DateTime GetAlert(Guid id);
    }
}