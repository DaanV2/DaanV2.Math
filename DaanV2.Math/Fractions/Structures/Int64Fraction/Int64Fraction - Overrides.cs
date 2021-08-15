/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public partial struct Int64Fraction : IEquatable<Int64Fraction> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Int64Fraction fraction && this.Equals(fraction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Int64Fraction other) {
            return this.Denominator == other.Denominator &&
                   this.Numerator == other.Numerator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Denominator, this.Numerator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.Numerator}/{this.Denominator}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(Int64Fraction left, Int64Fraction right) {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(Int64Fraction left, Int64Fraction right) {
            return !(left == right);
        }
    }
}
