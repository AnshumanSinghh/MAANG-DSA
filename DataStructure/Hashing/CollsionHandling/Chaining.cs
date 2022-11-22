using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing.CollsionHandling
{
    class Chaining
    {
        private const int modulo = 10;
        private int Hash(string key)
        {
            var keyStr = key.ToString();
            var asciiSum = keyStr.Sum(x => (int)x);
            return asciiSum % modulo;
        }

        // Array<KV> ==> Array<List<KV>>
        private List<KeyValuePair<int, string>>[] map = new List<KeyValuePair<int, string>>[10];

        public string this[int key]
        {
            get { return GetValueByKey(map[Hash(key.ToString())], key); }
            set { SetValueByKey(key, value);}
        }

        private string GetValueByKey(List<KeyValuePair<int, string>> keyValueList, int key)
        {
            if (keyValueList == null)
            {
                return null;
            }
            foreach (var kv in keyValueList)
            {
                if (kv.Key == key)
                {
                    return kv.Value;
                }
            }
            return null;
        }

        private void SetValueByKey(int key, string value)
        {
            var idx = Hash(key.ToString());
            var keyValueList = map[idx];
            if (keyValueList == null)  // for the very first time we have to initialize and add key value
            {
                map[idx] = new List<KeyValuePair<int, string>> { new KeyValuePair<int, string> (key, value)};
            }
            // means not duplicate key and also already List is initialized
            else if (GetValueByKey(keyValueList, key) == null)
            {
                keyValueList.Add(new KeyValuePair<int, string>(key, value));
            }
            // if duplicate key throw error.
            else
            {
                throw new Exception("Duplicate Key Not Allowed.");
            }
        }

        public void Add(int key, string value)
        {
            SetValueByKey(key, value);
        }

        public string GetValue(int key)
        {
            var value = GetValueByKey(map[Hash(key.ToString())], key);
            Console.WriteLine($"Key: {key} and Value: {value}");
            return value;
        }
    }
}
