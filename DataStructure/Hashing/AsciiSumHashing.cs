using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    class AsciiSumHashing
    {
        private const int modulo = 10;
        private int Hash(string key)
        {
            var keyStr = key.ToString();
            var asciiSum = keyStr.Sum(x => (int)x);
            return asciiSum % modulo;
        }

        public KeyValuePair<int, string>[] map = new KeyValuePair<int, string>[10];
        public string this[int key]
        {
            get { return map[Hash(key.ToString())].Value; }
            set { map[Hash(key.ToString())] = new KeyValuePair<int, string>(key, value); }
        }

        public void Add(int key, string value)
        {
            var idx = Hash(key.ToString());
            map[idx] = new KeyValuePair<int, string>(key, value);
        }
    }
}
