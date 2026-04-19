using MediatorPattern.Colleagues;
using MediatorPattern.Mediators;

Console.WriteLine("== Mediator Pattern: Team Chat ==\n");

var chatRoom = new ChatRoomMediator();
var alice = new User("Alice", chatRoom);
var bob = new User("Bob", chatRoom);
var carol = new User("Carol", chatRoom);

chatRoom.Register(alice);
chatRoom.Register(bob);
chatRoom.Register(carol);

alice.Send("Standup in 5 minutes.");
bob.Send("On my way!");
