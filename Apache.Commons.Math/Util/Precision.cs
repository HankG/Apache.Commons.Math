using System;
using System.Numerics;
using JavaDotNet.Math;
using Apache.Commons.Math.Exceptions;
using Apache.Commons.Math.Exceptions.Util;

/**
 * Utilities for comparing numbers.
 *
 * @since 3.0
 * @version $Id$
 */

namespace Apache.Commons.Math.Util
{
	public class Precision {
	
	    /** Exponent offset in IEEE754 representation. */
	    private static readonly long EXPONENT_OFFSET = 1023L;
	
	    /**
	     * Smallest positive number such that {@code 1 - EPSILON} is not
	     * numerically equal to 1.
	     * <br/>
	     * In IEEE 754 arithmetic, this is 2<sup>-53</sup>.
	     */
	    public static readonly double EPSILON = BitConverter.Int64BitsToDouble((EXPONENT_OFFSET - 53L) << 52);
	    //This was previously expressed as = 0x1.0p-53;
	    // However, OpenJDK (Sparc Solaris) cannot handle such small constants: MATH-721
	
	    /**
	     * Safe minimum, such that {@code 1 / SAFE_MIN} does not overflow.
	     * <br/>
	     * In IEEE 754 arithmetic, this is also the smallest normalized
	     * number 2<sup>-1022</sup>.
	     */
	    public static readonly double SAFE_MIN = BitConverter.Int64BitsToDouble((EXPONENT_OFFSET - 1022L) << 52);
	    // This was previously expressed as = 0x1.0p-1022;
	    // However, OpenJDK (Sparc Solaris) cannot handle such small constants: MATH-721
	
		//TODO: Why are these masks okay as long and int but have to be ulong and uint in .NET?
	    /** Offset to order signed double numbers lexicographically. */
	    private static readonly ulong SGN_MASK = 0x8000000000000000L;
		
	    /** Offset to order signed double numbers lexicographically. */
	    private static readonly uint SGN_MASK_FLOAT = 0x80000000;
	
	    /**
	     * Private constructor.
	     */
	    private Precision() {}
	
	    /**
	     * Compares two numbers given some amount of allowed error.
	     *
	     * @param x the first number
	     * @param y the second number
	     * @param eps the amount of error to allow when checking for equality
	     * @return <ul><li>0 if  {@link #equals(double, double, double) equals(x, y, eps)}</li>
	     *       <li>&lt; 0 if !{@link #equals(double, double, double) equals(x, y, eps)} &amp;&amp; x &lt; y</li>
	     *       <li>> 0 if !{@link #equals(double, double, double) equals(x, y, eps)} &amp;&amp; x > y</li></ul>
	     */
	    public static int compareTo(double x, double y, double eps) {
	        if (equals(x, y, eps)) {
	            return 0;
	        } else if (x < y) {
	            return -1;
	        }
	        return 1;
	    }
	
	    /**
	     * Compares two numbers given some amount of allowed error.
	     * Two float numbers are considered equal if there are {@code (maxUlps - 1)}
	     * (or fewer) floating point numbers between them, i.e. two adjacent floating
	     * point numbers are considered equal.
	     * Adapted from <a
	     * href="http://www.cygnus-software.com/papers/comparingfloats/comparingfloats.htm">
	     * Bruce Dawson</a>
	     *
	     * @param x first value
	     * @param y second value
	     * @param maxUlps {@code (maxUlps - 1)} is the number of floating point
	     * values between {@code x} and {@code y}.
	     * @return <ul><li>0 if  {@link #equals(double, double, int) equals(x, y, maxUlps)}</li>
	     *       <li>&lt; 0 if !{@link #equals(double, double, int) equals(x, y, maxUlps)} &amp;&amp; x &lt; y</li>
	     *       <li>> 0 if !{@link #equals(double, double, int) equals(x, y, maxUlps)} &amp;&amp; x > y</li></ul>
	     */
	    public static int compareTo(double x, double y, int maxUlps) {
	        if (equals(x, y, maxUlps)) {
	            return 0;
	        } else if (x < y) {
	            return -1;
	        }
	        return 1;
	    }
	
