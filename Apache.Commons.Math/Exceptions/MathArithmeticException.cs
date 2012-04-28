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
    /// Base class for arithmetic exceptions.
    /// <para>It is used for all the exceptions that have the semantics of the standard
    /// <see cref="ArithmeticException"/>, but must also provide a localized message.</para>
    /// </summary>
    [Serializable]
    public class MathArithmeticException: ArithmeticException, IExceptionContextProvider
    {
        /// <summary>
        /// Context.
        /// </summary>
        private readonly ExceptionContext context;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MathArithmeticException()
        {
            context = new ExceptionContext(this);
            context.AddMessage(LocalizedFormats.ARITHMETIC_EXCEPTION);
        }

        /// <summary>
        /// Constructor with a specific message.
        /// </summary>
        /// <param name="pattern">Message pattern providing the specific context of the error.</param>
        /// <param name="args">Arguments.</param>
        public MathArithmeticException(ILocalizable pattern, params object[] args)
        {
            context = new ExceptionContext(this);
            context.AddMessage(pattern, args);
        }

        public virtual ExceptionContext Context
        {
            get { return context; }
        }

        public override string Message
        {
            get
            {
                return context.LocalizedMessage;
            }
        }
    }
}
