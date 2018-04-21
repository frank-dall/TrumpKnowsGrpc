using System;
using System.IO;
using System.Threading.Tasks;
using Trump;
using Grpc.Core;

namespace TrumpKnowsGrpcServer
{
  internal class TrumpKnowsImpl : TrumpKnows.TrumpKnowsBase
  {
    private readonly Tweets _trumpTweets = Tweets.Parser.ParseJson(File.ReadAllText("../trump.json"));

    public override Task<Tweet> AskForATrumpTweet(BigLeagueRequest request, ServerCallContext context)
    {
      var tweets = _trumpTweets.AllTweets;
      // generate a random index, with an upper bound of the trump.json tweet length
      var randomIndex = new Random().Next(tweets.Count);

      return Task.FromResult(new Tweet(tweets[randomIndex]));
    }
  }

  internal static class Program
  {
    private const int Port = 50051;

    public static void Main()
    {
      var server = new Server
      {
        Services = {TrumpKnows.BindService(new TrumpKnowsImpl())},
        Ports = {new ServerPort("localhost", Port, ServerCredentials.Insecure)}
      };
      server.Start();

      Console.WriteLine("TrumpKnows server listening on port " + Port);
      Console.WriteLine("Press any key to stop the server...");
      Console.ReadKey();

      server.ShutdownAsync().Wait();
    }
  }
}