	    /**
	     * Returns true iff they are equal as defined by
	     * {@link #equals(float,float,int) equals(x, y, 1)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @return {@code true} if the values are equal.
	     */
	    public static bool equals(float x, float y) {
	        return equals(x, y, 1);
	    }
	
	    /**
	     * Returns true if both arguments are NaN or neither is NaN and they are
	     * equal as defined by {@link #equals(float,float) equals(x, y, 1)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @return {@code true} if the values are equal or both are NaN.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(float x, float y) {
	        return (Single.IsNaN(x) && Single.IsNaN(y)) || equals(x, y, 1);
	    }
	
	    /**
	     * Returns true if both arguments are equal or within the range of allowed
	     * error (inclusive).
	     *
	     * @param x first value
	     * @param y second value
	     * @param eps the amount of absolute error to allow.
	     * @return {@code true} if the values are equal or within range of each other.
	     * @since 2.2
	     */
	    public static bool equals(float x, float y, float eps) {
	        return equals(x, y, 1) || FastMath.abs(y - x) <= eps;
	    }
	
	    /**
	     * Returns true if both arguments are NaN or are equal or within the range
	     * of allowed error (inclusive).
	     *
	     * @param x first value
	     * @param y second value
	     * @param eps the amount of absolute error to allow.
	     * @return {@code true} if the values are equal or within range of each other,
	     * or both are NaN.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(float x, float y, float eps) {
	        return equalsIncludingNaN(x, y) || (FastMath.abs(y - x) <= eps);
	    }
	
	    /**
	     * Returns true if both arguments are equal or within the range of allowed
	     * error (inclusive).
	     * Two float numbers are considered equal if there are {@code (maxUlps - 1)}
	     * (or fewer) floating point numbers between them, i.e. two adjacent floating
	     * point numbers are considered equal.
	     * Adapted from <a
	     * href="http://www.cygnus-software.com/papers/comparingfloats/comparingfloats.htm">
	     * Bruce Dawson</a>
	     *
	     * @param x first value
	     * @param y second value
	     * @param maxUlps {@code (maxUlps - 1)} is the number of floating point
	     * values between {@code x} and {@code y}.
	     * @return {@code true} if there are fewer than {@code maxUlps} floating
	     * point values between {@code x} and {@code y}.
	     * @since 2.2
	     */
	    public static bool equals(float x, float y, int maxUlps) {
	        int xInt = ACMBitConverter.SingleToInt32Bits(x);
	        int yInt = ACMBitConverter.SingleToInt32Bits(y);
	
	        // Make lexicographically ordered as a two's-complement integer.
	        if (xInt < 0) {
	            xInt = (int)SGN_MASK_FLOAT - xInt;
	        }
	        if (yInt < 0) {
	            yInt = (int)SGN_MASK_FLOAT - yInt;
	        }
	
	        bool isEqual = FastMath.abs(xInt - yInt) <= maxUlps;
	
	        return isEqual && !Single.IsNaN(x) && !Single.IsNaN(y);
	    }
	
	    /**
	     * Returns true if both arguments are NaN or if they are equal as defined
	     * by {@link #equals(float,float,int) equals(x, y, maxUlps)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @param maxUlps {@code (maxUlps - 1)} is the number of floating point
	     * values between {@code x} and {@code y}.
	     * @return {@code true} if both arguments are NaN or if there are less than
	     * {@code maxUlps} floating point values between {@code x} and {@code y}.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(float x, float y, int maxUlps) {
	        return (Single.IsNaN(x) && Single.IsNaN(y)) || equals(x, y, maxUlps);
	    }
	
	    /**
	     * Returns true iff they are equal as defined by
	     * {@link #equals(double,double,int) equals(x, y, 1)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @return {@code true} if the values are equal.
	     */
	    public static bool equals(double x, double y) {
	        return equals(x, y, 1);
	    }
	
