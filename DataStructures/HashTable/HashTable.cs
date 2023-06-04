using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        public string[] _hashTable { get; set; }

        public HashTable()
        {
            _hashTable = new string[10];
        }

        public void Set(string key, string value)
        {
            int hashedKey = _hash(key);
            if (_hashTable[hashedKey] != null)
            {
                throw new Exception("Key already exists");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }

        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];
        }

        // Incorrect has key, will cause collisions due to length being repeated
        // TODO: generate a better hash key
        private int _hash(string key)
        {
            return key.Length % _hashTable.Length;
        }
    }
}
