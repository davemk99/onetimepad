# onetimepad
Implementation of One Time Pad Cipher.

For encryption you must provide key and message to encrypt as byte arrays.
Key and Message must have the same length.
You can call static OneTimePad.Encrypt method to do so.

```
byte[] bytes = new byte[] { 5, 8, 5, 1, 2, 3, 32, 64 };
byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var cipher=OneTimePad.Encrypt(key, bytes);
```

For decryption you must provide key and cipher as byte arrays.
Key and Cipher must have the same length
You can call static OneTimePad.Decrypt method to do so.

```
byte[] bytes = new byte[] { 5, 8, 5, 1, 2, 3, 32, 64 };
byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var message=OneTimePad.Decrypt(key, bytes);
```

It's not in any mean production use cipher algorithm and I write it simply for fun.
