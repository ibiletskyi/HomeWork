namespace Task5
{
    public class ComplexNumber
    {
        #region fields
        private float real;
        private float imaginary;
        #endregion

        #region Constructor
        public ComplexNumber(float real, float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            var sign = this.imaginary >= 0 ? "+" : "";
            return $"{real}{sign}{imaginary}i";
        }

        public override bool Equals(object obj)
        {
            var other = obj as ComplexNumber;
            if (other == null) return false;

            return (this.real == other.real) && (this.imaginary == other.imaginary);
        }

        public override int GetHashCode()
        {
            return string.Format("{0}+{1}i", this.real, this.imaginary).GetHashCode();
        }
        #endregion

        #region operators
        public static bool operator ==(ComplexNumber me, ComplexNumber other) => Equals(me, other);
        public static bool operator !=(ComplexNumber me, ComplexNumber other) => !Equals(me, other);

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                (c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary),
                (c2.real * c1.imaginary - c2.imaginary * c1.real) / (c2.real * c2.real + c2.imaginary * c2.imaginary));
        }
        #endregion
    }
}
