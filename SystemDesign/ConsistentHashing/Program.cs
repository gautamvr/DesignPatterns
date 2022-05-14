
using ConsistentHashing;

List<Server> rackServers = new List<Server>();
rackServers.Add(new Server("10.0.0.1"));
rackServers.Add(new Server("10.0.0.2"));
int numberOfReplicas = 1;
ConsistentHasher serverDistributor = new ConsistentHasher(numberOfReplicas, rackServers);
//add a new server to the mix
Server newServer = new Server("10.0.0.3");
serverDistributor.addServerToHashRing(newServer);
//Assume we have a key "key0"
Server serverForKey = serverDistributor.GetServerForKey("key0");
Console.WriteLine("Server: " + serverForKey.ipAddress + " holds key: Key0");
// Now remove a server
serverDistributor.removeServerFromHashRing(newServer);
Console.WriteLine($"Server: {newServer.ipAddress} is now removed from the ring");
// Now check on which server "key0" landed up
serverForKey = serverDistributor.GetServerForKey("key0");
Console.WriteLine("Server: " + serverForKey.ipAddress + " holds key: Key0");
