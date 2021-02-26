using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavigateAround.Services
{
    public class AlertService
    {
        private List<Alert> _alerts = new List<Alert>();
        
        public List<Alert> GetAlerts()
        {
            var tmp = _alerts.ToList();
            _alerts = new List<Alert>();
            return tmp;
        }

        public void AddAlert(Alert alert)
        {
            _alerts.Add(alert);
        }
    }
}
