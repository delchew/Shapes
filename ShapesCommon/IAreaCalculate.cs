namespace ShapesCommon
{
    /// <summary>
    /// Entityes inherited this interface can calculate its area
    /// </summary>
    public interface IAreaCalculate
    {
        /// <summary>
        /// Calculate entity area
        /// </summary>
        /// <returns>Entity area</returns>
        double GetArea();
    }
}
