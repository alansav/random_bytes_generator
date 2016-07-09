# random_bytes_generator

This project is a .NET Core class library.

This project is designed to generate an array of random bytes as securely as possible.

## Why
Developers often have a requirement to generate an array of random bytes. The current recommended best practice in .NET is to use the System.Security.Cryptography.RandomNumberGenerator. This class library provides static methods to enable a developer to quickly create an array of bytes with their requireed length.

##Usage

In your project use nuget to add a reference to random_bytes_generator:

`Install-Package RandomBytesGenerator`

```
var result = Savage.RandomBytesGenerator.Generate(32); //an array of random bytes (length = 32)
var resultBase64 = Savage.RandomBytesGenerator.GenerateAsBase64(16); // a string containing base64 encoded random bytes (length 16) (i.e. "Q2yNFINfe85i6xH7t5+CSw==")
```