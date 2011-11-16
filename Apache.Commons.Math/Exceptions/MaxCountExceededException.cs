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
    /// Exception to be thrown when some counter maximum value is exceeded.
    /// </summary>
    [Serializable]
    public class MaxCountExceededException: MathIllegalStateException
    {
        /// <summary>
        /// Maximum number of evaluations.
        /// </summary>
        private readonly long max;

        /// <summary>
        /// Construct the exception.
        /// </summary>
        /// <param name="max">The maximum.</param>
        public MaxCountExceededException(int max) : this(LocalizedFormat.MAX_COUNT_EXCEEDED, max) { }

        /// <summary>
        /// Construct the exception with a specific context.
        /// </summary>
        /// <param name="specific">Specific context pattern.</param>
        /// <param name="max">The maximum</param>
        /// <param name="args">Additional arguments.</param>
        public MaxCountExceededException(ILocalizable specific, int max, params object[] args)
        {
            Context.AddMessage(specific, max, args);
            this.max = max;
        }

        public long Max
        {
            get { return max; }
        }
    }
}
