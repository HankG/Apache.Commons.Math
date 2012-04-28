using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apache.Commons.Math.Exceptions.Util
{
    public class LocalizedFormats: ILocalizable
    {
        public static readonly LocalizedFormats ARGUMENT_OUTSIDE_DOMAIN = new LocalizedFormats("Argument {0} outside domain [{1} ; {2}]");
        public static readonly LocalizedFormats ARRAY_SIZE_EXCEEDS_MAX_VARIABLES = new LocalizedFormats("array size cannot be greater than {0}");
        public static readonly LocalizedFormats ARRAY_SIZES_SHOULD_HAVE_DIFFERENCE_1 = new LocalizedFormats("array sizes should have difference 1 ({0} != {1} + 1)");
        public static readonly LocalizedFormats ARRAY_SUMS_TO_ZERO = new LocalizedFormats("array sums to zero");
        public static readonly LocalizedFormats ASSYMETRIC_EIGEN_NOT_SUPPORTED = new LocalizedFormats("eigen decomposition of assymetric matrices not supported yet");
        public static readonly LocalizedFormats AT_LEAST_ONE_COLUMN = new LocalizedFormats("matrix must have at least one column");
        public static readonly LocalizedFormats AT_LEAST_ONE_ROW = new LocalizedFormats("matrix must have at least one row");
        public static readonly LocalizedFormats BANDWIDTH = new LocalizedFormats("bandwidth ({0})");
        public static readonly LocalizedFormats BINOMIAL_INVALID_PARAMETERS_ORDER = new LocalizedFormats("must have n >= k for binomial coefficient (n, k), got k = {0}, n = {1}");
        public static readonly LocalizedFormats BINOMIAL_NEGATIVE_PARAMETER = new LocalizedFormats("must have n >= 0 for binomial coefficient (n, k), got n = {0}");
        public static readonly LocalizedFormats CANNOT_CLEAR_STATISTIC_CONSTRUCTED_FROM_EXTERNAL_MOMENTS = new LocalizedFormats("statistics constructed from external moments cannot be cleared");
        public static readonly LocalizedFormats CANNOT_COMPUTE_0TH_ROOT_OF_UNITY = new LocalizedFormats("cannot compute 0-th root of unity, indefinite result");
        public static readonly LocalizedFormats CANNOT_COMPUTE_BETA_DENSITY_AT_0_FOR_SOME_ALPHA = new LocalizedFormats("cannot compute beta density at 0 when alpha = {0,number}");
        public static readonly LocalizedFormats CANNOT_COMPUTE_BETA_DENSITY_AT_1_FOR_SOME_BETA = new LocalizedFormats("cannot compute beta density at 1 when beta = %.3g");
        public static readonly LocalizedFormats CANNOT_COMPUTE_NTH_ROOT_FOR_NEGATIVE_N = new LocalizedFormats("cannot compute nth root for null or negative n: {0}");
        public static readonly LocalizedFormats CANNOT_DISCARD_NEGATIVE_NUMBER_OF_ELEMENTS = new LocalizedFormats("cannot discard a negative number of elements ({0})");
        public static readonly LocalizedFormats CANNOT_FORMAT_INSTANCE_AS_3D_VECTOR = new LocalizedFormats("cannot format a {0} instance as a 3D vector");
        public static readonly LocalizedFormats CANNOT_FORMAT_INSTANCE_AS_COMPLEX = new LocalizedFormats("cannot format a {0} instance as a complex number");
        public static readonly LocalizedFormats CANNOT_FORMAT_INSTANCE_AS_REAL_VECTOR = new LocalizedFormats("cannot format a {0} instance as a real vector");
        public static readonly LocalizedFormats CANNOT_FORMAT_OBJECT_TO_FRACTION = new LocalizedFormats("cannot format given object as a fraction number");
        public static readonly LocalizedFormats CANNOT_INCREMENT_STATISTIC_CONSTRUCTED_FROM_EXTERNAL_MOMENTS = new LocalizedFormats("statistics constructed from external moments cannot be incremented");
        public static readonly LocalizedFormats CANNOT_NORMALIZE_A_ZERO_NORM_VECTOR = new LocalizedFormats("cannot normalize a zero norm vector");
        public static readonly LocalizedFormats CANNOT_RETRIEVE_AT_NEGATIVE_INDEX = new LocalizedFormats("elements cannot be retrieved from a negative array index {0}");
        public static readonly LocalizedFormats CANNOT_SET_AT_NEGATIVE_INDEX = new LocalizedFormats("cannot set an element at a negative index {0}");
        public static readonly LocalizedFormats CANNOT_SUBSTITUTE_ELEMENT_FROM_EMPTY_ARRAY = new LocalizedFormats("cannot substitute an element from an empty array");
        public static readonly LocalizedFormats CANNOT_TRANSFORM_TO_DOUBLE = new LocalizedFormats("Conversion Exception in Transformation: {0}");
        public static readonly LocalizedFormats CARDAN_ANGLES_SINGULARITY = new LocalizedFormats("Cardan angles singularity");
        public static readonly LocalizedFormats CLASS_DOESNT_IMPLEMENT_COMPARABLE = new LocalizedFormats("class ({0}) does not implement Comparable");
        public static readonly LocalizedFormats CLOSEST_ORTHOGONAL_MATRIX_HAS_NEGATIVE_DETERMINANT = new LocalizedFormats("the closest orthogonal matrix has a negative determinant {0}");
        public static readonly LocalizedFormats COLUMN_INDEX_OUT_OF_RANGE = new LocalizedFormats("column index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormats COLUMN_INDEX = new LocalizedFormats("column index ({0})"); /* keep */
        public static readonly LocalizedFormats CONTINUED_FRACTION_INFINITY_DIVERGENCE = new LocalizedFormats("Continued fraction convergents diverged to +/- infinity for value {0}");
        public static readonly LocalizedFormats CONTINUED_FRACTION_NAN_DIVERGENCE = new LocalizedFormats("Continued fraction diverged to NaN for value {0}");
        public static readonly LocalizedFormats CONTRACTION_CRITERIA_SMALLER_THAN_EXPANSION_FACTOR = new LocalizedFormats("contraction criteria ({0}) smaller than the expansion factor ({1}).  This would lead to a never ending loop of expansion and contraction as a newly expanded internal storage array would immediately satisfy the criteria for contraction.");
        public static readonly LocalizedFormats CONTRACTION_CRITERIA_SMALLER_THAN_ONE = new LocalizedFormats("contraction criteria smaller than one ({0}).  This would lead to a never ending loop of expansion and contraction as an internal storage array length equal to the number of elements would satisfy the contraction criteria.");
        public static readonly LocalizedFormats CONVERGENCE_FAILED = new LocalizedFormats("convergence failed"); /* keep */
        public static readonly LocalizedFormats CROSSING_BOUNDARY_LOOPS = new LocalizedFormats("some outline boundary loops cross each other");
        public static readonly LocalizedFormats CUMULATIVE_PROBABILITY_RETURNED_NAN = new LocalizedFormats("Cumulative probability function returned NaN for argument {0} p = {1}");
        public static readonly LocalizedFormats DIFFERENT_ROWS_LENGTHS = new LocalizedFormats("some rows have length {0} while others have length {1}");
        public static readonly LocalizedFormats DIGEST_NOT_INITIALIZED = new LocalizedFormats("digest not initialized");
        public static readonly LocalizedFormats DIMENSIONS_MISMATCH_2x2 = new LocalizedFormats("got {0}x{1} but expected {2}x{3}"); /* keep */
        public static readonly LocalizedFormats DIMENSIONS_MISMATCH_SIMPLE = new LocalizedFormats("{0} != {1}"); /* keep */
        public static readonly LocalizedFormats DIMENSIONS_MISMATCH = new LocalizedFormats("dimensions mismatch"); /* keep */
        public static readonly LocalizedFormats DISCRETE_CUMULATIVE_PROBABILITY_RETURNED_NAN = new LocalizedFormats("Discrete cumulative probability function returned NaN for argument {0}");
        public static readonly LocalizedFormats DISTRIBUTION_NOT_LOADED = new LocalizedFormats("distribution not loaded");
        public static readonly LocalizedFormats DUPLICATED_ABSCISSA = new LocalizedFormats("Abscissa {0} is duplicated at both indices {1} and {2}");
        public static readonly LocalizedFormats EMPTY_CLUSTER_IN_K_MEANS = new LocalizedFormats("empty cluster in k-means");
        public static readonly LocalizedFormats EMPTY_POLYNOMIALS_COEFFICIENTS_ARRAY = new LocalizedFormats("empty polynomials coefficients array"); /* keep */
        public static readonly LocalizedFormats EMPTY_SELECTED_COLUMN_INDEX_ARRAY = new LocalizedFormats("empty selected column index array");
        public static readonly LocalizedFormats EMPTY_SELECTED_ROW_INDEX_ARRAY = new LocalizedFormats("empty selected row index array");
        public static readonly LocalizedFormats EMPTY_STRING_FOR_IMAGINARY_CHARACTER = new LocalizedFormats("empty string for imaginary character");
        public static readonly LocalizedFormats ENDPOINTS_NOT_AN_INTERVAL = new LocalizedFormats("endpoints do not specify an interval: [{0}, {1}]");
        public static readonly LocalizedFormats EQUAL_VERTICES_IN_SIMPLEX = new LocalizedFormats("equal vertices {0} and {1} in simplex configuration");
        public static readonly LocalizedFormats EULER_ANGLES_SINGULARITY = new LocalizedFormats("Euler angles singularity");
        public static readonly LocalizedFormats EVALUATION = new LocalizedFormats("evaluation"); /* keep */
        public static readonly LocalizedFormats EXPANSION_FACTOR_SMALLER_THAN_ONE = new LocalizedFormats("expansion factor smaller than one ({0})");
        public static readonly LocalizedFormats FACTORIAL_NEGATIVE_PARAMETER = new LocalizedFormats("must have n >= 0 for n!, got n = {0}");
        public static readonly LocalizedFormats FAILED_BRACKETING = new LocalizedFormats("number of iterations={4}, maximum iterations={5}, initial={6}, lower bound={7}, upper bound={8}, final a value={0}, final b value={1}, f(a)={2}, f(b)={3}");
        public static readonly LocalizedFormats FAILED_FRACTION_CONVERSION = new LocalizedFormats("Unable to convert {0} to fraction after {1} iterations");
        public static readonly LocalizedFormats FIRST_COLUMNS_NOT_INITIALIZED_YET = new LocalizedFormats("first {0} columns are not initialized yet");
        public static readonly LocalizedFormats FIRST_ELEMENT_NOT_ZERO = new LocalizedFormats("first element is not 0: {0}");
        public static readonly LocalizedFormats FIRST_ROWS_NOT_INITIALIZED_YET = new LocalizedFormats("first {0} rows are not initialized yet");
        public static readonly LocalizedFormats FRACTION_CONVERSION_OVERFLOW = new LocalizedFormats("Overflow trying to convert {0} to fraction ({1}/{2})");
        public static readonly LocalizedFormats FUNCTION_NOT_DIFFERENTIABLE = new LocalizedFormats("function is not differentiable");
        public static readonly LocalizedFormats FUNCTION_NOT_POLYNOMIAL = new LocalizedFormats("function is not polynomial");
        public static readonly LocalizedFormats GCD_OVERFLOW_32_BITS = new LocalizedFormats("overflow: gcd({0}, {1}) is 2^31");
        public static readonly LocalizedFormats GCD_OVERFLOW_64_BITS = new LocalizedFormats("overflow: gcd({0}, {1}) is 2^63");
        public static readonly LocalizedFormats HOLE_BETWEEN_MODELS_TIME_RANGES = new LocalizedFormats("{0} wide hole between models time ranges");
        public static readonly LocalizedFormats IDENTICAL_ABSCISSAS_DIVISION_BY_ZERO = new LocalizedFormats("identical abscissas x[{0}] == x[{1}] == {2} cause division by zero");
        public static readonly LocalizedFormats ILL_CONDITIONED_OPERATOR = new LocalizedFormats("condition number {1} is too high ");
        public static readonly LocalizedFormats INDEX_LARGER_THAN_MAX = new LocalizedFormats("the index specified: {0} is larger than the current maximal index {1}");
        public static readonly LocalizedFormats INDEX_NOT_POSITIVE = new LocalizedFormats("index ({0}) is not positive");
        public static readonly LocalizedFormats INDEX_OUT_OF_RANGE = new LocalizedFormats("index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormats INDEX = new LocalizedFormats("index ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_FINITE_NUMBER = new LocalizedFormats("{0} is not a finite number"); /* keep */
        public static readonly LocalizedFormats ARRAY_ELEMENT = new LocalizedFormats("value {0} at index {1}"); /* keep */
        public static readonly LocalizedFormats INFINITE_ARRAY_ELEMENT = new LocalizedFormats("Array contains an infinite element, {0} at index {1}");
        public static readonly LocalizedFormats INFINITE_VALUE_CONVERSION = new LocalizedFormats("cannot convert infinite value");
        public static readonly LocalizedFormats INITIAL_CAPACITY_NOT_POSITIVE = new LocalizedFormats("initial capacity ({0}) is not positive");
        public static readonly LocalizedFormats INITIAL_COLUMN_AFTER_FINAL_COLUMN = new LocalizedFormats("initial column {1} after final column {0}");
        public static readonly LocalizedFormats INITIAL_ROW_AFTER_FINAL_ROW = new LocalizedFormats("initial row {1} after final row {0}");
        public static readonly LocalizedFormats INPUT_DATA_FROM_UNSUPPORTED_DATASOURCE = new LocalizedFormats("input data comes from unsupported datasource: {0}, supported sources: {1}, {2}");
        public static readonly LocalizedFormats INSTANCES_NOT_COMPARABLE_TO_EXISTING_VALUES = new LocalizedFormats("instance of class {0} not comparable to existing values");
        public static readonly LocalizedFormats INSUFFICIENT_DATA_FOR_T_STATISTIC = new LocalizedFormats("insufficient data for t statistic, needs at least 2, got {0}");
        public static readonly LocalizedFormats INSUFFICIENT_DIMENSION = new LocalizedFormats("insufficient dimension {0}, must be at least {1}");
        public static readonly LocalizedFormats DIMENSION = new LocalizedFormats("dimension ({0})"); /* keep */
        public static readonly LocalizedFormats INSUFFICIENT_OBSERVED_POINTS_IN_SAMPLE = new LocalizedFormats("sample contains {0} observed points, at least {1} are required");
        public static readonly LocalizedFormats INSUFFICIENT_ROWS_AND_COLUMNS = new LocalizedFormats("insufficient data: only {0} rows and {1} columns.");
        public static readonly LocalizedFormats INTEGRATION_METHOD_NEEDS_AT_LEAST_TWO_PREVIOUS_POINTS = new LocalizedFormats("{0} method needs at least two previous points");
        public static readonly LocalizedFormats INTERNAL_ERROR = new LocalizedFormats("internal error, please fill a bug report at {0}");
        public static readonly LocalizedFormats INVALID_BINARY_DIGIT = new LocalizedFormats("invalid binary digit: {0}");
        public static readonly LocalizedFormats INVALID_BRACKETING_PARAMETERS = new LocalizedFormats("invalid bracketing parameters:  lower bound={0},  initial={1}, upper bound={2}");
        public static readonly LocalizedFormats INVALID_INTERVAL_INITIAL_VALUE_PARAMETERS = new LocalizedFormats("invalid interval, initial value parameters:  lower={0}, initial={1}, upper={2}");
        public static readonly LocalizedFormats INVALID_ITERATIONS_LIMITS = new LocalizedFormats("invalid iteration limits: min={0}, max={1}");
        public static readonly LocalizedFormats INVALID_MAX_ITERATIONS = new LocalizedFormats("bad value for maximum iterations number: {0}");
        public static readonly LocalizedFormats NOT_ENOUGH_DATA_REGRESSION = new LocalizedFormats("the number of observations is not sufficient to conduct regression");
        public static readonly LocalizedFormats INVALID_REGRESSION_ARRAY = new LocalizedFormats("input data array length = {0} does not match the number of observations = {1} and the number of regressors = {2}");
        public static readonly LocalizedFormats INVALID_REGRESSION_OBSERVATION = new LocalizedFormats("length of regressor array = {0} does not match the number of variables = {1} in the model");
        public static readonly LocalizedFormats INVALID_ROUNDING_METHOD = new LocalizedFormats("invalid rounding method {0}, valid methods: {1} ({2}), {3} ({4}), {5} ({6}), {7} ({8}), {9} ({10}), {11} ({12}), {13} ({14}), {15} ({16})");
        public static readonly LocalizedFormats ITERATOR_EXHAUSTED = new LocalizedFormats("iterator exhausted");
        public static readonly LocalizedFormats LCM_OVERFLOW_32_BITS = new LocalizedFormats("overflow: lcm({0}, {1}) is 2^31");
        public static readonly LocalizedFormats LCM_OVERFLOW_64_BITS = new LocalizedFormats("overflow: lcm({0}, {1}) is 2^63");
        public static readonly LocalizedFormats LIST_OF_CHROMOSOMES_BIGGER_THAN_POPULATION_SIZE = new LocalizedFormats("list of chromosomes bigger than maxPopulationSize");
        public static readonly LocalizedFormats LOESS_EXPECTS_AT_LEAST_ONE_POINT = new LocalizedFormats("Loess expects at least 1 point");
        public static readonly LocalizedFormats LOWER_BOUND_NOT_BELOW_UPPER_BOUND = new LocalizedFormats("lower bound ({0}) must be strictly less than upper bound ({1})"); /* keep */
        public static readonly LocalizedFormats LOWER_ENDPOINT_ABOVE_UPPER_ENDPOINT = new LocalizedFormats("lower endpoint ({0}) must be less than or equal to upper endpoint ({1})");
        public static readonly LocalizedFormats MAP_MODIFIED_WHILE_ITERATING = new LocalizedFormats("map has been modified while iterating");
        public static readonly LocalizedFormats EVALUATIONS = new LocalizedFormats("evaluations"); /* keep */
        public static readonly LocalizedFormats MAX_COUNT_EXCEEDED = new LocalizedFormats("maximal count ({0}) exceeded"); /* keep */
        public static readonly LocalizedFormats MAX_ITERATIONS_EXCEEDED = new LocalizedFormats("maximal number of iterations ({0}) exceeded");
        public static readonly LocalizedFormats MINIMAL_STEPSIZE_REACHED_DURING_INTEGRATION = new LocalizedFormats("minimal step size ({1,number,0.00E00}) reached, integration needs {0,number,0.00E00}");
        public static readonly LocalizedFormats MISMATCHED_LOESS_ABSCISSA_ORDINATE_ARRAYS = new LocalizedFormats("Loess expects the abscissa and ordinate arrays to be of the same size, but got {0} abscissae and {1} ordinatae");
        public static readonly LocalizedFormats NAN_ELEMENT_AT_INDEX = new LocalizedFormats("element {0} is NaN");
        public static readonly LocalizedFormats NAN_VALUE_CONVERSION = new LocalizedFormats("cannot convert NaN value");
        public static readonly LocalizedFormats NEGATIVE_BRIGHTNESS_EXPONENT = new LocalizedFormats("brightness exponent should be positive or null, but got {0}");
        public static readonly LocalizedFormats NEGATIVE_COMPLEX_MODULE = new LocalizedFormats("negative complex module {0}");
        public static readonly LocalizedFormats NEGATIVE_ELEMENT_AT_2D_INDEX = new LocalizedFormats("element ({0}, {1}) is negative: {2}");
        public static readonly LocalizedFormats NEGATIVE_ELEMENT_AT_INDEX = new LocalizedFormats("element {0} is negative: {1}");
        public static readonly LocalizedFormats NEGATIVE_NUMBER_OF_SUCCESSES = new LocalizedFormats("number of successes must be non-negative ({0})");
        public static readonly LocalizedFormats NUMBER_OF_SUCCESSES = new LocalizedFormats("number of successes ({0})"); /* keep */
        public static readonly LocalizedFormats NEGATIVE_NUMBER_OF_TRIALS = new LocalizedFormats("number of trials must be non-negative ({0})");
        public static readonly LocalizedFormats NUMBER_OF_INTERPOLATION_POINTS = new LocalizedFormats("number of interpolation points ({0})"); /* keep */
        public static readonly LocalizedFormats NUMBER_OF_TRIALS = new LocalizedFormats("number of trials ({0})");
        public static readonly LocalizedFormats ROBUSTNESS_ITERATIONS = new LocalizedFormats("number of robustness iterations ({0})");
        public static readonly LocalizedFormats START_POSITION = new LocalizedFormats("start position ({0})"); /* keep */
        public static readonly LocalizedFormats NON_CONVERGENT_CONTINUED_FRACTION = new LocalizedFormats("Continued fraction convergents failed to converge (in less than {0} iterations) for value {1}");
        public static readonly LocalizedFormats NON_INVERTIBLE_TRANSFORM = new LocalizedFormats("non-invertible affine transform collapses some lines into single points");
        public static readonly LocalizedFormats NON_POSITIVE_MICROSPHERE_ELEMENTS = new LocalizedFormats("number of microsphere elements must be positive, but got {0}");
        public static readonly LocalizedFormats NON_POSITIVE_POLYNOMIAL_DEGREE = new LocalizedFormats("polynomial degree must be positive: degree={0}");
        public static readonly LocalizedFormats NON_REAL_FINITE_ABSCISSA = new LocalizedFormats("all abscissae must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormats NON_REAL_FINITE_ORDINATE = new LocalizedFormats("all ordinatae must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormats NON_REAL_FINITE_WEIGHT = new LocalizedFormats("all weights must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormats NON_SQUARE_MATRIX = new LocalizedFormats("non square ({0}x{1}) matrix");
        public static readonly LocalizedFormats NORMALIZE_INFINITE = new LocalizedFormats("Cannot normalize to an infinite value");
        public static readonly LocalizedFormats NORMALIZE_NAN = new LocalizedFormats("Cannot normalize to NaN");
        public static readonly LocalizedFormats NOT_ADDITION_COMPATIBLE_MATRICES = new LocalizedFormats("{0}x{1} and {2}x{3} matrices are not addition compatible");
        public static readonly LocalizedFormats NOT_DECREASING_NUMBER_OF_POINTS = new LocalizedFormats("points {0} and {1} are not decreasing ({2} < {3})");
        public static readonly LocalizedFormats NOT_DECREASING_SEQUENCE = new LocalizedFormats("points {3} and {2} are not decreasing ({1} < {0})"); /* keep */
        public static readonly LocalizedFormats NOT_ENOUGH_DATA_FOR_NUMBER_OF_PREDICTORS = new LocalizedFormats("not enough data ({0} rows) for this many predictors ({1} predictors)");
        public static readonly LocalizedFormats NOT_ENOUGH_POINTS_IN_SPLINE_PARTITION = new LocalizedFormats("spline partition must have at least {0} points, got {1}");
        public static readonly LocalizedFormats NOT_INCREASING_NUMBER_OF_POINTS = new LocalizedFormats("points {0} and {1} are not increasing ({2} > {3})");
        public static readonly LocalizedFormats NOT_INCREASING_SEQUENCE = new LocalizedFormats("points {3} and {2} are not increasing ({1} > {0})"); /* keep */
        public static readonly LocalizedFormats NOT_MULTIPLICATION_COMPATIBLE_MATRICES = new LocalizedFormats("{0}x{1} and {2}x{3} matrices are not multiplication compatible");
        public static readonly LocalizedFormats ALPHA = new LocalizedFormats("alpha"); /* keep */
        public static readonly LocalizedFormats BETA = new LocalizedFormats("beta"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_COLUMNDIMENSION = new LocalizedFormats("invalid column dimension: {0} (must be positive)");
        public static readonly LocalizedFormats NOT_POSITIVE_DEFINITE_MATRIX = new LocalizedFormats("not positive definite matrix"); /* keep */
        public static readonly LocalizedFormats NON_POSITIVE_DEFINITE_MATRIX = new LocalizedFormats("not positive definite matrix: diagonal element at ({1},{1}) is smaller than {2} ({0})");
        public static readonly LocalizedFormats NON_POSITIVE_DEFINITE_OPERATOR = new LocalizedFormats("non positive definite linear operator"); /* keep */
        public static readonly LocalizedFormats NON_SELF_ADJOINT_OPERATOR = new LocalizedFormats("non self-adjoint linear operator"); /* keep */
        public static readonly LocalizedFormats NON_SQUARE_OPERATOR = new LocalizedFormats("non square ({0}x{1}) linear operator"); /* keep */
        public static readonly LocalizedFormats DEGREES_OF_FREEDOM = new LocalizedFormats("degrees of freedom ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_DEGREES_OF_FREEDOM = new LocalizedFormats("degrees of freedom must be positive ({0})");
        public static readonly LocalizedFormats NOT_POSITIVE_ELEMENT_AT_INDEX = new LocalizedFormats("element {0} is not positive: {1}");
        public static readonly LocalizedFormats NOT_POSITIVE_EXPONENT = new LocalizedFormats("invalid exponent {0} (must be positive)");
        public static readonly LocalizedFormats EXPONENT = new LocalizedFormats("exponent ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_LENGTH = new LocalizedFormats("length must be positive ({0})");
        public static readonly LocalizedFormats LENGTH = new LocalizedFormats("length ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_MEAN = new LocalizedFormats("mean must be positive ({0})");
        public static readonly LocalizedFormats MEAN = new LocalizedFormats("mean ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_NUMBER_OF_SAMPLES = new LocalizedFormats("number of sample is not positive: {0}");
        public static readonly LocalizedFormats NUMBER_OF_SAMPLES = new LocalizedFormats("number of samples ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_PERMUTATION = new LocalizedFormats("permutation k ({0}) must be positive");
        public static readonly LocalizedFormats PERMUTATION_SIZE = new LocalizedFormats("permutation size ({0}"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_POISSON_MEAN = new LocalizedFormats("the Poisson mean must be positive ({0})");
        public static readonly LocalizedFormats NOT_POSITIVE_POPULATION_SIZE = new LocalizedFormats("population size must be positive ({0})");
        public static readonly LocalizedFormats POPULATION_SIZE = new LocalizedFormats("population size ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_ROW_DIMENSION = new LocalizedFormats("invalid row dimension: {0} (must be positive)");
        public static readonly LocalizedFormats NOT_POSITIVE_SAMPLE_SIZE = new LocalizedFormats("sample size must be positive ({0})");
        public static readonly LocalizedFormats NOT_POSITIVE_SCALE = new LocalizedFormats("scale must be positive ({0})");
        public static readonly LocalizedFormats SCALE = new LocalizedFormats("scale ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_SHAPE = new LocalizedFormats("shape must be positive ({0})");
        public static readonly LocalizedFormats SHAPE = new LocalizedFormats("shape ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_STANDARD_DEVIATION = new LocalizedFormats("standard deviation must be positive ({0})");
        public static readonly LocalizedFormats STANDARD_DEVIATION = new LocalizedFormats("standard deviation ({0})"); /* keep */
        public static readonly LocalizedFormats NOT_POSITIVE_UPPER_BOUND = new LocalizedFormats("upper bound must be positive ({0})");
        public static readonly LocalizedFormats NOT_POSITIVE_WINDOW_SIZE = new LocalizedFormats("window size must be positive ({0})");
        public static readonly LocalizedFormats NOT_POWER_OF_TWO = new LocalizedFormats("{0} is not a power of 2");
        public static readonly LocalizedFormats NOT_POWER_OF_TWO_CONSIDER_PADDING = new LocalizedFormats("{0} is not a power of 2, consider padding for fix");
        public static readonly LocalizedFormats NOT_POWER_OF_TWO_PLUS_ONE = new LocalizedFormats("{0} is not a power of 2 plus one");
        public static readonly LocalizedFormats NOT_STRICTLY_DECREASING_NUMBER_OF_POINTS = new LocalizedFormats("points {0} and {1} are not strictly decreasing ({2} <= {3})");
        public static readonly LocalizedFormats NOT_STRICTLY_DECREASING_SEQUENCE = new LocalizedFormats("points {3} and {2} are not strictly decreasing ({1} <= {0})"); /* keep */
        public static readonly LocalizedFormats NOT_STRICTLY_INCREASING_KNOT_VALUES = new LocalizedFormats("knot values must be strictly increasing");
        public static readonly LocalizedFormats NOT_STRICTLY_INCREASING_NUMBER_OF_POINTS = new LocalizedFormats("points {0} and {1} are not strictly increasing ({2} >= {3})");
        public static readonly LocalizedFormats NOT_STRICTLY_INCREASING_SEQUENCE = new LocalizedFormats("points {3} and {2} are not strictly increasing ({1} >= {0})"); /* keep */
        public static readonly LocalizedFormats NOT_SUBTRACTION_COMPATIBLE_MATRICES = new LocalizedFormats("{0}x{1} and {2}x{3} matrices are not subtraction compatible");
        public static readonly LocalizedFormats NOT_SUPPORTED_IN_DIMENSION_N = new LocalizedFormats("method not supported in dimension {0}");
        public static readonly LocalizedFormats NOT_SYMMETRIC_MATRIX = new LocalizedFormats("not symmetric matrix");
        public static readonly LocalizedFormats NON_SYMMETRIC_MATRIX = new LocalizedFormats("non symmetric matrix: the difference between entries at ({0},{1}) and ({1},{0}) is larger than {2}"); /* keep */
        public static readonly LocalizedFormats NO_BIN_SELECTED = new LocalizedFormats("no bin selected");
        public static readonly LocalizedFormats NO_CONVERGENCE_WITH_ANY_START_POINT = new LocalizedFormats("none of the {0} start points lead to convergence"); /* keep */
        public static readonly LocalizedFormats NO_DATA = new LocalizedFormats("no data"); /* keep */
        public static readonly LocalizedFormats NO_DEGREES_OF_FREEDOM = new LocalizedFormats("no degrees of freedom ({0} measurements, {1} parameters)");
        public static readonly LocalizedFormats NO_DENSITY_FOR_THIS_DISTRIBUTION = new LocalizedFormats("This distribution does not have a density function implemented");
        public static readonly LocalizedFormats NO_FEASIBLE_SOLUTION = new LocalizedFormats("no feasible solution");
        public static readonly LocalizedFormats NO_OPTIMUM_COMPUTED_YET = new LocalizedFormats("no optimum computed yet"); /* keep */
        public static readonly LocalizedFormats NO_REGRESSORS = new LocalizedFormats("Regression model must include at least one regressor");
        public static readonly LocalizedFormats NO_RESULT_AVAILABLE = new LocalizedFormats("no result available");
        public static readonly LocalizedFormats NO_SUCH_MATRIX_ENTRY = new LocalizedFormats("no entry at indices ({0}, {1}) in a {2}x{3} matrix");
        public static readonly LocalizedFormats NULL_NOT_ALLOWED = new LocalizedFormats("null is not allowed"); /* keep */
        public static readonly LocalizedFormats ARRAY_ZERO_LENGTH_OR_NULL_NOTALLOWED = new LocalizedFormats("A null or zero length array not allowed");
        public static readonly LocalizedFormats COVARIANCE_MATRIX = new LocalizedFormats("covariance matrix"); /* keep */
        public static readonly LocalizedFormats DENOMINATOR = new LocalizedFormats("denominator"); /* keep */
        public static readonly LocalizedFormats DENOMINATOR_FORMAT = new LocalizedFormats("denominator format"); /* keep */
        public static readonly LocalizedFormats FRACTION = new LocalizedFormats("fraction"); /* keep */
        public static readonly LocalizedFormats FUNCTION = new LocalizedFormats("function"); /* keep */
        public static readonly LocalizedFormats IMAGINARY_FORMAT = new LocalizedFormats("imaginary format"); /* keep */
        public static readonly LocalizedFormats INPUT_ARRAY = new LocalizedFormats("input array"); /* keep */
        public static readonly LocalizedFormats NUMERATOR = new LocalizedFormats("numerator"); /* keep */
        public static readonly LocalizedFormats NUMERATOR_FORMAT = new LocalizedFormats("numerator format"); /* keep */
        public static readonly LocalizedFormats OBJECT_TRANSFORMATION = new LocalizedFormats("conversion exception in transformation"); /* keep */
        public static readonly LocalizedFormats REAL_FORMAT = new LocalizedFormats("real format"); /* keep */
        public static readonly LocalizedFormats WHOLE_FORMAT = new LocalizedFormats("whole format"); /* keep */
        public static readonly LocalizedFormats NUMBER_TOO_LARGE = new LocalizedFormats("{0} is larger than the maximum ({1})"); /* keep */
        public static readonly LocalizedFormats NUMBER_TOO_SMALL = new LocalizedFormats("{0} is smaller than the minimum ({1})"); /* keep */
        public static readonly LocalizedFormats NUMBER_TOO_LARGE_BOUND_EXCLUDED = new LocalizedFormats("{0} is larger than, or equal to, the maximum ({1})"); /* keep */
        public static readonly LocalizedFormats NUMBER_TOO_SMALL_BOUND_EXCLUDED = new LocalizedFormats("{0} is smaller than, or equal to, the minimum ({1})"); /* keep */
        public static readonly LocalizedFormats NUMBER_OF_SUCCESS_LARGER_THAN_POPULATION_SIZE = new LocalizedFormats("number of successes ({0}) must be less than or equal to population size ({1})");
        public static readonly LocalizedFormats NUMERATOR_OVERFLOW_AFTER_MULTIPLY = new LocalizedFormats("overflow, numerator too large after multiply: {0}");
        public static readonly LocalizedFormats N_POINTS_GAUSS_LEGENDRE_INTEGRATOR_NOT_SUPPORTED = new LocalizedFormats("{0} points Legendre-Gauss integrator not supported, number of points must be in the {1}-{2} range");
        public static readonly LocalizedFormats OBSERVED_COUNTS_ALL_ZERO = new LocalizedFormats("observed counts are all 0 in observed array {0}");
        public static readonly LocalizedFormats OBSERVED_COUNTS_BOTTH_ZERO_FOR_ENTRY = new LocalizedFormats("observed counts are both zero for entry {0}");
        public static readonly LocalizedFormats BOBYQA_BOUND_DIFFERENCE_CONDITION = new LocalizedFormats("the difference between the upper and lower bound must be larger than twice the initial trust region radius ({0})");
        public static readonly LocalizedFormats OUT_OF_BOUNDS_QUANTILE_VALUE = new LocalizedFormats("out of bounds quantile value: {0}, must be in (0, 100]");
        public static readonly LocalizedFormats OUT_OF_BOUND_SIGNIFICANCE_LEVEL = new LocalizedFormats("out of bounds significance level {0}, must be between {1} and {2}");
        public static readonly LocalizedFormats SIGNIFICANCE_LEVEL = new LocalizedFormats("significance level ({0})"); /* keep */
        public static readonly LocalizedFormats OUT_OF_ORDER_ABSCISSA_ARRAY = new LocalizedFormats("the abscissae array must be sorted in a strictly increasing order, but the {0}-th element is {1} whereas {2}-th is {3}");
        public static readonly LocalizedFormats OUT_OF_RANGE_ROOT_OF_UNITY_INDEX = new LocalizedFormats("out of range root of unity index {0} (must be in [{1};{2}])");
        public static readonly LocalizedFormats OUT_OF_RANGE = new LocalizedFormats("out of range"); /* keep */
        public static readonly LocalizedFormats OUT_OF_RANGE_SIMPLE = new LocalizedFormats("{0} out of [{1}, {2}] range"); /* keep */
        public static readonly LocalizedFormats OUT_OF_RANGE_LEFT = new LocalizedFormats("{0} out of ({1}, {2}] range");
        public static readonly LocalizedFormats OUT_OF_RANGE_RIGHT = new LocalizedFormats("{0} out of [{1}, {2}) range");
        public static readonly LocalizedFormats OUTLINE_BOUNDARY_LOOP_OPEN = new LocalizedFormats("an outline boundary loop is open");
        public static readonly LocalizedFormats OVERFLOW = new LocalizedFormats("overflow"); /* keep */
        public static readonly LocalizedFormats OVERFLOW_IN_FRACTION = new LocalizedFormats("overflow in fraction {0}/{1}, cannot negate");
        public static readonly LocalizedFormats OVERFLOW_IN_ADDITION = new LocalizedFormats("overflow in addition: {0} + {1}");
        public static readonly LocalizedFormats OVERFLOW_IN_SUBTRACTION = new LocalizedFormats("overflow in subtraction: {0} - {1}");
        public static readonly LocalizedFormats PERCENTILE_IMPLEMENTATION_CANNOT_ACCESS_METHOD = new LocalizedFormats("cannot access {0} method in percentile implementation {1}");
        public static readonly LocalizedFormats PERCENTILE_IMPLEMENTATION_UNSUPPORTED_METHOD = new LocalizedFormats("percentile implementation {0} does not support {1}");
        public static readonly LocalizedFormats PERMUTATION_EXCEEDS_N = new LocalizedFormats("permutation size ({0}) exceeds permuation domain ({1})"); /* keep */
        public static readonly LocalizedFormats POLYNOMIAL = new LocalizedFormats("polynomial"); /* keep */
        public static readonly LocalizedFormats POLYNOMIAL_INTERPOLANTS_MISMATCH_SEGMENTS = new LocalizedFormats("number of polynomial interpolants must match the number of segments ({0} != {1} - 1)");
        public static readonly LocalizedFormats POPULATION_LIMIT_NOT_POSITIVE = new LocalizedFormats("population limit has to be positive");
        public static readonly LocalizedFormats POSITION_SIZE_MISMATCH_INPUT_ARRAY = new LocalizedFormats("position {0} and size {1} don't fit to the size of the input array {2}");
        public static readonly LocalizedFormats POWER_NEGATIVE_PARAMETERS = new LocalizedFormats("cannot raise an integral value to a negative power ({0}^{1})");
        public static readonly LocalizedFormats PROPAGATION_DIRECTION_MISMATCH = new LocalizedFormats("propagation direction mismatch");
        public static readonly LocalizedFormats RANDOMKEY_MUTATION_WRONG_CLASS = new LocalizedFormats("RandomKeyMutation works only with RandomKeys, not {0}");
        public static readonly LocalizedFormats ROOTS_OF_UNITY_NOT_COMPUTED_YET = new LocalizedFormats("roots of unity have not been computed yet");
        public static readonly LocalizedFormats ROTATION_MATRIX_DIMENSIONS = new LocalizedFormats("a {0}x{1} matrix cannot be a rotation matrix");
        public static readonly LocalizedFormats ROW_INDEX_OUT_OF_RANGE = new LocalizedFormats("row index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormats ROW_INDEX = new LocalizedFormats("row index ({0})"); /* keep */
        public static readonly LocalizedFormats SAME_SIGN_AT_ENDPOINTS = new LocalizedFormats("function values at endpoints do not have different signs, endpoints: [{0}, {1}], values: [{2}, {3}]");
        public static readonly LocalizedFormats SAMPLE_SIZE_EXCEEDS_COLLECTION_SIZE = new LocalizedFormats("sample size ({0}) exceeds collection size ({1})"); /* keep */
        public static readonly LocalizedFormats SAMPLE_SIZE_LARGER_THAN_POPULATION_SIZE = new LocalizedFormats("sample size ({0}) must be less than or equal to population size ({1})");
        public static readonly LocalizedFormats SIMPLEX_NEED_ONE_POINT = new LocalizedFormats("simplex must contain at least one point");
        public static readonly LocalizedFormats SIMPLE_MESSAGE = new LocalizedFormats("{0}");
        public static readonly LocalizedFormats SINGULAR_MATRIX = new LocalizedFormats("matrix is singular"); /* keep */
        public static readonly LocalizedFormats SINGULAR_OPERATOR = new LocalizedFormats("operator is singular");
        public static readonly LocalizedFormats SUBARRAY_ENDS_AFTER_ARRAY_END = new LocalizedFormats("subarray ends after array end");
        public static readonly LocalizedFormats TOO_LARGE_CUTOFF_SINGULAR_VALUE = new LocalizedFormats("cutoff singular value is {0}, should be at most {1}");
        public static readonly LocalizedFormats TOO_MANY_ELEMENTS_TO_DISCARD_FROM_ARRAY = new LocalizedFormats("cannot discard {0} elements from a {1} elements array");
        public static readonly LocalizedFormats TOO_MUCH_CANCELLATION = new LocalizedFormats("too much cancellation in a denominator");
        public static readonly LocalizedFormats TOO_MANY_REGRESSORS = new LocalizedFormats("too many regressors ({0}) specified, only {1} in the model");
        public static readonly LocalizedFormats TOO_SMALL_COST_RELATIVE_TOLERANCE = new LocalizedFormats("cost relative tolerance is too small ({0}), no further reduction in the sum of squares is possible");
        public static readonly LocalizedFormats TOO_SMALL_INTEGRATION_INTERVAL = new LocalizedFormats("too small integration interval: length = {0}");
        public static readonly LocalizedFormats TOO_SMALL_ORTHOGONALITY_TOLERANCE = new LocalizedFormats("orthogonality tolerance is too small ({0}), solution is orthogonal to the jacobian");
        public static readonly LocalizedFormats TOO_SMALL_PARAMETERS_RELATIVE_TOLERANCE = new LocalizedFormats("parameters relative tolerance is too small ({0}), no further improvement in the approximate solution is possible");
        public static readonly LocalizedFormats TRUST_REGION_STEP_FAILED = new LocalizedFormats("trust region step has failed to reduce Q");
        public static readonly LocalizedFormats TWO_OR_MORE_CATEGORIES_REQUIRED = new LocalizedFormats("two or more categories required, got {0}");
        public static readonly LocalizedFormats TWO_OR_MORE_VALUES_IN_CATEGORY_REQUIRED = new LocalizedFormats("two or more values required in each category, one has {0}");
        public static readonly LocalizedFormats UNABLE_TO_BRACKET_OPTIMUM_IN_LINE_SEARCH = new LocalizedFormats("unable to bracket optimum in line search");
        public static readonly LocalizedFormats UNABLE_TO_COMPUTE_COVARIANCE_SINGULAR_PROBLEM = new LocalizedFormats("unable to compute covariances: singular problem");
        public static readonly LocalizedFormats UNABLE_TO_FIRST_GUESS_HARMONIC_COEFFICIENTS = new LocalizedFormats("unable to first guess the harmonic coefficients");
        public static readonly LocalizedFormats UNABLE_TO_ORTHOGONOLIZE_MATRIX = new LocalizedFormats("unable to orthogonalize matrix in {0} iterations");
        public static readonly LocalizedFormats UNABLE_TO_PERFORM_QR_DECOMPOSITION_ON_JACOBIAN = new LocalizedFormats("unable to perform Q.R decomposition on the {0}x{1} jacobian matrix");
        public static readonly LocalizedFormats UNABLE_TO_SOLVE_SINGULAR_PROBLEM = new LocalizedFormats("unable to solve: singular problem");
        public static readonly LocalizedFormats UNBOUNDED_SOLUTION = new LocalizedFormats("unbounded solution");
        public static readonly LocalizedFormats UNKNOWN_MODE = new LocalizedFormats("unknown mode {0}, known modes: {1} ({2}), {3} ({4}), {5} ({6}), {7} ({8}), {9} ({10}) and {11} ({12})");
        public static readonly LocalizedFormats UNKNOWN_PARAMETER = new LocalizedFormats("unknown parameter {0}");
        public static readonly LocalizedFormats UNMATCHED_ODE_IN_EXPANDED_SET = new LocalizedFormats("ode does not match the main ode set in the extended set");
        public static readonly LocalizedFormats CANNOT_PARSE_AS_TYPE = new LocalizedFormats("string \"{0}\" unparseable (from position {1}) as an object of type {2}"); /* keep */
        public static readonly LocalizedFormats CANNOT_PARSE = new LocalizedFormats("string \"{0}\" unparseable (from position {1})"); /* keep */
        public static readonly LocalizedFormats UNPARSEABLE_3D_VECTOR = new LocalizedFormats("unparseable 3D vector: \"{0}\"");
        public static readonly LocalizedFormats UNPARSEABLE_COMPLEX_NUMBER = new LocalizedFormats("unparseable complex number: \"{0}\"");
        public static readonly LocalizedFormats UNPARSEABLE_REAL_VECTOR = new LocalizedFormats("unparseable real vector: \"{0}\"");
        public static readonly LocalizedFormats UNSUPPORTED_EXPANSION_MODE = new LocalizedFormats("unsupported expansion mode {0}, supported modes are {1} ({2}) and {3} ({4})");
        public static readonly LocalizedFormats UNSUPPORTED_OPERATION = new LocalizedFormats("unsupported operation"); /* keep */
        public static readonly LocalizedFormats ARITHMETIC_EXCEPTION = new LocalizedFormats("arithmetic exception"); /* keep */
        public static readonly LocalizedFormats ILLEGAL_STATE = new LocalizedFormats("illegal state"); /* keep */
        public static readonly LocalizedFormats USER_EXCEPTION = new LocalizedFormats("exception generated in user code"); /* keep */
        public static readonly LocalizedFormats URL_CONTAINS_NO_DATA = new LocalizedFormats("URL {0} contains no data");
        public static readonly LocalizedFormats VALUES_ADDED_BEFORE_CONFIGURING_STATISTIC = new LocalizedFormats("{0} values have been added before statistic is configured");
        public static readonly LocalizedFormats VECTOR_LENGTH_MISMATCH = new LocalizedFormats("vector length mismatch: got {0} but expected {1}");
        public static readonly LocalizedFormats VECTOR_MUST_HAVE_AT_LEAST_ONE_ELEMENT = new LocalizedFormats("vector must have at least one element");
        public static readonly LocalizedFormats WEIGHT_AT_LEAST_ONE_NON_ZERO = new LocalizedFormats("weigth array must contain at least one non-zero value");
        public static readonly LocalizedFormats WRONG_BLOCK_LENGTH = new LocalizedFormats("wrong array shape (block length = {0}, expected {1})");
        public static readonly LocalizedFormats WRONG_NUMBER_OF_POINTS = new LocalizedFormats("{0} points are required, got only {1}");
        public static readonly LocalizedFormats NUMBER_OF_POINTS = new LocalizedFormats("number of points ({0})"); /* keep */
        public static readonly LocalizedFormats ZERO_DENOMINATOR = new LocalizedFormats("denominator must be different from 0");
        public static readonly LocalizedFormats ZERO_DENOMINATOR_IN_FRACTION = new LocalizedFormats("zero denominator in fraction {0}/{1}");
        public static readonly LocalizedFormats ZERO_FRACTION_TO_DIVIDE_BY = new LocalizedFormats("the fraction to divide by must not be zero: {0}/{1}");
        public static readonly LocalizedFormats ZERO_NORM = new LocalizedFormats("zero norm");
        public static readonly LocalizedFormats ZERO_NORM_FOR_ROTATION_AXIS = new LocalizedFormats("zero norm for rotation axis");
        public static readonly LocalizedFormats ZERO_NORM_FOR_ROTATION_DEFINING_VECTOR = new LocalizedFormats("zero norm for rotation defining vector");
        public static readonly LocalizedFormats ZERO_NOT_ALLOWED = new LocalizedFormats("zero not allowed here");

        /// <summary>
        /// Source english format.
        /// </summary>
        private readonly string sourceFormat;

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="sourceFormat">The english format to use when no localized version is available.</param>
        private LocalizedFormats(string sourceFormat)
        {
            this.sourceFormat = sourceFormat;
        }

        public string SourceString
        {
            get { return sourceFormat; }
        }

        public string GetLocalizedString(System.Globalization.CultureInfo cultureInfo)
        {
            return LocalizedFormatsBuilder.ResourceManager.GetString(sourceFormat, cultureInfo);
        }
    }
}
