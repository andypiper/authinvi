# Authinvi

[![license](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://github.com/andypiper/TwitterDotNetCore/blob/master/LICENSE) [![v1.1](https://img.shields.io/endpoint?url=https%3A%2F%2Ftwbadges.glitch.me%2Fbadges%2Fstandard)](https://developer.twitter.com/en/docs/authentication/oauth-1-0a/pin-based-oauth) [![Twitter Follow](https://badgen.net/twitter/follow/andypiper)](https://twitter.com/intent/follow?screen_name=andypiper)

Authinvi is a .NET console application library for authenticating Twitter users to Twitter apps, using PIN-based authentication

If you have a Twitter app that supports Sign-in With Twitter, you can authenticate additional Twitter users to the app and retrieve user access token and access token secrets, via a web-browser and PIN-based login flow. This is useful when authenticating multiple users to an app when you don't want to build a full authentication backend - for example, authenticating "bot" users to a script or application of your choice

## Build & Run

This was built using .NET Core 3.1 and Tweetinvi 5.0.1. Assuming these are available, you should be in good shape.

To start from scratch (skipping all of the command outputs):

```
$ dotnet new console // creates the app skeleton
$ dotnet add package tweetinviapi // installs the latest Tweetinvi from nuget

...
// you've got this code - just wanted to get you bootstrapped
...

$ dotnet run [CONSUMER_KEY] [CONSUMER_SECRET] // from Twitter app dashboard

-- OR --

$ dotnet dotnet publish -r win10-x64 -c Release /p:PublishSingleFile=true // builds a single .exe
$ authinvi [CONSUMER_KEY] [CONSUMER_SECRET] // from release folder
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)