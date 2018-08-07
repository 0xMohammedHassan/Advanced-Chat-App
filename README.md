# Advanced-Chat-App
Chat Application with 2 Encryption modes


Task definition:

-This is a program coded with Vb.net/PHP that use TCP protocol to communicate between two devices. 

Definition of an algorithm and mode of operation :
1-DES Algorithm:
The Data Encryption Standard is a symmetric-key algorithm for the encryption of data. Although now considered insecure, it was highly influential in the advancement of modern cryptography.

Developed in the early 1970s at IBM and based on an earlier design by Horst Feistel, the algorithm was submitted to the National Bureau of Standards (NBS) following the agency's invitation to propose a candidate for the protection of sensitive, unclassified electronic government data.

2- CBC mode:
Ehrsam, Meyer, Smith and Tuchman invented the Cipher Block Chaining (CBC) mode of operation in 1976. In CBC mode, each block of plaintext is XORed with the previous ciphertext block before being encrypted. This way, each ciphertext block depends on all plaintext blocks processed up to that point. To make each message unique, an initialization vector must be used in the first block.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
1-AES Algorithm :
The Advanced Encryption Standard (AES), also known by its original name Rijndael is a specification for the encryption of electronic data established by the U.S. National Institute of Standards and Technology (NIST) in 2001.

AES is a subset of the Rijndael cipher developed by two Belgian cryptographers, Vincent Rijmen and Joan Daemen, who submitted a proposal to NIST during the AES selection process. Rijndael is a family of ciphers with different key and block sizes.

For AES, NIST selected three members of the Rijndael family, each with a block size of 128 bits, but three different key lengths: 128, 192 and 256 bits.


2-CTR mode:
Counter mode turns a block cipher into a stream cipher. It generates the next keystream block by encrypting successive values of a "counter". The counter can be any function which produces a sequence which is guaranteed not to repeat for a long time, although an actual increment-by-one counter is the simplest and most popular. The usage of a simple deterministic input function used to be controversial; critics argued that "deliberately exposing a cryptosystem to a known systematic input represents an unnecessary risk."However, today CTR mode is widely accepted and any problems are considered a weakness of the underlying block cipher, which is expected to be secure regardless of systemic bias in its input. Along with CBC, CTR mode is one of two block cipher modes recommended by Niels Ferguson and Bruce Schneier.



*Description of Application and Source codes:
-In folder Executable File contain the chat application.
-In Folder ChatApp contain the source code of chat application coded with vb.net.
-in Folder Helpers contain the encryption algorithm .
-Requirement text contain the instruction about how to setup application and the requirement third party application to use it.

*Application Tests on run-time tests:

         


-Experiments results:
After running the application we will need to set an IP and Port on host and it must be the same on client device, also the port must be available on windows so we cant use busy ports, After setting the IP and port we need to click on "Make me host" to make the program running as a host and start listening to incoming connections from the client, on client side we need to click on "Connect" to start the communication with the host, Also we need to start Apache service on windows by installing program called "Xamp" or any program  can start this service , and this service is important to run the algorithms scripts fine.
Also the algorithm script must be on this path's:
C:\xampp\htdocs\enc.php
C:\xampp\htdocs\ACC\

Otherwise the algorithms wont be running.

*Conclusion:
-This is an implement of principals of Client/Server
And encrypting strings between it by using DES-CBC and AES-CTR algorithms,and it can be worked on LAN network flawlessly .

-References:
https://en.wikipedia.org/wiki/Data_Encryption_Standard
https://en.wikipedia.org/wiki/Block_cipher_mode_of_operation
https://en.wikipedia.org/wiki/Advanced_Encryption_Standard
https://stackoverflow.com
