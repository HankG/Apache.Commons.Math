using System;
using System.Numerics;
using JavaDotNet.Lang;

/* java.math.BigDecimal -- Arbitrary precision decimals.
   Copyright (C) 1999, 2000, 2001, 2003, 2005, 2006 Free Software Foundation, Inc.

This file is part of GNU Classpath.

GNU Classpath is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2, or (at your option)
any later version.
 
GNU Classpath is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
General Public License for more details.

You should have received a copy of the GNU General Public License
along with GNU Classpath; see the file COPYING.  If not, write to the
Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA
02110-1301 USA.

Linking this library statically or dynamically with other modules is
making a combined work based on this library.  Thus, the terms and
conditions of the GNU General Public License cover the whole
combination.

As a special exception, the copyright holders of this library give you
permission to link this library with independent modules to produce an
executable, regardless of the license terms of these independent
modules, and to copy and distribute the resulting executable under
terms of your choice, provided that you also meet, for each linked
independent module, the terms and conditions of the license of that
module.  An independent module is a module which is not derived from
or based on this library.  If you modify this library, you may extend
this exception to your version of the library, but you are not
obligated to do so.  If you do not wish to do so, delete this
exception statement from your version. */

namespace JavaDotNet.Math
{
	public class BigDecimal : Number, IComparable<BigDecimal>
	{
	  private BigInteger _intVal;
	  private int _scale;
	  private int _precision = 0;
	
#pragma warning disable 0414
	  private static readonly long serialVersionUID = 6108874887143696463L;
#pragma warning restore 0414
		
	  /* Internally use BigInteger.TEN  a lot so creating one here
	   *
	   */
	  private static readonly BigInteger _bigInteger_TEN = new BigInteger(10);
	
	  /**
	   * The constant zero as a BigDecimal with scale zero.
	   * @since 1.5
	   */
	  public static readonly BigDecimal ZERO = 
	    new BigDecimal (BigInteger.Zero, 0);
	
	  /**
	   * The constant one as a BigDecimal with scale zero.
	   * @since 1.5
	   */
	  public static readonly BigDecimal ONE = 
	    new BigDecimal (BigInteger.One, 0);
	
	  /**
	   * The constant ten as a BigDecimal with scale zero.
	   * @since 1.5
	   */
	  public static readonly BigDecimal TEN = 
	    new BigDecimal (_bigInteger_TEN, 0);
	
	  public const int ROUND_UP = 0;
	  public const int ROUND_DOWN = 1;
	  public const int ROUND_CEILING = 2;
	  public const int ROUND_FLOOR = 3;
	  public const int ROUND_HALF_UP = 4;
	  public const int ROUND_HALF_DOWN = 5;
	  public const int ROUND_HALF_EVEN = 6;
	  public const int ROUND_UNNECESSARY = 7;
			
		
	  /**
	   * Constructs a new BigDecimal whose unscaled value is val and whose
	   * scale is zero.
	   * @param val the value of the new BigDecimal
	   * @since 1.5
	   */
	  public BigDecimal (int val)
	  {
	    this.intVal = new BigInteger(val);
	    this.scale = 0;
	  }
	  
	  /**
	   * Constructs a BigDecimal using the BigDecimal(int) constructor and then
	   * rounds according to the MathContext.
	   * @param val the value for the initial (unrounded) BigDecimal
	   * @param mc the MathContext specifying the rounding
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal (int val, MathContext mc):this(val)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }    
	  }
	  
	  /**
	   * Constructs a new BigDecimal whose unscaled value is val and whose
	   * scale is zero.
	   * @param val the value of the new BigDecimal
	   */
	  public BigDecimal (long val)
	  {
	    this.intVal = new BigInteger(val);
	    this.scale = 0;
	  }
	  
