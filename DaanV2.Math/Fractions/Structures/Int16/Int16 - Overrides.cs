/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct Int16Fraction : IEquatable<Int16Fraction> {
        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns>True or false if the object equal each other</returns>
        public override Boolean Equals(Object obj) {
            if(obj is Int16Fraction fraction && this.Equals(fraction)) {
                return true;
            }
            else if (obj is IFraction<Int16> ifrac && this.Equals(ifrac)) {
                return true;
            }

            return false;
        }

        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>True or false if the object equal each other</returns>
        public Boolean Equals(Int16Fraction other) {
            if (this.Denominator == other.Denominator && this.Numerator == other.Numerator) {
                return true;
            }

            return false;
        }

        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>True or false if the object equal each other</returns>
        public Boolean Equals(IFraction<Int16> other) {
            if (this.Denominator == other.Denominator && this.Numerator == other.Numerator) {
                return true;
            }

            return false;
        }

        /// <summary>Checks whenever the given object equals value to this instance</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>True or false if the object equal each other</returns>
        public Boolean EqualsValue(Int16Fraction other) {
            Int16Fraction temp = Math.Substract(this, other);

            if (temp.Numerator == 0) return true;

            return false;
        }

        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="other">The object to compare to</param>
        /// <param name="error">The allowed range of error</param>
        /// <returns>True or false if the object equal each other</returns>
        public Boolean EqualsValue(Int16Fraction other, Int16 error) {
            Int16Fraction temp = Math.Substract(this, other);

            if (temp.Numerator <= error) return true;
            if (temp.Numerator + error >= 0) return true;

            return false;
        }

        /// <summary>Returns the hashcode of this instance</summary>
        /// <returns>A Int32 representing the hashcode</returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Denominator, this.Numerator);
        }

        /// <summary>Returns the string representation of this instance</summary>
        /// <returns>A string representration of this object</returns>
        public override String ToString() {
            return $"{this.Numerator}/{this.Denominator}";
        }

        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>True or false is the object are equal to each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(Int16Fraction left, Int16Fraction right) {
            return left.Equals(right);
        }
        
        /// <summary>Checks whenever the given object equals to this instance</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>True or false is the object are equal to each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(Int16Fraction left, IFraction<Int16> right) {
            return left.Equals(right);
        }

        /// <summary>Checks whenever the given object not equals to this instance</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>True or false is the object are not equal to each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(Int16Fraction left, Int16Fraction right) {
            return !(left == right);
        }

        /// <summary>Checks whenever the given object not equals to this instance</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>True or false is the object are not equal to each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(Int16Fraction left, IFraction<Int16> right) {
            return !(left == right);
        }
    }
}
