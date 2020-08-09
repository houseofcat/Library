﻿using System.Threading.Tasks;

namespace HouseofCat.Hashing
{
    public interface IHashingProvider
    {
        string Type { get; }
        Task<byte[]> GetHashKeyAsync(byte[] passphrase, byte[] salt, int size);
        Task<byte[]> GetHashKeyAsync(string passphrase, string salt, int size);
    }
}