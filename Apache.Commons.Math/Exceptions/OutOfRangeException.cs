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
using Apache.Commons.Math.Exceptions.Util;

namespace Apache.Commons.Math.Exceptions
{
    /// <summary>
    /// Exception to be thrown when some argument is out of range.
    /// </summary>
    [Serializable]
    public class OutOfRangeException<T>: MathIllegalNumberException<T>
    {
        /// <summary>
        /// The lower bound.
        /// </summary>
        public T Lo { get; private set; }
        
        /// <summary>
        /// The higher bound.
        /// </summary>
        public T Hi { get; private set; }

        /// <summary>
        /// Construct an exception from the mismatched data.
        /// </summary>
        /// <param name="wrong">The wrong value</param>
        /// <param name="lo">Lower bound</param>
        /// <param name="hi">Higher bound</param>
        public OutOfRangeException(T wrong, T lo, T hi) : this(LocalizedFormats.OUT_OF_RANGE_SIMPLE, wrong, lo, hi) { }

        /// <summary>
        /// Construct an exception from the mismatched dimensions with a specific context information.
        /// </summary>
        /// <param name="specific">Context information.</param>
        /// <param name="wrong">Requested value.</param>
        /// <param name="lo">Lower bound.</param>
        /// <param name="hi">Higher bound.</param>
        public OutOfRangeException(ILocalizable specific, T wrong, T lo, T hi):
            base(specific, wrong, lo, hi)
        {
            this.Lo = lo;
            this.Hi = hi;
        }
    }
}