	    /**
	     * Returns true if both arguments are NaN or neither is NaN and they are
	     * equal as defined by {@link #equals(double,double) equals(x, y, 1)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @return {@code true} if the values are equal or both are NaN.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(double x, double y) {
	        return (Double.IsNaN(x) && Double.IsNaN(y)) || equals(x, y, 1);
	    }
	
	    /**
	     * Returns {@code true} if there is no double value strictly between the
	     * arguments or the difference between them is within the range of allowed
	     * error (inclusive).
	     *
	     * @param x First value.
	     * @param y Second value.
	     * @param eps Amount of allowed absolute error.
	     * @return {@code true} if the values are two adjacent floating point
	     * numbers or they are within range of each other.
	     */
	    public static bool equals(double x, double y, double eps) {
	        return equals(x, y, 1) || FastMath.abs(y - x) <= eps;
	    }
	
	    /**
	     * Returns true if both arguments are NaN or are equal or within the range
	     * of allowed error (inclusive).
	     *
	     * @param x first value
	     * @param y second value
	     * @param eps the amount of absolute error to allow.
	     * @return {@code true} if the values are equal or within range of each other,
	     * or both are NaN.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(double x, double y, double eps) {
	        return equalsIncludingNaN(x, y) || (FastMath.abs(y - x) <= eps);
	    }
	
	    /**
	     * Returns true if both arguments are equal or within the range of allowed
	     * error (inclusive).
	     * Two float numbers are considered equal if there are {@code (maxUlps - 1)}
	     * (or fewer) floating point numbers between them, i.e. two adjacent floating
	     * point numbers are considered equal.
	     * Adapted from <a
	     * href="http://www.cygnus-software.com/papers/comparingfloats/comparingfloats.htm">
	     * Bruce Dawson</a>
	     *
	     * @param x first value
	     * @param y second value
	     * @param maxUlps {@code (maxUlps - 1)} is the number of floating point
	     * values between {@code x} and {@code y}.
	     * @return {@code true} if there are fewer than {@code maxUlps} floating
	     * point values between {@code x} and {@code y}.
	     */
	    public static bool equals(double x, double y, int maxUlps) {
	        long xInt = BitConverter.DoubleToInt64Bits(x);
	        long yInt = BitConverter.DoubleToInt64Bits(y);
	
	        // Make lexicographically ordered as a two's-complement integer.
			//TODO: Look at impact of type conversion (mask changed to fix compiler warning on size of mask at definition)
	        if (xInt < 0) {
	            xInt = (long)SGN_MASK - xInt;
	        }
	        if (yInt < 0) {
	            yInt = (long)SGN_MASK - yInt;
	        }
	
	        bool isEqual = FastMath.abs(xInt - yInt) <= maxUlps;
	
	        return isEqual && !Double.IsNaN(x) && !Double.IsNaN(y);
	    }
	
	    /**
	     * Returns true if both arguments are NaN or if they are equal as defined
	     * by {@link #equals(double,double,int) equals(x, y, maxUlps)}.
	     *
	     * @param x first value
	     * @param y second value
	     * @param maxUlps {@code (maxUlps - 1)} is the number of floating point
	     * values between {@code x} and {@code y}.
	     * @return {@code true} if both arguments are NaN or if there are less than
	     * {@code maxUlps} floating point values between {@code x} and {@code y}.
	     * @since 2.2
	     */
	    public static bool equalsIncludingNaN(double x, double y, int maxUlps) {
	        return (Double.IsNaN(x) && Double.IsNaN(y)) || equals(x, y, maxUlps);
	    }
	
	    /**
	     * Rounds the given value to the specified number of decimal places.
	     * The value is rounded using the {@link BigDecimal#ROUND_HALF_UP} method.
	     *
	     * @param x Value to round.
	     * @param scale Number of digits to the right of the decimal point.
	     * @return the rounded value.
	     * @since 1.1 (previously in {@code MathUtils}, moved as of version 3.0)
	     */
	    public static double round(double x, int scale) {
	        return round(x, scale, BigDecimal.ROUND_HALF_UP);
	    }
	
