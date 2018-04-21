'use strict'

const grpc = require('grpc')
  , PROTO_PATH = __dirname + '/../protos/trump.proto'
  , protoDescriptor = grpc.load(PROTO_PATH)
  , trump = protoDescriptor.trump
  , client = new trump.TrumpKnows('localhost:50051', grpc.credentials.createInsecure())
  , req = 'foo'

client.askForATrumpTweet(req, function(err, tweet) {
    if (err) {
        // process error
        console.log(err)
    } else {
        // process feature
        console.log(tweet.text)
        console.log(`favorites: ${tweet.favorite_count}`)
        console.log(`retweets: ${tweet.retweet_count}`)
    }
})
