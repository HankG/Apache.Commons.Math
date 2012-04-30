using System;

/**
 * Representation of real numbers with arbitrary precision field.
 * <p>
 * This class is a singleton.
 * </p>
 * @see BigReal
 * @version $Id: BigRealField.java 1244107 2012-02-14 16:17:55Z erans $
 * @since 2.0
 */

namespace Apache.Commons.Math.Util
{
	[Serializable]
	public class BigRealField: IField<BigReal>  {
	
	    /** Serializable version identifier */
	    internal static readonly long serialVersionUID = 4756431066541037559L;
	
	    /** Private constructor for the singleton.
	     */
	    private BigRealField() {
	    }
	
	    /** Get the unique instance.
	     * @return the unique instance
	     */
	    public static BigRealField getInstance() {
	        return LazyHolder.INSTANCE;
	    }

		#region IField[BigReal] implementation
		BigReal IField<BigReal>.Zero {
			get {
				return BigReal.ZERO;
			}
		}

		BigReal IField<BigReal>.One {
			get {
				return BigReal.ONE;
			}
		}

		Type IField<BigReal>.RuntimeType {
			get {
				return new BigReal(0).GetType();
			}
		}
		#endregion	
	    /** {@inheritDoc} */
	    public BigReal getOne() {
	        return BigReal.ONE;
	    }
	
	    /** {@inheritDoc} */
	    public BigReal getZero() {
	        return BigReal.ZERO;
	    }
		
	    // CHECKSTYLE: stop HideUtilityClassConstructor
	    /** Holder for the instance.
	     * <p>We use here the Initialization On Demand Holder Idiom.</p>
	     */
	    private static class LazyHolder {
	        /** Cached field instance. */
	        internal static readonly BigRealField INSTANCE = new BigRealField();
	    }
	    // CHECKSTYLE: resume HideUtilityClassConstructor
	
	    /** Handle deserialization of the singleton.
	     * @return the singleton instance
	     */
	    private Object readResolve() {
	        // return the singleton instance
	        return LazyHolder.INSTANCE;
	    }
	
	}
}

