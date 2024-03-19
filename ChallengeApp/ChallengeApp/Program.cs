
using ChallengeApp;

User user1 = new User("Adam", "pipipi");
User user2 = new User("Zuzia", "pipipi");
User user3 = new User("Kamil", "pipipi");
User user4 = new User("Damian", "pipipi");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(10);
var result = user1.Result;
Console.WriteLine(result);



