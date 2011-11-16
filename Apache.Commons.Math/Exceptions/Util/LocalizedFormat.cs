using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apache.Commons.Math.Exceptions.Util
{
    public class LocalizedFormat: ILocalizable
    {
        public static readonly LocalizedFormat ARGUMENT_OUTSIDE_DOMAIN = new LocalizedFormat("Argument {0} outside domain [{1} ; {2}]");
        public static readonly LocalizedFormat ARRAY_SIZE_EXCEEDS_MAX_VARIABLES = new LocalizedFormat("array size cannot be greater than {0}");
        public static readonly LocalizedFormat ARRAY_SIZES_SHOULD_HAVE_DIFFERENCE_1 = new LocalizedFormat("array sizes should have difference 1 ({0} != {1} + 1)");
        public static readonly LocalizedFormat ARRAY_SUMS_TO_ZERO = new LocalizedFormat("array sums to zero");
        public static readonly LocalizedFormat ASSYMETRIC_EIGEN_NOT_SUPPORTED = new LocalizedFormat("eigen decomposition of assymetric matrices not supported yet");
        public static readonly LocalizedFormat AT_LEAST_ONE_COLUMN = new LocalizedFormat("matrix must have at least one column");
        public static readonly LocalizedFormat AT_LEAST_ONE_ROW = new LocalizedFormat("matrix must have at least one row");
        public static readonly LocalizedFormat BANDWIDTH = new LocalizedFormat("bandwidth ({0})");
        public static readonly LocalizedFormat BINOMIAL_INVALID_PARAMETERS_ORDER = new LocalizedFormat("must have n >= k for binomial coefficient (n, k), got k = {0}, n = {1}");
        public static readonly LocalizedFormat BINOMIAL_NEGATIVE_PARAMETER = new LocalizedFormat("must have n >= 0 for binomial coefficient (n, k), got n = {0}");
        public static readonly LocalizedFormat CANNOT_CLEAR_STATISTIC_CONSTRUCTED_FROM_EXTERNAL_MOMENTS = new LocalizedFormat("statistics constructed from external moments cannot be cleared");
        public static readonly LocalizedFormat CANNOT_COMPUTE_0TH_ROOT_OF_UNITY = new LocalizedFormat("cannot compute 0-th root of unity, indefinite result");
        public static readonly LocalizedFormat CANNOT_COMPUTE_BETA_DENSITY_AT_0_FOR_SOME_ALPHA = new LocalizedFormat("cannot compute beta density at 0 when alpha = {0,number}");
        public static readonly LocalizedFormat CANNOT_COMPUTE_BETA_DENSITY_AT_1_FOR_SOME_BETA = new LocalizedFormat("cannot compute beta density at 1 when beta = %.3g");
        public static readonly LocalizedFormat CANNOT_COMPUTE_NTH_ROOT_FOR_NEGATIVE_N = new LocalizedFormat("cannot compute nth root for null or negative n: {0}");
        public static readonly LocalizedFormat CANNOT_DISCARD_NEGATIVE_NUMBER_OF_ELEMENTS = new LocalizedFormat("cannot discard a negative number of elements ({0})");
        public static readonly LocalizedFormat CANNOT_FORMAT_INSTANCE_AS_3D_VECTOR = new LocalizedFormat("cannot format a {0} instance as a 3D vector");
        public static readonly LocalizedFormat CANNOT_FORMAT_INSTANCE_AS_COMPLEX = new LocalizedFormat("cannot format a {0} instance as a complex number");
        public static readonly LocalizedFormat CANNOT_FORMAT_INSTANCE_AS_REAL_VECTOR = new LocalizedFormat("cannot format a {0} instance as a real vector");
        public static readonly LocalizedFormat CANNOT_FORMAT_OBJECT_TO_FRACTION = new LocalizedFormat("cannot format given object as a fraction number");
        public static readonly LocalizedFormat CANNOT_INCREMENT_STATISTIC_CONSTRUCTED_FROM_EXTERNAL_MOMENTS = new LocalizedFormat("statistics constructed from external moments cannot be incremented");
        public static readonly LocalizedFormat CANNOT_NORMALIZE_A_ZERO_NORM_VECTOR = new LocalizedFormat("cannot normalize a zero norm vector");
        public static readonly LocalizedFormat CANNOT_RETRIEVE_AT_NEGATIVE_INDEX = new LocalizedFormat("elements cannot be retrieved from a negative array index {0}");
        public static readonly LocalizedFormat CANNOT_SET_AT_NEGATIVE_INDEX = new LocalizedFormat("cannot set an element at a negative index {0}");
        public static readonly LocalizedFormat CANNOT_SUBSTITUTE_ELEMENT_FROM_EMPTY_ARRAY = new LocalizedFormat("cannot substitute an element from an empty array");
        public static readonly LocalizedFormat CANNOT_TRANSFORM_TO_DOUBLE = new LocalizedFormat("Conversion Exception in Transformation: {0}");
        public static readonly LocalizedFormat CARDAN_ANGLES_SINGULARITY = new LocalizedFormat("Cardan angles singularity");
        public static readonly LocalizedFormat CLASS_DOESNT_IMPLEMENT_COMPARABLE = new LocalizedFormat("class ({0}) does not implement Comparable");
        public static readonly LocalizedFormat CLOSEST_ORTHOGONAL_MATRIX_HAS_NEGATIVE_DETERMINANT = new LocalizedFormat("the closest orthogonal matrix has a negative determinant {0}");
        public static readonly LocalizedFormat COLUMN_INDEX_OUT_OF_RANGE = new LocalizedFormat("column index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormat COLUMN_INDEX = new LocalizedFormat("column index ({0})"); /* keep */
        public static readonly LocalizedFormat CONTINUED_FRACTION_INFINITY_DIVERGENCE = new LocalizedFormat("Continued fraction convergents diverged to +/- infinity for value {0}");
        public static readonly LocalizedFormat CONTINUED_FRACTION_NAN_DIVERGENCE = new LocalizedFormat("Continued fraction diverged to NaN for value {0}");
        public static readonly LocalizedFormat CONTRACTION_CRITERIA_SMALLER_THAN_EXPANSION_FACTOR = new LocalizedFormat("contraction criteria ({0}) smaller than the expansion factor ({1}).  This would lead to a never ending loop of expansion and contraction as a newly expanded internal storage array would immediately satisfy the criteria for contraction.");
        public static readonly LocalizedFormat CONTRACTION_CRITERIA_SMALLER_THAN_ONE = new LocalizedFormat("contraction criteria smaller than one ({0}).  This would lead to a never ending loop of expansion and contraction as an internal storage array length equal to the number of elements would satisfy the contraction criteria.");
        public static readonly LocalizedFormat CONVERGENCE_FAILED = new LocalizedFormat("convergence failed"); /* keep */
        public static readonly LocalizedFormat CROSSING_BOUNDARY_LOOPS = new LocalizedFormat("some outline boundary loops cross each other");
        public static readonly LocalizedFormat CUMULATIVE_PROBABILITY_RETURNED_NAN = new LocalizedFormat("Cumulative probability function returned NaN for argument {0} p = {1}");
        public static readonly LocalizedFormat DIFFERENT_ROWS_LENGTHS = new LocalizedFormat("some rows have length {0} while others have length {1}");
        public static readonly LocalizedFormat DIGEST_NOT_INITIALIZED = new LocalizedFormat("digest not initialized");
        public static readonly LocalizedFormat DIMENSIONS_MISMATCH_2x2 = new LocalizedFormat("got {0}x{1} but expected {2}x{3}"); /* keep */
        public static readonly LocalizedFormat DIMENSIONS_MISMATCH_SIMPLE = new LocalizedFormat("{0} != {1}"); /* keep */
        public static readonly LocalizedFormat DIMENSIONS_MISMATCH = new LocalizedFormat("dimensions mismatch"); /* keep */
        public static readonly LocalizedFormat DISCRETE_CUMULATIVE_PROBABILITY_RETURNED_NAN = new LocalizedFormat("Discrete cumulative probability function returned NaN for argument {0}");
        public static readonly LocalizedFormat DISTRIBUTION_NOT_LOADED = new LocalizedFormat("distribution not loaded");
        public static readonly LocalizedFormat DUPLICATED_ABSCISSA = new LocalizedFormat("Abscissa {0} is duplicated at both indices {1} and {2}");
        public static readonly LocalizedFormat EMPTY_CLUSTER_IN_K_MEANS = new LocalizedFormat("empty cluster in k-means");
        public static readonly LocalizedFormat EMPTY_POLYNOMIALS_COEFFICIENTS_ARRAY = new LocalizedFormat("empty polynomials coefficients array"); /* keep */
        public static readonly LocalizedFormat EMPTY_SELECTED_COLUMN_INDEX_ARRAY = new LocalizedFormat("empty selected column index array");
        public static readonly LocalizedFormat EMPTY_SELECTED_ROW_INDEX_ARRAY = new LocalizedFormat("empty selected row index array");
        public static readonly LocalizedFormat EMPTY_STRING_FOR_IMAGINARY_CHARACTER = new LocalizedFormat("empty string for imaginary character");
        public static readonly LocalizedFormat ENDPOINTS_NOT_AN_INTERVAL = new LocalizedFormat("endpoints do not specify an interval: [{0}, {1}]");
        public static readonly LocalizedFormat EQUAL_VERTICES_IN_SIMPLEX = new LocalizedFormat("equal vertices {0} and {1} in simplex configuration");
        public static readonly LocalizedFormat EULER_ANGLES_SINGULARITY = new LocalizedFormat("Euler angles singularity");
        public static readonly LocalizedFormat EVALUATION = new LocalizedFormat("evaluation"); /* keep */
        public static readonly LocalizedFormat EXPANSION_FACTOR_SMALLER_THAN_ONE = new LocalizedFormat("expansion factor smaller than one ({0})");
        public static readonly LocalizedFormat FACTORIAL_NEGATIVE_PARAMETER = new LocalizedFormat("must have n >= 0 for n!, got n = {0}");
        public static readonly LocalizedFormat FAILED_BRACKETING = new LocalizedFormat("number of iterations={4}, maximum iterations={5}, initial={6}, lower bound={7}, upper bound={8}, final a value={0}, final b value={1}, f(a)={2}, f(b)={3}");
        public static readonly LocalizedFormat FAILED_FRACTION_CONVERSION = new LocalizedFormat("Unable to convert {0} to fraction after {1} iterations");
        public static readonly LocalizedFormat FIRST_COLUMNS_NOT_INITIALIZED_YET = new LocalizedFormat("first {0} columns are not initialized yet");
        public static readonly LocalizedFormat FIRST_ELEMENT_NOT_ZERO = new LocalizedFormat("first element is not 0: {0}");
        public static readonly LocalizedFormat FIRST_ROWS_NOT_INITIALIZED_YET = new LocalizedFormat("first {0} rows are not initialized yet");
        public static readonly LocalizedFormat FRACTION_CONVERSION_OVERFLOW = new LocalizedFormat("Overflow trying to convert {0} to fraction ({1}/{2})");
        public static readonly LocalizedFormat FUNCTION_NOT_DIFFERENTIABLE = new LocalizedFormat("function is not differentiable");
        public static readonly LocalizedFormat FUNCTION_NOT_POLYNOMIAL = new LocalizedFormat("function is not polynomial");
        public static readonly LocalizedFormat GCD_OVERFLOW_32_BITS = new LocalizedFormat("overflow: gcd({0}, {1}) is 2^31");
        public static readonly LocalizedFormat GCD_OVERFLOW_64_BITS = new LocalizedFormat("overflow: gcd({0}, {1}) is 2^63");
        public static readonly LocalizedFormat HOLE_BETWEEN_MODELS_TIME_RANGES = new LocalizedFormat("{0} wide hole between models time ranges");
        public static readonly LocalizedFormat IDENTICAL_ABSCISSAS_DIVISION_BY_ZERO = new LocalizedFormat("identical abscissas x[{0}] == x[{1}] == {2} cause division by zero");
        public static readonly LocalizedFormat ILL_CONDITIONED_OPERATOR = new LocalizedFormat("condition number {1} is too high ");
        public static readonly LocalizedFormat INDEX_LARGER_THAN_MAX = new LocalizedFormat("the index specified: {0} is larger than the current maximal index {1}");
        public static readonly LocalizedFormat INDEX_NOT_POSITIVE = new LocalizedFormat("index ({0}) is not positive");
        public static readonly LocalizedFormat INDEX_OUT_OF_RANGE = new LocalizedFormat("index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormat INDEX = new LocalizedFormat("index ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_FINITE_NUMBER = new LocalizedFormat("{0} is not a finite number"); /* keep */
        public static readonly LocalizedFormat ARRAY_ELEMENT = new LocalizedFormat("value {0} at index {1}"); /* keep */
        public static readonly LocalizedFormat INFINITE_ARRAY_ELEMENT = new LocalizedFormat("Array contains an infinite element, {0} at index {1}");
        public static readonly LocalizedFormat INFINITE_VALUE_CONVERSION = new LocalizedFormat("cannot convert infinite value");
        public static readonly LocalizedFormat INITIAL_CAPACITY_NOT_POSITIVE = new LocalizedFormat("initial capacity ({0}) is not positive");
        public static readonly LocalizedFormat INITIAL_COLUMN_AFTER_FINAL_COLUMN = new LocalizedFormat("initial column {1} after final column {0}");
        public static readonly LocalizedFormat INITIAL_ROW_AFTER_FINAL_ROW = new LocalizedFormat("initial row {1} after final row {0}");
        public static readonly LocalizedFormat INPUT_DATA_FROM_UNSUPPORTED_DATASOURCE = new LocalizedFormat("input data comes from unsupported datasource: {0}, supported sources: {1}, {2}");
        public static readonly LocalizedFormat INSTANCES_NOT_COMPARABLE_TO_EXISTING_VALUES = new LocalizedFormat("instance of class {0} not comparable to existing values");
        public static readonly LocalizedFormat INSUFFICIENT_DATA_FOR_T_STATISTIC = new LocalizedFormat("insufficient data for t statistic, needs at least 2, got {0}");
        public static readonly LocalizedFormat INSUFFICIENT_DIMENSION = new LocalizedFormat("insufficient dimension {0}, must be at least {1}");
        public static readonly LocalizedFormat DIMENSION = new LocalizedFormat("dimension ({0})"); /* keep */
        public static readonly LocalizedFormat INSUFFICIENT_OBSERVED_POINTS_IN_SAMPLE = new LocalizedFormat("sample contains {0} observed points, at least {1} are required");
        public static readonly LocalizedFormat INSUFFICIENT_ROWS_AND_COLUMNS = new LocalizedFormat("insufficient data: only {0} rows and {1} columns.");
        public static readonly LocalizedFormat INTEGRATION_METHOD_NEEDS_AT_LEAST_TWO_PREVIOUS_POINTS = new LocalizedFormat("{0} method needs at least two previous points");
        public static readonly LocalizedFormat INTERNAL_ERROR = new LocalizedFormat("internal error, please fill a bug report at {0}");
        public static readonly LocalizedFormat INVALID_BINARY_DIGIT = new LocalizedFormat("invalid binary digit: {0}");
        public static readonly LocalizedFormat INVALID_BRACKETING_PARAMETERS = new LocalizedFormat("invalid bracketing parameters:  lower bound={0},  initial={1}, upper bound={2}");
        public static readonly LocalizedFormat INVALID_INTERVAL_INITIAL_VALUE_PARAMETERS = new LocalizedFormat("invalid interval, initial value parameters:  lower={0}, initial={1}, upper={2}");
        public static readonly LocalizedFormat INVALID_ITERATIONS_LIMITS = new LocalizedFormat("invalid iteration limits: min={0}, max={1}");
        public static readonly LocalizedFormat INVALID_MAX_ITERATIONS = new LocalizedFormat("bad value for maximum iterations number: {0}");
        public static readonly LocalizedFormat NOT_ENOUGH_DATA_REGRESSION = new LocalizedFormat("the number of observations is not sufficient to conduct regression");
        public static readonly LocalizedFormat INVALID_REGRESSION_ARRAY = new LocalizedFormat("input data array length = {0} does not match the number of observations = {1} and the number of regressors = {2}");
        public static readonly LocalizedFormat INVALID_REGRESSION_OBSERVATION = new LocalizedFormat("length of regressor array = {0} does not match the number of variables = {1} in the model");
        public static readonly LocalizedFormat INVALID_ROUNDING_METHOD = new LocalizedFormat("invalid rounding method {0}, valid methods: {1} ({2}), {3} ({4}), {5} ({6}), {7} ({8}), {9} ({10}), {11} ({12}), {13} ({14}), {15} ({16})");
        public static readonly LocalizedFormat ITERATOR_EXHAUSTED = new LocalizedFormat("iterator exhausted");
        public static readonly LocalizedFormat LCM_OVERFLOW_32_BITS = new LocalizedFormat("overflow: lcm({0}, {1}) is 2^31");
        public static readonly LocalizedFormat LCM_OVERFLOW_64_BITS = new LocalizedFormat("overflow: lcm({0}, {1}) is 2^63");
        public static readonly LocalizedFormat LIST_OF_CHROMOSOMES_BIGGER_THAN_POPULATION_SIZE = new LocalizedFormat("list of chromosomes bigger than maxPopulationSize");
        public static readonly LocalizedFormat LOESS_EXPECTS_AT_LEAST_ONE_POINT = new LocalizedFormat("Loess expects at least 1 point");
        public static readonly LocalizedFormat LOWER_BOUND_NOT_BELOW_UPPER_BOUND = new LocalizedFormat("lower bound ({0}) must be strictly less than upper bound ({1})"); /* keep */
        public static readonly LocalizedFormat LOWER_ENDPOINT_ABOVE_UPPER_ENDPOINT = new LocalizedFormat("lower endpoint ({0}) must be less than or equal to upper endpoint ({1})");
        public static readonly LocalizedFormat MAP_MODIFIED_WHILE_ITERATING = new LocalizedFormat("map has been modified while iterating");
        public static readonly LocalizedFormat EVALUATIONS = new LocalizedFormat("evaluations"); /* keep */
        public static readonly LocalizedFormat MAX_COUNT_EXCEEDED = new LocalizedFormat("maximal count ({0}) exceeded"); /* keep */
        public static readonly LocalizedFormat MAX_ITERATIONS_EXCEEDED = new LocalizedFormat("maximal number of iterations ({0}) exceeded");
        public static readonly LocalizedFormat MINIMAL_STEPSIZE_REACHED_DURING_INTEGRATION = new LocalizedFormat("minimal step size ({1,number,0.00E00}) reached, integration needs {0,number,0.00E00}");
        public static readonly LocalizedFormat MISMATCHED_LOESS_ABSCISSA_ORDINATE_ARRAYS = new LocalizedFormat("Loess expects the abscissa and ordinate arrays to be of the same size, but got {0} abscissae and {1} ordinatae");
        public static readonly LocalizedFormat NAN_ELEMENT_AT_INDEX = new LocalizedFormat("element {0} is NaN");
        public static readonly LocalizedFormat NAN_VALUE_CONVERSION = new LocalizedFormat("cannot convert NaN value");
        public static readonly LocalizedFormat NEGATIVE_BRIGHTNESS_EXPONENT = new LocalizedFormat("brightness exponent should be positive or null, but got {0}");
        public static readonly LocalizedFormat NEGATIVE_COMPLEX_MODULE = new LocalizedFormat("negative complex module {0}");
        public static readonly LocalizedFormat NEGATIVE_ELEMENT_AT_2D_INDEX = new LocalizedFormat("element ({0}, {1}) is negative: {2}");
        public static readonly LocalizedFormat NEGATIVE_ELEMENT_AT_INDEX = new LocalizedFormat("element {0} is negative: {1}");
        public static readonly LocalizedFormat NEGATIVE_NUMBER_OF_SUCCESSES = new LocalizedFormat("number of successes must be non-negative ({0})");
        public static readonly LocalizedFormat NUMBER_OF_SUCCESSES = new LocalizedFormat("number of successes ({0})"); /* keep */
        public static readonly LocalizedFormat NEGATIVE_NUMBER_OF_TRIALS = new LocalizedFormat("number of trials must be non-negative ({0})");
        public static readonly LocalizedFormat NUMBER_OF_INTERPOLATION_POINTS = new LocalizedFormat("number of interpolation points ({0})"); /* keep */
        public static readonly LocalizedFormat NUMBER_OF_TRIALS = new LocalizedFormat("number of trials ({0})");
        public static readonly LocalizedFormat ROBUSTNESS_ITERATIONS = new LocalizedFormat("number of robustness iterations ({0})");
        public static readonly LocalizedFormat START_POSITION = new LocalizedFormat("start position ({0})"); /* keep */
        public static readonly LocalizedFormat NON_CONVERGENT_CONTINUED_FRACTION = new LocalizedFormat("Continued fraction convergents failed to converge (in less than {0} iterations) for value {1}");
        public static readonly LocalizedFormat NON_INVERTIBLE_TRANSFORM = new LocalizedFormat("non-invertible affine transform collapses some lines into single points");
        public static readonly LocalizedFormat NON_POSITIVE_MICROSPHERE_ELEMENTS = new LocalizedFormat("number of microsphere elements must be positive, but got {0}");
        public static readonly LocalizedFormat NON_POSITIVE_POLYNOMIAL_DEGREE = new LocalizedFormat("polynomial degree must be positive: degree={0}");
        public static readonly LocalizedFormat NON_REAL_FINITE_ABSCISSA = new LocalizedFormat("all abscissae must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormat NON_REAL_FINITE_ORDINATE = new LocalizedFormat("all ordinatae must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormat NON_REAL_FINITE_WEIGHT = new LocalizedFormat("all weights must be finite real numbers, but {0}-th is {1}");
        public static readonly LocalizedFormat NON_SQUARE_MATRIX = new LocalizedFormat("non square ({0}x{1}) matrix");
        public static readonly LocalizedFormat NORMALIZE_INFINITE = new LocalizedFormat("Cannot normalize to an infinite value");
        public static readonly LocalizedFormat NORMALIZE_NAN = new LocalizedFormat("Cannot normalize to NaN");
        public static readonly LocalizedFormat NOT_ADDITION_COMPATIBLE_MATRICES = new LocalizedFormat("{0}x{1} and {2}x{3} matrices are not addition compatible");
        public static readonly LocalizedFormat NOT_DECREASING_NUMBER_OF_POINTS = new LocalizedFormat("points {0} and {1} are not decreasing ({2} < {3})");
        public static readonly LocalizedFormat NOT_DECREASING_SEQUENCE = new LocalizedFormat("points {3} and {2} are not decreasing ({1} < {0})"); /* keep */
        public static readonly LocalizedFormat NOT_ENOUGH_DATA_FOR_NUMBER_OF_PREDICTORS = new LocalizedFormat("not enough data ({0} rows) for this many predictors ({1} predictors)");
        public static readonly LocalizedFormat NOT_ENOUGH_POINTS_IN_SPLINE_PARTITION = new LocalizedFormat("spline partition must have at least {0} points, got {1}");
        public static readonly LocalizedFormat NOT_INCREASING_NUMBER_OF_POINTS = new LocalizedFormat("points {0} and {1} are not increasing ({2} > {3})");
        public static readonly LocalizedFormat NOT_INCREASING_SEQUENCE = new LocalizedFormat("points {3} and {2} are not increasing ({1} > {0})"); /* keep */
        public static readonly LocalizedFormat NOT_MULTIPLICATION_COMPATIBLE_MATRICES = new LocalizedFormat("{0}x{1} and {2}x{3} matrices are not multiplication compatible");
        public static readonly LocalizedFormat ALPHA = new LocalizedFormat("alpha"); /* keep */
        public static readonly LocalizedFormat BETA = new LocalizedFormat("beta"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_COLUMNDIMENSION = new LocalizedFormat("invalid column dimension: {0} (must be positive)");
        public static readonly LocalizedFormat NOT_POSITIVE_DEFINITE_MATRIX = new LocalizedFormat("not positive definite matrix"); /* keep */
        public static readonly LocalizedFormat NON_POSITIVE_DEFINITE_MATRIX = new LocalizedFormat("not positive definite matrix: diagonal element at ({1},{1}) is smaller than {2} ({0})");
        public static readonly LocalizedFormat NON_POSITIVE_DEFINITE_OPERATOR = new LocalizedFormat("non positive definite linear operator"); /* keep */
        public static readonly LocalizedFormat NON_SELF_ADJOINT_OPERATOR = new LocalizedFormat("non self-adjoint linear operator"); /* keep */
        public static readonly LocalizedFormat NON_SQUARE_OPERATOR = new LocalizedFormat("non square ({0}x{1}) linear operator"); /* keep */
        public static readonly LocalizedFormat DEGREES_OF_FREEDOM = new LocalizedFormat("degrees of freedom ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_DEGREES_OF_FREEDOM = new LocalizedFormat("degrees of freedom must be positive ({0})");
        public static readonly LocalizedFormat NOT_POSITIVE_ELEMENT_AT_INDEX = new LocalizedFormat("element {0} is not positive: {1}");
        public static readonly LocalizedFormat NOT_POSITIVE_EXPONENT = new LocalizedFormat("invalid exponent {0} (must be positive)");
        public static readonly LocalizedFormat EXPONENT = new LocalizedFormat("exponent ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_LENGTH = new LocalizedFormat("length must be positive ({0})");
        public static readonly LocalizedFormat LENGTH = new LocalizedFormat("length ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_MEAN = new LocalizedFormat("mean must be positive ({0})");
        public static readonly LocalizedFormat MEAN = new LocalizedFormat("mean ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_NUMBER_OF_SAMPLES = new LocalizedFormat("number of sample is not positive: {0}");
        public static readonly LocalizedFormat NUMBER_OF_SAMPLES = new LocalizedFormat("number of samples ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_PERMUTATION = new LocalizedFormat("permutation k ({0}) must be positive");
        public static readonly LocalizedFormat PERMUTATION_SIZE = new LocalizedFormat("permutation size ({0}"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_POISSON_MEAN = new LocalizedFormat("the Poisson mean must be positive ({0})");
        public static readonly LocalizedFormat NOT_POSITIVE_POPULATION_SIZE = new LocalizedFormat("population size must be positive ({0})");
        public static readonly LocalizedFormat POPULATION_SIZE = new LocalizedFormat("population size ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_ROW_DIMENSION = new LocalizedFormat("invalid row dimension: {0} (must be positive)");
        public static readonly LocalizedFormat NOT_POSITIVE_SAMPLE_SIZE = new LocalizedFormat("sample size must be positive ({0})");
        public static readonly LocalizedFormat NOT_POSITIVE_SCALE = new LocalizedFormat("scale must be positive ({0})");
        public static readonly LocalizedFormat SCALE = new LocalizedFormat("scale ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_SHAPE = new LocalizedFormat("shape must be positive ({0})");
        public static readonly LocalizedFormat SHAPE = new LocalizedFormat("shape ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_STANDARD_DEVIATION = new LocalizedFormat("standard deviation must be positive ({0})");
        public static readonly LocalizedFormat STANDARD_DEVIATION = new LocalizedFormat("standard deviation ({0})"); /* keep */
        public static readonly LocalizedFormat NOT_POSITIVE_UPPER_BOUND = new LocalizedFormat("upper bound must be positive ({0})");
        public static readonly LocalizedFormat NOT_POSITIVE_WINDOW_SIZE = new LocalizedFormat("window size must be positive ({0})");
        public static readonly LocalizedFormat NOT_POWER_OF_TWO = new LocalizedFormat("{0} is not a power of 2");
        public static readonly LocalizedFormat NOT_POWER_OF_TWO_CONSIDER_PADDING = new LocalizedFormat("{0} is not a power of 2, consider padding for fix");
        public static readonly LocalizedFormat NOT_POWER_OF_TWO_PLUS_ONE = new LocalizedFormat("{0} is not a power of 2 plus one");
        public static readonly LocalizedFormat NOT_STRICTLY_DECREASING_NUMBER_OF_POINTS = new LocalizedFormat("points {0} and {1} are not strictly decreasing ({2} <= {3})");
        public static readonly LocalizedFormat NOT_STRICTLY_DECREASING_SEQUENCE = new LocalizedFormat("points {3} and {2} are not strictly decreasing ({1} <= {0})"); /* keep */
        public static readonly LocalizedFormat NOT_STRICTLY_INCREASING_KNOT_VALUES = new LocalizedFormat("knot values must be strictly increasing");
        public static readonly LocalizedFormat NOT_STRICTLY_INCREASING_NUMBER_OF_POINTS = new LocalizedFormat("points {0} and {1} are not strictly increasing ({2} >= {3})");
        public static readonly LocalizedFormat NOT_STRICTLY_INCREASING_SEQUENCE = new LocalizedFormat("points {3} and {2} are not strictly increasing ({1} >= {0})"); /* keep */
        public static readonly LocalizedFormat NOT_SUBTRACTION_COMPATIBLE_MATRICES = new LocalizedFormat("{0}x{1} and {2}x{3} matrices are not subtraction compatible");
        public static readonly LocalizedFormat NOT_SUPPORTED_IN_DIMENSION_N = new LocalizedFormat("method not supported in dimension {0}");
        public static readonly LocalizedFormat NOT_SYMMETRIC_MATRIX = new LocalizedFormat("not symmetric matrix");
        public static readonly LocalizedFormat NON_SYMMETRIC_MATRIX = new LocalizedFormat("non symmetric matrix: the difference between entries at ({0},{1}) and ({1},{0}) is larger than {2}"); /* keep */
        public static readonly LocalizedFormat NO_BIN_SELECTED = new LocalizedFormat("no bin selected");
        public static readonly LocalizedFormat NO_CONVERGENCE_WITH_ANY_START_POINT = new LocalizedFormat("none of the {0} start points lead to convergence"); /* keep */
        public static readonly LocalizedFormat NO_DATA = new LocalizedFormat("no data"); /* keep */
        public static readonly LocalizedFormat NO_DEGREES_OF_FREEDOM = new LocalizedFormat("no degrees of freedom ({0} measurements, {1} parameters)");
        public static readonly LocalizedFormat NO_DENSITY_FOR_THIS_DISTRIBUTION = new LocalizedFormat("This distribution does not have a density function implemented");
        public static readonly LocalizedFormat NO_FEASIBLE_SOLUTION = new LocalizedFormat("no feasible solution");
        public static readonly LocalizedFormat NO_OPTIMUM_COMPUTED_YET = new LocalizedFormat("no optimum computed yet"); /* keep */
        public static readonly LocalizedFormat NO_REGRESSORS = new LocalizedFormat("Regression model must include at least one regressor");
        public static readonly LocalizedFormat NO_RESULT_AVAILABLE = new LocalizedFormat("no result available");
        public static readonly LocalizedFormat NO_SUCH_MATRIX_ENTRY = new LocalizedFormat("no entry at indices ({0}, {1}) in a {2}x{3} matrix");
        public static readonly LocalizedFormat NULL_NOT_ALLOWED = new LocalizedFormat("null is not allowed"); /* keep */
        public static readonly LocalizedFormat ARRAY_ZERO_LENGTH_OR_NULL_NOTALLOWED = new LocalizedFormat("A null or zero length array not allowed");
        public static readonly LocalizedFormat COVARIANCE_MATRIX = new LocalizedFormat("covariance matrix"); /* keep */
        public static readonly LocalizedFormat DENOMINATOR = new LocalizedFormat("denominator"); /* keep */
        public static readonly LocalizedFormat DENOMINATOR_FORMAT = new LocalizedFormat("denominator format"); /* keep */
        public static readonly LocalizedFormat FRACTION = new LocalizedFormat("fraction"); /* keep */
        public static readonly LocalizedFormat FUNCTION = new LocalizedFormat("function"); /* keep */
        public static readonly LocalizedFormat IMAGINARY_FORMAT = new LocalizedFormat("imaginary format"); /* keep */
        public static readonly LocalizedFormat INPUT_ARRAY = new LocalizedFormat("input array"); /* keep */
        public static readonly LocalizedFormat NUMERATOR = new LocalizedFormat("numerator"); /* keep */
        public static readonly LocalizedFormat NUMERATOR_FORMAT = new LocalizedFormat("numerator format"); /* keep */
        public static readonly LocalizedFormat OBJECT_TRANSFORMATION = new LocalizedFormat("conversion exception in transformation"); /* keep */
        public static readonly LocalizedFormat REAL_FORMAT = new LocalizedFormat("real format"); /* keep */
        public static readonly LocalizedFormat WHOLE_FORMAT = new LocalizedFormat("whole format"); /* keep */
        public static readonly LocalizedFormat NUMBER_TOO_LARGE = new LocalizedFormat("{0} is larger than the maximum ({1})"); /* keep */
        public static readonly LocalizedFormat NUMBER_TOO_SMALL = new LocalizedFormat("{0} is smaller than the minimum ({1})"); /* keep */
        public static readonly LocalizedFormat NUMBER_TOO_LARGE_BOUND_EXCLUDED = new LocalizedFormat("{0} is larger than, or equal to, the maximum ({1})"); /* keep */
        public static readonly LocalizedFormat NUMBER_TOO_SMALL_BOUND_EXCLUDED = new LocalizedFormat("{0} is smaller than, or equal to, the minimum ({1})"); /* keep */
        public static readonly LocalizedFormat NUMBER_OF_SUCCESS_LARGER_THAN_POPULATION_SIZE = new LocalizedFormat("number of successes ({0}) must be less than or equal to population size ({1})");
        public static readonly LocalizedFormat NUMERATOR_OVERFLOW_AFTER_MULTIPLY = new LocalizedFormat("overflow, numerator too large after multiply: {0}");
        public static readonly LocalizedFormat N_POINTS_GAUSS_LEGENDRE_INTEGRATOR_NOT_SUPPORTED = new LocalizedFormat("{0} points Legendre-Gauss integrator not supported, number of points must be in the {1}-{2} range");
        public static readonly LocalizedFormat OBSERVED_COUNTS_ALL_ZERO = new LocalizedFormat("observed counts are all 0 in observed array {0}");
        public static readonly LocalizedFormat OBSERVED_COUNTS_BOTTH_ZERO_FOR_ENTRY = new LocalizedFormat("observed counts are both zero for entry {0}");
        public static readonly LocalizedFormat BOBYQA_BOUND_DIFFERENCE_CONDITION = new LocalizedFormat("the difference between the upper and lower bound must be larger than twice the initial trust region radius ({0})");
        public static readonly LocalizedFormat OUT_OF_BOUNDS_QUANTILE_VALUE = new LocalizedFormat("out of bounds quantile value: {0}, must be in (0, 100]");
        public static readonly LocalizedFormat OUT_OF_BOUND_SIGNIFICANCE_LEVEL = new LocalizedFormat("out of bounds significance level {0}, must be between {1} and {2}");
        public static readonly LocalizedFormat SIGNIFICANCE_LEVEL = new LocalizedFormat("significance level ({0})"); /* keep */
        public static readonly LocalizedFormat OUT_OF_ORDER_ABSCISSA_ARRAY = new LocalizedFormat("the abscissae array must be sorted in a strictly increasing order, but the {0}-th element is {1} whereas {2}-th is {3}");
        public static readonly LocalizedFormat OUT_OF_RANGE_ROOT_OF_UNITY_INDEX = new LocalizedFormat("out of range root of unity index {0} (must be in [{1};{2}])");
        public static readonly LocalizedFormat OUT_OF_RANGE = new LocalizedFormat("out of range"); /* keep */
        public static readonly LocalizedFormat OUT_OF_RANGE_SIMPLE = new LocalizedFormat("{0} out of [{1}, {2}] range"); /* keep */
        public static readonly LocalizedFormat OUT_OF_RANGE_LEFT = new LocalizedFormat("{0} out of ({1}, {2}] range");
        public static readonly LocalizedFormat OUT_OF_RANGE_RIGHT = new LocalizedFormat("{0} out of [{1}, {2}) range");
        public static readonly LocalizedFormat OUTLINE_BOUNDARY_LOOP_OPEN = new LocalizedFormat("an outline boundary loop is open");
        public static readonly LocalizedFormat OVERFLOW = new LocalizedFormat("overflow"); /* keep */
        public static readonly LocalizedFormat OVERFLOW_IN_FRACTION = new LocalizedFormat("overflow in fraction {0}/{1}, cannot negate");
        public static readonly LocalizedFormat OVERFLOW_IN_ADDITION = new LocalizedFormat("overflow in addition: {0} + {1}");
        public static readonly LocalizedFormat OVERFLOW_IN_SUBTRACTION = new LocalizedFormat("overflow in subtraction: {0} - {1}");
        public static readonly LocalizedFormat PERCENTILE_IMPLEMENTATION_CANNOT_ACCESS_METHOD = new LocalizedFormat("cannot access {0} method in percentile implementation {1}");
        public static readonly LocalizedFormat PERCENTILE_IMPLEMENTATION_UNSUPPORTED_METHOD = new LocalizedFormat("percentile implementation {0} does not support {1}");
        public static readonly LocalizedFormat PERMUTATION_EXCEEDS_N = new LocalizedFormat("permutation size ({0}) exceeds permuation domain ({1})"); /* keep */
        public static readonly LocalizedFormat POLYNOMIAL = new LocalizedFormat("polynomial"); /* keep */
        public static readonly LocalizedFormat POLYNOMIAL_INTERPOLANTS_MISMATCH_SEGMENTS = new LocalizedFormat("number of polynomial interpolants must match the number of segments ({0} != {1} - 1)");
        public static readonly LocalizedFormat POPULATION_LIMIT_NOT_POSITIVE = new LocalizedFormat("population limit has to be positive");
        public static readonly LocalizedFormat POSITION_SIZE_MISMATCH_INPUT_ARRAY = new LocalizedFormat("position {0} and size {1} don't fit to the size of the input array {2}");
        public static readonly LocalizedFormat POWER_NEGATIVE_PARAMETERS = new LocalizedFormat("cannot raise an integral value to a negative power ({0}^{1})");
        public static readonly LocalizedFormat PROPAGATION_DIRECTION_MISMATCH = new LocalizedFormat("propagation direction mismatch");
        public static readonly LocalizedFormat RANDOMKEY_MUTATION_WRONG_CLASS = new LocalizedFormat("RandomKeyMutation works only with RandomKeys, not {0}");
        public static readonly LocalizedFormat ROOTS_OF_UNITY_NOT_COMPUTED_YET = new LocalizedFormat("roots of unity have not been computed yet");
        public static readonly LocalizedFormat ROTATION_MATRIX_DIMENSIONS = new LocalizedFormat("a {0}x{1} matrix cannot be a rotation matrix");
        public static readonly LocalizedFormat ROW_INDEX_OUT_OF_RANGE = new LocalizedFormat("row index {0} out of allowed range [{1}, {2}]");
        public static readonly LocalizedFormat ROW_INDEX = new LocalizedFormat("row index ({0})"); /* keep */
        public static readonly LocalizedFormat SAME_SIGN_AT_ENDPOINTS = new LocalizedFormat("function values at endpoints do not have different signs, endpoints: [{0}, {1}], values: [{2}, {3}]");
        public static readonly LocalizedFormat SAMPLE_SIZE_EXCEEDS_COLLECTION_SIZE = new LocalizedFormat("sample size ({0}) exceeds collection size ({1})"); /* keep */
        public static readonly LocalizedFormat SAMPLE_SIZE_LARGER_THAN_POPULATION_SIZE = new LocalizedFormat("sample size ({0}) must be less than or equal to population size ({1})");
        public static readonly LocalizedFormat SIMPLEX_NEED_ONE_POINT = new LocalizedFormat("simplex must contain at least one point");
        public static readonly LocalizedFormat SIMPLE_MESSAGE = new LocalizedFormat("{0}");
        public static readonly LocalizedFormat SINGULAR_MATRIX = new LocalizedFormat("matrix is singular"); /* keep */
        public static readonly LocalizedFormat SINGULAR_OPERATOR = new LocalizedFormat("operator is singular");
        public static readonly LocalizedFormat SUBARRAY_ENDS_AFTER_ARRAY_END = new LocalizedFormat("subarray ends after array end");
        public static readonly LocalizedFormat TOO_LARGE_CUTOFF_SINGULAR_VALUE = new LocalizedFormat("cutoff singular value is {0}, should be at most {1}");
        public static readonly LocalizedFormat TOO_MANY_ELEMENTS_TO_DISCARD_FROM_ARRAY = new LocalizedFormat("cannot discard {0} elements from a {1} elements array");
        public static readonly LocalizedFormat TOO_MUCH_CANCELLATION = new LocalizedFormat("too much cancellation in a denominator");
        public static readonly LocalizedFormat TOO_MANY_REGRESSORS = new LocalizedFormat("too many regressors ({0}) specified, only {1} in the model");
        public static readonly LocalizedFormat TOO_SMALL_COST_RELATIVE_TOLERANCE = new LocalizedFormat("cost relative tolerance is too small ({0}), no further reduction in the sum of squares is possible");
        public static readonly LocalizedFormat TOO_SMALL_INTEGRATION_INTERVAL = new LocalizedFormat("too small integration interval: length = {0}");
        public static readonly LocalizedFormat TOO_SMALL_ORTHOGONALITY_TOLERANCE = new LocalizedFormat("orthogonality tolerance is too small ({0}), solution is orthogonal to the jacobian");
        public static readonly LocalizedFormat TOO_SMALL_PARAMETERS_RELATIVE_TOLERANCE = new LocalizedFormat("parameters relative tolerance is too small ({0}), no further improvement in the approximate solution is possible");
        public static readonly LocalizedFormat TRUST_REGION_STEP_FAILED = new LocalizedFormat("trust region step has failed to reduce Q");
        public static readonly LocalizedFormat TWO_OR_MORE_CATEGORIES_REQUIRED = new LocalizedFormat("two or more categories required, got {0}");
        public static readonly LocalizedFormat TWO_OR_MORE_VALUES_IN_CATEGORY_REQUIRED = new LocalizedFormat("two or more values required in each category, one has {0}");
        public static readonly LocalizedFormat UNABLE_TO_BRACKET_OPTIMUM_IN_LINE_SEARCH = new LocalizedFormat("unable to bracket optimum in line search");
        public static readonly LocalizedFormat UNABLE_TO_COMPUTE_COVARIANCE_SINGULAR_PROBLEM = new LocalizedFormat("unable to compute covariances: singular problem");
        public static readonly LocalizedFormat UNABLE_TO_FIRST_GUESS_HARMONIC_COEFFICIENTS = new LocalizedFormat("unable to first guess the harmonic coefficients");
        public static readonly LocalizedFormat UNABLE_TO_ORTHOGONOLIZE_MATRIX = new LocalizedFormat("unable to orthogonalize matrix in {0} iterations");
        public static readonly LocalizedFormat UNABLE_TO_PERFORM_QR_DECOMPOSITION_ON_JACOBIAN = new LocalizedFormat("unable to perform Q.R decomposition on the {0}x{1} jacobian matrix");
        public static readonly LocalizedFormat UNABLE_TO_SOLVE_SINGULAR_PROBLEM = new LocalizedFormat("unable to solve: singular problem");
        public static readonly LocalizedFormat UNBOUNDED_SOLUTION = new LocalizedFormat("unbounded solution");
        public static readonly LocalizedFormat UNKNOWN_MODE = new LocalizedFormat("unknown mode {0}, known modes: {1} ({2}), {3} ({4}), {5} ({6}), {7} ({8}), {9} ({10}) and {11} ({12})");
        public static readonly LocalizedFormat UNKNOWN_PARAMETER = new LocalizedFormat("unknown parameter {0}");
        public static readonly LocalizedFormat UNMATCHED_ODE_IN_EXPANDED_SET = new LocalizedFormat("ode does not match the main ode set in the extended set");
        public static readonly LocalizedFormat CANNOT_PARSE_AS_TYPE = new LocalizedFormat("string \"{0}\" unparseable (from position {1}) as an object of type {2}"); /* keep */
        public static readonly LocalizedFormat CANNOT_PARSE = new LocalizedFormat("string \"{0}\" unparseable (from position {1})"); /* keep */
        public static readonly LocalizedFormat UNPARSEABLE_3D_VECTOR = new LocalizedFormat("unparseable 3D vector: \"{0}\"");
        public static readonly LocalizedFormat UNPARSEABLE_COMPLEX_NUMBER = new LocalizedFormat("unparseable complex number: \"{0}\"");
        public static readonly LocalizedFormat UNPARSEABLE_REAL_VECTOR = new LocalizedFormat("unparseable real vector: \"{0}\"");
        public static readonly LocalizedFormat UNSUPPORTED_EXPANSION_MODE = new LocalizedFormat("unsupported expansion mode {0}, supported modes are {1} ({2}) and {3} ({4})");
        public static readonly LocalizedFormat UNSUPPORTED_OPERATION = new LocalizedFormat("unsupported operation"); /* keep */
        public static readonly LocalizedFormat ARITHMETIC_EXCEPTION = new LocalizedFormat("arithmetic exception"); /* keep */
        public static readonly LocalizedFormat ILLEGAL_STATE = new LocalizedFormat("illegal state"); /* keep */
        public static readonly LocalizedFormat USER_EXCEPTION = new LocalizedFormat("exception generated in user code"); /* keep */
        public static readonly LocalizedFormat URL_CONTAINS_NO_DATA = new LocalizedFormat("URL {0} contains no data");
        public static readonly LocalizedFormat VALUES_ADDED_BEFORE_CONFIGURING_STATISTIC = new LocalizedFormat("{0} values have been added before statistic is configured");
        public static readonly LocalizedFormat VECTOR_LENGTH_MISMATCH = new LocalizedFormat("vector length mismatch: got {0} but expected {1}");
        public static readonly LocalizedFormat VECTOR_MUST_HAVE_AT_LEAST_ONE_ELEMENT = new LocalizedFormat("vector must have at least one element");
        public static readonly LocalizedFormat WEIGHT_AT_LEAST_ONE_NON_ZERO = new LocalizedFormat("weigth array must contain at least one non-zero value");
        public static readonly LocalizedFormat WRONG_BLOCK_LENGTH = new LocalizedFormat("wrong array shape (block length = {0}, expected {1})");
        public static readonly LocalizedFormat WRONG_NUMBER_OF_POINTS = new LocalizedFormat("{0} points are required, got only {1}");
        public static readonly LocalizedFormat NUMBER_OF_POINTS = new LocalizedFormat("number of points ({0})"); /* keep */
        public static readonly LocalizedFormat ZERO_DENOMINATOR = new LocalizedFormat("denominator must be different from 0");
        public static readonly LocalizedFormat ZERO_DENOMINATOR_IN_FRACTION = new LocalizedFormat("zero denominator in fraction {0}/{1}");
        public static readonly LocalizedFormat ZERO_FRACTION_TO_DIVIDE_BY = new LocalizedFormat("the fraction to divide by must not be zero: {0}/{1}");
        public static readonly LocalizedFormat ZERO_NORM = new LocalizedFormat("zero norm");
        public static readonly LocalizedFormat ZERO_NORM_FOR_ROTATION_AXIS = new LocalizedFormat("zero norm for rotation axis");
        public static readonly LocalizedFormat ZERO_NORM_FOR_ROTATION_DEFINING_VECTOR = new LocalizedFormat("zero norm for rotation defining vector");
        public static readonly LocalizedFormat ZERO_NOT_ALLOWED = new LocalizedFormat("zero not allowed here");

        /// <summary>
        /// Source english format.
        /// </summary>
        private readonly string sourceFormat;

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="sourceFormat">The english format to use when no localized version is available.</param>
        private LocalizedFormat(string sourceFormat)
        {
            this.sourceFormat = sourceFormat;
        }

        public string SourceString
        {
            get { return sourceFormat; }
        }

        public string GetLocalizedString(System.Globalization.CultureInfo cultureInfo)
        {
            return LocalizedFormats.ResourceManager.GetString(sourceFormat, cultureInfo);
        }
    }
}
