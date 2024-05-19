using OpenClose;
using OpenClose.Principled;

// unprincipled
var hello = new Hello();
hello.Say("en");

// principled
var newHello = new NewHello();
newHello.Say(new French());