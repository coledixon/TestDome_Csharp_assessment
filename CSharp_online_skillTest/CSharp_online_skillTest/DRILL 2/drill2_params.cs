// DRILL PARAMETERS (3 test cases)

/*
 -- Create a new INTERFACE, named IAlertDAO, that containes the same methods as AlertDAO
 -- AlertDAO should implement the IAlertDAI interface.
 -- AlertService should have a constructor that accepts IAlertDAO.
 -- The RaiseAlert() and GetAlert() methods should use the object passed through the constructor.
 */


// BASE CODE PROVIDED
//using System.Collections.Generic;
//using System;

//public class AlertService
//{
//    private readonly AlertDAO storage = new AlertDAO();

//    public Guid RaiseAlert()
//    {
//        return this.storage.AddAlert(DateTime.Now);
//    }

//    public DateTime GetAlertTime(Guid id)
//    {
//        return this.storage.GetAlert(id);
//    }
//}

//public class AlertDAO
//{
//    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

//    public Guid AddAlert(DateTime time)
//    {
//        Guid id = Guid.NewGuid();
//        this.alerts.Add(id, time);
//        return id;
//    }

//    public DateTime GetAlert(Guid id)
//    {
//        return this.alerts[id];
//    }
//}