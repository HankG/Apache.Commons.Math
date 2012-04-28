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
using Apache.Commons.Math.Util;
using Apache.Commons.Math.Exceptions.Util;

namespace Apache.Commons.Math.Exceptions
{
    /// <summary>
    /// Exception to be thrown when a sequence of values is not monotonically increasing or decreasing.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class NonMonotonicSequenceException<T>: MathIllegalNumberException<T>
    {
        /// <summary>
        /// Direction (positive for increasing, negative for decreasing).
        /// </summary>
        public OrderDirection Direction { get; private set; }
        /// <summary>
        /// Whether the sequence must be strictly increasing or decreasing.
        /// </summary>
        public bool Strict { get; private set; }
        /// <summary>
        /// Index of the wrong value.
        /// </summary>
        public int Index { get; private set; }
        /// <summary>
        /// Previous value.
        /// </summary>
        public T Previous { get; private set; }

        /// <summary>
        /// Construct the exception.
        /// <para>This constructor used default values assuming that the sequence should
        /// have been strictly increasing.</para>
        /// </summary>
        /// <param name="wrong">The value that did not match the requirements.</param>
        /// <param name="previous">Previous value in the sequence.</param>
        /// <param name="index">Index of the value that did not match the sequence.</param>
        public NonMonotonicSequenceException(T wrong, T previous, int index) :
            this(wrong, previous, index, OrderDirection.Increasing, true) { }

        public NonMonotonicSequenceException(T wrong, T previous, int index, OrderDirection direction, bool strict):
            base(direction == OrderDirection.Increasing ?
            (strict ? LocalizedFormats.NOT_STRICTLY_INCREASING_SEQUENCE : LocalizedFormats.NOT_INCREASING_SEQUENCE) :
            (strict ? LocalizedFormats.NOT_STRICTLY_DECREASING_SEQUENCE : LocalizedFormats.NOT_DECREASING_SEQUENCE),
            wrong, previous, index, index - 1)
        {
            this.Direction = direction;
            this.Strict = strict;
            this.Index = index;
            this.Previous = previous;
        }
    }
}
