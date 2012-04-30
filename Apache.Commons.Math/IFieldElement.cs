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

namespace Apache.Commons.Math
{
    /// <summary>
    /// Interface representing field elements.
    /// </summary>
    /// <see cref="IField"/>
    /// <seealso cref="http://mathworld.worlfram.com/Field.html"/>
    /// <typeparam name="T">The type of the field elements.</typeparam>
    public interface IFieldElement<T>
    {
        /// <summary>
        /// Compute <c>this + a</c>.
        /// </summary>
        /// <param name="a">Element to add.</param>
        /// <returns>A new element representing <c>this + a</c>.</returns>
        T add(T a);

        /// <summary>
        /// Compute <c>this - a</c>.
        /// </summary>
        /// <param name="a">Element to subtract.</param>
        /// <returns>A new element representing <c>this - a</c>.</returns>
        T subtract(T a);

        /// <summary>
        /// Returns the additive inverse of <c>this</c> element.
        /// </summary>
        /// <returns>The opposite of <c>this</c>.</returns>
        T negate();

        /// <summary>
        /// Compute <c>n &times; this</c>.
        /// <para>Multiplication by an integer number is defined as the folling sum:
        /// <center><c>n &times; this = &sum;<sub>i=1</sub><sup>n</sup>this</c></center></para>
        /// </summary>
        /// <param name="n">Number of times <c>this</c> must be added to itself.</param>
        /// <returns>A new element representing n &times; this.</returns>
        T multiply(int n);

        /// <summary>
        /// Compute <c>this &times; a</c>.
        /// </summary>
        /// <param name="a">Element to multiply</param>
        /// <returns>A new element representing <c>this &times; a</c>.</returns>
        T multiply(T a);

        /// <summary>
        /// Compute <c>this &divide; a</c>.
        /// </summary>
        /// <param name="a">Element to divide for.</param>
        /// <returns>A new element representing <c>this &divide; a</c>.</returns>
        /// <exception cref="ArithmeticException">If <paramref name="a"/> is the zero of the additive operation (i.e. additive identity).</exception>
        T divide(T a);

        /// <summary>
        /// Return the multiplicative inverse of <c>this</c>.
        /// </summary>
        /// <returns>The inverse of <c>this</c>.</returns>
        T reciprocal();

        /// <summary>
        /// Get the <see cref="IField"/> to which the instance belongs.
        /// </summary>
        IField<T> Field { get; }
    }
}
