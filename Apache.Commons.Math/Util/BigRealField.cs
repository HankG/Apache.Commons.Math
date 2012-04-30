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
	public class BigRealField implements Field<BigReal>, Serializable  {
	
	    /** Serializable version identifier */
	    private static final long serialVersionUID = 4756431066541037559L;
	
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
	
	    /** {@inheritDoc} */
	    public BigReal getOne() {
	        return BigReal.ONE;
	    }
	
	    /** {@inheritDoc} */
	    public BigReal getZero() {
	        return BigReal.ZERO;
	    }
	
	    /** {@inheritDoc} */
	    public Class<? extends FieldElement<BigReal>> getRuntimeClass() {
	        return BigReal.class;
	    }
	
	    // CHECKSTYLE: stop HideUtilityClassConstructor
	    /** Holder for the instance.
	     * <p>We use here the Initialization On Demand Holder Idiom.</p>
	     */
	    private static class LazyHolder {
	        /** Cached field instance. */
	        private static final BigRealField INSTANCE = new BigRealField();
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

