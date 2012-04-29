using System;

/**
 * Helper utility to replace the Float int to float converter functions in Java.
 *
 * @since 3.0
 * @version $Id$
 */


namespace Apache.Commons.Math
{
	public class ACMBitConverter
	{
		/**
	     * Takes in a floating point value and returns the integer bits of that value
	     *
	     **/

		public static int SingleToInt32Bits(float value)
		{
			//TODO: Implement SingleToInt32Bits
			throw new NotImplementedException();
			return BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
		}
		
		/**
	     * Takes in a floating point value and returns the integer bits of that value
	     * preservin the NaN
	     *
	     **/

		public static int SingleToRawInt32Bits(float value)
		{
			//TODO: Implement SingleToRawInt32Bits
			throw new NotImplementedException();
			return BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
		}
		

		/**
	     * Takes in an integer bits value and returns the floating point of that value
	     *
	     **/

		public static float Int32BitsToSingle(int value)
		{
			//TODO: Implement Int32BitsToSingle
			throw new NotImplementedException();
			return BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
		}
		
		public ACMBitConverter ()
		{

		}
	}
}