	    /**
	     * Rounds the given value to the specified number of decimal places.
	     * The value is rounded using the given method which is any method defined
	     * in {@link BigDecimal}.
	     * If {@code x} is infinite or {@code NaN}, then the value of {@code x} is
	     * returned unchanged, regardless of the other parameters.
	     *
	     * @param x Value to round.
	     * @param scale Number of digits to the right of the decimal point.
	     * @param roundingMethod Rounding method as defined in {@link BigDecimal}.
	     * @return the rounded value.
	     * @throws ArithmeticException if {@code roundingMethod == ROUND_UNNECESSARY}
	     * and the specified scaling operation would require rounding.
	     * @throws IllegalArgumentException if {@code roundingMethod} does not
	     * represent a valid rounding mode.
	     * @since 1.1 (previously in {@code MathUtils}, moved as of version 3.0)
	     */
	    public static double round(double x, int scale, int roundingMethod) {
	        try {
	            return (new BigDecimal
	                   (String.Format ("{0}",x))
	                   .setScale(scale, roundingMethod))
	                   .doubleValue();
	        } catch (FormatException ex) {
	            if (Double.IsInfinity(x)) {
	                return x;
	            } else {
	                return Double.NaN;
	            }
	        }
	    }
	
	    /**
	     * Rounds the given value to the specified number of decimal places.
	     * The value is rounded using the {@link BigDecimal#ROUND_HALF_UP} method.
	     *
	     * @param x Value to round.
	     * @param scale Number of digits to the right of the decimal point.
	     * @return the rounded value.
	     * @since 1.1 (previously in {@code MathUtils}, moved as of version 3.0)
	     */
	    public static float round(float x, int scale) {
	        return round(x, scale, BigDecimal.ROUND_HALF_UP);
	    }
	
	    /**
	     * Rounds the given value to the specified number of decimal places.
	     * The value is rounded using the given method which is any method defined
	     * in {@link BigDecimal}.
	     *
	     * @param x Value to round.
	     * @param scale Number of digits to the right of the decimal point.
	     * @param roundingMethod Rounding method as defined in {@link BigDecimal}.
	     * @return the rounded value.
	     * @since 1.1 (previously in {@code MathUtils}, moved as of version 3.0)
	     */
	    public static float round(float x, int scale, int roundingMethod) {
	        float sign = FastMath.copySign(1f, x);
	        float factor = (float) FastMath.pow(10.0f, scale) * sign;
	        return (float) roundUnscaled(x * factor, sign, roundingMethod) / factor;
	    }
	
