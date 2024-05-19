using LiskovSubstitution;

var note = new Note(459);
note.Save("Let's do this!");

// unprincipled
var readonlyNote = new ReadonlyNote(459);
readonlyNote.Save("Let's do this!"); // an exception is thrown

// principled
var writableNote = new LiskovSubstitution.Principled.WritableNote(459);
writableNote.Save("Let's do this!");