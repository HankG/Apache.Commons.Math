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
    /// Interface representing an field.
    /// <para>Classes implementing this interface will often be singletons.</para>
    /// </summary>
    /// <seealso cref="http://mathworld.wolfram.com/Field.html"/>
    /// <typeparam name="T">The type of the field elements.</typeparam>
    public interface IField<T>
    {
        /// <summary>
        /// Get the additive identity for the field.
        /// <para>The additive identity is the element <em>e<sub>0</sub></em> of the field such that
        /// for all elements <em>a</em> of the field, the equalities <em>a + e<sub>0</sub> = e<sub>0</sub> + a = a</em>
        /// hold.</para>
        /// </summary>
        T Zero { get; }

        /// <summary>
        /// Get the multiplicative identity for the field.
        /// <para>The multiplicative identity is the element <em>e<sub>1</sub></em> of the field such that
        /// for all elements <em>a</em> of the field, the equalities <em>a &times; e<sub>1</sub> =
        /// e<sub>1</sub> &times; a = a</em> hold.</para>
        /// </summary>
        T One { get; }

        /// <summary>
        /// Retrieve the runtime type of the <see cref="FieldElement"/>
        /// </summary>
        Type RuntimeType { get; }
    }
}
