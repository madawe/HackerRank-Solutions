// Add your code here
public Difference(int[] el)
{
    this.elements = el;
}
public void computeDifference()
{
    maximumDifference = elements.Max() - elements.Min();
}