using System;
using System.Numerics;
using JavaDotNet.Math;
using Apache.Commons.Math.Exceptions;
using Apache.Commons.Math.Exceptions.Util;


/**
 * Arbitrary precision decimal number.
 * <p>
 * This class is a simple wrapper around the standard <code>BigDecimal</code>
 * in order to implement the {@link FieldElement} interface.
 * </p>
 * @since 2.0
 * @version $Id: BigReal.java 1294043 2012-02-27 06:32:59Z celestin $
 */

namespace Apache.Commons.Math.Util
{
	[Serializable]
	public class BigReal:IFieldElement<BigReal>, IComparable<BigReal> 
	{
	    /** A big real representing 0. */
	    public static readonly BigReal ZERO = new BigReal(BigDecimal.ZERO);
	
	    /** A big real representing 1. */
	    public static readonly BigReal ONE = new BigReal(BigDecimal.ONE);
	
	    /** Serializable version identifier. */
	    internal static readonly long serialVersionUID = 4984534880991310382L;
	
	    /** Underlying BigDecimal. */
	    private readonly BigDecimal d;
	
	    /** Rounding mode for divisions. **/
	    private RoundingMode roundingMode = RoundingMode.HALF_UP;
	
	    /*** BigDecimal scale ***/
	    private int scale = 64;
	
	    /** Build an instance from a BigDecimal.
	     * @param val value of the instance
	     */
	    public BigReal(BigDecimal val) {
	        d =  val;
	    }
	
	    /** Build an instance from a BigInteger.
	     * @param val value of the instance
	     */
	    public BigReal(BigInteger val) {
	        d = new BigDecimal(val);
	    }
	
	    /** Build an instance from an unscaled BigInteger.
	     * @param unscaledVal unscaled value
	     * @param scale scale to use
	     */
	    public BigReal(BigInteger unscaledVal, int scale) {
	        d = new BigDecimal(unscaledVal, scale);
	    }
	
	    /** Build an instance from an unscaled BigInteger.
	     * @param unscaledVal unscaled value
	     * @param scale scale to use
	     * @param mc to used
	     */
	    public BigReal(BigInteger unscaledVal, int scale, MathContext mc) {
	        d = new BigDecimal(unscaledVal, scale, mc);
	    }
	
	    /** Build an instance from a BigInteger.
	     * @param val value of the instance
	     * @param mc context to use
	     */
	    public BigReal(BigInteger val, MathContext mc) {
	        d = new BigDecimal(val, mc);
	    }
	
	    /** Build an instance from a characters representation.
	     * @param in character representation of the value
	     */
	    public BigReal(char[] input) {
	        d = new BigDecimal(input);
	    }
	
	    /** Build an instance from a characters representation.
	     * @param in character representation of the value
	     * @param offset offset of the first character to analyze
	     * @param len length of the array slice to analyze
	     */
	    public BigReal(char[] input, int offset, int len) {
	        d = new BigDecimal(input, offset, len);
	    }
	
	    /** Build an instance from a characters representation.
	     * @param in character representation of the value
	     * @param offset offset of the first character to analyze
	     * @param len length of the array slice to analyze
	     * @param mc context to use
	     */
	    public BigReal(char[] input, int offset, int len, MathContext mc) {
	        d = new BigDecimal(input, offset, len, mc);
	    }
	
	    /** Build an instance from a characters representation.
	     * @param in character representation of the value
	     * @param mc context to use
	     */
	    public BigReal(char[] input, MathContext mc) {
	        d = new BigDecimal(input, mc);
	    }
	
	    /** Build an instance from a double.
	     * @param val value of the instance
	     */
	    public BigReal(double val) {
	        d = new BigDecimal(val);
	    }
	
	    /** Build an instance from a double.
	     * @param val value of the instance
	     * @param mc context to use
	     */
	    public BigReal(double val, MathContext mc) {
	        d = new BigDecimal(val, mc);
	    }
	
	    /** Build an instance from an int.
	     * @param val value of the instance
	     */
	    public BigReal(int val) {
	        d = new BigDecimal(val);
	    }
	
	    /** Build an instance from an int.
	     * @param val value of the instance
	     * @param mc context to use
	     */
	    public BigReal(int val, MathContext mc) {
	        d = new BigDecimal(val, mc);
	    }
	
	    /** Build an instance from a long.
	     * @param val value of the instance
	     */
	    public BigReal(long val) {
	        d = new BigDecimal(val);
	    }
	
