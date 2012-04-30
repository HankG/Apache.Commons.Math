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
    /// Exception thrown when two sets of dimensions differ.
    /// </summary>
    [Serializable]
    public class MultiDimensionMismatchException: MathIllegalArgumentException
    {
        /// <summary>
        /// Wrong dimensions.
        /// </summary>
        public int[] WrongDimensions { get; private set; }
        /// <summary>
        /// Correct dimensions.
        /// </summary>
        public int[] ExpectedDimensions { get; private set; }

        /// <summary>
        /// Constructs an exception from the mismatched dimensions.
        /// </summary>
        /// <param name="wrong">Wrong dimensions.</param>
        /// <param name="expected">Expected dimensions.</param>
        public MultiDimensionMismatchException(int[] wrong, int[] expected) :
            this(LocalizedFormats.DIMENSIONS_MISMATCH, wrong, expected) { }

        /// <summary>
        /// Construct an exception from the mismatched dimensions.
        /// </summary>
        /// <param name="specific">Message pattern providing the specific context of the error.</param>
        /// <param name="wrong">Wrong dimensions.</param>
        /// <param name="expected">Expected dimensions.</param>
        public MultiDimensionMismatchException(ILocalizable specific, int[] wrong, int[] expected):
            base(specific, wrong, expected)
        {
            this.WrongDimensions = wrong.Clone() as int[];
            this.ExpectedDimensions = expected.Clone() as int[];
        }
    }
}
