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
    /// Exception to be thrown when two dimensions differ.
    /// </summary>
    [Serializable]
    public class DimensionMismatchException: MathIllegalNumberException<int>
    {
        /// <summary>
        /// Correct dimension.
        /// </summary>
        private readonly int dimension;

        /// <summary>
        /// Construct an exception from the mismatched dimensions.
        /// </summary>
        /// <param name="specific">Specific context information pattern.</param>
        /// <param name="wrong">Wrong dimension.</param>
        /// <param name="expected">Expected dimension.</param>
        public DimensionMismatchException(ILocalizable specific, int wrong, int expected): base(specific, wrong, expected)
        {
            this.dimension = expected;
        }

        /// <summary>
        /// Construct an exception from the mismatched dimensions.
        /// </summary>
        /// <param name="wrong">Wrong dimension.</param>
        /// <param name="expected">Expected dimension.</param>
        public DimensionMismatchException(int wrong, int expected) : this(LocalizedFormat.DIMENSIONS_MISMATCH_SIMPLE, wrong, expected) { }

        /// <summary>
        /// The expected dimension.
        /// </summary>
        public int Dimension
        {
            get { return dimension; }
        }
    }
}
