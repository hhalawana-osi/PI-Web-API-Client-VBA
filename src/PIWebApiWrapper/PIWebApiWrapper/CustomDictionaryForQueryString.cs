// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PIWebAPIWrapper
{
    public class CustomDictionaryForQueryString
    {
        private List<KeyValuePair<String, String>> items = new List<KeyValuePair<String, String>>();
        public void Add(string key, string value)
        {
            //
            string[] queryStringWords = value.Split(',');
            foreach (var item in queryStringWords)
            {
                items.Add(new KeyValuePair<string, string>(key, item));
            }
        }


        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        public class MyEnumerator
        {
            int nIndex;
            CustomDictionaryForQueryString collection;
            public MyEnumerator(CustomDictionaryForQueryString coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.items.Count);
            }

            public KeyValuePair<String, String> Current
            {
                get
                {
                    return (collection.items[nIndex]);
                }
            }
        }
    }
}