	  /**
	   * Constructs a BigDecimal from the long in the same way as BigDecimal(long)
	   * and then rounds according to the MathContext.
	   * @param val the long from which we create the initial BigDecimal
	   * @param mc the MathContext that specifies the rounding behaviour
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal (long val, MathContext mc):this(val)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }    
	  }
	  
	  /**
	   * Constructs a BigDecimal whose value is given by num rounded according to 
	   * mc.  Since num is already a BigInteger, the rounding refers only to the 
	   * precision setting in mc, if mc.getPrecision() returns an int lower than
	   * the number of digits in num, then rounding is necessary.
	   * @param num the unscaledValue, before rounding
	   * @param mc the MathContext that specifies the precision
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY
	   * * @since 1.5
	   */
	  public BigDecimal (BigInteger num, MathContext mc):this (num, 0)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }
	  }
	  
	  /**
	   * Constructs a BigDecimal from the String val according to the same
	   * rules as the BigDecimal(String) constructor and then rounds 
	   * according to the MathContext mc.
	   * @param val the String from which we construct the initial BigDecimal
	   * @param mc the MathContext that specifies the rounding
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY   
	   * @since 1.5
	   */
	  public BigDecimal (String val, MathContext mc):this(val)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }
	  }
	  
	  /**
	   * Constructs a BigDecimal whose unscaled value is num and whose
	   * scale is zero.
	   * @param num the value of the new BigDecimal
	   */
	  public BigDecimal (BigInteger num):this(num,0)
	  {

	  }
	
	  /**
	   * Constructs a BigDecimal whose unscaled value is num and whose
	   * scale is scale.
	   * @param num
	   * @param scale
	   */
	  public BigDecimal (BigInteger num, int scale)
	  {
	    this.intVal = num;
	    this.scale = scale;
	  }
	  
	  /**
	   * Constructs a BigDecimal using the BigDecimal(BigInteger, int) 
	   * constructor and then rounds according to the MathContext.
	   * @param num the unscaled value of the unrounded BigDecimal
	   * @param scale the scale of the unrounded BigDecimal
	   * @param mc the MathContext specifying the rounding
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal (BigInteger num, int scale, MathContext mc):this (num, scale)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }
	  }
	
	  /**
	   * Constructs a BigDecimal in the same way as BigDecimal(double) and then
	   * rounds according to the MathContext.
	   * @param num the double from which the initial BigDecimal is created
	   * @param mc the MathContext that specifies the rounding behaviour
	   * @throws ArithmeticException if the result is inexact but the rounding type
	   * is RoundingMode.UNNECESSARY 
	   * @since 1.5
	   */
	  public BigDecimal (double num, MathContext mc):this(num)
	  {
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal result = this.round(mc);
	        this.intVal = result.intVal;
	        this.scale = result.scale;
	        this.precision = result.precision;
	      }
	  }
	  
	  public BigDecimal (double num) 
	  {
	    if (Double.IsInfinity (num) || Double.IsNaN (num))
	      throw new ArgumentOutOfRangeException ("invalid argument: " + num);
	    // Note we can't convert NUM to a String and then use the
	    // String-based constructor.  The BigDecimal documentation makes
	    // it clear that the two constructors work differently.
	
	    int mantissaBits = 52;
	    int exponentBits = 11;
	    long mantMask = (1L << mantissaBits) - 1;
	    long expMask = (1L << exponentBits) - 1;
	
	    long bits = BitConverter.DoubleToInt64Bits(num);
	    long mantissa = bits & mantMask;
	    long exponent = ((long)((ulong)bits >> mantissaBits)) & expMask;
	    bool denormal = exponent == 0;
	
	    // Correct the exponent for the bias.
	    exponent -= denormal ? 1022 : 1023;
	
	    // Now correct the exponent to account for the bits to the right
	    // of the decimal.
	    exponent -= mantissaBits;
	    // Ordinary numbers have an implied leading `1' bit.
	    if (! denormal)
	      mantissa |= (1L << mantissaBits);
	
	    // Shave off factors of 10.
	    while (exponent < 0 && (mantissa & 1) == 0)
	      {
		++exponent;
		mantissa >>= 1;
	      }
	
	    intVal = new BigInteger (bits < 0 ? - mantissa : mantissa);
	    if (exponent < 0)
	      {
		// We have MANTISSA * 2 ^ (EXPONENT).
		// Since (1/2)^N == 5^N * 10^-N we can easily convert this
		// into a power of 10.
		scale = (int) (- exponent);
		BigInteger mult = BigInteger.Pow(new BigInteger (5), scale);
		intVal = BigInteger.Multiply (intVal, mult);
	      }
	    else
	      {
		intVal = intVal << (int) exponent;
		scale = 0;
	      }
	  }
	
	  /**
	   * Constructs a BigDecimal from the char subarray and rounding 
	   * according to the MathContext.
	   * @param in the char array
	   * @param offset the start of the subarray
	   * @param len the length of the subarray
	   * @param mc the MathContext for rounding
	   * @throws NumberFormatException if the char subarray is not a valid 
	   * BigDecimal representation
	   * @throws ArithmeticException if the result is inexact but the rounding 
	   * mode is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal(char[] input, int offset, int len, MathContext mc):this(input, offset, len)
	  {
	    // If mc has precision other than zero then we must round.
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal temp = this.round(mc);
	        this.intVal = temp.intVal;
	        this.scale = temp.scale;
	        this.precision = temp.precision;
	      }
	  }
	  
	  /**
	   * Constructs a BigDecimal from the char array and rounding according
	   * to the MathContext. 
	   * @param in the char array
	   * @param mc the MathContext
	   * @throws NumberFormatException if <code>in</code> is not a valid BigDecimal
	   * representation
	   * @throws ArithmeticException if the result is inexact but the rounding mode
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal(char[] input, MathContext mc):this(input, 0, input.Length)
	  {
	    // If mc has precision other than zero then we must round.
	    if (mc.getPrecision() != 0)
	      {
	        BigDecimal temp = this.round(mc);
	        this.intVal = temp.intVal;
	        this.scale = temp.scale;
	        this.precision = temp.precision;
	      } 
	  }
	  
	  /**
	   * Constructs a BigDecimal from the given char array, accepting the same
	   * sequence of characters as the BigDecimal(String) constructor.
	   * @param in the char array
	   * @throws NumberFormatException if <code>in</code> is not a valid BigDecimal
	   * representation
	   * @since 1.5
	   */
	  public BigDecimal(char[] input):this(input, 0, input.Length)
	  {
	  }
	  
	  /**
	   * Constructs a BigDecimal from a char subarray, accepting the same sequence
	   * of characters as the BigDecimal(String) constructor.  
	   * @param in the char array
	   * @param offset the start of the subarray
	   * @param len the length of the subarray
	   * @throws NumberFormatException if <code>in</code> is not a valid
	   * BigDecimal representation.
	   * @since 1.5
	   */
	  public BigDecimal(char[] input, int offset, int len)
	  {
	    //  start is the index into the char array where the significand starts
	    int start = offset;
	    //  end is one greater than the index of the last character used
	    int end = offset + len;
	    //  point is the index into the char array where the exponent starts
	    //  (or, if there is no exponent, this is equal to end)
	    int point = offset;
	    //  dot is the index into the char array where the decimal point is 
	    //  found, or -1 if there is no decimal point
	    int dot = -1;
	    
	    //  The following examples show what these variables mean.  Note that
	    //  point and dot don't yet have the correct values, they will be 
	    //  properly assigned in a loop later on in this method.
	    //
	    //  Example 1
	    //
	    //         +  1  0  2  .  4  6  9
	    //  __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __
	    //
	    //  offset = 2, len = 8, start = 3, dot = 6, point = end = 10
	    //
	    //  Example 2
	    //
	    //         +  2  3  4  .  6  1  3  E  -  1
	    //  __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __
	    //
	    //  offset = 2, len = 11, start = 3, dot = 6, point = 10, end = 13
	    //
	    //  Example 3
	    //
	    //         -  1  2  3  4  5  e  7  
	    //  __ __ __ __ __ __ __ __ __ __ __ __ __ __ __ __
	    //
	    //  offset = 2, len = 8, start = 3, dot = -1, point = 8, end = 10 
	    
	    //  Determine the sign of the number.
	    bool negative = false;
	    if (input[offset] == '+')
	      {
	        ++start;
	        ++point;
	      }
	    else if (input[offset] == '-')
	      {
	        ++start;
	        ++point;
	        negative = true;
	      }
	
	    //  Check each character looking for the decimal point and the 
	    //  start of the exponent.
	    while (point < end)
	      {
	        char c = input[point];
	        if (c == '.')
	          {
	            // If dot != -1 then we've seen more than one decimal point.
	            if (dot != -1)
	              throw new ArgumentOutOfRangeException("multiple `.'s in number");
	            dot = point;
	          }
	        // Break when we reach the start of the exponent.
	        else if (c == 'e' || c == 'E')
	          break;
	        // Throw an exception if the character was not a decimal or an 
	        // exponent and is not a digit.
	        else if (!Char.IsDigit(c))
	          throw new FormatException("unrecognized character at " + point
	                                          + ": " + c);
	        ++point;
	      }
	
	    // val is a StringBuilder from which we'll create a BigInteger
	    // which will be the unscaled value for this BigDecimal
	    System.Text.StringBuilder val = new System.Text.StringBuilder(point - start - 1);
	    if (dot != -1)
	      {
	        // If there was a decimal we must combine the two parts that 
	        // contain only digits and we must set the scale properly.
	        val.Append(input, start, dot - start);
	        val.Append(input, dot + 1, point - dot - 1);
	        scale = point - 1 - dot;
	      }
	    else
	      {
	        // If there was no decimal then the unscaled value is just the number
	        // formed from all the digits and the scale is zero.
	        val.Append(input, start, point - start);
	        scale = 0;
	      }
	    if (val.Length == 0)
	      throw new FormatException("no digits seen");
	
	    // Prepend a negative sign if necessary.
	    if (negative)
	      val.Insert(0, '-');
	    intVal = BigInteger.Parse(val.ToString());
	
	    // Now parse exponent.
	    // If point < end that means we broke out of the previous loop when we
	    // saw an 'e' or an 'E'.
	    if (point < end)
	      {
	        point++;
	        // Ignore a '+' sign.
	        if (input[point] == '+')
	          point++;
	
	        // Throw an exception if there were no digits found after the 'e'
	        // or 'E'.
	        if (point >= end)
	          throw new FormatException("no exponent following e or E");
	
			int decrementValue = 0;
			if(Int32.TryParse(new String(input, point, end - point), out decrementValue))
			{
				scale -= decrementValue;
			}
			else
			{
				throw new FormatException("malformed exponent");
			}
	      }
	  }
	  
	  public BigDecimal (String num)
	  {
	    int len = num.Length;
	    int start = 0, point = 0;
	    int dot = -1;
	    bool negative = false;
	    if (num[0] == '+')
	      {
		++start;
		++point;
	      }
	    else if (num[0] == '-')
	      {
		++start;
		++point;
		negative = true;
	      }
	
	    while (point < len)
	      {
		char c = num[point];
		if (c == '.')
		  {
		    if (dot >= 0)
		      throw new FormatException ("multiple `.'s in number");
		    dot = point;
		  }
		else if (c == 'e' || c == 'E')
		  break;
		else if (!Char.IsDigit(c))
		  throw new FormatException ("unrecognized character: " + c);
		++point;
	      }
	
	    String val;
	    if (dot >= 0)
	      {
		val = num.Substring (start, dot) + num.Substring (dot + 1, point);
		scale = point - 1 - dot;
	      }
	    else
	      {
		val = num.Substring (start, point);
		scale = 0;
	      }
	    if (val.Length  == 0)
	      throw new FormatException ("no digits seen");
	
	    if (negative)
	      val = "-" + val;
	    intVal = BigInteger.Parse(val);
	
	    // Now parse exponent.
	    if (point < len)
	      {
	        point++;
	        if (num[point] == '+')
	          point++;
	
	        if (point >= len )
	          throw new FormatException ("no exponent following e or E");
		
		  	int decrement = 0;
		    if(Int32.TryParse(num.Substring(point), out decrement))
			{
				scale -= decrement;
			}
			else
			{
				throw new FormatException("malformed exponent");
	        }
		  }
	  }
	
	  public static BigDecimal valueOf (long val) 
	  {
	    return valueOf (val, 0);
	  }
	
	  public static BigDecimal valueOf (long val, int scale) 
	  {
	    if ((scale == 0) && ((int)val == val))
	      switch ((int) val)
		{
		case 0:
		  return ZERO;
		case 1:
		  return ONE;
		}
	
	    return new BigDecimal (new BigInteger(val), scale);
	  }
	
	  public BigDecimal add (BigDecimal val) 
	  {
	    // For addition, need to line up decimals.  Note that the movePointRight
	    // method cannot be used for this as it might return a BigDecimal with
	    // scale == 0 instead of the scale we need.
	    BigInteger op1 = intVal;
	    BigInteger op2 = val.intVal;
		BigInteger ten = _bigInteger_TEN;
	    if (scale < val.scale)
	      op1 = BigInteger.Multiply(op1, BigInteger.Pow (ten, (val.scale - scale)));
	    else if (scale > val.scale)
	      op2 = BigInteger.Multiply(op2, BigInteger.Pow (ten, (scale - val.scale)));
	
	    return new BigDecimal (BigInteger.Add (op1, op2), System.Math.Max (scale, val.scale));
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is found first by calling the 
	   * method add(val) and then by rounding according to the MathContext mc.
	   * @param val the augend
	   * @param mc the MathContext for rounding
	   * @throws ArithmeticException if the value is inexact but the rounding is
	   * RoundingMode.UNNECESSARY
	   * @return <code>this</code> + <code>val</code>, rounded if need be
	   * @since 1.5
	   */
	  public BigDecimal add (BigDecimal val, MathContext mc)
	  {
	    return add(val).round(mc);
	  }
	
	  public BigDecimal subtract (BigDecimal val) 
	  {
	    return this.add(val.negate());
	  }
	
	  /**
	   * Returns a BigDecimal whose value is found first by calling the 
	   * method subtract(val) and then by rounding according to the MathContext mc.
	   * @param val the subtrahend
	   * @param mc the MathContext for rounding
	   * @throws ArithmeticException if the value is inexact but the rounding is
	   * RoundingMode.UNNECESSARY
	   * @return <code>this</code> - <code>val</code>, rounded if need be
	   * @since 1.5
	   */
	  public BigDecimal subtract (BigDecimal val, MathContext mc)
	  {
	    return subtract(val).round(mc);
	  }
	
	  public BigDecimal multiply (BigDecimal val) 
	  {
	    return new BigDecimal (BigInteger.Multiply(intVal, val.intVal), scale + val.scale);
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is (this x val) before it is rounded
	   * according to the MathContext mc. 
	   * @param val the multiplicand
	   * @param mc the MathContext for rounding
	   * @return a new BigDecimal with value approximately (this x val)
	   * @throws ArithmeticException if the value is inexact but the rounding mode
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal multiply (BigDecimal val, MathContext mc)
	  {
	    return multiply(val).round(mc);
	  }
	
	  public BigDecimal divide (BigDecimal val, int roundingMode) 
	  {
	    return divide (val, scale, roundingMode);
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is (this / val), with the specified scale
	   * and rounding according to the RoundingMode 
	   * @param val the divisor
	   * @param scale the scale of the BigDecimal returned
	   * @param roundingMode the rounding mode to use
	   * @return a BigDecimal whose value is approximately (this / val)
	   * @throws ArithmeticException if divisor is zero or the rounding mode is
	   * UNNECESSARY but the specified scale cannot represent the value exactly
	   * @since 1.5
	   */
	  public BigDecimal divide(BigDecimal val, 
	                           int scale, RoundingMode roundingMode)
	  {
	    return divide (val, scale, (int)roundingMode);
	  }
	
	  /**
	   * Returns a BigDecimal whose value is (this / val) rounded according to the
	   * RoundingMode
	   * @param val the divisor
	   * @param roundingMode the rounding mode to use
	   * @return a BigDecimal whose value is approximately (this / val)
	   * @throws ArithmeticException if divisor is zero or the rounding mode is
	   * UNNECESSARY but the specified scale cannot represent the value exactly
	   */
	  public BigDecimal divide (BigDecimal val, RoundingMode roundingMode)
	  {
	    return divide (val, scale, (int)roundingMode);
	  }
	  
	  public BigDecimal divide(BigDecimal val, int newScale, int roundingMode)
	  {
	    if (roundingMode < 0 || roundingMode > 7)
	      throw 
		new ArgumentException("illegal rounding mode: " + roundingMode);
	
	    if (intVal.Sign == 0)	// handle special case of 0.0/0.0
	      return newScale == 0 ? ZERO : new BigDecimal (ZERO.intVal, newScale);
	    
	    // Ensure that pow gets a non-negative value.
	    BigInteger valIntVal = val.intVal;
	    int power = newScale - (scale - val.scale);
	    if (power < 0)
	      {
		// Effectively increase the scale of val to avoid an
		// ArithmeticException for a negative power.
	        valIntVal = BigInteger.Multiply(valIntVal, BigInteger.Pow (_bigInteger_TEN, -power));
			power = 0;
	      }
	
	    BigInteger dividend = BigInteger.Multiply(intVal, BigInteger.Pow (_bigInteger_TEN, power));
		BigInteger remainder;
		BigInteger value = BigInteger.DivRem(dividend, valIntVal, out remainder);
	    
	    BigInteger[] parts = {value, remainder };
	
	    BigInteger unrounded = parts[0];
	    if (parts[1].Sign == 0) // no remainder, no rounding necessary
	      return new BigDecimal (unrounded, newScale);
	
	    if (roundingMode == ROUND_UNNECESSARY)
	      throw new ArithmeticException ("Rounding necessary");
	
	    int sign = intVal.Sign * valIntVal.Sign;
	
	    if (roundingMode == ROUND_CEILING)
	      roundingMode = (sign > 0) ? ROUND_UP : ROUND_DOWN;
	    else if (roundingMode == ROUND_FLOOR)
	      roundingMode = (sign < 0) ? ROUND_UP : ROUND_DOWN;
	    else
	      {
		// half is -1 if remainder*2 < positive intValue (*power), 0 if equal,
		// 1 if >. This implies that the remainder to round is less than,
		// equal to, or greater than half way to the next digit.
		BigInteger posRemainder
		  = parts[1].Sign < 0 ? BigInteger.Negate (parts[1]) : parts[1];
		valIntVal = valIntVal.Sign < 0 ? BigInteger.Negate (valIntVal) : valIntVal;
		int half = (posRemainder << 1).CompareTo(valIntVal);
	
		switch(roundingMode)
		  {
		  case ROUND_HALF_UP:
		    roundingMode = (half < 0) ? ROUND_DOWN : ROUND_UP;
		    break;
		  case ROUND_HALF_DOWN:
		    roundingMode = (half > 0) ? ROUND_UP : ROUND_DOWN;
		    break;
		  case ROUND_HALF_EVEN:
		    if (half < 0)
		      roundingMode = ROUND_DOWN;
		    else if (half > 0)
		      roundingMode = ROUND_UP;
		    else if (!unrounded.IsEven) // odd, then ROUND_HALF_UP
		      roundingMode = ROUND_UP;
		    else                           // even, ROUND_HALF_DOWN
		      roundingMode = ROUND_DOWN;
		    break;
		  }
	      }
	
	    if (roundingMode == ROUND_UP)
	      unrounded = BigInteger.Add (unrounded, new BigInteger(sign > 0 ? 1 : -1));
	
	    // roundingMode == ROUND_DOWN
	    return new BigDecimal (unrounded, newScale);
	  }
	  
	  /**
	   * Performs division, if the resulting quotient requires rounding
	   * (has a nonterminating decimal expansion), 
	   * an ArithmeticException is thrown. 
	   * #see divide(BigDecimal, int, int)
	   * @since 1.5
	   */
	  public BigDecimal divide(BigDecimal divisor)
	  {
	    return divide(divisor, scale, ROUND_UNNECESSARY);
	  }
	
	  /**
	   * Returns a BigDecimal whose value is the remainder in the quotient
	   * this / val.  This is obtained by 
	   * subtract(divideToIntegralValue(val).multiply(val)).  
	   * @param val the divisor
	   * @return a BigDecimal whose value is the remainder
	   * @throws ArithmeticException if val == 0
	   * @since 1.5
	   */
	  public BigDecimal remainder(BigDecimal val)
	  {
	    return subtract(divideToIntegralValue(val).multiply(val));
	  }
	
	  /**
	   * Returns a BigDecimal array, the first element of which is the integer part
	   * of this / val, and the second element of which is the remainder of 
	   * that quotient.
	   * @param val the divisor
	   * @return the above described BigDecimal array
	   * @throws ArithmeticException if val == 0
	   * @since 1.5
	   */
	  public BigDecimal[] divideAndRemainder(BigDecimal val)
	  {
	    BigDecimal[] result = new BigDecimal[2];
	    result[0] = divideToIntegralValue(val);
	    result[1] = subtract(result[0].multiply(val));
	    return result;
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is the integer part of the quotient 
	   * this / val.  The preferred scale is this.scale - val.scale.
	   * @param val the divisor
	   * @return a BigDecimal whose value is the integer part of this / val.
	   * @throws ArithmeticException if val == 0
	   * @since 1.5
	   */
	  public BigDecimal divideToIntegralValue(BigDecimal val)
	  {
	    return divide(val, ROUND_DOWN).floor().setScale(scale - val.scale, ROUND_DOWN);
	  }
	  
	  /**
	   * Mutates this BigDecimal into one with no fractional part, whose value is 
	   * equal to the largest integer that is <= to this BigDecimal.  Note that
	   * since this method is private it is okay to mutate this BigDecimal.
	   * @return the BigDecimal obtained through the floor operation on this 
	   * BigDecimal.
	   */
	  private BigDecimal floor()
	  {
	    if (scale <= 0)
	      return this;
	    String intValStr = intVal.ToString();
	    intValStr = intValStr.Substring(0, intValStr.Length - scale);
	    intVal = BigInteger.Multiply(BigInteger.Parse(intValStr), BigInteger.Pow (_bigInteger_TEN, scale));
	    return this;
	  }
	    
	  public int compareTo (BigDecimal val) 
	  {
	    if (scale == val.scale)
	      return intVal.CompareTo (val.intVal);
	
		BigInteger tenPowScale = BigInteger.Pow (_bigInteger_TEN, scale);
		BigInteger valRemainder;
		BigInteger valRVal = BigInteger.DivRem(intVal, tenPowScale, out valRemainder);
	    BigInteger[] thisParts = {valRVal, valRemainder};
			
		BigInteger tenPowValScale = BigInteger.Pow (_bigInteger_TEN, val.scale);
		BigInteger valIntValRemainder;
		BigInteger valIntValRval = BigInteger.DivRem(val.intVal,tenPowValScale, out valIntValRemainder);
	    BigInteger[] valParts = {valIntValRval, valIntValRemainder};
	    
	    int compare;
	    if ((compare = thisParts[0].CompareTo (valParts[0])) != 0)
	      return compare;
	
	    // quotients are the same, so compare remainders
	
	    // Add some trailing zeros to the remainder with the smallest scale
	    if (scale < val.scale)
	      thisParts[1] = BigInteger.Multiply(thisParts[1], 
				BigInteger.Pow ( _bigInteger_TEN, (val.scale - scale)));
	    else if (scale > val.scale)
	      valParts[1] = BigInteger.Multiply(valParts[1],
				BigInteger.Pow (_bigInteger_TEN, (scale - val.scale)));
	
	    // and compare them
	    return thisParts[1].CompareTo (valParts[1]);
	  }
	
	  public bool equals (Object o) 
	  {
	    return (o is BigDecimal 
		    && scale == ((BigDecimal) o).scale
		    && compareTo ((BigDecimal) o) == 0);
	  }
	
	  public int hashCode() 
	  {
	    return intValue() ^ scale;
	  }
	
	  public BigDecimal max (BigDecimal val)
	  {
	    switch (compareTo (val)) 
	      {
	      case 1:
		return this;
	      default:
		return val;
	      }
	  }
	
	  public BigDecimal min (BigDecimal val) 
	  {
	    switch (compareTo (val)) 
	      {
	      case -1:
		return this;
	      default:
		return val;
	      }
	  }
	
	  public BigDecimal movePointLeft (int n)
	  {
	    return (n < 0) ? movePointRight (-n) : new BigDecimal (intVal, scale + n);
	  }
	
	  public BigDecimal movePointRight (int n)
	  {
	    if (n < 0)
	      return movePointLeft (-n);
	
	    if (scale >= n)
	      return new BigDecimal (intVal, scale - n);
	
		BigInteger tenPow = BigInteger.Pow(_bigInteger_TEN, (n - scale));
	    return new BigDecimal (BigInteger.Multiply(intVal,tenPow), 0);
	  }
	
	  public int signum () 
	  {
	    return intVal.Sign;
	  }
	
	  public int scale 
	  {
			get
			{
	    		return _scale;
			}
			set
			{
				_scale = value;
			}
	  }
	  
	  public BigInteger intVal 
	  { 
			get 
			{ 
				return _intVal;
			}
			set 
			{
				_intVal = value;
			}
	  }
		
	  public BigInteger unscaledValue()
	  {
	    return intVal;
	  }
	
	  public BigDecimal abs () 
	  {
	    return new BigDecimal (BigInteger.Abs (intVal), scale);
	  }
	
	  public BigDecimal negate () 
	  {
	    return new BigDecimal (BigInteger.Negate(intVal), scale);
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is found first by negating this via
	   * the negate() method, then by rounding according to the MathContext mc.
	   * @param mc the MathContext for rounding
	   * @return a BigDecimal whose value is approximately (-this)
	   * @throws ArithmeticException if the value is inexact but the rounding mode
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal negate(MathContext mc)
	  {
	    BigDecimal result = negate();
	    if (mc.getPrecision() != 0)
	      result = result.round(mc);
	    return result;
	  }
	  
	  /**
	   * Returns this BigDecimal.  This is included for symmetry with the 
	   * method negate().
	   * @return this
	   * @since 1.5
	   */
	  public BigDecimal plus()
	  {
	    return this;
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is found by rounding <code>this</code> 
	   * according to the MathContext.  This is the same as round(MathContext).
	   * @param mc the MathContext for rounding
	   * @return a BigDecimal whose value is <code>this</code> before being rounded
	   * @throws ArithmeticException if the value is inexact but the rounding mode
	   * is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal plus(MathContext mc)
	  {
	    return round(mc);
	  }
	  
	  /**
	   * Returns a BigDecimal which is this BigDecimal rounded according to the
	   * MathContext rounding settings.
	   * @param mc the MathContext that tells us how to round
	   * @return the rounded BigDecimal
	   */
	  public BigDecimal round(MathContext mc)
	  {
	    int mcPrecision = mc.getPrecision();
	    int numToChop = this.precision - mcPrecision;
	    // If mc specifies not to chop any digits or if we've already chopped 
	    // enough digits (say by using a MathContext in the constructor for this
	    // BigDecimal) then just return this.
	    if (mcPrecision == 0 || numToChop <= 0)
	      return this;
	    
	    // Make a new BigDecimal which is the correct power of 10 to chop off
	    // the required number of digits and then call divide.
	    BigDecimal div = new BigDecimal(BigInteger.Pow (_bigInteger_TEN,numToChop));
	    BigDecimal rounded = divide(div, scale, (int)mc.getRoundingMode());
	    rounded.scale -= numToChop;
	    rounded.precision = mcPrecision;
	    return rounded;
	  }
	  
	  /**
	   * Returns the precision of this BigDecimal (the number of digits in the
	   * unscaled value).  The precision of a zero value is 1.
	   * @return the number of digits in the unscaled value, or 1 if the value 
	   * is zero.
	   */		
	  public int precision
	  {
			get
			{
				if (_precision == 0)
			      {
					String s = this.intVal.ToString();
					_precision = s.Length - (( s[0] == '-' ) ? 1 : 0);
			      }
			    return _precision;
			}
			set
			{
				_precision = value;
			}
	  }
	  
	  /**
	   * Returns the String representation of this BigDecimal, using scientific
	   * notation if necessary.  The following steps are taken to generate
	   * the result:
	   * 
	   * 1. the BigInteger unscaledValue's toString method is called and if
	   * <code>scale == 0<code> is returned.
	   * 2. an <code>int adjExp</code> is created which is equal to the negation
	   * of <code>scale</code> plus the number of digits in the unscaled value, 
	   * minus one.
	   * 3. if <code>scale >= 0 && adjExp >= -6</code> then we represent this 
	   * BigDecimal without scientific notation.  A decimal is added if the 
	   * scale is positive and zeros are prepended as necessary.
	   * 4. if scale is negative or adjExp is less than -6 we use scientific
	   * notation.  If the unscaled value has more than one digit, a decimal 
	   * as inserted after the first digit, the character 'E' is appended
	   * and adjExp is appended.
	   */
	  public String toString()
	  {
	    // bigStr is the String representation of the unscaled value.  If
	    // scale is zero we simply return this.
	    String bigStr = intVal.ToString();
	    if (scale == 0)
	      return bigStr;
	
	    bool negative = (bigStr[0] == '-');
	    int point = bigStr.Length - scale - (negative ? 1 : 0);
	
	    System.Text.StringBuilder val = new System.Text.StringBuilder();
	
	    if (scale >= 0 && (point - 1) >= -6)
	      {
		// Convert to character form without scientific notation.
	        if (point <= 0)
	          {
	            // Zeros need to be prepended to the StringBuilder.
	            if (negative)
	              val.Append('-');
	            // Prepend a '0' and a '.' and then as many more '0's as necessary.
	            val.Append('0').Append('.');
	            while (point < 0)
	              {
	                val.Append('0');
	                point++;
	              }
	            // Append the unscaled value.
	            val.Append(bigStr.Substring(negative ? 1 : 0));
	          }
	        else
	          {
	            // No zeros need to be prepended so the String is simply the 
	            // unscaled value with the decimal point inserted.
	            val.Append(bigStr);
	            val.Insert(point + (negative ? 1 : 0), '.');
	          }
	      }
	    else
	      {
	        // We must use scientific notation to represent this BigDecimal.
	        val.Append(bigStr);
	        // If there is more than one digit in the unscaled value we put a 
	        // decimal after the first digit.
	        if (bigStr.Length > 1)
	          val.Insert( ( negative ? 2 : 1 ), '.');
	        // And then append 'E' and the exponent = (point - 1).
	        val.Append('E');
	        if (point - 1 >= 0)
	          val.Append('+');
	        val.Append( point - 1 );
	      }
	    return val.ToString();
	  }
	
	  /**
	   * Returns the String representation of this BigDecimal, using engineering
	   * notation if necessary.  This is similar to toString() but when exponents 
	   * are used the exponent is made to be a multiple of 3 such that the integer
	   * part is between 1 and 999.
	   * 
	   * @return a String representation of this BigDecimal in engineering notation
	   * @since 1.5
	   */
	  public String toEngineeringString()
	  {
	    // bigStr is the String representation of the unscaled value.  If
	    // scale is zero we simply return this.
	    String bigStr = intVal.ToString();
	    if (scale == 0)
	      return bigStr;
	
	    bool negative = (bigStr[0] == '-');
	    int point = bigStr.Length - scale - (negative ? 1 : 0);
	
	    // This is the adjusted exponent described above.
	    int adjExp = point - 1;
	    System.Text.StringBuilder val = new System.Text.StringBuilder();
	
	    if (scale >= 0 && adjExp >= -6)
	      {
	        // Convert to character form without scientific notation.
	        if (point <= 0)
	          {
	            // Zeros need to be prepended to the StringBuilder.
	            if (negative)
	              val.Append('-');
	            // Prepend a '0' and a '.' and then as many more '0's as necessary.
	            val.Append('0').Append('.');
	            while (point < 0)
	              {
	                val.Append('0');
	                point++;
	              }
	            // Append the unscaled value.
	            val.Append(bigStr.Substring(negative ? 1 : 0));
	          }
	        else
	          {
	            // No zeros need to be prepended so the String is simply the 
	            // unscaled value with the decimal point inserted.
	            val.Append(bigStr);
	            val.Insert(point + (negative ? 1 : 0), '.');
	          }
	      }
	    else
	      {
	        // We must use scientific notation to represent this BigDecimal.
	        // The exponent must be a multiple of 3 and the integer part
	        // must be between 1 and 999.
	        val.Append(bigStr);        
	        int zeros = adjExp % 3;
	        int dot = 1;
	        if (adjExp > 0)
	          {
	            // If the exponent is positive we just move the decimal to the
	            // right and decrease the exponent until it is a multiple of 3.
	            dot += zeros;
	            adjExp -= zeros;
	          }
	        else
	          {
	            // If the exponent is negative then we move the dot to the right
	            // and decrease the exponent (increase its magnitude) until 
	            // it is a multiple of 3.  Note that this is not adjExp -= zeros
	            // because the mod operator doesn't give us the distance to the 
	            // correct multiple of 3.  (-5 mod 3) is -2 but the distance from
	            // -5 to the correct multiple of 3 (-6) is 1, not 2.
	            if (zeros == -2)
	              {
	                dot += 1;
	                adjExp -= 1;
	              }
	            else if (zeros == -1)
	              {
	                dot += 2;
	                adjExp -= 2;
	              }
	          }
	
	        // Either we have to append zeros because, for example, 1.1E+5 should
	        // be 110E+3, or we just have to put the decimal in the right place.
	        if (dot > val.Length)
	          {
	            while (dot > val.Length)
	              val.Append('0');
	          }
	        else if (bigStr.Length > dot)
	          val.Insert(dot + (negative ? 1 : 0), '.');
	        
	        // And then append 'E' and the exponent (adjExp).
	        val.Append('E');
	        if (adjExp >= 0)
	          val.Append('+');
	        val.Append(adjExp);
	      }
	    return val.ToString();
	  }
	  
	  /**
	   * Returns a String representation of this BigDecimal without using 
	   * scientific notation.  This is how toString() worked for releases 1.4
	   * and previous.  Zeros may be added to the end of the String.  For
	   * example, an unscaled value of 1234 and a scale of -3 would result in 
	   * the String 1234000, but the toString() method would return 
	   * 1.234E+6.
	   * @return a String representation of this BigDecimal
	   * @since 1.5
	   */
	  public String toPlainString()
	  {
	    // If the scale is zero we simply return the String representation of the 
	    // unscaled value.
	    String bigStr = intVal.ToString();
	    if (scale == 0)
	      return bigStr;
	
	    // Remember if we have to put a negative sign at the start.
	    bool negative = (bigStr[0] == '-');
	
	    int point = bigStr.Length - scale - (negative ? 1 : 0);
	
	    System.Text.StringBuilder sb = new System.Text.StringBuilder(bigStr.Length + 2
						     + (point <= 0 ? (-point + 1) : 0));
	    if (point <= 0)
	      {
	        // We have to prepend zeros and a decimal point.
	        if (negative)
	          sb.Append('-');
	        sb.Append('0').Append('.');
	        while (point < 0)
	          {
	            sb.Append('0');
	            point++;
	          }
	        sb.Append(bigStr.Substring(negative ? 1 : 0));
	      }
	    else if (point < bigStr.Length)
	      {
	        // No zeros need to be prepended or appended, just put the decimal
	        // in the right place.
	        sb.Append(bigStr);
	        sb.Insert(point + (negative ? 1 : 0), '.');
	      }
	    else
	      {
	        // We must append zeros instead of using scientific notation.
	        sb.Append(bigStr);
	        for (int i = bigStr.Length; i < point; i++)
	          sb.Append('0');
	      }
	    return sb.ToString();
	  }
	  
	  /**
	   * Converts this BigDecimal to a BigInteger.  Any fractional part will
	   * be discarded.
	   * @return a BigDecimal whose value is equal to floor[this]
	   */
	  public BigInteger toBigInteger () 
	  {
	    // If scale > 0 then we must divide, if scale > 0 then we must multiply,
	    // and if scale is zero then we just return intVal;
	    if (scale > 0)
	      return BigInteger.Divide(intVal,BigInteger.Pow (_bigInteger_TEN, scale));
	    else if (scale < 0)
	      return BigInteger.Multiply(intVal,BigInteger.Pow(_bigInteger_TEN, -scale));
	    return intVal;
	  }
	  
	  /**
	   * Converts this BigDecimal into a BigInteger, throwing an 
	   * ArithmeticException if the conversion is not exact.
	   * @return a BigInteger whose value is equal to the value of this BigDecimal
	   * @since 1.5
	   */
	  public BigInteger toBigIntegerExact()
	  {
	    if (scale > 0)
	      {
	        // If we have to divide, we must check if the result is exact.
			BigInteger remainder;
			BigInteger divResult = BigInteger.DivRem(intVal, BigInteger.Pow (_bigInteger_TEN, scale), out remainder);
	        if (remainder.Equals(BigInteger.Zero))
	          return divResult;
	        throw new ArithmeticException("No exact BigInteger representation");
	      }
	    else if (scale < 0)
	      // If we're multiplying instead, then we needn't check for exactness.
	      return BigInteger.Multiply(intVal,BigInteger.Pow(_bigInteger_TEN, -scale));
	    // If the scale is zero we can simply return intVal.
	    return intVal;
	  }
	
	  public override int intValue () 
	  {
	    return (int)(toBigInteger ());
	  }
	  
	  /**
	   * Returns a BigDecimal which is numerically equal to this BigDecimal but 
	   * with no trailing zeros in the representation.  For example, if this 
	   * BigDecimal has [unscaledValue, scale] = [6313000, 4] this method returns
	   * a BigDecimal with [unscaledValue, scale] = [6313, 1].  As another 
	   * example, [12400, -2] would become [124, -4].
	   * @return a numerically equal BigDecimal with no trailing zeros
	   */
	  public BigDecimal stripTrailingZeros()  
	  {
	    String intValStr = intVal.ToString();
	    int newScale = scale;
	    int pointer = intValStr.Length - 1;
	    // This loop adjusts pointer which will be used to give us the substring
	    // of intValStr to use in our new BigDecimal, and also accordingly
	    // adjusts the scale of our new BigDecimal.
	    while (intValStr[pointer] == '0')
	      {
	        pointer --;
	        newScale --;
	      }
	    // Create a new BigDecimal with the appropriate substring and then
	    // set its scale.
	    BigDecimal result = new BigDecimal(intValStr.Substring(0, pointer + 1));    
	    result.scale = newScale;
	    return result;
	  }
	
	  public override long longValue ()
	  {
	    return (long)(toBigInteger());
	  }
	
	  public override float floatValue() 
	  {
	    return Single.Parse(toString());
	  }
	
	  public override double doubleValue() 
	  {
	    return Double.Parse(toString());
	  }
	
	  public BigDecimal setScale (int scale)
	  {
	    return setScale (scale, ROUND_UNNECESSARY);
	  }
	
	  public BigDecimal setScale (int scale, int roundingMode)
	  {
	    // NOTE: The 1.5 JRE doesn't throw this, ones prior to it do and
	    // the spec says it should. Nevertheless, if 1.6 doesn't fix this
	    // we should consider removing it.
	    if( scale < 0 ) throw new ArithmeticException("Scale parameter < 0.");
	    return divide (ONE, scale, roundingMode);
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is the same as this BigDecimal but whose
	   * representation has a scale of <code>newScale</code>.  If the scale is
	   * reduced then rounding may occur, according to the RoundingMode.
	   * @param newScale
	   * @param roundingMode
	   * @return a BigDecimal whose scale is as given, whose value is 
	   * <code>this</code> with possible rounding
	   * @throws ArithmeticException if the rounding mode is UNNECESSARY but 
	   * rounding is required 
	   * @since 1.5
	   */
	  public BigDecimal setScale(int newScale, RoundingMode roundingMode)
	  {
	    return setScale(newScale, (int)roundingMode);
	  }
	  
	  /**
	   * Returns a new BigDecimal constructed from the BigDecimal(String) 
	   * constructor using the Double.toString(double) method to obtain
	   * the String.
	   * @param val the double value used in Double.toString(double)
	   * @return a BigDecimal representation of val
	   * @throws NumberFormatException if val is NaN or infinite
	   * @since 1.5
	   */
	  public static BigDecimal valueOf(double val)
	  {
	    if (Double.IsInfinity(val) || Double.IsNaN(val))
	      throw new FormatException("argument cannot be NaN or infinite.");
	    return new BigDecimal(String.Format("{0}",val));
	  }
	  
	  /**
	   * Returns a BigDecimal whose numerical value is the numerical value
	   * of this BigDecimal multiplied by 10 to the power of <code>n</code>. 
	   * @param n the power of ten
	   * @return the new BigDecimal
	   * @since 1.5
	   */
	  public BigDecimal scaleByPowerOfTen(int n)
	  {
	    BigDecimal result = new BigDecimal(intVal, scale - n);
	    result.precision = precision;
	    return result;
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is <code>this</code> to the power of 
	   * <code>n</code>. 
	   * @param n the power
	   * @return the new BigDecimal
	   * @since 1.5
	   */
	  public BigDecimal pow(int n)
	  {
	    if (n < 0 || n > 999999999)
	      throw new ArithmeticException("n must be between 0 and 999999999");
	    BigDecimal result = new BigDecimal(BigInteger.Pow (intVal, n), scale * n);
	    return result;
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is determined by first calling pow(n)
	   * and then by rounding according to the MathContext mc.
	   * @param n the power
	   * @param mc the MathContext
	   * @return the new BigDecimal
	   * @throws ArithmeticException if n < 0 or n > 999999999 or if the result is
	   * inexact but the rounding is RoundingMode.UNNECESSARY
	   * @since 1.5
	   */
	  public BigDecimal pow(int n, MathContext mc)
	  {
	    // FIXME: The specs claim to use the X3.274-1996 algorithm.  We
	    // currently do not.
	    return pow(n).round(mc);
	  }
	  
	  /**
	   * Returns a BigDecimal whose value is the absolute value of this BigDecimal
	   * with rounding according to the given MathContext.
	   * @param mc the MathContext
	   * @return the new BigDecimal
	   */
	  public BigDecimal abs(MathContext mc)
	  {
	    BigDecimal result = abs();
	    result = result.round(mc);
	    return result;
	  }
	  
	  /**
	   * Returns the size of a unit in the last place of this BigDecimal.  This
	   * returns a BigDecimal with [unscaledValue, scale] = [1, this.scale()].
	   * @return the size of a unit in the last place of <code>this</code>.
	   * @since 1.5
	   */
	  public BigDecimal ulp()
	  {
	    return new BigDecimal(BigInteger.One, scale);
	  }
	  
	  /**
	   * Converts this BigDecimal to a long value.
	   * @return the long value
	   * @throws ArithmeticException if rounding occurs or if overflow occurs
	   * @since 1.5
	   */
	  public long longValueExact()
	  {
	    // Set scale will throw an exception if rounding occurs.
	    BigDecimal temp = setScale(0, ROUND_UNNECESSARY);
	    BigInteger tempVal = temp.intVal;
	    // Check for overflow.
	    long result = (long)intVal;
	    if (tempVal.CompareTo(new BigInteger(Int64.MaxValue)) > 1
	        || (result < 0 && signum() == 1) || (result > 0 && signum() == -1))
	      throw new ArithmeticException("this BigDecimal is too " +
	            "large to fit into the return type");
	    
	    return (long)(intVal);
	  }
	  
	  /**
	   * Converts this BigDecimal into an int by first calling longValueExact
	   * and then checking that the <code>long</code> returned from that
	   * method fits into an <code>int</code>.
	   * @return an int whose value is <code>this</code>
	   * @throws ArithmeticException if this BigDecimal has a fractional part
	   * or is too large to fit into an int.
	   * @since 1.5
	   */
	  public int intValueExact()
	  {
	    long temp = longValueExact();
	    int result = (int)temp;
	    if (result != temp)
	      throw new ArithmeticException ("this BigDecimal cannot fit into an int");
	    return result;
	  }
	  
	  /**
	   * Converts this BigDecimal into a byte by first calling longValueExact
	   * and then checking that the <code>long</code> returned from that
	   * method fits into a <code>byte</code>.
	   * @return a byte whose value is <code>this</code>
	   * @throws ArithmeticException if this BigDecimal has a fractional part
	   * or is too large to fit into a byte.
	   * @since 1.5
	   */
	  public byte byteValueExact()
	  {
	    long temp = longValueExact();
	    byte result = (byte)temp;
	    if (result != temp)
	      throw new ArithmeticException ("this BigDecimal cannot fit into a byte");
	    return result;
	  }
	  
	  /**
	   * Converts this BigDecimal into a short by first calling longValueExact
	   * and then checking that the <code>long</code> returned from that
	   * method fits into a <code>short</code>.
	   * @return a short whose value is <code>this</code>
	   * @throws ArithmeticException if this BigDecimal has a fractional part
	   * or is too large to fit into a short.
	   * @since 1.5
	   */
	  public short shortValueExact()
	  {
	    long temp = longValueExact();
	    short result = (short)temp;
	    if (result != temp)
	      throw new ArithmeticException ("this BigDecimal cannot fit into a short");
	    return result;
	  }

	  #region IComparable[BigDecimal] implementation
	  int IComparable<BigDecimal>.CompareTo (BigDecimal other)
	  {
		 return this.compareTo(other);
	  }
	  #endregion
	}
}

