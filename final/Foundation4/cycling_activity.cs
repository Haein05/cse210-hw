public class CyclingActivity :Activity
{

    public CyclingActivity(DateTime date, int length,float distance) : base(date, length,distance)
    {
      this.kg_distance= distance; 
        kg_name = "Cycling";
    }
    public override float GetPace()
      {
           return   kg_length/kg_distance;
      }

    public override float getDistance()
      {
            return kg_distance;
      }

    public override float GetSpeed()
      {
           return   (kg_distance/kg_length)*60;
      }

}