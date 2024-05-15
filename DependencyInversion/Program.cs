using DependencyInversion;
using DependencyInversion.Principled;

// unprinciled
var log = new Log();
log.Update();

var newLog = new PrincipledLog(new DependencyInversion.Principled.MySql());
newLog.Update();
