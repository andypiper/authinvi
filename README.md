# Inviauth

Inviauth is a .NET console application library for authenticating Twitter users to Twitter apps, using PIN-based authentication

If you have a Twitter app that supports Sign-in With Twitter, you can authenticate additional Twitter users to the app and retrieve user access token and access token secrets, via a web-browser and PIN-based login flow. This is useful when authenticating multiple users to an app when you don't want to build a full authentication backend - for example, authenticating "bot" users to a script or application of your choice

## Building

This was built using .NET Core 3.1 and Tweetinvi 5.0.1. Assuming these are installed, you should be in good shape.

To start from scratch (skipping all of the command outputs):

```
$ dotnet new console // creates the app skeleton
$ dotnet add package tweetinviapi // installs the latest Tweetinvi from nuget

...
// you've got this code - just wanted to get you bootstrapped
...

$ dotnet run [CONSUMER_KEY] [CONSUMER_SECRET] // from Twitter app dashboard

-- OR --

$ dotnet publish -r win-x64 -c release // builds a release .exe
$ inviauth  [CONSUMER_KEY] [CONSUMER_SECRET] // from release folder

-- OR --

$ dotnet tool install -g dotnet-warp
$ dotnet warp // builds a smaller release .exe
$ inviauth  [CONSUMER_KEY] [CONSUMER_SECRET] // from release folder
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)