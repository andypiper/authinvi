using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Tweetinvi;

// trivial sample to print access token and secret from PIN-based OAuth
// basically a runabble implementation of
// https://linvi.github.io/tweetinvi/dist/authentication/authentication-pin-code.html

// TODO: add help and error handling
// TODO: add the ability to revoke instead of issue

namespace authinvi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var appClient = new TwitterClient(args[0], args[1]);

            // Start the authentication process
            var authenticationRequest = await appClient.Auth.RequestAuthenticationUrlAsync();
            Console.WriteLine(authenticationRequest);

            // Go to the URL so that Twitter authenticates the user and returns a PIN code
            Process.Start(new ProcessStartInfo(authenticationRequest.AuthorizationURL)
            {
                UseShellExecute = true
            });

            // Ask the user to enter the PIN code returned by Twitter
            Console.WriteLine("Please enter the code and press enter.");
            var pinCode = Console.ReadLine();

            // With this PIN code it is now possible to get the credentials back from Twitter
            var userCredentials = await appClient.Auth.RequestCredentialsFromVerifierCodeAsync(pinCode, authenticationRequest);

            // Save (in userCredentials) and print the credentials
            var userClient = new TwitterClient(userCredentials);
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine("\nAuthenticated user  : " + user);
            Console.WriteLine("Access Token        : " + userCredentials.AccessToken);
            Console.WriteLine("Access Token Secret : " + userCredentials.AccessTokenSecret);

        }
    }
}