	    /**
	     * Rounds the given non-negative value to the "nearest" integer. Nearest is
	     * determined by the rounding method specified. Rounding methods are defined
	     * in {@link BigDecimal}.
	     *
	     * @param unscaled Value to round.
	     * @param sign Sign of the original, scaled value.
	     * @param roundingMethod Rounding method, as defined in {@link BigDecimal}.
	     * @return the rounded value.
	     * @throws MathIllegalArgumentException if {@code roundingMethod} is not a valid rounding method.
	     * @since 1.1 (previously in {@code MathUtils}, moved as of version 3.0)
	     */
	    private static double roundUnscaled(double unscaled,
	                                        double sign,
	                                        int roundingMethod) {
	        switch (roundingMethod) {
	        case BigDecimal.ROUND_CEILING :
	            if (sign == -1) {
	                unscaled = FastMath.floor(FastMath.nextAfter(unscaled, Double.NegativeInfinity));
	            } else {
	                unscaled = FastMath.ceil(FastMath.nextAfter(unscaled, Double.PositiveInfinity));
	            }
	            break;
	        case BigDecimal.ROUND_DOWN :
	            unscaled = FastMath.floor(FastMath.nextAfter(unscaled, Double.NegativeInfinity));
	            break;
	        case BigDecimal.ROUND_FLOOR :
	            if (sign == -1) {
	                unscaled = FastMath.ceil(FastMath.nextAfter(unscaled, Double.PositiveInfinity));
	            } else {
	                unscaled = FastMath.floor(FastMath.nextAfter(unscaled, Double.NegativeInfinity));
	            }
	            break;
	        case BigDecimal.ROUND_HALF_DOWN : {
	            unscaled = FastMath.nextAfter(unscaled, Double.NegativeInfinity);
	            double fraction = unscaled - FastMath.floor(unscaled);
	            if (fraction > 0.5) {
	                unscaled = FastMath.ceil(unscaled);
	            } else {
	                unscaled = FastMath.floor(unscaled);
	            }
	            break;
	        }
	        case BigDecimal.ROUND_HALF_EVEN : {
	            double fraction = unscaled - FastMath.floor(unscaled);
	            if (fraction > 0.5) {
	                unscaled = FastMath.ceil(unscaled);
	            } else if (fraction < 0.5) {
	                unscaled = FastMath.floor(unscaled);
	            } else {
	                // The following equality test is intentional and needed for rounding purposes
	                if (FastMath.floor(unscaled) / 2.0 == FastMath.floor(
						System.Math.Floor(unscaled) / 2.0)) { // even
	                    unscaled = FastMath.floor(unscaled);
	                } else { // odd
	                    unscaled = FastMath.ceil(unscaled);
	                }
	            }
	            break;
	        }
	        case BigDecimal.ROUND_HALF_UP : {
	            unscaled = FastMath.nextAfter(unscaled, Double.PositiveInfinity);
	            double fraction = unscaled - FastMath.floor(unscaled);
	            if (fraction >= 0.5) {
	                unscaled = FastMath.ceil(unscaled);
	            } else {
	                unscaled = FastMath.floor(unscaled);
	            }
	            break;
	        }
	        case BigDecimal.ROUND_UNNECESSARY :
	            if (unscaled != FastMath.floor(unscaled)) {
	                throw new MathArithmeticException();
	            }
	            break;
	        case BigDecimal.ROUND_UP :
	            unscaled = FastMath.ceil(FastMath.nextAfter(unscaled,  Double.PositiveInfinity));
	            break;
	        default :
	            throw new MathIllegalArgumentException(LocalizedFormats.INVALID_ROUNDING_METHOD,
	                                                   roundingMethod,
	                                                   "ROUND_CEILING", BigDecimal.ROUND_CEILING,
	                                                   "ROUND_DOWN", BigDecimal.ROUND_DOWN,
	                                                   "ROUND_FLOOR", BigDecimal.ROUND_FLOOR,
	                                                   "ROUND_HALF_DOWN", BigDecimal.ROUND_HALF_DOWN,
	                                                   "ROUND_HALF_EVEN", BigDecimal.ROUND_HALF_EVEN,
	                                                   "ROUND_HALF_UP", BigDecimal.ROUND_HALF_UP,
	                                                   "ROUND_UNNECESSARY", BigDecimal.ROUND_UNNECESSARY,
	                                                   "ROUND_UP", BigDecimal.ROUND_UP);
	        }
	        return unscaled;
	    }
	
	
	    /**
	     * Computes a number {@code delta} close to {@code originalDelta} with
	     * the property that <pre><code>
	     *   x + delta - x
	     * </code></pre>
	     * is exactly machine-representable.
	     * This is useful when computing numerical derivatives, in order to reduce
	     * roundoff errors.
	     *
	     * @param x Value.
	     * @param originalDelta Offset value.
	     * @return a number {@code delta} so that {@code x + delta} and {@code x}
	     * differ by a representable floating number.
	     */
	    public static double representableDelta(double x,
	                                            double originalDelta) {
	        return x + originalDelta - x;
	    }
	}
}

