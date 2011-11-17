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
    /// Exception to be thrown when a number is too small.
    /// </summary>
    [Serializable]
    public class NumberIsTooSmallException<T>: MathIllegalNumberException<T>
    {
        /// <summary>
        /// Higher bound.
        /// </summary>
        public T Min { get; private set;}
        /// <summary>
        /// Whether the maximum is included in the allowed range.
        /// </summary>
        public bool BoundIsAllowed { get; private set; }

        /// <summary>
        /// Construct the exception.
        /// </summary>
        /// <param name="wrong">The wrong value.</param>
        /// <param name="min">The minimum value</param>
        /// <param name="boundIsAllowed">Whether <paramref name="min"/> is included in the allowed range.</param>
        public NumberIsTooSmallException(T wrong, T min, bool boundIsAllowed) :
            this(boundIsAllowed ? LocalizedFormat.NUMBER_TOO_SMALL : LocalizedFormat.NUMBER_TOO_SMALL_BOUND_EXCLUDED,
             wrong, min, boundIsAllowed) { }

        /// <summary>
        /// Construct the exception with a specific context.
        /// </summary>
        /// <param name="specific">Specific context.</param>
        /// <param name="wrong">The wrong value.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="boundIsAllowed">Whether <paramref name="min"/> is included in the allowed range.</param>
        public NumberIsTooSmallException(ILocalizable specific, T wrong, T min, bool boundIsAllowed):
            base(specific, wrong, min)
        {
            this.Min = min;
            this.BoundIsAllowed = boundIsAllowed;
        }
    }
}
