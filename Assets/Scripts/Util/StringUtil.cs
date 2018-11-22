/**
 * 
 * Utility functions for string manipulation.
 * 
 */

public static class StringUtil {

    /**
     * Swaps characters in a string
     */
    public static string SwapCharacters(string value, int position1, int position2) {

        char[] array = value.ToCharArray();
        char temp = array[position1];

        array[position1] = array[position2];
        array[position2] = temp;

        return new string(array);
    }
}