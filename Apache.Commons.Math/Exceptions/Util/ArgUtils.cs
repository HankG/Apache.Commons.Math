/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apache.Commons.Math.Exceptions.Util
{
    /// <summary>
    /// Utility class for transforming the list of arguments passed to constructors of exceptions.
    /// </summary>
    public static class ArgUtils
    {
        /// <summary>
        /// Transform a multidimensional array into a one-dimensional list.
        /// </summary>
        /// <param name="array">Array, possibly multidimensional.</param>
        /// <returns>A list of all the <c>object</c> instances contained in <paramref name="array"/>.</returns>
        public static object[] Flatten(this object[] array)
        {
            var list = new List<object>();
            if (array != null)
            {
                foreach (object o in array)
                {
                    var objs = o as object[];
                    if (objs != null)
                    {
                        foreach (object or in objs.Flatten())
                            list.Add(or);
                    }
                    else
                    {
                        list.Add(o);
                    }
                }
            }
            return list.ToArray();
        }
    }
}
