using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGDiscordBot {
    public static class Extensions {
        public static T[] Slice<T>(this T[] source, int index, int length) {
            T[] slice = new T[length];
            Array.Copy(source, index, slice, 0, length);
            return slice;
        }

        /// <summary>
        /// Splits an array into several smaller arrays.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to split.</param>
        /// <param name="size">The size of the smaller arrays.</param>
        /// usage:
        /// var array = new byte[] {10, 20, 30, 40, 50};
        /// var splitArray = array.Split(2);
        /// <returns>An array containing smaller arrays.</returns>
        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] array, int size) {
            for (var i = 0; i < (float)array.Length / size; i++) {
                yield return array.Skip(i * size).Take(size);
            }
        }

        public static T[,] ToSquare2D<T>(this T[] array, int size) {
            var buffer = new T[(int)Math.Ceiling((double)array.Length / size), size];
            for (var i = 0; i < (float)array.Length / size; i++) {
                for (var j = 0; j < size; j++) {
                    buffer[i, j] = array[i + j];
                }
            }
            return buffer;
        }

    }
}