	    /** Build an instance from a long.
	     * @param val value of the instance
	     * @param mc context to use
	     */
	    public BigReal(long val, MathContext mc) {
	        d = new BigDecimal(val, mc);
	    }
	
	    /** Build an instance from a String representation.
	     * @param val character representation of the value
	     */
	    public BigReal(String val) {
	        d = new BigDecimal(val);
	    }
	
	    /** Build an instance from a String representation.
	     * @param val character representation of the value
	     * @param mc context to use
	     */
	    public BigReal(String val, MathContext mc)  {
	        d = new BigDecimal(val, mc);
	    }
	
	    /***
	     * Gets the rounding mode for division operations
	     * The default is {@code RoundingMode.HALF_UP}
	     * @return the rounding mode.
	     * @since 2.1
	     */
	    public RoundingMode getRoundingMode() {
	        return roundingMode;
	    }
	
	    /***
	     * Sets the rounding mode for decimal divisions.
	     * @param roundingMode rounding mode for decimal divisions
	     * @since 2.1
	     */
	    public void setRoundingMode(RoundingMode roundingMode) {
	        this.roundingMode = roundingMode;
	    }
	
	    /***
	     * Sets the scale for division operations.
	     * The default is 64
	     * @return the scale
	     * @since 2.1
	     */
	    public int getScale() {
	        return scale;
	    }
	
	    /***
	     * Sets the scale for division operations.
	     * @param scale scale for division operations
	     * @since 2.1
	     */
	    public void setScale(int scale) {
	        this.scale = scale;
	    }
	
	    /** {@inheritDoc} */
	    public BigReal add(BigReal a) {
	        return new BigReal(d.add(a.d));
	    }
	
	    /** {@inheritDoc} */
	    public BigReal subtract(BigReal a) {
	        return new BigReal(d.subtract(a.d));
	    }
	
	    /** {@inheritDoc} */
	    public BigReal negate() {
	        return new BigReal(d.negate());
	    }
	
	    /**
	     * {@inheritDoc}
	     *
	     * @throws MathArithmeticException if {@code a} is zero
	     */
	    public BigReal divide(BigReal a) {
	        try {
	            return new BigReal(d.divide(a.d, scale, roundingMode));
	        } catch (ArithmeticException e) {
	            // Division by zero has occured
	            throw new MathArithmeticException(LocalizedFormats.ZERO_NOT_ALLOWED);
	        }
	    }
	
	    /**
	     * {@inheritDoc}
	     *
	     * @throws MathArithmeticException if {@code this} is zero
	     */
	    public BigReal reciprocal() {
	        try {
	            return new BigReal(BigDecimal.ONE.divide(d, scale, roundingMode));
	        } catch (ArithmeticException e) {
	            // Division by zero has occured
	            throw new MathArithmeticException(LocalizedFormats.ZERO_NOT_ALLOWED);
	        }
	    }
	
	    /** {@inheritDoc} */
	    public BigReal multiply(BigReal a) {
	        return new BigReal(d.multiply(a.d));
	    }
	
	    /** {@inheritDoc} */
	    public BigReal multiply(int n) {
	        return new BigReal(d.multiply(new BigDecimal(n)));
	    }
	
	    /** {@inheritDoc} */
	    public int compareTo(BigReal a) {
	        return d.compareTo(a.d);
	    }
	
	    /** Get the double value corresponding to the instance.
	     * @return double value corresponding to the instance
	     */
	    public double doubleValue() {
	        return d.doubleValue();
	    }
	
	    /** Get the BigDecimal value corresponding to the instance.
	     * @return BigDecimal value corresponding to the instance
	     */
	    public BigDecimal bigDecimalValue() {
	        return d;
	    }
	
	    /** {@inheritDoc} */
	    public bool equals(Object other) {
	        if (this == other){
	            return true;
	        }
	
	        if (other is BigReal){
	            return d.equals(((BigReal) other).d);
	        }
	        return false;
	    }
	
	    /** {@inheritDoc} */
	    public int hashCode() {
	        return d.hashCode();
	    }
	
	    /** {@inheritDoc} */
	    public IField<BigReal> Field {
			get
			{
	        	return BigRealField.getInstance();
			}
	    }

		#region IComparable[BigReal] implementation
		int IComparable<BigReal>.CompareTo (BigReal other)
		{
			return this.compareTo(other);
		}
		#endregion
	}
}

