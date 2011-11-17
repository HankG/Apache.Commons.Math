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
    /// Exception to be thrown when function values have the same sign at both ends of an interval.
    /// </summary>
    [Serializable]
    public class NoBracketingException: MathArgumentException
    {
        /// <summary>
        /// Lower end of the interval.
        /// </summary>
        public double Lo { get; private set; }
        /// <summary>
        /// Higher end of the interval.
        /// </summary>
        public double Hi { get; private set; }
        /// <summary>
        /// Value at the lower end of the interval.
        /// </summary>
        public double Flo { get; private set; }
        /// <summary>
        /// Value at the upper end of the interval.
        /// </summary>
        public double Fhi { get; private set; }

        /// <summary>
        /// Construct the exception.
        /// </summary>
        /// <param name="lo">Lower end of the interval.</param>
        /// <param name="hi">Higher end of the interval.</param>
        /// <param name="fLo">Value at the lower end of the interval.</param>
        /// <param name="fHi">Value at the higher end of the interval.</param>
        public NoBracketingException(double lo, double hi, double fLo, double fHi) :
            this(LocalizedFormat.SAME_SIGN_AT_ENDPOINTS, lo, hi, fLo, fHi) { }

        /// <summary>
        /// Construct the exception.
        /// </summary>
        /// <param name="specific">Contextual information on what caused the exception.</param>
        /// <param name="lo">Lower end of the interval.</param>
        /// <param name="hi">Higher end of the interval.</param>
        /// <param name="fLo">Value at the lower end of the interval.</param>
        /// <param name="fHi">Value at the higher end of the interval.</param>
        /// <param name="args">Additional arguments.</param>
        public NoBracketingException(ILocalizable specific, double lo, double hi, double fLo, double fHi, params object[] args) :
            base(specific, lo, hi, fLo, fHi, args)
        {
            this.Lo = lo;
            this.Hi = hi;
            this.Flo = fLo;
            this.Fhi = fHi;
        }
    }
}
