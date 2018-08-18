using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OneTimePad.Test
{
    public class ConsistencyTest
    {
        [Fact]
        public void CheckConsistency()
        {
            byte[] bytes = new byte[] { 5, 8, 5, 1, 2, 3, 32, 64 };
            byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Equal(bytes, OneTimePad.Decrypt(key, OneTimePad.Encrypt(key, bytes)));
        }
    }
}